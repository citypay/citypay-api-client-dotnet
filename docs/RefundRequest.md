# CityPayAPI.Model.RefundRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Amount** | **int** | The amount to refund in the lowest unit of currency with a variable length to a maximum of 12 digits.  The amount should be the total amount required to refund for the transaction up to the original processed amount.  No decimal points are to be included and no divisional characters such as 1,024.  For example with GBP £1,021.95 the amount value is 102195.  | 
**Identifier** | **string** | The identifier of the refund to process. The value should be a valid reference and may be used to perform  post processing actions and to aid in reconciliation of transactions.  The value should be a valid printable string with ASCII character ranges from 0x32 to 0x127.  The identifier is recommended to be distinct for each transaction such as a [random unique identifier](https://en.wikipedia.org/wiki/Universally_unique_identifier) this will aid in ensuring each transaction is identifiable.  When transactions are processed they are also checked for duplicate requests. Changing the identifier on a subsequent request will ensure that a transaction is considered as different.  | 
**Merchantid** | **int** | Identifies the merchant account to perform the refund for. | 
**RefundRef** | **int** | A reference to the original transaction number that is wanting to be refunded. The original  transaction must be on the same merchant id, previously authorised.  | 
**TransInfo** | **string** | Further information that can be added to the transaction will display in reporting. Can be used for flexible values such as operator id. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

