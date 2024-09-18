# CityPayAPI.Model.MerchantBatchReportRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**DateFrom** | **DateOnly** | Start date (YYYY-MM-DD) for batch retrieval range, inclusive. Maximum value is 3 years ago. | [optional] 
**DateUntil** | **DateOnly** | End date (YYYY-MM-DD) for batch retrieval range, inclusive. | [optional] 
**MaxResults** | **int** | The maximum number of results to return in a single response. This value is used to limit the size of data returned by the API, enhancing performance and manageability. Values should be between 5 and 250. | [optional] 
**MerchantId** | **List&lt;int&gt;** |  | [optional] 
**NextToken** | **string** | A token that identifies the starting point of the page of results to be returned. An empty value indicates the start of the dataset. When supplied, it is validated and used to fetch the subsequent page of results. This token is typically obtained from the response of a previous pagination request. | [optional] 
**OrderBy** | **string** | Specifies the field by which results are ordered. Available fields are [merchant_id,batch_no,net_amount]. By default, fields are ordered by OrderByExpression(merchant_id,ASC),OrderByExpression(batch_no,ASC). To order in descending order, prefix with &#39;-&#39; or suffix with &#39; DESC&#39;. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

