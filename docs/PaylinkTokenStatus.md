# CityPayAPI.Model.PaylinkTokenStatus

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AmountPaid** | **int** | the amount that has been paid against the session. | [optional] 
**AuthCode** | **string** | an authorisation code if the transaction was processed and isPaid is true. | [optional] 
**Card** | **string** | a description of the card that was used for payment if paid. | [optional] 
**Created** | **DateTime** | the date and time that the session was created. | [optional] 
**Datetime** | **DateTime** | the date and time of the current status. | [optional] 
**Identifier** | **string** | the merchant identifier, to help identifying the token. | [optional] 
**IsAttachment** | **bool** | true if an attachment exists. | [optional] 
**IsCancelled** | **bool** | true if the session was cancelled either by the user or by a system request. | [optional] 
**IsClosed** | **bool** | true if the token has been closed. | [optional] 
**IsCustomerReceiptEmailSent** | **bool** | true if a customer receipt has been sent. | [optional] 
**IsEmailSent** | **bool** | true if an email was sent. | [optional] 
**IsExpired** | **bool** | true if the session has expired. | [optional] 
**IsFormViewed** | **bool** | true if the form was ever displayed to the addressee. | [optional] 
**IsMerchantNotificationEmailSent** | **bool** | true if a merchant notification receipt was sent. | [optional] 
**IsOpenForPayment** | **bool** | true if the session is still open for payment or false if it has been closed. | [optional] 
**IsPaid** | **bool** | whether the session has been paid and therefore can be considered as complete. | [optional] 
**IsPaymentAttempted** | **bool** | true if payment has been attempted. | [optional] 
**IsPostbackOk** | **bool** | true if a post back was executed successfully. | [optional] 
**IsRequestChallenged** | **bool** | true if the request has been challenged using 3-D Secure. | [optional] 
**IsSmsSent** | **bool** | true if an SMS was sent. | [optional] 
**IsValidated** | **bool** | whether the token generation was successfully validated. | [optional] 
**LastEventDateTime** | **DateTime** | the date and time that the session last had an event actioned against it. | [optional] 
**LastPaymentResult** | **string** | the result of the last payment if one exists. | [optional] 
**Mid** | **string** | identifies the merchant account. | [optional] 
**PaymentAttemptsCount** | **int** | the number of attempts made to pay. | [optional] 
**StateHistory** | [**List&lt;PaylinkStateEvent&gt;**](PaylinkStateEvent.md) |  | [optional] 
**Token** | **string** | the token value which uniquely identifies the session. | [optional] 
**TransNo** | **int** | a transaction number if the transacstion was processed and isPaid is true. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

