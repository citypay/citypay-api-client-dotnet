# CityPay API Client for DotNet


This CityPay API is a HTTP RESTful payment API used for direct server to server transactional processing. It
provides a number of payment mechanisms including: Internet, MOTO, Continuous Authority transaction processing,
3-D Secure decision handling using RFA Secure, Authorisation, Refunding, Pre-Authorisation, Cancellation/Voids and
Completion processing. The API is also capable of tokinsed payments using Card Holder Accounts.

## Compliance and Security
<aside class=\"notice\">
  Before we begin a reminder that your application will need to adhere to PCI-DSS standards to operate safely
  and to meet requirements set out by Visa and MasterCard and the PCI Security Standards Council including:
</aside>

* Data must be collected using TLS version 1.2 using [strong cryptography](#enabled-tls-ciphers). We will not accept calls to our API at
  lower grade encryption levels. We regularly scan our TLS endpoints for vulnerabilities and perform TLS assessments
  as part of our compliance program.
* The application must not store sensitive card holder data (CHD) such as the card security code (CSC) or
  primary access number (PAN)
* The application must not display the full card number on receipts, it is recommended to mask the PAN
  and show the last 4 digits. The API will return this for you for ease of receipt creation
* If you are developing a website, you will be required to perform regular scans on the network where you host the
  application to meet your compliance obligations
* You will be required to be PCI Compliant and the application must adhere to the security standard. Further information
  is available from [https://www.pcisecuritystandards.org/](https://www.pcisecuritystandards.org/)
* The API verifies that the request is for a valid account and originates from a trusted source using the remote IP
  address. Our application firewalls analyse data that may be an attempt to break a large number of security common
  security vulnerabilities.


This C# SDK is automatically generated by the [OpenAPI Generator](https://openapi-generator.tech) project:

- API version: 6.0.12
- SDK version: 1.0.5
- Build package: org.openapitools.codegen.languages.CSharpNetCoreClientCodegen
    For more information, please visit [https://citypay.com/customer-centre/technical-support.html](https://citypay.com/customer-centre/technical-support.html)

<a name="frameworks-supported"></a>
## Frameworks supported
- .NET Core >= 2.1 
- Mono/Xamarin >=vNext

<a name="dependencies"></a>
## Dependencies

- [RestSharp](https://www.nuget.org/packages/RestSharp) - 106.10.1 or later
- [Json.NET](https://www.nuget.org/packages/Newtonsoft.Json/) - 12.0.1 or later
- [JsonSubTypes](https://www.nuget.org/packages/JsonSubTypes/) - 1.5.2 or later
- [System.ComponentModel.Annotations](https://www.nuget.org/packages/System.ComponentModel.Annotations) - 4.5.0 or later

The DLLs included in the package may not be the latest version. We recommend using [NuGet](https://docs.nuget.org/consume/installing-nuget) to obtain the latest version of the packages:
```
Install-Package RestSharp
Install-Package Newtonsoft.Json
Install-Package JsonSubTypes
Install-Package System.ComponentModel.Annotations
```

NOTE: RestSharp versions greater than 105.1.0 have a bug which causes file uploads to fail. See [RestSharp#742](https://github.com/restsharp/RestSharp/issues/742)

<a name="installation"></a>
## Installation
Generate the DLL using your preferred tool (e.g. `dotnet build`)

Then include the DLL (under the `bin` folder) in the C# project, and use the namespaces:
```csharp
using CityPayAPI.Api;
using CityPayAPI.Client;
using CityPayAPI.Model;
```
<a name="getting-started"></a>
## Getting Started

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using CityPayAPI.Api;
using CityPayAPI.Client;
using CityPayAPI.Model;

namespace Example
{
    public class Example
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
            catch (ApiException e)
            {
                Debug.Print("Exception when calling CardHolderAccountApi.AccountCardDeleteRequest: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }

        }
    }
}
```

<a name="documentation-for-api-endpoints"></a>
## Documentation for API Endpoints

All URIs are relative to *https://api.citypay.com/v6*

Class | Method | HTTP request | Description
------------ | ------------- | ------------- | -------------
*CardHolderAccountApi* | [**AccountCardDeleteRequest**](docs/CardHolderAccountApi.md#accountcarddeleterequest) | **DELETE** /account/{accountid}/card/{cardId} | Card Deletion
*CardHolderAccountApi* | [**AccountCardRegisterRequest**](docs/CardHolderAccountApi.md#accountcardregisterrequest) | **POST** /account/{accountid}/register | Card Registration
*CardHolderAccountApi* | [**AccountCardStatusRequest**](docs/CardHolderAccountApi.md#accountcardstatusrequest) | **POST** /account/{accountid}/card/{cardId}/status | Card Status
*CardHolderAccountApi* | [**AccountChangeContactRequest**](docs/CardHolderAccountApi.md#accountchangecontactrequest) | **POST** /account/{accountid}/contact | Contact Details Update
*CardHolderAccountApi* | [**AccountCreate**](docs/CardHolderAccountApi.md#accountcreate) | **POST** /account/create | Account Create
*CardHolderAccountApi* | [**AccountDeleteRequest**](docs/CardHolderAccountApi.md#accountdeleterequest) | **DELETE** /account/{accountid} | Account Deletion
*CardHolderAccountApi* | [**AccountExistsRequest**](docs/CardHolderAccountApi.md#accountexistsrequest) | **GET** /account-exists/{accountid} | Account Exists
*CardHolderAccountApi* | [**AccountRetrieveRequest**](docs/CardHolderAccountApi.md#accountretrieverequest) | **GET** /account/{accountid} | Account Retrieval
*CardHolderAccountApi* | [**AccountStatusRequest**](docs/CardHolderAccountApi.md#accountstatusrequest) | **POST** /account/{accountid}/status | Account Status
*CardHolderAccountApi* | [**ChargeRequest**](docs/CardHolderAccountApi.md#chargerequest) | **POST** /charge | Charge
*OperationalApi* | [**ListMerchantsRequest**](docs/OperationalApi.md#listmerchantsrequest) | **GET** /merchants/{clientid} | List Merchants Request
*OperationalApi* | [**PingRequest**](docs/OperationalApi.md#pingrequest) | **POST** /ping | Ping Request
*PaymentProcessingApi* | [**AuthorisationRequest**](docs/PaymentProcessingApi.md#authorisationrequest) | **POST** /authorise | Authorisation
*PaymentProcessingApi* | [**CResRequest**](docs/PaymentProcessingApi.md#cresrequest) | **POST** /cres | CRes
*PaymentProcessingApi* | [**CaptureRequest**](docs/PaymentProcessingApi.md#capturerequest) | **POST** /capture | Capture
*PaymentProcessingApi* | [**PaResRequest**](docs/PaymentProcessingApi.md#paresrequest) | **POST** /pares | PaRes
*PaymentProcessingApi* | [**RefundRequest**](docs/PaymentProcessingApi.md#refundrequest) | **POST** /refund | Refund
*PaymentProcessingApi* | [**RetrievalRequest**](docs/PaymentProcessingApi.md#retrievalrequest) | **POST** /retrieve | Retrieval
*PaymentProcessingApi* | [**VoidRequest**](docs/PaymentProcessingApi.md#voidrequest) | **POST** /void | Void


<a name="documentation-for-models"></a>
## Documentation for Models

 - [Model.AccountCreate](docs/AccountCreate.md)
 - [Model.AccountStatus](docs/AccountStatus.md)
 - [Model.Acknowledgement](docs/Acknowledgement.md)
 - [Model.AirlineAdvice](docs/AirlineAdvice.md)
 - [Model.AirlineSegment](docs/AirlineSegment.md)
 - [Model.AuthReference](docs/AuthReference.md)
 - [Model.AuthReferences](docs/AuthReferences.md)
 - [Model.AuthRequest](docs/AuthRequest.md)
 - [Model.AuthResponse](docs/AuthResponse.md)
 - [Model.AuthenRequired](docs/AuthenRequired.md)
 - [Model.CResAuthRequest](docs/CResAuthRequest.md)
 - [Model.CaptureRequest](docs/CaptureRequest.md)
 - [Model.Card](docs/Card.md)
 - [Model.CardHolderAccount](docs/CardHolderAccount.md)
 - [Model.CardStatus](docs/CardStatus.md)
 - [Model.ChargeRequest](docs/ChargeRequest.md)
 - [Model.ContactDetails](docs/ContactDetails.md)
 - [Model.Decision](docs/Decision.md)
 - [Model.Error](docs/Error.md)
 - [Model.Exists](docs/Exists.md)
 - [Model.ExternalMPI](docs/ExternalMPI.md)
 - [Model.ListMerchantsResponse](docs/ListMerchantsResponse.md)
 - [Model.MCC6012](docs/MCC6012.md)
 - [Model.Merchant](docs/Merchant.md)
 - [Model.PaResAuthRequest](docs/PaResAuthRequest.md)
 - [Model.Ping](docs/Ping.md)
 - [Model.RefundRequest](docs/RefundRequest.md)
 - [Model.RegisterCard](docs/RegisterCard.md)
 - [Model.RequestChallenged](docs/RequestChallenged.md)
 - [Model.RetrieveRequest](docs/RetrieveRequest.md)
 - [Model.ThreeDSecure](docs/ThreeDSecure.md)
 - [Model.VoidRequest](docs/VoidRequest.md)


<a name="documentation-for-authorization"></a>
## Documentation for Authorization

<a name="cp-api-key"></a>
### cp-api-key

- **Type**: API key
- **API key parameter name**: cp-api-key
- **Location**: HTTP header

