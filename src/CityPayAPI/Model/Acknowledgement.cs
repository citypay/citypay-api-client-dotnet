/* 
 * CityPay Payment API
 *
 *  This CityPay API is a HTTP RESTful payment API used for direct server to server transactional processing. It provides a number of payment mechanisms including: Internet, MOTO, Continuous Authority transaction processing, 3-D Secure decision handling using RFA Secure, Authorisation, Refunding, Pre-Authorisation, Cancellation/Voids and Completion processing. The API is also capable of tokinsed payments using Card Holder Accounts.  ## Compliance and Security <aside class=\"notice\">   Before we begin a reminder that your application will need to adhere to PCI-DSS standards to operate safely   and to meet requirements set out by Visa and MasterCard and the PCI Security Standards Council including: </aside>  * Data must be collected using TLS version 1.2 using [strong cryptography](#enabled-tls-ciphers). We will not accept calls to our API at   lower grade encryption levels. We regularly scan our TLS endpoints for vulnerabilities and perform TLS assessments   as part of our compliance program. * The application must not store sensitive card holder data (CHD) such as the card security code (CSC) or   primary access number (PAN) * The application must not display the full card number on receipts, it is recommended to mask the PAN   and show the last 4 digits. The API will return this for you for ease of receipt creation * If you are developing a website, you will be required to perform regular scans on the network where you host the   application to meet your compliance obligations * You will be required to be PCI Compliant and the application must adhere to the security standard. Further information   is available from [https://www.pcisecuritystandards.org/](https://www.pcisecuritystandards.org/) * The API verifies that the request is for a valid account and originates from a trusted source using the remote IP   address. Our application firewalls analyse data that may be an attempt to break a large number of security common   security vulnerabilities. 
 *
 * Contact: support@citypay.com
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = CityPayAPI.Client.OpenAPIDateConverter;

namespace CityPayAPI.Model
{
    /// <summary>
    /// Acknowledgement
    /// </summary>
    [DataContract]
    public partial class Acknowledgement :  IEquatable<Acknowledgement>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Acknowledgement" /> class.
        /// </summary>
        /// <param name="code">A response code providing a result of the process..</param>
        /// <param name="context">A context id of the process used for referencing transactions through support..</param>
        /// <param name="identifier">An identifier if presented in the original request..</param>
        /// <param name="message">A response message providing a description of the result of the process..</param>
        public Acknowledgement(string code = default(string), string context = default(string), string identifier = default(string), string message = default(string))
        {
            this.Code = code;
            this.Context = context;
            this.Identifier = identifier;
            this.Message = message;
        }
        
        /// <summary>
        /// A response code providing a result of the process.
        /// </summary>
        /// <value>A response code providing a result of the process.</value>
        [DataMember(Name="code", EmitDefaultValue=false)]
        public string Code { get; set; }

        /// <summary>
        /// A context id of the process used for referencing transactions through support.
        /// </summary>
        /// <value>A context id of the process used for referencing transactions through support.</value>
        [DataMember(Name="context", EmitDefaultValue=false)]
        public string Context { get; set; }

        /// <summary>
        /// An identifier if presented in the original request.
        /// </summary>
        /// <value>An identifier if presented in the original request.</value>
        [DataMember(Name="identifier", EmitDefaultValue=false)]
        public string Identifier { get; set; }

        /// <summary>
        /// A response message providing a description of the result of the process.
        /// </summary>
        /// <value>A response message providing a description of the result of the process.</value>
        [DataMember(Name="message", EmitDefaultValue=false)]
        public string Message { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Acknowledgement {\n");
            sb.Append("  Code: ").Append(Code).Append("\n");
            sb.Append("  Context: ").Append(Context).Append("\n");
            sb.Append("  Identifier: ").Append(Identifier).Append("\n");
            sb.Append("  Message: ").Append(Message).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as Acknowledgement);
        }

        /// <summary>
        /// Returns true if Acknowledgement instances are equal
        /// </summary>
        /// <param name="input">Instance of Acknowledgement to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Acknowledgement input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Code == input.Code ||
                    (this.Code != null &&
                    this.Code.Equals(input.Code))
                ) && 
                (
                    this.Context == input.Context ||
                    (this.Context != null &&
                    this.Context.Equals(input.Context))
                ) && 
                (
                    this.Identifier == input.Identifier ||
                    (this.Identifier != null &&
                    this.Identifier.Equals(input.Identifier))
                ) && 
                (
                    this.Message == input.Message ||
                    (this.Message != null &&
                    this.Message.Equals(input.Message))
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
                if (this.Code != null)
                    hashCode = hashCode * 59 + this.Code.GetHashCode();
                if (this.Context != null)
                    hashCode = hashCode * 59 + this.Context.GetHashCode();
                if (this.Identifier != null)
                    hashCode = hashCode * 59 + this.Identifier.GetHashCode();
                if (this.Message != null)
                    hashCode = hashCode * 59 + this.Message.GetHashCode();
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
            // Code (string) maxLength
            if(this.Code != null && this.Code.Length > 4)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Code, length must be less than 4.", new [] { "Code" });
            }

            // Code (string) minLength
            if(this.Code != null && this.Code.Length < 3)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Code, length must be greater than 3.", new [] { "Code" });
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
