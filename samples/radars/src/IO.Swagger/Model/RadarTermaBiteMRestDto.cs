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
    /// RadarTermaBiteMRestDto
    /// </summary>
    [DataContract]
        public partial class RadarTermaBiteMRestDto :  IEquatable<RadarTermaBiteMRestDto>, IValidatableObject
    {
        /// <summary>
        /// Terma type of BITE data. &#x27;UNKNOWN&#x27; is reported if it&#x27;s an unrecognized value
        /// </summary>
        /// <value>Terma type of BITE data. &#x27;UNKNOWN&#x27; is reported if it&#x27;s an unrecognized value</value>
        [JsonConverter(typeof(StringEnumConverter))]
                public enum TypeEnum
        {
            /// <summary>
            /// Enum FUNCTION for value: FUNCTION
            /// </summary>
            [EnumMember(Value = "FUNCTION")]
            FUNCTION = 1,
            /// <summary>
            /// Enum FLOAT for value: FLOAT
            /// </summary>
            [EnumMember(Value = "FLOAT")]
            FLOAT = 2,
            /// <summary>
            /// Enum SHORT for value: SHORT
            /// </summary>
            [EnumMember(Value = "SHORT")]
            SHORT = 3,
            /// <summary>
            /// Enum USHORT for value: USHORT
            /// </summary>
            [EnumMember(Value = "USHORT")]
            USHORT = 4,
            /// <summary>
            /// Enum CHAR for value: CHAR
            /// </summary>
            [EnumMember(Value = "CHAR")]
            CHAR = 5,
            /// <summary>
            /// Enum UCHAR for value: UCHAR
            /// </summary>
            [EnumMember(Value = "UCHAR")]
            UCHAR = 6,
            /// <summary>
            /// Enum TIME for value: TIME
            /// </summary>
            [EnumMember(Value = "TIME")]
            TIME = 7,
            /// <summary>
            /// Enum BITEMEASUREMENT for value: BITE_MEASUREMENT
            /// </summary>
            [EnumMember(Value = "BITE_MEASUREMENT")]
            BITEMEASUREMENT = 8,
            /// <summary>
            /// Enum BITEMODULESTATUS for value: BITE_MODULE_STATUS
            /// </summary>
            [EnumMember(Value = "BITE_MODULE_STATUS")]
            BITEMODULESTATUS = 9,
            /// <summary>
            /// Enum UNKNOWN for value: UNKNOWN
            /// </summary>
            [EnumMember(Value = "UNKNOWN")]
            UNKNOWN = 10        }
        /// <summary>
        /// Terma type of BITE data. &#x27;UNKNOWN&#x27; is reported if it&#x27;s an unrecognized value
        /// </summary>
        /// <value>Terma type of BITE data. &#x27;UNKNOWN&#x27; is reported if it&#x27;s an unrecognized value</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public TypeEnum Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="RadarTermaBiteMRestDto" /> class.
        /// </summary>
        /// <param name="description">SSR&#x27;s Radar Processor generated description of the meaning of the type and id.</param>
        /// <param name="errorOrWarnValue">Terma value of an error or warning.</param>
        /// <param name="floatValue">Terma value provided if data is of float type.</param>
        /// <param name="id">Terma id of the BITE data.</param>
        /// <param name="rpTime">SSR&#x27;s Radar Processor timestamp of when received the BITE data.</param>
        /// <param name="termaTime">Terma provided timestamp when provided.</param>
        /// <param name="type">Terma type of BITE data. &#x27;UNKNOWN&#x27; is reported if it&#x27;s an unrecognized value (required).</param>
        /// <param name="value">Terma value provided if data is of integer type.</param>
        public RadarTermaBiteMRestDto(string description = default(string), int? errorOrWarnValue = default(int?), float? floatValue = default(float?), int? id = default(int?), string rpTime = default(string), string termaTime = default(string), TypeEnum type = default(TypeEnum), int? value = default(int?))
        {
            // to ensure "type" is required (not null)
            if (type == null)
            {
                throw new InvalidDataException("type is a required property for RadarTermaBiteMRestDto and cannot be null");
            }
            else
            {
                this.Type = type;
            }
            this.Description = description;
            this.ErrorOrWarnValue = errorOrWarnValue;
            this.FloatValue = floatValue;
            this.Id = id;
            this.RpTime = rpTime;
            this.TermaTime = termaTime;
            this.Value = value;
        }
        
        /// <summary>
        /// SSR&#x27;s Radar Processor generated description of the meaning of the type and id
        /// </summary>
        /// <value>SSR&#x27;s Radar Processor generated description of the meaning of the type and id</value>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }

        /// <summary>
        /// Terma value of an error or warning
        /// </summary>
        /// <value>Terma value of an error or warning</value>
        [DataMember(Name="error_or_warn_value", EmitDefaultValue=false)]
        public int? ErrorOrWarnValue { get; set; }

        /// <summary>
        /// Terma value provided if data is of float type
        /// </summary>
        /// <value>Terma value provided if data is of float type</value>
        [DataMember(Name="float_value", EmitDefaultValue=false)]
        public float? FloatValue { get; set; }

        /// <summary>
        /// Terma id of the BITE data
        /// </summary>
        /// <value>Terma id of the BITE data</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public int? Id { get; set; }

        /// <summary>
        /// SSR&#x27;s Radar Processor timestamp of when received the BITE data
        /// </summary>
        /// <value>SSR&#x27;s Radar Processor timestamp of when received the BITE data</value>
        [DataMember(Name="rp_time", EmitDefaultValue=false)]
        public string RpTime { get; set; }

        /// <summary>
        /// Terma provided timestamp when provided
        /// </summary>
        /// <value>Terma provided timestamp when provided</value>
        [DataMember(Name="terma_time", EmitDefaultValue=false)]
        public string TermaTime { get; set; }


        /// <summary>
        /// Terma value provided if data is of integer type
        /// </summary>
        /// <value>Terma value provided if data is of integer type</value>
        [DataMember(Name="value", EmitDefaultValue=false)]
        public int? Value { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RadarTermaBiteMRestDto {\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  ErrorOrWarnValue: ").Append(ErrorOrWarnValue).Append("\n");
            sb.Append("  FloatValue: ").Append(FloatValue).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  RpTime: ").Append(RpTime).Append("\n");
            sb.Append("  TermaTime: ").Append(TermaTime).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Value: ").Append(Value).Append("\n");
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
            return this.Equals(input as RadarTermaBiteMRestDto);
        }

        /// <summary>
        /// Returns true if RadarTermaBiteMRestDto instances are equal
        /// </summary>
        /// <param name="input">Instance of RadarTermaBiteMRestDto to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RadarTermaBiteMRestDto input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.ErrorOrWarnValue == input.ErrorOrWarnValue ||
                    (this.ErrorOrWarnValue != null &&
                    this.ErrorOrWarnValue.Equals(input.ErrorOrWarnValue))
                ) && 
                (
                    this.FloatValue == input.FloatValue ||
                    (this.FloatValue != null &&
                    this.FloatValue.Equals(input.FloatValue))
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.RpTime == input.RpTime ||
                    (this.RpTime != null &&
                    this.RpTime.Equals(input.RpTime))
                ) && 
                (
                    this.TermaTime == input.TermaTime ||
                    (this.TermaTime != null &&
                    this.TermaTime.Equals(input.TermaTime))
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && 
                (
                    this.Value == input.Value ||
                    (this.Value != null &&
                    this.Value.Equals(input.Value))
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
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.ErrorOrWarnValue != null)
                    hashCode = hashCode * 59 + this.ErrorOrWarnValue.GetHashCode();
                if (this.FloatValue != null)
                    hashCode = hashCode * 59 + this.FloatValue.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.RpTime != null)
                    hashCode = hashCode * 59 + this.RpTime.GetHashCode();
                if (this.TermaTime != null)
                    hashCode = hashCode * 59 + this.TermaTime.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.Value != null)
                    hashCode = hashCode * 59 + this.Value.GetHashCode();
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
