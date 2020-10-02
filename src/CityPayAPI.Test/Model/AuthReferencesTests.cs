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
    ///  Class for testing AuthReferences
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class AuthReferencesTests : IDisposable
    {
        private AuthReferences instance;

        public AuthReferencesTests()
        {
            string json = @"
{  ""auths"": [
            {
                ""amount"": ""0.12"",
                ""amount_value"": 12,
                ""atrn"": null,
                ""authcode"": ""A12345"",
                ""batchno"": null,
                ""currency"": ""GBP"",
                ""datetime"": ""2020-07-21T15:55:04Z"",
                ""identifier"": ""TestingAPI"",
                ""maskedpan"": ""400000******0000"",
                ""merchantid"": 12345678,
                ""result"": ""Accepted"",
                ""trans_status"": ""O"",
                ""trans_type"": ""S"",
                ""transno"": 88
            }
            ]
        }
";
            instance = (AuthReferences) JsonConvert.DeserializeObject(json, typeof(AuthReferences));
        }

        public void Dispose()
        {
        }

        /// <summary>
        /// Test an instance of AuthReferences
        /// </summary>
        [Fact]
        public void AuthReferencesInstanceTest()
        {
            Assert.IsType<AuthReferences>(instance);
        }


        /// <summary>
        /// Test the property 'Auths'
        /// </summary>
        [Fact]
        public void AuthsTest()
        {
            Assert.Equal("0.12", instance.Auths[0].Amount);
            Assert.Equal(12, instance.Auths[0].AmountValue);
            Assert.Null(instance.Auths[0].Atrn);
            Assert.Equal("A12345", instance.Auths[0].Authcode);
            Assert.Null(instance.Auths[0].Batchno);
            Assert.Equal("GBP", instance.Auths[0].Currency);
            Assert.Equal("2020-07-21T15:55:04", instance.Auths[0].Datetime.ToString("yyyy-MM-ddTHH:mm:ss"));
            Assert.Equal("TestingAPI", instance.Auths[0].Identifier);
            Assert.Equal("400000******0000", instance.Auths[0].Maskedpan);
            Assert.Equal(12345678, instance.Auths[0].Merchantid);
            Assert.Equal("Accepted", instance.Auths[0].Result);
            Assert.Equal("O", instance.Auths[0].TransStatus);
            Assert.Equal("S", instance.Auths[0].TransType);
            Assert.Equal(88, instance.Auths[0].Transno);
        }
    }
}
