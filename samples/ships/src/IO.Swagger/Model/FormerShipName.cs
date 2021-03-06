/* 
 * No description provided (generated by Swagger Codegen https://github.com/swagger-api/swagger-codegen)
 *
 * OpenAPI spec version: 1.0
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
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
using SwaggerDateConverter = IO.Swagger.Client.SwaggerDateConverter;

namespace IO.Swagger.Model
{
    /// <summary>
    /// FormerShipName
    /// </summary>
    [DataContract]
        public partial class FormerShipName :  IEquatable<FormerShipName>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FormerShipName" /> class.
        /// </summary>
        /// <param name="callSign">Previous Call Sign of the ship.</param>
        /// <param name="country">*method&#x3D;POST_OR_PUT*Alpha 3 Code as per ISO 3166-1 alpha-3 codes.</param>
        /// <param name="lastReported">Date the ship was last reported with this name. &lt;br&gt;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;Example Value: 2019-03-14T14:55:00Z specifies a year-month-day followed by 24-hour hours:minutes:seconds in GMT time.</param>
        /// <param name="links">*method&#x3D;GET*Provides link relations as URLs using the REST &#x27;hateoas&#x27; convention (for REST delivered data).&lt;br&gt;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;The &#x27;self&#x27; link references this rest object, including any specified query criteria&lt;br&gt;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;The &#x27;rel/country&#x27; link references the ship&#x27;s registered country during this time.</param>
        /// <param name="name">Previous name of ship (required).</param>
        /// <param name="statusCode">*hidden*.</param>
        public FormerShipName(string callSign = default(string), string country = default(string), string lastReported = default(string), List<Link> links = default(List<Link>), string name = default(string), int? statusCode = default(int?))
        {
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new InvalidDataException("name is a required property for FormerShipName and cannot be null");
            }
            else
            {
                this.Name = name;
            }
            this.CallSign = callSign;
            this.Country = country;
            this.LastReported = lastReported;
            this.Links = links;
            this.StatusCode = statusCode;
        }
        
        /// <summary>
        /// Previous Call Sign of the ship
        /// </summary>
        /// <value>Previous Call Sign of the ship</value>
        [DataMember(Name="callSign", EmitDefaultValue=false)]
        public string CallSign { get; set; }

        /// <summary>
        /// *method&#x3D;POST_OR_PUT*Alpha 3 Code as per ISO 3166-1 alpha-3 codes
        /// </summary>
        /// <value>*method&#x3D;POST_OR_PUT*Alpha 3 Code as per ISO 3166-1 alpha-3 codes</value>
        [DataMember(Name="country", EmitDefaultValue=false)]
        public string Country { get; set; }

        /// <summary>
        /// Date the ship was last reported with this name. &lt;br&gt;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;Example Value: 2019-03-14T14:55:00Z specifies a year-month-day followed by 24-hour hours:minutes:seconds in GMT time
        /// </summary>
        /// <value>Date the ship was last reported with this name. &lt;br&gt;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;Example Value: 2019-03-14T14:55:00Z specifies a year-month-day followed by 24-hour hours:minutes:seconds in GMT time</value>
        [DataMember(Name="lastReported", EmitDefaultValue=false)]
        public string LastReported { get; set; }

        /// <summary>
        /// *method&#x3D;GET*Provides link relations as URLs using the REST &#x27;hateoas&#x27; convention (for REST delivered data).&lt;br&gt;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;The &#x27;self&#x27; link references this rest object, including any specified query criteria&lt;br&gt;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;The &#x27;rel/country&#x27; link references the ship&#x27;s registered country during this time
        /// </summary>
        /// <value>*method&#x3D;GET*Provides link relations as URLs using the REST &#x27;hateoas&#x27; convention (for REST delivered data).&lt;br&gt;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;The &#x27;self&#x27; link references this rest object, including any specified query criteria&lt;br&gt;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;The &#x27;rel/country&#x27; link references the ship&#x27;s registered country during this time</value>
        [DataMember(Name="links", EmitDefaultValue=false)]
        public List<Link> Links { get; set; }

        /// <summary>
        /// Previous name of ship
        /// </summary>
        /// <value>Previous name of ship</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// *hidden*
        /// </summary>
        /// <value>*hidden*</value>
        [DataMember(Name="statusCode", EmitDefaultValue=false)]
        public int? StatusCode { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FormerShipName {\n");
            sb.Append("  CallSign: ").Append(CallSign).Append("\n");
            sb.Append("  Country: ").Append(Country).Append("\n");
            sb.Append("  LastReported: ").Append(LastReported).Append("\n");
            sb.Append("  Links: ").Append(Links).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  StatusCode: ").Append(StatusCode).Append("\n");
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
            return this.Equals(input as FormerShipName);
        }

        /// <summary>
        /// Returns true if FormerShipName instances are equal
        /// </summary>
        /// <param name="input">Instance of FormerShipName to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FormerShipName input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.CallSign == input.CallSign ||
                    (this.CallSign != null &&
                    this.CallSign.Equals(input.CallSign))
                ) && 
                (
                    this.Country == input.Country ||
                    (this.Country != null &&
                    this.Country.Equals(input.Country))
                ) && 
                (
                    this.LastReported == input.LastReported ||
                    (this.LastReported != null &&
                    this.LastReported.Equals(input.LastReported))
                ) && 
                (
                    this.Links == input.Links ||
                    this.Links != null &&
                    input.Links != null &&
                    this.Links.SequenceEqual(input.Links)
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.StatusCode == input.StatusCode ||
                    (this.StatusCode != null &&
                    this.StatusCode.Equals(input.StatusCode))
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
                if (this.CallSign != null)
                    hashCode = hashCode * 59 + this.CallSign.GetHashCode();
                if (this.Country != null)
                    hashCode = hashCode * 59 + this.Country.GetHashCode();
                if (this.LastReported != null)
                    hashCode = hashCode * 59 + this.LastReported.GetHashCode();
                if (this.Links != null)
                    hashCode = hashCode * 59 + this.Links.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.StatusCode != null)
                    hashCode = hashCode * 59 + this.StatusCode.GetHashCode();
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
