/*
 * CityPay Payment API
 *
 *  This CityPay API is a HTTP RESTful payment API used for direct server to server transactional processing. It provides a number of payment mechanisms including: Internet, MOTO, Continuous Authority transaction processing, 3-D Secure decision handling using RFA Secure, Authorisation, Refunding, Pre-Authorisation, Cancellation/Voids and Completion processing. The API is also capable of tokinsed payments using Card Holder Accounts.  ## Compliance and Security Your application will need to adhere to PCI-DSS standards to operate safely and to meet requirements set out by  Visa and MasterCard and the PCI Security Standards Council. These include  * Data must be collected using TLS version 1.2 using [strong cryptography](#enabled-tls-ciphers). We will not accept calls to our API at   lower grade encryption levels. We regularly scan our TLS endpoints for vulnerabilities and perform TLS assessments   as part of our compliance program. * The application must not store sensitive card holder data (CHD) such as the card security code (CSC) or   primary access number (PAN) * The application must not display the full card number on receipts, it is recommended to mask the PAN   and show the last 4 digits. The API will return this for you for ease of receipt creation * If you are developing a website, you will be required to perform regular scans on the network where you host the   application to meet your compliance obligations * You will be required to be PCI Compliant and the application must adhere to the security standard. Further information   is available from [https://www.pcisecuritystandards.org/](https://www.pcisecuritystandards.org/) * The API verifies that the request is for a valid account and originates from a trusted source using the remote IP   address. Our application firewalls analyse data that may be an attempt to break a large number of security common   security vulnerabilities. 
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
    /// PaylinkPartPayments
    /// </summary>
    [DataContract(Name = "PaylinkPartPayments")]
    public partial class PaylinkPartPayments : IEquatable<PaylinkPartPayments>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PaylinkPartPayments" /> class.
        /// </summary>
        /// <param name="enabled">Determines if part payments is enabled. Default is false..</param>
        /// <param name="floor">The floor amount specifies a value that the minimum rate cannot go under. If 0 the amount of min rate is applied..</param>
        /// <param name="max">a maximum percentage to charge i.e. 90%..</param>
        /// <param name="maxRate">a rate as fixed or percentage..</param>
        /// <param name="min">a minimum percentage to charge i.e. 10..</param>
        /// <param name="minRate">a rate as fixed or percentage..</param>
        public PaylinkPartPayments(string enabled = default(string), string floor = default(string), string max = default(string), string maxRate = default(string), string min = default(string), string minRate = default(string))
        {
            this.Enabled = enabled;
            this.Floor = floor;
            this.Max = max;
            this.MaxRate = maxRate;
            this.Min = min;
            this.MinRate = minRate;
        }

        /// <summary>
        /// Determines if part payments is enabled. Default is false.
        /// </summary>
        /// <value>Determines if part payments is enabled. Default is false.</value>
        [DataMember(Name = "enabled", EmitDefaultValue = false)]
        public string Enabled { get; set; }

        /// <summary>
        /// The floor amount specifies a value that the minimum rate cannot go under. If 0 the amount of min rate is applied.
        /// </summary>
        /// <value>The floor amount specifies a value that the minimum rate cannot go under. If 0 the amount of min rate is applied.</value>
        [DataMember(Name = "floor", EmitDefaultValue = false)]
        public string Floor { get; set; }

        /// <summary>
        /// a maximum percentage to charge i.e. 90%.
        /// </summary>
        /// <value>a maximum percentage to charge i.e. 90%.</value>
        [DataMember(Name = "max", EmitDefaultValue = false)]
        public string Max { get; set; }

        /// <summary>
        /// a rate as fixed or percentage.
        /// </summary>
        /// <value>a rate as fixed or percentage.</value>
        [DataMember(Name = "max_rate", EmitDefaultValue = false)]
        public string MaxRate { get; set; }

        /// <summary>
        /// a minimum percentage to charge i.e. 10.
        /// </summary>
        /// <value>a minimum percentage to charge i.e. 10.</value>
        [DataMember(Name = "min", EmitDefaultValue = false)]
        public string Min { get; set; }

        /// <summary>
        /// a rate as fixed or percentage.
        /// </summary>
        /// <value>a rate as fixed or percentage.</value>
        [DataMember(Name = "min_rate", EmitDefaultValue = false)]
        public string MinRate { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class PaylinkPartPayments {\n");
            sb.Append("  Enabled: ").Append(Enabled).Append("\n");
            sb.Append("  Floor: ").Append(Floor).Append("\n");
            sb.Append("  Max: ").Append(Max).Append("\n");
            sb.Append("  MaxRate: ").Append(MaxRate).Append("\n");
            sb.Append("  Min: ").Append(Min).Append("\n");
            sb.Append("  MinRate: ").Append(MinRate).Append("\n");
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
            return this.Equals(input as PaylinkPartPayments);
        }

        /// <summary>
        /// Returns true if PaylinkPartPayments instances are equal
        /// </summary>
        /// <param name="input">Instance of PaylinkPartPayments to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PaylinkPartPayments input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Enabled == input.Enabled ||
                    (this.Enabled != null &&
                    this.Enabled.Equals(input.Enabled))
                ) && 
                (
                    this.Floor == input.Floor ||
                    (this.Floor != null &&
                    this.Floor.Equals(input.Floor))
                ) && 
                (
                    this.Max == input.Max ||
                    (this.Max != null &&
                    this.Max.Equals(input.Max))
                ) && 
                (
                    this.MaxRate == input.MaxRate ||
                    (this.MaxRate != null &&
                    this.MaxRate.Equals(input.MaxRate))
                ) && 
                (
                    this.Min == input.Min ||
                    (this.Min != null &&
                    this.Min.Equals(input.Min))
                ) && 
                (
                    this.MinRate == input.MinRate ||
                    (this.MinRate != null &&
                    this.MinRate.Equals(input.MinRate))
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
                if (this.Enabled != null)
                {
                    hashCode = (hashCode * 59) + this.Enabled.GetHashCode();
                }
                if (this.Floor != null)
                {
                    hashCode = (hashCode * 59) + this.Floor.GetHashCode();
                }
                if (this.Max != null)
                {
                    hashCode = (hashCode * 59) + this.Max.GetHashCode();
                }
                if (this.MaxRate != null)
                {
                    hashCode = (hashCode * 59) + this.MaxRate.GetHashCode();
                }
                if (this.Min != null)
                {
                    hashCode = (hashCode * 59) + this.Min.GetHashCode();
                }
                if (this.MinRate != null)
                {
                    hashCode = (hashCode * 59) + this.MinRate.GetHashCode();
                }
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        public IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
