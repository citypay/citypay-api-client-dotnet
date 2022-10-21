# CityPayAPI.Model.PaylinkTokenRequestModel

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Accountno** | **string** | Specifies an alpha-numeric account number that the Paylink service uses when creating a Cardholder Account. The value should be no longer than 20 characters in length. | [optional] 
**Amount** | **int** | Specifies the intended value of the transaction in the lowest denomination with no spacing characters or decimal point. This is the net total to be processed. An example of £74.95 would be presented as 7495. | 
**Cardholder** | [**PaylinkCardHolder**](PaylinkCardHolder.md) |  | [optional] 
**Cart** | [**PaylinkCart**](PaylinkCart.md) |  | [optional] 
**ClientVersion** | **string** | The clientVersion field is used to specify the version of your application that has invoked the Paylink payment process. This feature is typically used for tracing issues relating to application deployments, or any Paylink integration module or plugin. | [optional] 
**Config** | [**PaylinkConfig**](PaylinkConfig.md) |  | [optional] 
**Email** | **string** | The email field is used for the Merchant to be notified on completion of the transaction . The value may be supplied to override the default stored value. Emails sent to this address by the Paylink service should not be forwarded on to the cardholder as it may contain certain information that is used by the Paylink service to validate and authenticate Paylink Token Requests: for example, the Merchant ID and the licence key.  | [optional] 
**Identifier** | **string** | Identifies a particular transaction linked to a Merchant account. It enables accurate duplicate checking within a pre-configured time period, as well as transaction reporting and tracing. The identifier should be unique to prevent payment card processing attempts from being rejected due to duplication.  | 
**Merchantid** | **int** | The merchant id you wish to process this transaction with. | 
**SubscriptionId** | **string** | an id associated with a subscription to link the token request against. | [optional] 
**TxType** | **string** | A value to override the transaction type if requested by your account manager. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

