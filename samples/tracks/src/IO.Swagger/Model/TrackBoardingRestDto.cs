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
    /// TrackBoardingRestDto
    /// </summary>
    [DataContract]
        public partial class TrackBoardingRestDto :  IEquatable<TrackBoardingRestDto>, IValidatableObject
    {
        /// <summary>
        /// Current boarding status of this track, used for Boarding Operations
        /// </summary>
        /// <value>Current boarding status of this track, used for Boarding Operations</value>
        [JsonConverter(typeof(StringEnumConverter))]
                public enum BoardingEnum
        {
            /// <summary>
            /// Enum NoInterest for value: NoInterest
            /// </summary>
            [EnumMember(Value = "NoInterest")]
            NoInterest = 1,
            /// <summary>
            /// Enum Interest for value: Interest
            /// </summary>
            [EnumMember(Value = "Interest")]
            Interest = 2,
            /// <summary>
            /// Enum OnBoard for value: OnBoard
            /// </summary>
            [EnumMember(Value = "OnBoard")]
            OnBoard = 3,
            /// <summary>
            /// Enum Boarded for value: Boarded
            /// </summary>
            [EnumMember(Value = "Boarded")]
            Boarded = 4        }
        /// <summary>
        /// Current boarding status of this track, used for Boarding Operations
        /// </summary>
        /// <value>Current boarding status of this track, used for Boarding Operations</value>
        [DataMember(Name="boarding", EmitDefaultValue=false)]
        public BoardingEnum? Boarding { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="TrackBoardingRestDto" /> class.
        /// </summary>
        /// <param name="boarding">Current boarding status of this track, used for Boarding Operations.</param>
        public TrackBoardingRestDto(BoardingEnum? boarding = default(BoardingEnum?))
        {
            this.Boarding = boarding;
        }
        

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TrackBoardingRestDto {\n");
            sb.Append("  Boarding: ").Append(Boarding).Append("\n");
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
            return this.Equals(input as TrackBoardingRestDto);
        }

        /// <summary>
        /// Returns true if TrackBoardingRestDto instances are equal
        /// </summary>
        /// <param name="input">Instance of TrackBoardingRestDto to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TrackBoardingRestDto input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Boarding == input.Boarding ||
                    (this.Boarding != null &&
                    this.Boarding.Equals(input.Boarding))
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
                if (this.Boarding != null)
                    hashCode = hashCode * 59 + this.Boarding.GetHashCode();
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
