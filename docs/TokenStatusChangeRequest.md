# CityPayAPI.Model.TokenStatusChangeRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**After** | **DateTime** | identifies the date and time to lookup changes after. | 
**MaxResults** | **int** | The maximum number of results that are returned per call. You can use nextToken to obtain further pages of results. The default is 50 and the maximum allowed page size is 100. A value of 0 uses the default. | [optional] 
**Merchantid** | **int** | the merchant id to review tokens for. | 
**NextToken** | **string** | If nextToken is returned, there are more results available. The value of nextToken is a unique pagination token for each page. Make the call again using the returned token to retrieve the next page. Keep all other arguments unchanged. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

