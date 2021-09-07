# CityPayAPI.Model.RequestChallenged

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AcsUrl** | **string** | The url of the Access Control Server (ACS) to forward the user to.  | [optional] 
**Creq** | **string** | The challenge request data which is encoded for usage by the ACS. | [optional] 
**Merchantid** | **int** | The merchant id that processed this transaction. | [optional] 
**ThreedserverTransId** | **string** | The 3DSv2 trans id reference for the challenge process. May be used to create the ThreeDSSessionData value to send to the ACS. | [optional] 
**Transno** | **int** | The transaction number for the challenge, ordered incrementally from 1 for every merchant_id.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

