# CityPayAPI.Api.DirectPostAPIApi

All URIs are relative to *https://api.citypay.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**DirectCResRequest**](DirectPostAPIApi.md#directcresrequest) | **POST** /direct/cres/{uuid} | Handles CRes response from ACS
[**DirectPostRequest**](DirectPostAPIApi.md#directpostrequest) | **POST** /direct | Direct Post Request
[**TokenRequest**](DirectPostAPIApi.md#tokenrequest) | **POST** /direct/auth | Direct Post Token Request


<a name="directcresrequest"></a>
# **DirectCResRequest**
> OneOfTokenisationResponseModelAuthResponse DirectCResRequest (string uuid, string cres = null, string threeDSSessionData = null)

Handles CRes response from ACS

Used to post from an ACS during a ThreeDSecure direct flow process. The endpoint requires a valid `threeDSSessionData` value which defines the unique transaction through its workflow. This endpoint may be used by merchants wishing to  perform a `Direct Post` integration who wish to handle the challenge flow themselves. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using CityPayAPI.Api;
using CityPayAPI.Client;
using CityPayAPI.Model;

namespace Example
{
    public class DirectCResRequestExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.citypay.com";
            var apiInstance = new DirectPostAPIApi(config);
            var uuid = uuid_example;  // string | An identifier used to track the CReq/CRes cycle.
            var cres = cres_example;  // string | The CRES from the ACS. (optional) 
            var threeDSSessionData = threeDSSessionData_example;  // string | The session data from the ACS. (optional) 

            try
            {
                // Handles CRes response from ACS
                OneOfTokenisationResponseModelAuthResponse result = apiInstance.DirectCResRequest(uuid, cres, threeDSSessionData);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DirectPostAPIApi.DirectCResRequest: " + e.Message );
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
 **uuid** | **string**| An identifier used to track the CReq/CRes cycle. | 
 **cres** | **string**| The CRES from the ACS. | [optional] 
 **threeDSSessionData** | **string**| The session data from the ACS. | [optional] 

### Return type

[**OneOfTokenisationResponseModelAuthResponse**](OneOfTokenisationResponseModelAuthResponse.md)

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

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="directpostrequest"></a>
# **DirectPostRequest**
> OneOfTokenisationResponseModelAuthResponse DirectPostRequest (int amount, string cardnumber, int expmonth, int expyear, string identifier, string avsPostcodePolicy = null, ContactDetails billTo = null, string csc = null, string cscPolicy = null, string currency = null, string duplicatePolicy = null, string matchAvsa = null, string nameOnCard = null, string nonce = null, string redirectFailure = null, string redirectSuccess = null, ContactDetails shipTo = null, ThreeDSecure threedsecure = null, bool? tokenise = null, string transInfo = null, string transType = null)

Direct Post Request

Used to initiate a direct post request transaction flow.  <pre class=\"inline-code language-bash\"> <code> curl https://api.citypay.com/v6/direct?cp-domain-key=n834ytqp84y... \\  -d \"amount=7500&identifier=example_trans&cardnumber=4000000000000002&expmonth=9&expyear=2028&bill_to_postcode=L1+7ZW </code> </pre>. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using CityPayAPI.Api;
using CityPayAPI.Client;
using CityPayAPI.Model;

namespace Example
{
    public class DirectPostRequestExample
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

            var apiInstance = new DirectPostAPIApi(config);
            var amount = 56;  // int | The amount to authorise in the lowest unit of currency with a variable length to a maximum of 12 digits.  No decimal points are to be included and no divisional characters such as 1,024.  The amount should be the total amount required for the transaction.  For example with GBP £1,021.95 the amount value is 102195. 
            var cardnumber = cardnumber_example;  // string | The card number (PAN) with a variable length to a maximum of 21 digits in numerical form. Any non numeric characters will be stripped out of the card number, this includes whitespace or separators internal of the provided value.  The card number must be treated as sensitive data. We only provide an obfuscated value in logging and reporting.  The plaintext value is encrypted in our database using AES 256 GMC bit encryption for settlement or refund purposes.  When providing the card number to our gateway through the authorisation API you will be handling the card data on your application. This will require further PCI controls to be in place and this value must never be stored. 
            var expmonth = 56;  // int | The month of expiry of the card. The month value should be a numerical value between 1 and 12. 
            var expyear = 56;  // int | The year of expiry of the card. 
            var identifier = identifier_example;  // string | The identifier of the transaction to process. The value should be a valid reference and may be used to perform  post processing actions and to aid in reconciliation of transactions.  The value should be a valid printable string with ASCII character ranges from 0x32 to 0x127.  The identifier is recommended to be distinct for each transaction such as a [random unique identifier](https://en.wikipedia.org/wiki/Universally_unique_identifier) this will aid in ensuring each transaction is identifiable.  When transactions are processed they are also checked for duplicate requests. Changing the identifier on a subsequent request will ensure that a transaction is considered as different. 
            var avsPostcodePolicy = avsPostcodePolicy_example;  // string | A policy value which determines whether an AVS postcode policy is enforced or bypassed.  Values are  `0` for the default policy (default value if not supplied). Your default values are determined by your account manager on setup of the account.   `1` for an enforced policy. Transactions that are enforced will be rejected if the AVS postcode numeric value does not match.   `2` to bypass. Transactions that are bypassed will be allowed through even if the postcode did not match.   `3` to ignore. Transactions that are ignored will bypass the result and not send postcode details for authorisation.  (optional) 
            var billTo = new ContactDetails(); // ContactDetails |  (optional) 
            var csc = csc_example;  // string | The Card Security Code (CSC) (also known as CV2/CVV2) is normally found on the back of the card (American Express has it on the front). The value helps to identify posession of the card as it is not available within the chip or magnetic swipe.  When forwarding the CSC, please ensure the value is a string as some values start with 0 and this will be stripped out by any integer parsing.  The CSC number aids fraud prevention in Mail Order and Internet payments.  Business rules are available on your account to identify whether to accept or decline transactions based on mismatched results of the CSC.  The Payment Card Industry (PCI) requires that at no stage of a transaction should the CSC be stored.  This applies to all entities handling card data.  It should also not be used in any hashing process.  CityPay do not store the value and have no method of retrieving the value once the transaction has been processed. For this reason, duplicate checking is unable to determine the CSC in its duplication check algorithm.  (optional) 
            var cscPolicy = cscPolicy_example;  // string | A policy value which determines whether a CSC policy is enforced or bypassed.  Values are  `0` for the default policy (default value if not supplied). Your default values are determined by your account manager on setup of the account.   `1` for an enforced policy. Transactions that are enforced will be rejected if the CSC value does not match.   `2` to bypass. Transactions that are bypassed will be allowed through even if the CSC did not match.   `3` to ignore. Transactions that are ignored will bypass the result and not send the CSC details for authorisation.  (optional) 
            var currency = currency_example;  // string | The processing currency for the transaction. Will default to the merchant account currency. (optional) 
            var duplicatePolicy = duplicatePolicy_example;  // string | A policy value which determines whether a duplication policy is enforced or bypassed. A duplication check has a window of time set against your account within which it can action. If a previous transaction with matching values occurred within the window, any subsequent transaction will result in a T001 result.  Values are  `0` for the default policy (default value if not supplied). Your default values are determined by your account manager on setup of the account.   `1` for an enforced policy. Transactions that are enforced will be checked for duplication within the duplication window.   `2` to bypass. Transactions that are bypassed will not be checked for duplication within the duplication window.   `3` to ignore. Transactions that are ignored will have the same affect as bypass.  (optional) 
            var matchAvsa = matchAvsa_example;  // string | A policy value which determines whether an AVS address policy is enforced, bypassed or ignored.  Values are  `0` for the default policy (default value if not supplied). Your default values are determined by your account manager on setup of the account.   `1` for an enforced policy. Transactions that are enforced will be rejected if the AVS address numeric value does not match.   `2` to bypass. Transactions that are bypassed will be allowed through even if the address did not match.   `3` to ignore. Transactions that are ignored will bypass the result and not send address numeric details for authorisation.  (optional) 
            var nameOnCard = nameOnCard_example;  // string | The card holder name as appears on the card such as MR N E BODY. Required for some acquirers.  (optional) 
            var nonce = nonce_example;  // string | A random value string which is provided to the API to perform a digest. The value will be used by its UTF-8 byte representation of any digest function.  (optional) 
            var redirectFailure = redirectFailure_example;  // string | The URL used to redirect back to your site when a transaction has been rejected or declined. Required if a url-encoded request.  (optional) 
            var redirectSuccess = redirectSuccess_example;  // string | The URL used to redirect back to your site when a transaction has been tokenised or authorised. Required if a url-encoded request.  (optional) 
            var shipTo = new ContactDetails(); // ContactDetails |  (optional) 
            var threedsecure = new ThreeDSecure(); // ThreeDSecure |  (optional) 
            var tokenise = true;  // bool? | Boolean flag which defines whether the response data is tokenised for further presentation at a later authorisation stage. A value of false will effectively turn off tokenisation and present the transaction immediately upstream to the acquirer.  (optional) 
            var transInfo = transInfo_example;  // string | Further information that can be added to the transaction will display in reporting. Can be used for flexible values such as operator id. (optional) 
            var transType = transType_example;  // string | The type of transaction being submitted. Normally this value is not required and your account manager may request that you set this field. (optional) 

            try
            {
                // Direct Post Request
                OneOfTokenisationResponseModelAuthResponse result = apiInstance.DirectPostRequest(amount, cardnumber, expmonth, expyear, identifier, avsPostcodePolicy, billTo, csc, cscPolicy, currency, duplicatePolicy, matchAvsa, nameOnCard, nonce, redirectFailure, redirectSuccess, shipTo, threedsecure, tokenise, transInfo, transType);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DirectPostAPIApi.DirectPostRequest: " + e.Message );
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
 **amount** | **int**| The amount to authorise in the lowest unit of currency with a variable length to a maximum of 12 digits.  No decimal points are to be included and no divisional characters such as 1,024.  The amount should be the total amount required for the transaction.  For example with GBP £1,021.95 the amount value is 102195.  | 
 **cardnumber** | **string**| The card number (PAN) with a variable length to a maximum of 21 digits in numerical form. Any non numeric characters will be stripped out of the card number, this includes whitespace or separators internal of the provided value.  The card number must be treated as sensitive data. We only provide an obfuscated value in logging and reporting.  The plaintext value is encrypted in our database using AES 256 GMC bit encryption for settlement or refund purposes.  When providing the card number to our gateway through the authorisation API you will be handling the card data on your application. This will require further PCI controls to be in place and this value must never be stored.  | 
 **expmonth** | **int**| The month of expiry of the card. The month value should be a numerical value between 1 and 12.  | 
 **expyear** | **int**| The year of expiry of the card.  | 
 **identifier** | **string**| The identifier of the transaction to process. The value should be a valid reference and may be used to perform  post processing actions and to aid in reconciliation of transactions.  The value should be a valid printable string with ASCII character ranges from 0x32 to 0x127.  The identifier is recommended to be distinct for each transaction such as a [random unique identifier](https://en.wikipedia.org/wiki/Universally_unique_identifier) this will aid in ensuring each transaction is identifiable.  When transactions are processed they are also checked for duplicate requests. Changing the identifier on a subsequent request will ensure that a transaction is considered as different.  | 
 **avsPostcodePolicy** | **string**| A policy value which determines whether an AVS postcode policy is enforced or bypassed.  Values are  &#x60;0&#x60; for the default policy (default value if not supplied). Your default values are determined by your account manager on setup of the account.   &#x60;1&#x60; for an enforced policy. Transactions that are enforced will be rejected if the AVS postcode numeric value does not match.   &#x60;2&#x60; to bypass. Transactions that are bypassed will be allowed through even if the postcode did not match.   &#x60;3&#x60; to ignore. Transactions that are ignored will bypass the result and not send postcode details for authorisation.  | [optional] 
 **billTo** | [**ContactDetails**](ContactDetails.md)|  | [optional] 
 **csc** | **string**| The Card Security Code (CSC) (also known as CV2/CVV2) is normally found on the back of the card (American Express has it on the front). The value helps to identify posession of the card as it is not available within the chip or magnetic swipe.  When forwarding the CSC, please ensure the value is a string as some values start with 0 and this will be stripped out by any integer parsing.  The CSC number aids fraud prevention in Mail Order and Internet payments.  Business rules are available on your account to identify whether to accept or decline transactions based on mismatched results of the CSC.  The Payment Card Industry (PCI) requires that at no stage of a transaction should the CSC be stored.  This applies to all entities handling card data.  It should also not be used in any hashing process.  CityPay do not store the value and have no method of retrieving the value once the transaction has been processed. For this reason, duplicate checking is unable to determine the CSC in its duplication check algorithm.  | [optional] 
 **cscPolicy** | **string**| A policy value which determines whether a CSC policy is enforced or bypassed.  Values are  &#x60;0&#x60; for the default policy (default value if not supplied). Your default values are determined by your account manager on setup of the account.   &#x60;1&#x60; for an enforced policy. Transactions that are enforced will be rejected if the CSC value does not match.   &#x60;2&#x60; to bypass. Transactions that are bypassed will be allowed through even if the CSC did not match.   &#x60;3&#x60; to ignore. Transactions that are ignored will bypass the result and not send the CSC details for authorisation.  | [optional] 
 **currency** | **string**| The processing currency for the transaction. Will default to the merchant account currency. | [optional] 
 **duplicatePolicy** | **string**| A policy value which determines whether a duplication policy is enforced or bypassed. A duplication check has a window of time set against your account within which it can action. If a previous transaction with matching values occurred within the window, any subsequent transaction will result in a T001 result.  Values are  &#x60;0&#x60; for the default policy (default value if not supplied). Your default values are determined by your account manager on setup of the account.   &#x60;1&#x60; for an enforced policy. Transactions that are enforced will be checked for duplication within the duplication window.   &#x60;2&#x60; to bypass. Transactions that are bypassed will not be checked for duplication within the duplication window.   &#x60;3&#x60; to ignore. Transactions that are ignored will have the same affect as bypass.  | [optional] 
 **matchAvsa** | **string**| A policy value which determines whether an AVS address policy is enforced, bypassed or ignored.  Values are  &#x60;0&#x60; for the default policy (default value if not supplied). Your default values are determined by your account manager on setup of the account.   &#x60;1&#x60; for an enforced policy. Transactions that are enforced will be rejected if the AVS address numeric value does not match.   &#x60;2&#x60; to bypass. Transactions that are bypassed will be allowed through even if the address did not match.   &#x60;3&#x60; to ignore. Transactions that are ignored will bypass the result and not send address numeric details for authorisation.  | [optional] 
 **nameOnCard** | **string**| The card holder name as appears on the card such as MR N E BODY. Required for some acquirers.  | [optional] 
 **nonce** | **string**| A random value string which is provided to the API to perform a digest. The value will be used by its UTF-8 byte representation of any digest function.  | [optional] 
 **redirectFailure** | **string**| The URL used to redirect back to your site when a transaction has been rejected or declined. Required if a url-encoded request.  | [optional] 
 **redirectSuccess** | **string**| The URL used to redirect back to your site when a transaction has been tokenised or authorised. Required if a url-encoded request.  | [optional] 
 **shipTo** | [**ContactDetails**](ContactDetails.md)|  | [optional] 
 **threedsecure** | [**ThreeDSecure**](ThreeDSecure.md)|  | [optional] 
 **tokenise** | **bool?**| Boolean flag which defines whether the response data is tokenised for further presentation at a later authorisation stage. A value of false will effectively turn off tokenisation and present the transaction immediately upstream to the acquirer.  | [optional] 
 **transInfo** | **string**| Further information that can be added to the transaction will display in reporting. Can be used for flexible values such as operator id. | [optional] 
 **transType** | **string**| The type of transaction being submitted. Normally this value is not required and your account manager may request that you set this field. | [optional] 

### Return type

[**OneOfTokenisationResponseModelAuthResponse**](OneOfTokenisationResponseModelAuthResponse.md)

### Authorization

[cp-api-key](../README.md#cp-api-key), [cp-domain-key](../README.md#cp-domain-key)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded, application/json, text/xml
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

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="tokenrequest"></a>
# **TokenRequest**
> AuthResponse TokenRequest (string nonce = null, string redirectFailure = null, string redirectSuccess = null, string token = null)

Direct Post Token Request

Perform a request for authorisation for a previously generated token. This flow will return an authorisation response stating that the transaction was approved or declined. 

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

            var apiInstance = new DirectPostAPIApi(config);
            var nonce = nonce_example;  // string | A random value string which is provided to the API to perform a digest. The value will be used by its UTF-8 byte representation of any digest function.  (optional) 
            var redirectFailure = redirectFailure_example;  // string | The URL used to redirect back to your site when a transaction has been rejected or declined. Required if a url-encoded request.  (optional) 
            var redirectSuccess = redirectSuccess_example;  // string | The URL used to redirect back to your site when a transaction has been authorised. Required if a url-encoded request.  (optional) 
            var token = token_example;  // string | The token required to process the transaction as presented by the direct post methodology.  (optional) 

            try
            {
                // Direct Post Token Request
                AuthResponse result = apiInstance.TokenRequest(nonce, redirectFailure, redirectSuccess, token);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DirectPostAPIApi.TokenRequest: " + e.Message );
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
 **nonce** | **string**| A random value string which is provided to the API to perform a digest. The value will be used by its UTF-8 byte representation of any digest function.  | [optional] 
 **redirectFailure** | **string**| The URL used to redirect back to your site when a transaction has been rejected or declined. Required if a url-encoded request.  | [optional] 
 **redirectSuccess** | **string**| The URL used to redirect back to your site when a transaction has been authorised. Required if a url-encoded request.  | [optional] 
 **token** | **string**| The token required to process the transaction as presented by the direct post methodology.  | [optional] 

### Return type

[**AuthResponse**](AuthResponse.md)

### Authorization

[cp-api-key](../README.md#cp-api-key), [cp-domain-key](../README.md#cp-domain-key)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded, application/json, text/xml
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

