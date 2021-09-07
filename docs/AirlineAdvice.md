# CityPayAPI.Model.AirlineAdvice

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**CarrierName** | **string** | The name of the airline carrier that generated the tickets for airline travel. | 
**ConjunctionTicketIndicator** | **bool** | true if a conjunction ticket (with additional coupons) was issued for an itinerary with more than four segments. Defaults to false.  | [optional] 
**EticketIndicator** | **bool** | The Electronic Ticket Indicator, a code that indicates if an electronic ticket was issued.  Defaults to true. | [optional] 
**NoAirSegments** | **int** | A value that indicates the number of air travel segments included on this ticket.  Valid entries include the numerals “0” through “4”. Required only if the transaction type is TKT or EXC.  | [optional] 
**NumberInParty** | **int** | The number of people in the party. | 
**OriginalTicketNo** | **string** | Required if transaction type is EXC. | [optional] 
**PassengerName** | **string** | The name of the passenger when the traveller is not the card member that purchased the ticket. Required only if the transaction type is TKT or EXC. | [optional] 
**Segment1** | [**AirlineSegment**](AirlineSegment.md) |  | 
**Segment2** | [**AirlineSegment**](AirlineSegment.md) |  | [optional] 
**Segment3** | [**AirlineSegment**](AirlineSegment.md) |  | [optional] 
**Segment4** | [**AirlineSegment**](AirlineSegment.md) |  | [optional] 
**TicketIssueCity** | **string** | The name of the city town or village where the transaction took place. | 
**TicketIssueDate** | **DateTime** | The date the ticket was issued in ISO Date format (yyyy-MM-dd). | 
**TicketIssueName** | **string** | The name of the agency generating the ticket. | 
**TicketNo** | **string** | This must be a valid ticket number, i.e. numeric (the first 3 digits must represent the valid IATA plate carrier code). The final check digit should be validated prior to submission. On credit charges, this field should contain the number of the original ticket, and not of a replacement.  | 
**TransactionType** | **string** | This field contains the Transaction Type code assigned to this transaction. Valid codes include:   - &#x60;TKT&#x60; &#x3D; Ticket Purchase   - &#x60;REF&#x60; &#x3D; Refund   - &#x60;EXC&#x60; &#x3D; Exchange Ticket   - &#x60;MSC&#x60; &#x3D; Miscellaneous (non-Ticket Purchase- and non-Exchange Ticket-related transactions only).  | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

