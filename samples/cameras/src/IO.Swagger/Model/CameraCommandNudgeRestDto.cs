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
        public partial class CameraCommandNudgeRestDto :  IEquatable<CameraCommandNudgeRestDto>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CameraCommandNudgeRestDto" /> class.
        /// </summary>
        /// <param name="down">[0 to 90]:Move camera down this many degrees.</param>
        /// <param name="left">[0 to 90]:Move camera left this many degrees.</param>
        /// <param name="right">[0 to 90]:Move camera right this many degrees.</param>
        /// <param name="up">[0 to 90]:Move camera up this many degrees.</param>
        public CameraCommandNudgeRestDto(int? down = default(int?), int? left = default(int?), int? right = default(int?), int? up = default(int?))
        {
            this.Down = down;
            this.Left = left;
            this.Right = right;
            this.Up = up;
        }
        
        /// <summary>
        /// [0 to 90]:Move camera down this many degrees
        /// </summary>
        /// <value>[0 to 90]:Move camera down this many degrees</value>
        [DataMember(Name="down", EmitDefaultValue=false)]
        public int? Down { get; set; }

        /// <summary>
        /// [0 to 90]:Move camera left this many degrees
        /// </summary>
        /// <value>[0 to 90]:Move camera left this many degrees</value>
        [DataMember(Name="left", EmitDefaultValue=false)]
        public int? Left { get; set; }

        /// <summary>
        /// [0 to 90]:Move camera right this many degrees
        /// </summary>
        /// <value>[0 to 90]:Move camera right this many degrees</value>
        [DataMember(Name="right", EmitDefaultValue=false)]
        public int? Right { get; set; }

        /// <summary>
        /// [0 to 90]:Move camera up this many degrees
        /// </summary>
        /// <value>[0 to 90]:Move camera up this many degrees</value>
        [DataMember(Name="up", EmitDefaultValue=false)]
        public int? Up { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CameraCommandNudgeRestDto {\n");
            sb.Append("  Down: ").Append(Down).Append("\n");
            sb.Append("  Left: ").Append(Left).Append("\n");
            sb.Append("  Right: ").Append(Right).Append("\n");
            sb.Append("  Up: ").Append(Up).Append("\n");
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
            return this.Equals(input as CameraCommandNudgeRestDto);
        }

        /// <summary>
        /// Returns true if CameraCommandNudgeRestDto instances are equal
        /// </summary>
        /// <param name="input">Instance of CameraCommandNudgeRestDto to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CameraCommandNudgeRestDto input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Down == input.Down ||
                    (this.Down != null &&
                    this.Down.Equals(input.Down))
                ) && 
                (
                    this.Left == input.Left ||
                    (this.Left != null &&
                    this.Left.Equals(input.Left))
                ) && 
                (
                    this.Right == input.Right ||
                    (this.Right != null &&
                    this.Right.Equals(input.Right))
                ) && 
                (
                    this.Up == input.Up ||
                    (this.Up != null &&
                    this.Up.Equals(input.Up))
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
                if (this.Down != null)
                    hashCode = hashCode * 59 + this.Down.GetHashCode();
                if (this.Left != null)
                    hashCode = hashCode * 59 + this.Left.GetHashCode();
                if (this.Right != null)
                    hashCode = hashCode * 59 + this.Right.GetHashCode();
                if (this.Up != null)
                    hashCode = hashCode * 59 + this.Up.GetHashCode();
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
