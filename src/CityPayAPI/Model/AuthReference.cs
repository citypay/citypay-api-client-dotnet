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
    /// AuthReference
    /// </summary>
    [DataContract(Name = "AuthReference")]
    public partial class AuthReference : IEquatable<AuthReference>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AuthReference" /> class.
        /// </summary>
        /// <param name="amount">The amount of the transaction in decimal currency format..</param>
        /// <param name="amountValue">The amount of the transaction in integer/request format..</param>
        /// <param name="atrn">A reference number provided by the acquiring services..</param>
        /// <param name="authcode">The authorisation code of the transaction returned by the acquirer or card issuer..</param>
        /// <param name="batchno">A batch number which the transaction has been end of day batched towards..</param>
        /// <param name="currency">The currency of the transaction in ISO 4217 code format..</param>
        /// <param name="datetime">The date and time of the transaction..</param>
        /// <param name="identifier">The identifier of the transaction used to process the transaction..</param>
        /// <param name="maskedpan">A masking of the card number which was used to process the tranasction..</param>
        /// <param name="merchantid">The merchant id of the transaction result..</param>
        /// <param name="result">The result of the transaction..</param>
        /// <param name="transStatus">The current status of the transaction through it&#39;s lifecycle..</param>
        /// <param name="transType">The type of transaction that was processed..</param>
        /// <param name="transno">The transaction number of the transaction..</param>
        public AuthReference(string amount = default(string), int amountValue = default(int), string atrn = default(string), string authcode = default(string), string batchno = default(string), string currency = default(string), DateTime datetime = default(DateTime), string identifier = default(string), string maskedpan = default(string), int merchantid = default(int), string result = default(string), string transStatus = default(string), string transType = default(string), int transno = default(int))
        {
            this.Amount = amount;
            this.AmountValue = amountValue;
            this.Atrn = atrn;
            this.Authcode = authcode;
            this.Batchno = batchno;
            this.Currency = currency;
            this.Datetime = datetime;
            this.Identifier = identifier;
            this.Maskedpan = maskedpan;
            this.Merchantid = merchantid;
            this.Result = result;
            this.TransStatus = transStatus;
            this.TransType = transType;
            this.Transno = transno;
        }

        /// <summary>
        /// The amount of the transaction in decimal currency format.
        /// </summary>
        /// <value>The amount of the transaction in decimal currency format.</value>
        [DataMember(Name = "amount", EmitDefaultValue = false)]
        public string Amount { get; set; }

        /// <summary>
        /// The amount of the transaction in integer/request format.
        /// </summary>
        /// <value>The amount of the transaction in integer/request format.</value>
        [DataMember(Name = "amount_value", EmitDefaultValue = false)]
        public int AmountValue { get; set; }

        /// <summary>
        /// A reference number provided by the acquiring services.
        /// </summary>
        /// <value>A reference number provided by the acquiring services.</value>
        [DataMember(Name = "atrn", EmitDefaultValue = false)]
        public string Atrn { get; set; }

        /// <summary>
        /// The authorisation code of the transaction returned by the acquirer or card issuer.
        /// </summary>
        /// <value>The authorisation code of the transaction returned by the acquirer or card issuer.</value>
        [DataMember(Name = "authcode", EmitDefaultValue = false)]
        public string Authcode { get; set; }

        /// <summary>
        /// A batch number which the transaction has been end of day batched towards.
        /// </summary>
        /// <value>A batch number which the transaction has been end of day batched towards.</value>
        [DataMember(Name = "batchno", EmitDefaultValue = false)]
        public string Batchno { get; set; }

        /// <summary>
        /// The currency of the transaction in ISO 4217 code format.
        /// </summary>
        /// <value>The currency of the transaction in ISO 4217 code format.</value>
        [DataMember(Name = "currency", EmitDefaultValue = false)]
        public string Currency { get; set; }

        /// <summary>
        /// The date and time of the transaction.
        /// </summary>
        /// <value>The date and time of the transaction.</value>
        [DataMember(Name = "datetime", EmitDefaultValue = false)]
        public DateTime Datetime { get; set; }

        /// <summary>
        /// The identifier of the transaction used to process the transaction.
        /// </summary>
        /// <value>The identifier of the transaction used to process the transaction.</value>
        [DataMember(Name = "identifier", EmitDefaultValue = false)]
        public string Identifier { get; set; }

        /// <summary>
        /// A masking of the card number which was used to process the tranasction.
        /// </summary>
        /// <value>A masking of the card number which was used to process the tranasction.</value>
        [DataMember(Name = "maskedpan", EmitDefaultValue = false)]
        public string Maskedpan { get; set; }

        /// <summary>
        /// The merchant id of the transaction result.
        /// </summary>
        /// <value>The merchant id of the transaction result.</value>
        [DataMember(Name = "merchantid", EmitDefaultValue = false)]
        public int Merchantid { get; set; }

        /// <summary>
        /// The result of the transaction.
        /// </summary>
        /// <value>The result of the transaction.</value>
        [DataMember(Name = "result", EmitDefaultValue = false)]
        public string Result { get; set; }

        /// <summary>
        /// The current status of the transaction through it&#39;s lifecycle.
        /// </summary>
        /// <value>The current status of the transaction through it&#39;s lifecycle.</value>
        [DataMember(Name = "trans_status", EmitDefaultValue = false)]
        public string TransStatus { get; set; }

        /// <summary>
        /// The type of transaction that was processed.
        /// </summary>
        /// <value>The type of transaction that was processed.</value>
        [DataMember(Name = "trans_type", EmitDefaultValue = false)]
        public string TransType { get; set; }

        /// <summary>
        /// The transaction number of the transaction.
        /// </summary>
        /// <value>The transaction number of the transaction.</value>
        [DataMember(Name = "transno", EmitDefaultValue = false)]
        public int Transno { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AuthReference {\n");
            sb.Append("  Amount: ").Append(Amount).Append("\n");
            sb.Append("  AmountValue: ").Append(AmountValue).Append("\n");
            sb.Append("  Atrn: ").Append(Atrn).Append("\n");
            sb.Append("  Authcode: ").Append(Authcode).Append("\n");
            sb.Append("  Batchno: ").Append(Batchno).Append("\n");
            sb.Append("  Currency: ").Append(Currency).Append("\n");
            sb.Append("  Datetime: ").Append(Datetime).Append("\n");
            sb.Append("  Identifier: ").Append(Identifier).Append("\n");
            sb.Append("  Maskedpan: ").Append(Maskedpan).Append("\n");
            sb.Append("  Merchantid: ").Append(Merchantid).Append("\n");
            sb.Append("  Result: ").Append(Result).Append("\n");
            sb.Append("  TransStatus: ").Append(TransStatus).Append("\n");
            sb.Append("  TransType: ").Append(TransType).Append("\n");
            sb.Append("  Transno: ").Append(Transno).Append("\n");
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
            return this.Equals(input as AuthReference);
        }

        /// <summary>
        /// Returns true if AuthReference instances are equal
        /// </summary>
        /// <param name="input">Instance of AuthReference to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AuthReference input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Amount == input.Amount ||
                    (this.Amount != null &&
                    this.Amount.Equals(input.Amount))
                ) && 
                (
                    this.AmountValue == input.AmountValue ||
                    this.AmountValue.Equals(input.AmountValue)
                ) && 
                (
                    this.Atrn == input.Atrn ||
                    (this.Atrn != null &&
                    this.Atrn.Equals(input.Atrn))
                ) && 
                (
                    this.Authcode == input.Authcode ||
                    (this.Authcode != null &&
                    this.Authcode.Equals(input.Authcode))
                ) && 
                (
                    this.Batchno == input.Batchno ||
                    (this.Batchno != null &&
                    this.Batchno.Equals(input.Batchno))
                ) && 
                (
                    this.Currency == input.Currency ||
                    (this.Currency != null &&
                    this.Currency.Equals(input.Currency))
                ) && 
                (
                    this.Datetime == input.Datetime ||
                    (this.Datetime != null &&
                    this.Datetime.Equals(input.Datetime))
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
                    this.Result == input.Result ||
                    (this.Result != null &&
                    this.Result.Equals(input.Result))
                ) && 
                (
                    this.TransStatus == input.TransStatus ||
                    (this.TransStatus != null &&
                    this.TransStatus.Equals(input.TransStatus))
                ) && 
                (
                    this.TransType == input.TransType ||
                    (this.TransType != null &&
                    this.TransType.Equals(input.TransType))
                ) && 
                (
                    this.Transno == input.Transno ||
                    this.Transno.Equals(input.Transno)
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
                if (this.Amount != null)
                    hashCode = hashCode * 59 + this.Amount.GetHashCode();
                hashCode = hashCode * 59 + this.AmountValue.GetHashCode();
                if (this.Atrn != null)
                    hashCode = hashCode * 59 + this.Atrn.GetHashCode();
                if (this.Authcode != null)
                    hashCode = hashCode * 59 + this.Authcode.GetHashCode();
                if (this.Batchno != null)
                    hashCode = hashCode * 59 + this.Batchno.GetHashCode();
                if (this.Currency != null)
                    hashCode = hashCode * 59 + this.Currency.GetHashCode();
                if (this.Datetime != null)
                    hashCode = hashCode * 59 + this.Datetime.GetHashCode();
                if (this.Identifier != null)
                    hashCode = hashCode * 59 + this.Identifier.GetHashCode();
                if (this.Maskedpan != null)
                    hashCode = hashCode * 59 + this.Maskedpan.GetHashCode();
                hashCode = hashCode * 59 + this.Merchantid.GetHashCode();
                if (this.Result != null)
                    hashCode = hashCode * 59 + this.Result.GetHashCode();
                if (this.TransStatus != null)
                    hashCode = hashCode * 59 + this.TransStatus.GetHashCode();
                if (this.TransType != null)
                    hashCode = hashCode * 59 + this.TransType.GetHashCode();
                hashCode = hashCode * 59 + this.Transno.GetHashCode();
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
            // Amount (string) maxLength
            if(this.Amount != null && this.Amount.Length > 10)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Amount, length must be less than 10.", new [] { "Amount" });
            }

            // Currency (string) maxLength
            if(this.Currency != null && this.Currency.Length > 3)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Currency, length must be less than 3.", new [] { "Currency" });
            }

            // Currency (string) minLength
            if(this.Currency != null && this.Currency.Length < 3)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Currency, length must be greater than 3.", new [] { "Currency" });
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

            // TransType (string) maxLength
            if(this.TransType != null && this.TransType.Length > 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for TransType, length must be less than 1.", new [] { "TransType" });
            }

            yield break;
        }
    }

}
