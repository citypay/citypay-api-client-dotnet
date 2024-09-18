# CityPayAPI.Model.RemittedClientData

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Batches** | [**List&lt;MerchantBatchResponse&gt;**](MerchantBatchResponse.md) |  | 
**Clientid** | **string** | The client id that the remittance data is for. | [optional] 
**Date** | **DateOnly** | The date of the remittance. | [optional] 
**DateCreated** | **DateTime** | The date time that the remittance was created. | [optional] 
**NetAmount** | **int** | Represents the net amount after accounting for refunds. This is calculated as SalesAmount - RefundAmount and expressed in the smallest currency unit. | [optional] 
**ProcessedAmount** | **int** | The total monetary amount processed consisting of sale and refund transactions. | [optional] 
**ProcessedCount** | **int** | Indicates the total number of sales and refund transactions that occurred. This count provides insight into the volume of processing. | [optional] 
**RefundAmount** | **int** | The total amount refunded to customers. | [optional] 
**RefundCount** | **int** | The total number of refund transactions processed. This figure helps in understanding the frequency of refunds relative to sales. | [optional] 
**Remittances** | [**List&lt;RemittanceData&gt;**](RemittanceData.md) |  | 
**SalesAmount** | **int** | The total monetary amount of sales transactions. | [optional] 
**SalesCount** | **int** | Indicates the total number of sales transactions that occurred. This count provides insight into the volume of sales. | [optional] 
**SettlementImplementation** | **string** | The name of the implementation. | [optional] 
**Uuid** | **Guid** | The uuid of the settlement file processed on. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

