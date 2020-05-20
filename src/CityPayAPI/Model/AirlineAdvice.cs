/* 
 * CityPay Payment API
 *
 *  This CityPay API is a HTTP RESTful payment API used for direct server to server transactional processing. It provides a number of payment mechanisms including: Internet, MOTO, Continuous Authority transaction processing, 3-D Secure decision handling using RFA Secure, Authorisation, Refunding, Pre-Authorisation, Cancellation/Voids and Completion processing. The API is also capable of tokinsed payments using Card Holder Accounts.  ## Compliance and Security <aside class=\"notice\">   Before we begin a reminder that your application will need to adhere to PCI-DSS standards to operate safely   and to meet requirements set out by Visa and MasterCard and the PCI Security Standards Council including: </aside>  * Data must be collected using TLS version 1.2 using [strong cryptography](#enabled-tls-ciphers). We will not accept calls to our API at   lower grade encryption levels. We regularly scan our TLS endpoints for vulnerabilities and perform TLS assessments   as part of our compliance program. * The application must not store sensitive card holder data (CHD) such as the card security code (CSC) or   primary access number (PAN) * The application must not display the full card number on receipts, it is recommended to mask the PAN   and show the last 4 digits. The API will return this for you for ease of receipt creation * If you are developing a website, you will be required to perform regular scans on the network where you host the   application to meet your compliance obligations * You will be required to be PCI Compliant and the application must adhere to the security standard. Further information   is available from [https://www.pcisecuritystandards.org/](https://www.pcisecuritystandards.org/) * The API verifies that the request is for a valid account and originates from a trusted source using the remote IP   address. Our application firewalls analyse data that may be an attempt to break a large number of security common   security vulnerabilities. 
 *
 * The version of the OpenAPI document: 6.0.0.BETA
 * Contact: support@citypay.com
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = CityPayAPI.Client.OpenAPIDateConverter;

namespace CityPayAPI.Model
{
    /// <summary>
    /// AirlineAdvice
    /// </summary>
    [DataContract]
    public partial class AirlineAdvice :  IEquatable<AirlineAdvice>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AirlineAdvice" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AirlineAdvice() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AirlineAdvice" /> class.
        /// </summary>
        /// <param name="carrierName">The name of the airline carrier that generated the tickets for airline travel. (required).</param>
        /// <param name="conjunctionTicketIndicator">true if a conjunction ticket (with additional coupons) was issued for an itinerary with more than four segments. Defaults to false. .</param>
        /// <param name="eticketIndicator">The Electronic Ticket Indicator, a code that indicates if an electronic ticket was issued.  Defaults to true..</param>
        /// <param name="noAirSegments">A value that indicates the number of air travel segments included on this ticket. Valid entries include the numerals “0” through “4”. Required only if the transaction type is TKT or EXC. .</param>
        /// <param name="numberInParty">The number of people in the party. (required).</param>
        /// <param name="originalTicketNo">Required if transaction type is EXC..</param>
        /// <param name="passengerName">The name of the passenger when the traveller is not the card member that purchased the ticket. Required only if the transaction type is TKT or EXC..</param>
        /// <param name="segment1">segment1 (required).</param>
        /// <param name="segment2">segment2.</param>
        /// <param name="segment3">segment3.</param>
        /// <param name="segment4">segment4.</param>
        /// <param name="ticketIssueCity">The name of the city town or village where the transaction took place. (required).</param>
        /// <param name="ticketIssueDate">The date the ticket was issued in ISO Date format (yyyy-MM-dd). (required).</param>
        /// <param name="ticketIssueName">The name of the agency generating the ticket. (required).</param>
        /// <param name="ticketNo">This must be a valid ticket number, i.e. numeric (the first 3 digits must represent the valid IATA plate carrier code). The final check digit should be validated prior to submission. On credit charges, this field should contain the number of the original ticket, and not of a replacement.  (required).</param>
        /// <param name="transactionType">This field contains the Transaction Type code assigned to this transaction. Valid codes include:   - &#x60;TKT&#x60; &#x3D; Ticket Purchase  - &#x60;REF&#x60; &#x3D; Refund  - &#x60;EXC&#x60; &#x3D; Exchange Ticket  - &#x60;MSC&#x60; &#x3D; Miscellaneous (non-Ticket Purchase- and non-Exchange Ticket-related transactions only).  (required).</param>
        public AirlineAdvice(string carrierName = default(string), bool conjunctionTicketIndicator = default(bool), bool eticketIndicator = default(bool), int noAirSegments = default(int), int numberInParty = default(int), string originalTicketNo = default(string), string passengerName = default(string), AirlineSegment segment1 = default(AirlineSegment), AirlineSegment segment2 = default(AirlineSegment), AirlineSegment segment3 = default(AirlineSegment), AirlineSegment segment4 = default(AirlineSegment), string ticketIssueCity = default(string), DateTime ticketIssueDate = default(DateTime), string ticketIssueName = default(string), string ticketNo = default(string), string transactionType = default(string))
        {
            // to ensure "carrierName" is required (not null)
            this.CarrierName = carrierName ?? throw new ArgumentNullException("carrierName is a required property for AirlineAdvice and cannot be null");
            this.NumberInParty = numberInParty;
            // to ensure "segment1" is required (not null)
            this.Segment1 = segment1 ?? throw new ArgumentNullException("segment1 is a required property for AirlineAdvice and cannot be null");
            // to ensure "ticketIssueCity" is required (not null)
            this.TicketIssueCity = ticketIssueCity ?? throw new ArgumentNullException("ticketIssueCity is a required property for AirlineAdvice and cannot be null");
            this.TicketIssueDate = ticketIssueDate;
            // to ensure "ticketIssueName" is required (not null)
            this.TicketIssueName = ticketIssueName ?? throw new ArgumentNullException("ticketIssueName is a required property for AirlineAdvice and cannot be null");
            // to ensure "ticketNo" is required (not null)
            this.TicketNo = ticketNo ?? throw new ArgumentNullException("ticketNo is a required property for AirlineAdvice and cannot be null");
            // to ensure "transactionType" is required (not null)
            this.TransactionType = transactionType ?? throw new ArgumentNullException("transactionType is a required property for AirlineAdvice and cannot be null");
            this.ConjunctionTicketIndicator = conjunctionTicketIndicator;
            this.EticketIndicator = eticketIndicator;
            this.NoAirSegments = noAirSegments;
            this.OriginalTicketNo = originalTicketNo;
            this.PassengerName = passengerName;
            this.Segment2 = segment2;
            this.Segment3 = segment3;
            this.Segment4 = segment4;
        }
        
        /// <summary>
        /// The name of the airline carrier that generated the tickets for airline travel.
        /// </summary>
        /// <value>The name of the airline carrier that generated the tickets for airline travel.</value>
        [DataMember(Name="carrier_name", EmitDefaultValue=false)]
        public string CarrierName { get; set; }

        /// <summary>
        /// true if a conjunction ticket (with additional coupons) was issued for an itinerary with more than four segments. Defaults to false. 
        /// </summary>
        /// <value>true if a conjunction ticket (with additional coupons) was issued for an itinerary with more than four segments. Defaults to false. </value>
        [DataMember(Name="conjunction_ticket_indicator", EmitDefaultValue=false)]
        public bool ConjunctionTicketIndicator { get; set; }

        /// <summary>
        /// The Electronic Ticket Indicator, a code that indicates if an electronic ticket was issued.  Defaults to true.
        /// </summary>
        /// <value>The Electronic Ticket Indicator, a code that indicates if an electronic ticket was issued.  Defaults to true.</value>
        [DataMember(Name="eticket_indicator", EmitDefaultValue=false)]
        public bool EticketIndicator { get; set; }

        /// <summary>
        /// A value that indicates the number of air travel segments included on this ticket. Valid entries include the numerals “0” through “4”. Required only if the transaction type is TKT or EXC. 
        /// </summary>
        /// <value>A value that indicates the number of air travel segments included on this ticket. Valid entries include the numerals “0” through “4”. Required only if the transaction type is TKT or EXC. </value>
        [DataMember(Name="no_air_segments", EmitDefaultValue=false)]
        public int NoAirSegments { get; set; }

        /// <summary>
        /// The number of people in the party.
        /// </summary>
        /// <value>The number of people in the party.</value>
        [DataMember(Name="number_in_party", EmitDefaultValue=false)]
        public int NumberInParty { get; set; }

        /// <summary>
        /// Required if transaction type is EXC.
        /// </summary>
        /// <value>Required if transaction type is EXC.</value>
        [DataMember(Name="original_ticket_no", EmitDefaultValue=false)]
        public string OriginalTicketNo { get; set; }

        /// <summary>
        /// The name of the passenger when the traveller is not the card member that purchased the ticket. Required only if the transaction type is TKT or EXC.
        /// </summary>
        /// <value>The name of the passenger when the traveller is not the card member that purchased the ticket. Required only if the transaction type is TKT or EXC.</value>
        [DataMember(Name="passenger_name", EmitDefaultValue=false)]
        public string PassengerName { get; set; }

        /// <summary>
        /// Gets or Sets Segment1
        /// </summary>
        [DataMember(Name="segment1", EmitDefaultValue=false)]
        public AirlineSegment Segment1 { get; set; }

        /// <summary>
        /// Gets or Sets Segment2
        /// </summary>
        [DataMember(Name="segment2", EmitDefaultValue=false)]
        public AirlineSegment Segment2 { get; set; }

        /// <summary>
        /// Gets or Sets Segment3
        /// </summary>
        [DataMember(Name="segment3", EmitDefaultValue=false)]
        public AirlineSegment Segment3 { get; set; }

        /// <summary>
        /// Gets or Sets Segment4
        /// </summary>
        [DataMember(Name="segment4", EmitDefaultValue=false)]
        public AirlineSegment Segment4 { get; set; }

        /// <summary>
        /// The name of the city town or village where the transaction took place.
        /// </summary>
        /// <value>The name of the city town or village where the transaction took place.</value>
        [DataMember(Name="ticket_issue_city", EmitDefaultValue=false)]
        public string TicketIssueCity { get; set; }

        /// <summary>
        /// The date the ticket was issued in ISO Date format (yyyy-MM-dd).
        /// </summary>
        /// <value>The date the ticket was issued in ISO Date format (yyyy-MM-dd).</value>
        [DataMember(Name="ticket_issue_date", EmitDefaultValue=false)]
        [JsonConverter(typeof(OpenAPIDateConverter))]
        public DateTime TicketIssueDate { get; set; }

        /// <summary>
        /// The name of the agency generating the ticket.
        /// </summary>
        /// <value>The name of the agency generating the ticket.</value>
        [DataMember(Name="ticket_issue_name", EmitDefaultValue=false)]
        public string TicketIssueName { get; set; }

        /// <summary>
        /// This must be a valid ticket number, i.e. numeric (the first 3 digits must represent the valid IATA plate carrier code). The final check digit should be validated prior to submission. On credit charges, this field should contain the number of the original ticket, and not of a replacement. 
        /// </summary>
        /// <value>This must be a valid ticket number, i.e. numeric (the first 3 digits must represent the valid IATA plate carrier code). The final check digit should be validated prior to submission. On credit charges, this field should contain the number of the original ticket, and not of a replacement. </value>
        [DataMember(Name="ticket_no", EmitDefaultValue=false)]
        public string TicketNo { get; set; }

        /// <summary>
        /// This field contains the Transaction Type code assigned to this transaction. Valid codes include:   - &#x60;TKT&#x60; &#x3D; Ticket Purchase  - &#x60;REF&#x60; &#x3D; Refund  - &#x60;EXC&#x60; &#x3D; Exchange Ticket  - &#x60;MSC&#x60; &#x3D; Miscellaneous (non-Ticket Purchase- and non-Exchange Ticket-related transactions only). 
        /// </summary>
        /// <value>This field contains the Transaction Type code assigned to this transaction. Valid codes include:   - &#x60;TKT&#x60; &#x3D; Ticket Purchase  - &#x60;REF&#x60; &#x3D; Refund  - &#x60;EXC&#x60; &#x3D; Exchange Ticket  - &#x60;MSC&#x60; &#x3D; Miscellaneous (non-Ticket Purchase- and non-Exchange Ticket-related transactions only). </value>
        [DataMember(Name="transaction_type", EmitDefaultValue=false)]
        public string TransactionType { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AirlineAdvice {\n");
            sb.Append("  CarrierName: ").Append(CarrierName).Append("\n");
            sb.Append("  ConjunctionTicketIndicator: ").Append(ConjunctionTicketIndicator).Append("\n");
            sb.Append("  EticketIndicator: ").Append(EticketIndicator).Append("\n");
            sb.Append("  NoAirSegments: ").Append(NoAirSegments).Append("\n");
            sb.Append("  NumberInParty: ").Append(NumberInParty).Append("\n");
            sb.Append("  OriginalTicketNo: ").Append(OriginalTicketNo).Append("\n");
            sb.Append("  PassengerName: ").Append(PassengerName).Append("\n");
            sb.Append("  Segment1: ").Append(Segment1).Append("\n");
            sb.Append("  Segment2: ").Append(Segment2).Append("\n");
            sb.Append("  Segment3: ").Append(Segment3).Append("\n");
            sb.Append("  Segment4: ").Append(Segment4).Append("\n");
            sb.Append("  TicketIssueCity: ").Append(TicketIssueCity).Append("\n");
            sb.Append("  TicketIssueDate: ").Append(TicketIssueDate).Append("\n");
            sb.Append("  TicketIssueName: ").Append(TicketIssueName).Append("\n");
            sb.Append("  TicketNo: ").Append(TicketNo).Append("\n");
            sb.Append("  TransactionType: ").Append(TransactionType).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as AirlineAdvice);
        }

        /// <summary>
        /// Returns true if AirlineAdvice instances are equal
        /// </summary>
        /// <param name="input">Instance of AirlineAdvice to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AirlineAdvice input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.CarrierName == input.CarrierName ||
                    (this.CarrierName != null &&
                    this.CarrierName.Equals(input.CarrierName))
                ) && 
                (
                    this.ConjunctionTicketIndicator == input.ConjunctionTicketIndicator ||
                    this.ConjunctionTicketIndicator.Equals(input.ConjunctionTicketIndicator)
                ) && 
                (
                    this.EticketIndicator == input.EticketIndicator ||
                    this.EticketIndicator.Equals(input.EticketIndicator)
                ) && 
                (
                    this.NoAirSegments == input.NoAirSegments ||
                    this.NoAirSegments.Equals(input.NoAirSegments)
                ) && 
                (
                    this.NumberInParty == input.NumberInParty ||
                    this.NumberInParty.Equals(input.NumberInParty)
                ) && 
                (
                    this.OriginalTicketNo == input.OriginalTicketNo ||
                    (this.OriginalTicketNo != null &&
                    this.OriginalTicketNo.Equals(input.OriginalTicketNo))
                ) && 
                (
                    this.PassengerName == input.PassengerName ||
                    (this.PassengerName != null &&
                    this.PassengerName.Equals(input.PassengerName))
                ) && 
                (
                    this.Segment1 == input.Segment1 ||
                    (this.Segment1 != null &&
                    this.Segment1.Equals(input.Segment1))
                ) && 
                (
                    this.Segment2 == input.Segment2 ||
                    (this.Segment2 != null &&
                    this.Segment2.Equals(input.Segment2))
                ) && 
                (
                    this.Segment3 == input.Segment3 ||
                    (this.Segment3 != null &&
                    this.Segment3.Equals(input.Segment3))
                ) && 
                (
                    this.Segment4 == input.Segment4 ||
                    (this.Segment4 != null &&
                    this.Segment4.Equals(input.Segment4))
                ) && 
                (
                    this.TicketIssueCity == input.TicketIssueCity ||
                    (this.TicketIssueCity != null &&
                    this.TicketIssueCity.Equals(input.TicketIssueCity))
                ) && 
                (
                    this.TicketIssueDate == input.TicketIssueDate ||
                    (this.TicketIssueDate != null &&
                    this.TicketIssueDate.Equals(input.TicketIssueDate))
                ) && 
                (
                    this.TicketIssueName == input.TicketIssueName ||
                    (this.TicketIssueName != null &&
                    this.TicketIssueName.Equals(input.TicketIssueName))
                ) && 
                (
                    this.TicketNo == input.TicketNo ||
                    (this.TicketNo != null &&
                    this.TicketNo.Equals(input.TicketNo))
                ) && 
                (
                    this.TransactionType == input.TransactionType ||
                    (this.TransactionType != null &&
                    this.TransactionType.Equals(input.TransactionType))
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.CarrierName != null)
                    hashCode = hashCode * 59 + this.CarrierName.GetHashCode();
                hashCode = hashCode * 59 + this.ConjunctionTicketIndicator.GetHashCode();
                hashCode = hashCode * 59 + this.EticketIndicator.GetHashCode();
                hashCode = hashCode * 59 + this.NoAirSegments.GetHashCode();
                hashCode = hashCode * 59 + this.NumberInParty.GetHashCode();
                if (this.OriginalTicketNo != null)
                    hashCode = hashCode * 59 + this.OriginalTicketNo.GetHashCode();
                if (this.PassengerName != null)
                    hashCode = hashCode * 59 + this.PassengerName.GetHashCode();
                if (this.Segment1 != null)
                    hashCode = hashCode * 59 + this.Segment1.GetHashCode();
                if (this.Segment2 != null)
                    hashCode = hashCode * 59 + this.Segment2.GetHashCode();
                if (this.Segment3 != null)
                    hashCode = hashCode * 59 + this.Segment3.GetHashCode();
                if (this.Segment4 != null)
                    hashCode = hashCode * 59 + this.Segment4.GetHashCode();
                if (this.TicketIssueCity != null)
                    hashCode = hashCode * 59 + this.TicketIssueCity.GetHashCode();
                if (this.TicketIssueDate != null)
                    hashCode = hashCode * 59 + this.TicketIssueDate.GetHashCode();
                if (this.TicketIssueName != null)
                    hashCode = hashCode * 59 + this.TicketIssueName.GetHashCode();
                if (this.TicketNo != null)
                    hashCode = hashCode * 59 + this.TicketNo.GetHashCode();
                if (this.TransactionType != null)
                    hashCode = hashCode * 59 + this.TransactionType.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            // CarrierName (string) maxLength
            if(this.CarrierName != null && this.CarrierName.Length > 25)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for CarrierName, length must be less than 25.", new [] { "CarrierName" });
            }

            // NoAirSegments (int) maximum
            if(this.NoAirSegments > (int)4)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for NoAirSegments, must be a value less than or equal to 4.", new [] { "NoAirSegments" });
            }

            // NoAirSegments (int) minimum
            if(this.NoAirSegments < (int)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for NoAirSegments, must be a value greater than or equal to 0.", new [] { "NoAirSegments" });
            }

            // OriginalTicketNo (string) maxLength
            if(this.OriginalTicketNo != null && this.OriginalTicketNo.Length > 14)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for OriginalTicketNo, length must be less than 14.", new [] { "OriginalTicketNo" });
            }

            // PassengerName (string) maxLength
            if(this.PassengerName != null && this.PassengerName.Length > 25)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for PassengerName, length must be less than 25.", new [] { "PassengerName" });
            }

            // TicketIssueCity (string) maxLength
            if(this.TicketIssueCity != null && this.TicketIssueCity.Length > 18)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for TicketIssueCity, length must be less than 18.", new [] { "TicketIssueCity" });
            }

            // TicketIssueName (string) maxLength
            if(this.TicketIssueName != null && this.TicketIssueName.Length > 26)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for TicketIssueName, length must be less than 26.", new [] { "TicketIssueName" });
            }

            // TicketNo (string) maxLength
            if(this.TicketNo != null && this.TicketNo.Length > 14)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for TicketNo, length must be less than 14.", new [] { "TicketNo" });
            }

            // TransactionType (string) maxLength
            if(this.TransactionType != null && this.TransactionType.Length > 3)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for TransactionType, length must be less than 3.", new [] { "TransactionType" });
            }

            // TransactionType (string) minLength
            if(this.TransactionType != null && this.TransactionType.Length < 3)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for TransactionType, length must be greater than 3.", new [] { "TransactionType" });
            }

            yield break;
        }
    }

}
