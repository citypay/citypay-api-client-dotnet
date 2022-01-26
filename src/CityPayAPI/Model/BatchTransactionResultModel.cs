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
    /// BatchTransactionResultModel
    /// </summary>
    [DataContract(Name = "BatchTransactionResultModel")]
    public partial class BatchTransactionResultModel : IEquatable<BatchTransactionResultModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BatchTransactionResultModel" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected BatchTransactionResultModel() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="BatchTransactionResultModel" /> class.
        /// </summary>
        /// <param name="accountId">The card holder account id used for the transaction. (required).</param>
        /// <param name="amount">The amount of the transaction processed..</param>
        /// <param name="authcode">The authorisation code of a successful transaction..</param>
        /// <param name="identifier">The identifier of the transaction. (required).</param>
        /// <param name="maskedpan">A masked value of the card number used for processing displaying limited values that can be used on a receipt. .</param>
        /// <param name="merchantid">The merchant id of the transaction. (required).</param>
        /// <param name="message">A response message pertaining to the transaction. (required).</param>
        /// <param name="result">An integer result that indicates the outcome of the transaction. The Code value below maps to the result value  &lt;table&gt; &lt;tr&gt; &lt;th&gt;Code&lt;/th&gt; &lt;th&gt;Abbrev&lt;/th&gt; &lt;th&gt;Description&lt;/th&gt; &lt;/tr&gt; &lt;tr&gt;&lt;td&gt;0&lt;/td&gt;&lt;td&gt;Declined&lt;/td&gt;&lt;td&gt;Declined&lt;/td&gt;&lt;/tr&gt; &lt;tr&gt;&lt;td&gt;1&lt;/td&gt;&lt;td&gt;Accepted&lt;/td&gt;&lt;td&gt;Accepted&lt;/td&gt;&lt;/tr&gt; &lt;tr&gt;&lt;td&gt;2&lt;/td&gt;&lt;td&gt;Rejected&lt;/td&gt;&lt;td&gt;Rejected&lt;/td&gt;&lt;/tr&gt; &lt;tr&gt;&lt;td&gt;3&lt;/td&gt;&lt;td&gt;Not Attempted&lt;/td&gt;&lt;td&gt;Not Attempted&lt;/td&gt;&lt;/tr&gt; &lt;tr&gt;&lt;td&gt;4&lt;/td&gt;&lt;td&gt;Referred&lt;/td&gt;&lt;td&gt;Referred&lt;/td&gt;&lt;/tr&gt; &lt;tr&gt;&lt;td&gt;5&lt;/td&gt;&lt;td&gt;PinRetry&lt;/td&gt;&lt;td&gt;Perform PIN Retry&lt;/td&gt;&lt;/tr&gt; &lt;tr&gt;&lt;td&gt;6&lt;/td&gt;&lt;td&gt;ForSigVer&lt;/td&gt;&lt;td&gt;Force Signature Verification&lt;/td&gt;&lt;/tr&gt; &lt;tr&gt;&lt;td&gt;7&lt;/td&gt;&lt;td&gt;Hold&lt;/td&gt;&lt;td&gt;Hold&lt;/td&gt;&lt;/tr&gt; &lt;tr&gt;&lt;td&gt;8&lt;/td&gt;&lt;td&gt;SecErr&lt;/td&gt;&lt;td&gt;Security Error&lt;/td&gt;&lt;/tr&gt; &lt;tr&gt;&lt;td&gt;9&lt;/td&gt;&lt;td&gt;CallAcq&lt;/td&gt;&lt;td&gt;Call Acquirer&lt;/td&gt;&lt;/tr&gt; &lt;tr&gt;&lt;td&gt;10&lt;/td&gt;&lt;td&gt;DNH&lt;/td&gt;&lt;td&gt;Do Not Honour&lt;/td&gt;&lt;/tr&gt; &lt;tr&gt;&lt;td&gt;11&lt;/td&gt;&lt;td&gt;RtnCrd&lt;/td&gt;&lt;td&gt;Retain Card&lt;/td&gt;&lt;/tr&gt; &lt;tr&gt;&lt;td&gt;12&lt;/td&gt;&lt;td&gt;ExprdCrd&lt;/td&gt;&lt;td&gt;Expired Card&lt;/td&gt;&lt;/tr&gt; &lt;tr&gt;&lt;td&gt;13&lt;/td&gt;&lt;td&gt;InvldCrd&lt;/td&gt;&lt;td&gt;Invalid Card No&lt;/td&gt;&lt;/tr&gt; &lt;tr&gt;&lt;td&gt;14&lt;/td&gt;&lt;td&gt;PinExcd&lt;/td&gt;&lt;td&gt;Pin Tries Exceeded&lt;/td&gt;&lt;/tr&gt; &lt;tr&gt;&lt;td&gt;15&lt;/td&gt;&lt;td&gt;PinInvld&lt;/td&gt;&lt;td&gt;Pin Invalid&lt;/td&gt;&lt;/tr&gt; &lt;tr&gt;&lt;td&gt;16&lt;/td&gt;&lt;td&gt;AuthReq&lt;/td&gt;&lt;td&gt;Authentication Required&lt;/td&gt;&lt;/tr&gt; &lt;tr&gt;&lt;td&gt;17&lt;/td&gt;&lt;td&gt;AuthenFail&lt;/td&gt;&lt;td&gt;Authentication Failed&lt;/td&gt;&lt;/tr&gt; &lt;tr&gt;&lt;td&gt;18&lt;/td&gt;&lt;td&gt;Verified&lt;/td&gt;&lt;td&gt;Card Verified&lt;/td&gt;&lt;/tr&gt; &lt;tr&gt;&lt;td&gt;19&lt;/td&gt;&lt;td&gt;Cancelled&lt;/td&gt;&lt;td&gt;Cancelled&lt;/td&gt;&lt;/tr&gt; &lt;tr&gt;&lt;td&gt;20&lt;/td&gt;&lt;td&gt;Un&lt;/td&gt;&lt;td&gt;Unknown&lt;/td&gt;&lt;/tr&gt; &lt;/table&gt;  (required).</param>
        /// <param name="scheme">A name of the card scheme of the transaction that processed the transaction such as Visa or MasterCard. .</param>
        public BatchTransactionResultModel(string accountId = default(string), int amount = default(int), string authcode = default(string), string identifier = default(string), string maskedpan = default(string), int merchantid = default(int), string message = default(string), int result = default(int), string scheme = default(string))
        {
            // to ensure "accountId" is required (not null)
            this.AccountId = accountId ?? throw new ArgumentNullException("accountId is a required property for BatchTransactionResultModel and cannot be null");
            // to ensure "identifier" is required (not null)
            this.Identifier = identifier ?? throw new ArgumentNullException("identifier is a required property for BatchTransactionResultModel and cannot be null");
            this.Merchantid = merchantid;
            // to ensure "message" is required (not null)
            this.Message = message ?? throw new ArgumentNullException("message is a required property for BatchTransactionResultModel and cannot be null");
            this.Result = result;
            this.Amount = amount;
            this.Authcode = authcode;
            this.Maskedpan = maskedpan;
            this.Scheme = scheme;
        }

        /// <summary>
        /// The card holder account id used for the transaction.
        /// </summary>
        /// <value>The card holder account id used for the transaction.</value>
        [DataMember(Name = "account_id", IsRequired = true, EmitDefaultValue = false)]
        public string AccountId { get; set; }

        /// <summary>
        /// The amount of the transaction processed.
        /// </summary>
        /// <value>The amount of the transaction processed.</value>
        [DataMember(Name = "amount", EmitDefaultValue = false)]
        public int Amount { get; set; }

        /// <summary>
        /// The authorisation code of a successful transaction.
        /// </summary>
        /// <value>The authorisation code of a successful transaction.</value>
        [DataMember(Name = "authcode", EmitDefaultValue = false)]
        public string Authcode { get; set; }

        /// <summary>
        /// The identifier of the transaction.
        /// </summary>
        /// <value>The identifier of the transaction.</value>
        [DataMember(Name = "identifier", IsRequired = true, EmitDefaultValue = false)]
        public string Identifier { get; set; }

        /// <summary>
        /// A masked value of the card number used for processing displaying limited values that can be used on a receipt. 
        /// </summary>
        /// <value>A masked value of the card number used for processing displaying limited values that can be used on a receipt. </value>
        [DataMember(Name = "maskedpan", EmitDefaultValue = false)]
        public string Maskedpan { get; set; }

        /// <summary>
        /// The merchant id of the transaction.
        /// </summary>
        /// <value>The merchant id of the transaction.</value>
        [DataMember(Name = "merchantid", IsRequired = true, EmitDefaultValue = false)]
        public int Merchantid { get; set; }

        /// <summary>
        /// A response message pertaining to the transaction.
        /// </summary>
        /// <value>A response message pertaining to the transaction.</value>
        [DataMember(Name = "message", IsRequired = true, EmitDefaultValue = false)]
        public string Message { get; set; }

        /// <summary>
        /// An integer result that indicates the outcome of the transaction. The Code value below maps to the result value  &lt;table&gt; &lt;tr&gt; &lt;th&gt;Code&lt;/th&gt; &lt;th&gt;Abbrev&lt;/th&gt; &lt;th&gt;Description&lt;/th&gt; &lt;/tr&gt; &lt;tr&gt;&lt;td&gt;0&lt;/td&gt;&lt;td&gt;Declined&lt;/td&gt;&lt;td&gt;Declined&lt;/td&gt;&lt;/tr&gt; &lt;tr&gt;&lt;td&gt;1&lt;/td&gt;&lt;td&gt;Accepted&lt;/td&gt;&lt;td&gt;Accepted&lt;/td&gt;&lt;/tr&gt; &lt;tr&gt;&lt;td&gt;2&lt;/td&gt;&lt;td&gt;Rejected&lt;/td&gt;&lt;td&gt;Rejected&lt;/td&gt;&lt;/tr&gt; &lt;tr&gt;&lt;td&gt;3&lt;/td&gt;&lt;td&gt;Not Attempted&lt;/td&gt;&lt;td&gt;Not Attempted&lt;/td&gt;&lt;/tr&gt; &lt;tr&gt;&lt;td&gt;4&lt;/td&gt;&lt;td&gt;Referred&lt;/td&gt;&lt;td&gt;Referred&lt;/td&gt;&lt;/tr&gt; &lt;tr&gt;&lt;td&gt;5&lt;/td&gt;&lt;td&gt;PinRetry&lt;/td&gt;&lt;td&gt;Perform PIN Retry&lt;/td&gt;&lt;/tr&gt; &lt;tr&gt;&lt;td&gt;6&lt;/td&gt;&lt;td&gt;ForSigVer&lt;/td&gt;&lt;td&gt;Force Signature Verification&lt;/td&gt;&lt;/tr&gt; &lt;tr&gt;&lt;td&gt;7&lt;/td&gt;&lt;td&gt;Hold&lt;/td&gt;&lt;td&gt;Hold&lt;/td&gt;&lt;/tr&gt; &lt;tr&gt;&lt;td&gt;8&lt;/td&gt;&lt;td&gt;SecErr&lt;/td&gt;&lt;td&gt;Security Error&lt;/td&gt;&lt;/tr&gt; &lt;tr&gt;&lt;td&gt;9&lt;/td&gt;&lt;td&gt;CallAcq&lt;/td&gt;&lt;td&gt;Call Acquirer&lt;/td&gt;&lt;/tr&gt; &lt;tr&gt;&lt;td&gt;10&lt;/td&gt;&lt;td&gt;DNH&lt;/td&gt;&lt;td&gt;Do Not Honour&lt;/td&gt;&lt;/tr&gt; &lt;tr&gt;&lt;td&gt;11&lt;/td&gt;&lt;td&gt;RtnCrd&lt;/td&gt;&lt;td&gt;Retain Card&lt;/td&gt;&lt;/tr&gt; &lt;tr&gt;&lt;td&gt;12&lt;/td&gt;&lt;td&gt;ExprdCrd&lt;/td&gt;&lt;td&gt;Expired Card&lt;/td&gt;&lt;/tr&gt; &lt;tr&gt;&lt;td&gt;13&lt;/td&gt;&lt;td&gt;InvldCrd&lt;/td&gt;&lt;td&gt;Invalid Card No&lt;/td&gt;&lt;/tr&gt; &lt;tr&gt;&lt;td&gt;14&lt;/td&gt;&lt;td&gt;PinExcd&lt;/td&gt;&lt;td&gt;Pin Tries Exceeded&lt;/td&gt;&lt;/tr&gt; &lt;tr&gt;&lt;td&gt;15&lt;/td&gt;&lt;td&gt;PinInvld&lt;/td&gt;&lt;td&gt;Pin Invalid&lt;/td&gt;&lt;/tr&gt; &lt;tr&gt;&lt;td&gt;16&lt;/td&gt;&lt;td&gt;AuthReq&lt;/td&gt;&lt;td&gt;Authentication Required&lt;/td&gt;&lt;/tr&gt; &lt;tr&gt;&lt;td&gt;17&lt;/td&gt;&lt;td&gt;AuthenFail&lt;/td&gt;&lt;td&gt;Authentication Failed&lt;/td&gt;&lt;/tr&gt; &lt;tr&gt;&lt;td&gt;18&lt;/td&gt;&lt;td&gt;Verified&lt;/td&gt;&lt;td&gt;Card Verified&lt;/td&gt;&lt;/tr&gt; &lt;tr&gt;&lt;td&gt;19&lt;/td&gt;&lt;td&gt;Cancelled&lt;/td&gt;&lt;td&gt;Cancelled&lt;/td&gt;&lt;/tr&gt; &lt;tr&gt;&lt;td&gt;20&lt;/td&gt;&lt;td&gt;Un&lt;/td&gt;&lt;td&gt;Unknown&lt;/td&gt;&lt;/tr&gt; &lt;/table&gt; 
        /// </summary>
        /// <value>An integer result that indicates the outcome of the transaction. The Code value below maps to the result value  &lt;table&gt; &lt;tr&gt; &lt;th&gt;Code&lt;/th&gt; &lt;th&gt;Abbrev&lt;/th&gt; &lt;th&gt;Description&lt;/th&gt; &lt;/tr&gt; &lt;tr&gt;&lt;td&gt;0&lt;/td&gt;&lt;td&gt;Declined&lt;/td&gt;&lt;td&gt;Declined&lt;/td&gt;&lt;/tr&gt; &lt;tr&gt;&lt;td&gt;1&lt;/td&gt;&lt;td&gt;Accepted&lt;/td&gt;&lt;td&gt;Accepted&lt;/td&gt;&lt;/tr&gt; &lt;tr&gt;&lt;td&gt;2&lt;/td&gt;&lt;td&gt;Rejected&lt;/td&gt;&lt;td&gt;Rejected&lt;/td&gt;&lt;/tr&gt; &lt;tr&gt;&lt;td&gt;3&lt;/td&gt;&lt;td&gt;Not Attempted&lt;/td&gt;&lt;td&gt;Not Attempted&lt;/td&gt;&lt;/tr&gt; &lt;tr&gt;&lt;td&gt;4&lt;/td&gt;&lt;td&gt;Referred&lt;/td&gt;&lt;td&gt;Referred&lt;/td&gt;&lt;/tr&gt; &lt;tr&gt;&lt;td&gt;5&lt;/td&gt;&lt;td&gt;PinRetry&lt;/td&gt;&lt;td&gt;Perform PIN Retry&lt;/td&gt;&lt;/tr&gt; &lt;tr&gt;&lt;td&gt;6&lt;/td&gt;&lt;td&gt;ForSigVer&lt;/td&gt;&lt;td&gt;Force Signature Verification&lt;/td&gt;&lt;/tr&gt; &lt;tr&gt;&lt;td&gt;7&lt;/td&gt;&lt;td&gt;Hold&lt;/td&gt;&lt;td&gt;Hold&lt;/td&gt;&lt;/tr&gt; &lt;tr&gt;&lt;td&gt;8&lt;/td&gt;&lt;td&gt;SecErr&lt;/td&gt;&lt;td&gt;Security Error&lt;/td&gt;&lt;/tr&gt; &lt;tr&gt;&lt;td&gt;9&lt;/td&gt;&lt;td&gt;CallAcq&lt;/td&gt;&lt;td&gt;Call Acquirer&lt;/td&gt;&lt;/tr&gt; &lt;tr&gt;&lt;td&gt;10&lt;/td&gt;&lt;td&gt;DNH&lt;/td&gt;&lt;td&gt;Do Not Honour&lt;/td&gt;&lt;/tr&gt; &lt;tr&gt;&lt;td&gt;11&lt;/td&gt;&lt;td&gt;RtnCrd&lt;/td&gt;&lt;td&gt;Retain Card&lt;/td&gt;&lt;/tr&gt; &lt;tr&gt;&lt;td&gt;12&lt;/td&gt;&lt;td&gt;ExprdCrd&lt;/td&gt;&lt;td&gt;Expired Card&lt;/td&gt;&lt;/tr&gt; &lt;tr&gt;&lt;td&gt;13&lt;/td&gt;&lt;td&gt;InvldCrd&lt;/td&gt;&lt;td&gt;Invalid Card No&lt;/td&gt;&lt;/tr&gt; &lt;tr&gt;&lt;td&gt;14&lt;/td&gt;&lt;td&gt;PinExcd&lt;/td&gt;&lt;td&gt;Pin Tries Exceeded&lt;/td&gt;&lt;/tr&gt; &lt;tr&gt;&lt;td&gt;15&lt;/td&gt;&lt;td&gt;PinInvld&lt;/td&gt;&lt;td&gt;Pin Invalid&lt;/td&gt;&lt;/tr&gt; &lt;tr&gt;&lt;td&gt;16&lt;/td&gt;&lt;td&gt;AuthReq&lt;/td&gt;&lt;td&gt;Authentication Required&lt;/td&gt;&lt;/tr&gt; &lt;tr&gt;&lt;td&gt;17&lt;/td&gt;&lt;td&gt;AuthenFail&lt;/td&gt;&lt;td&gt;Authentication Failed&lt;/td&gt;&lt;/tr&gt; &lt;tr&gt;&lt;td&gt;18&lt;/td&gt;&lt;td&gt;Verified&lt;/td&gt;&lt;td&gt;Card Verified&lt;/td&gt;&lt;/tr&gt; &lt;tr&gt;&lt;td&gt;19&lt;/td&gt;&lt;td&gt;Cancelled&lt;/td&gt;&lt;td&gt;Cancelled&lt;/td&gt;&lt;/tr&gt; &lt;tr&gt;&lt;td&gt;20&lt;/td&gt;&lt;td&gt;Un&lt;/td&gt;&lt;td&gt;Unknown&lt;/td&gt;&lt;/tr&gt; &lt;/table&gt; </value>
        [DataMember(Name = "result", IsRequired = true, EmitDefaultValue = false)]
        public int Result { get; set; }

        /// <summary>
        /// A name of the card scheme of the transaction that processed the transaction such as Visa or MasterCard. 
        /// </summary>
        /// <value>A name of the card scheme of the transaction that processed the transaction such as Visa or MasterCard. </value>
        [DataMember(Name = "scheme", EmitDefaultValue = false)]
        public string Scheme { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BatchTransactionResultModel {\n");
            sb.Append("  AccountId: ").Append(AccountId).Append("\n");
            sb.Append("  Amount: ").Append(Amount).Append("\n");
            sb.Append("  Authcode: ").Append(Authcode).Append("\n");
            sb.Append("  Identifier: ").Append(Identifier).Append("\n");
            sb.Append("  Maskedpan: ").Append(Maskedpan).Append("\n");
            sb.Append("  Merchantid: ").Append(Merchantid).Append("\n");
            sb.Append("  Message: ").Append(Message).Append("\n");
            sb.Append("  Result: ").Append(Result).Append("\n");
            sb.Append("  Scheme: ").Append(Scheme).Append("\n");
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
            return this.Equals(input as BatchTransactionResultModel);
        }

        /// <summary>
        /// Returns true if BatchTransactionResultModel instances are equal
        /// </summary>
        /// <param name="input">Instance of BatchTransactionResultModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BatchTransactionResultModel input)
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
                    this.Authcode == input.Authcode ||
                    (this.Authcode != null &&
                    this.Authcode.Equals(input.Authcode))
                ) && 
                (
                    this.Identifier == input.Identifier ||
                    (this.Identifier != null &&
                    this.Identifier.Equals(input.Identifier))
                ) && 
                (
                    this.Maskedpan == input.Maskedpan ||
                    (this.Maskedpan != null &&
                    this.Maskedpan.Equals(input.Maskedpan))
                ) && 
                (
                    this.Merchantid == input.Merchantid ||
                    this.Merchantid.Equals(input.Merchantid)
                ) && 
                (
                    this.Message == input.Message ||
                    (this.Message != null &&
                    this.Message.Equals(input.Message))
                ) && 
                (
                    this.Result == input.Result ||
                    this.Result.Equals(input.Result)
                ) && 
                (
                    this.Scheme == input.Scheme ||
                    (this.Scheme != null &&
                    this.Scheme.Equals(input.Scheme))
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
                if (this.Authcode != null)
                    hashCode = hashCode * 59 + this.Authcode.GetHashCode();
                if (this.Identifier != null)
                    hashCode = hashCode * 59 + this.Identifier.GetHashCode();
                if (this.Maskedpan != null)
                    hashCode = hashCode * 59 + this.Maskedpan.GetHashCode();
                hashCode = hashCode * 59 + this.Merchantid.GetHashCode();
                if (this.Message != null)
                    hashCode = hashCode * 59 + this.Message.GetHashCode();
                hashCode = hashCode * 59 + this.Result.GetHashCode();
                if (this.Scheme != null)
                    hashCode = hashCode * 59 + this.Scheme.GetHashCode();
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
