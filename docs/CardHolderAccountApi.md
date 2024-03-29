# CityPayAPI.Api.CardHolderAccountApi

All URIs are relative to *https://api.citypay.com*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**AccountCardDeleteRequest**](CardHolderAccountApi.md#accountcarddeleterequest) | **DELETE** /v6/account/{accountid}/card/{cardId} | Card Deletion |
| [**AccountCardRegisterRequest**](CardHolderAccountApi.md#accountcardregisterrequest) | **POST** /v6/account/{accountid}/register | Card Registration |
| [**AccountCardStatusRequest**](CardHolderAccountApi.md#accountcardstatusrequest) | **POST** /v6/account/{accountid}/card/{cardId}/status | Card Status |
| [**AccountChangeContactRequest**](CardHolderAccountApi.md#accountchangecontactrequest) | **POST** /v6/account/{accountid}/contact | Contact Details Update |
| [**AccountCreate**](CardHolderAccountApi.md#accountcreate) | **POST** /v6/account/create | Account Create |
| [**AccountDeleteRequest**](CardHolderAccountApi.md#accountdeleterequest) | **DELETE** /v6/account/{accountid} | Account Deletion |
| [**AccountExistsRequest**](CardHolderAccountApi.md#accountexistsrequest) | **GET** /v6/account-exists/{accountid} | Account Exists |
| [**AccountRetrieveRequest**](CardHolderAccountApi.md#accountretrieverequest) | **GET** /v6/account/{accountid} | Account Retrieval |
| [**AccountStatusRequest**](CardHolderAccountApi.md#accountstatusrequest) | **POST** /v6/account/{accountid}/status | Account Status |
| [**ChargeRequest**](CardHolderAccountApi.md#chargerequest) | **POST** /v6/charge | Charge |

<a id="accountcarddeleterequest"></a>
# **AccountCardDeleteRequest**
> Acknowledgement AccountCardDeleteRequest (string accountid, string cardId)

Card Deletion

Deletes a card from the account. The card will be marked for deletion before a subsequent
purge will clear the card permanently.


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
            config.BasePath = "https://api.citypay.com";
            // Create a temporal ApiKey using your client id and licence key
            config.AddApiKey("cp-api-key", new ApiKey("CLIENT_ID", "LICENCE_KEY").GenerateKey());

            var apiInstance = new CardHolderAccountApi(config);
            var accountid = "accountid_example";  // string | The account id that refers to the customer's account no. This value will have been provided when setting up the card holder account.
            var cardId = "cardId_example";  // string | The id of the card that is presented by a call to retrieve a card holder account.

            try
            {
                // Card Deletion
                Acknowledgement result = apiInstance.AccountCardDeleteRequest(accountid, cardId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CardHolderAccountApi.AccountCardDeleteRequest: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AccountCardDeleteRequestWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Card Deletion
    ApiResponse<Acknowledgement> response = apiInstance.AccountCardDeleteRequestWithHttpInfo(accountid, cardId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CardHolderAccountApi.AccountCardDeleteRequestWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **accountid** | **string** | The account id that refers to the customer&#39;s account no. This value will have been provided when setting up the card holder account. |  |
| **cardId** | **string** | The id of the card that is presented by a call to retrieve a card holder account. |  |

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
| **200** | Acknowledges the card has been requested for deletion. A response code of &#x60;001&#x60; is returned if the account is available for deletion otherwise an error code is returned. |  -  |
| **400** | Bad Request. Should the incoming data not be validly determined. |  -  |
| **401** | Unauthorized. No api key has been provided and is required for this operation. |  -  |
| **403** | Forbidden. The api key was provided and understood but is either incorrect or does not have permission to access the account provided on the request. |  -  |
| **422** | Unprocessable Entity. Should a failure occur that prevents processing of the API call. |  -  |
| **500** | Server Error. The server was unable to complete the request. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="accountcardregisterrequest"></a>
# **AccountCardRegisterRequest**
> CardHolderAccount AccountCardRegisterRequest (string accountid, RegisterCard registerCard)

Card Registration

Allows for a card to be registered for the account. The card will be added for future 
processing and will be available as a tokenised value for future processing.

The card will be validated for

0. Being a valid card number (luhn check)
0. Having a valid expiry date
0. Being a valid bin value.


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
            config.BasePath = "https://api.citypay.com";
            // Create a temporal ApiKey using your client id and licence key
            config.AddApiKey("cp-api-key", new ApiKey("CLIENT_ID", "LICENCE_KEY").GenerateKey());

            var apiInstance = new CardHolderAccountApi(config);
            var accountid = "accountid_example";  // string | The account id that refers to the customer's account no. This value will have been provided when setting up the card holder account.
            var registerCard = new RegisterCard(); // RegisterCard | 

            try
            {
                // Card Registration
                CardHolderAccount result = apiInstance.AccountCardRegisterRequest(accountid, registerCard);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CardHolderAccountApi.AccountCardRegisterRequest: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AccountCardRegisterRequestWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Card Registration
    ApiResponse<CardHolderAccount> response = apiInstance.AccountCardRegisterRequestWithHttpInfo(accountid, registerCard);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CardHolderAccountApi.AccountCardRegisterRequestWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **accountid** | **string** | The account id that refers to the customer&#39;s account no. This value will have been provided when setting up the card holder account. |  |
| **registerCard** | [**RegisterCard**](RegisterCard.md) |  |  |

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
| **200** | A successfully registered card provides a reload of the account including the new card. |  -  |
| **400** | Bad Request. Should the incoming data not be validly determined. |  -  |
| **401** | Unauthorized. No api key has been provided and is required for this operation. |  -  |
| **403** | Forbidden. The api key was provided and understood but is either incorrect or does not have permission to access the account provided on the request. |  -  |
| **422** | Unprocessable Entity. Should a failure occur that prevents processing of the API call. |  -  |
| **500** | Server Error. The server was unable to complete the request. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="accountcardstatusrequest"></a>
# **AccountCardStatusRequest**
> Acknowledgement AccountCardStatusRequest (string accountid, string cardId, CardStatus cardStatus)

Card Status

Updates the status of a card for processing. The following values are available

| Status | Description | 
|--------|-------------|
| Active | The card is active for processing and can be used for charging against with a valid token |
| Inactive | The card is inactive for processing and cannot be used for processing, it will require reactivation before being used to charge |
| Expired | The card has expired either due to the expiry date no longer being valid or due to a replacement card being issued |


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
            config.BasePath = "https://api.citypay.com";
            // Create a temporal ApiKey using your client id and licence key
            config.AddApiKey("cp-api-key", new ApiKey("CLIENT_ID", "LICENCE_KEY").GenerateKey());

            var apiInstance = new CardHolderAccountApi(config);
            var accountid = "accountid_example";  // string | The account id that refers to the customer's account no. This value will have been provided when setting up the card holder account.
            var cardId = "cardId_example";  // string | The id of the card that is presented by a call to retrieve a card holder account.
            var cardStatus = new CardStatus(); // CardStatus | 

            try
            {
                // Card Status
                Acknowledgement result = apiInstance.AccountCardStatusRequest(accountid, cardId, cardStatus);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CardHolderAccountApi.AccountCardStatusRequest: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AccountCardStatusRequestWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Card Status
    ApiResponse<Acknowledgement> response = apiInstance.AccountCardStatusRequestWithHttpInfo(accountid, cardId, cardStatus);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CardHolderAccountApi.AccountCardStatusRequestWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **accountid** | **string** | The account id that refers to the customer&#39;s account no. This value will have been provided when setting up the card holder account. |  |
| **cardId** | **string** | The id of the card that is presented by a call to retrieve a card holder account. |  |
| **cardStatus** | [**CardStatus**](CardStatus.md) |  |  |

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
| **200** | Acknowledges the card status has changed, returning a response code of &#x60;001&#x60; for a valid change or &#x60;000&#x60; for a non valid change. |  -  |
| **400** | Bad Request. Should the incoming data not be validly determined. |  -  |
| **401** | Unauthorized. No api key has been provided and is required for this operation. |  -  |
| **403** | Forbidden. The api key was provided and understood but is either incorrect or does not have permission to access the account provided on the request. |  -  |
| **422** | Unprocessable Entity. Should a failure occur that prevents processing of the API call. |  -  |
| **500** | Server Error. The server was unable to complete the request. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="accountchangecontactrequest"></a>
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
            config.BasePath = "https://api.citypay.com";
            // Create a temporal ApiKey using your client id and licence key
            config.AddApiKey("cp-api-key", new ApiKey("CLIENT_ID", "LICENCE_KEY").GenerateKey());

            var apiInstance = new CardHolderAccountApi(config);
            var accountid = "accountid_example";  // string | The account id that refers to the customer's account no. This value will have been provided when setting up the card holder account.
            var contactDetails = new ContactDetails(); // ContactDetails | 

            try
            {
                // Contact Details Update
                CardHolderAccount result = apiInstance.AccountChangeContactRequest(accountid, contactDetails);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CardHolderAccountApi.AccountChangeContactRequest: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AccountChangeContactRequestWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Contact Details Update
    ApiResponse<CardHolderAccount> response = apiInstance.AccountChangeContactRequestWithHttpInfo(accountid, contactDetails);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CardHolderAccountApi.AccountChangeContactRequestWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **accountid** | **string** | The account id that refers to the customer&#39;s account no. This value will have been provided when setting up the card holder account. |  |
| **contactDetails** | [**ContactDetails**](ContactDetails.md) |  |  |

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
| **200** | A revised account with the new details set. |  -  |
| **400** | Bad Request. Should the incoming data not be validly determined. |  -  |
| **401** | Unauthorized. No api key has been provided and is required for this operation. |  -  |
| **403** | Forbidden. The api key was provided and understood but is either incorrect or does not have permission to access the account provided on the request. |  -  |
| **422** | Unprocessable Entity. Should a failure occur that prevents processing of the API call. |  -  |
| **500** | Server Error. The server was unable to complete the request. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="accountcreate"></a>
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
            config.BasePath = "https://api.citypay.com";
            // Create a temporal ApiKey using your client id and licence key
            config.AddApiKey("cp-api-key", new ApiKey("CLIENT_ID", "LICENCE_KEY").GenerateKey());

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
                Debug.Print("Exception when calling CardHolderAccountApi.AccountCreate: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AccountCreateWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Account Create
    ApiResponse<CardHolderAccount> response = apiInstance.AccountCreateWithHttpInfo(accountCreate);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CardHolderAccountApi.AccountCreateWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **accountCreate** | [**AccountCreate**](AccountCreate.md) |  |  |

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
| **200** | Provides an initialised account. |  -  |
| **400** | Bad Request. Should the incoming data not be validly determined. |  -  |
| **401** | Unauthorized. No api key has been provided and is required for this operation. |  -  |
| **403** | Forbidden. The api key was provided and understood but is either incorrect or does not have permission to access the account provided on the request. |  -  |
| **422** | Unprocessable Entity. Should a failure occur that prevents processing of the API call. |  -  |
| **500** | Server Error. The server was unable to complete the request. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="accountdeleterequest"></a>
# **AccountDeleteRequest**
> Acknowledgement AccountDeleteRequest (string accountid)

Account Deletion

Allows for the deletion of an account. The account will marked for deletion and subsequent purging. No further
transactions will be alowed to be processed or actioned against this account.


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
            config.BasePath = "https://api.citypay.com";
            // Create a temporal ApiKey using your client id and licence key
            config.AddApiKey("cp-api-key", new ApiKey("CLIENT_ID", "LICENCE_KEY").GenerateKey());

            var apiInstance = new CardHolderAccountApi(config);
            var accountid = "accountid_example";  // string | The account id that refers to the customer's account no. This value will have been provided when setting up the card holder account.

            try
            {
                // Account Deletion
                Acknowledgement result = apiInstance.AccountDeleteRequest(accountid);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CardHolderAccountApi.AccountDeleteRequest: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AccountDeleteRequestWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Account Deletion
    ApiResponse<Acknowledgement> response = apiInstance.AccountDeleteRequestWithHttpInfo(accountid);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CardHolderAccountApi.AccountDeleteRequestWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **accountid** | **string** | The account id that refers to the customer&#39;s account no. This value will have been provided when setting up the card holder account. |  |

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
| **200** | An acknowledgment code of &#x60;001&#x60; that the card holder account has been marked for deletion. |  -  |
| **400** | Bad Request. Should the incoming data not be validly determined. |  -  |
| **401** | Unauthorized. No api key has been provided and is required for this operation. |  -  |
| **403** | Forbidden. The api key was provided and understood but is either incorrect or does not have permission to access the account provided on the request. |  -  |
| **422** | Unprocessable Entity. Should a failure occur that prevents processing of the API call. |  -  |
| **500** | Server Error. The server was unable to complete the request. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="accountexistsrequest"></a>
# **AccountExistsRequest**
> Exists AccountExistsRequest (string accountid)

Account Exists

Checks that an account exists and is active by providing the account id as a url parameter.


### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using CityPayAPI.Api;
using CityPayAPI.Client;
using CityPayAPI.Model;

namespace Example
{
    public class AccountExistsRequestExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.citypay.com";
            // Create a temporal ApiKey using your client id and licence key
            config.AddApiKey("cp-api-key", new ApiKey("CLIENT_ID", "LICENCE_KEY").GenerateKey());

            var apiInstance = new CardHolderAccountApi(config);
            var accountid = "accountid_example";  // string | The account id that refers to the customer's account no. This value will have been provided when setting up the card holder account.

            try
            {
                // Account Exists
                Exists result = apiInstance.AccountExistsRequest(accountid);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CardHolderAccountApi.AccountExistsRequest: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AccountExistsRequestWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Account Exists
    ApiResponse<Exists> response = apiInstance.AccountExistsRequestWithHttpInfo(accountid);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CardHolderAccountApi.AccountExistsRequestWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **accountid** | **string** | The account id that refers to the customer&#39;s account no. This value will have been provided when setting up the card holder account. |  |

### Return type

[**Exists**](Exists.md)

### Authorization

[cp-api-key](../README.md#cp-api-key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/xml


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | A response model determining whether the account exists, if exists is true, a last modified date of the account is also provided. |  -  |
| **400** | Bad Request. Should the incoming data not be validly determined. |  -  |
| **401** | Unauthorized. No api key has been provided and is required for this operation. |  -  |
| **403** | Forbidden. The api key was provided and understood but is either incorrect or does not have permission to access the account provided on the request. |  -  |
| **422** | Unprocessable Entity. Should a failure occur that prevents processing of the API call. |  -  |
| **500** | Server Error. The server was unable to complete the request. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="accountretrieverequest"></a>
# **AccountRetrieveRequest**
> CardHolderAccount AccountRetrieveRequest (string accountid)

Account Retrieval

Allows for the retrieval of a card holder account for the given `id`. Should duplicate accounts exist
for the same `id`, the first account created with that `id` will be returned.

The account can be used for tokenisation processing by listing all cards assigned to the account.
The returned cards will include all `active`, `inactive` and `expired` cards. This can be used to 
enable a card holder to view their wallet and make constructive choices on which card to use.


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
            config.BasePath = "https://api.citypay.com";
            // Create a temporal ApiKey using your client id and licence key
            config.AddApiKey("cp-api-key", new ApiKey("CLIENT_ID", "LICENCE_KEY").GenerateKey());

            var apiInstance = new CardHolderAccountApi(config);
            var accountid = "accountid_example";  // string | The account id that refers to the customer's account no. This value will have been provided when setting up the card holder account.

            try
            {
                // Account Retrieval
                CardHolderAccount result = apiInstance.AccountRetrieveRequest(accountid);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CardHolderAccountApi.AccountRetrieveRequest: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AccountRetrieveRequestWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Account Retrieval
    ApiResponse<CardHolderAccount> response = apiInstance.AccountRetrieveRequestWithHttpInfo(accountid);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CardHolderAccountApi.AccountRetrieveRequestWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **accountid** | **string** | The account id that refers to the customer&#39;s account no. This value will have been provided when setting up the card holder account. |  |

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
| **200** | A card holder account that matches the account id provided in the request. |  -  |
| **400** | Bad Request. Should the incoming data not be validly determined. |  -  |
| **401** | Unauthorized. No api key has been provided and is required for this operation. |  -  |
| **403** | Forbidden. The api key was provided and understood but is either incorrect or does not have permission to access the account provided on the request. |  -  |
| **422** | Unprocessable Entity. Should a failure occur that prevents processing of the API call. |  -  |
| **500** | Server Error. The server was unable to complete the request. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="accountstatusrequest"></a>
# **AccountStatusRequest**
> Acknowledgement AccountStatusRequest (string accountid, AccountStatus accountStatus)

Account Status

Updates the status of an account. An account can have the following statuses applied

| Status | Description |
|--------|-------------|
| Active | The account is active for processing |
| Disabled | The account has been disabled and cannot be used for processing. The account will require reactivation to continue procesing |


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
            config.BasePath = "https://api.citypay.com";
            // Create a temporal ApiKey using your client id and licence key
            config.AddApiKey("cp-api-key", new ApiKey("CLIENT_ID", "LICENCE_KEY").GenerateKey());

            var apiInstance = new CardHolderAccountApi(config);
            var accountid = "accountid_example";  // string | The account id that refers to the customer's account no. This value will have been provided when setting up the card holder account.
            var accountStatus = new AccountStatus(); // AccountStatus | 

            try
            {
                // Account Status
                Acknowledgement result = apiInstance.AccountStatusRequest(accountid, accountStatus);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CardHolderAccountApi.AccountStatusRequest: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AccountStatusRequestWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Account Status
    ApiResponse<Acknowledgement> response = apiInstance.AccountStatusRequestWithHttpInfo(accountid, accountStatus);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CardHolderAccountApi.AccountStatusRequestWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **accountid** | **string** | The account id that refers to the customer&#39;s account no. This value will have been provided when setting up the card holder account. |  |
| **accountStatus** | [**AccountStatus**](AccountStatus.md) |  |  |

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
| **200** | An acknowledgment that the card holder account status has been updated.&lt;/br&gt;&lt;/br&gt;A response code of &#x60;001&#x60; is returned if the request was accepted or no change required.&lt;/br&gt;&lt;/br&gt;A response code of &#x60;000&#x60; is returned if the request contains invalid data. |  -  |
| **400** | Bad Request. Should the incoming data not be validly determined. |  -  |
| **401** | Unauthorized. No api key has been provided and is required for this operation. |  -  |
| **403** | Forbidden. The api key was provided and understood but is either incorrect or does not have permission to access the account provided on the request. |  -  |
| **422** | Unprocessable Entity. Should a failure occur that prevents processing of the API call. |  -  |
| **500** | Server Error. The server was unable to complete the request. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="chargerequest"></a>
# **ChargeRequest**
> Decision ChargeRequest (ChargeRequest chargeRequest)

Charge

A charge process obtains an authorisation using a tokenised value which represents a stored card 
on a card holder account. 
A card must previously be registered by calling `/account-register-card` with the card details 
or retrieved using `/account-retrieve`

Tokens are generated whenever a previously registered list of cards are retrieved. Each token has, by design a 
relatively short time to live of 30 minutes. This is both to safe guard the merchant and card holder from 
replay attacks. Tokens are also restricted to your account, preventing malicious actors from stealing details
for use elsewhere.  

If a token is reused after it has expired it will be rejected and a new token will be required.
 
Tokenisation can be used for
 
- repeat authorisations on a previously stored card
- easy authorisations just requiring CSC values to be entered
- can be used for credential on file style payments
- can require full 3-D Secure authentication to retain the liability shift
- wallet style usage
 

_Should an account be used with 3DSv2, the card holder name should also be stored alongside the card as this is a
required field with both Visa and MasterCard for risk analysis._.


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
            config.BasePath = "https://api.citypay.com";
            // Create a temporal ApiKey using your client id and licence key
            config.AddApiKey("cp-api-key", new ApiKey("CLIENT_ID", "LICENCE_KEY").GenerateKey());

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
                Debug.Print("Exception when calling CardHolderAccountApi.ChargeRequest: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ChargeRequestWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Charge
    ApiResponse<Decision> response = apiInstance.ChargeRequestWithHttpInfo(chargeRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CardHolderAccountApi.ChargeRequestWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **chargeRequest** | [**ChargeRequest**](ChargeRequest.md) |  |  |

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
| **200** | A decision met by the result of the charge. |  -  |
| **400** | Bad Request. Should the incoming data not be validly determined. |  -  |
| **401** | Unauthorized. No api key has been provided and is required for this operation. |  -  |
| **403** | Forbidden. The api key was provided and understood but is either incorrect or does not have permission to access the account provided on the request. |  -  |
| **422** | Unprocessable Entity. Should a failure occur that prevents processing of the API call. |  -  |
| **500** | Server Error. The server was unable to complete the request. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

