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
    ///  Class for testing AuthorisationAndPaymentApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class AuthorisationAndPaymentApiTests : IDisposable
    {
        private AuthorisationAndPaymentApi instance;

        public AuthorisationAndPaymentApiTests()
        {
            instance = new AuthorisationAndPaymentApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of AuthorisationAndPaymentApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' AuthorisationAndPaymentApi
            //Assert.IsType<AuthorisationAndPaymentApi>(instance);
        }

        /// <summary>
        /// Test AuthorisationRequest
        /// </summary>
        [Fact]
        public void AuthorisationRequestTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //AuthRequest authRequest = null;
            //var response = instance.AuthorisationRequest(authRequest);
            //Assert.IsType<Decision>(response);
        }

        /// <summary>
        /// Test BinRangeLookupRequest
        /// </summary>
        [Fact]
        public void BinRangeLookupRequestTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //BinLookup binLookup = null;
            //var response = instance.BinRangeLookupRequest(binLookup);
            //Assert.IsType<Bin>(response);
        }

        /// <summary>
        /// Test CResRequest
        /// </summary>
        [Fact]
        public void CResRequestTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //CResAuthRequest cResAuthRequest = null;
            //var response = instance.CResRequest(cResAuthRequest);
            //Assert.IsType<AuthResponse>(response);
        }

        /// <summary>
        /// Test CaptureRequest
        /// </summary>
        [Fact]
        public void CaptureRequestTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //CaptureRequest captureRequest = null;
            //var response = instance.CaptureRequest(captureRequest);
            //Assert.IsType<Acknowledgement>(response);
        }

        /// <summary>
        /// Test PaResRequest
        /// </summary>
        [Fact]
        public void PaResRequestTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //PaResAuthRequest paResAuthRequest = null;
            //var response = instance.PaResRequest(paResAuthRequest);
            //Assert.IsType<AuthResponse>(response);
        }

        /// <summary>
        /// Test RefundRequest
        /// </summary>
        [Fact]
        public void RefundRequestTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //RefundRequest refundRequest = null;
            //var response = instance.RefundRequest(refundRequest);
            //Assert.IsType<AuthResponse>(response);
        }

        /// <summary>
        /// Test RetrievalRequest
        /// </summary>
        [Fact]
        public void RetrievalRequestTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //RetrieveRequest retrieveRequest = null;
            //var response = instance.RetrievalRequest(retrieveRequest);
            //Assert.IsType<AuthReferences>(response);
        }

        /// <summary>
        /// Test VoidRequest
        /// </summary>
        [Fact]
        public void VoidRequestTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //VoidRequest voidRequest = null;
            //var response = instance.VoidRequest(voidRequest);
            //Assert.IsType<Acknowledgement>(response);
        }
    }
}
