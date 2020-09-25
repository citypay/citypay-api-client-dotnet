# CityPayAPI.Api.CardHolderAccountApi

All URIs are relative to *https://api.citypay.com/v6*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AccountCardDeleteRequest**](CardHolderAccountApi.md#accountcarddeleterequest) | **DELETE** /account/{accountid}/card/{cardId} | Card Deletion
[**AccountCardRegisterRequest**](CardHolderAccountApi.md#accountcardregisterrequest) | **POST** /account/{accountid}/register | Card Registration
[**AccountCardStatusRequest**](CardHolderAccountApi.md#accountcardstatusrequest) | **POST** /account/{accountid}/card/{cardId}/status | Card Status
[**AccountChangeContactRequest**](CardHolderAccountApi.md#accountchangecontactrequest) | **POST** /account/{accountid}/contact | Contact Details Update
[**AccountCreate**](CardHolderAccountApi.md#accountcreate) | **POST** /account/create | Account Create
[**AccountDeleteRequest**](CardHolderAccountApi.md#accountdeleterequest) | **DELETE** /account/{accountid} | Account Deletion
[**AccountRetrieveRequest**](CardHolderAccountApi.md#accountretrieverequest) | **GET** /account/{accountid} | Account Retrieval
[**AccountStatusRequest**](CardHolderAccountApi.md#accountstatusrequest) | **POST** /account/{accountid}/status | Account Status
[**ChargeRequest**](CardHolderAccountApi.md#chargerequest) | **POST** /charge | Charge


<a name="accountcarddeleterequest"></a>
# **AccountCardDeleteRequest**
> Acknowledgement AccountCardDeleteRequest (string accountid, string cardId)

Card Deletion

Deletes a card from the account. The card will be marked for deletion before a subsequent purge will clear the card permanently. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using CityPayAPI.Api;
using CityPayAPI.Client;
using CityPayAPI.Model;

namespace Example
{
    public class AccountCardDeleteRequestExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.citypay.com/v6";
            // Create a temporal ApiKey using your client id and licence key
            config.AddApiKey("cp-api-key", new ApiKey("CLIENT_ID", "LICENCE_KEY").GenerateKey();

            var apiInstance = new CardHolderAccountApi(config);
            var accountid = accountid_example;  // string | The account id that refers to the customer's account no. This value will have been provided when setting up the card holder account.
            var cardId = cardId_example;  // string | The id of the card that is presented by a call to retrieve a card holder account.

            try
            {
                // Card Deletion
                Acknowledgement result = apiInstance.AccountCardDeleteRequest(accountid, cardId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CardHolderAccountApi.AccountCardDeleteRequest: " + e.Message );
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
 **accountid** | **string**| The account id that refers to the customer&#39;s account no. This value will have been provided when setting up the card holder account. | 
 **cardId** | **string**| The id of the card that is presented by a call to retrieve a card holder account. | 

### Return type

[**Acknowledgement**](Acknowledgement.md)

### Authorization

[cp-api-key](../README.md#cp-api-key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/xml

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **403** | Forbidden. The api key was provided and understood but is either incorrect or does not have permission to access the account provided on the request. |  -  |
| **401** | Unauthorized. No api key has been provided and is required for this operation. |  -  |
| **422** | Unprocessable Entity. Should a failure occur that prevents processing of the API call. |  -  |
| **400** | Bad Request. Should the incoming data not be validly determined. |  -  |
| **200** | Acknowledges the card has been requested for deletion. A response code of &#x60;001&#x60; is returned if the account is available for deletion or an error code is returned. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="accountcardregisterrequest"></a>
# **AccountCardRegisterRequest**
> CardHolderAccount AccountCardRegisterRequest (string accountid, RegisterCard registerCard)

Card Registration

Allows for a card to be registered for the account. The card will be added for future  processing and will be available as a tokenised value for future processing.  The card will be validated for  0. Being a valid card number (luhn check) 0. Having a valid expiry date 0. Being a valid bin value. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using CityPayAPI.Api;
using CityPayAPI.Client;
using CityPayAPI.Model;

namespace Example
{
    public class AccountCardRegisterRequestExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.citypay.com/v6";
            // Create a temporal ApiKey using your client id and licence key
            config.AddApiKey("cp-api-key", new ApiKey("CLIENT_ID", "LICENCE_KEY").GenerateKey();

            var apiInstance = new CardHolderAccountApi(config);
            var accountid = accountid_example;  // string | The account id that refers to the customer's account no. This value will have been provided when setting up the card holder account.
            var registerCard = new RegisterCard(); // RegisterCard | 

            try
            {
                // Card Registration
                CardHolderAccount result = apiInstance.AccountCardRegisterRequest(accountid, registerCard);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CardHolderAccountApi.AccountCardRegisterRequest: " + e.Message );
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
 **accountid** | **string**| The account id that refers to the customer&#39;s account no. This value will have been provided when setting up the card holder account. | 
 **registerCard** | [**RegisterCard**](RegisterCard.md)|  | 

### Return type

[**CardHolderAccount**](CardHolderAccount.md)

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
| **200** | A successfully registered card provides a reload of the account including the new card. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="accountcardstatusrequest"></a>
# **AccountCardStatusRequest**
> Acknowledgement AccountCardStatusRequest (string accountid, string cardId, CardStatus cardStatus)

Card Status

Updates the status of a card for processing. The following values are available  | Status | Description |  |- -- -- -- -|- -- -- -- -- -- --| | Active | The card is active for processing and can be used for charging against with a valid token | | Inactive | The card is inactive for processing and cannot be used for processing, it will require reactivation before being used to charge | | Expired | The card has expired either due to the expiry date no longer being valid or due to a replacement card being issued | 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using CityPayAPI.Api;
using CityPayAPI.Client;
using CityPayAPI.Model;

namespace Example
{
    public class AccountCardStatusRequestExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.citypay.com/v6";
            // Create a temporal ApiKey using your client id and licence key
            config.AddApiKey("cp-api-key", new ApiKey("CLIENT_ID", "LICENCE_KEY").GenerateKey();

            var apiInstance = new CardHolderAccountApi(config);
            var accountid = accountid_example;  // string | The account id that refers to the customer's account no. This value will have been provided when setting up the card holder account.
            var cardId = cardId_example;  // string | The id of the card that is presented by a call to retrieve a card holder account.
            var cardStatus = new CardStatus(); // CardStatus | 

            try
            {
                // Card Status
                Acknowledgement result = apiInstance.AccountCardStatusRequest(accountid, cardId, cardStatus);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CardHolderAccountApi.AccountCardStatusRequest: " + e.Message );
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
 **accountid** | **string**| The account id that refers to the customer&#39;s account no. This value will have been provided when setting up the card holder account. | 
 **cardId** | **string**| The id of the card that is presented by a call to retrieve a card holder account. | 
 **cardStatus** | [**CardStatus**](CardStatus.md)|  | 

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
| **200** | Acknowledges the card status has changed, returning a response code of &#x60;001&#x60; for a valid change or &#x60;000&#x60; for a non valid change.  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="accountchangecontactrequest"></a>
# **AccountChangeContactRequest**
> CardHolderAccount AccountChangeContactRequest (string accountid, ContactDetails contactDetails)

Contact Details Update

Allows for the ability to change the contact details for an account.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using CityPayAPI.Api;
using CityPayAPI.Client;
using CityPayAPI.Model;

namespace Example
{
    public class AccountChangeContactRequestExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.citypay.com/v6";
            // Create a temporal ApiKey using your client id and licence key
            config.AddApiKey("cp-api-key", new ApiKey("CLIENT_ID", "LICENCE_KEY").GenerateKey();

            var apiInstance = new CardHolderAccountApi(config);
            var accountid = accountid_example;  // string | The account id that refers to the customer's account no. This value will have been provided when setting up the card holder account.
            var contactDetails = new ContactDetails(); // ContactDetails | 

            try
            {
                // Contact Details Update
                CardHolderAccount result = apiInstance.AccountChangeContactRequest(accountid, contactDetails);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CardHolderAccountApi.AccountChangeContactRequest: " + e.Message );
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
 **accountid** | **string**| The account id that refers to the customer&#39;s account no. This value will have been provided when setting up the card holder account. | 
 **contactDetails** | [**ContactDetails**](ContactDetails.md)|  | 

### Return type

[**CardHolderAccount**](CardHolderAccount.md)

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
| **200** | A revised account with the new details set. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="accountcreate"></a>
# **AccountCreate**
> CardHolderAccount AccountCreate (AccountCreate accountCreate)

Account Create

Creates a new card holder account and initialises the account ready for adding cards.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using CityPayAPI.Api;
using CityPayAPI.Client;
using CityPayAPI.Model;

namespace Example
{
    public class AccountCreateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.citypay.com/v6";
            // Create a temporal ApiKey using your client id and licence key
            config.AddApiKey("cp-api-key", new ApiKey("CLIENT_ID", "LICENCE_KEY").GenerateKey();

            var apiInstance = new CardHolderAccountApi(config);
            var accountCreate = new AccountCreate(); // AccountCreate | 

            try
            {
                // Account Create
                CardHolderAccount result = apiInstance.AccountCreate(accountCreate);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CardHolderAccountApi.AccountCreate: " + e.Message );
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
 **accountCreate** | [**AccountCreate**](AccountCreate.md)|  | 

### Return type

[**CardHolderAccount**](CardHolderAccount.md)

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
| **200** | Provides an initialised account. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="accountdeleterequest"></a>
# **AccountDeleteRequest**
> Acknowledgement AccountDeleteRequest (string accountid)

Account Deletion

Allows for the deletion of an account. The account will marked for deletion and subsequent purging. No further transactions will be alowed to be processed or actioned against this account. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using CityPayAPI.Api;
using CityPayAPI.Client;
using CityPayAPI.Model;

namespace Example
{
    public class AccountDeleteRequestExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.citypay.com/v6";
            // Create a temporal ApiKey using your client id and licence key
            config.AddApiKey("cp-api-key", new ApiKey("CLIENT_ID", "LICENCE_KEY").GenerateKey();

            var apiInstance = new CardHolderAccountApi(config);
            var accountid = accountid_example;  // string | The account id that refers to the customer's account no. This value will have been provided when setting up the card holder account.

            try
            {
                // Account Deletion
                Acknowledgement result = apiInstance.AccountDeleteRequest(accountid);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CardHolderAccountApi.AccountDeleteRequest: " + e.Message );
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
 **accountid** | **string**| The account id that refers to the customer&#39;s account no. This value will have been provided when setting up the card holder account. | 

### Return type

[**Acknowledgement**](Acknowledgement.md)

### Authorization

[cp-api-key](../README.md#cp-api-key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/xml

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **403** | Forbidden. The api key was provided and understood but is either incorrect or does not have permission to access the account provided on the request. |  -  |
| **401** | Unauthorized. No api key has been provided and is required for this operation. |  -  |
| **422** | Unprocessable Entity. Should a failure occur that prevents processing of the API call. |  -  |
| **400** | Bad Request. Should the incoming data not be validly determined. |  -  |
| **200** | An acknowledgment that the card holder account has been marked for deletion. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="accountretrieverequest"></a>
# **AccountRetrieveRequest**
> CardHolderAccount AccountRetrieveRequest (string accountid)

Account Retrieval

Allows for the retrieval of a card holder account for the given `id`. Should duplicate accounts exist for the same `id`, the first account created with that `id` will be returned.  The account can be used for tokenisation processing by listing all cards assigned to the account. The returned cards will include all `active`, `inactive` and `expired` cards. This can be used to  enable a card holder to view their wallet and make constructive choices on which card to use. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using CityPayAPI.Api;
using CityPayAPI.Client;
using CityPayAPI.Model;

namespace Example
{
    public class AccountRetrieveRequestExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.citypay.com/v6";
            // Create a temporal ApiKey using your client id and licence key
            config.AddApiKey("cp-api-key", new ApiKey("CLIENT_ID", "LICENCE_KEY").GenerateKey();

            var apiInstance = new CardHolderAccountApi(config);
            var accountid = accountid_example;  // string | The account id that refers to the customer's account no. This value will have been provided when setting up the card holder account.

            try
            {
                // Account Retrieval
                CardHolderAccount result = apiInstance.AccountRetrieveRequest(accountid);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CardHolderAccountApi.AccountRetrieveRequest: " + e.Message );
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
 **accountid** | **string**| The account id that refers to the customer&#39;s account no. This value will have been provided when setting up the card holder account. | 

### Return type

[**CardHolderAccount**](CardHolderAccount.md)

### Authorization

[cp-api-key](../README.md#cp-api-key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/xml

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **403** | Forbidden. The api key was provided and understood but is either incorrect or does not have permission to access the account provided on the request. |  -  |
| **401** | Unauthorized. No api key has been provided and is required for this operation. |  -  |
| **422** | Unprocessable Entity. Should a failure occur that prevents processing of the API call. |  -  |
| **400** | Bad Request. Should the incoming data not be validly determined. |  -  |
| **200** | A card holder account that matches the account id provided in the request. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="accountstatusrequest"></a>
# **AccountStatusRequest**
> Acknowledgement AccountStatusRequest (string accountid, AccountStatus accountStatus)

Account Status

Updates the status of an account. An account can have the following statuses applied  | Status | Description | |- -- -- -- -|- -- -- -- -- -- --| | Active | The account is active for processing | | Disabled | The account has been disabled and cannot be used for processing. The account will require reactivation to continue procesing | 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using CityPayAPI.Api;
using CityPayAPI.Client;
using CityPayAPI.Model;

namespace Example
{
    public class AccountStatusRequestExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.citypay.com/v6";
            // Create a temporal ApiKey using your client id and licence key
            config.AddApiKey("cp-api-key", new ApiKey("CLIENT_ID", "LICENCE_KEY").GenerateKey();

            var apiInstance = new CardHolderAccountApi(config);
            var accountid = accountid_example;  // string | The account id that refers to the customer's account no. This value will have been provided when setting up the card holder account.
            var accountStatus = new AccountStatus(); // AccountStatus | 

            try
            {
                // Account Status
                Acknowledgement result = apiInstance.AccountStatusRequest(accountid, accountStatus);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CardHolderAccountApi.AccountStatusRequest: " + e.Message );
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
 **accountid** | **string**| The account id that refers to the customer&#39;s account no. This value will have been provided when setting up the card holder account. | 
 **accountStatus** | [**AccountStatus**](AccountStatus.md)|  | 

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
| **200** | An acknowledgment that the card holder account status has been updated. A response code of &#x60;001&#x60; is returned if the request was accepted or no change required. A response code of &#x60;000&#x60; is returned if the request contains invalid data.  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="chargerequest"></a>
# **ChargeRequest**
> Decision ChargeRequest (ChargeRequest chargeRequest)

Charge

A charge process obtains an authorisation using a tokenised value which represents a stored card  on a card holder account.  A card must previously be registered by calling `/account-register-card` with the card details  or retrieved using `/account-retrieve`  Tokens are generated whenever a previously registered list of cards are retrieved. Each token has, by design a  relatively short time to live of 30 minutes. This is both to safe guard the merchant and card holder from  replay attacks. Tokens are also restricted to your account, preventing malicious actors from stealing details for use elsewhere.    If a token is reused after it has expired it will be rejected and a new token will be required.   Tokenisation can be used for   - repeat authorisations on a previously stored card - easy authorisations just requiring CSC values to be entered - can be used for credential on file style payments - can require full 3-D Secure authentication to retain the liability shift - wallet style usage. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using CityPayAPI.Api;
using CityPayAPI.Client;
using CityPayAPI.Model;

namespace Example
{
    public class ChargeRequestExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.citypay.com/v6";
            // Create a temporal ApiKey using your client id and licence key
            config.AddApiKey("cp-api-key", new ApiKey("CLIENT_ID", "LICENCE_KEY").GenerateKey();

            var apiInstance = new CardHolderAccountApi(config);
            var chargeRequest = new ChargeRequest(); // ChargeRequest | 

            try
            {
                // Charge
                Decision result = apiInstance.ChargeRequest(chargeRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CardHolderAccountApi.ChargeRequest: " + e.Message );
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
 **chargeRequest** | [**ChargeRequest**](ChargeRequest.md)|  | 

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
| **200** | A decision met by the result of the charge. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

