# CityPayAPI.Model.CardHolderAccount
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AccountId** | **string** | The account id of the card holder account which uniquely identifies the account.  | 
**CacId** | **string** | The card holder control id which identifies the scheme that the account belongs to, ordinarily this is the same as your client id. | [optional] 
**Cards** | [**List&lt;Card&gt;**](Card.md) |  | [optional] 
**Contact** | [**ContactDetails**](ContactDetails.md) |  | 
**DateCreated** | **DateTime** | The date and time the account was created. | [optional] 
**TransStatus** | **string** | Defines the status of the account for processing valid values are   - ACTIVE for active accounts that are able to process  - DISABLED for accounts that are currently disabled for processing.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

