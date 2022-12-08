# CityPayAPI.Api.DirectPostApi

All URIs are relative to *https://api.citypay.com*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**DirectCResAuthRequest**](DirectPostApi.md#directcresauthrequest) | **POST** /direct/cres/auth/{uuid} | Handles a CRes response from ACS, returning back the result of authorisation |
| [**DirectCResTokeniseRequest**](DirectPostApi.md#directcrestokeniserequest) | **POST** /direct/cres/tokenise/{uuid} | Handles a CRes response from ACS, returning back a token for future authorisation |
| [**DirectPostAuthRequest**](DirectPostApi.md#directpostauthrequest) | **POST** /direct/auth | Direct Post Auth Request |
| [**DirectPostTokeniseRequest**](DirectPostApi.md#directposttokeniserequest) | **POST** /direct/tokenise | Direct Post Tokenise Request |
| [**TokenRequest**](DirectPostApi.md#tokenrequest) | **POST** /direct/token | Direct Post Token Request |

<a name="directcresauthrequest"></a>
# **DirectCResAuthRequest**
> AuthResponse DirectCResAuthRequest (string uuid, string cres = null, string threeDSSessionData = null)

Handles a CRes response from ACS, returning back the result of authorisation

Used to post from an ACS during a ThreeDSecure direct flow process. The endpoint requires a valid `threeDSSessionData`
value which defines the unique transaction through its workflow. This endpoint may be used by merchants wishing to
perform a `Direct Post` integration who wish to handle the challenge flow themselves.


### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using CityPayAPI.Api;
using CityPayAPI.Client;
using CityPayAPI.Model;

namespace Example
{
    public class DirectCResAuthRequestExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.citypay.com";
            var apiInstance = new DirectPostApi(config);
            var uuid = "uuid_example";  // string | An identifier used to track the CReq/CRes cycle.
            var cres = "cres_example";  // string | The CRES from the ACS. (optional) 
            var threeDSSessionData = "threeDSSessionData_example";  // string | The session data from the ACS. (optional) 

            try
            {
                // Handles a CRes response from ACS, returning back the result of authorisation
                AuthResponse result = apiInstance.DirectCResAuthRequest(uuid, cres, threeDSSessionData);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DirectPostApi.DirectCResAuthRequest: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DirectCResAuthRequestWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Handles a CRes response from ACS, returning back the result of authorisation
    ApiResponse<AuthResponse> response = apiInstance.DirectCResAuthRequestWithHttpInfo(uuid, cres, threeDSSessionData);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DirectPostApi.DirectCResAuthRequestWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **uuid** | **string** | An identifier used to track the CReq/CRes cycle. |  |
| **cres** | **string** | The CRES from the ACS. | [optional]  |
| **threeDSSessionData** | **string** | The session data from the ACS. | [optional]  |

### Return type

[**AuthResponse**](AuthResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/json, application/xml, application/x-www-form-urlencoded


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | A result of a successful tokenisation or authorisation process if called via an XHR method. |  -  |
| **303** | Redirect. A result of a successful tokenisation or authorisation process, redirecting to the success URL. |  -  |
| **307** | Redirect. A result of a non-successful tokenisation or authorisation process, redirecting to the failure URL. |  -  |
| **401** | Unauthorized. No domain key has been provided and is required for this operation. |  -  |
| **403** | Forbidden. The domain key was provided and understood but is either incorrect or does not have permission to access the account provided on the request. |  -  |
| **406** | Not Acceptable. Should the incoming data not be validly determined. |  -  |
| **412** | Bad Request. Should the incoming data not be validly determined and an error code results. |  -  |
| **500** | Server Error. Server Error. The server was unable to complete the request. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="directcrestokeniserequest"></a>
# **DirectCResTokeniseRequest**
> TokenisationResponseModel DirectCResTokeniseRequest (string uuid, string cres = null, string threeDSSessionData = null)

Handles a CRes response from ACS, returning back a token for future authorisation

Used to post from an ACS during a ThreeDSecure direct flow process. The endpoint requires a valid `threeDSSessionData`
value which defines the unique transaction through its workflow. This endpoint may be used by merchants wishing to
perform a `Direct Post` integration who wish to handle the challenge flow themselves.


### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using CityPayAPI.Api;
using CityPayAPI.Client;
using CityPayAPI.Model;

namespace Example
{
    public class DirectCResTokeniseRequestExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.citypay.com";
            var apiInstance = new DirectPostApi(config);
            var uuid = "uuid_example";  // string | An identifier used to track the CReq/CRes cycle.
            var cres = "cres_example";  // string | The CRES from the ACS. (optional) 
            var threeDSSessionData = "threeDSSessionData_example";  // string | The session data from the ACS. (optional) 

            try
            {
                // Handles a CRes response from ACS, returning back a token for future authorisation
                TokenisationResponseModel result = apiInstance.DirectCResTokeniseRequest(uuid, cres, threeDSSessionData);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DirectPostApi.DirectCResTokeniseRequest: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DirectCResTokeniseRequestWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Handles a CRes response from ACS, returning back a token for future authorisation
    ApiResponse<TokenisationResponseModel> response = apiInstance.DirectCResTokeniseRequestWithHttpInfo(uuid, cres, threeDSSessionData);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DirectPostApi.DirectCResTokeniseRequestWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **uuid** | **string** | An identifier used to track the CReq/CRes cycle. |  |
| **cres** | **string** | The CRES from the ACS. | [optional]  |
| **threeDSSessionData** | **string** | The session data from the ACS. | [optional]  |

### Return type

[**TokenisationResponseModel**](TokenisationResponseModel.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/json, application/xml, application/x-www-form-urlencoded


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | A result of a successful tokenisation or authorisation process if called via an XHR method. |  -  |
| **303** | Redirect. A result of a successful tokenisation or authorisation process, redirecting to the success URL. |  -  |
| **307** | Redirect. A result of a non-successful tokenisation or authorisation process, redirecting to the failure URL. |  -  |
| **401** | Unauthorized. No domain key has been provided and is required for this operation. |  -  |
| **403** | Forbidden. The domain key was provided and understood but is either incorrect or does not have permission to access the account provided on the request. |  -  |
| **406** | Not Acceptable. Should the incoming data not be validly determined. |  -  |
| **412** | Bad Request. Should the incoming data not be validly determined and an error code results. |  -  |
| **500** | Server Error. Server Error. The server was unable to complete the request. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="directpostauthrequest"></a>
# **DirectPostAuthRequest**
> AuthResponse DirectPostAuthRequest (DirectPostRequest directPostRequest)

Direct Post Auth Request

Used to initiate a direct post request transaction flow.

<pre class="inline-code language-bash">
<code>
curl https://api.citypay.com/direct/auth?cp-domain-key=n834ytqp84y... \
 -d "amount=7500&identifier=example_trans&cardnumber=4000000000000002&expmonth=9&expyear=2028&bill_to_postcode=L1+7ZW
</code>
</pre>.


### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using CityPayAPI.Api;
using CityPayAPI.Client;
using CityPayAPI.Model;

namespace Example
{
    public class DirectPostAuthRequestExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.citypay.com";
            // Create a temporal ApiKey using your client id and licence key
            config.AddApiKey("cp-api-key", new ApiKey("CLIENT_ID", "LICENCE_KEY").GenerateKey());
            // Configure API key authorization: cp-domain-key
            config.AddApiKey("cp-domain-key", "YOUR_API_KEY");
            // config.AddApiKeyPrefix("cp-domain-key", "Bearer");

            var apiInstance = new DirectPostApi(config);
            var directPostRequest = new DirectPostRequest(); // DirectPostRequest | 

            try
            {
                // Direct Post Auth Request
                AuthResponse result = apiInstance.DirectPostAuthRequest(directPostRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DirectPostApi.DirectPostAuthRequest: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DirectPostAuthRequestWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Direct Post Auth Request
    ApiResponse<AuthResponse> response = apiInstance.DirectPostAuthRequestWithHttpInfo(directPostRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DirectPostApi.DirectPostAuthRequestWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **directPostRequest** | [**DirectPostRequest**](DirectPostRequest.md) |  |  |

### Return type

[**AuthResponse**](AuthResponse.md)

### Authorization

[cp-api-key](../README.md#cp-api-key), [cp-domain-key](../README.md#cp-domain-key)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, text/xml
 - **Accept**: application/json, application/xml, application/x-www-form-urlencoded, text/xml


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | A result of a successful tokenisation or authorisation process if called via an XHR method. |  -  |
| **303** | Redirect. A result of a successful tokenisation or authorisation process, redirecting to the success URL. |  -  |
| **307** | Redirect. A result of a non-successful tokenisation or authorisation process, redirecting to the failure URL. |  -  |
| **401** | Unauthorized. No domain key has been provided and is required for this operation. |  -  |
| **403** | Forbidden. The domain key was provided and understood but is either incorrect or does not have permission to access the account provided on the request. |  -  |
| **406** | Not Acceptable. Should the incoming data not be validly determined. |  -  |
| **412** | Bad Request. Should the incoming data not be validly determined and an error code results. |  -  |
| **500** | Server Error. Server Error. The server was unable to complete the request. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="directposttokeniserequest"></a>
# **DirectPostTokeniseRequest**
> AuthResponse DirectPostTokeniseRequest (DirectPostRequest directPostRequest)

Direct Post Tokenise Request

Used to initiate a direct post request transaction flow.

<pre class="inline-code language-bash">
<code>
curl https://api.citypay.com/v6/direct?cp-domain-key=n834ytqp84y... \
 -d "amount=7500&identifier=example_trans&cardnumber=4000000000000002&expmonth=9&expyear=2028&bill_to_postcode=L1+7ZW
</code>
</pre>.


### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using CityPayAPI.Api;
using CityPayAPI.Client;
using CityPayAPI.Model;

namespace Example
{
    public class DirectPostTokeniseRequestExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.citypay.com";
            // Create a temporal ApiKey using your client id and licence key
            config.AddApiKey("cp-api-key", new ApiKey("CLIENT_ID", "LICENCE_KEY").GenerateKey());
            // Configure API key authorization: cp-domain-key
            config.AddApiKey("cp-domain-key", "YOUR_API_KEY");
            // config.AddApiKeyPrefix("cp-domain-key", "Bearer");

            var apiInstance = new DirectPostApi(config);
            var directPostRequest = new DirectPostRequest(); // DirectPostRequest | 

            try
            {
                // Direct Post Tokenise Request
                AuthResponse result = apiInstance.DirectPostTokeniseRequest(directPostRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DirectPostApi.DirectPostTokeniseRequest: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DirectPostTokeniseRequestWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Direct Post Tokenise Request
    ApiResponse<AuthResponse> response = apiInstance.DirectPostTokeniseRequestWithHttpInfo(directPostRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DirectPostApi.DirectPostTokeniseRequestWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **directPostRequest** | [**DirectPostRequest**](DirectPostRequest.md) |  |  |

### Return type

[**AuthResponse**](AuthResponse.md)

### Authorization

[cp-api-key](../README.md#cp-api-key), [cp-domain-key](../README.md#cp-domain-key)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, text/xml
 - **Accept**: application/json, application/xml, application/x-www-form-urlencoded, text/xml


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | A result of a successful tokenisation or authorisation process if called via an XHR method. |  -  |
| **303** | Redirect. A result of a successful tokenisation or authorisation process, redirecting to the success URL. |  -  |
| **307** | Redirect. A result of a non-successful tokenisation or authorisation process, redirecting to the failure URL. |  -  |
| **401** | Unauthorized. No domain key has been provided and is required for this operation. |  -  |
| **403** | Forbidden. The domain key was provided and understood but is either incorrect or does not have permission to access the account provided on the request. |  -  |
| **406** | Not Acceptable. Should the incoming data not be validly determined. |  -  |
| **412** | Bad Request. Should the incoming data not be validly determined and an error code results. |  -  |
| **500** | Server Error. Server Error. The server was unable to complete the request. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="tokenrequest"></a>
# **TokenRequest**
> AuthResponse TokenRequest (DirectTokenAuthRequest directTokenAuthRequest)

Direct Post Token Request

Perform a request for authorisation for a previously generated token. This flow will return an authorisation
response stating that the transaction was approved or declined.


### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using CityPayAPI.Api;
using CityPayAPI.Client;
using CityPayAPI.Model;

namespace Example
{
    public class TokenRequestExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.citypay.com";
            // Create a temporal ApiKey using your client id and licence key
            config.AddApiKey("cp-api-key", new ApiKey("CLIENT_ID", "LICENCE_KEY").GenerateKey());
            // Configure API key authorization: cp-domain-key
            config.AddApiKey("cp-domain-key", "YOUR_API_KEY");
            // config.AddApiKeyPrefix("cp-domain-key", "Bearer");

            var apiInstance = new DirectPostApi(config);
            var directTokenAuthRequest = new DirectTokenAuthRequest(); // DirectTokenAuthRequest | 

            try
            {
                // Direct Post Token Request
                AuthResponse result = apiInstance.TokenRequest(directTokenAuthRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DirectPostApi.TokenRequest: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the TokenRequestWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Direct Post Token Request
    ApiResponse<AuthResponse> response = apiInstance.TokenRequestWithHttpInfo(directTokenAuthRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DirectPostApi.TokenRequestWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **directTokenAuthRequest** | [**DirectTokenAuthRequest**](DirectTokenAuthRequest.md) |  |  |

### Return type

[**AuthResponse**](AuthResponse.md)

### Authorization

[cp-api-key](../README.md#cp-api-key), [cp-domain-key](../README.md#cp-domain-key)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, text/xml
 - **Accept**: application/json, application/xml, application/x-www-form-urlencoded, text/xml


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | A result of an authorisation process if called via an XHR method. |  -  |
| **303** | Redirect. A result of a successful tokenisation or authorisation process, redirecting to the success URL. |  -  |
| **307** | Redirect. A result of a non-successful tokenisation or authorisation process, redirecting to the failure URL. |  -  |
| **401** | Unauthorized. No domain key has been provided and is required for this operation. |  -  |
| **403** | Forbidden. The domain key was provided and understood but is either incorrect or does not have permission to access the account provided on the request. |  -  |
| **406** | Not Acceptable. Should the incoming data not be validly determined. |  -  |
| **412** | Bad Request. Should the incoming data not be validly determined and an error code results. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

