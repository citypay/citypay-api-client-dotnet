# CityPayAPI.Model.Card
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**BinCommercial** | **bool** | Defines whether the card is a commercial card. | [optional] 
**BinCorporate** | **bool** | Defines whether the card is a corporate business card. | [optional] 
**BinCountryIssued** | **string** | The determined country where the card was issued. | [optional] 
**BinCredit** | **bool** | Defines whether the card is a credit card. | [optional] 
**BinCurrency** | **string** | The default currency determined for the card. | [optional] 
**BinDebit** | **bool** | Defines whether the card is a debit card. | [optional] 
**BinDescription** | **string** | A description of the bin on the card to identify what type of product the card is. | [optional] 
**BinEu** | **bool** | Defines whether the card is regulated within the EU. | [optional] 
**CardId** | **string** | The id of the card that is returned. Should be used for referencing the card when perform any changes. | [optional] 
**CardStatus** | **string** | The status of the card such, valid values are  - ACTIVE the card is active for processing  - INACTIVE the card is not active for processing  - EXPIRED for cards that have passed their expiry date.  | [optional] 
**Default** | **bool** | Determines if the card is the default card for the account and should be regarded as the first option to be used for processing. | [optional] 
**Expmonth** | **int** | The expiry month of the card. | [optional] 
**Expyear** | **int** | The expiry year of the card. | [optional] 
**Label** | **string** | A label which identifies this card. | [optional] 
**Label2** | **string** | A label which also provides the expiry date of the card. | [optional] 
**Last4digits** | **string** | The last 4 digits of the card to aid in identification. | [optional] 
**Scheme** | **string** | The scheme that issued the card. | [optional] 
**Token** | **string** | A token that can be used to process against the card. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

