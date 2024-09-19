# CityPayAPI.Model.RemittanceData

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**DateCreated** | **DateTime** | Represents the date and time when the remittance was processed. This timestamp follows the ISO 8601 format for datetime representation. | [optional] 
**NetAmount** | **int** | Represents the net amount after accounting for refunds. This is calculated as SalesAmount - RefundAmount and expressed in the smallest currency unit. | [optional] 
**RefundAmount** | **int** | The total amount refunded to customers. | [optional] 
**RefundCount** | **int** | The total number of refund transactions processed. This figure helps in understanding the frequency of refunds relative to sales. | [optional] 
**SalesAmount** | **int** | The total monetary amount of sales transactions. | [optional] 
**SalesCount** | **int** | Indicates the total number of sales transactions that occurred. This count provides insight into the volume of sales. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

