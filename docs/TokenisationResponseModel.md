# CityPayAPI.Model.TokenisationResponseModel

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AuthenResult** | **string** | The result of any authentication using 3d_secure authorisation against ecommerce transactions. Values are:  &lt;table&gt; &lt;tr&gt; &lt;th&gt;Value&lt;/th&gt; &lt;th&gt;Description&lt;/th&gt; &lt;/tr&gt; &lt;tr&gt; &lt;td&gt;Y&lt;/td&gt; &lt;td&gt;Authentication Successful. The Cardholder&#39;s password was successfully validated.&lt;/td&gt; &lt;/tr&gt; &lt;tr&gt; &lt;td&gt;N&lt;/td&gt; &lt;td&gt;Authentication Failed. Customer failed or cancelled authentication, transaction denied.&lt;/td&gt; &lt;/tr&gt; &lt;tr&gt; &lt;td&gt;A&lt;/td&gt; &lt;td&gt;Attempts Processing Performed Authentication could not be completed but a proof of authentication attempt (CAVV) was generated.&lt;/td&gt; &lt;/tr&gt; &lt;tr&gt; &lt;td&gt;U&lt;/td&gt; &lt;td&gt;Authentication Could Not Be Performed Authentication could not be completed, due to technical or other problem.&lt;/td&gt; &lt;/tr&gt; &lt;/table&gt;  | [optional] 
**BinCommercial** | **bool** | Determines whether the bin range was found to be a commercial or business card. | [optional] 
**BinDebit** | **bool** | Determines whether the bin range was found to be a debit card. If false the card was considered as a credit card. | [optional] 
**BinDescription** | **string** | A description of the bin range found for the card. | [optional] 
**Eci** | **string** | An Electronic Commerce Indicator (ECI) used to identify the result of authentication using 3DSecure.  | [optional] 
**Identifier** | **string** | The identifier provided within the request. | [optional] 
**Maskedpan** | **string** | A masked value of the card number used for processing displaying limited values that can be used on a receipt.  | [optional] 
**Scheme** | **string** | The name of the card scheme of the transaction that processed the transaction such as Visa or MasterCard.  | [optional] 
**SigId** | **string** | A Base58 encoded SHA-256 digest generated from the token value Base58 decoded and appended with the nonce value UTF-8 decoded. | [optional] 
**Token** | **string** | The token used for presentment to authorisation later in the processing flow. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

