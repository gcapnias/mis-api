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
    /// dto description not used
    /// </summary>
    [DataContract]
        public partial class TrackPostParametersRestDto :  IEquatable<TrackPostParametersRestDto>, IValidatableObject
    {
        /// <summary>
        /// optionally supplied type of track
        /// </summary>
        /// <value>optionally supplied type of track</value>
        [JsonConverter(typeof(StringEnumConverter))]
                public enum TypeEnum
        {
            /// <summary>
            /// Enum Surface for value: Surface
            /// </summary>
            [EnumMember(Value = "Surface")]
            Surface = 1,
            /// <summary>
            /// Enum Air for value:  Air
            /// </summary>
            [EnumMember(Value = " Air")]
            Air = 2,
            /// <summary>
            /// Enum Iff for value:  Iff
            /// </summary>
            [EnumMember(Value = " Iff")]
            Iff = 3,
            /// <summary>
            /// Enum SurfaceImo for value:  SurfaceImo
            /// </summary>
            [EnumMember(Value = " SurfaceImo")]
            SurfaceImo = 4        }
        /// <summary>
        /// optionally supplied type of track
        /// </summary>
        /// <value>optionally supplied type of track</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public TypeEnum? Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="TrackPostParametersRestDto" /> class.
        /// </summary>
        /// <param name="extTrkId">[1 to 65535]: optionally supplied tracking number strictly for the benefit of the user to associate with the created track and not used by MIS.</param>
        /// <param name="location">location.</param>
        /// <param name="searchRadius">optionally supplied search radius in meters around the &#x27;location&#x27; parameter within which to create the track. (Defaults to 100.0 meters)&lt;br/&gt;Adjust this parameter when an operator creates a track from the user interface. The current range scale and viewport pixel density will define the meters per pixel, which will drive the searchRadius value. As a general example, if using 1920x1080 display at 1 NMI range scale the search radius may be 25-50 meters and at 10 NMI may be 250-500 meters..</param>
        /// <param name="type">optionally supplied type of track.</param>
        public TrackPostParametersRestDto(int? extTrkId = default(int?), GeoLocationRestDto location = default(GeoLocationRestDto), float? searchRadius = default(float?), TypeEnum? type = default(TypeEnum?))
        {
            this.ExtTrkId = extTrkId;
            this.Location = location;
            this.SearchRadius = searchRadius;
            this.Type = type;
        }
        
        /// <summary>
        /// [1 to 65535]: optionally supplied tracking number strictly for the benefit of the user to associate with the created track and not used by MIS
        /// </summary>
        /// <value>[1 to 65535]: optionally supplied tracking number strictly for the benefit of the user to associate with the created track and not used by MIS</value>
        [DataMember(Name="extTrkId", EmitDefaultValue=false)]
        public int? ExtTrkId { get; set; }

        /// <summary>
        /// Gets or Sets Location
        /// </summary>
        [DataMember(Name="location", EmitDefaultValue=false)]
        public GeoLocationRestDto Location { get; set; }

        /// <summary>
        /// optionally supplied search radius in meters around the &#x27;location&#x27; parameter within which to create the track. (Defaults to 100.0 meters)&lt;br/&gt;Adjust this parameter when an operator creates a track from the user interface. The current range scale and viewport pixel density will define the meters per pixel, which will drive the searchRadius value. As a general example, if using 1920x1080 display at 1 NMI range scale the search radius may be 25-50 meters and at 10 NMI may be 250-500 meters.
        /// </summary>
        /// <value>optionally supplied search radius in meters around the &#x27;location&#x27; parameter within which to create the track. (Defaults to 100.0 meters)&lt;br/&gt;Adjust this parameter when an operator creates a track from the user interface. The current range scale and viewport pixel density will define the meters per pixel, which will drive the searchRadius value. As a general example, if using 1920x1080 display at 1 NMI range scale the search radius may be 25-50 meters and at 10 NMI may be 250-500 meters.</value>
        [DataMember(Name="searchRadius", EmitDefaultValue=false)]
        public float? SearchRadius { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TrackPostParametersRestDto {\n");
            sb.Append("  ExtTrkId: ").Append(ExtTrkId).Append("\n");
            sb.Append("  Location: ").Append(Location).Append("\n");
            sb.Append("  SearchRadius: ").Append(SearchRadius).Append("\n");
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
            return this.Equals(input as TrackPostParametersRestDto);
        }

        /// <summary>
        /// Returns true if TrackPostParametersRestDto instances are equal
        /// </summary>
        /// <param name="input">Instance of TrackPostParametersRestDto to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TrackPostParametersRestDto input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ExtTrkId == input.ExtTrkId ||
                    (this.ExtTrkId != null &&
                    this.ExtTrkId.Equals(input.ExtTrkId))
                ) && 
                (
                    this.Location == input.Location ||
                    (this.Location != null &&
                    this.Location.Equals(input.Location))
                ) && 
                (
                    this.SearchRadius == input.SearchRadius ||
                    (this.SearchRadius != null &&
                    this.SearchRadius.Equals(input.SearchRadius))
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
                if (this.ExtTrkId != null)
                    hashCode = hashCode * 59 + this.ExtTrkId.GetHashCode();
                if (this.Location != null)
                    hashCode = hashCode * 59 + this.Location.GetHashCode();
                if (this.SearchRadius != null)
                    hashCode = hashCode * 59 + this.SearchRadius.GetHashCode();
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