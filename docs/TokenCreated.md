# CityPayAPI.Model.TokenCreated

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Attachments** | [**AttachmentResult**](AttachmentResult.md) |  | [optional] 
**Bps** | **string** | true if BPS has been enabled on this token. | [optional] 
**DateCreated** | **DateTime** | Date and time the token was generated. | [optional] 
**Errors** | [**List&lt;ErrorCode&gt;**](ErrorCode.md) |  | [optional] 
**Id** | **string** | A unique id of the request. | 
**Identifier** | **string** | The identifier as presented in the TokenRequest. | [optional] 
**Mode** | **string** | Determines whether the token is &#x60;live&#x60; or &#x60;test&#x60;. | [optional] 
**Qrcode** | **string** | A URL of a qrcode which can be used to refer to the token URL. | [optional] 
**Result** | **int** | The result field contains the result for the Paylink Token Request. 0 - indicates that an error was encountered while creating the token. 1 - which indicates that a Token was successfully created. | 
**ServerVersion** | **string** | the version of the server performing the call. | [optional] 
**Source** | **string** | The incoming IP address of the call. | [optional] 
**Token** | **string** | A token generated for the request used to refer to the transaction in consequential calls. | 
**Url** | **string** | The Paylink token URL used to checkout by the card holder. | [optional] 
**Usc** | **string** | A UrlShortCode (USC) used for short links. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

