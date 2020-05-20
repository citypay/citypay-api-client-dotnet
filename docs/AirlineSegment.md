# CityPayAPI.Model.AirlineSegment
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ArrivalLocationCode** | **string** | A standard airline routing code (airport code or location identifier) applicable to the arrival portion of this segment.  | 
**CarrierCode** | **string** | This field contains the two character airline designator code (air carrier code or airline code) that corresponds to the airline carrier applicable for up to four flight segments of this trip itinerary.  | 
**ClassServiceCode** | **string** | This field contains a code that corresponds to the fare class (A, B, C, D, Premium, Discounted, etc.) within the overall class of service (e.g., First Class, Business, Economy) applicable to this travel segment, as specified in the IATA Standard Code allocation table.  | 
**DepartureDate** | **DateTime** | The Departure Date for the travel segment in ISO Date Format (yyyy-MM-dd). | 
**DepartureLocationCode** | **string** | A standard airline routing code (airport code or location identifier) applicable to the departure portion of this segment.  | [optional] 
**FlightNumber** | **string** | This field contains the carrier-assigned Flight Number for this travel segment. | 
**SegmentFare** | **int** | This field contains the total Fare for this travel segment. | [optional] 
**StopOverIndicator** | **string** | O &#x3D; Stopover allowed, X &#x3D; Stopover not allowed. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

