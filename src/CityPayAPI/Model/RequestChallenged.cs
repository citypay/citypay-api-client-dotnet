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
    /// RequestChallenged
    /// </summary>
    [DataContract]
    public partial class RequestChallenged :  IEquatable<RequestChallenged>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RequestChallenged" /> class.
        /// </summary>
        /// <param name="acsUrl">The url of the Access Control Server (ACS) to forward the user to. .</param>
        /// <param name="creq">The challenge request data which is encoded for usage by the ACS..</param>
        /// <param name="merchantid">The merchant id that processed this transaction..</param>
        /// <param name="threedserverTransId">The 3DSv2 trans id reference for the challenge process..</param>
        /// <param name="transno">The transaction number for the challenge, ordered incrementally from 1 for every merchant_id. .</param>
        public RequestChallenged(string acsUrl = default(string), string creq = default(string), int merchantid = default(int), string threedserverTransId = default(string), int transno = default(int))
        {
            this.AcsUrl = acsUrl;
            this.Creq = creq;
            this.Merchantid = merchantid;
            this.ThreedserverTransId = threedserverTransId;
            this.Transno = transno;
        }
        
        /// <summary>
        /// The url of the Access Control Server (ACS) to forward the user to. 
        /// </summary>
        /// <value>The url of the Access Control Server (ACS) to forward the user to. </value>
        [DataMember(Name="acs_url", EmitDefaultValue=false)]
        public string AcsUrl { get; set; }

        /// <summary>
        /// The challenge request data which is encoded for usage by the ACS.
        /// </summary>
        /// <value>The challenge request data which is encoded for usage by the ACS.</value>
        [DataMember(Name="creq", EmitDefaultValue=false)]
        public string Creq { get; set; }

        /// <summary>
        /// The merchant id that processed this transaction.
        /// </summary>
        /// <value>The merchant id that processed this transaction.</value>
        [DataMember(Name="merchantid", EmitDefaultValue=false)]
        public int Merchantid { get; set; }

        /// <summary>
        /// The 3DSv2 trans id reference for the challenge process.
        /// </summary>
        /// <value>The 3DSv2 trans id reference for the challenge process.</value>
        [DataMember(Name="threedserver_trans_id", EmitDefaultValue=false)]
        public string ThreedserverTransId { get; set; }

        /// <summary>
        /// The transaction number for the challenge, ordered incrementally from 1 for every merchant_id. 
        /// </summary>
        /// <value>The transaction number for the challenge, ordered incrementally from 1 for every merchant_id. </value>
        [DataMember(Name="transno", EmitDefaultValue=false)]
        public int Transno { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RequestChallenged {\n");
            sb.Append("  AcsUrl: ").Append(AcsUrl).Append("\n");
            sb.Append("  Creq: ").Append(Creq).Append("\n");
            sb.Append("  Merchantid: ").Append(Merchantid).Append("\n");
            sb.Append("  ThreedserverTransId: ").Append(ThreedserverTransId).Append("\n");
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
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as RequestChallenged);
        }

        /// <summary>
        /// Returns true if RequestChallenged instances are equal
        /// </summary>
        /// <param name="input">Instance of RequestChallenged to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RequestChallenged input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AcsUrl == input.AcsUrl ||
                    (this.AcsUrl != null &&
                    this.AcsUrl.Equals(input.AcsUrl))
                ) && 
                (
                    this.Creq == input.Creq ||
                    (this.Creq != null &&
                    this.Creq.Equals(input.Creq))
                ) && 
                (
                    this.Merchantid == input.Merchantid ||
                    this.Merchantid.Equals(input.Merchantid)
                ) && 
                (
                    this.ThreedserverTransId == input.ThreedserverTransId ||
                    (this.ThreedserverTransId != null &&
                    this.ThreedserverTransId.Equals(input.ThreedserverTransId))
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
                if (this.AcsUrl != null)
                    hashCode = hashCode * 59 + this.AcsUrl.GetHashCode();
                if (this.Creq != null)
                    hashCode = hashCode * 59 + this.Creq.GetHashCode();
                hashCode = hashCode * 59 + this.Merchantid.GetHashCode();
                if (this.ThreedserverTransId != null)
                    hashCode = hashCode * 59 + this.ThreedserverTransId.GetHashCode();
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
            yield break;
        }
    }

}
