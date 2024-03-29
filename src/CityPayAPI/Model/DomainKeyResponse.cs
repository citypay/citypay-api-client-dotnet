/*
 * CityPay Payment API
 *
 *  This CityPay API is an HTTP RESTful payment API used for direct server to server transactional processing. It provides a number of payment mechanisms including: Internet, MOTO, Continuous Authority transaction processing, 3-D Secure decision handling using RFA Secure, Authorisation, Refunding, Pre-Authorisation, Cancellation/Voids and Completion processing. The API is also capable of tokenized payments using cardholder Accounts.  ## Compliance and Security Your application will need to adhere to PCI-DSS standards to operate safely and to meet requirements set out by  Visa and MasterCard and the PCI Security Standards Council. These include  * Data must be collected using TLS version 1.2 using [strong cryptography](https://citypay.github.io/api-docs/payment-api/#enabled-tls-ciphers). We will not accept calls to our API at   lower grade encryption levels. We regularly scan our TLS endpoints for vulnerabilities and perform TLS assessments   as part of our compliance program. * The application must not store sensitive cardholder data (CHD) such as the card security code (CSC) or   primary access number (PAN) * The application must not display the full card number on receipts, it is recommended to mask the PAN   and show the last 4 digits. The API will return this for you for ease of receipt creation * If you are developing a website, you will be required to perform regular scans on the network where you host the   application to meet your compliance obligations * You will be required to be PCI Compliant and the application must adhere to the security standard. Further information   is available from [https://www.pcisecuritystandards.org/](https://www.pcisecuritystandards.org/) * The API verifies that the request is for a valid account and originates from a trusted source using the remote IP   address. Our application firewalls analyse data that may be an attempt to break a large number of security common   security vulnerabilities. 
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
    /// DomainKeyResponse
    /// </summary>
    [DataContract(Name = "DomainKeyResponse")]
    public partial class DomainKeyResponse : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DomainKeyResponse" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected DomainKeyResponse() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="DomainKeyResponse" /> class.
        /// </summary>
        /// <param name="dateCreated">The date the domain key was generated. .</param>
        /// <param name="domain">domain (required).</param>
        /// <param name="domainKey">The domain key generated. .</param>
        /// <param name="live">true if this key is a production key. .</param>
        /// <param name="merchantid">The merchant id the domain key is to be used for.  (required).</param>
        public DomainKeyResponse(DateTime dateCreated = default(DateTime), List<string> domain = default(List<string>), string domainKey = default(string), bool live = default(bool), int merchantid = default(int))
        {
            // to ensure "domain" is required (not null)
            if (domain == null)
            {
                throw new ArgumentNullException("domain is a required property for DomainKeyResponse and cannot be null");
            }
            this.Domain = domain;
            this.Merchantid = merchantid;
            this.DateCreated = dateCreated;
            this.DomainKey = domainKey;
            this.Live = live;
        }

        /// <summary>
        /// The date the domain key was generated. 
        /// </summary>
        /// <value>The date the domain key was generated. </value>
        /// <example>2020-01-02T18:32:28Z</example>
        [DataMember(Name = "date_created", EmitDefaultValue = false)]
        public DateTime DateCreated { get; set; }

        /// <summary>
        /// Gets or Sets Domain
        /// </summary>
        [DataMember(Name = "domain", IsRequired = true, EmitDefaultValue = true)]
        public List<string> Domain { get; set; }

        /// <summary>
        /// The domain key generated. 
        /// </summary>
        /// <value>The domain key generated. </value>
        /// <example>3MEcU8cEf...QMeebACxcQVejmT1Wi</example>
        [DataMember(Name = "domain_key", EmitDefaultValue = false)]
        public string DomainKey { get; set; }

        /// <summary>
        /// true if this key is a production key. 
        /// </summary>
        /// <value>true if this key is a production key. </value>
        /// <example>true</example>
        [DataMember(Name = "live", EmitDefaultValue = true)]
        public bool Live { get; set; }

        /// <summary>
        /// The merchant id the domain key is to be used for. 
        /// </summary>
        /// <value>The merchant id the domain key is to be used for. </value>
        /// <example>11223344</example>
        [DataMember(Name = "merchantid", IsRequired = true, EmitDefaultValue = true)]
        public int Merchantid { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class DomainKeyResponse {\n");
            sb.Append("  DateCreated: ").Append(DateCreated).Append("\n");
            sb.Append("  Domain: ").Append(Domain).Append("\n");
            sb.Append("  DomainKey: ").Append(DomainKey).Append("\n");
            sb.Append("  Live: ").Append(Live).Append("\n");
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
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            // DomainKey (string) maxLength
            if (this.DomainKey != null && this.DomainKey.Length > 512)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for DomainKey, length must be less than 512.", new [] { "DomainKey" });
            }

            // DomainKey (string) minLength
            if (this.DomainKey != null && this.DomainKey.Length < 64)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for DomainKey, length must be greater than 64.", new [] { "DomainKey" });
            }

            yield break;
        }
    }

}
