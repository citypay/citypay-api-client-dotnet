# CityPayAPI.Model.VoidRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Identifier** | **string** | The identifier of the transaction to void. If an empty value is supplied then a &#x60;trans_no&#x60; value must be supplied. | [optional] 
**Merchantid** | **int** | Identifies the merchant account to perform the void for. | 
**Transno** | **int** | The transaction number of the transaction to look up and void. If an empty value is supplied then an identifier value must be supplied. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

