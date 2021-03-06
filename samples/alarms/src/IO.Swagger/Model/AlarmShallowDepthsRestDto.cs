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
    /// Container for multiple Alarm Shallow Depths
    /// </summary>
    [DataContract]
        public partial class AlarmShallowDepthsRestDto :  IEquatable<AlarmShallowDepthsRestDto>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AlarmShallowDepthsRestDto" /> class.
        /// </summary>
        /// <param name="items">An array of Alarm Shallow Depths matching the query criteria.</param>
        /// <param name="links">*method&#x3D;GET*Provides link relations as URLs using the REST &#x27;hateoas&#x27; convention (for REST delivered data).&lt;br&gt;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;The &#x27;self&#x27; link references this rest object, including any specified query criteria.</param>
        /// <param name="totalItems">Total number of elements matching the query filter and not limited by page size.</param>
        public AlarmShallowDepthsRestDto(List<AlarmShallowDepthRestDto> items = default(List<AlarmShallowDepthRestDto>), List<Link> links = default(List<Link>), long? totalItems = default(long?))
        {
            this.Items = items;
            this.Links = links;
            this.TotalItems = totalItems;
        }
        
        /// <summary>
        /// An array of Alarm Shallow Depths matching the query criteria
        /// </summary>
        /// <value>An array of Alarm Shallow Depths matching the query criteria</value>
        [DataMember(Name="items", EmitDefaultValue=false)]
        public List<AlarmShallowDepthRestDto> Items { get; set; }

        /// <summary>
        /// *method&#x3D;GET*Provides link relations as URLs using the REST &#x27;hateoas&#x27; convention (for REST delivered data).&lt;br&gt;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;The &#x27;self&#x27; link references this rest object, including any specified query criteria
        /// </summary>
        /// <value>*method&#x3D;GET*Provides link relations as URLs using the REST &#x27;hateoas&#x27; convention (for REST delivered data).&lt;br&gt;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;The &#x27;self&#x27; link references this rest object, including any specified query criteria</value>
        [DataMember(Name="links", EmitDefaultValue=false)]
        public List<Link> Links { get; set; }

        /// <summary>
        /// Total number of elements matching the query filter and not limited by page size
        /// </summary>
        /// <value>Total number of elements matching the query filter and not limited by page size</value>
        [DataMember(Name="totalItems", EmitDefaultValue=false)]
        public long? TotalItems { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AlarmShallowDepthsRestDto {\n");
            sb.Append("  Items: ").Append(Items).Append("\n");
            sb.Append("  Links: ").Append(Links).Append("\n");
            sb.Append("  TotalItems: ").Append(TotalItems).Append("\n");
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
            return this.Equals(input as AlarmShallowDepthsRestDto);
        }

        /// <summary>
        /// Returns true if AlarmShallowDepthsRestDto instances are equal
        /// </summary>
        /// <param name="input">Instance of AlarmShallowDepthsRestDto to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AlarmShallowDepthsRestDto input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Items == input.Items ||
                    this.Items != null &&
                    input.Items != null &&
                    this.Items.SequenceEqual(input.Items)
                ) && 
                (
                    this.Links == input.Links ||
                    this.Links != null &&
                    input.Links != null &&
                    this.Links.SequenceEqual(input.Links)
                ) && 
                (
                    this.TotalItems == input.TotalItems ||
                    (this.TotalItems != null &&
                    this.TotalItems.Equals(input.TotalItems))
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
                if (this.Items != null)
                    hashCode = hashCode * 59 + this.Items.GetHashCode();
                if (this.Links != null)
                    hashCode = hashCode * 59 + this.Links.GetHashCode();
                if (this.TotalItems != null)
                    hashCode = hashCode * 59 + this.TotalItems.GetHashCode();
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
