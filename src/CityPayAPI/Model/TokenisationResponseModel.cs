/*
 * CityPay Payment API
 *
 *  This CityPay API is a HTTP RESTful payment API used for direct server to server transactional processing. It provides a number of payment mechanisms including: Internet, MOTO, Continuous Authority transaction processing, 3-D Secure decision handling using RFA Secure, Authorisation, Refunding, Pre-Authorisation, Cancellation/Voids and Completion processing. The API is also capable of tokinsed payments using Card Holder Accounts.  ## Compliance and Security Your application will need to adhere to PCI-DSS standards to operate safely and to meet requirements set out by  Visa and MasterCard and the PCI Security Standards Council. These include  * Data must be collected using TLS version 1.2 using [strong cryptography](#enabled-tls-ciphers). We will not accept calls to our API at   lower grade encryption levels. We regularly scan our TLS endpoints for vulnerabilities and perform TLS assessments   as part of our compliance program. * The application must not store sensitive card holder data (CHD) such as the card security code (CSC) or   primary access number (PAN) * The application must not display the full card number on receipts, it is recommended to mask the PAN   and show the last 4 digits. The API will return this for you for ease of receipt creation * If you are developing a website, you will be required to perform regular scans on the network where you host the   application to meet your compliance obligations * You will be required to be PCI Compliant and the application must adhere to the security standard. Further information   is available from [https://www.pcisecuritystandards.org/](https://www.pcisecuritystandards.org/) * The API verifies that the request is for a valid account and originates from a trusted source using the remote IP   address. Our application firewalls analyse data that may be an attempt to break a large number of security common   security vulnerabilities.. 
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
    /// TokenisationResponseModel
    /// </summary>
    [DataContract(Name = "TokenisationResponseModel")]
    public partial class TokenisationResponseModel : IEquatable<TokenisationResponseModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TokenisationResponseModel" /> class.
        /// </summary>
        /// <param name="authenResult">The result of any authentication using 3d_secure authorisation against ecommerce transactions. Values are:  &lt;table&gt; &lt;tr&gt; &lt;th&gt;Value&lt;/th&gt; &lt;th&gt;Description&lt;/th&gt; &lt;/tr&gt; &lt;tr&gt; &lt;td&gt;Y&lt;/td&gt; &lt;td&gt;Authentication Successful. The Cardholder&#39;s password was successfully validated.&lt;/td&gt; &lt;/tr&gt; &lt;tr&gt; &lt;td&gt;N&lt;/td&gt; &lt;td&gt;Authentication Failed. Customer failed or cancelled authentication, transaction denied.&lt;/td&gt; &lt;/tr&gt; &lt;tr&gt; &lt;td&gt;A&lt;/td&gt; &lt;td&gt;Attempts Processing Performed Authentication could not be completed but a proof of authentication attempt (CAVV) was generated.&lt;/td&gt; &lt;/tr&gt; &lt;tr&gt; &lt;td&gt;U&lt;/td&gt; &lt;td&gt;Authentication Could Not Be Performed Authentication could not be completed, due to technical or other problem.&lt;/td&gt; &lt;/tr&gt; &lt;/table&gt; .</param>
        /// <param name="binCommercial">Determines whether the bin range was found to be a commercial or business card..</param>
        /// <param name="binDebit">Determines whether the bin range was found to be a debit card. If false the card was considered as a credit card..</param>
        /// <param name="binDescription">A description of the bin range found for the card..</param>
        /// <param name="eci">An Electronic Commerce Indicator (ECI) used to identify the result of authentication using 3DSecure. .</param>
        /// <param name="identifier">The identifier provided within the request..</param>
        /// <param name="maskedpan">A masked value of the card number used for processing displaying limited values that can be used on a receipt. .</param>
        /// <param name="scheme">A name of the card scheme of the transaction that processed the transaction such as Visa or MasterCard. .</param>
        /// <param name="sigId">A Base58 encoded SHA-256 digest generated from the token value Base58 decoded and appended with the nonce value UTF-8 decoded..</param>
        /// <param name="token">The token used for presentment to authorisation later in the procsesing flow..</param>
        public TokenisationResponseModel(string authenResult = default(string), bool binCommercial = default(bool), bool binDebit = default(bool), string binDescription = default(string), string eci = default(string), string identifier = default(string), string maskedpan = default(string), string scheme = default(string), string sigId = default(string), string token = default(string))
        {
            this.AuthenResult = authenResult;
            this.BinCommercial = binCommercial;
            this.BinDebit = binDebit;
            this.BinDescription = binDescription;
            this.Eci = eci;
            this.Identifier = identifier;
            this.Maskedpan = maskedpan;
            this.Scheme = scheme;
            this.SigId = sigId;
            this.Token = token;
        }

        /// <summary>
        /// The result of any authentication using 3d_secure authorisation against ecommerce transactions. Values are:  &lt;table&gt; &lt;tr&gt; &lt;th&gt;Value&lt;/th&gt; &lt;th&gt;Description&lt;/th&gt; &lt;/tr&gt; &lt;tr&gt; &lt;td&gt;Y&lt;/td&gt; &lt;td&gt;Authentication Successful. The Cardholder&#39;s password was successfully validated.&lt;/td&gt; &lt;/tr&gt; &lt;tr&gt; &lt;td&gt;N&lt;/td&gt; &lt;td&gt;Authentication Failed. Customer failed or cancelled authentication, transaction denied.&lt;/td&gt; &lt;/tr&gt; &lt;tr&gt; &lt;td&gt;A&lt;/td&gt; &lt;td&gt;Attempts Processing Performed Authentication could not be completed but a proof of authentication attempt (CAVV) was generated.&lt;/td&gt; &lt;/tr&gt; &lt;tr&gt; &lt;td&gt;U&lt;/td&gt; &lt;td&gt;Authentication Could Not Be Performed Authentication could not be completed, due to technical or other problem.&lt;/td&gt; &lt;/tr&gt; &lt;/table&gt; 
        /// </summary>
        /// <value>The result of any authentication using 3d_secure authorisation against ecommerce transactions. Values are:  &lt;table&gt; &lt;tr&gt; &lt;th&gt;Value&lt;/th&gt; &lt;th&gt;Description&lt;/th&gt; &lt;/tr&gt; &lt;tr&gt; &lt;td&gt;Y&lt;/td&gt; &lt;td&gt;Authentication Successful. The Cardholder&#39;s password was successfully validated.&lt;/td&gt; &lt;/tr&gt; &lt;tr&gt; &lt;td&gt;N&lt;/td&gt; &lt;td&gt;Authentication Failed. Customer failed or cancelled authentication, transaction denied.&lt;/td&gt; &lt;/tr&gt; &lt;tr&gt; &lt;td&gt;A&lt;/td&gt; &lt;td&gt;Attempts Processing Performed Authentication could not be completed but a proof of authentication attempt (CAVV) was generated.&lt;/td&gt; &lt;/tr&gt; &lt;tr&gt; &lt;td&gt;U&lt;/td&gt; &lt;td&gt;Authentication Could Not Be Performed Authentication could not be completed, due to technical or other problem.&lt;/td&gt; &lt;/tr&gt; &lt;/table&gt; </value>
        [DataMember(Name = "authen_result", EmitDefaultValue = false)]
        public string AuthenResult { get; set; }

        /// <summary>
        /// Determines whether the bin range was found to be a commercial or business card.
        /// </summary>
        /// <value>Determines whether the bin range was found to be a commercial or business card.</value>
        [DataMember(Name = "bin_commercial", EmitDefaultValue = true)]
        public bool BinCommercial { get; set; }

        /// <summary>
        /// Determines whether the bin range was found to be a debit card. If false the card was considered as a credit card.
        /// </summary>
        /// <value>Determines whether the bin range was found to be a debit card. If false the card was considered as a credit card.</value>
        [DataMember(Name = "bin_debit", EmitDefaultValue = true)]
        public bool BinDebit { get; set; }

        /// <summary>
        /// A description of the bin range found for the card.
        /// </summary>
        /// <value>A description of the bin range found for the card.</value>
        [DataMember(Name = "bin_description", EmitDefaultValue = false)]
        public string BinDescription { get; set; }

        /// <summary>
        /// An Electronic Commerce Indicator (ECI) used to identify the result of authentication using 3DSecure. 
        /// </summary>
        /// <value>An Electronic Commerce Indicator (ECI) used to identify the result of authentication using 3DSecure. </value>
        [DataMember(Name = "eci", EmitDefaultValue = false)]
        public string Eci { get; set; }

        /// <summary>
        /// The identifier provided within the request.
        /// </summary>
        /// <value>The identifier provided within the request.</value>
        [DataMember(Name = "identifier", EmitDefaultValue = false)]
        public string Identifier { get; set; }

        /// <summary>
        /// A masked value of the card number used for processing displaying limited values that can be used on a receipt. 
        /// </summary>
        /// <value>A masked value of the card number used for processing displaying limited values that can be used on a receipt. </value>
        [DataMember(Name = "maskedpan", EmitDefaultValue = false)]
        public string Maskedpan { get; set; }

        /// <summary>
        /// A name of the card scheme of the transaction that processed the transaction such as Visa or MasterCard. 
        /// </summary>
        /// <value>A name of the card scheme of the transaction that processed the transaction such as Visa or MasterCard. </value>
        [DataMember(Name = "scheme", EmitDefaultValue = false)]
        public string Scheme { get; set; }

        /// <summary>
        /// A Base58 encoded SHA-256 digest generated from the token value Base58 decoded and appended with the nonce value UTF-8 decoded.
        /// </summary>
        /// <value>A Base58 encoded SHA-256 digest generated from the token value Base58 decoded and appended with the nonce value UTF-8 decoded.</value>
        [DataMember(Name = "sig_id", EmitDefaultValue = false)]
        public string SigId { get; set; }

        /// <summary>
        /// The token used for presentment to authorisation later in the procsesing flow.
        /// </summary>
        /// <value>The token used for presentment to authorisation later in the procsesing flow.</value>
        [DataMember(Name = "token", EmitDefaultValue = false)]
        public string Token { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TokenisationResponseModel {\n");
            sb.Append("  AuthenResult: ").Append(AuthenResult).Append("\n");
            sb.Append("  BinCommercial: ").Append(BinCommercial).Append("\n");
            sb.Append("  BinDebit: ").Append(BinDebit).Append("\n");
            sb.Append("  BinDescription: ").Append(BinDescription).Append("\n");
            sb.Append("  Eci: ").Append(Eci).Append("\n");
            sb.Append("  Identifier: ").Append(Identifier).Append("\n");
            sb.Append("  Maskedpan: ").Append(Maskedpan).Append("\n");
            sb.Append("  Scheme: ").Append(Scheme).Append("\n");
            sb.Append("  SigId: ").Append(SigId).Append("\n");
            sb.Append("  Token: ").Append(Token).Append("\n");
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
            return this.Equals(input as TokenisationResponseModel);
        }

        /// <summary>
        /// Returns true if TokenisationResponseModel instances are equal
        /// </summary>
        /// <param name="input">Instance of TokenisationResponseModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TokenisationResponseModel input)
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
                    this.BinCommercial == input.BinCommercial ||
                    this.BinCommercial.Equals(input.BinCommercial)
                ) && 
                (
                    this.BinDebit == input.BinDebit ||
                    this.BinDebit.Equals(input.BinDebit)
                ) && 
                (
                    this.BinDescription == input.BinDescription ||
                    (this.BinDescription != null &&
                    this.BinDescription.Equals(input.BinDescription))
                ) && 
                (
                    this.Eci == input.Eci ||
                    (this.Eci != null &&
                    this.Eci.Equals(input.Eci))
                ) && 
                (
                    this.Identifier == input.Identifier ||
                    (this.Identifier != null &&
                    this.Identifier.Equals(input.Identifier))
                ) && 
                (
                    this.Maskedpan == input.Maskedpan ||
                    (this.Maskedpan != null &&
                    this.Maskedpan.Equals(input.Maskedpan))
                ) && 
                (
                    this.Scheme == input.Scheme ||
                    (this.Scheme != null &&
                    this.Scheme.Equals(input.Scheme))
                ) && 
                (
                    this.SigId == input.SigId ||
                    (this.SigId != null &&
                    this.SigId.Equals(input.SigId))
                ) && 
                (
                    this.Token == input.Token ||
                    (this.Token != null &&
                    this.Token.Equals(input.Token))
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
                hashCode = hashCode * 59 + this.BinCommercial.GetHashCode();
                hashCode = hashCode * 59 + this.BinDebit.GetHashCode();
                if (this.BinDescription != null)
                    hashCode = hashCode * 59 + this.BinDescription.GetHashCode();
                if (this.Eci != null)
                    hashCode = hashCode * 59 + this.Eci.GetHashCode();
                if (this.Identifier != null)
                    hashCode = hashCode * 59 + this.Identifier.GetHashCode();
                if (this.Maskedpan != null)
                    hashCode = hashCode * 59 + this.Maskedpan.GetHashCode();
                if (this.Scheme != null)
                    hashCode = hashCode * 59 + this.Scheme.GetHashCode();
                if (this.SigId != null)
                    hashCode = hashCode * 59 + this.SigId.GetHashCode();
                if (this.Token != null)
                    hashCode = hashCode * 59 + this.Token.GetHashCode();
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
