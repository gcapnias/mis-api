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
    /// TrackGtcSourceRestDto
    /// </summary>
    [DataContract]
        public partial class TrackGtcSourceRestDto :  IEquatable<TrackGtcSourceRestDto>, IValidatableObject
    {
        /// <summary>
        /// Type of source for the track.
        /// </summary>
        /// <value>Type of source for the track.</value>
        [JsonConverter(typeof(StringEnumConverter))]
                public enum TypeEnum
        {
            /// <summary>
            /// Enum Radar for value: Radar
            /// </summary>
            [EnumMember(Value = "Radar")]
            Radar = 1,
            /// <summary>
            /// Enum AIS for value: AIS
            /// </summary>
            [EnumMember(Value = "AIS")]
            AIS = 2,
            /// <summary>
            /// Enum NRT for value: NRT
            /// </summary>
            [EnumMember(Value = "NRT")]
            NRT = 3,
            /// <summary>
            /// Enum Pending for value: Pending
            /// </summary>
            [EnumMember(Value = "Pending")]
            Pending = 4,
            /// <summary>
            /// Enum GenericExternalTrack for value: Generic:External_Track
            /// </summary>
            [EnumMember(Value = "Generic:External_Track")]
            GenericExternalTrack = 5,
            /// <summary>
            /// Enum GenericExternalRadar for value: Generic:External_Radar
            /// </summary>
            [EnumMember(Value = "Generic:External_Radar")]
            GenericExternalRadar = 6,
            /// <summary>
            /// Enum GenericSonar for value: Generic:Sonar
            /// </summary>
            [EnumMember(Value = "Generic:Sonar")]
            GenericSonar = 7,
            /// <summary>
            /// Enum GenericIFF for value: Generic:IFF
            /// </summary>
            [EnumMember(Value = "Generic:IFF")]
            GenericIFF = 8,
            /// <summary>
            /// Enum GenericDSC for value: Generic:DSC
            /// </summary>
            [EnumMember(Value = "Generic:DSC")]
            GenericDSC = 9,
            /// <summary>
            /// Enum GenericADSB for value: Generic:ADS-B
            /// </summary>
            [EnumMember(Value = "Generic:ADS-B")]
            GenericADSB = 10,
            /// <summary>
            /// Enum GenericRaveon for value: Generic:Raveon
            /// </summary>
            [EnumMember(Value = "Generic:Raveon")]
            GenericRaveon = 11,
            /// <summary>
            /// Enum Unknown for value: Unknown
            /// </summary>
            [EnumMember(Value = "Unknown")]
            Unknown = 12,
            /// <summary>
            /// Enum Other for value: Other
            /// </summary>
            [EnumMember(Value = "Other")]
            Other = 13        }
        /// <summary>
        /// Type of source for the track.
        /// </summary>
        /// <value>Type of source for the track.</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public TypeEnum Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="TrackGtcSourceRestDto" /> class.
        /// </summary>
        /// <param name="id">Unique value within same sensor source (1-64 for Radar, 1 for AIS, 1 on up for Generic) (required).</param>
        /// <param name="name">Name assigned to the source within the system. It is not provided if unknown..</param>
        /// <param name="type">Type of source for the track. (required).</param>
        public TrackGtcSourceRestDto(int? id = default(int?), string name = default(string), TypeEnum type = default(TypeEnum))
        {
            // to ensure "id" is required (not null)
            if (id == null)
            {
                throw new InvalidDataException("id is a required property for TrackGtcSourceRestDto and cannot be null");
            }
            else
            {
                this.Id = id;
            }
            // to ensure "type" is required (not null)
            if (type == null)
            {
                throw new InvalidDataException("type is a required property for TrackGtcSourceRestDto and cannot be null");
            }
            else
            {
                this.Type = type;
            }
            this.Name = name;
        }
        
        /// <summary>
        /// Unique value within same sensor source (1-64 for Radar, 1 for AIS, 1 on up for Generic)
        /// </summary>
        /// <value>Unique value within same sensor source (1-64 for Radar, 1 for AIS, 1 on up for Generic)</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public int? Id { get; set; }

        /// <summary>
        /// Name assigned to the source within the system. It is not provided if unknown.
        /// </summary>
        /// <value>Name assigned to the source within the system. It is not provided if unknown.</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TrackGtcSourceRestDto {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
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
            return this.Equals(input as TrackGtcSourceRestDto);
        }

        /// <summary>
        /// Returns true if TrackGtcSourceRestDto instances are equal
        /// </summary>
        /// <param name="input">Instance of TrackGtcSourceRestDto to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TrackGtcSourceRestDto input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
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
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
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
