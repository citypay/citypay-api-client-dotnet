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
    /// ChargeRequest
    /// </summary>
    [DataContract]
    public partial class ChargeRequest :  IEquatable<ChargeRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ChargeRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ChargeRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ChargeRequest" /> class.
        /// </summary>
        /// <param name="amount">The amount to authorise in the lowest unit of currency with a variable length to a maximum of 12 digits. No decimal points are to be included and no divisional characters such as 1,024. The amount should be the total amount required for the transaction. For example with GBP £1,021.95 the amount value is 102195.  (required).</param>
        /// <param name="avsPostcodePolicy">A policy value which determines whether an AVS postcode policy is enforced or bypassed.  Values are  &#x60;0&#x60; for the default policy (default value if not supplied). Your default values are determined by your account manager on setup of the account.  &#x60;1&#x60; for an enforced policy. Transactions that are enforced will be rejected if the AVS postcode numeric value does not match.  &#x60;2&#x60; to bypass. Transactions that are bypassed will be allowed through even if the postcode did not match.  &#x60;3&#x60; to ignore. Transactions that are ignored will bypass the result and not send postcode details for authorisation. .</param>
        /// <param name="csc">The Card Security Code (CSC) (also known as CV2/CVV2) is normally found on the back of the card (American Express has it on the front). The value helps to identify posession of the card as it is not available within the chip or magnetic swipe.  When forwarding the CSC, please ensure the value is a string as some values start with 0 and this will be stripped out by any integer parsing.  The CSC number aids fraud prevention in Mail Order and Internet payments.   Business rules are available on your account to identify whether to accept or decline transactions based on mismatched results of the CSC.  The Payment Card Industry (PCI) requires that at no stage of a transaction should the CSC be stored. This applies to all entities handling card data. It should also not be used in any hashing process. CityPay do not store the value and have no method of retrieving the value once the transaction has been processed. For this reason, duplicate checking is unable to determine the CSC in its duplication check algorithm. .</param>
        /// <param name="cscPolicy">A policy value which determines whether a CSC policy is enforced or bypassed.  Values are  &#x60;0&#x60; for the default policy (default value if not supplied). Your default values are determined by your account manager on setup of the account.  &#x60;1&#x60; for an enforced policy. Transactions that are enforced will be rejected if the CSC value does not match.  &#x60;2&#x60; to bypass. Transactions that are bypassed will be allowed through even if the CSC did not match.  &#x60;3&#x60; to ignore. Transactions that are ignored will bypass the result and not send the CSC details for authorisation. .</param>
        /// <param name="currency">The processing currency for the transaction. Will default to the merchant account currency..</param>
        /// <param name="duplicatePolicy">A policy value which determines whether a duplication policy is enforced or bypassed. A duplication check has a window of time set against your account within which it can action. If a previous transaction with matching values occurred within the window, any subsequent transaction will result in a T001 result.  Values are  &#x60;0&#x60; for the default policy (default value if not supplied). Your default values are determined by your account manager on setup of the account.  &#x60;1&#x60; for an enforced policy. Transactions that are enforced will be checked for duplication within the duplication window.  &#x60;2&#x60; to bypass. Transactions that are bypassed will not be checked for duplication within the duplication window.  &#x60;3&#x60; to ignore. Transactions that are ignored will have the same affect as bypass. .</param>
        /// <param name="identifier">The identifier of the transaction to process. The value should be a valid reference and may be used to perform  post processing actions and to aid in reconciliation of transactions.  The value should be a valid printable string with ASCII character ranges from 0x32 to 0x127.  The identifier is recommended to be distinct for each transaction such as a [random unique identifier](https://en.wikipedia.org/wiki/Universally_unique_identifier) this will aid in ensuring each transaction is identifiable.  When transactions are processed they are also checked for duplicate requests. Changing the identifier on a subsequent request will ensure that a transaction is considered as different.  (required).</param>
        /// <param name="matchAvsa">A policy value which determines whether an AVS address policy is enforced, bypassed or ignored.   Values are  &#x60;0&#x60; for the default policy (default value if not supplied). Your default values are determined by your account manager on setup of the account.  &#x60;1&#x60; for an enforced policy. Transactions that are enforced will be rejected if the AVS address numeric value does not match.  &#x60;2&#x60; to bypass. Transactions that are bypassed will be allowed through even if the address did not match.  &#x60;3&#x60; to ignore. Transactions that are ignored will bypass the result and not send address numeric details for authorisation. .</param>
        /// <param name="merchantid">Identifies the merchant account to perform processing for. (required).</param>
        /// <param name="threedsecure">threedsecure.</param>
        /// <param name="token">A tokenised form of a card that belongs to a card holder&#39;s account and that has been previously registered. The token is time based and will only be active for a short duration. The value is therefore designed not to be stored remotely for future  use.  Tokens will start with ct and are resiliently tamper proof using HMacSHA-256. No sensitive card data is stored internally within the token.  Each card will contain a different token and the value may be different on any retrieval call.  The value can be presented for payment as a selection value to an end user in a web application.  (required).</param>
        /// <param name="transInfo">Further information that can be added to the transaction will display in reporting. Can be used for flexible values such as operator id..</param>
        /// <param name="transType">The type of transaction being submitted. Normally this value is not required and your account manager may request that you set this field..</param>
        public ChargeRequest(int amount = default(int), string avsPostcodePolicy = default(string), string csc = default(string), string cscPolicy = default(string), string currency = default(string), string duplicatePolicy = default(string), string identifier = default(string), string matchAvsa = default(string), int merchantid = default(int), ThreeDSecure threedsecure = default(ThreeDSecure), string token = default(string), string transInfo = default(string), string transType = default(string))
        {
            this.Amount = amount;
            // to ensure "identifier" is required (not null)
            this.Identifier = identifier ?? throw new ArgumentNullException("identifier is a required property for ChargeRequest and cannot be null");
            this.Merchantid = merchantid;
            // to ensure "token" is required (not null)
            this.Token = token ?? throw new ArgumentNullException("token is a required property for ChargeRequest and cannot be null");
            this.AvsPostcodePolicy = avsPostcodePolicy;
            this.Csc = csc;
            this.CscPolicy = cscPolicy;
            this.Currency = currency;
            this.DuplicatePolicy = duplicatePolicy;
            this.MatchAvsa = matchAvsa;
            this.Threedsecure = threedsecure;
            this.TransInfo = transInfo;
            this.TransType = transType;
        }
        
        /// <summary>
        /// The amount to authorise in the lowest unit of currency with a variable length to a maximum of 12 digits. No decimal points are to be included and no divisional characters such as 1,024. The amount should be the total amount required for the transaction. For example with GBP £1,021.95 the amount value is 102195. 
        /// </summary>
        /// <value>The amount to authorise in the lowest unit of currency with a variable length to a maximum of 12 digits. No decimal points are to be included and no divisional characters such as 1,024. The amount should be the total amount required for the transaction. For example with GBP £1,021.95 the amount value is 102195. </value>
        [DataMember(Name="amount", EmitDefaultValue=false)]
        public int Amount { get; set; }

        /// <summary>
        /// A policy value which determines whether an AVS postcode policy is enforced or bypassed.  Values are  &#x60;0&#x60; for the default policy (default value if not supplied). Your default values are determined by your account manager on setup of the account.  &#x60;1&#x60; for an enforced policy. Transactions that are enforced will be rejected if the AVS postcode numeric value does not match.  &#x60;2&#x60; to bypass. Transactions that are bypassed will be allowed through even if the postcode did not match.  &#x60;3&#x60; to ignore. Transactions that are ignored will bypass the result and not send postcode details for authorisation. 
        /// </summary>
        /// <value>A policy value which determines whether an AVS postcode policy is enforced or bypassed.  Values are  &#x60;0&#x60; for the default policy (default value if not supplied). Your default values are determined by your account manager on setup of the account.  &#x60;1&#x60; for an enforced policy. Transactions that are enforced will be rejected if the AVS postcode numeric value does not match.  &#x60;2&#x60; to bypass. Transactions that are bypassed will be allowed through even if the postcode did not match.  &#x60;3&#x60; to ignore. Transactions that are ignored will bypass the result and not send postcode details for authorisation. </value>
        [DataMember(Name="avs_postcode_policy", EmitDefaultValue=false)]
        public string AvsPostcodePolicy { get; set; }

        /// <summary>
        /// The Card Security Code (CSC) (also known as CV2/CVV2) is normally found on the back of the card (American Express has it on the front). The value helps to identify posession of the card as it is not available within the chip or magnetic swipe.  When forwarding the CSC, please ensure the value is a string as some values start with 0 and this will be stripped out by any integer parsing.  The CSC number aids fraud prevention in Mail Order and Internet payments.   Business rules are available on your account to identify whether to accept or decline transactions based on mismatched results of the CSC.  The Payment Card Industry (PCI) requires that at no stage of a transaction should the CSC be stored. This applies to all entities handling card data. It should also not be used in any hashing process. CityPay do not store the value and have no method of retrieving the value once the transaction has been processed. For this reason, duplicate checking is unable to determine the CSC in its duplication check algorithm. 
        /// </summary>
        /// <value>The Card Security Code (CSC) (also known as CV2/CVV2) is normally found on the back of the card (American Express has it on the front). The value helps to identify posession of the card as it is not available within the chip or magnetic swipe.  When forwarding the CSC, please ensure the value is a string as some values start with 0 and this will be stripped out by any integer parsing.  The CSC number aids fraud prevention in Mail Order and Internet payments.   Business rules are available on your account to identify whether to accept or decline transactions based on mismatched results of the CSC.  The Payment Card Industry (PCI) requires that at no stage of a transaction should the CSC be stored. This applies to all entities handling card data. It should also not be used in any hashing process. CityPay do not store the value and have no method of retrieving the value once the transaction has been processed. For this reason, duplicate checking is unable to determine the CSC in its duplication check algorithm. </value>
        [DataMember(Name="csc", EmitDefaultValue=false)]
        public string Csc { get; set; }

        /// <summary>
        /// A policy value which determines whether a CSC policy is enforced or bypassed.  Values are  &#x60;0&#x60; for the default policy (default value if not supplied). Your default values are determined by your account manager on setup of the account.  &#x60;1&#x60; for an enforced policy. Transactions that are enforced will be rejected if the CSC value does not match.  &#x60;2&#x60; to bypass. Transactions that are bypassed will be allowed through even if the CSC did not match.  &#x60;3&#x60; to ignore. Transactions that are ignored will bypass the result and not send the CSC details for authorisation. 
        /// </summary>
        /// <value>A policy value which determines whether a CSC policy is enforced or bypassed.  Values are  &#x60;0&#x60; for the default policy (default value if not supplied). Your default values are determined by your account manager on setup of the account.  &#x60;1&#x60; for an enforced policy. Transactions that are enforced will be rejected if the CSC value does not match.  &#x60;2&#x60; to bypass. Transactions that are bypassed will be allowed through even if the CSC did not match.  &#x60;3&#x60; to ignore. Transactions that are ignored will bypass the result and not send the CSC details for authorisation. </value>
        [DataMember(Name="csc_policy", EmitDefaultValue=false)]
        public string CscPolicy { get; set; }

        /// <summary>
        /// The processing currency for the transaction. Will default to the merchant account currency.
        /// </summary>
        /// <value>The processing currency for the transaction. Will default to the merchant account currency.</value>
        [DataMember(Name="currency", EmitDefaultValue=false)]
        public string Currency { get; set; }

        /// <summary>
        /// A policy value which determines whether a duplication policy is enforced or bypassed. A duplication check has a window of time set against your account within which it can action. If a previous transaction with matching values occurred within the window, any subsequent transaction will result in a T001 result.  Values are  &#x60;0&#x60; for the default policy (default value if not supplied). Your default values are determined by your account manager on setup of the account.  &#x60;1&#x60; for an enforced policy. Transactions that are enforced will be checked for duplication within the duplication window.  &#x60;2&#x60; to bypass. Transactions that are bypassed will not be checked for duplication within the duplication window.  &#x60;3&#x60; to ignore. Transactions that are ignored will have the same affect as bypass. 
        /// </summary>
        /// <value>A policy value which determines whether a duplication policy is enforced or bypassed. A duplication check has a window of time set against your account within which it can action. If a previous transaction with matching values occurred within the window, any subsequent transaction will result in a T001 result.  Values are  &#x60;0&#x60; for the default policy (default value if not supplied). Your default values are determined by your account manager on setup of the account.  &#x60;1&#x60; for an enforced policy. Transactions that are enforced will be checked for duplication within the duplication window.  &#x60;2&#x60; to bypass. Transactions that are bypassed will not be checked for duplication within the duplication window.  &#x60;3&#x60; to ignore. Transactions that are ignored will have the same affect as bypass. </value>
        [DataMember(Name="duplicate_policy", EmitDefaultValue=false)]
        public string DuplicatePolicy { get; set; }

        /// <summary>
        /// The identifier of the transaction to process. The value should be a valid reference and may be used to perform  post processing actions and to aid in reconciliation of transactions.  The value should be a valid printable string with ASCII character ranges from 0x32 to 0x127.  The identifier is recommended to be distinct for each transaction such as a [random unique identifier](https://en.wikipedia.org/wiki/Universally_unique_identifier) this will aid in ensuring each transaction is identifiable.  When transactions are processed they are also checked for duplicate requests. Changing the identifier on a subsequent request will ensure that a transaction is considered as different. 
        /// </summary>
        /// <value>The identifier of the transaction to process. The value should be a valid reference and may be used to perform  post processing actions and to aid in reconciliation of transactions.  The value should be a valid printable string with ASCII character ranges from 0x32 to 0x127.  The identifier is recommended to be distinct for each transaction such as a [random unique identifier](https://en.wikipedia.org/wiki/Universally_unique_identifier) this will aid in ensuring each transaction is identifiable.  When transactions are processed they are also checked for duplicate requests. Changing the identifier on a subsequent request will ensure that a transaction is considered as different. </value>
        [DataMember(Name="identifier", EmitDefaultValue=false)]
        public string Identifier { get; set; }

        /// <summary>
        /// A policy value which determines whether an AVS address policy is enforced, bypassed or ignored.   Values are  &#x60;0&#x60; for the default policy (default value if not supplied). Your default values are determined by your account manager on setup of the account.  &#x60;1&#x60; for an enforced policy. Transactions that are enforced will be rejected if the AVS address numeric value does not match.  &#x60;2&#x60; to bypass. Transactions that are bypassed will be allowed through even if the address did not match.  &#x60;3&#x60; to ignore. Transactions that are ignored will bypass the result and not send address numeric details for authorisation. 
        /// </summary>
        /// <value>A policy value which determines whether an AVS address policy is enforced, bypassed or ignored.   Values are  &#x60;0&#x60; for the default policy (default value if not supplied). Your default values are determined by your account manager on setup of the account.  &#x60;1&#x60; for an enforced policy. Transactions that are enforced will be rejected if the AVS address numeric value does not match.  &#x60;2&#x60; to bypass. Transactions that are bypassed will be allowed through even if the address did not match.  &#x60;3&#x60; to ignore. Transactions that are ignored will bypass the result and not send address numeric details for authorisation. </value>
        [DataMember(Name="match_avsa", EmitDefaultValue=false)]
        public string MatchAvsa { get; set; }

        /// <summary>
        /// Identifies the merchant account to perform processing for.
        /// </summary>
        /// <value>Identifies the merchant account to perform processing for.</value>
        [DataMember(Name="merchantid", EmitDefaultValue=false)]
        public int Merchantid { get; set; }

        /// <summary>
        /// Gets or Sets Threedsecure
        /// </summary>
        [DataMember(Name="threedsecure", EmitDefaultValue=false)]
        public ThreeDSecure Threedsecure { get; set; }

        /// <summary>
        /// A tokenised form of a card that belongs to a card holder&#39;s account and that has been previously registered. The token is time based and will only be active for a short duration. The value is therefore designed not to be stored remotely for future  use.  Tokens will start with ct and are resiliently tamper proof using HMacSHA-256. No sensitive card data is stored internally within the token.  Each card will contain a different token and the value may be different on any retrieval call.  The value can be presented for payment as a selection value to an end user in a web application. 
        /// </summary>
        /// <value>A tokenised form of a card that belongs to a card holder&#39;s account and that has been previously registered. The token is time based and will only be active for a short duration. The value is therefore designed not to be stored remotely for future  use.  Tokens will start with ct and are resiliently tamper proof using HMacSHA-256. No sensitive card data is stored internally within the token.  Each card will contain a different token and the value may be different on any retrieval call.  The value can be presented for payment as a selection value to an end user in a web application. </value>
        [DataMember(Name="token", EmitDefaultValue=false)]
        public string Token { get; set; }

        /// <summary>
        /// Further information that can be added to the transaction will display in reporting. Can be used for flexible values such as operator id.
        /// </summary>
        /// <value>Further information that can be added to the transaction will display in reporting. Can be used for flexible values such as operator id.</value>
        [DataMember(Name="trans_info", EmitDefaultValue=false)]
        public string TransInfo { get; set; }

        /// <summary>
        /// The type of transaction being submitted. Normally this value is not required and your account manager may request that you set this field.
        /// </summary>
        /// <value>The type of transaction being submitted. Normally this value is not required and your account manager may request that you set this field.</value>
        [DataMember(Name="trans_type", EmitDefaultValue=false)]
        public string TransType { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ChargeRequest {\n");
            sb.Append("  Amount: ").Append(Amount).Append("\n");
            sb.Append("  AvsPostcodePolicy: ").Append(AvsPostcodePolicy).Append("\n");
            sb.Append("  Csc: ").Append(Csc).Append("\n");
            sb.Append("  CscPolicy: ").Append(CscPolicy).Append("\n");
            sb.Append("  Currency: ").Append(Currency).Append("\n");
            sb.Append("  DuplicatePolicy: ").Append(DuplicatePolicy).Append("\n");
            sb.Append("  Identifier: ").Append(Identifier).Append("\n");
            sb.Append("  MatchAvsa: ").Append(MatchAvsa).Append("\n");
            sb.Append("  Merchantid: ").Append(Merchantid).Append("\n");
            sb.Append("  Threedsecure: ").Append(Threedsecure).Append("\n");
            sb.Append("  Token: ").Append(Token).Append("\n");
            sb.Append("  TransInfo: ").Append(TransInfo).Append("\n");
            sb.Append("  TransType: ").Append(TransType).Append("\n");
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
            return this.Equals(input as ChargeRequest);
        }

        /// <summary>
        /// Returns true if ChargeRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of ChargeRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ChargeRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Amount == input.Amount ||
                    this.Amount.Equals(input.Amount)
                ) && 
                (
                    this.AvsPostcodePolicy == input.AvsPostcodePolicy ||
                    (this.AvsPostcodePolicy != null &&
                    this.AvsPostcodePolicy.Equals(input.AvsPostcodePolicy))
                ) && 
                (
                    this.Csc == input.Csc ||
                    (this.Csc != null &&
                    this.Csc.Equals(input.Csc))
                ) && 
                (
                    this.CscPolicy == input.CscPolicy ||
                    (this.CscPolicy != null &&
                    this.CscPolicy.Equals(input.CscPolicy))
                ) && 
                (
                    this.Currency == input.Currency ||
                    (this.Currency != null &&
                    this.Currency.Equals(input.Currency))
                ) && 
                (
                    this.DuplicatePolicy == input.DuplicatePolicy ||
                    (this.DuplicatePolicy != null &&
                    this.DuplicatePolicy.Equals(input.DuplicatePolicy))
                ) && 
                (
                    this.Identifier == input.Identifier ||
                    (this.Identifier != null &&
                    this.Identifier.Equals(input.Identifier))
                ) && 
                (
                    this.MatchAvsa == input.MatchAvsa ||
                    (this.MatchAvsa != null &&
                    this.MatchAvsa.Equals(input.MatchAvsa))
                ) && 
                (
                    this.Merchantid == input.Merchantid ||
                    this.Merchantid.Equals(input.Merchantid)
                ) && 
                (
                    this.Threedsecure == input.Threedsecure ||
                    (this.Threedsecure != null &&
                    this.Threedsecure.Equals(input.Threedsecure))
                ) && 
                (
                    this.Token == input.Token ||
                    (this.Token != null &&
                    this.Token.Equals(input.Token))
                ) && 
                (
                    this.TransInfo == input.TransInfo ||
                    (this.TransInfo != null &&
                    this.TransInfo.Equals(input.TransInfo))
                ) && 
                (
                    this.TransType == input.TransType ||
                    (this.TransType != null &&
                    this.TransType.Equals(input.TransType))
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
                hashCode = hashCode * 59 + this.Amount.GetHashCode();
                if (this.AvsPostcodePolicy != null)
                    hashCode = hashCode * 59 + this.AvsPostcodePolicy.GetHashCode();
                if (this.Csc != null)
                    hashCode = hashCode * 59 + this.Csc.GetHashCode();
                if (this.CscPolicy != null)
                    hashCode = hashCode * 59 + this.CscPolicy.GetHashCode();
                if (this.Currency != null)
                    hashCode = hashCode * 59 + this.Currency.GetHashCode();
                if (this.DuplicatePolicy != null)
                    hashCode = hashCode * 59 + this.DuplicatePolicy.GetHashCode();
                if (this.Identifier != null)
                    hashCode = hashCode * 59 + this.Identifier.GetHashCode();
                if (this.MatchAvsa != null)
                    hashCode = hashCode * 59 + this.MatchAvsa.GetHashCode();
                hashCode = hashCode * 59 + this.Merchantid.GetHashCode();
                if (this.Threedsecure != null)
                    hashCode = hashCode * 59 + this.Threedsecure.GetHashCode();
                if (this.Token != null)
                    hashCode = hashCode * 59 + this.Token.GetHashCode();
                if (this.TransInfo != null)
                    hashCode = hashCode * 59 + this.TransInfo.GetHashCode();
                if (this.TransType != null)
                    hashCode = hashCode * 59 + this.TransType.GetHashCode();
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
            // Csc (string) maxLength
            if(this.Csc != null && this.Csc.Length > 4)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Csc, length must be less than 4.", new [] { "Csc" });
            }

            // Csc (string) minLength
            if(this.Csc != null && this.Csc.Length < 3)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Csc, length must be greater than 3.", new [] { "Csc" });
            }

            // Currency (string) maxLength
            if(this.Currency != null && this.Currency.Length > 3)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Currency, length must be less than 3.", new [] { "Currency" });
            }

            // Currency (string) minLength
            if(this.Currency != null && this.Currency.Length < 3)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Currency, length must be greater than 3.", new [] { "Currency" });
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

            // TransInfo (string) maxLength
            if(this.TransInfo != null && this.TransInfo.Length > 50)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for TransInfo, length must be less than 50.", new [] { "TransInfo" });
            }

            // TransType (string) maxLength
            if(this.TransType != null && this.TransType.Length > 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for TransType, length must be less than 1.", new [] { "TransType" });
            }

            yield break;
        }
    }

}
