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

namespace CityPayAPI.Test.Model
{
    /// <summary>
    ///  Class for testing ProcessBatchRequest
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class ProcessBatchRequestTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for ProcessBatchRequest
        //private ProcessBatchRequest instance;

        public ProcessBatchRequestTests()
        {
            // TODO uncomment below to create an instance of ProcessBatchRequest
            //instance = new ProcessBatchRequest();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of ProcessBatchRequest
        /// </summary>
        [Fact]
        public void ProcessBatchRequestInstanceTest()
        {
            // TODO uncomment below to test "IsType" ProcessBatchRequest
            //Assert.IsType<ProcessBatchRequest>(instance);
        }


        /// <summary>
        /// Test the property 'AccountId'
        /// </summary>
        [Fact]
        public void AccountIdTest()
        {
            // TODO unit test for the property 'AccountId'
        }
        /// <summary>
        /// Test the property 'BatchDate'
        /// </summary>
        [Fact]
        public void BatchDateTest()
        {
            // TODO unit test for the property 'BatchDate'
        }
        /// <summary>
        /// Test the property 'BatchId'
        /// </summary>
        [Fact]
        public void BatchIdTest()
        {
            // TODO unit test for the property 'BatchId'
        }
        /// <summary>
        /// Test the property 'Transactions'
        /// </summary>
        [Fact]
        public void TransactionsTest()
        {
            // TODO unit test for the property 'Transactions'
        }

    }

}
