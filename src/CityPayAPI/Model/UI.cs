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
    /// UI
    /// </summary>
    [DataContract(Name = "UI")]
    public partial class UI : IEquatable<UI>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UI" /> class.
        /// </summary>
        /// <param name="addressMandatory">whether the address is forced as mandatory..</param>
        /// <param name="formAutocomplete">specify the form autocomplete setting, default to on. If set to off the UI will set autocomplete&#x3D;\&quot;off\&quot; on the form level and prevent elements from adding it..</param>
        /// <param name="ordering">the logical ordering of the ui groups..</param>
        /// <param name="postcodeMandatory">whether the postcode is forced as mandatory..</param>
        public UI(bool addressMandatory = default(bool), string formAutocomplete = default(string), int ordering = default(int), bool postcodeMandatory = default(bool))
        {
            this.AddressMandatory = addressMandatory;
            this.FormAutocomplete = formAutocomplete;
            this.Ordering = ordering;
            this.PostcodeMandatory = postcodeMandatory;
        }

        /// <summary>
        /// whether the address is forced as mandatory.
        /// </summary>
        /// <value>whether the address is forced as mandatory.</value>
        [DataMember(Name = "addressMandatory", EmitDefaultValue = true)]
        public bool AddressMandatory { get; set; }

        /// <summary>
        /// specify the form autocomplete setting, default to on. If set to off the UI will set autocomplete&#x3D;\&quot;off\&quot; on the form level and prevent elements from adding it.
        /// </summary>
        /// <value>specify the form autocomplete setting, default to on. If set to off the UI will set autocomplete&#x3D;\&quot;off\&quot; on the form level and prevent elements from adding it.</value>
        [DataMember(Name = "formAutocomplete", EmitDefaultValue = false)]
        public string FormAutocomplete { get; set; }

        /// <summary>
        /// the logical ordering of the ui groups.
        /// </summary>
        /// <value>the logical ordering of the ui groups.</value>
        [DataMember(Name = "ordering", EmitDefaultValue = false)]
        public int Ordering { get; set; }

        /// <summary>
        /// whether the postcode is forced as mandatory.
        /// </summary>
        /// <value>whether the postcode is forced as mandatory.</value>
        [DataMember(Name = "postcodeMandatory", EmitDefaultValue = true)]
        public bool PostcodeMandatory { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UI {\n");
            sb.Append("  AddressMandatory: ").Append(AddressMandatory).Append("\n");
            sb.Append("  FormAutocomplete: ").Append(FormAutocomplete).Append("\n");
            sb.Append("  Ordering: ").Append(Ordering).Append("\n");
            sb.Append("  PostcodeMandatory: ").Append(PostcodeMandatory).Append("\n");
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
            return this.Equals(input as UI);
        }

        /// <summary>
        /// Returns true if UI instances are equal
        /// </summary>
        /// <param name="input">Instance of UI to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UI input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AddressMandatory == input.AddressMandatory ||
                    this.AddressMandatory.Equals(input.AddressMandatory)
                ) && 
                (
                    this.FormAutocomplete == input.FormAutocomplete ||
                    (this.FormAutocomplete != null &&
                    this.FormAutocomplete.Equals(input.FormAutocomplete))
                ) && 
                (
                    this.Ordering == input.Ordering ||
                    this.Ordering.Equals(input.Ordering)
                ) && 
                (
                    this.PostcodeMandatory == input.PostcodeMandatory ||
                    this.PostcodeMandatory.Equals(input.PostcodeMandatory)
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
                hashCode = hashCode * 59 + this.AddressMandatory.GetHashCode();
                if (this.FormAutocomplete != null)
                    hashCode = hashCode * 59 + this.FormAutocomplete.GetHashCode();
                hashCode = hashCode * 59 + this.Ordering.GetHashCode();
                hashCode = hashCode * 59 + this.PostcodeMandatory.GetHashCode();
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
