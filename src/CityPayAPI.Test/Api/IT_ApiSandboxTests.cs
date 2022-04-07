using System;
using CityPayAPI.Api;
using CityPayAPI.Model;
using CityPayAPI.Client;
using Newtonsoft.Json;
using Xunit;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;

namespace CityPayAPI.Test
{
    public class IT_ApiSandboxTests : IDisposable
    {
        private string _cpClientId = Environment.GetEnvironmentVariable("CP_CLIENT_ID");
        private string _cpLicenceKey = Environment.GetEnvironmentVariable("CP_LICENCE_KEY");
        private int _cpMerchantId = int.Parse(Environment.GetEnvironmentVariable("CP_MERCHANT_ID"));

        private Configuration _configuration;

        public IT_ApiSandboxTests()
        {
            if (_cpClientId == null)
                throw new ArgumentException("No CP_CLIENT_ID value set");
            if (_cpLicenceKey == null)
                throw new ArgumentException("No CP_LICENCE_KEY value set");
            // if (_cpMerchantId == null)
            //     throw new ArgumentException("No CP_MERCHANT_ID value set");

            _configuration = new Configuration();
            _configuration.BasePath = "https://sandbox.citypay.com/v6";
            _configuration.AddApiKey("cp-api-key", new ApiKey(_cpClientId, _cpLicenceKey).GenerateKey());
        }

        public void Dispose()
        {
        }

        [Fact]
        public void PingTest()
        {
            var api = new OperationalApi(_configuration);
            var ack = api.PingRequest(new Ping("it_test_cs"));
            Assert.Equal("044", ack.Code);
            Assert.Equal("it_test_cs", ack.Identifier);
            Assert.Equal("Ping OK", ack.Message);
        }

        [Fact]
        public void ListMerchantsTest()
        {
            var api = new OperationalApi(_configuration);
            var merchants = api.ListMerchantsRequest(_cpClientId);
            Assert.Equal(_cpClientId, merchants.Clientid);
        }

        [Fact]
        public void AuthoriseTest()
        {
            var id = Guid.NewGuid().ToString();
            var api = new PaymentProcessingApi(_configuration);
            var decision = api.AuthorisationRequest(new AuthRequest(
                amount: 1395,
                cardnumber: "4000 0000 0000 0002",
                expmonth: 12,
                expyear: 2030,
                csc: "012",
                identifier: id,
                merchantid: _cpMerchantId,
                threedsecure: new ThreeDSecure(
                    tdsPolicy: "2"
                )
            ));

            Assert.True(decision.IsAuthResponse());
            Assert.False(decision.IsRequestChallenged());
            Assert.False(decision.IsAuthenRequired());
            var response = decision.AuthResponse;

            Assert.Equal("001", response.ResultCode);
            Assert.Equal(id, response.Identifier);
            Assert.Equal("A12345", response.Authcode);
            Assert.Equal(1395, response.Amount);
            
            Boolean isValidDigest = Utils.Digest.validateDigest(response, _cpLicenceKey);
            
            Assert.True(isValidDigest);
        }

        [Fact]
        public void CardholderAccountTests()
        {
            var guid = Guid.NewGuid().ToString();
            var api = new CardHolderAccountApi(_configuration);
            var result = api.AccountCreate(new AccountCreate(guid, new ContactDetails(
                address1: "7 Esplanade",
                area: "St Helier",
                company: "CityPay Limited",
                country: "JE",
                email: "dev@citypay.com",
                firstname: "Integration",
                lastname: "Test",
                postcode: "JE2 3QA"
            )));

            Assert.Equal(guid, result.AccountId);
            Assert.Equal("7 Esplanade", result.Contact.Address1);

            result = api.AccountCardRegisterRequest(guid, new RegisterCard(
                cardnumber: "4000 0000 0000 0002",
                expmonth: 12,
                expyear: 2030
            ));

            Assert.Equal(guid, result.AccountId);
            Assert.Single(result.Cards);
            Assert.Equal(12, result.Cards[0].Expmonth);
            Assert.Equal(2030, result.Cards[0].Expyear);

            result = api.AccountRetrieveRequest(guid);
            Assert.Equal(guid, result.AccountId);
            Assert.Equal("7 Esplanade", result.Contact.Address1);
            Assert.Single(result.Cards);
            Assert.Equal(12, result.Cards[0].Expmonth);
            Assert.Equal(2030, result.Cards[0].Expyear);

            var identifier = Guid.NewGuid().ToString();
            var decision = api.ChargeRequest(new ChargeRequest(
                amount: 7801,
                identifier: identifier,
                merchantid: _cpMerchantId,
                token: result.Cards[0].Token,
                csc: "012",
                threedsecure: new ThreeDSecure(
                    tdsPolicy: "2"
                )
            ));

            Assert.False(decision.IsRequestChallenged());
            Assert.False(decision.IsAuthenRequired());
            Assert.True(decision.IsAuthResponse());

            var response = decision.AuthResponse;
            Assert.Equal("001", response.ResultCode);
            Assert.Equal(identifier, response.Identifier);
            Assert.Equal("A12345", response.Authcode);
            Assert.Equal(7801, response.Amount);

            var ack = api.AccountDeleteRequest(guid);
            Assert.Equal("001", ack.Code);
        }
        
        public class Cres
        {
            public string AcsTransID { get; set; }
            public string MessageType { get; set; }
            public string MessageVersion { get; set; }
            public string ThreeDSServerTransID { get; set; }
            public string TransStatus { get; set; }
            
            public Cres(string acsTransID, string messageType, string messageVersion, string threeDSServerTransID, string transStatus)
            {
                AcsTransID = acsTransID;
                MessageType = messageType;
                MessageVersion = messageVersion;
                ThreeDSServerTransID = threeDSServerTransID;
                TransStatus = transStatus;
            }
            // Other properties, methods, events...
        }

        [Fact]
        public void Authorise3DSv2Test()
        {
            var id = Guid.NewGuid().ToString();
            var api = new PaymentProcessingApi(_configuration);
            var decision = api.AuthorisationRequest(new AuthRequest(
                amount: 1595,
                cardnumber: "4000 0000 0000 0002",
                expmonth: 12,
                expyear: 2030,
                csc: "123",
                identifier: id,
                merchantid: _cpMerchantId,
                transType: "A", //Enforcing Ecom Transaction
                threedsecure: new ThreeDSecure(
                    cpBx:
                    "eyJhIjoiRkFwSCIsImMiOjI0LCJpIjoid3dIOTExTlBKSkdBRVhVZCIsImoiOmZhbHNlLCJsIjoiZW4tVVMiLCJoIjoxNDQwLCJ3IjoyNTYwLCJ0IjowLCJ1IjoiTW96aWxsYS81LjAgKE1hY2ludG9zaDsgSW50ZWwgTWFjIE9TIFggMTFfMl8zKSBBcHBsZVdlYktpdC81MzcuMzYgKEtIVE1MLCBsaWtlIEdlY2tvKSBDaHJvbWUvODkuMC40Mzg5LjgyIFNhZmFyaS81MzcuMzYiLCJ2IjoiMS4wLjAifQ==",
                    merchantTermurl: "https://citypay.com/acs/return"
                )
            ));

            Assert.False(decision.IsAuthResponse());
            Assert.True(decision.IsRequestChallenged());
            Assert.False(decision.IsAuthenRequired());
            var response = decision.RequestChallenged;
            var creq = response.Creq;
            var threedserverTransId = response.ThreedserverTransId;

            Assert.NotEmpty(response.AcsUrl);
            Assert.NotEmpty(creq);
            Assert.NotEmpty(threedserverTransId);
            
            if (creq == string.Empty) return;
            
            // Sending Creq 
            var client = new HttpClient();
            client.BaseAddress = new Uri("https://sandbox.citypay.com/3dsv2/");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders
                .Accept
                .Add(new MediaTypeWithQualityHeaderValue("application/json"));

            var content = new
            {
                threeDSSessionData = response.ThreedserverTransId,
                creq = response.Creq
            };

            var jsonContent = JsonConvert.SerializeObject(content);
            var stringContent = new StringContent(jsonContent.ToString(), Encoding.UTF8,
                "application/json");
            var res = client.PostAsync("acs", stringContent).Result;

            Assert.True(res.IsSuccessStatusCode);
            
            if (res.IsSuccessStatusCode)
            {
                var cResString = res.Content.ReadAsStringAsync().Result;
                
                var cRes = JsonConvert.DeserializeObject<Cres>(cResString);
                
                Assert.NotEmpty(cRes.AcsTransID);
                Assert.NotEmpty(cRes.MessageType);
                Assert.NotEmpty(cRes.MessageVersion);
                Assert.NotEmpty(cRes.ThreeDSServerTransID);
                Assert.NotEmpty(cRes.TransStatus);

                var cResAuthRequest =
                    new CResAuthRequest(Convert.ToBase64String(Encoding.UTF8.GetBytes(cResString)));

                var cResRequestResponse = api.CResRequest(cResAuthRequest);
                Assert.Equal(1595, cResRequestResponse.Amount);
                Assert.Equal("A12345",cResRequestResponse.Authcode);
                Assert.Equal("Y", cResRequestResponse.AuthenResult);
                Assert.True(cResRequestResponse.Authorised);
            }
        }
    }
}