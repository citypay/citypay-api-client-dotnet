using System;
using CityPayAPI.Api;
using CityPayAPI.Model;
using CityPayAPI.Client;
using System.Reflection;
using Newtonsoft.Json;
using Xunit;

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
            if (_cpMerchantId == null)
                throw new ArgumentException("No CP_MERCHANT_ID value set");

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
                merchantid: _cpMerchantId
            ));

            Assert.True(decision.IsAuthResponse());
            Assert.False(decision.IsRequestChallenged());
            Assert.False(decision.IsAuthenRequired());
            var response = decision.AuthResponse;

            Assert.Equal("001", response.ResultCode);
            Assert.Equal(id, response.Identifier);
            Assert.Equal("A12345", response.Authcode);
            Assert.Equal(1395, response.Amount);
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
                csc: "012"
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
    }
}
