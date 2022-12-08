# CityPayAPI.Model.PaylinkBillPaymentTokenRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Addressee** | **string** | Who the bill payment request intended for. This should be a readable name such as a person or company. | [optional] 
**Attachments** | [**List&lt;PaylinkAttachmentRequest&gt;**](PaylinkAttachmentRequest.md) |  | [optional] 
**Descriptor** | **string** | A descriptor for the bill payment used to describe what the payment request is for for instance \&quot;Invoice\&quot;.  The descriptor can be used as descriptive text on emails or the payment page. For instance an invoice may have a button saying \&quot;View Invoice\&quot; or an email may say \&quot;to pay your Invoice online\&quot;.  | [optional] 
**Due** | **DateTime** | A date that the invoice is due. This can be displayed on the payment page. | [optional] 
**EmailNotificationPath** | [**PaylinkEmailNotificationPath**](PaylinkEmailNotificationPath.md) |  | [optional] 
**Memo** | **string** | A memo that can be added to the payment page and email to provide to the customer. | [optional] 
**Request** | [**PaylinkTokenRequestModel**](PaylinkTokenRequestModel.md) |  | 
**SmsNotificationPath** | [**PaylinkSMSNotificationPath**](PaylinkSMSNotificationPath.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

