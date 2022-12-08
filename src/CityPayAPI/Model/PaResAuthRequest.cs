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
    /// PaResAuthRequest
    /// </summary>
    [DataContract(Name = "PaResAuthRequest")]
    public partial class PaResAuthRequest : IEquatable<PaResAuthRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PaResAuthRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected PaResAuthRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="PaResAuthRequest" /> class.
        /// </summary>
        /// <param name="md">The Merchant Data (MD) which is a unique ID to reference the authentication session.  This value will be created by CityPay when required. When responding from the ACS, this value will be returned by the ACS.  (required).</param>
        /// <param name="pares">The Payer Authentication Response packet which is returned by the ACS containing the  response of the authentication session including verification values. The response  is a base64 encoded packet and should be forwarded to CityPay untouched.  (required).</param>
        public PaResAuthRequest(string md = default(string), string pares = default(string))
        {
            // to ensure "md" is required (not null)
            if (md == null)
            {
                throw new ArgumentNullException("md is a required property for PaResAuthRequest and cannot be null");
            }
            this.Md = md;
            // to ensure "pares" is required (not null)
            if (pares == null)
            {
                throw new ArgumentNullException("pares is a required property for PaResAuthRequest and cannot be null");
            }
            this.Pares = pares;
        }

        /// <summary>
        /// The Merchant Data (MD) which is a unique ID to reference the authentication session.  This value will be created by CityPay when required. When responding from the ACS, this value will be returned by the ACS. 
        /// </summary>
        /// <value>The Merchant Data (MD) which is a unique ID to reference the authentication session.  This value will be created by CityPay when required. When responding from the ACS, this value will be returned by the ACS. </value>
        [DataMember(Name = "md", IsRequired = true, EmitDefaultValue = false)]
        public string Md { get; set; }

        /// <summary>
        /// The Payer Authentication Response packet which is returned by the ACS containing the  response of the authentication session including verification values. The response  is a base64 encoded packet and should be forwarded to CityPay untouched. 
        /// </summary>
        /// <value>The Payer Authentication Response packet which is returned by the ACS containing the  response of the authentication session including verification values. The response  is a base64 encoded packet and should be forwarded to CityPay untouched. </value>
        [DataMember(Name = "pares", IsRequired = true, EmitDefaultValue = false)]
        public string Pares { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class PaResAuthRequest {\n");
            sb.Append("  Md: ").Append(Md).Append("\n");
            sb.Append("  Pares: ").Append(Pares).Append("\n");
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
            return this.Equals(input as PaResAuthRequest);
        }

        /// <summary>
        /// Returns true if PaResAuthRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of PaResAuthRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PaResAuthRequest input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Md == input.Md ||
                    (this.Md != null &&
                    this.Md.Equals(input.Md))
                ) && 
                (
                    this.Pares == input.Pares ||
                    (this.Pares != null &&
                    this.Pares.Equals(input.Pares))
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
                if (this.Md != null)
                {
                    hashCode = (hashCode * 59) + this.Md.GetHashCode();
                }
                if (this.Pares != null)
                {
                    hashCode = (hashCode * 59) + this.Pares.GetHashCode();
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
