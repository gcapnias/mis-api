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
    /// RadarServiceRestDto
    /// </summary>
    [DataContract]
        public partial class RadarServiceRestDto :  IEquatable<RadarServiceRestDto>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RadarServiceRestDto" /> class.
        /// </summary>
        /// <param name="controllers">controllers.</param>
        /// <param name="isActive">Specifies whether the service is active (required).</param>
        /// <param name="links">*method&#x3D;GET*Provides link relations as URLs using the REST &#x27;hateoas&#x27; convention (for REST delivered data).&lt;br&gt;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;The &#x27;rel/radar&#x27; link references the associated Radar and can be used to access further information via the REST Radar (or RadarImage) Endpoint (required).</param>
        /// <param name="name">Name of this service (required).</param>
        /// <param name="radarUsageTime">radarUsageTime.</param>
        public RadarServiceRestDto(ControllersRestDto controllers = default(ControllersRestDto), bool? isActive = default(bool?), List<Link> links = default(List<Link>), string name = default(string), RadarUsageTimeRestDto radarUsageTime = default(RadarUsageTimeRestDto))
        {
            // to ensure "isActive" is required (not null)
            if (isActive == null)
            {
                throw new InvalidDataException("isActive is a required property for RadarServiceRestDto and cannot be null");
            }
            else
            {
                this.IsActive = isActive;
            }
            // to ensure "links" is required (not null)
            if (links == null)
            {
                throw new InvalidDataException("links is a required property for RadarServiceRestDto and cannot be null");
            }
            else
            {
                this.Links = links;
            }
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new InvalidDataException("name is a required property for RadarServiceRestDto and cannot be null");
            }
            else
            {
                this.Name = name;
            }
            this.Controllers = controllers;
            this.RadarUsageTime = radarUsageTime;
        }
        
        /// <summary>
        /// Gets or Sets Controllers
        /// </summary>
        [DataMember(Name="controllers", EmitDefaultValue=false)]
        public ControllersRestDto Controllers { get; set; }

        /// <summary>
        /// Specifies whether the service is active
        /// </summary>
        /// <value>Specifies whether the service is active</value>
        [DataMember(Name="isActive", EmitDefaultValue=false)]
        public bool? IsActive { get; set; }

        /// <summary>
        /// *method&#x3D;GET*Provides link relations as URLs using the REST &#x27;hateoas&#x27; convention (for REST delivered data).&lt;br&gt;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;The &#x27;rel/radar&#x27; link references the associated Radar and can be used to access further information via the REST Radar (or RadarImage) Endpoint
        /// </summary>
        /// <value>*method&#x3D;GET*Provides link relations as URLs using the REST &#x27;hateoas&#x27; convention (for REST delivered data).&lt;br&gt;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;The &#x27;rel/radar&#x27; link references the associated Radar and can be used to access further information via the REST Radar (or RadarImage) Endpoint</value>
        [DataMember(Name="links", EmitDefaultValue=false)]
        public List<Link> Links { get; set; }

        /// <summary>
        /// Name of this service
        /// </summary>
        /// <value>Name of this service</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets RadarUsageTime
        /// </summary>
        [DataMember(Name="radarUsageTime", EmitDefaultValue=false)]
        public RadarUsageTimeRestDto RadarUsageTime { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RadarServiceRestDto {\n");
            sb.Append("  Controllers: ").Append(Controllers).Append("\n");
            sb.Append("  IsActive: ").Append(IsActive).Append("\n");
            sb.Append("  Links: ").Append(Links).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  RadarUsageTime: ").Append(RadarUsageTime).Append("\n");
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
            return this.Equals(input as RadarServiceRestDto);
        }

        /// <summary>
        /// Returns true if RadarServiceRestDto instances are equal
        /// </summary>
        /// <param name="input">Instance of RadarServiceRestDto to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RadarServiceRestDto input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Controllers == input.Controllers ||
                    (this.Controllers != null &&
                    this.Controllers.Equals(input.Controllers))
                ) && 
                (
                    this.IsActive == input.IsActive ||
                    (this.IsActive != null &&
                    this.IsActive.Equals(input.IsActive))
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
                    this.RadarUsageTime == input.RadarUsageTime ||
                    (this.RadarUsageTime != null &&
                    this.RadarUsageTime.Equals(input.RadarUsageTime))
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
                if (this.Controllers != null)
                    hashCode = hashCode * 59 + this.Controllers.GetHashCode();
                if (this.IsActive != null)
                    hashCode = hashCode * 59 + this.IsActive.GetHashCode();
                if (this.Links != null)
                    hashCode = hashCode * 59 + this.Links.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.RadarUsageTime != null)
                    hashCode = hashCode * 59 + this.RadarUsageTime.GetHashCode();
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
