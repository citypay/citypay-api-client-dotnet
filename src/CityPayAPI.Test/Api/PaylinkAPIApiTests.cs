/*
 * CityPay Payment API
 *
 *  This CityPay API is a HTTP RESTful payment API used for direct server to server transactional processing. It provides a number of payment mechanisms including: Internet, MOTO, Continuous Authority transaction processing, 3-D Secure decision handling using RFA Secure, Authorisation, Refunding, Pre-Authorisation, Cancellation/Voids and Completion processing. The API is also capable of tokinsed payments using Card Holder Accounts.  ## Compliance and Security Your application will need to adhere to PCI-DSS standards to operate safely and to meet requirements set out by  Visa and MasterCard and the PCI Security Standards Council. These include  * Data must be collected using TLS version 1.2 using [strong cryptography](#enabled-tls-ciphers). We will not accept calls to our API at   lower grade encryption levels. We regularly scan our TLS endpoints for vulnerabilities and perform TLS assessments   as part of our compliance program. * The application must not store sensitive card holder data (CHD) such as the card security code (CSC) or   primary access number (PAN) * The application must not display the full card number on receipts, it is recommended to mask the PAN   and show the last 4 digits. The API will return this for you for ease of receipt creation * If you are developing a website, you will be required to perform regular scans on the network where you host the   application to meet your compliance obligations * You will be required to be PCI Compliant and the application must adhere to the security standard. Further information   is available from [https://www.pcisecuritystandards.org/](https://www.pcisecuritystandards.org/) * The API verifies that the request is for a valid account and originates from a trusted source using the remote IP   address. Our application firewalls analyse data that may be an attempt to break a large number of security common   security vulnerabilities. 
 *
 * Contact: support@citypay.com
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using RestSharp;
using Xunit;

using CityPayAPI.Client;
using CityPayAPI.Api;
// uncomment below to import models
//using CityPayAPI.Model;

namespace CityPayAPI.Test.Api
{
    /// <summary>
    ///  Class for testing PaylinkAPIApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class PaylinkAPIApiTests : IDisposable
    {
        private PaylinkAPIApi instance;

        public PaylinkAPIApiTests()
        {
            instance = new PaylinkAPIApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of PaylinkAPIApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' PaylinkAPIApi
            //Assert.IsType<PaylinkAPIApi>(instance);
        }

        /// <summary>
        /// Test TokenAdjustmentRequest
        /// </summary>
        [Fact]
        public void TokenAdjustmentRequestTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string token = null;
            //AdjustmentRequest adjustmentRequest = null;
            //var response = instance.TokenAdjustmentRequest(token, adjustmentRequest);
            //Assert.IsType<Acknowledgement>(response);
        }

        /// <summary>
        /// Test TokenCloseRequest
        /// </summary>
        [Fact]
        public void TokenCloseRequestTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string token = null;
            //var response = instance.TokenCloseRequest(token);
            //Assert.IsType<Acknowledgement>(response);
        }

        /// <summary>
        /// Test TokenCreateBillPaymentRequest
        /// </summary>
        [Fact]
        public void TokenCreateBillPaymentRequestTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //BillPaymentTokenRequest billPaymentTokenRequest = null;
            //var response = instance.TokenCreateBillPaymentRequest(billPaymentTokenRequest);
            //Assert.IsType<TokenCreated>(response);
        }

        /// <summary>
        /// Test TokenCreateRequest
        /// </summary>
        [Fact]
        public void TokenCreateRequestTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //TokenRequestModel tokenRequestModel = null;
            //var response = instance.TokenCreateRequest(tokenRequestModel);
            //Assert.IsType<TokenCreated>(response);
        }

        /// <summary>
        /// Test TokenReconciledRequest
        /// </summary>
        [Fact]
        public void TokenReconciledRequestTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string token = null;
            //var response = instance.TokenReconciledRequest(token);
            //Assert.IsType<Acknowledgement>(response);
        }

        /// <summary>
        /// Test TokenReopenRequest
        /// </summary>
        [Fact]
        public void TokenReopenRequestTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string token = null;
            //var response = instance.TokenReopenRequest(token);
            //Assert.IsType<Acknowledgement>(response);
        }

        /// <summary>
        /// Test TokenStatusChangesRequest
        /// </summary>
        [Fact]
        public void TokenStatusChangesRequestTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //TokenStatusChangeRequest tokenStatusChangeRequest = null;
            //var response = instance.TokenStatusChangesRequest(tokenStatusChangeRequest);
            //Assert.IsType<TokenStatusChangeResponse>(response);
        }

        /// <summary>
        /// Test TokenStatusRequest
        /// </summary>
        [Fact]
        public void TokenStatusRequestTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string token = null;
            //var response = instance.TokenStatusRequest(token);
            //Assert.IsType<TokenStatus>(response);
        }
    }
}
