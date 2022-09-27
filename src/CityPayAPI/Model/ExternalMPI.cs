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
    /// ExternalMPI
    /// </summary>
    [DataContract(Name = "ExternalMPI")]
    public partial class ExternalMPI : IEquatable<ExternalMPI>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ExternalMPI" /> class.
        /// </summary>
        /// <param name="authenResult">The authentication result available from the MPI..</param>
        /// <param name="cavv">A value determining the cardholder verification value supplied by the card scheme..</param>
        /// <param name="eci">The obtained e-commerce indicator from the MPI..</param>
        /// <param name="enrolled">A value determining whether the card holder was enrolled..</param>
        /// <param name="xid">The XID used for processing with the MPI..</param>
        public ExternalMPI(string authenResult = default(string), string cavv = default(string), int eci = default(int), string enrolled = default(string), string xid = default(string))
        {
            this.AuthenResult = authenResult;
            this.Cavv = cavv;
            this.Eci = eci;
            this.Enrolled = enrolled;
            this.Xid = xid;
        }

        /// <summary>
        /// The authentication result available from the MPI.
        /// </summary>
        /// <value>The authentication result available from the MPI.</value>
        [DataMember(Name = "authen_result", EmitDefaultValue = false)]
        public string AuthenResult { get; set; }

        /// <summary>
        /// A value determining the cardholder verification value supplied by the card scheme.
        /// </summary>
        /// <value>A value determining the cardholder verification value supplied by the card scheme.</value>
        [DataMember(Name = "cavv", EmitDefaultValue = false)]
        public string Cavv { get; set; }

        /// <summary>
        /// The obtained e-commerce indicator from the MPI.
        /// </summary>
        /// <value>The obtained e-commerce indicator from the MPI.</value>
        [DataMember(Name = "eci", EmitDefaultValue = false)]
        public int Eci { get; set; }

        /// <summary>
        /// A value determining whether the card holder was enrolled.
        /// </summary>
        /// <value>A value determining whether the card holder was enrolled.</value>
        [DataMember(Name = "enrolled", EmitDefaultValue = false)]
        public string Enrolled { get; set; }

        /// <summary>
        /// The XID used for processing with the MPI.
        /// </summary>
        /// <value>The XID used for processing with the MPI.</value>
        [DataMember(Name = "xid", EmitDefaultValue = false)]
        public string Xid { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ExternalMPI {\n");
            sb.Append("  AuthenResult: ").Append(AuthenResult).Append("\n");
            sb.Append("  Cavv: ").Append(Cavv).Append("\n");
            sb.Append("  Eci: ").Append(Eci).Append("\n");
            sb.Append("  Enrolled: ").Append(Enrolled).Append("\n");
            sb.Append("  Xid: ").Append(Xid).Append("\n");
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
            return this.Equals(input as ExternalMPI);
        }

        /// <summary>
        /// Returns true if ExternalMPI instances are equal
        /// </summary>
        /// <param name="input">Instance of ExternalMPI to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ExternalMPI input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AuthenResult == input.AuthenResult ||
                    (this.AuthenResult != null &&
                    this.AuthenResult.Equals(input.AuthenResult))
                ) && 
                (
                    this.Cavv == input.Cavv ||
                    (this.Cavv != null &&
                    this.Cavv.Equals(input.Cavv))
                ) && 
                (
                    this.Eci == input.Eci ||
                    this.Eci.Equals(input.Eci)
                ) && 
                (
                    this.Enrolled == input.Enrolled ||
                    (this.Enrolled != null &&
                    this.Enrolled.Equals(input.Enrolled))
                ) && 
                (
                    this.Xid == input.Xid ||
                    (this.Xid != null &&
                    this.Xid.Equals(input.Xid))
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
                if (this.AuthenResult != null)
                    hashCode = hashCode * 59 + this.AuthenResult.GetHashCode();
                if (this.Cavv != null)
                    hashCode = hashCode * 59 + this.Cavv.GetHashCode();
                hashCode = hashCode * 59 + this.Eci.GetHashCode();
                if (this.Enrolled != null)
                    hashCode = hashCode * 59 + this.Enrolled.GetHashCode();
                if (this.Xid != null)
                    hashCode = hashCode * 59 + this.Xid.GetHashCode();
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
            // AuthenResult (string) maxLength
            if(this.AuthenResult != null && this.AuthenResult.Length > 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for AuthenResult, length must be less than 1.", new [] { "AuthenResult" });
            }

            // Cavv (string) maxLength
            if(this.Cavv != null && this.Cavv.Length > 20)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Cavv, length must be less than 20.", new [] { "Cavv" });
            }

            // Enrolled (string) maxLength
            if(this.Enrolled != null && this.Enrolled.Length > 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Enrolled, length must be less than 1.", new [] { "Enrolled" });
            }

            // Xid (string) maxLength
            if(this.Xid != null && this.Xid.Length > 20)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Xid, length must be less than 20.", new [] { "Xid" });
            }

            yield break;
        }
    }

}
