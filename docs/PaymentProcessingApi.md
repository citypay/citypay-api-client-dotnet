# CityPayAPI.Api.PaymentProcessingApi

All URIs are relative to *https://api.citypay.com/v6*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AuthorisationRequest**](PaymentProcessingApi.md#authorisationrequest) | **POST** /authorise | Authorisation
[**BinRangeLookupRequest**](PaymentProcessingApi.md#binrangelookuprequest) | **POST** /bin | Bin Lookup
[**CResRequest**](PaymentProcessingApi.md#cresrequest) | **POST** /cres | CRes
[**CaptureRequest**](PaymentProcessingApi.md#capturerequest) | **POST** /capture | Capture
[**PaResRequest**](PaymentProcessingApi.md#paresrequest) | **POST** /pares | PaRes
[**RefundRequest**](PaymentProcessingApi.md#refundrequest) | **POST** /refund | Refund
[**RetrievalRequest**](PaymentProcessingApi.md#retrievalrequest) | **POST** /retrieve | Retrieval
[**VoidRequest**](PaymentProcessingApi.md#voidrequest) | **POST** /void | Void


<a name="authorisationrequest"></a>
# **AuthorisationRequest**
> Decision AuthorisationRequest (AuthRequest authRequest)

Authorisation

An authorisation process performs a standard transaction authorisation based on the provided parameters of its request. The CityPay gateway will route your transaction via an Acquiring bank for subsequent authorisation to the appropriate card  schemes such as Visa or MasterCard.  The authorisation API should be used for server environments to process transactions on demand and in realtime.   The authorisation API can be used for multiple types of transactions including E-commerce, mail order, telephone order, customer present (keyed), continuous authority, pre-authorisation and others. CityPay will configure your account for  the appropriate coding and this will perform transparently by the gateway.   Data properties that are required, may depend on the environment you are conducting payment for. Our API aims to be  flexible enough to cater for these structures. Our integration team will aid you in providing the necessary data to   transact.      ### E-commerce workflows   For E-commerce transactions requiring 3DSv1 and 3DSv2 transactions, the API contains a fully accredited in built mechanism to handle authentication.  The gateway has been accredited extensively with both Acquirers and Card Schemes and simplifies the nature of these calls into a simple structure for authentication, preventing integrators from performing lengthy and a costly accreditation with Visa and MasterCard.  3D-secure has been around for a number of years and aims to shift the liability of a transaction away from a merchant back to the card holder. A *liability shift* determines whether a card holder can charge back a transaction as unknown. Effectively the process asks for a card holder to authenticate the transaction prior to authorisation producing a Cardholder  verification value (CAVV) as evidence of authorisation.   #### 3DSv1  ```json {    \"AuthenticationRequired\": {     \"acsurl\": \"https://bank.com/3DS/ACS\",     \"pareq\": \"SXQgd2FzIHRoZSBiZXN0IG9mIHRpbWVzLCBpdCB3YXMgdGhlIHdvcnN00...\",     \"md\": \"WQgZXZlcnl0aGluZyBiZW\"   }                } ```  ```xml <AuthenticationRequired>  <acsurl>https://bank.com/3DS/ACS</acsurl>  <pareq>SXQgd2FzIHRoZSBiZXN0IG9mIHRpbWVzLCBpdCB3YXMgdGhlIHdvcnN00...</pareq>  <md>WQgZXZlcnl0aGluZyBiZW</md> </AuthenticationRequired> ```  For E-commerce transactions requiring 3DSv1, the API contains a built in MPI which will be called to check whether the  card is participating in 3DSv1 with Verified by Visa or MasterCard SecureCode. We only support Amex SafeKey with 3DSv2. Should the card be enrolled, a payer  request (PAReq) value will be created and returned back as an [authentication required](#authenticationrequired) response object.   Your system will need to process this authentication packet and forward the user's browser to an authentication server (ACS)  to gain the user's authentication. Once complete, the ACS will produce a HTTP `POST` call back to the URL supplied in   the authentication request as `merchant_termurl`. This URL should behave as a controller and handle the post data from the   ACS and on a forked server to server HTTP request, forward this data to the [pares authentication url](#pares) for    subsequent authorisation processing. You may prefer to provide a processing page whilst this is being processed.   Processing with our systems should be relatively quick and be between 500ms - 3000ms however it is desirable to let   the user see that something is happening rather than a pending browser.      The main reason for ensuring that this controller is two fold:      1. We are never in control of the user's browser in a server API call   2. The controller is actioned on your site to ensure that any post actions from authorisation can be executed in real time    To forward the user to the ACS, we recommend a simple auto submit HTML form.  > Simple auto submit HTML form  ```html <html lang=\"en\"> <head>         <title>Forward to ACS</title> <script type=\"text/javascript\">         function onLoadEvent() {              document.acs.submit();          }         </script>         <noscript>You will require JavaScript to be enabled to complete this transaction</noscript>     </head>     <body onload=\"onLoadEvent();\">         <form name=\"acs\" action=\"{{ACSURL from Response}}\" method=\"POST\">             <input type=\"hidden\" name=\"PaReq\" value=\"{{PaReq Packet from Response}}\" />             <input type=\"hidden\" name=\"TermUrl\" value=\"{{Your Controller}}\" />             <input type=\"hidden\" name=\"MD\" value=\"{{MD From Response}}\" />         </form>     </body> </html> ```  Please note that 3DSv1 is being phased out due to changes to strong customer authentication mechanisms. 3DSv2 addresses this and will solidify the authorisation and confirmation process.  We provide a Test ACS for full 3DSv1 integration testing that simulates an ACS.    #### 3DSv2  ```json {    \"RequestChallenged\": {     \"acsurl\": \"https://bank.com/3DS/ACS\",     \"creq\": \"SXQgd2FzIHRoZSBiZXN0IG9mIHRpbWVzLCBpdCB3YXMgdGhlIHdvcnN00...\",     \"merchantid\": 12345,     \"transno\": 1,     \"threedserver_trans_id\": \"d652d8d2-d74a-4264-a051-a7862b10d5d6\"   }                } ```  ```xml <RequestChallenged>   <acsurl>https://bank.com/3DS/ACS</acsurl>   <creq>SXQgd2FzIHRoZSBiZXN0IG9mIHRpbWVzLCBpdCB3YXMgdGhlIHdvcnN00...</creq>   <merchantid>12345</merchantid>   <transno>1</transno>   <threedserver_trans_id>d652d8d2-d74a-4264-a051-a7862b10d5d6</threedserver_trans_id> </RequestChallenged> ```  All merchants in the EEC will require to migrate their E-commerce transactions to a secure customer authentication  model (SCA) throughout 2020. This has been adopted by the payment's industry as a progressive move alongside the European  Unions payments service directive.  CityPay support 3DSv2 for Verified by Visa, MasterCard Identity Check and American Express SafeKey 2.0 and will be rolling out acquirers on the new platform from Q4 2020. The new enhancement to 3DSv2 will allow for CityPay to seamlessly authenticate transactions in a \"frictionless\" flowed method which will authenticate low risk transactions with minimal impact to a  standard authorisation flow. Our API simply performs this on behalf of the merchant and cardholder. For these transactions you will not be required to change anything.  However, should a transaction be \"challenged\" the API will return a [request challenge](#requestchallenged) which will  require your integration to forward the cardholder's browser to the given [ACS url](#acsurl) by posting the [creq](#creq) value. Once complete, the ACS will have already been in touch with our servers by sending us a result of the authentication known as `RReq`.  To maintain session state, a parameter `ThreeDSSessionData` can be posted to the ACS url and will be returned alongside  the `CRes` value. This will ensure that any controller code will be able to isolate state between calls. This field is to be used by your own systems rather than ours and may be any value which can uniquely identify your cardholder's session. As an option, we do provide a `threedserver_trans_id` value in the `RequestChallenged` packet which can be used for the `ThreeDSSessionData` value as it is used to uniquely identify the 3D-Secure session.   Our servers however will await confirmation that the authorisation should continue and on receipt of a [cres](#cres) value, the flow will perform full authorisation processing.   Please note that the CRes returned to us is purely a mechanism of acknowledging that transactions should be committed for authorisation. The ACS by this point will have sent us the verification value (CAVV) to perform a liability shift. The CRes value will be validated for receipt of the CAVV and subsequently may return back response codes illustrating this.   To forward the user to the ACS, we recommend a simple auto submit HTML form.  > Simple auto submit HTML form  ```html <html lang=\"en\"> <head>         <title>Forward to ACS</title> <script type=\"text/javascript\">         function onLoadEvent() {              document.acs.submit();          }         </script>         <noscript>You will require JavaScript to be enabled to complete this transaction</noscript>     </head>     <body onload=\"onLoadEvent();\">         <form name=\"acs\" action=\"{{ACSURL from Response}}\" method=\"POST\">             <input type=\"hidden\" name=\"creq\" value=\"{{CReq Packet from Response}}\" />             <input type=\"hidden\" name=\"ThreeDSSessionData\" value=\"{{session-identifier}}\" />         </form>     </body> </html> ```  We are currently working on an integration test suite for 3DSv2 which will mock the ACS challenge process.          ### Testing 3DSv2 Integrations  The API provides a mock 3dsV2 handler which performs a number of scenarios based on the value of the CSC in the request.  | CSC Value | Behaviour | |- -- -- -- -- --|- -- -- -- -- --| | 731       | Frictionless processing - Not authenticated | | 732       | Frictionless processing - Account verification count not be performed |         | 733       | Frictionless processing - Verification Rejected |         | 741       | Frictionless processing - Attempts Processing |         | 750       | Frictionless processing - Authenticated  |         | 761       | Triggers an error message |   | Any       | Challenge Request | 

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
            config.BasePath = "https://api.citypay.com/v6";
            // Create a temporal ApiKey using your client id and licence key
            config.AddApiKey("cp-api-key", new ApiKey("CLIENT_ID", "LICENCE_KEY").GenerateKey());

            var apiInstance = new PaymentProcessingApi(config);
            var authRequest = new AuthRequest(); // AuthRequest | 

            try
            {
                // Authorisation
                Decision result = apiInstance.AuthorisationRequest(authRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PaymentProcessingApi.AuthorisationRequest: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **authRequest** | [**AuthRequest**](AuthRequest.md)|  | 

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
| **403** | Forbidden. The api key was provided and understood but is either incorrect or does not have permission to access the account provided on the request. |  -  |
| **401** | Unauthorized. No api key has been provided and is required for this operation. |  -  |
| **422** | Unprocessable Entity. Should a failure occur that prevents processing of the API call. |  -  |
| **400** | Bad Request. Should the incoming data not be validly determined. |  -  |
| **200** | A decision made by the result of processing. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="binrangelookuprequest"></a>
# **BinRangeLookupRequest**
> Bin BinRangeLookupRequest (BinLookup binLookup)

Bin Lookup

A bin range lookup service can be used to check what a card is, as seen by the gateway. Each card number's  leading digits help to identify who  0. the card scheme is such as Visa, MasterCard or American Express  1. the issuer of the card, such as the bank 2. it's country of origin 3. it's currency of origin  Our gateway has 450 thousand possible bin ranges and uses a number of algorithms to determine the likelihood of the bin data. The request requires a bin value of between 6 and 12 digits. The more digits provided may ensure a more accurate result. 

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
            config.BasePath = "https://api.citypay.com/v6";
            // Create a temporal ApiKey using your client id and licence key
            config.AddApiKey("cp-api-key", new ApiKey("CLIENT_ID", "LICENCE_KEY").GenerateKey());

            var apiInstance = new PaymentProcessingApi(config);
            var binLookup = new BinLookup(); // BinLookup | 

            try
            {
                // Bin Lookup
                Bin result = apiInstance.BinRangeLookupRequest(binLookup);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PaymentProcessingApi.BinRangeLookupRequest: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **binLookup** | [**BinLookup**](BinLookup.md)|  | 

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
| **403** | Forbidden. The api key was provided and understood but is either incorrect or does not have permission to access the account provided on the request. |  -  |
| **401** | Unauthorized. No api key has been provided and is required for this operation. |  -  |
| **422** | Unprocessable Entity. Should a failure occur that prevents processing of the API call. |  -  |
| **400** | Bad Request. Should the incoming data not be validly determined. |  -  |
| **200** | A result of the bin lookup request returning a bin object determined by the gateway service. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="cresrequest"></a>
# **CResRequest**
> AuthResponse CResRequest (CResAuthRequest cResAuthRequest)

CRes

The CRes request performs authorisation processing once a challenge request has been completed with an Authentication Server (ACS). This challenge response contains confirmation that will allow the API systems to return an authorisation response based on the result. Our systems will  know out of band via an `RReq` call by the ACS to notify us if the liability shift has been issued.  Any call to the CRes operation will require a previous authorisation request and cannot be called  on its own without a previous [request challenge](#requestchallenged) being obtained. 

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
            config.BasePath = "https://api.citypay.com/v6";
            // Create a temporal ApiKey using your client id and licence key
            config.AddApiKey("cp-api-key", new ApiKey("CLIENT_ID", "LICENCE_KEY").GenerateKey());

            var apiInstance = new PaymentProcessingApi(config);
            var cResAuthRequest = new CResAuthRequest(); // CResAuthRequest | 

            try
            {
                // CRes
                AuthResponse result = apiInstance.CResRequest(cResAuthRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PaymentProcessingApi.CResRequest: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **cResAuthRequest** | [**CResAuthRequest**](CResAuthRequest.md)|  | 

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
| **403** | Forbidden. The api key was provided and understood but is either incorrect or does not have permission to access the account provided on the request. |  -  |
| **401** | Unauthorized. No api key has been provided and is required for this operation. |  -  |
| **422** | Unprocessable Entity. Should a failure occur that prevents processing of the API call. |  -  |
| **400** | Bad Request. Should the incoming data not be validly determined. |  -  |
| **200** | A result of processing the 3DSv2 authorisation data. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="capturerequest"></a>
# **CaptureRequest**
> Acknowledgement CaptureRequest (CaptureRequest captureRequest)

Capture

_The capture process only applies to transactions which have been pre-authorised only._   The capture process will ensure that a transaction will now settle. It is expected that a capture call will be provided within 3 days or a maximum of 7 days.  A capture request is provided to confirm that you wish the transaction to be settled. This request can contain a final amount for the transaction which is different to the original authorisation amount. This may be useful in a delayed system process such as waiting for stock to be ordered, confirmed, or services provided before the final cost is known.  When a transaction is completed, a new authorisation code may be created and a new confirmation can be sent online to the acquiring bank.  Once the transaction has been processed. A standard [`Acknowledgement`](#acknowledgement) will be returned, outlining the result of the transaction. On a successful completion process, the transaction will be available for the settlement and completed at the end of the day. 

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
            config.BasePath = "https://api.citypay.com/v6";
            // Create a temporal ApiKey using your client id and licence key
            config.AddApiKey("cp-api-key", new ApiKey("CLIENT_ID", "LICENCE_KEY").GenerateKey());

            var apiInstance = new PaymentProcessingApi(config);
            var captureRequest = new CaptureRequest(); // CaptureRequest | 

            try
            {
                // Capture
                Acknowledgement result = apiInstance.CaptureRequest(captureRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PaymentProcessingApi.CaptureRequest: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **captureRequest** | [**CaptureRequest**](CaptureRequest.md)|  | 

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
| **403** | Forbidden. The api key was provided and understood but is either incorrect or does not have permission to access the account provided on the request. |  -  |
| **401** | Unauthorized. No api key has been provided and is required for this operation. |  -  |
| **422** | Unprocessable Entity. Should a failure occur that prevents processing of the API call. |  -  |
| **400** | Bad Request. Should the incoming data not be validly determined. |  -  |
| **200** | A result and acknowledgement of the capture request. The response will return a &#x60;000/001&#x60; response on a successful capture otherwise an error code response explaining the error. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="paresrequest"></a>
# **PaResRequest**
> AuthResponse PaResRequest (PaResAuthRequest paResAuthRequest)

PaRes

The Payer Authentication Response (PaRes) is an operation after the result of authentication   being performed. The request uses an encoded packet of authentication data to  notify us of the completion of the liability shift. Once this value has been unpacked and its signature is checked, our systems will proceed to authorisation processing.    Any call to the PaRes operation will require a previous authorisation request and cannot be called  on its own without a previous [authentication required](#authenticationrequired)  being obtained. 

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
            config.BasePath = "https://api.citypay.com/v6";
            // Create a temporal ApiKey using your client id and licence key
            config.AddApiKey("cp-api-key", new ApiKey("CLIENT_ID", "LICENCE_KEY").GenerateKey());

            var apiInstance = new PaymentProcessingApi(config);
            var paResAuthRequest = new PaResAuthRequest(); // PaResAuthRequest | 

            try
            {
                // PaRes
                AuthResponse result = apiInstance.PaResRequest(paResAuthRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PaymentProcessingApi.PaResRequest: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **paResAuthRequest** | [**PaResAuthRequest**](PaResAuthRequest.md)|  | 

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
| **403** | Forbidden. The api key was provided and understood but is either incorrect or does not have permission to access the account provided on the request. |  -  |
| **401** | Unauthorized. No api key has been provided and is required for this operation. |  -  |
| **422** | Unprocessable Entity. Should a failure occur that prevents processing of the API call. |  -  |
| **400** | Bad Request. Should the incoming data not be validly determined. |  -  |
| **200** | A result of processing the 3DSv1 authorisation data. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="refundrequest"></a>
# **RefundRequest**
> AuthResponse RefundRequest (RefundRequest refundRequest)

Refund

A refund request which allows for the refunding of a previous transaction up  and to the amount of the original sale. A refund will be performed against the  original card used to process the transaction. 

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
            config.BasePath = "https://api.citypay.com/v6";
            // Create a temporal ApiKey using your client id and licence key
            config.AddApiKey("cp-api-key", new ApiKey("CLIENT_ID", "LICENCE_KEY").GenerateKey());

            var apiInstance = new PaymentProcessingApi(config);
            var refundRequest = new RefundRequest(); // RefundRequest | 

            try
            {
                // Refund
                AuthResponse result = apiInstance.RefundRequest(refundRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PaymentProcessingApi.RefundRequest: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **refundRequest** | [**RefundRequest**](RefundRequest.md)|  | 

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
| **403** | Forbidden. The api key was provided and understood but is either incorrect or does not have permission to access the account provided on the request. |  -  |
| **401** | Unauthorized. No api key has been provided and is required for this operation. |  -  |
| **422** | Unprocessable Entity. Should a failure occur that prevents processing of the API call. |  -  |
| **400** | Bad Request. Should the incoming data not be validly determined. |  -  |
| **200** | A result of the refund of sale processing. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="retrievalrequest"></a>
# **RetrievalRequest**
> AuthReferences RetrievalRequest (RetrieveRequest retrieveRequest)

Retrieval

A retrieval request which allows an integration to obtain the result of a transaction processed in the last 90 days. The request allows for retrieval based on the identifier or transaction  number.   The process may return multiple results in particular where a transaction was processed multiple times against the same identifier. This can happen if errors were first received. The API therefore returns up to the first 5 transactions in the latest date time order.  It is not intended for this operation to be a replacement for reporting and only allows for base transaction information to be returned. 

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
            config.BasePath = "https://api.citypay.com/v6";
            // Create a temporal ApiKey using your client id and licence key
            config.AddApiKey("cp-api-key", new ApiKey("CLIENT_ID", "LICENCE_KEY").GenerateKey());

            var apiInstance = new PaymentProcessingApi(config);
            var retrieveRequest = new RetrieveRequest(); // RetrieveRequest | 

            try
            {
                // Retrieval
                AuthReferences result = apiInstance.RetrievalRequest(retrieveRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PaymentProcessingApi.RetrievalRequest: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **retrieveRequest** | [**RetrieveRequest**](RetrieveRequest.md)|  | 

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
| **403** | Forbidden. The api key was provided and understood but is either incorrect or does not have permission to access the account provided on the request. |  -  |
| **401** | Unauthorized. No api key has been provided and is required for this operation. |  -  |
| **422** | Unprocessable Entity. Should a failure occur that prevents processing of the API call. |  -  |
| **400** | Bad Request. Should the incoming data not be validly determined. |  -  |
| **200** | A result of the retrieval request. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="voidrequest"></a>
# **VoidRequest**
> Acknowledgement VoidRequest (VoidRequest voidRequest)

Void

_The void process generally applies to transactions which have been pre-authorised only however voids can occur  on the same day if performed before batching and settlement._   The void process will ensure that a transaction will now settle. It is expected that a void call will be  provided on the same day before batching and settlement or within 3 days or within a maximum of 7 days.  Once the transaction has been processed as a void, an [`Acknowledgement`](#acknowledgement) will be returned, outlining the result of the transaction. 

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
            config.BasePath = "https://api.citypay.com/v6";
            // Create a temporal ApiKey using your client id and licence key
            config.AddApiKey("cp-api-key", new ApiKey("CLIENT_ID", "LICENCE_KEY").GenerateKey());

            var apiInstance = new PaymentProcessingApi(config);
            var voidRequest = new VoidRequest(); // VoidRequest | 

            try
            {
                // Void
                Acknowledgement result = apiInstance.VoidRequest(voidRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PaymentProcessingApi.VoidRequest: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **voidRequest** | [**VoidRequest**](VoidRequest.md)|  | 

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
| **403** | Forbidden. The api key was provided and understood but is either incorrect or does not have permission to access the account provided on the request. |  -  |
| **401** | Unauthorized. No api key has been provided and is required for this operation. |  -  |
| **422** | Unprocessable Entity. Should a failure occur that prevents processing of the API call. |  -  |
| **400** | Bad Request. Should the incoming data not be validly determined. |  -  |
| **200** | &lt;/br&gt;A result and acknowledgement of the void request, returning an &#x60;080/003&#x60; response code on successful void/cancellation of the transaction.&lt;/br&gt;&lt;/br&gt;If an error occurs an error code will be returned explaining the failure. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

