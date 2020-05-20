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
    ///  Class for testing MCC6012
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class MCC6012Tests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for MCC6012
        //private MCC6012 instance;

        public MCC6012Tests()
        {
            // TODO uncomment below to create an instance of MCC6012
            //instance = new MCC6012();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of MCC6012
        /// </summary>
        [Fact]
        public void MCC6012InstanceTest()
        {
            // TODO uncomment below to test "IsInstanceOfType" MCC6012
            //Assert.IsInstanceOfType<MCC6012> (instance, "variable 'instance' is a MCC6012");
        }


        /// <summary>
        /// Test the property 'RecipientAccount'
        /// </summary>
        [Fact]
        public void RecipientAccountTest()
        {
            // TODO unit test for the property 'RecipientAccount'
        }
        /// <summary>
        /// Test the property 'RecipientDob'
        /// </summary>
        [Fact]
        public void RecipientDobTest()
        {
            // TODO unit test for the property 'RecipientDob'
        }
        /// <summary>
        /// Test the property 'RecipientLastname'
        /// </summary>
        [Fact]
        public void RecipientLastnameTest()
        {
            // TODO unit test for the property 'RecipientLastname'
        }
        /// <summary>
        /// Test the property 'RecipientPostcode'
        /// </summary>
        [Fact]
        public void RecipientPostcodeTest()
        {
            // TODO unit test for the property 'RecipientPostcode'
        }

    }

}
