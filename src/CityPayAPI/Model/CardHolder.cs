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
    /// CardHolder
    /// </summary>
    [DataContract(Name = "CardHolder")]
    public partial class CardHolder : IEquatable<CardHolder>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CardHolder" /> class.
        /// </summary>
        /// <param name="acceptHeaders">The accept headers string generated by the Customer Browser. This field may be used to lock the payment process to the customer&#39;s browser. If the customer were to attempt to use a different browser an error will be generated..</param>
        /// <param name="address">address.</param>
        /// <param name="company">The company name for the card holder..</param>
        /// <param name="email">The cardholder&#39;s email address. This field can be used to send a receipt to the payment cardholder. If this value is not supplied, no email will be sent..</param>
        /// <param name="firstname">The first name of the card holder..</param>
        /// <param name="lastname">The last name or surname of the card holder..</param>
        /// <param name="mobileNo">The mobile number of the cardholder. This can be used for data collection via the Paylink Payment Form or to send an SMS on completion of a transaction. This feature is a licensable option and is not configured by default..</param>
        /// <param name="remoteAddr">Specifies the remote IP address of the customer&#39;s browser. This field may be used to lock the payment form to the customer&#39;s IP address. Should the address change or a malicious third party attempted to hijack the transaction, an error will be generated..</param>
        /// <param name="title">A title for the card holder such as Mr, Mrs, Ms, M. Mme. etc..</param>
        /// <param name="userAgent">Specifies the user agent string of the Customer Browser. This field may be used to lock the payment form to the browser. Should a different user agent attempt to process the transaction or a malicious third party attempted to hijack the transaction, an error is generated..</param>
        public CardHolder(string acceptHeaders = default(string), Address address = default(Address), string company = default(string), string email = default(string), string firstname = default(string), string lastname = default(string), string mobileNo = default(string), string remoteAddr = default(string), string title = default(string), string userAgent = default(string))
        {
            this.AcceptHeaders = acceptHeaders;
            this.Address = address;
            this.Company = company;
            this.Email = email;
            this.Firstname = firstname;
            this.Lastname = lastname;
            this.MobileNo = mobileNo;
            this.RemoteAddr = remoteAddr;
            this.Title = title;
            this.UserAgent = userAgent;
        }

        /// <summary>
        /// The accept headers string generated by the Customer Browser. This field may be used to lock the payment process to the customer&#39;s browser. If the customer were to attempt to use a different browser an error will be generated.
        /// </summary>
        /// <value>The accept headers string generated by the Customer Browser. This field may be used to lock the payment process to the customer&#39;s browser. If the customer were to attempt to use a different browser an error will be generated.</value>
        [DataMember(Name = "acceptHeaders", EmitDefaultValue = false)]
        public string AcceptHeaders { get; set; }

        /// <summary>
        /// Gets or Sets Address
        /// </summary>
        [DataMember(Name = "Address", EmitDefaultValue = false)]
        public Address Address { get; set; }

        /// <summary>
        /// The company name for the card holder.
        /// </summary>
        /// <value>The company name for the card holder.</value>
        [DataMember(Name = "company", EmitDefaultValue = false)]
        public string Company { get; set; }

        /// <summary>
        /// The cardholder&#39;s email address. This field can be used to send a receipt to the payment cardholder. If this value is not supplied, no email will be sent.
        /// </summary>
        /// <value>The cardholder&#39;s email address. This field can be used to send a receipt to the payment cardholder. If this value is not supplied, no email will be sent.</value>
        [DataMember(Name = "email", EmitDefaultValue = false)]
        public string Email { get; set; }

        /// <summary>
        /// The first name of the card holder.
        /// </summary>
        /// <value>The first name of the card holder.</value>
        [DataMember(Name = "firstname", EmitDefaultValue = false)]
        public string Firstname { get; set; }

        /// <summary>
        /// The last name or surname of the card holder.
        /// </summary>
        /// <value>The last name or surname of the card holder.</value>
        [DataMember(Name = "lastname", EmitDefaultValue = false)]
        public string Lastname { get; set; }

        /// <summary>
        /// The mobile number of the cardholder. This can be used for data collection via the Paylink Payment Form or to send an SMS on completion of a transaction. This feature is a licensable option and is not configured by default.
        /// </summary>
        /// <value>The mobile number of the cardholder. This can be used for data collection via the Paylink Payment Form or to send an SMS on completion of a transaction. This feature is a licensable option and is not configured by default.</value>
        [DataMember(Name = "mobile_no", EmitDefaultValue = false)]
        public string MobileNo { get; set; }

        /// <summary>
        /// Specifies the remote IP address of the customer&#39;s browser. This field may be used to lock the payment form to the customer&#39;s IP address. Should the address change or a malicious third party attempted to hijack the transaction, an error will be generated.
        /// </summary>
        /// <value>Specifies the remote IP address of the customer&#39;s browser. This field may be used to lock the payment form to the customer&#39;s IP address. Should the address change or a malicious third party attempted to hijack the transaction, an error will be generated.</value>
        [DataMember(Name = "remoteAddr", EmitDefaultValue = false)]
        public string RemoteAddr { get; set; }

        /// <summary>
        /// A title for the card holder such as Mr, Mrs, Ms, M. Mme. etc.
        /// </summary>
        /// <value>A title for the card holder such as Mr, Mrs, Ms, M. Mme. etc.</value>
        [DataMember(Name = "title", EmitDefaultValue = false)]
        public string Title { get; set; }

        /// <summary>
        /// Specifies the user agent string of the Customer Browser. This field may be used to lock the payment form to the browser. Should a different user agent attempt to process the transaction or a malicious third party attempted to hijack the transaction, an error is generated.
        /// </summary>
        /// <value>Specifies the user agent string of the Customer Browser. This field may be used to lock the payment form to the browser. Should a different user agent attempt to process the transaction or a malicious third party attempted to hijack the transaction, an error is generated.</value>
        [DataMember(Name = "userAgent", EmitDefaultValue = false)]
        public string UserAgent { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CardHolder {\n");
            sb.Append("  AcceptHeaders: ").Append(AcceptHeaders).Append("\n");
            sb.Append("  Address: ").Append(Address).Append("\n");
            sb.Append("  Company: ").Append(Company).Append("\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
            sb.Append("  Firstname: ").Append(Firstname).Append("\n");
            sb.Append("  Lastname: ").Append(Lastname).Append("\n");
            sb.Append("  MobileNo: ").Append(MobileNo).Append("\n");
            sb.Append("  RemoteAddr: ").Append(RemoteAddr).Append("\n");
            sb.Append("  Title: ").Append(Title).Append("\n");
            sb.Append("  UserAgent: ").Append(UserAgent).Append("\n");
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
            return this.Equals(input as CardHolder);
        }

        /// <summary>
        /// Returns true if CardHolder instances are equal
        /// </summary>
        /// <param name="input">Instance of CardHolder to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CardHolder input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AcceptHeaders == input.AcceptHeaders ||
                    (this.AcceptHeaders != null &&
                    this.AcceptHeaders.Equals(input.AcceptHeaders))
                ) && 
                (
                    this.Address == input.Address ||
                    (this.Address != null &&
                    this.Address.Equals(input.Address))
                ) && 
                (
                    this.Company == input.Company ||
                    (this.Company != null &&
                    this.Company.Equals(input.Company))
                ) && 
                (
                    this.Email == input.Email ||
                    (this.Email != null &&
                    this.Email.Equals(input.Email))
                ) && 
                (
                    this.Firstname == input.Firstname ||
                    (this.Firstname != null &&
                    this.Firstname.Equals(input.Firstname))
                ) && 
                (
                    this.Lastname == input.Lastname ||
                    (this.Lastname != null &&
                    this.Lastname.Equals(input.Lastname))
                ) && 
                (
                    this.MobileNo == input.MobileNo ||
                    (this.MobileNo != null &&
                    this.MobileNo.Equals(input.MobileNo))
                ) && 
                (
                    this.RemoteAddr == input.RemoteAddr ||
                    (this.RemoteAddr != null &&
                    this.RemoteAddr.Equals(input.RemoteAddr))
                ) && 
                (
                    this.Title == input.Title ||
                    (this.Title != null &&
                    this.Title.Equals(input.Title))
                ) && 
                (
                    this.UserAgent == input.UserAgent ||
                    (this.UserAgent != null &&
                    this.UserAgent.Equals(input.UserAgent))
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
                if (this.AcceptHeaders != null)
                    hashCode = hashCode * 59 + this.AcceptHeaders.GetHashCode();
                if (this.Address != null)
                    hashCode = hashCode * 59 + this.Address.GetHashCode();
                if (this.Company != null)
                    hashCode = hashCode * 59 + this.Company.GetHashCode();
                if (this.Email != null)
                    hashCode = hashCode * 59 + this.Email.GetHashCode();
                if (this.Firstname != null)
                    hashCode = hashCode * 59 + this.Firstname.GetHashCode();
                if (this.Lastname != null)
                    hashCode = hashCode * 59 + this.Lastname.GetHashCode();
                if (this.MobileNo != null)
                    hashCode = hashCode * 59 + this.MobileNo.GetHashCode();
                if (this.RemoteAddr != null)
                    hashCode = hashCode * 59 + this.RemoteAddr.GetHashCode();
                if (this.Title != null)
                    hashCode = hashCode * 59 + this.Title.GetHashCode();
                if (this.UserAgent != null)
                    hashCode = hashCode * 59 + this.UserAgent.GetHashCode();
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
            // Company (string) maxLength
            if(this.Company != null && this.Company.Length > 50)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Company, length must be less than 50.", new [] { "Company" });
            }

            // Email (string) maxLength
            if(this.Email != null && this.Email.Length > 254)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Email, length must be less than 254.", new [] { "Email" });
            }

            // MobileNo (string) maxLength
            if(this.MobileNo != null && this.MobileNo.Length > 20)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for MobileNo, length must be less than 20.", new [] { "MobileNo" });
            }

            yield break;
        }
    }

}
