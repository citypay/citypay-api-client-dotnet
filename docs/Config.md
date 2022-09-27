# CityPayAPI.Model.Config

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AcsMode** | **string** | Specifies the approach to be adopted by the Paylink form when displaying a 3-D Secure challenge window. The values may be  iframe: shows the 3-D Secure ACS in an iframe dialog, neatly embedding it in Paylink. This provides a more seamless flow for the cardholder who is able to validate and authenticate their card using a dialog provided by their card issuer.  inline: an inline mode transfers the full browser window to the authentication server, allowing the payment cardholder to see their payment card issuer&#39;s URL and the certificate status in the browser. If you request an iframe mode and the browser width is deemed as being small (&lt; 768px) then an inline mode will be enforced. This is to ensure that mobile users have an improved user experience.  | [optional] 
**CustomParams** | **string** | Defines custom parameters to add to the request. | [optional] 
**Descriptor** | **string** | Directly specify the merchant descriptor used for the transaction to be displayed on the payment page. | [optional] 
**ExpireIn** | **string** | Specifies a period of time in seconds after which the token cannot be used. A value of 0 defines that the token will never expire. The API will convert an expiry time based on a string value. For instance:   s - Time in seconds, for example 90s.   m - Time in minutes, for example 20m.   h - Time in hours, for example 4h.   w - Time in weeks, for example 4w.   M - Time in months, for example 6M.   y - Time in years, for example 1y.   Defaults to 30 minutes.  | [optional] 
**FieldGuard** | [**FieldGuardModel**](FieldGuardModel.md) |  | [optional] 
**LockParams** | **string** | string[] Optional May be used to lock fields which are displayed in the form. For example, if the cardholder.address.postcode field were to be specified this would will prevent the customer amending the postal code for the cardholder postcode field. | [optional] 
**MerchLogo** | **string** | A URL of a logo to include in the form. The URL should be delivered using HTTPS. | [optional] 
**MerchTerms** | **string** | A URL of the merchant terms and conditions for payment. If a value is supplied, a checkbox will be required to be completed to confirm that the cardholder agrees to these conditions before payment. A modal dialogue is displayed with the content of the conditions displayed. | [optional] 
**Options** | **List&lt;String&gt;** |  | [optional] 
**PartPayments** | [**FieldGuardModel**](FieldGuardModel.md) |  | [optional] 
**Postback** | **string** | Specifies a URL to use for a call back when the payment is completed. see Postback Handling }. | [optional] 
**PostbackPassword** | **string** | A password to be added to the postback for HTTP Basic Authentication. | [optional] 
**PostbackPolicy** | **string** | The policy setting for the postback see Postback Handling. | [optional] 
**PostbackUsername** | **string** | A username to be added to the postback for HTTP Basic Authentication. | [optional] 
**RedirectDelay** | **int** | A value which can delay the redirection in seconds. A value of 0 will redirect immediately. | [optional] 
**RedirectFailure** | **string** | A URL which the browser is redirected to on non-completion of a transaction. | [optional] 
**RedirectSuccess** | **string** | A URL which the browser is redirected to on authorisation of a transaction. | [optional] 
**Renderer** | **string** | The Paylink renderer engine to use. | [optional] 
**ReturnParams** | **string** | If a value of true is specified, any redirection will include the transaction result in parameters. It is recommended to use the postback integration rather than redirection parameters. | [optional] 
**Ui** | [**UI**](UI.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

