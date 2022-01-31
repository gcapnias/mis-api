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
    /// Not used - Alarm data
    /// </summary>
    [DataContract]
        public partial class AlarmShallowDepthRestDto :  IEquatable<AlarmShallowDepthRestDto>, IValidatableObject
    {
        /// <summary>
        /// Type of Alarm
        /// </summary>
        /// <value>Type of Alarm</value>
        [JsonConverter(typeof(StringEnumConverter))]
                public enum TypeEnum
        {
            /// <summary>
            /// Enum Cpa for value: cpa
            /// </summary>
            [EnumMember(Value = "cpa")]
            Cpa = 1,
            /// <summary>
            /// Enum Proximity for value: proximity
            /// </summary>
            [EnumMember(Value = "proximity")]
            Proximity = 2,
            /// <summary>
            /// Enum AnchorWatch for value: anchorWatch
            /// </summary>
            [EnumMember(Value = "anchorWatch")]
            AnchorWatch = 3,
            /// <summary>
            /// Enum RouteDeviate for value: routeDeviate
            /// </summary>
            [EnumMember(Value = "routeDeviate")]
            RouteDeviate = 4,
            /// <summary>
            /// Enum ShallowDepth for value: shallowDepth
            /// </summary>
            [EnumMember(Value = "shallowDepth")]
            ShallowDepth = 5,
            /// <summary>
            /// Enum StateChanged for value: stateChanged
            /// </summary>
            [EnumMember(Value = "stateChanged")]
            StateChanged = 6        }
        /// <summary>
        /// Type of Alarm
        /// </summary>
        /// <value>Type of Alarm</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public TypeEnum? Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="AlarmShallowDepthRestDto" /> class.
        /// </summary>
        /// <param name="alarmId">ID of the Alarm.</param>
        /// <param name="distance">[1 and greater]: Safe Limit Distance (in meters).</param>
        /// <param name="links">*method&#x3D;GET*Provides link relations as URLs using the REST &#x27;hateoas&#x27; convention (for REST delivered data).&lt;br&gt;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;The &#x27;self&#x27; link references this rest object, including any specified query criteria.</param>
        /// <param name="trackIds">trackIds.</param>
        /// <param name="type">Type of Alarm.</param>
        public AlarmShallowDepthRestDto(int? alarmId = default(int?), int? distance = default(int?), List<Link> links = default(List<Link>), TrackIdsIdOnlyRestDto trackIds = default(TrackIdsIdOnlyRestDto), TypeEnum? type = default(TypeEnum?))
        {
            this.AlarmId = alarmId;
            this.Distance = distance;
            this.Links = links;
            this.TrackIds = trackIds;
            this.Type = type;
        }
        
        /// <summary>
        /// ID of the Alarm
        /// </summary>
        /// <value>ID of the Alarm</value>
        [DataMember(Name="alarmId", EmitDefaultValue=false)]
        public int? AlarmId { get; set; }

        /// <summary>
        /// [1 and greater]: Safe Limit Distance (in meters)
        /// </summary>
        /// <value>[1 and greater]: Safe Limit Distance (in meters)</value>
        [DataMember(Name="distance", EmitDefaultValue=false)]
        public int? Distance { get; set; }

        /// <summary>
        /// *method&#x3D;GET*Provides link relations as URLs using the REST &#x27;hateoas&#x27; convention (for REST delivered data).&lt;br&gt;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;The &#x27;self&#x27; link references this rest object, including any specified query criteria
        /// </summary>
        /// <value>*method&#x3D;GET*Provides link relations as URLs using the REST &#x27;hateoas&#x27; convention (for REST delivered data).&lt;br&gt;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;The &#x27;self&#x27; link references this rest object, including any specified query criteria</value>
        [DataMember(Name="links", EmitDefaultValue=false)]
        public List<Link> Links { get; set; }

        /// <summary>
        /// Gets or Sets TrackIds
        /// </summary>
        [DataMember(Name="trackIds", EmitDefaultValue=false)]
        public TrackIdsIdOnlyRestDto TrackIds { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AlarmShallowDepthRestDto {\n");
            sb.Append("  AlarmId: ").Append(AlarmId).Append("\n");
            sb.Append("  Distance: ").Append(Distance).Append("\n");
            sb.Append("  Links: ").Append(Links).Append("\n");
            sb.Append("  TrackIds: ").Append(TrackIds).Append("\n");
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
            return this.Equals(input as AlarmShallowDepthRestDto);
        }

        /// <summary>
        /// Returns true if AlarmShallowDepthRestDto instances are equal
        /// </summary>
        /// <param name="input">Instance of AlarmShallowDepthRestDto to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AlarmShallowDepthRestDto input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AlarmId == input.AlarmId ||
                    (this.AlarmId != null &&
                    this.AlarmId.Equals(input.AlarmId))
                ) && 
                (
                    this.Distance == input.Distance ||
                    (this.Distance != null &&
                    this.Distance.Equals(input.Distance))
                ) && 
                (
                    this.Links == input.Links ||
                    this.Links != null &&
                    input.Links != null &&
                    this.Links.SequenceEqual(input.Links)
                ) && 
                (
                    this.TrackIds == input.TrackIds ||
                    (this.TrackIds != null &&
                    this.TrackIds.Equals(input.TrackIds))
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
                if (this.AlarmId != null)
                    hashCode = hashCode * 59 + this.AlarmId.GetHashCode();
                if (this.Distance != null)
                    hashCode = hashCode * 59 + this.Distance.GetHashCode();
                if (this.Links != null)
                    hashCode = hashCode * 59 + this.Links.GetHashCode();
                if (this.TrackIds != null)
                    hashCode = hashCode * 59 + this.TrackIds.GetHashCode();
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
