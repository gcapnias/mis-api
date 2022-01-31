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
    /// RadarStateRestDto
    /// </summary>
    [DataContract]
        public partial class RadarStateRestDto :  IEquatable<RadarStateRestDto>, IValidatableObject
    {
        /// <summary>
        /// radar state for this radar. Please note that this can NOT be set if the Radar is a slave RP
        /// </summary>
        /// <value>radar state for this radar. Please note that this can NOT be set if the Radar is a slave RP</value>
        [JsonConverter(typeof(StringEnumConverter))]
                public enum RadarStateEnum
        {
            /// <summary>
            /// Enum Off for value: Off
            /// </summary>
            [EnumMember(Value = "Off")]
            Off = 1,
            /// <summary>
            /// Enum Standby for value: Standby
            /// </summary>
            [EnumMember(Value = "Standby")]
            Standby = 2,
            /// <summary>
            /// Enum Radiate for value: Radiate
            /// </summary>
            [EnumMember(Value = "Radiate")]
            Radiate = 3,
            /// <summary>
            /// Enum Rotate for value: Rotate
            /// </summary>
            [EnumMember(Value = "Rotate")]
            Rotate = 4,
            /// <summary>
            /// Enum RotateRadiate for value: RotateRadiate
            /// </summary>
            [EnumMember(Value = "RotateRadiate")]
            RotateRadiate = 5        }
        /// <summary>
        /// radar state for this radar. Please note that this can NOT be set if the Radar is a slave RP
        /// </summary>
        /// <value>radar state for this radar. Please note that this can NOT be set if the Radar is a slave RP</value>
        [DataMember(Name="radarState", EmitDefaultValue=false)]
        public RadarStateEnum? RadarState { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="RadarStateRestDto" /> class.
        /// </summary>
        /// <param name="radarState">radar state for this radar. Please note that this can NOT be set if the Radar is a slave RP.</param>
        public RadarStateRestDto(RadarStateEnum? radarState = default(RadarStateEnum?))
        {
            this.RadarState = radarState;
        }
        

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RadarStateRestDto {\n");
            sb.Append("  RadarState: ").Append(RadarState).Append("\n");
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
            return this.Equals(input as RadarStateRestDto);
        }

        /// <summary>
        /// Returns true if RadarStateRestDto instances are equal
        /// </summary>
        /// <param name="input">Instance of RadarStateRestDto to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RadarStateRestDto input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.RadarState == input.RadarState ||
                    (this.RadarState != null &&
                    this.RadarState.Equals(input.RadarState))
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
                if (this.RadarState != null)
                    hashCode = hashCode * 59 + this.RadarState.GetHashCode();
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
