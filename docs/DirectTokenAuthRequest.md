# CityPayAPI.Model.DirectTokenAuthRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Nonce** | **string** | A random value string which is provided to the API to perform a digest. The value will be used by its UTF-8 byte representation of any digest function.  | [optional] 
**RedirectFailure** | **string** | The URL used to redirect back to your site when a transaction has been rejected or declined. Required if a url-encoded request.  | [optional] 
**RedirectSuccess** | **string** | The URL used to redirect back to your site when a transaction has been authorised. Required if a url-encoded request.  | [optional] 
**Token** | **string** | The token required to process the transaction as presented by the direct post methodology.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

