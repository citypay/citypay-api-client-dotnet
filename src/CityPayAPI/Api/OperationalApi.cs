/*
 * CityPay Payment API
 *
 *  This CityPay API is a HTTP RESTful payment API used for direct server to server transactional processing. It provides a number of payment mechanisms including: Internet, MOTO, Continuous Authority transaction processing, 3-D Secure decision handling using RFA Secure, Authorisation, Refunding, Pre-Authorisation, Cancellation/Voids and Completion processing. The API is also capable of tokinsed payments using Card Holder Accounts.  ## Compliance and Security <aside class=\"notice\">   Before we begin a reminder that your application will need to adhere to PCI-DSS standards to operate safely   and to meet requirements set out by Visa and MasterCard and the PCI Security Standards Council including: </aside>  * Data must be collected using TLS version 1.2 using [strong cryptography](#enabled-tls-ciphers). We will not accept calls to our API at   lower grade encryption levels. We regularly scan our TLS endpoints for vulnerabilities and perform TLS assessments   as part of our compliance program. * The application must not store sensitive card holder data (CHD) such as the card security code (CSC) or   primary access number (PAN) * The application must not display the full card number on receipts, it is recommended to mask the PAN   and show the last 4 digits. The API will return this for you for ease of receipt creation * If you are developing a website, you will be required to perform regular scans on the network where you host the   application to meet your compliance obligations * You will be required to be PCI Compliant and the application must adhere to the security standard. Further information   is available from [https://www.pcisecuritystandards.org/](https://www.pcisecuritystandards.org/) * The API verifies that the request is for a valid account and originates from a trusted source using the remote IP   address. Our application firewalls analyse data that may be an attempt to break a large number of security common   security vulnerabilities. 
 *
 * Contact: support@citypay.com
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net;
using System.Net.Mime;
using CityPayAPI.Client;
using CityPayAPI.Model;

namespace CityPayAPI.Api
{

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IOperationalApiSync : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// List Merchants Request
        /// </summary>
        /// <remarks>
        /// An operational request to list current merchants for a client.  ### Sorting  Sorting can be performed by include a query parameter i.e. &#x60;/merchants/?sort&#x3D;merchantid&#x60;  Fields that can be sorted are &#x60;merchantid&#x60; or &#x60;name&#x60;. 
        /// </remarks>
        /// <exception cref="CityPayAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="clientid">The client id to return merchants for, specifying \&quot;default\&quot; will use the value in your api key.</param>
        /// <returns>ListMerchantsResponse</returns>
        ListMerchantsResponse ListMerchantsRequest(string clientid);

        /// <summary>
        /// List Merchants Request
        /// </summary>
        /// <remarks>
        /// An operational request to list current merchants for a client.  ### Sorting  Sorting can be performed by include a query parameter i.e. &#x60;/merchants/?sort&#x3D;merchantid&#x60;  Fields that can be sorted are &#x60;merchantid&#x60; or &#x60;name&#x60;. 
        /// </remarks>
        /// <exception cref="CityPayAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="clientid">The client id to return merchants for, specifying \&quot;default\&quot; will use the value in your api key.</param>
        /// <returns>ApiResponse of ListMerchantsResponse</returns>
        ApiResponse<ListMerchantsResponse> ListMerchantsRequestWithHttpInfo(string clientid);
        /// <summary>
        /// Ping Request
        /// </summary>
        /// <remarks>
        /// A ping request which performs a connection and authentication test to the CityPay API server. The request will return a standard Acknowledgement with a response code &#x60;044&#x60; to signify a successful ping.  The ping call is useful to confirm that you will be able to access  the API from behind any firewalls and that the permission model is granting access from your source. 
        /// </remarks>
        /// <exception cref="CityPayAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="ping"></param>
        /// <returns>Acknowledgement</returns>
        Acknowledgement PingRequest(Ping ping);

        /// <summary>
        /// Ping Request
        /// </summary>
        /// <remarks>
        /// A ping request which performs a connection and authentication test to the CityPay API server. The request will return a standard Acknowledgement with a response code &#x60;044&#x60; to signify a successful ping.  The ping call is useful to confirm that you will be able to access  the API from behind any firewalls and that the permission model is granting access from your source. 
        /// </remarks>
        /// <exception cref="CityPayAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="ping"></param>
        /// <returns>ApiResponse of Acknowledgement</returns>
        ApiResponse<Acknowledgement> PingRequestWithHttpInfo(Ping ping);
        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IOperationalApiAsync : IApiAccessor
    {
        #region Asynchronous Operations
        /// <summary>
        /// List Merchants Request
        /// </summary>
        /// <remarks>
        /// An operational request to list current merchants for a client.  ### Sorting  Sorting can be performed by include a query parameter i.e. &#x60;/merchants/?sort&#x3D;merchantid&#x60;  Fields that can be sorted are &#x60;merchantid&#x60; or &#x60;name&#x60;. 
        /// </remarks>
        /// <exception cref="CityPayAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="clientid">The client id to return merchants for, specifying \&quot;default\&quot; will use the value in your api key.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ListMerchantsResponse</returns>
        System.Threading.Tasks.Task<ListMerchantsResponse> ListMerchantsRequestAsync(string clientid, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// List Merchants Request
        /// </summary>
        /// <remarks>
        /// An operational request to list current merchants for a client.  ### Sorting  Sorting can be performed by include a query parameter i.e. &#x60;/merchants/?sort&#x3D;merchantid&#x60;  Fields that can be sorted are &#x60;merchantid&#x60; or &#x60;name&#x60;. 
        /// </remarks>
        /// <exception cref="CityPayAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="clientid">The client id to return merchants for, specifying \&quot;default\&quot; will use the value in your api key.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (ListMerchantsResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<ListMerchantsResponse>> ListMerchantsRequestWithHttpInfoAsync(string clientid, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// Ping Request
        /// </summary>
        /// <remarks>
        /// A ping request which performs a connection and authentication test to the CityPay API server. The request will return a standard Acknowledgement with a response code &#x60;044&#x60; to signify a successful ping.  The ping call is useful to confirm that you will be able to access  the API from behind any firewalls and that the permission model is granting access from your source. 
        /// </remarks>
        /// <exception cref="CityPayAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="ping"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of Acknowledgement</returns>
        System.Threading.Tasks.Task<Acknowledgement> PingRequestAsync(Ping ping, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Ping Request
        /// </summary>
        /// <remarks>
        /// A ping request which performs a connection and authentication test to the CityPay API server. The request will return a standard Acknowledgement with a response code &#x60;044&#x60; to signify a successful ping.  The ping call is useful to confirm that you will be able to access  the API from behind any firewalls and that the permission model is granting access from your source. 
        /// </remarks>
        /// <exception cref="CityPayAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="ping"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (Acknowledgement)</returns>
        System.Threading.Tasks.Task<ApiResponse<Acknowledgement>> PingRequestWithHttpInfoAsync(Ping ping, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IOperationalApi : IOperationalApiSync, IOperationalApiAsync
    {

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class OperationalApi : IOperationalApi
    {
        private CityPayAPI.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="OperationalApi"/> class.
        /// </summary>
        /// <returns></returns>
        public OperationalApi() : this((string)null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OperationalApi"/> class.
        /// </summary>
        /// <returns></returns>
        public OperationalApi(string basePath)
        {
            this.Configuration = CityPayAPI.Client.Configuration.MergeConfigurations(
                CityPayAPI.Client.GlobalConfiguration.Instance,
                new CityPayAPI.Client.Configuration { BasePath = basePath }
            );
            this.Client = new CityPayAPI.Client.ApiClient(this.Configuration.BasePath);
            this.AsynchronousClient = new CityPayAPI.Client.ApiClient(this.Configuration.BasePath);
            this.ExceptionFactory = CityPayAPI.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OperationalApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public OperationalApi(CityPayAPI.Client.Configuration configuration)
        {
            if (configuration == null) throw new ArgumentNullException("configuration");

            this.Configuration = CityPayAPI.Client.Configuration.MergeConfigurations(
                CityPayAPI.Client.GlobalConfiguration.Instance,
                configuration
            );
            this.Client = new CityPayAPI.Client.ApiClient(this.Configuration.BasePath);
            this.AsynchronousClient = new CityPayAPI.Client.ApiClient(this.Configuration.BasePath);
            ExceptionFactory = CityPayAPI.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OperationalApi"/> class
        /// using a Configuration object and client instance.
        /// </summary>
        /// <param name="client">The client interface for synchronous API access.</param>
        /// <param name="asyncClient">The client interface for asynchronous API access.</param>
        /// <param name="configuration">The configuration object.</param>
        public OperationalApi(CityPayAPI.Client.ISynchronousClient client, CityPayAPI.Client.IAsynchronousClient asyncClient, CityPayAPI.Client.IReadableConfiguration configuration)
        {
            if (client == null) throw new ArgumentNullException("client");
            if (asyncClient == null) throw new ArgumentNullException("asyncClient");
            if (configuration == null) throw new ArgumentNullException("configuration");

            this.Client = client;
            this.AsynchronousClient = asyncClient;
            this.Configuration = configuration;
            this.ExceptionFactory = CityPayAPI.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// The client for accessing this underlying API asynchronously.
        /// </summary>
        public CityPayAPI.Client.IAsynchronousClient AsynchronousClient { get; set; }

        /// <summary>
        /// The client for accessing this underlying API synchronously.
        /// </summary>
        public CityPayAPI.Client.ISynchronousClient Client { get; set; }

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        public string GetBasePath()
        {
            return this.Configuration.BasePath;
        }

        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        public CityPayAPI.Client.IReadableConfiguration Configuration { get; set; }

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public CityPayAPI.Client.ExceptionFactory ExceptionFactory
        {
            get
            {
                if (_exceptionFactory != null && _exceptionFactory.GetInvocationList().Length > 1)
                {
                    throw new InvalidOperationException("Multicast delegate for ExceptionFactory is unsupported.");
                }
                return _exceptionFactory;
            }
            set { _exceptionFactory = value; }
        }

        /// <summary>
        /// List Merchants Request An operational request to list current merchants for a client.  ### Sorting  Sorting can be performed by include a query parameter i.e. &#x60;/merchants/?sort&#x3D;merchantid&#x60;  Fields that can be sorted are &#x60;merchantid&#x60; or &#x60;name&#x60;. 
        /// </summary>
        /// <exception cref="CityPayAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="clientid">The client id to return merchants for, specifying \&quot;default\&quot; will use the value in your api key.</param>
        /// <returns>ListMerchantsResponse</returns>
        public ListMerchantsResponse ListMerchantsRequest(string clientid)
        {
            CityPayAPI.Client.ApiResponse<ListMerchantsResponse> localVarResponse = ListMerchantsRequestWithHttpInfo(clientid);
            return localVarResponse.Data;
        }

        /// <summary>
        /// List Merchants Request An operational request to list current merchants for a client.  ### Sorting  Sorting can be performed by include a query parameter i.e. &#x60;/merchants/?sort&#x3D;merchantid&#x60;  Fields that can be sorted are &#x60;merchantid&#x60; or &#x60;name&#x60;. 
        /// </summary>
        /// <exception cref="CityPayAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="clientid">The client id to return merchants for, specifying \&quot;default\&quot; will use the value in your api key.</param>
        /// <returns>ApiResponse of ListMerchantsResponse</returns>
        public CityPayAPI.Client.ApiResponse<ListMerchantsResponse> ListMerchantsRequestWithHttpInfo(string clientid)
        {
            // verify the required parameter 'clientid' is set
            if (clientid == null)
                throw new CityPayAPI.Client.ApiException(400, "Missing required parameter 'clientid' when calling OperationalApi->ListMerchantsRequest");

            CityPayAPI.Client.RequestOptions localVarRequestOptions = new CityPayAPI.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json",
                "text/xml"
            };

            var localVarContentType = CityPayAPI.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = CityPayAPI.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("clientid", CityPayAPI.Client.ClientUtils.ParameterToString(clientid)); // path parameter

            // authentication (cp-api-key) required
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("cp-api-key")))
            {
                localVarRequestOptions.HeaderParameters.Add("cp-api-key", this.Configuration.GetApiKeyWithPrefix("cp-api-key"));
            }

            // make the HTTP request
            var localVarResponse = this.Client.Get<ListMerchantsResponse>("/merchants/{clientid}", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("ListMerchantsRequest", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// List Merchants Request An operational request to list current merchants for a client.  ### Sorting  Sorting can be performed by include a query parameter i.e. &#x60;/merchants/?sort&#x3D;merchantid&#x60;  Fields that can be sorted are &#x60;merchantid&#x60; or &#x60;name&#x60;. 
        /// </summary>
        /// <exception cref="CityPayAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="clientid">The client id to return merchants for, specifying \&quot;default\&quot; will use the value in your api key.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ListMerchantsResponse</returns>
        public async System.Threading.Tasks.Task<ListMerchantsResponse> ListMerchantsRequestAsync(string clientid, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            CityPayAPI.Client.ApiResponse<ListMerchantsResponse> localVarResponse = await ListMerchantsRequestWithHttpInfoAsync(clientid, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// List Merchants Request An operational request to list current merchants for a client.  ### Sorting  Sorting can be performed by include a query parameter i.e. &#x60;/merchants/?sort&#x3D;merchantid&#x60;  Fields that can be sorted are &#x60;merchantid&#x60; or &#x60;name&#x60;. 
        /// </summary>
        /// <exception cref="CityPayAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="clientid">The client id to return merchants for, specifying \&quot;default\&quot; will use the value in your api key.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (ListMerchantsResponse)</returns>
        public async System.Threading.Tasks.Task<CityPayAPI.Client.ApiResponse<ListMerchantsResponse>> ListMerchantsRequestWithHttpInfoAsync(string clientid, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            // verify the required parameter 'clientid' is set
            if (clientid == null)
                throw new CityPayAPI.Client.ApiException(400, "Missing required parameter 'clientid' when calling OperationalApi->ListMerchantsRequest");


            CityPayAPI.Client.RequestOptions localVarRequestOptions = new CityPayAPI.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json",
                "text/xml"
            };


            var localVarContentType = CityPayAPI.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = CityPayAPI.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("clientid", CityPayAPI.Client.ClientUtils.ParameterToString(clientid)); // path parameter

            // authentication (cp-api-key) required
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("cp-api-key")))
            {
                localVarRequestOptions.HeaderParameters.Add("cp-api-key", this.Configuration.GetApiKeyWithPrefix("cp-api-key"));
            }

            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.GetAsync<ListMerchantsResponse>("/merchants/{clientid}", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("ListMerchantsRequest", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Ping Request A ping request which performs a connection and authentication test to the CityPay API server. The request will return a standard Acknowledgement with a response code &#x60;044&#x60; to signify a successful ping.  The ping call is useful to confirm that you will be able to access  the API from behind any firewalls and that the permission model is granting access from your source. 
        /// </summary>
        /// <exception cref="CityPayAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="ping"></param>
        /// <returns>Acknowledgement</returns>
        public Acknowledgement PingRequest(Ping ping)
        {
            CityPayAPI.Client.ApiResponse<Acknowledgement> localVarResponse = PingRequestWithHttpInfo(ping);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Ping Request A ping request which performs a connection and authentication test to the CityPay API server. The request will return a standard Acknowledgement with a response code &#x60;044&#x60; to signify a successful ping.  The ping call is useful to confirm that you will be able to access  the API from behind any firewalls and that the permission model is granting access from your source. 
        /// </summary>
        /// <exception cref="CityPayAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="ping"></param>
        /// <returns>ApiResponse of Acknowledgement</returns>
        public CityPayAPI.Client.ApiResponse<Acknowledgement> PingRequestWithHttpInfo(Ping ping)
        {
            // verify the required parameter 'ping' is set
            if (ping == null)
                throw new CityPayAPI.Client.ApiException(400, "Missing required parameter 'ping' when calling OperationalApi->PingRequest");

            CityPayAPI.Client.RequestOptions localVarRequestOptions = new CityPayAPI.Client.RequestOptions();

            string[] _contentTypes = new string[] {
                "application/json",
                "text/xml"
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json",
                "text/xml"
            };

            var localVarContentType = CityPayAPI.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = CityPayAPI.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.Data = ping;

            // authentication (cp-api-key) required
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("cp-api-key")))
            {
                localVarRequestOptions.HeaderParameters.Add("cp-api-key", this.Configuration.GetApiKeyWithPrefix("cp-api-key"));
            }

            // make the HTTP request
            var localVarResponse = this.Client.Post<Acknowledgement>("/ping", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("PingRequest", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Ping Request A ping request which performs a connection and authentication test to the CityPay API server. The request will return a standard Acknowledgement with a response code &#x60;044&#x60; to signify a successful ping.  The ping call is useful to confirm that you will be able to access  the API from behind any firewalls and that the permission model is granting access from your source. 
        /// </summary>
        /// <exception cref="CityPayAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="ping"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of Acknowledgement</returns>
        public async System.Threading.Tasks.Task<Acknowledgement> PingRequestAsync(Ping ping, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            CityPayAPI.Client.ApiResponse<Acknowledgement> localVarResponse = await PingRequestWithHttpInfoAsync(ping, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Ping Request A ping request which performs a connection and authentication test to the CityPay API server. The request will return a standard Acknowledgement with a response code &#x60;044&#x60; to signify a successful ping.  The ping call is useful to confirm that you will be able to access  the API from behind any firewalls and that the permission model is granting access from your source. 
        /// </summary>
        /// <exception cref="CityPayAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="ping"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (Acknowledgement)</returns>
        public async System.Threading.Tasks.Task<CityPayAPI.Client.ApiResponse<Acknowledgement>> PingRequestWithHttpInfoAsync(Ping ping, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            // verify the required parameter 'ping' is set
            if (ping == null)
                throw new CityPayAPI.Client.ApiException(400, "Missing required parameter 'ping' when calling OperationalApi->PingRequest");


            CityPayAPI.Client.RequestOptions localVarRequestOptions = new CityPayAPI.Client.RequestOptions();

            string[] _contentTypes = new string[] {
                "application/json", 
                "text/xml"
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json",
                "text/xml"
            };


            var localVarContentType = CityPayAPI.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = CityPayAPI.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.Data = ping;

            // authentication (cp-api-key) required
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("cp-api-key")))
            {
                localVarRequestOptions.HeaderParameters.Add("cp-api-key", this.Configuration.GetApiKeyWithPrefix("cp-api-key"));
            }

            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.PostAsync<Acknowledgement>("/ping", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("PingRequest", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

    }
}
