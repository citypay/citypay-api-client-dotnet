/*
 * CityPay Payment API
 *
 *  This CityPay API is a HTTP RESTful payment API used for direct server to server transactional processing. It provides a number of payment mechanisms including: Internet, MOTO, Continuous Authority transaction processing, 3-D Secure decision handling using RFA Secure, Authorisation, Refunding, Pre-Authorisation, Cancellation/Voids and Completion processing. The API is also capable of tokinsed payments using Card Holder Accounts.  ## Compliance and Security <aside class=\"notice\">   Before we begin a reminder that your application will need to adhere to PCI-DSS standards to operate safely   and to meet requirements set out by Visa and MasterCard and the PCI Security Standards Council including: </aside>  * Data must be collected using TLS version 1.2 using [strong cryptography](#enabled-tls-ciphers). We will not accept calls to our API at   lower grade encryption levels. We regularly scan our TLS endpoints for vulnerabilities and perform TLS assessments   as part of our compliance program. * The application must not store sensitive card holder data (CHD) such as the card security code (CSC) or   primary access number (PAN) * The application must not display the full card number on receipts, it is recommended to mask the PAN   and show the last 4 digits. The API will return this for you for ease of receipt creation * If you are developing a website, you will be required to perform regular scans on the network where you host the   application to meet your compliance obligations * You will be required to be PCI Compliant and the application must adhere to the security standard. Further information   is available from [https://www.pcisecuritystandards.org/](https://www.pcisecuritystandards.org/) * The API verifies that the request is for a valid account and originates from a trusted source using the remote IP   address. Our application firewalls analyse data that may be an attempt to break a large number of security common   security vulnerabilities. 
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
    /// ProcessBatchRequest
    /// </summary>
    [DataContract(Name = "ProcessBatchRequest")]
    public partial class ProcessBatchRequest : IEquatable<ProcessBatchRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ProcessBatchRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ProcessBatchRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ProcessBatchRequest" /> class.
        /// </summary>
        /// <param name="batchDate">The date and time that the file was created in ISO-8601 format. (required).</param>
        /// <param name="batchId">The id is a referencable id for the batch that should be generated by your integration. Its recommended to use an incremental id to help determine if a batch has been skipped or missed. The id is used by reporting systems to reference the unique batch alongside your client id.  (required).</param>
        /// <param name="clientAccountId">The batch account id to process the batch for. Defaults to your client id if not provided..</param>
        /// <param name="transactions">transactions (required).</param>
        public ProcessBatchRequest(DateTime batchDate = default(DateTime), int batchId = default(int), string clientAccountId = default(string), List<BatchTransaction> transactions = default(List<BatchTransaction>))
        {
            this.BatchDate = batchDate;
            this.BatchId = batchId;
            // to ensure "transactions" is required (not null)
            this.Transactions = transactions ?? throw new ArgumentNullException("transactions is a required property for ProcessBatchRequest and cannot be null");
            this.ClientAccountId = clientAccountId;
        }

        /// <summary>
        /// The date and time that the file was created in ISO-8601 format.
        /// </summary>
        /// <value>The date and time that the file was created in ISO-8601 format.</value>
        [DataMember(Name = "batch_date", IsRequired = true, EmitDefaultValue = false)]
        [JsonConverter(typeof(OpenAPIDateConverter))]
        public DateTime BatchDate { get; set; }

        /// <summary>
        /// The id is a referencable id for the batch that should be generated by your integration. Its recommended to use an incremental id to help determine if a batch has been skipped or missed. The id is used by reporting systems to reference the unique batch alongside your client id. 
        /// </summary>
        /// <value>The id is a referencable id for the batch that should be generated by your integration. Its recommended to use an incremental id to help determine if a batch has been skipped or missed. The id is used by reporting systems to reference the unique batch alongside your client id. </value>
        [DataMember(Name = "batch_id", IsRequired = true, EmitDefaultValue = false)]
        public int BatchId { get; set; }

        /// <summary>
        /// The batch account id to process the batch for. Defaults to your client id if not provided.
        /// </summary>
        /// <value>The batch account id to process the batch for. Defaults to your client id if not provided.</value>
        [DataMember(Name = "client_account_id", EmitDefaultValue = false)]
        public string ClientAccountId { get; set; }

        /// <summary>
        /// Gets or Sets Transactions
        /// </summary>
        [DataMember(Name = "transactions", IsRequired = true, EmitDefaultValue = false)]
        public List<BatchTransaction> Transactions { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ProcessBatchRequest {\n");
            sb.Append("  BatchDate: ").Append(BatchDate).Append("\n");
            sb.Append("  BatchId: ").Append(BatchId).Append("\n");
            sb.Append("  ClientAccountId: ").Append(ClientAccountId).Append("\n");
            sb.Append("  Transactions: ").Append(Transactions).Append("\n");
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
            return this.Equals(input as ProcessBatchRequest);
        }

        /// <summary>
        /// Returns true if ProcessBatchRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of ProcessBatchRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ProcessBatchRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.BatchDate == input.BatchDate ||
                    (this.BatchDate != null &&
                    this.BatchDate.Equals(input.BatchDate))
                ) && 
                (
                    this.BatchId == input.BatchId ||
                    this.BatchId.Equals(input.BatchId)
                ) && 
                (
                    this.ClientAccountId == input.ClientAccountId ||
                    (this.ClientAccountId != null &&
                    this.ClientAccountId.Equals(input.ClientAccountId))
                ) && 
                (
                    this.Transactions == input.Transactions ||
                    this.Transactions != null &&
                    input.Transactions != null &&
                    this.Transactions.SequenceEqual(input.Transactions)
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
                if (this.BatchDate != null)
                    hashCode = hashCode * 59 + this.BatchDate.GetHashCode();
                hashCode = hashCode * 59 + this.BatchId.GetHashCode();
                if (this.ClientAccountId != null)
                    hashCode = hashCode * 59 + this.ClientAccountId.GetHashCode();
                if (this.Transactions != null)
                    hashCode = hashCode * 59 + this.Transactions.GetHashCode();
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
            // BatchId (int) minimum
            if(this.BatchId < (int)1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for BatchId, must be a value greater than or equal to 1.", new [] { "BatchId" });
            }

            // ClientAccountId (string) maxLength
            if(this.ClientAccountId != null && this.ClientAccountId.Length > 20)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ClientAccountId, length must be less than 20.", new [] { "ClientAccountId" });
            }

            // ClientAccountId (string) minLength
            if(this.ClientAccountId != null && this.ClientAccountId.Length < 3)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ClientAccountId, length must be greater than 3.", new [] { "ClientAccountId" });
            }

            yield break;
        }
    }

}
