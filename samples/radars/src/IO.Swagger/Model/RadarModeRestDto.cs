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
    /// RadarModeRestDto
    /// </summary>
    [DataContract]
        public partial class RadarModeRestDto :  IEquatable<RadarModeRestDto>, IValidatableObject
    {
        /// <summary>
        /// pulse mode of the radar. Please note that this can NOT be set if the Radar is a slave RP
        /// </summary>
        /// <value>pulse mode of the radar. Please note that this can NOT be set if the Radar is a slave RP</value>
        [JsonConverter(typeof(StringEnumConverter))]
                public enum RadarModeEnum
        {
            /// <summary>
            /// Enum Auto for value: Auto
            /// </summary>
            [EnumMember(Value = "Auto")]
            Auto = 1,
            /// <summary>
            /// Enum Manual for value: Manual
            /// </summary>
            [EnumMember(Value = "Manual")]
            Manual = 2,
            /// <summary>
            /// Enum Short1 for value: Short-1
            /// </summary>
            [EnumMember(Value = "Short-1")]
            Short1 = 3,
            /// <summary>
            /// Enum Short2 for value: Short-2
            /// </summary>
            [EnumMember(Value = "Short-2")]
            Short2 = 4,
            /// <summary>
            /// Enum Medium1 for value: Medium-1
            /// </summary>
            [EnumMember(Value = "Medium-1")]
            Medium1 = 5,
            /// <summary>
            /// Enum Medium2 for value: Medium-2
            /// </summary>
            [EnumMember(Value = "Medium-2")]
            Medium2 = 6,
            /// <summary>
            /// Enum Long1 for value: Long-1
            /// </summary>
            [EnumMember(Value = "Long-1")]
            Long1 = 7,
            /// <summary>
            /// Enum Long2 for value: Long-2
            /// </summary>
            [EnumMember(Value = "Long-2")]
            Long2 = 8,
            /// <summary>
            /// Enum Short3 for value: Short-3
            /// </summary>
            [EnumMember(Value = "Short-3")]
            Short3 = 9,
            /// <summary>
            /// Enum Medium3 for value: Medium-3
            /// </summary>
            [EnumMember(Value = "Medium-3")]
            Medium3 = 10,
            /// <summary>
            /// Enum Long3 for value: Long-3
            /// </summary>
            [EnumMember(Value = "Long-3")]
            Long3 = 11        }
        /// <summary>
        /// pulse mode of the radar. Please note that this can NOT be set if the Radar is a slave RP
        /// </summary>
        /// <value>pulse mode of the radar. Please note that this can NOT be set if the Radar is a slave RP</value>
        [DataMember(Name="radarMode", EmitDefaultValue=false)]
        public RadarModeEnum? RadarMode { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="RadarModeRestDto" /> class.
        /// </summary>
        /// <param name="radarMode">pulse mode of the radar. Please note that this can NOT be set if the Radar is a slave RP.</param>
        public RadarModeRestDto(RadarModeEnum? radarMode = default(RadarModeEnum?))
        {
            this.RadarMode = radarMode;
        }
        

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RadarModeRestDto {\n");
            sb.Append("  RadarMode: ").Append(RadarMode).Append("\n");
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
            return this.Equals(input as RadarModeRestDto);
        }

        /// <summary>
        /// Returns true if RadarModeRestDto instances are equal
        /// </summary>
        /// <param name="input">Instance of RadarModeRestDto to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RadarModeRestDto input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.RadarMode == input.RadarMode ||
                    (this.RadarMode != null &&
                    this.RadarMode.Equals(input.RadarMode))
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
                if (this.RadarMode != null)
                    hashCode = hashCode * 59 + this.RadarMode.GetHashCode();
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
