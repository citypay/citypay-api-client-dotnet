/* 
 * CityPay Payment API
 *
 *  This CityPay API is a HTTP RESTful payment API used for direct server to server transactional processing. It provides a number of payment mechanisms including: Internet, MOTO, Continuous Authority transaction processing, 3-D Secure decision handling using RFA Secure, Authorisation, Refunding, Pre-Authorisation, Cancellation/Voids and Completion processing. The API is also capable of tokinsed payments using Card Holder Accounts.  ## Compliance and Security <aside class=\"notice\">   Before we begin a reminder that your application will need to adhere to PCI-DSS standards to operate safely   and to meet requirements set out by Visa and MasterCard and the PCI Security Standards Council including: </aside>  * Data must be collected using TLS version 1.2 using [strong cryptography](#enabled-tls-ciphers). We will not accept calls to our API at   lower grade encryption levels. We regularly scan our TLS endpoints for vulnerabilities and perform TLS assessments   as part of our compliance program. * The application must not store sensitive card holder data (CHD) such as the card security code (CSC) or   primary access number (PAN) * The application must not display the full card number on receipts, it is recommended to mask the PAN   and show the last 4 digits. The API will return this for you for ease of receipt creation * If you are developing a website, you will be required to perform regular scans on the network where you host the   application to meet your compliance obligations * You will be required to be PCI Compliant and the application must adhere to the security standard. Further information   is available from [https://www.pcisecuritystandards.org/](https://www.pcisecuritystandards.org/) * The API verifies that the request is for a valid account and originates from a trusted source using the remote IP   address. Our application firewalls analyse data that may be an attempt to break a large number of security common   security vulnerabilities. 
 *
 * The version of the OpenAPI document: 6.0.0
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
    /// ContactDetails
    /// </summary>
    [DataContract]
    public partial class ContactDetails :  IEquatable<ContactDetails>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ContactDetails" /> class.
        /// </summary>
        /// <param name="address1">The first line of the address for the card holder..</param>
        /// <param name="address2">The second line of the address for the card holder..</param>
        /// <param name="address3">The third line of the address for the card holder..</param>
        /// <param name="area">The area such as city, department, parish for the card holder..</param>
        /// <param name="company">The company name for the card holder if the contact is a corporate contact..</param>
        /// <param name="country">The country code in ISO 3166 format. The country value may be used for fraud analysis and for   acceptance of the transaction. .</param>
        /// <param name="email">An email address for the card holder which may be used for correspondence..</param>
        /// <param name="firstname">The first name  of the card holder..</param>
        /// <param name="lastname">The last name or surname of the card holder..</param>
        /// <param name="mobileNo">A mobile number for the card holder the mobile number is often required by delivery companies to ensure they are able to be in contact when required..</param>
        /// <param name="postcode">The postcode or zip code of the address which may be used for fraud analysis..</param>
        /// <param name="telephoneNo">A telephone number for the card holder..</param>
        /// <param name="title">A title for the card holder such as Mr, Mrs, Ms, M. Mme. etc..</param>
        public ContactDetails(string address1 = default(string), string address2 = default(string), string address3 = default(string), string area = default(string), string company = default(string), string country = default(string), string email = default(string), string firstname = default(string), string lastname = default(string), string mobileNo = default(string), string postcode = default(string), string telephoneNo = default(string), string title = default(string))
        {
            this.Address1 = address1;
            this.Address2 = address2;
            this.Address3 = address3;
            this.Area = area;
            this.Company = company;
            this.Country = country;
            this.Email = email;
            this.Firstname = firstname;
            this.Lastname = lastname;
            this.MobileNo = mobileNo;
            this.Postcode = postcode;
            this.TelephoneNo = telephoneNo;
            this.Title = title;
        }
        
        /// <summary>
        /// The first line of the address for the card holder.
        /// </summary>
        /// <value>The first line of the address for the card holder.</value>
        [DataMember(Name="address1", EmitDefaultValue=false)]
        public string Address1 { get; set; }

        /// <summary>
        /// The second line of the address for the card holder.
        /// </summary>
        /// <value>The second line of the address for the card holder.</value>
        [DataMember(Name="address2", EmitDefaultValue=false)]
        public string Address2 { get; set; }

        /// <summary>
        /// The third line of the address for the card holder.
        /// </summary>
        /// <value>The third line of the address for the card holder.</value>
        [DataMember(Name="address3", EmitDefaultValue=false)]
        public string Address3 { get; set; }

        /// <summary>
        /// The area such as city, department, parish for the card holder.
        /// </summary>
        /// <value>The area such as city, department, parish for the card holder.</value>
        [DataMember(Name="area", EmitDefaultValue=false)]
        public string Area { get; set; }

        /// <summary>
        /// The company name for the card holder if the contact is a corporate contact.
        /// </summary>
        /// <value>The company name for the card holder if the contact is a corporate contact.</value>
        [DataMember(Name="company", EmitDefaultValue=false)]
        public string Company { get; set; }

        /// <summary>
        /// The country code in ISO 3166 format. The country value may be used for fraud analysis and for   acceptance of the transaction. 
        /// </summary>
        /// <value>The country code in ISO 3166 format. The country value may be used for fraud analysis and for   acceptance of the transaction. </value>
        [DataMember(Name="country", EmitDefaultValue=false)]
        public string Country { get; set; }

        /// <summary>
        /// An email address for the card holder which may be used for correspondence.
        /// </summary>
        /// <value>An email address for the card holder which may be used for correspondence.</value>
        [DataMember(Name="email", EmitDefaultValue=false)]
        public string Email { get; set; }

        /// <summary>
        /// The first name  of the card holder.
        /// </summary>
        /// <value>The first name  of the card holder.</value>
        [DataMember(Name="firstname", EmitDefaultValue=false)]
        public string Firstname { get; set; }

        /// <summary>
        /// The last name or surname of the card holder.
        /// </summary>
        /// <value>The last name or surname of the card holder.</value>
        [DataMember(Name="lastname", EmitDefaultValue=false)]
        public string Lastname { get; set; }

        /// <summary>
        /// A mobile number for the card holder the mobile number is often required by delivery companies to ensure they are able to be in contact when required.
        /// </summary>
        /// <value>A mobile number for the card holder the mobile number is often required by delivery companies to ensure they are able to be in contact when required.</value>
        [DataMember(Name="mobile_no", EmitDefaultValue=false)]
        public string MobileNo { get; set; }

        /// <summary>
        /// The postcode or zip code of the address which may be used for fraud analysis.
        /// </summary>
        /// <value>The postcode or zip code of the address which may be used for fraud analysis.</value>
        [DataMember(Name="postcode", EmitDefaultValue=false)]
        public string Postcode { get; set; }

        /// <summary>
        /// A telephone number for the card holder.
        /// </summary>
        /// <value>A telephone number for the card holder.</value>
        [DataMember(Name="telephone_no", EmitDefaultValue=false)]
        public string TelephoneNo { get; set; }

        /// <summary>
        /// A title for the card holder such as Mr, Mrs, Ms, M. Mme. etc.
        /// </summary>
        /// <value>A title for the card holder such as Mr, Mrs, Ms, M. Mme. etc.</value>
        [DataMember(Name="title", EmitDefaultValue=false)]
        public string Title { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ContactDetails {\n");
            sb.Append("  Address1: ").Append(Address1).Append("\n");
            sb.Append("  Address2: ").Append(Address2).Append("\n");
            sb.Append("  Address3: ").Append(Address3).Append("\n");
            sb.Append("  Area: ").Append(Area).Append("\n");
            sb.Append("  Company: ").Append(Company).Append("\n");
            sb.Append("  Country: ").Append(Country).Append("\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
            sb.Append("  Firstname: ").Append(Firstname).Append("\n");
            sb.Append("  Lastname: ").Append(Lastname).Append("\n");
            sb.Append("  MobileNo: ").Append(MobileNo).Append("\n");
            sb.Append("  Postcode: ").Append(Postcode).Append("\n");
            sb.Append("  TelephoneNo: ").Append(TelephoneNo).Append("\n");
            sb.Append("  Title: ").Append(Title).Append("\n");
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
            return this.Equals(input as ContactDetails);
        }

        /// <summary>
        /// Returns true if ContactDetails instances are equal
        /// </summary>
        /// <param name="input">Instance of ContactDetails to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ContactDetails input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Address1 == input.Address1 ||
                    (this.Address1 != null &&
                    this.Address1.Equals(input.Address1))
                ) && 
                (
                    this.Address2 == input.Address2 ||
                    (this.Address2 != null &&
                    this.Address2.Equals(input.Address2))
                ) && 
                (
                    this.Address3 == input.Address3 ||
                    (this.Address3 != null &&
                    this.Address3.Equals(input.Address3))
                ) && 
                (
                    this.Area == input.Area ||
                    (this.Area != null &&
                    this.Area.Equals(input.Area))
                ) && 
                (
                    this.Company == input.Company ||
                    (this.Company != null &&
                    this.Company.Equals(input.Company))
                ) && 
                (
                    this.Country == input.Country ||
                    (this.Country != null &&
                    this.Country.Equals(input.Country))
                ) && 
                (
                    this.Email == input.Email ||
                    (this.Email != null &&
                    this.Email.Equals(input.Email))
                ) && 
                (
                    this.Firstname == input.Firstname ||
                    (this.Firstname != null &&
                    this.Firstname.Equals(input.Firstname))
                ) && 
                (
                    this.Lastname == input.Lastname ||
                    (this.Lastname != null &&
                    this.Lastname.Equals(input.Lastname))
                ) && 
                (
                    this.MobileNo == input.MobileNo ||
                    (this.MobileNo != null &&
                    this.MobileNo.Equals(input.MobileNo))
                ) && 
                (
                    this.Postcode == input.Postcode ||
                    (this.Postcode != null &&
                    this.Postcode.Equals(input.Postcode))
                ) && 
                (
                    this.TelephoneNo == input.TelephoneNo ||
                    (this.TelephoneNo != null &&
                    this.TelephoneNo.Equals(input.TelephoneNo))
                ) && 
                (
                    this.Title == input.Title ||
                    (this.Title != null &&
                    this.Title.Equals(input.Title))
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
                if (this.Address1 != null)
                    hashCode = hashCode * 59 + this.Address1.GetHashCode();
                if (this.Address2 != null)
                    hashCode = hashCode * 59 + this.Address2.GetHashCode();
                if (this.Address3 != null)
                    hashCode = hashCode * 59 + this.Address3.GetHashCode();
                if (this.Area != null)
                    hashCode = hashCode * 59 + this.Area.GetHashCode();
                if (this.Company != null)
                    hashCode = hashCode * 59 + this.Company.GetHashCode();
                if (this.Country != null)
                    hashCode = hashCode * 59 + this.Country.GetHashCode();
                if (this.Email != null)
                    hashCode = hashCode * 59 + this.Email.GetHashCode();
                if (this.Firstname != null)
                    hashCode = hashCode * 59 + this.Firstname.GetHashCode();
                if (this.Lastname != null)
                    hashCode = hashCode * 59 + this.Lastname.GetHashCode();
                if (this.MobileNo != null)
                    hashCode = hashCode * 59 + this.MobileNo.GetHashCode();
                if (this.Postcode != null)
                    hashCode = hashCode * 59 + this.Postcode.GetHashCode();
                if (this.TelephoneNo != null)
                    hashCode = hashCode * 59 + this.TelephoneNo.GetHashCode();
                if (this.Title != null)
                    hashCode = hashCode * 59 + this.Title.GetHashCode();
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
            // Address1 (string) maxLength
            if(this.Address1 != null && this.Address1.Length > 40)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Address1, length must be less than 40.", new [] { "Address1" });
            }

            // Address2 (string) maxLength
            if(this.Address2 != null && this.Address2.Length > 30)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Address2, length must be less than 30.", new [] { "Address2" });
            }

            // Address3 (string) maxLength
            if(this.Address3 != null && this.Address3.Length > 20)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Address3, length must be less than 20.", new [] { "Address3" });
            }

            // Area (string) maxLength
            if(this.Area != null && this.Area.Length > 20)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Area, length must be less than 20.", new [] { "Area" });
            }

            // Country (string) maxLength
            if(this.Country != null && this.Country.Length > 2)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Country, length must be less than 2.", new [] { "Country" });
            }

            // Country (string) minLength
            if(this.Country != null && this.Country.Length < 2)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Country, length must be greater than 2.", new [] { "Country" });
            }

            // MobileNo (string) maxLength
            if(this.MobileNo != null && this.MobileNo.Length > 20)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for MobileNo, length must be less than 20.", new [] { "MobileNo" });
            }

            // Postcode (string) maxLength
            if(this.Postcode != null && this.Postcode.Length > 10)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Postcode, length must be less than 10.", new [] { "Postcode" });
            }

            // TelephoneNo (string) maxLength
            if(this.TelephoneNo != null && this.TelephoneNo.Length > 20)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for TelephoneNo, length must be less than 20.", new [] { "TelephoneNo" });
            }

            yield break;
        }
    }

}
