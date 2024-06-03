# CityPayAPI.Api.AuthorisationAndPaymentApi

All URIs are relative to *https://api.citypay.com*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**AuthorisationRequest**](AuthorisationAndPaymentApi.md#authorisationrequest) | **POST** /v6/authorise | Authorisation |
| [**BinRangeLookupRequest**](AuthorisationAndPaymentApi.md#binrangelookuprequest) | **POST** /v6/bin | Bin Lookup |
| [**CResRequest**](AuthorisationAndPaymentApi.md#cresrequest) | **POST** /v6/cres | CRes |
| [**CaptureRequest**](AuthorisationAndPaymentApi.md#capturerequest) | **POST** /v6/capture | Capture |
| [**CreatePaymentIntent**](AuthorisationAndPaymentApi.md#createpaymentintent) | **POST** /v6/intent/create | Create a Payment Intent |
| [**PaResRequest**](AuthorisationAndPaymentApi.md#paresrequest) | **POST** /v6/pares | PaRes |
| [**RefundRequest**](AuthorisationAndPaymentApi.md#refundrequest) | **POST** /v6/refund | Refund |
| [**RetrievalRequest**](AuthorisationAndPaymentApi.md#retrievalrequest) | **POST** /v6/retrieve | Retrieval |
| [**VoidRequest**](AuthorisationAndPaymentApi.md#voidrequest) | **POST** /v6/void | Void |

<a id="authorisationrequest"></a>
# **AuthorisationRequest**
> Decision AuthorisationRequest (AuthRequest authRequest)

Authorisation

Performs a request for authorisation for a card payment request.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using CityPayAPI.Api;
using CityPayAPI.Client;
using CityPayAPI.Model;

namespace Example
{
    public class AuthorisationRequestExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.citypay.com";
            // Create a temporal ApiKey using your client id and licence key
            config.AddApiKey("cp-api-key", new ApiKey("CLIENT_ID", "LICENCE_KEY").GenerateKey());

            var apiInstance = new AuthorisationAndPaymentApi(config);
            var authRequest = new AuthRequest(); // AuthRequest | 

            try
            {
                // Authorisation
                Decision result = apiInstance.AuthorisationRequest(authRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AuthorisationAndPaymentApi.AuthorisationRequest: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AuthorisationRequestWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Authorisation
    ApiResponse<Decision> response = apiInstance.AuthorisationRequestWithHttpInfo(authRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AuthorisationAndPaymentApi.AuthorisationRequestWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **authRequest** | [**AuthRequest**](AuthRequest.md) |  |  |

### Return type

[**Decision**](Decision.md)

### Authorization

[cp-api-key](../README.md#cp-api-key)

### HTTP request headers

 - **Content-Type**: application/json, text/xml
 - **Accept**: application/json, text/xml


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | A decision made by the result of processing. |  -  |
| **400** | Bad Request. Should the incoming data not be validly determined. |  -  |
| **401** | Unauthorized. No api key has been provided and is required for this operation. |  -  |
| **403** | Forbidden. The api key was provided and understood but is either incorrect or does not have permission to access the account provided on the request. |  -  |
| **422** | Unprocessable Entity. Should a failure occur that prevents processing of the API call. |  -  |
| **500** | Server Error. The server was unable to complete the request. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="binrangelookuprequest"></a>
# **BinRangeLookupRequest**
> Bin BinRangeLookupRequest (BinLookup binLookup)

Bin Lookup

A bin range lookup service can be used to check what a card is, as seen by the gateway. Each card number's 
leading digits help to identify who

0. the card scheme is such as Visa, MasterCard or American Express 
1. the issuer of the card, such as the bank
2. it's country of origin
3. it's currency of origin

Our gateway has 450 thousand possible bin ranges and uses a number of algorithms to determine the likelihood of the bin
data. The request requires a bin value of between 6 and 12 digits. The more digits provided may ensure a more accurate
result.


### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using CityPayAPI.Api;
using CityPayAPI.Client;
using CityPayAPI.Model;

namespace Example
{
    public class BinRangeLookupRequestExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.citypay.com";
            // Create a temporal ApiKey using your client id and licence key
            config.AddApiKey("cp-api-key", new ApiKey("CLIENT_ID", "LICENCE_KEY").GenerateKey());

            var apiInstance = new AuthorisationAndPaymentApi(config);
            var binLookup = new BinLookup(); // BinLookup | 

            try
            {
                // Bin Lookup
                Bin result = apiInstance.BinRangeLookupRequest(binLookup);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AuthorisationAndPaymentApi.BinRangeLookupRequest: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the BinRangeLookupRequestWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Bin Lookup
    ApiResponse<Bin> response = apiInstance.BinRangeLookupRequestWithHttpInfo(binLookup);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AuthorisationAndPaymentApi.BinRangeLookupRequestWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **binLookup** | [**BinLookup**](BinLookup.md) |  |  |

### Return type

[**Bin**](Bin.md)

### Authorization

[cp-api-key](../README.md#cp-api-key)

### HTTP request headers

 - **Content-Type**: application/json, text/xml
 - **Accept**: application/json, text/xml


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | A result of the bin lookup request returning a bin object determined by the gateway service. |  -  |
| **400** | Bad Request. Should the incoming data not be validly determined. |  -  |
| **401** | Unauthorized. No api key has been provided and is required for this operation. |  -  |
| **403** | Forbidden. The api key was provided and understood but is either incorrect or does not have permission to access the account provided on the request. |  -  |
| **422** | Unprocessable Entity. Should a failure occur that prevents processing of the API call. |  -  |
| **500** | Server Error. The server was unable to complete the request. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="cresrequest"></a>
# **CResRequest**
> AuthResponse CResRequest (CResAuthRequest cResAuthRequest)

CRes

The CRes request performs authorisation processing once a challenge request has been completed
with an Authentication Server (ACS). This challenge response contains confirmation that will
allow the API systems to return an authorisation response based on the result. Our systems will 
know out of band via an `RReq` call by the ACS to notify us if the liability shift has been issued.

Any call to the CRes operation will require a previous authorisation request and cannot be called 
on its own without a previous [request challenge](#requestchallenged) being obtained.


### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using CityPayAPI.Api;
using CityPayAPI.Client;
using CityPayAPI.Model;

namespace Example
{
    public class CResRequestExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.citypay.com";
            // Create a temporal ApiKey using your client id and licence key
            config.AddApiKey("cp-api-key", new ApiKey("CLIENT_ID", "LICENCE_KEY").GenerateKey());

            var apiInstance = new AuthorisationAndPaymentApi(config);
            var cResAuthRequest = new CResAuthRequest(); // CResAuthRequest | 

            try
            {
                // CRes
                AuthResponse result = apiInstance.CResRequest(cResAuthRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AuthorisationAndPaymentApi.CResRequest: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CResRequestWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // CRes
    ApiResponse<AuthResponse> response = apiInstance.CResRequestWithHttpInfo(cResAuthRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AuthorisationAndPaymentApi.CResRequestWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **cResAuthRequest** | [**CResAuthRequest**](CResAuthRequest.md) |  |  |

### Return type

[**AuthResponse**](AuthResponse.md)

### Authorization

[cp-api-key](../README.md#cp-api-key)

### HTTP request headers

 - **Content-Type**: application/json, text/xml
 - **Accept**: application/json, text/xml


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | A result of processing the 3DSv2 authorisation data. |  -  |
| **400** | Bad Request. Should the incoming data not be validly determined. |  -  |
| **401** | Unauthorized. No api key has been provided and is required for this operation. |  -  |
| **403** | Forbidden. The api key was provided and understood but is either incorrect or does not have permission to access the account provided on the request. |  -  |
| **422** | Unprocessable Entity. Should a failure occur that prevents processing of the API call. |  -  |
| **500** | Server Error. The server was unable to complete the request. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="capturerequest"></a>
# **CaptureRequest**
> Acknowledgement CaptureRequest (CaptureRequest captureRequest)

Capture

_The capture process only applies to transactions which have been pre-authorised only._ 

The capture process will ensure
that a transaction will now settle. It is expected that a capture call will be provided within 3 days or
a maximum of 7 days.

A capture request is provided to confirm that you wish the transaction to be settled. This request can
contain a final amount for the transaction which is different to the original authorisation amount. This
may be useful in a delayed system process such as waiting for stock to be ordered, confirmed, or services
provided before the final cost is known.

When a transaction is completed, a new authorisation code may be created and a new confirmation
can be sent online to the acquiring bank.

Once the transaction has been processed. A standard [`Acknowledgement`](#acknowledgement) will be returned,
outlining the result of the transaction. On a successful completion process, the transaction will
be available for the settlement and completed at the end of the day.


### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using CityPayAPI.Api;
using CityPayAPI.Client;
using CityPayAPI.Model;

namespace Example
{
    public class CaptureRequestExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.citypay.com";
            // Create a temporal ApiKey using your client id and licence key
            config.AddApiKey("cp-api-key", new ApiKey("CLIENT_ID", "LICENCE_KEY").GenerateKey());

            var apiInstance = new AuthorisationAndPaymentApi(config);
            var captureRequest = new CaptureRequest(); // CaptureRequest | 

            try
            {
                // Capture
                Acknowledgement result = apiInstance.CaptureRequest(captureRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AuthorisationAndPaymentApi.CaptureRequest: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CaptureRequestWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Capture
    ApiResponse<Acknowledgement> response = apiInstance.CaptureRequestWithHttpInfo(captureRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AuthorisationAndPaymentApi.CaptureRequestWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **captureRequest** | [**CaptureRequest**](CaptureRequest.md) |  |  |

### Return type

[**Acknowledgement**](Acknowledgement.md)

### Authorization

[cp-api-key](../README.md#cp-api-key)

### HTTP request headers

 - **Content-Type**: application/json, text/xml
 - **Accept**: application/json, text/xml


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | A result and acknowledgement of the capture request. The response will return a &#x60;000/001&#x60; response on a successful capture otherwise an error code response explaining the error. |  -  |
| **400** | Bad Request. Should the incoming data not be validly determined. |  -  |
| **401** | Unauthorized. No api key has been provided and is required for this operation. |  -  |
| **403** | Forbidden. The api key was provided and understood but is either incorrect or does not have permission to access the account provided on the request. |  -  |
| **422** | Unprocessable Entity. Should a failure occur that prevents processing of the API call. |  -  |
| **500** | Server Error. The server was unable to complete the request. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="createpaymentintent"></a>
# **CreatePaymentIntent**
> PaymentIntentReference CreatePaymentIntent (PaymentIntent paymentIntent)

Create a Payment Intent

This endpoint initiates the creation of a payment intent, which is a precursor to processing a payment. A payment intent
captures the details of a prospective payment transaction, including the payment amount, currency, and associated
billing and shipping information.


### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using CityPayAPI.Api;
using CityPayAPI.Client;
using CityPayAPI.Model;

namespace Example
{
    public class CreatePaymentIntentExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.citypay.com";
            // Create a temporal ApiKey using your client id and licence key
            config.AddApiKey("cp-api-key", new ApiKey("CLIENT_ID", "LICENCE_KEY").GenerateKey());

            var apiInstance = new AuthorisationAndPaymentApi(config);
            var paymentIntent = new PaymentIntent(); // PaymentIntent | 

            try
            {
                // Create a Payment Intent
                PaymentIntentReference result = apiInstance.CreatePaymentIntent(paymentIntent);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AuthorisationAndPaymentApi.CreatePaymentIntent: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreatePaymentIntentWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create a Payment Intent
    ApiResponse<PaymentIntentReference> response = apiInstance.CreatePaymentIntentWithHttpInfo(paymentIntent);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AuthorisationAndPaymentApi.CreatePaymentIntentWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **paymentIntent** | [**PaymentIntent**](PaymentIntent.md) |  |  |

### Return type

[**PaymentIntentReference**](PaymentIntentReference.md)

### Authorization

[cp-api-key](../README.md#cp-api-key)

### HTTP request headers

 - **Content-Type**: application/json, text/xml
 - **Accept**: application/json, text/xml


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returns the id of the payment intent. |  -  |
| **400** | Bad Request. Should the incoming data not be validly determined. |  -  |
| **401** | Unauthorized. No api key has been provided and is required for this operation. |  -  |
| **403** | Forbidden. The api key was provided and understood but is either incorrect or does not have permission to access the account provided on the request. |  -  |
| **422** | Unprocessable Entity. Should a failure occur that prevents processing of the API call. |  -  |
| **500** | Server Error. The server was unable to complete the request. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="paresrequest"></a>
# **PaResRequest**
> AuthResponse PaResRequest (PaResAuthRequest paResAuthRequest)

PaRes

The Payer Authentication Response (PaRes) is an operation after the result of authentication 
 being performed. The request uses an encoded packet of authentication data to 
notify us of the completion of the liability shift. Once this value has been unpacked and its
signature is checked, our systems will proceed to authorisation processing.  

Any call to the PaRes operation will require a previous authorisation request and cannot be called 
on its own without a previous [authentication required](#authenticationrequired)  being obtained.


### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using CityPayAPI.Api;
using CityPayAPI.Client;
using CityPayAPI.Model;

namespace Example
{
    public class PaResRequestExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.citypay.com";
            // Create a temporal ApiKey using your client id and licence key
            config.AddApiKey("cp-api-key", new ApiKey("CLIENT_ID", "LICENCE_KEY").GenerateKey());

            var apiInstance = new AuthorisationAndPaymentApi(config);
            var paResAuthRequest = new PaResAuthRequest(); // PaResAuthRequest | 

            try
            {
                // PaRes
                AuthResponse result = apiInstance.PaResRequest(paResAuthRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AuthorisationAndPaymentApi.PaResRequest: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PaResRequestWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // PaRes
    ApiResponse<AuthResponse> response = apiInstance.PaResRequestWithHttpInfo(paResAuthRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AuthorisationAndPaymentApi.PaResRequestWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **paResAuthRequest** | [**PaResAuthRequest**](PaResAuthRequest.md) |  |  |

### Return type

[**AuthResponse**](AuthResponse.md)

### Authorization

[cp-api-key](../README.md#cp-api-key)

### HTTP request headers

 - **Content-Type**: application/json, text/xml
 - **Accept**: application/json, text/xml


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | A result of processing the 3DSv1 authorisation data. |  -  |
| **400** | Bad Request. Should the incoming data not be validly determined. |  -  |
| **401** | Unauthorized. No api key has been provided and is required for this operation. |  -  |
| **403** | Forbidden. The api key was provided and understood but is either incorrect or does not have permission to access the account provided on the request. |  -  |
| **422** | Unprocessable Entity. Should a failure occur that prevents processing of the API call. |  -  |
| **500** | Server Error. The server was unable to complete the request. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="refundrequest"></a>
# **RefundRequest**
> AuthResponse RefundRequest (RefundRequest refundRequest)

Refund

A refund request which allows for the refunding of a previous transaction up 
and to the amount of the original sale. A refund will be performed against the 
original card used to process the transaction.


### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using CityPayAPI.Api;
using CityPayAPI.Client;
using CityPayAPI.Model;

namespace Example
{
    public class RefundRequestExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.citypay.com";
            // Create a temporal ApiKey using your client id and licence key
            config.AddApiKey("cp-api-key", new ApiKey("CLIENT_ID", "LICENCE_KEY").GenerateKey());

            var apiInstance = new AuthorisationAndPaymentApi(config);
            var refundRequest = new RefundRequest(); // RefundRequest | 

            try
            {
                // Refund
                AuthResponse result = apiInstance.RefundRequest(refundRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AuthorisationAndPaymentApi.RefundRequest: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the RefundRequestWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Refund
    ApiResponse<AuthResponse> response = apiInstance.RefundRequestWithHttpInfo(refundRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AuthorisationAndPaymentApi.RefundRequestWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **refundRequest** | [**RefundRequest**](RefundRequest.md) |  |  |

### Return type

[**AuthResponse**](AuthResponse.md)

### Authorization

[cp-api-key](../README.md#cp-api-key)

### HTTP request headers

 - **Content-Type**: application/json, text/xml
 - **Accept**: application/json, text/xml


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | A result of the refund of sale processing. |  -  |
| **400** | Bad Request. Should the incoming data not be validly determined. |  -  |
| **401** | Unauthorized. No api key has been provided and is required for this operation. |  -  |
| **403** | Forbidden. The api key was provided and understood but is either incorrect or does not have permission to access the account provided on the request. |  -  |
| **422** | Unprocessable Entity. Should a failure occur that prevents processing of the API call. |  -  |
| **500** | Server Error. The server was unable to complete the request. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="retrievalrequest"></a>
# **RetrievalRequest**
> AuthReferences RetrievalRequest (RetrieveRequest retrieveRequest)

Retrieval

A retrieval request which allows an integration to obtain the result of a transaction processed
in the last 90 days. The request allows for retrieval based on the identifier or transaction 
number. 

The process may return multiple results in particular where a transaction was processed multiple
times against the same identifier. This can happen if errors were first received. The API therefore
returns up to the first 5 transactions in the latest date time order.

It is not intended for this operation to be a replacement for reporting and only allows for base transaction
information to be returned.


### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using CityPayAPI.Api;
using CityPayAPI.Client;
using CityPayAPI.Model;

namespace Example
{
    public class RetrievalRequestExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.citypay.com";
            // Create a temporal ApiKey using your client id and licence key
            config.AddApiKey("cp-api-key", new ApiKey("CLIENT_ID", "LICENCE_KEY").GenerateKey());

            var apiInstance = new AuthorisationAndPaymentApi(config);
            var retrieveRequest = new RetrieveRequest(); // RetrieveRequest | 

            try
            {
                // Retrieval
                AuthReferences result = apiInstance.RetrievalRequest(retrieveRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AuthorisationAndPaymentApi.RetrievalRequest: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the RetrievalRequestWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieval
    ApiResponse<AuthReferences> response = apiInstance.RetrievalRequestWithHttpInfo(retrieveRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AuthorisationAndPaymentApi.RetrievalRequestWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **retrieveRequest** | [**RetrieveRequest**](RetrieveRequest.md) |  |  |

### Return type

[**AuthReferences**](AuthReferences.md)

### Authorization

[cp-api-key](../README.md#cp-api-key)

### HTTP request headers

 - **Content-Type**: application/json, text/xml
 - **Accept**: application/json, text/xml


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | A result of the retrieval request. |  -  |
| **400** | Bad Request. Should the incoming data not be validly determined. |  -  |
| **401** | Unauthorized. No api key has been provided and is required for this operation. |  -  |
| **403** | Forbidden. The api key was provided and understood but is either incorrect or does not have permission to access the account provided on the request. |  -  |
| **422** | Unprocessable Entity. Should a failure occur that prevents processing of the API call. |  -  |
| **500** | Server Error. The server was unable to complete the request. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="voidrequest"></a>
# **VoidRequest**
> Acknowledgement VoidRequest (VoidRequest voidRequest)

Void

_The void process generally applies to transactions which have been pre-authorised only however voids can occur 
on the same day if performed before batching and settlement._ 

The void process will ensure that a transaction will now settle. It is expected that a void call will be 
provided on the same day before batching and settlement or within 3 days or within a maximum of 7 days.

Once the transaction has been processed as a void, an [`Acknowledgement`](#acknowledgement) will be returned,
outlining the result of the transaction.


### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using CityPayAPI.Api;
using CityPayAPI.Client;
using CityPayAPI.Model;

namespace Example
{
    public class VoidRequestExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.citypay.com";
            // Create a temporal ApiKey using your client id and licence key
            config.AddApiKey("cp-api-key", new ApiKey("CLIENT_ID", "LICENCE_KEY").GenerateKey());

            var apiInstance = new AuthorisationAndPaymentApi(config);
            var voidRequest = new VoidRequest(); // VoidRequest | 

            try
            {
                // Void
                Acknowledgement result = apiInstance.VoidRequest(voidRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AuthorisationAndPaymentApi.VoidRequest: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the VoidRequestWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Void
    ApiResponse<Acknowledgement> response = apiInstance.VoidRequestWithHttpInfo(voidRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AuthorisationAndPaymentApi.VoidRequestWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **voidRequest** | [**VoidRequest**](VoidRequest.md) |  |  |

### Return type

[**Acknowledgement**](Acknowledgement.md)

### Authorization

[cp-api-key](../README.md#cp-api-key)

### HTTP request headers

 - **Content-Type**: application/json, text/xml
 - **Accept**: application/json, text/xml


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | &lt;/br&gt;A result and acknowledgement of the void request, returning an &#x60;080/003&#x60; response code on successful void/cancellation of the transaction.&lt;/br&gt;&lt;/br&gt;If an error occurs an error code will be returned explaining the failure. |  -  |
| **400** | Bad Request. Should the incoming data not be validly determined. |  -  |
| **401** | Unauthorized. No api key has been provided and is required for this operation. |  -  |
| **403** | Forbidden. The api key was provided and understood but is either incorrect or does not have permission to access the account provided on the request. |  -  |
| **422** | Unprocessable Entity. Should a failure occur that prevents processing of the API call. |  -  |
| **500** | Server Error. The server was unable to complete the request. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

