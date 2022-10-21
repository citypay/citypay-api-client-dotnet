/*
 * CityPay Payment API
 *
 *  This CityPay API is a HTTP RESTful payment API used for direct server to server transactional processing. It provides a number of payment mechanisms including: Internet, MOTO, Continuous Authority transaction processing, 3-D Secure decision handling using RFA Secure, Authorisation, Refunding, Pre-Authorisation, Cancellation/Voids and Completion processing. The API is also capable of tokinsed payments using Card Holder Accounts.  ## Compliance and Security Your application will need to adhere to PCI-DSS standards to operate safely and to meet requirements set out by  Visa and MasterCard and the PCI Security Standards Council. These include  * Data must be collected using TLS version 1.2 using [strong cryptography](#enabled-tls-ciphers). We will not accept calls to our API at   lower grade encryption levels. We regularly scan our TLS endpoints for vulnerabilities and perform TLS assessments   as part of our compliance program. * The application must not store sensitive card holder data (CHD) such as the card security code (CSC) or   primary access number (PAN) * The application must not display the full card number on receipts, it is recommended to mask the PAN   and show the last 4 digits. The API will return this for you for ease of receipt creation * If you are developing a website, you will be required to perform regular scans on the network where you host the   application to meet your compliance obligations * You will be required to be PCI Compliant and the application must adhere to the security standard. Further information   is available from [https://www.pcisecuritystandards.org/](https://www.pcisecuritystandards.org/) * The API verifies that the request is for a valid account and originates from a trusted source using the remote IP   address. Our application firewalls analyse data that may be an attempt to break a large number of security common   security vulnerabilities.. 
 *
 * Contact: support@citypay.com
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = CityPayAPI.Client.OpenAPIDateConverter;

namespace CityPayAPI.Model
{
    /// <summary>
    /// AirlineSegment
    /// </summary>
    [DataContract(Name = "AirlineSegment")]
    public partial class AirlineSegment : IEquatable<AirlineSegment>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AirlineSegment" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AirlineSegment() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AirlineSegment" /> class.
        /// </summary>
        /// <param name="arrivalLocationCode">A standard airline routing code (airport code or location identifier) applicable to the arrival portion of this segment.  (required).</param>
        /// <param name="carrierCode">This field contains the two character airline designator code (air carrier code or airline code) that corresponds to the airline carrier applicable for up to four flight segments of this trip itinerary.  (required).</param>
        /// <param name="classServiceCode">This field contains a code that corresponds to the fare class (A, B, C, D, Premium, Discounted, etc.) within the overall class of service (e.g., First Class, Business, Economy) applicable to this travel segment, as specified in the IATA Standard Code allocation table.  (required).</param>
        /// <param name="departureDate">The Departure Date for the travel segment in ISO Date Format (yyyy-MM-dd). (required).</param>
        /// <param name="departureLocationCode">A standard airline routing code (airport code or location identifier) applicable to the departure portion of this segment. .</param>
        /// <param name="flightNumber">This field contains the carrier-assigned Flight Number for this travel segment. (required).</param>
        /// <param name="segmentFare">This field contains the total Fare for this travel segment..</param>
        /// <param name="stopOverIndicator">O &#x3D; Stopover allowed, X &#x3D; Stopover not allowed..</param>
        public AirlineSegment(string arrivalLocationCode = default(string), string carrierCode = default(string), string classServiceCode = default(string), DateTime departureDate = default(DateTime), string departureLocationCode = default(string), string flightNumber = default(string), int segmentFare = default(int), string stopOverIndicator = default(string))
        {
            // to ensure "arrivalLocationCode" is required (not null)
            this.ArrivalLocationCode = arrivalLocationCode ?? throw new ArgumentNullException("arrivalLocationCode is a required property for AirlineSegment and cannot be null");
            // to ensure "carrierCode" is required (not null)
            this.CarrierCode = carrierCode ?? throw new ArgumentNullException("carrierCode is a required property for AirlineSegment and cannot be null");
            // to ensure "classServiceCode" is required (not null)
            this.ClassServiceCode = classServiceCode ?? throw new ArgumentNullException("classServiceCode is a required property for AirlineSegment and cannot be null");
            this.DepartureDate = departureDate;
            // to ensure "flightNumber" is required (not null)
            this.FlightNumber = flightNumber ?? throw new ArgumentNullException("flightNumber is a required property for AirlineSegment and cannot be null");
            this.DepartureLocationCode = departureLocationCode;
            this.SegmentFare = segmentFare;
            this.StopOverIndicator = stopOverIndicator;
        }

        /// <summary>
        /// A standard airline routing code (airport code or location identifier) applicable to the arrival portion of this segment. 
        /// </summary>
        /// <value>A standard airline routing code (airport code or location identifier) applicable to the arrival portion of this segment. </value>
        [DataMember(Name = "arrival_location_code", IsRequired = true, EmitDefaultValue = false)]
        public string ArrivalLocationCode { get; set; }

        /// <summary>
        /// This field contains the two character airline designator code (air carrier code or airline code) that corresponds to the airline carrier applicable for up to four flight segments of this trip itinerary. 
        /// </summary>
        /// <value>This field contains the two character airline designator code (air carrier code or airline code) that corresponds to the airline carrier applicable for up to four flight segments of this trip itinerary. </value>
        [DataMember(Name = "carrier_code", IsRequired = true, EmitDefaultValue = false)]
        public string CarrierCode { get; set; }

        /// <summary>
        /// This field contains a code that corresponds to the fare class (A, B, C, D, Premium, Discounted, etc.) within the overall class of service (e.g., First Class, Business, Economy) applicable to this travel segment, as specified in the IATA Standard Code allocation table. 
        /// </summary>
        /// <value>This field contains a code that corresponds to the fare class (A, B, C, D, Premium, Discounted, etc.) within the overall class of service (e.g., First Class, Business, Economy) applicable to this travel segment, as specified in the IATA Standard Code allocation table. </value>
        [DataMember(Name = "class_service_code", IsRequired = true, EmitDefaultValue = false)]
        public string ClassServiceCode { get; set; }

        /// <summary>
        /// The Departure Date for the travel segment in ISO Date Format (yyyy-MM-dd).
        /// </summary>
        /// <value>The Departure Date for the travel segment in ISO Date Format (yyyy-MM-dd).</value>
        [DataMember(Name = "departure_date", IsRequired = true, EmitDefaultValue = false)]
        [JsonConverter(typeof(OpenAPIDateConverter))]
        public DateTime DepartureDate { get; set; }

        /// <summary>
        /// A standard airline routing code (airport code or location identifier) applicable to the departure portion of this segment. 
        /// </summary>
        /// <value>A standard airline routing code (airport code or location identifier) applicable to the departure portion of this segment. </value>
        [DataMember(Name = "departure_location_code", EmitDefaultValue = false)]
        public string DepartureLocationCode { get; set; }

        /// <summary>
        /// This field contains the carrier-assigned Flight Number for this travel segment.
        /// </summary>
        /// <value>This field contains the carrier-assigned Flight Number for this travel segment.</value>
        [DataMember(Name = "flight_number", IsRequired = true, EmitDefaultValue = false)]
        public string FlightNumber { get; set; }

        /// <summary>
        /// This field contains the total Fare for this travel segment.
        /// </summary>
        /// <value>This field contains the total Fare for this travel segment.</value>
        [DataMember(Name = "segment_fare", EmitDefaultValue = false)]
        public int SegmentFare { get; set; }

        /// <summary>
        /// O &#x3D; Stopover allowed, X &#x3D; Stopover not allowed.
        /// </summary>
        /// <value>O &#x3D; Stopover allowed, X &#x3D; Stopover not allowed.</value>
        [DataMember(Name = "stop_over_indicator", EmitDefaultValue = false)]
        public string StopOverIndicator { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AirlineSegment {\n");
            sb.Append("  ArrivalLocationCode: ").Append(ArrivalLocationCode).Append("\n");
            sb.Append("  CarrierCode: ").Append(CarrierCode).Append("\n");
            sb.Append("  ClassServiceCode: ").Append(ClassServiceCode).Append("\n");
            sb.Append("  DepartureDate: ").Append(DepartureDate).Append("\n");
            sb.Append("  DepartureLocationCode: ").Append(DepartureLocationCode).Append("\n");
            sb.Append("  FlightNumber: ").Append(FlightNumber).Append("\n");
            sb.Append("  SegmentFare: ").Append(SegmentFare).Append("\n");
            sb.Append("  StopOverIndicator: ").Append(StopOverIndicator).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as AirlineSegment);
        }

        /// <summary>
        /// Returns true if AirlineSegment instances are equal
        /// </summary>
        /// <param name="input">Instance of AirlineSegment to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AirlineSegment input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ArrivalLocationCode == input.ArrivalLocationCode ||
                    (this.ArrivalLocationCode != null &&
                    this.ArrivalLocationCode.Equals(input.ArrivalLocationCode))
                ) && 
                (
                    this.CarrierCode == input.CarrierCode ||
                    (this.CarrierCode != null &&
                    this.CarrierCode.Equals(input.CarrierCode))
                ) && 
                (
                    this.ClassServiceCode == input.ClassServiceCode ||
                    (this.ClassServiceCode != null &&
                    this.ClassServiceCode.Equals(input.ClassServiceCode))
                ) && 
                (
                    this.DepartureDate == input.DepartureDate ||
                    (this.DepartureDate != null &&
                    this.DepartureDate.Equals(input.DepartureDate))
                ) && 
                (
                    this.DepartureLocationCode == input.DepartureLocationCode ||
                    (this.DepartureLocationCode != null &&
                    this.DepartureLocationCode.Equals(input.DepartureLocationCode))
                ) && 
                (
                    this.FlightNumber == input.FlightNumber ||
                    (this.FlightNumber != null &&
                    this.FlightNumber.Equals(input.FlightNumber))
                ) && 
                (
                    this.SegmentFare == input.SegmentFare ||
                    this.SegmentFare.Equals(input.SegmentFare)
                ) && 
                (
                    this.StopOverIndicator == input.StopOverIndicator ||
                    (this.StopOverIndicator != null &&
                    this.StopOverIndicator.Equals(input.StopOverIndicator))
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
                if (this.ArrivalLocationCode != null)
                    hashCode = hashCode * 59 + this.ArrivalLocationCode.GetHashCode();
                if (this.CarrierCode != null)
                    hashCode = hashCode * 59 + this.CarrierCode.GetHashCode();
                if (this.ClassServiceCode != null)
                    hashCode = hashCode * 59 + this.ClassServiceCode.GetHashCode();
                if (this.DepartureDate != null)
                    hashCode = hashCode * 59 + this.DepartureDate.GetHashCode();
                if (this.DepartureLocationCode != null)
                    hashCode = hashCode * 59 + this.DepartureLocationCode.GetHashCode();
                if (this.FlightNumber != null)
                    hashCode = hashCode * 59 + this.FlightNumber.GetHashCode();
                hashCode = hashCode * 59 + this.SegmentFare.GetHashCode();
                if (this.StopOverIndicator != null)
                    hashCode = hashCode * 59 + this.StopOverIndicator.GetHashCode();
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
            // ArrivalLocationCode (string) maxLength
            if(this.ArrivalLocationCode != null && this.ArrivalLocationCode.Length > 3)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ArrivalLocationCode, length must be less than 3.", new [] { "ArrivalLocationCode" });
            }

            // CarrierCode (string) maxLength
            if(this.CarrierCode != null && this.CarrierCode.Length > 2)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for CarrierCode, length must be less than 2.", new [] { "CarrierCode" });
            }

            // ClassServiceCode (string) maxLength
            if(this.ClassServiceCode != null && this.ClassServiceCode.Length > 2)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ClassServiceCode, length must be less than 2.", new [] { "ClassServiceCode" });
            }

            // DepartureLocationCode (string) maxLength
            if(this.DepartureLocationCode != null && this.DepartureLocationCode.Length > 3)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for DepartureLocationCode, length must be less than 3.", new [] { "DepartureLocationCode" });
            }

            // FlightNumber (string) maxLength
            if(this.FlightNumber != null && this.FlightNumber.Length > 4)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for FlightNumber, length must be less than 4.", new [] { "FlightNumber" });
            }

            // StopOverIndicator (string) maxLength
            if(this.StopOverIndicator != null && this.StopOverIndicator.Length > 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for StopOverIndicator, length must be less than 1.", new [] { "StopOverIndicator" });
            }

            yield break;
        }
    }

}
