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
    /// CResAuthRequest
    /// </summary>
    [DataContract]
    public partial class CResAuthRequest :  IEquatable<CResAuthRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CResAuthRequest" /> class.
        /// </summary>
        /// <param name="cres">The challenge response data forwarded by the ACS in 3D-Secure V2 processing. Data should be forwarded to CityPay unchanged for subsequent authorisation and processing. .</param>
        public CResAuthRequest(string cres = default(string))
        {
            this.Cres = cres;
        }
        
        /// <summary>
        /// The challenge response data forwarded by the ACS in 3D-Secure V2 processing. Data should be forwarded to CityPay unchanged for subsequent authorisation and processing. 
        /// </summary>
        /// <value>The challenge response data forwarded by the ACS in 3D-Secure V2 processing. Data should be forwarded to CityPay unchanged for subsequent authorisation and processing. </value>
        [DataMember(Name="cres", EmitDefaultValue=false)]
        public string Cres { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CResAuthRequest {\n");
            sb.Append("  Cres: ").Append(Cres).Append("\n");
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
            return this.Equals(input as CResAuthRequest);
        }

        /// <summary>
        /// Returns true if CResAuthRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of CResAuthRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CResAuthRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Cres == input.Cres ||
                    (this.Cres != null &&
                    this.Cres.Equals(input.Cres))
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
                if (this.Cres != null)
                    hashCode = hashCode * 59 + this.Cres.GetHashCode();
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
