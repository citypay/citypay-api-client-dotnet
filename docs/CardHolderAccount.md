# CityPayAPI.Model.CardHolderAccount
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AccountId** | **string** | The account id of the card holder account provided by the merchant which uniquely identifies the account.  | 
**Cards** | [**List&lt;Card&gt;**](Card.md) |  | [optional] 
**Contact** | [**ContactDetails**](ContactDetails.md) |  | 
**DateCreated** | **DateTime** | The date and time the account was created. | [optional] 
**DefaultCardId** | **string** | The id of the default card. | [optional] 
**DefaultCardIndex** | **string** | The index in the array of the default card. | [optional] 
**Status** | **string** | Defines the status of the account for processing valid values are   - ACTIVE for active accounts that are able to process  - DISABLED for accounts that are currently disabled for processing.  | [optional] 
**UniqueId** | **string** | A unique id of the card holder account which uniquely identifies the stored account. This value is not searchable. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

