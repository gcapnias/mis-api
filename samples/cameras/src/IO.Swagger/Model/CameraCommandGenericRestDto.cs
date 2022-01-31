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
        public partial class CameraCommandGenericRestDto :  IEquatable<CameraCommandGenericRestDto>, IValidatableObject
    {
        /// <summary>
        /// Command name
        /// </summary>
        /// <value>Command name</value>
        [JsonConverter(typeof(StringEnumConverter))]
                public enum CommandEnum
        {
            /// <summary>
            /// Enum Wiper for value: Wiper
            /// </summary>
            [EnumMember(Value = "Wiper")]
            Wiper = 1,
            /// <summary>
            /// Enum IRMode for value: IRMode
            /// </summary>
            [EnumMember(Value = "IRMode")]
            IRMode = 2,
            /// <summary>
            /// Enum PanTilt for value: PanTilt
            /// </summary>
            [EnumMember(Value = "PanTilt")]
            PanTilt = 3,
            /// <summary>
            /// Enum Volume for value: Volume
            /// </summary>
            [EnumMember(Value = "Volume")]
            Volume = 4,
            /// <summary>
            /// Enum Mute for value: Mute
            /// </summary>
            [EnumMember(Value = "Mute")]
            Mute = 5,
            /// <summary>
            /// Enum Play for value: Play
            /// </summary>
            [EnumMember(Value = "Play")]
            Play = 6,
            /// <summary>
            /// Enum Polarity for value: Polarity
            /// </summary>
            [EnumMember(Value = "Polarity")]
            Polarity = 7,
            /// <summary>
            /// Enum Scene for value: Scene
            /// </summary>
            [EnumMember(Value = "Scene")]
            Scene = 8        }
        /// <summary>
        /// Command name
        /// </summary>
        /// <value>Command name</value>
        [DataMember(Name="command", EmitDefaultValue=false)]
        public CommandEnum? Command { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="CameraCommandGenericRestDto" /> class.
        /// </summary>
        /// <param name="command">Command name.</param>
        /// <param name="value1">CONFIRM THE FOLLOWING: First value for the given generic command (unchecked). For PanTilt, this is the pan (bearing) in degrees (where 0 is true north), For Volume, this is the volume level, For Mute, this is 0 (un-mute) or 1 (mute), For Scene, this is 1 thru 6 to represent the scene (the video client).</param>
        /// <param name="value2">CONFIRM THE FOLLOWING: Second value for the given generic command (unchecked). For PanTilt, this is the tilt in degrees, where 0 points down and 180 points up.</param>
        public CameraCommandGenericRestDto(CommandEnum? command = default(CommandEnum?), double? value1 = default(double?), double? value2 = default(double?))
        {
            this.Command = command;
            this.Value1 = value1;
            this.Value2 = value2;
        }
        

        /// <summary>
        /// CONFIRM THE FOLLOWING: First value for the given generic command (unchecked). For PanTilt, this is the pan (bearing) in degrees (where 0 is true north), For Volume, this is the volume level, For Mute, this is 0 (un-mute) or 1 (mute), For Scene, this is 1 thru 6 to represent the scene (the video client)
        /// </summary>
        /// <value>CONFIRM THE FOLLOWING: First value for the given generic command (unchecked). For PanTilt, this is the pan (bearing) in degrees (where 0 is true north), For Volume, this is the volume level, For Mute, this is 0 (un-mute) or 1 (mute), For Scene, this is 1 thru 6 to represent the scene (the video client)</value>
        [DataMember(Name="value1", EmitDefaultValue=false)]
        public double? Value1 { get; set; }

        /// <summary>
        /// CONFIRM THE FOLLOWING: Second value for the given generic command (unchecked). For PanTilt, this is the tilt in degrees, where 0 points down and 180 points up
        /// </summary>
        /// <value>CONFIRM THE FOLLOWING: Second value for the given generic command (unchecked). For PanTilt, this is the tilt in degrees, where 0 points down and 180 points up</value>
        [DataMember(Name="value2", EmitDefaultValue=false)]
        public double? Value2 { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CameraCommandGenericRestDto {\n");
            sb.Append("  Command: ").Append(Command).Append("\n");
            sb.Append("  Value1: ").Append(Value1).Append("\n");
            sb.Append("  Value2: ").Append(Value2).Append("\n");
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
            return this.Equals(input as CameraCommandGenericRestDto);
        }

        /// <summary>
        /// Returns true if CameraCommandGenericRestDto instances are equal
        /// </summary>
        /// <param name="input">Instance of CameraCommandGenericRestDto to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CameraCommandGenericRestDto input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Command == input.Command ||
                    (this.Command != null &&
                    this.Command.Equals(input.Command))
                ) && 
                (
                    this.Value1 == input.Value1 ||
                    (this.Value1 != null &&
                    this.Value1.Equals(input.Value1))
                ) && 
                (
                    this.Value2 == input.Value2 ||
                    (this.Value2 != null &&
                    this.Value2.Equals(input.Value2))
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
                if (this.Command != null)
                    hashCode = hashCode * 59 + this.Command.GetHashCode();
                if (this.Value1 != null)
                    hashCode = hashCode * 59 + this.Value1.GetHashCode();
                if (this.Value2 != null)
                    hashCode = hashCode * 59 + this.Value2.GetHashCode();
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