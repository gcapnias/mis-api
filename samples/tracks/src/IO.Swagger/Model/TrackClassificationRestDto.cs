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
    /// TrackClassificationRestDto
    /// </summary>
    [DataContract]
        public partial class TrackClassificationRestDto :  IEquatable<TrackClassificationRestDto>, IValidatableObject
    {
        /// <summary>
        /// Classification of this track
        /// </summary>
        /// <value>Classification of this track</value>
        [JsonConverter(typeof(StringEnumConverter))]
                public enum ClassificationEnum
        {
            /// <summary>
            /// Enum Unknown for value: Unknown
            /// </summary>
            [EnumMember(Value = "Unknown")]
            Unknown = 1,
            /// <summary>
            /// Enum SurfaceUnknown for value: SurfaceUnknown
            /// </summary>
            [EnumMember(Value = "SurfaceUnknown")]
            SurfaceUnknown = 2,
            /// <summary>
            /// Enum Merchant for value: Merchant
            /// </summary>
            [EnumMember(Value = "Merchant")]
            Merchant = 3,
            /// <summary>
            /// Enum Cargo for value: Cargo
            /// </summary>
            [EnumMember(Value = "Cargo")]
            Cargo = 4,
            /// <summary>
            /// Enum SearchCenter for value: SearchCenter
            /// </summary>
            [EnumMember(Value = "SearchCenter")]
            SearchCenter = 5,
            /// <summary>
            /// Enum Navy for value: Navy
            /// </summary>
            [EnumMember(Value = "Navy")]
            Navy = 6,
            /// <summary>
            /// Enum Tug for value: Tug
            /// </summary>
            [EnumMember(Value = "Tug")]
            Tug = 7,
            /// <summary>
            /// Enum Ferry for value: Ferry
            /// </summary>
            [EnumMember(Value = "Ferry")]
            Ferry = 8,
            /// <summary>
            /// Enum Passenger for value: Passenger
            /// </summary>
            [EnumMember(Value = "Passenger")]
            Passenger = 9,
            /// <summary>
            /// Enum CoastGuard for value: CoastGuard
            /// </summary>
            [EnumMember(Value = "CoastGuard")]
            CoastGuard = 10,
            /// <summary>
            /// Enum Hazmat for value: Hazmat
            /// </summary>
            [EnumMember(Value = "Hazmat")]
            Hazmat = 11,
            /// <summary>
            /// Enum Towing for value: Towing
            /// </summary>
            [EnumMember(Value = "Towing")]
            Towing = 12,
            /// <summary>
            /// Enum Fishing for value: Fishing
            /// </summary>
            [EnumMember(Value = "Fishing")]
            Fishing = 13,
            /// <summary>
            /// Enum Drifter for value: Drifter
            /// </summary>
            [EnumMember(Value = "Drifter")]
            Drifter = 14,
            /// <summary>
            /// Enum Dredge for value: Dredge
            /// </summary>
            [EnumMember(Value = "Dredge")]
            Dredge = 15,
            /// <summary>
            /// Enum Trawler for value: Trawler
            /// </summary>
            [EnumMember(Value = "Trawler")]
            Trawler = 16,
            /// <summary>
            /// Enum Leisure for value: Leisure
            /// </summary>
            [EnumMember(Value = "Leisure")]
            Leisure = 17,
            /// <summary>
            /// Enum Hovercraft for value: Hovercraft
            /// </summary>
            [EnumMember(Value = "Hovercraft")]
            Hovercraft = 18,
            /// <summary>
            /// Enum MarineLife for value: MarineLife
            /// </summary>
            [EnumMember(Value = "MarineLife")]
            MarineLife = 19,
            /// <summary>
            /// Enum Iceberg for value: Iceberg
            /// </summary>
            [EnumMember(Value = "Iceberg")]
            Iceberg = 20,
            /// <summary>
            /// Enum DitchedAircraft for value: DitchedAircraft
            /// </summary>
            [EnumMember(Value = "DitchedAircraft")]
            DitchedAircraft = 21,
            /// <summary>
            /// Enum ManInWater for value: ManInWater
            /// </summary>
            [EnumMember(Value = "ManInWater")]
            ManInWater = 22,
            /// <summary>
            /// Enum DistressedVessel for value: DistressedVessel
            /// </summary>
            [EnumMember(Value = "DistressedVessel")]
            DistressedVessel = 23,
            /// <summary>
            /// Enum OilPlatform for value: OilPlatform
            /// </summary>
            [EnumMember(Value = "OilPlatform")]
            OilPlatform = 24,
            /// <summary>
            /// Enum AirHelo for value: AirHelo
            /// </summary>
            [EnumMember(Value = "AirHelo")]
            AirHelo = 25,
            /// <summary>
            /// Enum AirFixedWing for value: AirFixedWing
            /// </summary>
            [EnumMember(Value = "AirFixedWing")]
            AirFixedWing = 26,
            /// <summary>
            /// Enum SubsurfaceUnknown for value: SubsurfaceUnknown
            /// </summary>
            [EnumMember(Value = "SubsurfaceUnknown")]
            SubsurfaceUnknown = 27,
            /// <summary>
            /// Enum AirUnknown for value: AirUnknown
            /// </summary>
            [EnumMember(Value = "AirUnknown")]
            AirUnknown = 28,
            /// <summary>
            /// Enum Ownship for value: Ownship
            /// </summary>
            [EnumMember(Value = "Ownship")]
            Ownship = 29,
            /// <summary>
            /// Enum Land for value: Land
            /// </summary>
            [EnumMember(Value = "Land")]
            Land = 30,
            /// <summary>
            /// Enum Buoy for value: Buoy
            /// </summary>
            [EnumMember(Value = "Buoy")]
            Buoy = 31,
            /// <summary>
            /// Enum AirUAV for value: AirUAV
            /// </summary>
            [EnumMember(Value = "AirUAV")]
            AirUAV = 32,
            /// <summary>
            /// Enum RigidHullInflatable for value: RigidHullInflatable
            /// </summary>
            [EnumMember(Value = "RigidHullInflatable")]
            RigidHullInflatable = 33,
            /// <summary>
            /// Enum Speedboat for value: Speedboat
            /// </summary>
            [EnumMember(Value = "Speedboat")]
            Speedboat = 34,
            /// <summary>
            /// Enum OilTanker for value: OilTanker
            /// </summary>
            [EnumMember(Value = "OilTanker")]
            OilTanker = 35        }
        /// <summary>
        /// Classification of this track
        /// </summary>
        /// <value>Classification of this track</value>
        [DataMember(Name="classification", EmitDefaultValue=false)]
        public ClassificationEnum? Classification { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="TrackClassificationRestDto" /> class.
        /// </summary>
        /// <param name="classification">Classification of this track.</param>
        public TrackClassificationRestDto(ClassificationEnum? classification = default(ClassificationEnum?))
        {
            this.Classification = classification;
        }
        

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TrackClassificationRestDto {\n");
            sb.Append("  Classification: ").Append(Classification).Append("\n");
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
            return this.Equals(input as TrackClassificationRestDto);
        }

        /// <summary>
        /// Returns true if TrackClassificationRestDto instances are equal
        /// </summary>
        /// <param name="input">Instance of TrackClassificationRestDto to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TrackClassificationRestDto input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Classification == input.Classification ||
                    (this.Classification != null &&
                    this.Classification.Equals(input.Classification))
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
                if (this.Classification != null)
                    hashCode = hashCode * 59 + this.Classification.GetHashCode();
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