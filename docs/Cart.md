# CityPayAPI.Model.Cart

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Contents** | **string** | Any cart items to list against the cart. | [optional] 
**Coupon** | **string** | A coupon redeemed with the transaction. | [optional] 
**Mode** | [**ModelInt**](ModelInt.md) | The mode field specifies the behaviour or functionality of the cart.  Valid values are:   0 - No cart - No cart is shown  1 - Read-only - The cart is shown with a breakdown of the item details provided by objects in the contents array.  2 - Selection cart - The cart is shown as a drop-down box of available cart items that the customer can a single item select from.  3 - Dynamic cart - a text box is rendered to enable the operator to input an amount.  4 - Multi cart - The cart is displayed with items rendered with selectable quantities.  | [optional] 
**ProductDescription** | **string** | Specifies a description about the product or service that is the subject of the transaction. It will be rendered in the header of the page with no labels. | [optional] 
**ProductInformation** | **string** | Specifies information about the product or service that is the subject of the transaction. It will be rendered in the header of the page. | [optional] 
**Shipping** | [**ModelInt**](ModelInt.md) | The shipping amount of the transaction in the lowest denomination of currency. | [optional] 
**Tax** | [**ModelInt**](ModelInt.md) | The tax amount of the transaction in the lowest denomination of currency. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

