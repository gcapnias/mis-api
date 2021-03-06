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
    /// NavOrTrackerServiceRestDto
    /// </summary>
    [DataContract]
        public partial class NavOrTrackerServiceRestDto :  IEquatable<NavOrTrackerServiceRestDto>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NavOrTrackerServiceRestDto" /> class.
        /// </summary>
        /// <param name="controller">Provides the controller of this service as an IP address. Available with expand&#x3D;detail.</param>
        /// <param name="isActive">Specifies whether the service is active or not (required).</param>
        public NavOrTrackerServiceRestDto(string controller = default(string), bool? isActive = default(bool?))
        {
            // to ensure "isActive" is required (not null)
            if (isActive == null)
            {
                throw new InvalidDataException("isActive is a required property for NavOrTrackerServiceRestDto and cannot be null");
            }
            else
            {
                this.IsActive = isActive;
            }
            this.Controller = controller;
        }
        
        /// <summary>
        /// Provides the controller of this service as an IP address. Available with expand&#x3D;detail
        /// </summary>
        /// <value>Provides the controller of this service as an IP address. Available with expand&#x3D;detail</value>
        [DataMember(Name="controller", EmitDefaultValue=false)]
        public string Controller { get; set; }

        /// <summary>
        /// Specifies whether the service is active or not
        /// </summary>
        /// <value>Specifies whether the service is active or not</value>
        [DataMember(Name="isActive", EmitDefaultValue=false)]
        public bool? IsActive { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class NavOrTrackerServiceRestDto {\n");
            sb.Append("  Controller: ").Append(Controller).Append("\n");
            sb.Append("  IsActive: ").Append(IsActive).Append("\n");
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
            return this.Equals(input as NavOrTrackerServiceRestDto);
        }

        /// <summary>
        /// Returns true if NavOrTrackerServiceRestDto instances are equal
        /// </summary>
        /// <param name="input">Instance of NavOrTrackerServiceRestDto to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NavOrTrackerServiceRestDto input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Controller == input.Controller ||
                    (this.Controller != null &&
                    this.Controller.Equals(input.Controller))
                ) && 
                (
                    this.IsActive == input.IsActive ||
                    (this.IsActive != null &&
                    this.IsActive.Equals(input.IsActive))
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
                if (this.Controller != null)
                    hashCode = hashCode * 59 + this.Controller.GetHashCode();
                if (this.IsActive != null)
                    hashCode = hashCode * 59 + this.IsActive.GetHashCode();
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
