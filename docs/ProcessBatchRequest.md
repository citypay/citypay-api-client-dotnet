# CityPayAPI.Model.ProcessBatchRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**BatchDate** | **DateTime** | The date and time that the file was created in ISO-8601 format. | 
**BatchId** | **List&lt;int&gt;** |  | 
**ClientAccountId** | **string** | The batch account id to process the batch for. Defaults to your client id if not provided. | [optional] 
**Transactions** | [**List&lt;BatchTransaction&gt;**](BatchTransaction.md) |  | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

