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
    /// PaylinkBillPaymentTokenRequest
    /// </summary>
    [DataContract(Name = "PaylinkBillPaymentTokenRequest")]
    public partial class PaylinkBillPaymentTokenRequest : IEquatable<PaylinkBillPaymentTokenRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PaylinkBillPaymentTokenRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected PaylinkBillPaymentTokenRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="PaylinkBillPaymentTokenRequest" /> class.
        /// </summary>
        /// <param name="addressee">Who the bill payment request intended for. This should be a readable name such as a person or company..</param>
        /// <param name="attachments">attachments.</param>
        /// <param name="descriptor">A descriptor for the bill payment used to describe what the payment request is for for instance \&quot;Invoice\&quot;.  The descriptor can be used as descriptive text on emails or the payment page. For instance an invoice may have a button saying \&quot;View Invoice\&quot; or an email may say \&quot;to pay your Invoice online\&quot;. .</param>
        /// <param name="due">A date that the invoice is due. This can be displayed on the payment page..</param>
        /// <param name="emailNotificationPath">emailNotificationPath.</param>
        /// <param name="memo">A memo that can be added to the payment page and email to provide to the customer..</param>
        /// <param name="request">request (required).</param>
        /// <param name="smsNotificationPath">smsNotificationPath.</param>
        public PaylinkBillPaymentTokenRequest(string addressee = default(string), List<PaylinkAttachmentRequest> attachments = default(List<PaylinkAttachmentRequest>), string descriptor = default(string), DateTime due = default(DateTime), PaylinkEmailNotificationPath emailNotificationPath = default(PaylinkEmailNotificationPath), string memo = default(string), PaylinkTokenRequestModel request = default(PaylinkTokenRequestModel), PaylinkSMSNotificationPath smsNotificationPath = default(PaylinkSMSNotificationPath))
        {
            // to ensure "request" is required (not null)
            if (request == null)
            {
                throw new ArgumentNullException("request is a required property for PaylinkBillPaymentTokenRequest and cannot be null");
            }
            this.Request = request;
            this.Addressee = addressee;
            this.Attachments = attachments;
            this.Descriptor = descriptor;
            this.Due = due;
            this.EmailNotificationPath = emailNotificationPath;
            this.Memo = memo;
            this.SmsNotificationPath = smsNotificationPath;
        }

        /// <summary>
        /// Who the bill payment request intended for. This should be a readable name such as a person or company.
        /// </summary>
        /// <value>Who the bill payment request intended for. This should be a readable name such as a person or company.</value>
        [DataMember(Name = "addressee", EmitDefaultValue = false)]
        public string Addressee { get; set; }

        /// <summary>
        /// Gets or Sets Attachments
        /// </summary>
        [DataMember(Name = "attachments", EmitDefaultValue = false)]
        public List<PaylinkAttachmentRequest> Attachments { get; set; }

        /// <summary>
        /// A descriptor for the bill payment used to describe what the payment request is for for instance \&quot;Invoice\&quot;.  The descriptor can be used as descriptive text on emails or the payment page. For instance an invoice may have a button saying \&quot;View Invoice\&quot; or an email may say \&quot;to pay your Invoice online\&quot;. 
        /// </summary>
        /// <value>A descriptor for the bill payment used to describe what the payment request is for for instance \&quot;Invoice\&quot;.  The descriptor can be used as descriptive text on emails or the payment page. For instance an invoice may have a button saying \&quot;View Invoice\&quot; or an email may say \&quot;to pay your Invoice online\&quot;. </value>
        [DataMember(Name = "descriptor", EmitDefaultValue = false)]
        public string Descriptor { get; set; }

        /// <summary>
        /// A date that the invoice is due. This can be displayed on the payment page.
        /// </summary>
        /// <value>A date that the invoice is due. This can be displayed on the payment page.</value>
        [DataMember(Name = "due", EmitDefaultValue = false)]
        [JsonConverter(typeof(OpenAPIDateConverter))]
        public DateTime Due { get; set; }

        /// <summary>
        /// Gets or Sets EmailNotificationPath
        /// </summary>
        [DataMember(Name = "email_notification_path", EmitDefaultValue = false)]
        public PaylinkEmailNotificationPath EmailNotificationPath { get; set; }

        /// <summary>
        /// A memo that can be added to the payment page and email to provide to the customer.
        /// </summary>
        /// <value>A memo that can be added to the payment page and email to provide to the customer.</value>
        [DataMember(Name = "memo", EmitDefaultValue = false)]
        public string Memo { get; set; }

        /// <summary>
        /// Gets or Sets Request
        /// </summary>
        [DataMember(Name = "request", IsRequired = true, EmitDefaultValue = false)]
        public PaylinkTokenRequestModel Request { get; set; }

        /// <summary>
        /// Gets or Sets SmsNotificationPath
        /// </summary>
        [DataMember(Name = "sms_notification_path", EmitDefaultValue = false)]
        public PaylinkSMSNotificationPath SmsNotificationPath { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class PaylinkBillPaymentTokenRequest {\n");
            sb.Append("  Addressee: ").Append(Addressee).Append("\n");
            sb.Append("  Attachments: ").Append(Attachments).Append("\n");
            sb.Append("  Descriptor: ").Append(Descriptor).Append("\n");
            sb.Append("  Due: ").Append(Due).Append("\n");
            sb.Append("  EmailNotificationPath: ").Append(EmailNotificationPath).Append("\n");
            sb.Append("  Memo: ").Append(Memo).Append("\n");
            sb.Append("  Request: ").Append(Request).Append("\n");
            sb.Append("  SmsNotificationPath: ").Append(SmsNotificationPath).Append("\n");
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
            return this.Equals(input as PaylinkBillPaymentTokenRequest);
        }

        /// <summary>
        /// Returns true if PaylinkBillPaymentTokenRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of PaylinkBillPaymentTokenRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PaylinkBillPaymentTokenRequest input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Addressee == input.Addressee ||
                    (this.Addressee != null &&
                    this.Addressee.Equals(input.Addressee))
                ) && 
                (
                    this.Attachments == input.Attachments ||
                    this.Attachments != null &&
                    input.Attachments != null &&
                    this.Attachments.SequenceEqual(input.Attachments)
                ) && 
                (
                    this.Descriptor == input.Descriptor ||
                    (this.Descriptor != null &&
                    this.Descriptor.Equals(input.Descriptor))
                ) && 
                (
                    this.Due == input.Due ||
                    (this.Due != null &&
                    this.Due.Equals(input.Due))
                ) && 
                (
                    this.EmailNotificationPath == input.EmailNotificationPath ||
                    (this.EmailNotificationPath != null &&
                    this.EmailNotificationPath.Equals(input.EmailNotificationPath))
                ) && 
                (
                    this.Memo == input.Memo ||
                    (this.Memo != null &&
                    this.Memo.Equals(input.Memo))
                ) && 
                (
                    this.Request == input.Request ||
                    (this.Request != null &&
                    this.Request.Equals(input.Request))
                ) && 
                (
                    this.SmsNotificationPath == input.SmsNotificationPath ||
                    (this.SmsNotificationPath != null &&
                    this.SmsNotificationPath.Equals(input.SmsNotificationPath))
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
                if (this.Addressee != null)
                {
                    hashCode = (hashCode * 59) + this.Addressee.GetHashCode();
                }
                if (this.Attachments != null)
                {
                    hashCode = (hashCode * 59) + this.Attachments.GetHashCode();
                }
                if (this.Descriptor != null)
                {
                    hashCode = (hashCode * 59) + this.Descriptor.GetHashCode();
                }
                if (this.Due != null)
                {
                    hashCode = (hashCode * 59) + this.Due.GetHashCode();
                }
                if (this.EmailNotificationPath != null)
                {
                    hashCode = (hashCode * 59) + this.EmailNotificationPath.GetHashCode();
                }
                if (this.Memo != null)
                {
                    hashCode = (hashCode * 59) + this.Memo.GetHashCode();
                }
                if (this.Request != null)
                {
                    hashCode = (hashCode * 59) + this.Request.GetHashCode();
                }
                if (this.SmsNotificationPath != null)
                {
                    hashCode = (hashCode * 59) + this.SmsNotificationPath.GetHashCode();
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
