# CityPayAPI.Model.PaylinkAttachmentRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Data** | **string** | base64 encoding of the file if less than 32kb in size. | [optional] 
**Filename** | **string** | The name of the attachment normally taken from the filename. You should not include the filename path as appropriate. | 
**MimeType** | **string** | The mime type of the attachment as defined in [RFC 9110](https://www.rfc-editor.org/rfc/rfc9110.html). Currently only &#x60;application/pdf&#x60; is supported. | 
**Name** | **string** | A name for the file to identify it to the card holder when it is displayed in the payment form. For example Invoice, Statement. | [optional] 
**Retention** | **int** | The retention period in days of the attachment. Defaults to 180 days. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

