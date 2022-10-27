# CityPayAPI.Api.AuthorisationAndPaymentAPI

All URIs are relative to *https://api.citypay.com*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**AuthorisationRequest**](AuthorisationAndPaymentAPI.md#authorisationrequest) | **POST** /v6/authorise | Authorisation |
| [**BinRangeLookupRequest**](AuthorisationAndPaymentAPI.md#binrangelookuprequest) | **POST** /v6/bin | Bin Lookup |
| [**CResRequest**](AuthorisationAndPaymentAPI.md#cresrequest) | **POST** /v6/cres | CRes |
| [**CaptureRequest**](AuthorisationAndPaymentAPI.md#capturerequest) | **POST** /v6/capture | Capture |
| [**PaResRequest**](AuthorisationAndPaymentAPI.md#paresrequest) | **POST** /v6/pares | PaRes |
| [**RefundRequest**](AuthorisationAndPaymentAPI.md#refundrequest) | **POST** /v6/refund | Refund |
| [**RetrievalRequest**](AuthorisationAndPaymentAPI.md#retrievalrequest) | **POST** /v6/retrieve | Retrieval |
| [**VoidRequest**](AuthorisationAndPaymentAPI.md#voidrequest) | **POST** /v6/void | Void |

<a name="authorisationrequest"></a>
# **AuthorisationRequest**
> Decision AuthorisationRequest (AuthRequest authRequest)

Authorisation

An authorisation process performs a standard transaction authorisation based on the provided parameters of its request.
The CityPay gateway will route your transaction via an Acquiring bank for subsequent authorisation to the appropriate card 
schemes such as Visa or MasterCard.

The authorisation API should be used for server environments to process transactions on demand and in realtime. 

The authorisation API can be used for multiple types of transactions including E-commerce, mail order, telephone order,
customer present (keyed), continuous authority, pre-authorisation and others. CityPay will configure your account for 
the appropriate coding and this will perform transparently by the gateway. 

Data properties that are required, may depend on the environment you are conducting payment for. Our API aims to be
 flexible enough to cater for these structures. Our integration team will aid you in providing the necessary data to 
 transact. 
 
 
## E-commerce workflows
 
For E-commerce transactions requiring 3DS, the API contains a fully accredited in built mechanism to handle authentication.

The Api and gateway has been accredited extensively with both Acquirers and Card Schemes to simplify the nature of these calls
into a simple structure for authentication, preventing integrators from performing lengthy and a costly accreditations with
Visa and MasterCard.

3D-secure has been around for a number of years and aims to shift the liability of a transaction away from a merchant back
to the card holder. A *liability shift* determines whether a card holder can charge back a transaction as unknown. Effectively
the process asks for a card holder to authenticate the transaction prior to authorisation producing a Cardholder 
verification value (CAVV) and ecommerce indicator (ECI) as evidence of authorisation.

3DS version 1 has now been replaced by 3DS version 2 to provide secure customer authentication (SCA) in line with EU regulation.
3DSv2 is being phased out and any accounts using version 1 of the protocol is expected to be migrated by March 2022. 

Any new integrations should only consider 3DSv2 flows. 

### 3DSv2

```json
{ 
  "RequestChallenged": {
    "acsurl": "https://bank.com/3DS/ACS",
    "creq": "SXQgd2FzIHRoZSBiZXN0IG9mIHRpbWVzLCBpdCB3YXMgdGhlIHdvcnN00...",
    "merchantid": 12345,
    "transno": 1,
    "threedserver_trans_id": "d652d8d2-d74a-4264-a051-a7862b10d5d6"
  }               
}
```

```xml
<RequestChallenged>
  <acsurl>https://bank.com/3DS/ACS</acsurl>
  <creq>SXQgd2FzIHRoZSBiZXN0IG9mIHRpbWVzLCBpdCB3YXMgdGhlIHdvcnN00...</creq>
  <merchantid>12345</merchantid>
  <transno>1</transno>
  <threedserver_trans_id>d652d8d2-d74a-4264-a051-a7862b10d5d6</threedserver_trans_id>
</RequestChallenged>
```

CityPay support 3DS version 2.1 for Verified by Visa, MasterCard Identity Check and American Express SafeKey 2.1. Version
2.2 is currently in development however this will be a seamless upgrade for all integrations.

#### 3-D Secure - None

![3DSv2 Frctionless Flow](/images/3dsv2-no3d.png)

A basic flow may involve no 3-D secure processing. This could happen if there is no ability to perform authentication.
An enrollment check may apply an "attempted" resolution to processing. In this instance a transaction may not meet any
liability shift. A transaction may result in a decline due to this. We are also able to prevent from transactions being
presented for authorisation if this occurs. 

#### 3-D Secure - Frictionless

![3DSv2 Frctionless Flow](/images/3dsv2-frictionless.png)

E-commerce transactions supporting 3DSv2 can benefit from seamlessly authenticated transactions which may perform a 
"frictionless" flow. This method will authenticate low risk transactions with minimal impact to a 
standard authorisation flow. Our API simply performs this on behalf of you the developer, the merchant and cardholder.

No redirection occurs and hence the flow is called frictionless and will appear as though a simple transaction 
authorisation has occurred.

#### 3-D Secure - Challenge

![3DSv2 Frctionless Flow](/images/3dsv2-challenge.png)

A transaction that is deemed as higher risk my be "challenged". In this instance, the API will return a
[request challenge](#requestchallenged) which will require your integration to forward the cardholder's browser to the 
given [ACS url](#acsurl). This should be performed by posting the [creq](#creq) value (the challenge request value). 

Once complete, the ACS will have already been in touch with our servers by sending us a result of the authentication
known as `RReq`.

To maintain session state, a parameter `threeDSSessionData` can be posted to the ACS url and will be returned alongside 
the `CRes` value. This will ensure that any controller code will be able to isolate state between calls. This field
is to be used by your own systems rather than ours and may be any value which can uniquely identify your cardholder's
session. As an option, we do provide a `threedserver_trans_id` value in the `RequestChallenged` packet which can be used
for the `threeDSSessionData` value as it is used to uniquely identify the 3D-Secure session. 

A common method of maintaining state is to provide a session related query string value in the `merchant_termurl` value
(also known as the `notificationUrl`). For example providing a url of `https://mystore.com/checkout?token=asny2348w4561..`
could return the user directly back to their session with your environment.

Once you have received a `cres` post from the ACS authentication service, this should be POSTed to the [cres](#cres) 
endpoint to perform full authorisation processing. 

Please note that the CRes returned to us is purely a mechanism of acknowledging that transactions should be committed for
authorisation. The ACS by this point will have sent us the verification value (CAVV) to perform a liability shift. The CRes
value will be validated for receipt of the CAVV and subsequently may return response codes illustrating this. 

To forward the user to the ACS, we recommend a simple auto submit HTML form.

> Simple auto submit HTML form

```html
<html lang="en">
<head>
        <title>Forward to ACS</title>
<script type="text/javascript">
        function onLoadEvent() { 
            document.acs.submit(); 
        }
        </script>
        <noscript>You will require JavaScript to be enabled to complete this transaction</noscript>
    </head>
    <body onload="onLoadEvent();">
        <form name="acs" action="{{ACSURL from Response}}" method="POST">
            <input type="hidden" name="creq" value="{{CReq Packet from Response}}" />
            <input type="hidden" name="threeDSSessionData" value="{{session-identifier}}" />
        </form>
    </body>
</html>
```

A full ACS test suite is available for 3DSv2 testing.
        
### Testing 3DSv2 Integrations

The API provides a mock 3dsV2 handler which performs a number of scenarios based on the value of the CSC in the request.

| CSC Value | Behaviour |
|-----------|-----------|
| 731       | Frictionless processing - Not authenticated |
| 732       | Frictionless processing - Account verification count not be performed |        
| 733       | Frictionless processing - Verification Rejected |        
| 741       | Frictionless processing - Attempts Processing |        
| 750       | Frictionless processing - Authenticated  |        
| 761       | Triggers an error message |  
| Any       | Challenge Request |       


#### 3DSv1

**Please note that 3DSv1 should now be considered as deprecated.**

```json
{ 
  "AuthenticationRequired": {
    "acsurl": "https://bank.com/3DS/ACS",
    "pareq": "SXQgd2FzIHRoZSBiZXN0IG9mIHRpbWVzLCBpdCB3YXMgdGhlIHdvcnN00...",
    "md": "WQgZXZlcnl0aGluZyBiZW"
  }               
}
```

```xml
<AuthenticationRequired>
 <acsurl>https://bank.com/3DS/ACS</acsurl>
 <pareq>SXQgd2FzIHRoZSBiZXN0IG9mIHRpbWVzLCBpdCB3YXMgdGhlIHdvcnN00...</pareq>
 <md>WQgZXZlcnl0aGluZyBiZW</md>
</AuthenticationRequired>
```

For E-commerce transactions requiring 3DSv1, the API contains a built in MPI which will be called to check whether the
card is participating in 3DSv1 with Verified by Visa or MasterCard SecureCode. We only support Amex SafeKey with 3DSv2. Should the card be enrolled, a payer
request (PAReq) value will be created and returned back as an [authentication required](#authenticationrequired) response object.

Your system will need to process this authentication packet and forward the user's browser to an authentication server (ACS)
to gain the user's authentication. Once complete, the ACS will produce a HTTP `POST` call back to the URL supplied in
the authentication request as `merchant_termurl`. This URL should behave as a controller and handle the post data from the
ACS and on a forked server to server HTTP request, forward this data to the [pares authentication url](#pares) for
subsequent authorisation processing. You may prefer to provide a processing page whilst this is being processed.
Processing with our systems should be relatively quick and be between 500ms - 3000ms however it is desirable to let
the user see that something is happening rather than a pending browser.

The main reason for ensuring that this controller is two fold:

1. We are never in control of the user's browser in a server API call
2. The controller is actioned on your site to ensure that any post actions from authorisation can be executed in real time

To forward the user to the ACS, we recommend a simple auto submit HTML form.

> Simple auto submit HTML form

```html
<html lang="en">
<head>
        <title>Forward to ACS</title>
<script type="text/javascript">
        function onLoadEvent() { 
            document.acs.submit(); 
        }
        </script>
        <noscript>You will require JavaScript to be enabled to complete this transaction</noscript>
    </head>
    <body onload="onLoadEvent();">
        <form name="acs" action="{{ACSURL from Response}}" method="POST">
            <input type="hidden" name="PaReq" value="{{PaReq Packet from Response}}" />
            <input type="hidden" name="TermUrl" value="{{Your Controller}}" />
            <input type="hidden" name="MD" value="{{MD From Response}}" />
        </form>
    </body>
</html>
```

Please note that 3DSv1 is being phased out due to changes to strong customer authentication mechanisms. 3DSv2 addresses
this and will solidify the authorisation and confirmation process.

We provide a Test ACS for full 3DSv1 integration testing that simulates an ACS.


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
            // Configure API key authorization: cp-api-key
            config.AddApiKey("cp-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("cp-api-key", "Bearer");

            var apiInstance = new AuthorisationAndPaymentAPI(config);
            var authRequest = new AuthRequest(); // AuthRequest | 

            try
            {
                // Authorisation
                Decision result = apiInstance.AuthorisationRequest(authRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AuthorisationAndPaymentAPI.AuthorisationRequest: " + e.Message);
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
    Debug.Print("Exception when calling AuthorisationAndPaymentAPI.AuthorisationRequestWithHttpInfo: " + e.Message);
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

<a name="binrangelookuprequest"></a>
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
            // Configure API key authorization: cp-api-key
            config.AddApiKey("cp-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("cp-api-key", "Bearer");

            var apiInstance = new AuthorisationAndPaymentAPI(config);
            var binLookup = new BinLookup(); // BinLookup | 

            try
            {
                // Bin Lookup
                Bin result = apiInstance.BinRangeLookupRequest(binLookup);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AuthorisationAndPaymentAPI.BinRangeLookupRequest: " + e.Message);
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
    Debug.Print("Exception when calling AuthorisationAndPaymentAPI.BinRangeLookupRequestWithHttpInfo: " + e.Message);
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

<a name="cresrequest"></a>
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
            // Configure API key authorization: cp-api-key
            config.AddApiKey("cp-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("cp-api-key", "Bearer");

            var apiInstance = new AuthorisationAndPaymentAPI(config);
            var cResAuthRequest = new CResAuthRequest(); // CResAuthRequest | 

            try
            {
                // CRes
                AuthResponse result = apiInstance.CResRequest(cResAuthRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AuthorisationAndPaymentAPI.CResRequest: " + e.Message);
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
    Debug.Print("Exception when calling AuthorisationAndPaymentAPI.CResRequestWithHttpInfo: " + e.Message);
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

<a name="capturerequest"></a>
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
            // Configure API key authorization: cp-api-key
            config.AddApiKey("cp-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("cp-api-key", "Bearer");

            var apiInstance = new AuthorisationAndPaymentAPI(config);
            var captureRequest = new CaptureRequest(); // CaptureRequest | 

            try
            {
                // Capture
                Acknowledgement result = apiInstance.CaptureRequest(captureRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AuthorisationAndPaymentAPI.CaptureRequest: " + e.Message);
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
    Debug.Print("Exception when calling AuthorisationAndPaymentAPI.CaptureRequestWithHttpInfo: " + e.Message);
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

<a name="paresrequest"></a>
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
            // Configure API key authorization: cp-api-key
            config.AddApiKey("cp-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("cp-api-key", "Bearer");

            var apiInstance = new AuthorisationAndPaymentAPI(config);
            var paResAuthRequest = new PaResAuthRequest(); // PaResAuthRequest | 

            try
            {
                // PaRes
                AuthResponse result = apiInstance.PaResRequest(paResAuthRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AuthorisationAndPaymentAPI.PaResRequest: " + e.Message);
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
    Debug.Print("Exception when calling AuthorisationAndPaymentAPI.PaResRequestWithHttpInfo: " + e.Message);
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

<a name="refundrequest"></a>
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
            // Configure API key authorization: cp-api-key
            config.AddApiKey("cp-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("cp-api-key", "Bearer");

            var apiInstance = new AuthorisationAndPaymentAPI(config);
            var refundRequest = new RefundRequest(); // RefundRequest | 

            try
            {
                // Refund
                AuthResponse result = apiInstance.RefundRequest(refundRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AuthorisationAndPaymentAPI.RefundRequest: " + e.Message);
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
    Debug.Print("Exception when calling AuthorisationAndPaymentAPI.RefundRequestWithHttpInfo: " + e.Message);
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

<a name="retrievalrequest"></a>
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
            // Configure API key authorization: cp-api-key
            config.AddApiKey("cp-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("cp-api-key", "Bearer");

            var apiInstance = new AuthorisationAndPaymentAPI(config);
            var retrieveRequest = new RetrieveRequest(); // RetrieveRequest | 

            try
            {
                // Retrieval
                AuthReferences result = apiInstance.RetrievalRequest(retrieveRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AuthorisationAndPaymentAPI.RetrievalRequest: " + e.Message);
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
    Debug.Print("Exception when calling AuthorisationAndPaymentAPI.RetrievalRequestWithHttpInfo: " + e.Message);
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

<a name="voidrequest"></a>
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
            // Configure API key authorization: cp-api-key
            config.AddApiKey("cp-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("cp-api-key", "Bearer");

            var apiInstance = new AuthorisationAndPaymentAPI(config);
            var voidRequest = new VoidRequest(); // VoidRequest | 

            try
            {
                // Void
                Acknowledgement result = apiInstance.VoidRequest(voidRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AuthorisationAndPaymentAPI.VoidRequest: " + e.Message);
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
    Debug.Print("Exception when calling AuthorisationAndPaymentAPI.VoidRequestWithHttpInfo: " + e.Message);
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

