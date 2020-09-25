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
    ///  Class for testing ListMerchantsResponse
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class ListMerchantsResponseTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for ListMerchantsResponse
        private ListMerchantsResponse instance;

        public ListMerchantsResponseTests()
        {
            string json = @"
{
            ""client_name"": ""CityPay Demo"",
            ""clientid"": ""PC123456"",
            ""merchants"": [
            {
                ""currency"": ""GBP"",
                ""merchantid"": 12345678,
                ""name"": ""CityPay One"",
                ""status"": ""T"",
                ""status_label"": ""Test""
            },
            {
                ""currency"": ""GBP"",
                ""merchantid"": 87654321,
                ""name"": ""CityPay Two"",
                ""status"": ""T"",
                ""status_label"": ""Test""
            }
            ]
    }
";
            instance = (ListMerchantsResponse) JsonConvert.DeserializeObject(json, typeof(ListMerchantsResponse));
        }

        public void Dispose()
        {
        }

        /// <summary>
        /// Test an instance of ListMerchantsResponse
        /// </summary>
        [Fact]
        public void ListMerchantsResponseInstanceTest()
        {
            Assert.IsType<ListMerchantsResponse>(instance);
        }


        /// <summary>
        /// Test the property 'ClientName'
        /// </summary>
        [Fact]
        public void ClientNameTest()
        {
            Assert.Equal("CityPay Demo", instance.ClientName);
        }
        /// <summary>
        /// Test the property 'Clientid'
        /// </summary>
        [Fact]
        public void ClientidTest()
        {
            Assert.Equal("PC123456", instance.Clientid);
        }
        /// <summary>
        /// Test the property 'Merchants'
        /// </summary>
        [Fact]
        public void MerchantsTest()
        {
            Assert.Equal(2, instance.Merchants.Count);

            Assert.Equal("GBP", instance.Merchants[0].Currency); 
            Assert.Equal(12345678, instance.Merchants[0].Merchantid);
            Assert.Equal("CityPay One", instance.Merchants[0].Name);
            Assert.Equal("T", instance.Merchants[0].Status);
            Assert.Equal("Test", instance.Merchants[0].StatusLabel);

            Assert.Equal("GBP", instance.Merchants[1].Currency); 
            Assert.Equal(87654321, instance.Merchants[1].Merchantid);
            Assert.Equal("CityPay Two", instance.Merchants[1].Name);
            Assert.Equal("T", instance.Merchants[1].Status);
            Assert.Equal("Test", instance.Merchants[1].StatusLabel);

                
        }

    }

}
