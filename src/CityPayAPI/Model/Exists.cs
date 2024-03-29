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
    /// Exists
    /// </summary>
    [DataContract(Name = "Exists")]
    public partial class Exists : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Exists" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Exists() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Exists" /> class.
        /// </summary>
        /// <param name="active">Boolean value whether the entity is active..</param>
        /// <param name="varExists">Boolean value whether the entity exists. (required).</param>
        /// <param name="lastModified">The last modified date of the entity..</param>
        public Exists(bool active = default(bool), bool varExists = default(bool), DateTime lastModified = default(DateTime))
        {
            this.VarExists = varExists;
            this.Active = active;
            this.LastModified = lastModified;
        }

        /// <summary>
        /// Boolean value whether the entity is active.
        /// </summary>
        /// <value>Boolean value whether the entity is active.</value>
        /// <example>true</example>
        [DataMember(Name = "active", EmitDefaultValue = true)]
        public bool Active { get; set; }

        /// <summary>
        /// Boolean value whether the entity exists.
        /// </summary>
        /// <value>Boolean value whether the entity exists.</value>
        /// <example>true</example>
        [DataMember(Name = "exists", IsRequired = true, EmitDefaultValue = true)]
        public bool VarExists { get; set; }

        /// <summary>
        /// The last modified date of the entity.
        /// </summary>
        /// <value>The last modified date of the entity.</value>
        /// <example>2020-01-02T18:32:28Z</example>
        [DataMember(Name = "last_modified", EmitDefaultValue = false)]
        public DateTime LastModified { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class Exists {\n");
            sb.Append("  Active: ").Append(Active).Append("\n");
            sb.Append("  VarExists: ").Append(VarExists).Append("\n");
            sb.Append("  LastModified: ").Append(LastModified).Append("\n");
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
            yield break;
        }
    }

}
