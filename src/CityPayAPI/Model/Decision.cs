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
    /// Decision
    /// </summary>
    [DataContract(Name = "Decision")]
    public partial class Decision : IEquatable<Decision>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Decision" /> class.
        /// </summary>
        /// <param name="authenRequired">authenRequired.</param>
        /// <param name="authResponse">authResponse.</param>
        /// <param name="requestChallenged">requestChallenged.</param>
        public Decision(AuthenRequired authenRequired = default(AuthenRequired), AuthResponse authResponse = default(AuthResponse), RequestChallenged requestChallenged = default(RequestChallenged))
        {
            this.AuthenRequired = authenRequired;
            this.AuthResponse = authResponse;
            this.RequestChallenged = requestChallenged;
        }

        /// <summary>
        /// Gets or Sets AuthenRequired
        /// </summary>
        [DataMember(Name = "AuthenRequired", EmitDefaultValue = false)]
        public AuthenRequired AuthenRequired { get; set; }

        /// <summary>
        /// Gets or Sets AuthResponse
        /// </summary>
        [DataMember(Name = "AuthResponse", EmitDefaultValue = false)]
        public AuthResponse AuthResponse { get; set; }

        /// <summary>
        /// Gets or Sets RequestChallenged
        /// </summary>
        [DataMember(Name = "RequestChallenged", EmitDefaultValue = false)]
        public RequestChallenged RequestChallenged { get; set; }

        /// <summary>
        /// Determines if the decision is a 3dsv2 challenge request
        /// </summary>
        /// <returns></returns>
        public bool IsRequestChallenged()
        {
            return this.RequestChallenged != null;
        }

        /// <summary>
        /// Determines if the decision resulted in an authorisation
        /// </summary>
        /// <returns></returns>
        public bool IsAuthResponse()
        {
            return this.AuthResponse != null;
        }

        /// <summary>
        /// Determines if the decision required authentication with 3DSv1
        /// </summary>
        /// <returns></returns>
        public bool IsAuthenRequired()
        {
            return this.AuthenRequired != null;
        }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class Decision {\n");
            sb.Append("  AuthenRequired: ").Append(AuthenRequired).Append("\n");
            sb.Append("  AuthResponse: ").Append(AuthResponse).Append("\n");
            sb.Append("  RequestChallenged: ").Append(RequestChallenged).Append("\n");
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
            return this.Equals(input as Decision);
        }

        /// <summary>
        /// Returns true if Decision instances are equal
        /// </summary>
        /// <param name="input">Instance of Decision to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Decision input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.AuthenRequired == input.AuthenRequired ||
                    (this.AuthenRequired != null &&
                    this.AuthenRequired.Equals(input.AuthenRequired))
                ) && 
                (
                    this.AuthResponse == input.AuthResponse ||
                    (this.AuthResponse != null &&
                    this.AuthResponse.Equals(input.AuthResponse))
                ) && 
                (
                    this.RequestChallenged == input.RequestChallenged ||
                    (this.RequestChallenged != null &&
                    this.RequestChallenged.Equals(input.RequestChallenged))
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
                if (this.AuthenRequired != null)
                {
                    hashCode = (hashCode * 59) + this.AuthenRequired.GetHashCode();
                }
                if (this.AuthResponse != null)
                {
                    hashCode = (hashCode * 59) + this.AuthResponse.GetHashCode();
                }
                if (this.RequestChallenged != null)
                {
                    hashCode = (hashCode * 59) + this.RequestChallenged.GetHashCode();
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
