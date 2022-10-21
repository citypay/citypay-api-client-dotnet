# CityPayAPI.Model.PaylinkBillPaymentTokenRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Attachments** | [**List&lt;PaylinkAttachmentRequest&gt;**](PaylinkAttachmentRequest.md) |  | [optional] 
**Descriptor** | **string** | A descriptor for the bill payment used to describe what the payment request is for for instance \&quot;Invoice\&quot;.  The descriptor can be used as descriptive text on emails or the payment page. For instance an invoice may have a button saying \&quot;View Invoice\&quot; or an email may say \&quot;to pay your Invoice online\&quot;.  | [optional] 
**Due** | **DateTime** | A date that the invoice is due. This can be displayed on the payment page. | [optional] 
**EmailNotificationPath** | [**PaylinkEmailNotificationPath**](PaylinkEmailNotificationPath.md) |  | [optional] 
**Request** | [**PaylinkTokenRequestModel**](PaylinkTokenRequestModel.md) |  | 
**SmsNotificationPath** | [**PaylinkSMSNotificationPath**](PaylinkSMSNotificationPath.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

