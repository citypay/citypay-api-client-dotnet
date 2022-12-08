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
    /// BatchReportResponseModel
    /// </summary>
    [DataContract(Name = "BatchReportResponseModel")]
    public partial class BatchReportResponseModel : IEquatable<BatchReportResponseModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BatchReportResponseModel" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected BatchReportResponseModel() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="BatchReportResponseModel" /> class.
        /// </summary>
        /// <param name="amount">The total amount that the batch contains. (required).</param>
        /// <param name="batchDate">The date and time of the batch in ISO-8601 format. (required).</param>
        /// <param name="batchId">The batch id specified in the batch processing request. (required).</param>
        /// <param name="batchStatus">The status of the batch. Possible values are - CANCELLED. The file has been cancelled by an administrator or server process.  - COMPLETE. The file has passed through the processing cycle and is determined as being complete further information should be obtained on the results of the processing - ERROR_IN_PROCESSING. Errors have occurred in the processing that has deemed that processing can not continue. - INITIALISED. The file has been initialised and no action has yet been performed - LOCKED. The file has been locked for processing - QUEUED. The file has been queued for processing yet no processing has yet been performed - UNKNOWN. The file is of an unknown status, that is the file can either not be determined by the information requested of the file has not yet been received.  (required).</param>
        /// <param name="clientAccountId">The batch account id that the batch was processed with. (required).</param>
        /// <param name="transactions">transactions (required).</param>
        public BatchReportResponseModel(int amount = default(int), DateTime batchDate = default(DateTime), int batchId = default(int), string batchStatus = default(string), string clientAccountId = default(string), List<BatchTransactionResultModel> transactions = default(List<BatchTransactionResultModel>))
        {
            this.Amount = amount;
            this.BatchDate = batchDate;
            this.BatchId = batchId;
            // to ensure "batchStatus" is required (not null)
            if (batchStatus == null)
            {
                throw new ArgumentNullException("batchStatus is a required property for BatchReportResponseModel and cannot be null");
            }
            this.BatchStatus = batchStatus;
            // to ensure "clientAccountId" is required (not null)
            if (clientAccountId == null)
            {
                throw new ArgumentNullException("clientAccountId is a required property for BatchReportResponseModel and cannot be null");
            }
            this.ClientAccountId = clientAccountId;
            // to ensure "transactions" is required (not null)
            if (transactions == null)
            {
                throw new ArgumentNullException("transactions is a required property for BatchReportResponseModel and cannot be null");
            }
            this.Transactions = transactions;
        }

        /// <summary>
        /// The total amount that the batch contains.
        /// </summary>
        /// <value>The total amount that the batch contains.</value>
        [DataMember(Name = "amount", IsRequired = true, EmitDefaultValue = false)]
        public int Amount { get; set; }

        /// <summary>
        /// The date and time of the batch in ISO-8601 format.
        /// </summary>
        /// <value>The date and time of the batch in ISO-8601 format.</value>
        [DataMember(Name = "batch_date", IsRequired = true, EmitDefaultValue = false)]
        [JsonConverter(typeof(OpenAPIDateConverter))]
        public DateTime BatchDate { get; set; }

        /// <summary>
        /// The batch id specified in the batch processing request.
        /// </summary>
        /// <value>The batch id specified in the batch processing request.</value>
        [DataMember(Name = "batch_id", IsRequired = true, EmitDefaultValue = false)]
        public int BatchId { get; set; }

        /// <summary>
        /// The status of the batch. Possible values are - CANCELLED. The file has been cancelled by an administrator or server process.  - COMPLETE. The file has passed through the processing cycle and is determined as being complete further information should be obtained on the results of the processing - ERROR_IN_PROCESSING. Errors have occurred in the processing that has deemed that processing can not continue. - INITIALISED. The file has been initialised and no action has yet been performed - LOCKED. The file has been locked for processing - QUEUED. The file has been queued for processing yet no processing has yet been performed - UNKNOWN. The file is of an unknown status, that is the file can either not be determined by the information requested of the file has not yet been received. 
        /// </summary>
        /// <value>The status of the batch. Possible values are - CANCELLED. The file has been cancelled by an administrator or server process.  - COMPLETE. The file has passed through the processing cycle and is determined as being complete further information should be obtained on the results of the processing - ERROR_IN_PROCESSING. Errors have occurred in the processing that has deemed that processing can not continue. - INITIALISED. The file has been initialised and no action has yet been performed - LOCKED. The file has been locked for processing - QUEUED. The file has been queued for processing yet no processing has yet been performed - UNKNOWN. The file is of an unknown status, that is the file can either not be determined by the information requested of the file has not yet been received. </value>
        [DataMember(Name = "batch_status", IsRequired = true, EmitDefaultValue = false)]
        public string BatchStatus { get; set; }

        /// <summary>
        /// The batch account id that the batch was processed with.
        /// </summary>
        /// <value>The batch account id that the batch was processed with.</value>
        [DataMember(Name = "client_account_id", IsRequired = true, EmitDefaultValue = false)]
        public string ClientAccountId { get; set; }

        /// <summary>
        /// Gets or Sets Transactions
        /// </summary>
        [DataMember(Name = "transactions", IsRequired = true, EmitDefaultValue = false)]
        public List<BatchTransactionResultModel> Transactions { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class BatchReportResponseModel {\n");
            sb.Append("  Amount: ").Append(Amount).Append("\n");
            sb.Append("  BatchDate: ").Append(BatchDate).Append("\n");
            sb.Append("  BatchId: ").Append(BatchId).Append("\n");
            sb.Append("  BatchStatus: ").Append(BatchStatus).Append("\n");
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
            return this.Equals(input as BatchReportResponseModel);
        }

        /// <summary>
        /// Returns true if BatchReportResponseModel instances are equal
        /// </summary>
        /// <param name="input">Instance of BatchReportResponseModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BatchReportResponseModel input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Amount == input.Amount ||
                    this.Amount.Equals(input.Amount)
                ) && 
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
                    this.BatchStatus == input.BatchStatus ||
                    (this.BatchStatus != null &&
                    this.BatchStatus.Equals(input.BatchStatus))
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
                hashCode = (hashCode * 59) + this.Amount.GetHashCode();
                if (this.BatchDate != null)
                {
                    hashCode = (hashCode * 59) + this.BatchDate.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.BatchId.GetHashCode();
                if (this.BatchStatus != null)
                {
                    hashCode = (hashCode * 59) + this.BatchStatus.GetHashCode();
                }
                if (this.ClientAccountId != null)
                {
                    hashCode = (hashCode * 59) + this.ClientAccountId.GetHashCode();
                }
                if (this.Transactions != null)
                {
                    hashCode = (hashCode * 59) + this.Transactions.GetHashCode();
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
            // BatchId (int) minimum
            if (this.BatchId < (int)1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for BatchId, must be a value greater than or equal to 1.", new [] { "BatchId" });
            }

            // ClientAccountId (string) maxLength
            if (this.ClientAccountId != null && this.ClientAccountId.Length > 20)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ClientAccountId, length must be less than 20.", new [] { "ClientAccountId" });
            }

            // ClientAccountId (string) minLength
            if (this.ClientAccountId != null && this.ClientAccountId.Length < 3)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ClientAccountId, length must be greater than 3.", new [] { "ClientAccountId" });
            }

            yield break;
        }
    }

}
