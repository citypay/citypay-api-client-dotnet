/* 
 * CityPay Payment API
 *
 *  This CityPay API is a HTTP RESTful payment API used for direct server to server transactional processing. It provides a number of payment mechanisms including: Internet, MOTO, Continuous Authority transaction processing, 3-D Secure decision handling using RFA Secure, Authorisation, Refunding, Pre-Authorisation, Cancellation/Voids and Completion processing. The API is also capable of tokinsed payments using Card Holder Accounts.  ## Compliance and Security <aside class=\"notice\">   Before we begin a reminder that your application will need to adhere to PCI-DSS standards to operate safely   and to meet requirements set out by Visa and MasterCard and the PCI Security Standards Council including: </aside>  * Data must be collected using TLS version 1.2 using [strong cryptography](#enabled-tls-ciphers). We will not accept calls to our API at   lower grade encryption levels. We regularly scan our TLS endpoints for vulnerabilities and perform TLS assessments   as part of our compliance program. * The application must not store sensitive card holder data (CHD) such as the card security code (CSC) or   primary access number (PAN) * The application must not display the full card number on receipts, it is recommended to mask the PAN   and show the last 4 digits. The API will return this for you for ease of receipt creation * If you are developing a website, you will be required to perform regular scans on the network where you host the   application to meet your compliance obligations * You will be required to be PCI Compliant and the application must adhere to the security standard. Further information   is available from [https://www.pcisecuritystandards.org/](https://www.pcisecuritystandards.org/) * The API verifies that the request is for a valid account and originates from a trusted source using the remote IP   address. Our application firewalls analyse data that may be an attempt to break a large number of security common   security vulnerabilities. 
 *
 * The version of the OpenAPI document: 6.0.0.BETA
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
    ///  Class for testing AuthResponse
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class AuthResponseTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for AuthResponse
        //private AuthResponse instance;

        public AuthResponseTests()
        {
            // TODO uncomment below to create an instance of AuthResponse
            //instance = new AuthResponse();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of AuthResponse
        /// </summary>
        [Fact]
        public void AuthResponseInstanceTest()
        {
            // TODO uncomment below to test "IsInstanceOfType" AuthResponse
            //Assert.IsInstanceOfType<AuthResponse> (instance, "variable 'instance' is a AuthResponse");
        }


        /// <summary>
        /// Test the property 'Amount'
        /// </summary>
        [Fact]
        public void AmountTest()
        {
            // TODO unit test for the property 'Amount'
        }
        /// <summary>
        /// Test the property 'Atrn'
        /// </summary>
        [Fact]
        public void AtrnTest()
        {
            // TODO unit test for the property 'Atrn'
        }
        /// <summary>
        /// Test the property 'Atsd'
        /// </summary>
        [Fact]
        public void AtsdTest()
        {
            // TODO unit test for the property 'Atsd'
        }
        /// <summary>
        /// Test the property 'Authcode'
        /// </summary>
        [Fact]
        public void AuthcodeTest()
        {
            // TODO unit test for the property 'Authcode'
        }
        /// <summary>
        /// Test the property 'AuthenResult'
        /// </summary>
        [Fact]
        public void AuthenResultTest()
        {
            // TODO unit test for the property 'AuthenResult'
        }
        /// <summary>
        /// Test the property 'Authorised'
        /// </summary>
        [Fact]
        public void AuthorisedTest()
        {
            // TODO unit test for the property 'Authorised'
        }
        /// <summary>
        /// Test the property 'AvsResult'
        /// </summary>
        [Fact]
        public void AvsResultTest()
        {
            // TODO unit test for the property 'AvsResult'
        }
        /// <summary>
        /// Test the property 'BinCommercial'
        /// </summary>
        [Fact]
        public void BinCommercialTest()
        {
            // TODO unit test for the property 'BinCommercial'
        }
        /// <summary>
        /// Test the property 'BinDebit'
        /// </summary>
        [Fact]
        public void BinDebitTest()
        {
            // TODO unit test for the property 'BinDebit'
        }
        /// <summary>
        /// Test the property 'BinDescription'
        /// </summary>
        [Fact]
        public void BinDescriptionTest()
        {
            // TODO unit test for the property 'BinDescription'
        }
        /// <summary>
        /// Test the property 'Cavv'
        /// </summary>
        [Fact]
        public void CavvTest()
        {
            // TODO unit test for the property 'Cavv'
        }
        /// <summary>
        /// Test the property 'Context'
        /// </summary>
        [Fact]
        public void ContextTest()
        {
            // TODO unit test for the property 'Context'
        }
        /// <summary>
        /// Test the property 'CscResult'
        /// </summary>
        [Fact]
        public void CscResultTest()
        {
            // TODO unit test for the property 'CscResult'
        }
        /// <summary>
        /// Test the property 'Currency'
        /// </summary>
        [Fact]
        public void CurrencyTest()
        {
            // TODO unit test for the property 'Currency'
        }
        /// <summary>
        /// Test the property 'Datetime'
        /// </summary>
        [Fact]
        public void DatetimeTest()
        {
            // TODO unit test for the property 'Datetime'
        }
        /// <summary>
        /// Test the property 'Eci'
        /// </summary>
        [Fact]
        public void EciTest()
        {
            // TODO unit test for the property 'Eci'
        }
        /// <summary>
        /// Test the property 'Identifier'
        /// </summary>
        [Fact]
        public void IdentifierTest()
        {
            // TODO unit test for the property 'Identifier'
        }
        /// <summary>
        /// Test the property 'Live'
        /// </summary>
        [Fact]
        public void LiveTest()
        {
            // TODO unit test for the property 'Live'
        }
        /// <summary>
        /// Test the property 'Maskedpan'
        /// </summary>
        [Fact]
        public void MaskedpanTest()
        {
            // TODO unit test for the property 'Maskedpan'
        }
        /// <summary>
        /// Test the property 'Merchantid'
        /// </summary>
        [Fact]
        public void MerchantidTest()
        {
            // TODO unit test for the property 'Merchantid'
        }
        /// <summary>
        /// Test the property 'Result'
        /// </summary>
        [Fact]
        public void ResultTest()
        {
            // TODO unit test for the property 'Result'
        }
        /// <summary>
        /// Test the property 'ResultCode'
        /// </summary>
        [Fact]
        public void ResultCodeTest()
        {
            // TODO unit test for the property 'ResultCode'
        }
        /// <summary>
        /// Test the property 'ResultMessage'
        /// </summary>
        [Fact]
        public void ResultMessageTest()
        {
            // TODO unit test for the property 'ResultMessage'
        }
        /// <summary>
        /// Test the property 'Scheme'
        /// </summary>
        [Fact]
        public void SchemeTest()
        {
            // TODO unit test for the property 'Scheme'
        }
        /// <summary>
        /// Test the property 'Sha256'
        /// </summary>
        [Fact]
        public void Sha256Test()
        {
            // TODO unit test for the property 'Sha256'
        }
        /// <summary>
        /// Test the property 'TransStatus'
        /// </summary>
        [Fact]
        public void TransStatusTest()
        {
            // TODO unit test for the property 'TransStatus'
        }
        /// <summary>
        /// Test the property 'Transno'
        /// </summary>
        [Fact]
        public void TransnoTest()
        {
            // TODO unit test for the property 'Transno'
        }

    }

}
