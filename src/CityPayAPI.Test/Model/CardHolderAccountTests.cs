/* 
 * CityPay Payment API
 *
 *  This CityPay API is a HTTP RESTful payment API used for direct server to server transactional processing. It provides a number of payment mechanisms including: Internet, MOTO, Continuous Authority transaction processing, 3-D Secure decision handling using RFA Secure, Authorisation, Refunding, Pre-Authorisation, Cancellation/Voids and Completion processing. The API is also capable of tokinsed payments using Card Holder Accounts.  ## Compliance and Security <aside class=\"notice\">   Before we begin a reminder that your application will need to adhere to PCI-DSS standards to operate safely   and to meet requirements set out by Visa and MasterCard and the PCI Security Standards Council including: </aside>  * Data must be collected using TLS version 1.2 using [strong cryptography](#enabled-tls-ciphers). We will not accept calls to our API at   lower grade encryption levels. We regularly scan our TLS endpoints for vulnerabilities and perform TLS assessments   as part of our compliance program. * The application must not store sensitive card holder data (CHD) such as the card security code (CSC) or   primary access number (PAN) * The application must not display the full card number on receipts, it is recommended to mask the PAN   and show the last 4 digits. The API will return this for you for ease of receipt creation * If you are developing a website, you will be required to perform regular scans on the network where you host the   application to meet your compliance obligations * You will be required to be PCI Compliant and the application must adhere to the security standard. Further information   is available from [https://www.pcisecuritystandards.org/](https://www.pcisecuritystandards.org/) * The API verifies that the request is for a valid account and originates from a trusted source using the remote IP   address. Our application firewalls analyse data that may be an attempt to break a large number of security common   security vulnerabilities. 
 *
 * Contact: support@citypay.com
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using Xunit;

using System;
using System.Linq;
using System.IO;
using System.Collections.Generic;
using CityPayAPI.Api;
using CityPayAPI.Model;
using CityPayAPI.Client;
using System.Reflection;
using Newtonsoft.Json;

namespace CityPayAPI.Test
{
    /// <summary>
    ///  Class for testing CardHolderAccount
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class CardHolderAccountTests : IDisposable
    {

        private CardHolderAccount instance;

        public CardHolderAccountTests()
        {
            string json = @"
{
            ""account_id"": ""abc123"",
            ""cards"": [{
                ""Bincommercial"": false,
                ""Bincorporate"": false,
                ""Bincountryissued"": ""GBR"",
                ""Bincurrency"": ""GBP"",
                ""Bindescription"": ""Visa Classic"",
                ""Bineu"": false,
                ""cardid"": ""2U1XV3PJSeUXFNzXidACn2TyCzAK"",
                ""cardstatus"": ""ACTIVE"",
                ""default"": true,
                ""expmonth"": 7,
                ""expyear"": 2022,
                ""label"": ""TestVisa/0002"",
                ""label2"": ""TestVisa/0002,Exp:7/2022"",
                ""scheme"": ""TestVisa"",
                ""token"": ""ctPCzxq4WxEwWbkG7whRPLRCG27vYFNzsEDNihYmDwqsBc5QEXnFRvq2j5oRyb56ErRVEQaBN7PFMEDtjQQXDQpfxKkp3AxbyeGo61RhKBjFTFegaP4LBZUxFZimsXW8Deae9VyhWSgS2o8AXzTJU9UP3bo8kRcpataxuH3fJj3JHDnyeZt""
            }],
            ""contact"": {
                ""address1"": ""7 Esplanade"",
                ""address2"": """",
                ""address3"": """",
                ""area"": ""St Helier"",
                ""company"": ""CityPay Ltd"",
                ""country"": ""JE"",
                ""email"": ""support@citypay.com"",
                ""firstname"": ""Joe"",
                ""lastname"": ""Wicks"",
                ""mobile_no"": ""077112123456"",
                ""postcode"": ""JE2 3QA"",
                ""telephone_no"": ""+4415341234567"",
                ""title"": ""Mr""},
            ""date_created"": ""2020-08-01T09:15:24Z"",
            ""default_card_id"": ""2U1XV3PJSeUXFNzXidACn2TyCzAK"",
            ""default_card_index"": 0,
            ""status"": ""ACTIVE"",
            ""unique_id"": ""Ew3BKeWNdL3qKQU7XK7Sbt2eAL5WFW4AfoASDSA""
        }

";
            instance = (CardHolderAccount) JsonConvert.DeserializeObject(json, typeof(CardHolderAccount));
        }

        public void Dispose()
        {
        }

        /// <summary>
        /// Test an instance of CardHolderAccount
        /// </summary>
        [Fact]
        public void CardHolderAccountInstanceTest()
        {
            Assert.IsType<CardHolderAccount>(instance);
        }


        /// <summary>
        /// Test the property 'AccountId'
        /// </summary>
        [Fact]
        public void AccountTest()
        {
            Assert.Equal("abc123", instance.AccountId);
            Assert.False(instance.Cards[0].BinCommercial);
            Assert.False(instance.Cards[0].BinCorporate);
            Assert.Equal("GBR", instance.Cards[0].BinCountryIssued);
            Assert.Equal("GBP", instance.Cards[0].BinCurrency);
            Assert.Equal("Visa Classic", instance.Cards[0].BinDescription);
            Assert.False(instance.Cards[0].BinEu);
            Assert.Equal( "2U1XV3PJSeUXFNzXidACn2TyCzAK", instance.Cards[0].CardId);
            Assert.Equal( "ACTIVE", instance.Cards[0].CardStatus);
            Assert.True( instance.Cards[0].VarDefault);
            Assert.Equal( 7, instance.Cards[0].Expmonth);
            Assert.Equal( 2022, instance.Cards[0].Expyear);
            Assert.Equal( "TestVisa/0002", instance.Cards[0].Label);
            Assert.Equal("TestVisa/0002,Exp:7/2022", instance.Cards[0].Label2);
            Assert.Equal("TestVisa", instance.Cards[0].Scheme);
            Assert.Equal( "ctPCzxq4WxEwWbkG7whRPLRCG27vYFNzsEDNihYmDwqsBc5QEXnFRvq2j5oRyb56ErRVEQaBN7PFMEDtjQQXDQpfxKkp3AxbyeGo61RhKBjFTFegaP4LBZUxFZimsXW8Deae9VyhWSgS2o8AXzTJU9UP3bo8kRcpataxuH3fJj3JHDnyeZt", instance.Cards[0].Token);
            Assert.Equal( "7 Esplanade", instance.Contact.Address1);
            Assert.Equal( "", instance.Contact.Address2);
            Assert.Equal( "", instance.Contact.Address3);
            Assert.Equal( "St Helier", instance.Contact.Area);
            Assert.Equal( "CityPay Ltd", instance.Contact.Company);
            Assert.Equal( "JE", instance.Contact.Country);
            Assert.Equal( "support@citypay.com", instance.Contact.Email);
            Assert.Equal( "Joe", instance.Contact.Firstname);
            Assert.Equal( "Wicks", instance.Contact.Lastname);
            Assert.Equal( "077112123456", instance.Contact.MobileNo);
            Assert.Equal( "JE2 3QA", instance.Contact.Postcode);
            Assert.Equal( "+4415341234567", instance.Contact.TelephoneNo);
            Assert.Equal( "Mr", instance.Contact.Title);
            Assert.Equal( "2020-08-01T09:15:24", instance.DateCreated.ToString("yyyy-MM-ddTHH:mm:ss"));
            Assert.Equal( "2U1XV3PJSeUXFNzXidACn2TyCzAK", instance.DefaultCardId);
            Assert.Equal( 0, instance.DefaultCardIndex);
            Assert.Equal( "ACTIVE", instance.Status);
            Assert.Equal( "Ew3BKeWNdL3qKQU7XK7Sbt2eAL5WFW4AfoASDSA", instance.UniqueId);
        }
        
    }

}
