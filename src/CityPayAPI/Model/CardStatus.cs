/*
 * CityPay Payment API
 *
 *  This CityPay API is a HTTP RESTful payment API used for direct server to server transactional processing. It provides a number of payment mechanisms including: Internet, MOTO, Continuous Authority transaction processing, 3-D Secure decision handling using RFA Secure, Authorisation, Refunding, Pre-Authorisation, Cancellation/Voids and Completion processing. The API is also capable of tokinsed payments using Card Holder Accounts.  ## Compliance and Security <aside class=\"notice\">   Before we begin a reminder that your application will need to adhere to PCI-DSS standards to operate safely   and to meet requirements set out by Visa and MasterCard and the PCI Security Standards Council including: </aside>  * Data must be collected using TLS version 1.2 using [strong cryptography](#enabled-tls-ciphers). We will not accept calls to our API at   lower grade encryption levels. We regularly scan our TLS endpoints for vulnerabilities and perform TLS assessments   as part of our compliance program. * The application must not store sensitive card holder data (CHD) such as the card security code (CSC) or   primary access number (PAN) * The application must not display the full card number on receipts, it is recommended to mask the PAN   and show the last 4 digits. The API will return this for you for ease of receipt creation * If you are developing a website, you will be required to perform regular scans on the network where you host the   application to meet your compliance obligations * You will be required to be PCI Compliant and the application must adhere to the security standard. Further information   is available from [https://www.pcisecuritystandards.org/](https://www.pcisecuritystandards.org/) * The API verifies that the request is for a valid account and originates from a trusted source using the remote IP   address. Our application firewalls analyse data that may be an attempt to break a large number of security common   security vulnerabilities. 
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
    /// CardStatus
    /// </summary>
    [DataContract(Name = "CardStatus")]
    public partial class CardStatus : IEquatable<CardStatus>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CardStatus" /> class.
        /// </summary>
        /// <param name="cardStatus">The status of the card to set, valid values are ACTIVE or INACTIVE..</param>
        /// <param name="_default">Defines if the card is set as the default..</param>
        public CardStatus(string cardStatus = default(string), bool _default = default(bool))
        {
            this._CardStatus = cardStatus;
            this.Default = _default;
        }

        /// <summary>
        /// The status of the card to set, valid values are ACTIVE or INACTIVE.
        /// </summary>
        /// <value>The status of the card to set, valid values are ACTIVE or INACTIVE.</value>
        [DataMember(Name = "card_status", EmitDefaultValue = false)]
        public string _CardStatus { get; set; }

        /// <summary>
        /// Defines if the card is set as the default.
        /// </summary>
        /// <value>Defines if the card is set as the default.</value>
        [DataMember(Name = "default", EmitDefaultValue = true)]
        public bool Default { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CardStatus {\n");
            sb.Append("  _CardStatus: ").Append(_CardStatus).Append("\n");
            sb.Append("  Default: ").Append(Default).Append("\n");
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
            return this.Equals(input as CardStatus);
        }

        /// <summary>
        /// Returns true if CardStatus instances are equal
        /// </summary>
        /// <param name="input">Instance of CardStatus to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CardStatus input)
        {
            if (input == null)
                return false;

            return 
                (
                    this._CardStatus == input._CardStatus ||
                    (this._CardStatus != null &&
                    this._CardStatus.Equals(input._CardStatus))
                ) && 
                (
                    this.Default == input.Default ||
                    this.Default.Equals(input.Default)
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
                if (this._CardStatus != null)
                    hashCode = hashCode * 59 + this._CardStatus.GetHashCode();
                hashCode = hashCode * 59 + this.Default.GetHashCode();
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
            yield break;
        }
    }

}
