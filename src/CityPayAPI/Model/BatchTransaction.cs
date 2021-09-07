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
    /// BatchTransaction
    /// </summary>
    [DataContract(Name = "BatchTransaction")]
    public partial class BatchTransaction : IEquatable<BatchTransaction>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BatchTransaction" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected BatchTransaction() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="BatchTransaction" /> class.
        /// </summary>
        /// <param name="accountId">The card holder account id to process against. (required).</param>
        /// <param name="amount">The amount required to process in the lowest denomination. (required).</param>
        /// <param name="identifier">An identifier used to reference the transaction set by your integration. The value should be used to refer to the transaction in future calls..</param>
        /// <param name="merchantid">The CityPay merchant id used to process the transaction..</param>
        public BatchTransaction(string accountId = default(string), int amount = default(int), string identifier = default(string), int merchantid = default(int))
        {
            // to ensure "accountId" is required (not null)
            this.AccountId = accountId ?? throw new ArgumentNullException("accountId is a required property for BatchTransaction and cannot be null");
            this.Amount = amount;
            this.Identifier = identifier;
            this.Merchantid = merchantid;
        }

        /// <summary>
        /// The card holder account id to process against.
        /// </summary>
        /// <value>The card holder account id to process against.</value>
        [DataMember(Name = "account_id", IsRequired = true, EmitDefaultValue = false)]
        public string AccountId { get; set; }

        /// <summary>
        /// The amount required to process in the lowest denomination.
        /// </summary>
        /// <value>The amount required to process in the lowest denomination.</value>
        [DataMember(Name = "amount", IsRequired = true, EmitDefaultValue = false)]
        public int Amount { get; set; }

        /// <summary>
        /// An identifier used to reference the transaction set by your integration. The value should be used to refer to the transaction in future calls.
        /// </summary>
        /// <value>An identifier used to reference the transaction set by your integration. The value should be used to refer to the transaction in future calls.</value>
        [DataMember(Name = "identifier", EmitDefaultValue = false)]
        public string Identifier { get; set; }

        /// <summary>
        /// The CityPay merchant id used to process the transaction.
        /// </summary>
        /// <value>The CityPay merchant id used to process the transaction.</value>
        [DataMember(Name = "merchantid", EmitDefaultValue = false)]
        public int Merchantid { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BatchTransaction {\n");
            sb.Append("  AccountId: ").Append(AccountId).Append("\n");
            sb.Append("  Amount: ").Append(Amount).Append("\n");
            sb.Append("  Identifier: ").Append(Identifier).Append("\n");
            sb.Append("  Merchantid: ").Append(Merchantid).Append("\n");
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
            return this.Equals(input as BatchTransaction);
        }

        /// <summary>
        /// Returns true if BatchTransaction instances are equal
        /// </summary>
        /// <param name="input">Instance of BatchTransaction to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BatchTransaction input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AccountId == input.AccountId ||
                    (this.AccountId != null &&
                    this.AccountId.Equals(input.AccountId))
                ) && 
                (
                    this.Amount == input.Amount ||
                    this.Amount.Equals(input.Amount)
                ) && 
                (
                    this.Identifier == input.Identifier ||
                    (this.Identifier != null &&
                    this.Identifier.Equals(input.Identifier))
                ) && 
                (
                    this.Merchantid == input.Merchantid ||
                    this.Merchantid.Equals(input.Merchantid)
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
                if (this.AccountId != null)
                    hashCode = hashCode * 59 + this.AccountId.GetHashCode();
                hashCode = hashCode * 59 + this.Amount.GetHashCode();
                if (this.Identifier != null)
                    hashCode = hashCode * 59 + this.Identifier.GetHashCode();
                hashCode = hashCode * 59 + this.Merchantid.GetHashCode();
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
            // AccountId (string) maxLength
            if(this.AccountId != null && this.AccountId.Length > 50)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for AccountId, length must be less than 50.", new [] { "AccountId" });
            }

            // AccountId (string) minLength
            if(this.AccountId != null && this.AccountId.Length < 5)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for AccountId, length must be greater than 5.", new [] { "AccountId" });
            }

            // Identifier (string) maxLength
            if(this.Identifier != null && this.Identifier.Length > 50)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Identifier, length must be less than 50.", new [] { "Identifier" });
            }

            // Identifier (string) minLength
            if(this.Identifier != null && this.Identifier.Length < 4)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Identifier, length must be greater than 4.", new [] { "Identifier" });
            }

            yield break;
        }
    }

}