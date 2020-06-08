# CityPayAPI.Model.AuthReference
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Amount** | **int** | The amount of the transaction in decimal currency format. | [optional] 
**AmountValue** | **string** | The amount of the transaction in integer/request format. | [optional] 
**Atrn** | **string** | A reference number provided by the acquiring services. | [optional] 
**Authcode** | **string** | The authorisation code of the transaction returned by the acquirer or card issuer. | [optional] 
**Batchno** | **string** | A batch number which the transaction has been end of day batched towards. | [optional] 
**Currency** | **string** | The currency of the transaction in ISO 4217 code format. | [optional] 
**Datetime** | **DateTime** | The date and time of the transaction. | [optional] 
**Identifier** | **string** | The identifier of the transaction used to process the transaction. | [optional] 
**Maskedpan** | **string** | A masking of the card number which was used to process the tranasction. | [optional] 
**Merchantid** | **int** | The merchant id of the transaction result. | [optional] 
**Result** | **string** | The result of the transaction. | [optional] 
**TransStatus** | **string** | The current status of the transaction through it&#39;s lifecycle. | [optional] 
**TransType** | **string** | The type of transaction that was processed. | [optional] 
**Transno** | **int** | The transaction number of the transaction. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

