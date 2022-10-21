/*
 * CityPay Payment API
 *
 *  This CityPay API is a HTTP RESTful payment API used for direct server to server transactional processing. It provides a number of payment mechanisms including: Internet, MOTO, Continuous Authority transaction processing, 3-D Secure decision handling using RFA Secure, Authorisation, Refunding, Pre-Authorisation, Cancellation/Voids and Completion processing. The API is also capable of tokinsed payments using Card Holder Accounts.  ## Compliance and Security Your application will need to adhere to PCI-DSS standards to operate safely and to meet requirements set out by  Visa and MasterCard and the PCI Security Standards Council. These include  * Data must be collected using TLS version 1.2 using [strong cryptography](#enabled-tls-ciphers). We will not accept calls to our API at   lower grade encryption levels. We regularly scan our TLS endpoints for vulnerabilities and perform TLS assessments   as part of our compliance program. * The application must not store sensitive card holder data (CHD) such as the card security code (CSC) or   primary access number (PAN) * The application must not display the full card number on receipts, it is recommended to mask the PAN   and show the last 4 digits. The API will return this for you for ease of receipt creation * If you are developing a website, you will be required to perform regular scans on the network where you host the   application to meet your compliance obligations * You will be required to be PCI Compliant and the application must adhere to the security standard. Further information   is available from [https://www.pcisecuritystandards.org/](https://www.pcisecuritystandards.org/) * The API verifies that the request is for a valid account and originates from a trusted source using the remote IP   address. Our application firewalls analyse data that may be an attempt to break a large number of security common   security vulnerabilities.. 
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

namespace CityPayAPI.Test.Model
{
    /// <summary>
    ///  Class for testing PaylinkUI
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class PaylinkUITests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for PaylinkUI
        //private PaylinkUI instance;

        public PaylinkUITests()
        {
            // TODO uncomment below to create an instance of PaylinkUI
            //instance = new PaylinkUI();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of PaylinkUI
        /// </summary>
        [Fact]
        public void PaylinkUIInstanceTest()
        {
            // TODO uncomment below to test "IsType" PaylinkUI
            //Assert.IsType<PaylinkUI>(instance);
        }


        /// <summary>
        /// Test the property 'AddressMandatory'
        /// </summary>
        [Fact]
        public void AddressMandatoryTest()
        {
            // TODO unit test for the property 'AddressMandatory'
        }
        /// <summary>
        /// Test the property 'FormAutoComplete'
        /// </summary>
        [Fact]
        public void FormAutoCompleteTest()
        {
            // TODO unit test for the property 'FormAutoComplete'
        }
        /// <summary>
        /// Test the property 'Ordering'
        /// </summary>
        [Fact]
        public void OrderingTest()
        {
            // TODO unit test for the property 'Ordering'
        }
        /// <summary>
        /// Test the property 'PostcodeMandatory'
        /// </summary>
        [Fact]
        public void PostcodeMandatoryTest()
        {
            // TODO unit test for the property 'PostcodeMandatory'
        }

    }

}