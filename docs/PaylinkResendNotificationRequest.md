# CityPayAPI.Model.PaylinkResendNotificationRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Email** | **bool** | Resends the bill payment email provided on the Paylink create token notification path. Emails can be sent up to 5 times per token. | [optional] 
**Sms** | **bool** | Resends the bill payment SMS provided on the Paylink create token notification path. An SMS cannot be resent if it was previously sent less than 1 minute ago. There is a limit of 3 retries per token.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

