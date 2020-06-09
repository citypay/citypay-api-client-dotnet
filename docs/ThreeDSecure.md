# CityPayAPI.Model.ThreeDSecure
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AcceptHeaders** | **string** | The content of the HTTP accept header as sent to the merchant from the cardholder&#39;s user agent. This value will be validated by the ACS when the card holder authenticates themselves to verify that no intermediary is performing this action. Required for 3DSv1.  | [optional] 
**Downgrade1** | **bool** | Where a merchant is configured for 3DSv2, setting this option will attempt to downgrade the transaction to  3DSv1.  | [optional] 
**MerchantTermurl** | **string** | A controller URL for 3D-Secure processing that any response from an authentication request or challenge request should be sent to.  The controller should forward on the response from the URL back via this API for subsequent processing. Required if 3DSv1 or 3DSv2 is required.  | [optional] 
**TdsPolicy** | **string** | A policy value which determines whether ThreeDSecure is enforced or bypassed. Note that this will only work for e-commerce transactions and accounts that have 3DSecure enabled and fully registered with Visa, MasterCard or American Express. It is useful when transactions may be wanted to bypass processing rules.  Note that this may affect the liability shift of transactions and may occur a higher fee with the acquiring bank.  Values are  &#x60;0&#x60; for the default policy (default value if not supplied). Your default values are determined by your account manager on setup of the account.  &#x60;1&#x60; for an enforced policy. Transactions will be enabled for 3DS processing  &#x60;2&#x60; to bypass. Transactions that are bypassed will switch off 3DS processing.  | [optional] 
**UserAgent** | **string** | The content of the HTTP user-agent header as sent to the merchant from the cardholder&#39;s user agent. This value will be validated by the ACS when the card holder authenticates themselves to verify that no intermediary is performing this action. Required for 3DSv1.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

