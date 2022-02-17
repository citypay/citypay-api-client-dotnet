/*
 * CityPay Payment API
 *
 *  This CityPay API is a HTTP RESTful payment API used for direct server to server transactional processing. It provides a number of payment mechanisms including: Internet, MOTO, Continuous Authority transaction processing, 3-D Secure decision handling using RFA Secure, Authorisation, Refunding, Pre-Authorisation, Cancellation/Voids and Completion processing. The API is also capable of tokinsed payments using Card Holder Accounts.  ## Compliance and Security <aside class=\"notice\">   Before we begin a reminder that your application will need to adhere to PCI-DSS standards to operate safely   and to meet requirements set out by Visa and MasterCard and the PCI Security Standards Council including: </aside>  * Data must be collected using TLS version 1.2 using [strong cryptography](#enabled-tls-ciphers). We will not accept calls to our API at   lower grade encryption levels. We regularly scan our TLS endpoints for vulnerabilities and perform TLS assessments   as part of our compliance program. * The application must not store sensitive card holder data (CHD) such as the card security code (CSC) or   primary access number (PAN) * The application must not display the full card number on receipts, it is recommended to mask the PAN   and show the last 4 digits. The API will return this for you for ease of receipt creation * If you are developing a website, you will be required to perform regular scans on the network where you host the   application to meet your compliance obligations * You will be required to be PCI Compliant and the application must adhere to the security standard. Further information   is available from [https://www.pcisecuritystandards.org/](https://www.pcisecuritystandards.org/) * The API verifies that the request is for a valid account and originates from a trusted source using the remote IP   address. Our application firewalls analyse data that may be an attempt to break a large number of security common   security vulnerabilities.. 
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
    /// CardHolderAccount
    /// </summary>
    [DataContract(Name = "CardHolderAccount")]
    public partial class CardHolderAccount : IEquatable<CardHolderAccount>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CardHolderAccount" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CardHolderAccount() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CardHolderAccount" /> class.
        /// </summary>
        /// <param name="accountId">The account id of the card holder account provided by the merchant which uniquely identifies the account.  (required).</param>
        /// <param name="cards">cards.</param>
        /// <param name="contact">contact (required).</param>
        /// <param name="dateCreated">The date and time the account was created..</param>
        /// <param name="defaultCardId">The id of the default card..</param>
        /// <param name="defaultCardIndex">The index in the array of the default card..</param>
        /// <param name="lastModified">The date and time the account was last modified..</param>
        /// <param name="status">Defines the status of the account for processing valid values are   - ACTIVE for active accounts that are able to process   - DISABLED for accounts that are currently disabled for processing. .</param>
        /// <param name="uniqueId">A unique id of the card holder account which uniquely identifies the stored account. This value is not searchable..</param>
        public CardHolderAccount(string accountId = default(string), List<Card> cards = default(List<Card>), ContactDetails contact = default(ContactDetails), DateTime dateCreated = default(DateTime), string defaultCardId = default(string), int defaultCardIndex = default(int), DateTime lastModified = default(DateTime), string status = default(string), string uniqueId = default(string))
        {
            // to ensure "accountId" is required (not null)
            this.AccountId = accountId ?? throw new ArgumentNullException("accountId is a required property for CardHolderAccount and cannot be null");
            // to ensure "contact" is required (not null)
            this.Contact = contact ?? throw new ArgumentNullException("contact is a required property for CardHolderAccount and cannot be null");
            this.Cards = cards;
            this.DateCreated = dateCreated;
            this.DefaultCardId = defaultCardId;
            this.DefaultCardIndex = defaultCardIndex;
            this.LastModified = lastModified;
            this.Status = status;
            this.UniqueId = uniqueId;
        }

        /// <summary>
        /// The account id of the card holder account provided by the merchant which uniquely identifies the account. 
        /// </summary>
        /// <value>The account id of the card holder account provided by the merchant which uniquely identifies the account. </value>
        [DataMember(Name = "account_id", IsRequired = true, EmitDefaultValue = false)]
        public string AccountId { get; set; }

        /// <summary>
        /// Gets or Sets Cards
        /// </summary>
        [DataMember(Name = "cards", EmitDefaultValue = false)]
        public List<Card> Cards { get; set; }

        /// <summary>
        /// Gets or Sets Contact
        /// </summary>
        [DataMember(Name = "contact", IsRequired = true, EmitDefaultValue = false)]
        public ContactDetails Contact { get; set; }

        /// <summary>
        /// The date and time the account was created.
        /// </summary>
        /// <value>The date and time the account was created.</value>
        [DataMember(Name = "date_created", EmitDefaultValue = false)]
        public DateTime DateCreated { get; set; }

        /// <summary>
        /// The id of the default card.
        /// </summary>
        /// <value>The id of the default card.</value>
        [DataMember(Name = "default_card_id", EmitDefaultValue = false)]
        public string DefaultCardId { get; set; }

        /// <summary>
        /// The index in the array of the default card.
        /// </summary>
        /// <value>The index in the array of the default card.</value>
        [DataMember(Name = "default_card_index", EmitDefaultValue = false)]
        public int DefaultCardIndex { get; set; }

        /// <summary>
        /// The date and time the account was last modified.
        /// </summary>
        /// <value>The date and time the account was last modified.</value>
        [DataMember(Name = "last_modified", EmitDefaultValue = false)]
        public DateTime LastModified { get; set; }

        /// <summary>
        /// Defines the status of the account for processing valid values are   - ACTIVE for active accounts that are able to process   - DISABLED for accounts that are currently disabled for processing. 
        /// </summary>
        /// <value>Defines the status of the account for processing valid values are   - ACTIVE for active accounts that are able to process   - DISABLED for accounts that are currently disabled for processing. </value>
        [DataMember(Name = "status", EmitDefaultValue = false)]
        public string Status { get; set; }

        /// <summary>
        /// A unique id of the card holder account which uniquely identifies the stored account. This value is not searchable.
        /// </summary>
        /// <value>A unique id of the card holder account which uniquely identifies the stored account. This value is not searchable.</value>
        [DataMember(Name = "unique_id", EmitDefaultValue = false)]
        public string UniqueId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CardHolderAccount {\n");
            sb.Append("  AccountId: ").Append(AccountId).Append("\n");
            sb.Append("  Cards: ").Append(Cards).Append("\n");
            sb.Append("  Contact: ").Append(Contact).Append("\n");
            sb.Append("  DateCreated: ").Append(DateCreated).Append("\n");
            sb.Append("  DefaultCardId: ").Append(DefaultCardId).Append("\n");
            sb.Append("  DefaultCardIndex: ").Append(DefaultCardIndex).Append("\n");
            sb.Append("  LastModified: ").Append(LastModified).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  UniqueId: ").Append(UniqueId).Append("\n");
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
            return this.Equals(input as CardHolderAccount);
        }

        /// <summary>
        /// Returns true if CardHolderAccount instances are equal
        /// </summary>
        /// <param name="input">Instance of CardHolderAccount to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CardHolderAccount input)
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
                    this.Cards == input.Cards ||
                    this.Cards != null &&
                    input.Cards != null &&
                    this.Cards.SequenceEqual(input.Cards)
                ) && 
                (
                    this.Contact == input.Contact ||
                    (this.Contact != null &&
                    this.Contact.Equals(input.Contact))
                ) && 
                (
                    this.DateCreated == input.DateCreated ||
                    (this.DateCreated != null &&
                    this.DateCreated.Equals(input.DateCreated))
                ) && 
                (
                    this.DefaultCardId == input.DefaultCardId ||
                    (this.DefaultCardId != null &&
                    this.DefaultCardId.Equals(input.DefaultCardId))
                ) && 
                (
                    this.DefaultCardIndex == input.DefaultCardIndex ||
                    this.DefaultCardIndex.Equals(input.DefaultCardIndex)
                ) && 
                (
                    this.LastModified == input.LastModified ||
                    (this.LastModified != null &&
                    this.LastModified.Equals(input.LastModified))
                ) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
                ) && 
                (
                    this.UniqueId == input.UniqueId ||
                    (this.UniqueId != null &&
                    this.UniqueId.Equals(input.UniqueId))
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
                if (this.Cards != null)
                    hashCode = hashCode * 59 + this.Cards.GetHashCode();
                if (this.Contact != null)
                    hashCode = hashCode * 59 + this.Contact.GetHashCode();
                if (this.DateCreated != null)
                    hashCode = hashCode * 59 + this.DateCreated.GetHashCode();
                if (this.DefaultCardId != null)
                    hashCode = hashCode * 59 + this.DefaultCardId.GetHashCode();
                hashCode = hashCode * 59 + this.DefaultCardIndex.GetHashCode();
                if (this.LastModified != null)
                    hashCode = hashCode * 59 + this.LastModified.GetHashCode();
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.UniqueId != null)
                    hashCode = hashCode * 59 + this.UniqueId.GetHashCode();
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

            yield break;
        }
    }

}
