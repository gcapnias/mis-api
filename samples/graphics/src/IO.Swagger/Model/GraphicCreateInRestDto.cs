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
    /// graphic for defining Track or Radar Processing regions
    /// </summary>
    [DataContract]
        public partial class GraphicCreateInRestDto :  IEquatable<GraphicCreateInRestDto>, IValidatableObject
    {
        /// <summary>
        /// How tracks within this region are acquired or processed.
        /// </summary>
        /// <value>How tracks within this region are acquired or processed.</value>
        [JsonConverter(typeof(StringEnumConverter))]
                public enum GraphicProcessingTypeEnum
        {
            /// <summary>
            /// Enum TRACKLANDMASK for value: TRACK_LAND_MASK
            /// </summary>
            [EnumMember(Value = "TRACK_LAND_MASK")]
            TRACKLANDMASK = 1,
            /// <summary>
            /// Enum ACQUISITIONWINDOW for value: ACQUISITION_WINDOW
            /// </summary>
            [EnumMember(Value = "ACQUISITION_WINDOW")]
            ACQUISITIONWINDOW = 2,
            /// <summary>
            /// Enum ACQUISITIONAIS for value: ACQUISITION_AIS
            /// </summary>
            [EnumMember(Value = "ACQUISITION_AIS")]
            ACQUISITIONAIS = 3,
            /// <summary>
            /// Enum ACQUISITIONIFF for value: ACQUISITION_IFF
            /// </summary>
            [EnumMember(Value = "ACQUISITION_IFF")]
            ACQUISITIONIFF = 4        }
        /// <summary>
        /// How tracks within this region are acquired or processed.
        /// </summary>
        /// <value>How tracks within this region are acquired or processed.</value>
        [DataMember(Name="graphicProcessingType", EmitDefaultValue=false)]
        public GraphicProcessingTypeEnum? GraphicProcessingType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="GraphicCreateInRestDto" /> class.
        /// </summary>
        /// <param name="circle">circle.</param>
        /// <param name="graphicProcessingType">How tracks within this region are acquired or processed..</param>
        /// <param name="polygon">definition of a simple polygon (closed with no intersections). (circle and polygon are exclusive).</param>
        public GraphicCreateInRestDto(GraphicCircleRestDto circle = default(GraphicCircleRestDto), GraphicProcessingTypeEnum? graphicProcessingType = default(GraphicProcessingTypeEnum?), List<GeoLatLonRestDto> polygon = default(List<GeoLatLonRestDto>))
        {
            this.Circle = circle;
            this.GraphicProcessingType = graphicProcessingType;
            this.Polygon = polygon;
        }
        
        /// <summary>
        /// Gets or Sets Circle
        /// </summary>
        [DataMember(Name="circle", EmitDefaultValue=false)]
        public GraphicCircleRestDto Circle { get; set; }


        /// <summary>
        /// definition of a simple polygon (closed with no intersections). (circle and polygon are exclusive)
        /// </summary>
        /// <value>definition of a simple polygon (closed with no intersections). (circle and polygon are exclusive)</value>
        [DataMember(Name="polygon", EmitDefaultValue=false)]
        public List<GeoLatLonRestDto> Polygon { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GraphicCreateInRestDto {\n");
            sb.Append("  Circle: ").Append(Circle).Append("\n");
            sb.Append("  GraphicProcessingType: ").Append(GraphicProcessingType).Append("\n");
            sb.Append("  Polygon: ").Append(Polygon).Append("\n");
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
            return this.Equals(input as GraphicCreateInRestDto);
        }

        /// <summary>
        /// Returns true if GraphicCreateInRestDto instances are equal
        /// </summary>
        /// <param name="input">Instance of GraphicCreateInRestDto to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GraphicCreateInRestDto input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Circle == input.Circle ||
                    (this.Circle != null &&
                    this.Circle.Equals(input.Circle))
                ) && 
                (
                    this.GraphicProcessingType == input.GraphicProcessingType ||
                    (this.GraphicProcessingType != null &&
                    this.GraphicProcessingType.Equals(input.GraphicProcessingType))
                ) && 
                (
                    this.Polygon == input.Polygon ||
                    this.Polygon != null &&
                    input.Polygon != null &&
                    this.Polygon.SequenceEqual(input.Polygon)
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
                if (this.Circle != null)
                    hashCode = hashCode * 59 + this.Circle.GetHashCode();
                if (this.GraphicProcessingType != null)
                    hashCode = hashCode * 59 + this.GraphicProcessingType.GetHashCode();
                if (this.Polygon != null)
                    hashCode = hashCode * 59 + this.Polygon.GetHashCode();
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
