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
        public partial class CameraCommandPelcoRestDto :  IEquatable<CameraCommandPelcoRestDto>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CameraCommandPelcoRestDto" /> class.
        /// </summary>
        /// <param name="command1">Pelco Command 1.</param>
        /// <param name="command2">Pelco Command 2.</param>
        /// <param name="data1">Data for Pelco Command 1.</param>
        /// <param name="data2">Data for Pelco Command 2.</param>
        public CameraCommandPelcoRestDto(int? command1 = default(int?), int? command2 = default(int?), int? data1 = default(int?), int? data2 = default(int?))
        {
            this.Command1 = command1;
            this.Command2 = command2;
            this.Data1 = data1;
            this.Data2 = data2;
        }
        
        /// <summary>
        /// Pelco Command 1
        /// </summary>
        /// <value>Pelco Command 1</value>
        [DataMember(Name="command1", EmitDefaultValue=false)]
        public int? Command1 { get; set; }

        /// <summary>
        /// Pelco Command 2
        /// </summary>
        /// <value>Pelco Command 2</value>
        [DataMember(Name="command2", EmitDefaultValue=false)]
        public int? Command2 { get; set; }

        /// <summary>
        /// Data for Pelco Command 1
        /// </summary>
        /// <value>Data for Pelco Command 1</value>
        [DataMember(Name="data1", EmitDefaultValue=false)]
        public int? Data1 { get; set; }

        /// <summary>
        /// Data for Pelco Command 2
        /// </summary>
        /// <value>Data for Pelco Command 2</value>
        [DataMember(Name="data2", EmitDefaultValue=false)]
        public int? Data2 { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CameraCommandPelcoRestDto {\n");
            sb.Append("  Command1: ").Append(Command1).Append("\n");
            sb.Append("  Command2: ").Append(Command2).Append("\n");
            sb.Append("  Data1: ").Append(Data1).Append("\n");
            sb.Append("  Data2: ").Append(Data2).Append("\n");
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
            return this.Equals(input as CameraCommandPelcoRestDto);
        }

        /// <summary>
        /// Returns true if CameraCommandPelcoRestDto instances are equal
        /// </summary>
        /// <param name="input">Instance of CameraCommandPelcoRestDto to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CameraCommandPelcoRestDto input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Command1 == input.Command1 ||
                    (this.Command1 != null &&
                    this.Command1.Equals(input.Command1))
                ) && 
                (
                    this.Command2 == input.Command2 ||
                    (this.Command2 != null &&
                    this.Command2.Equals(input.Command2))
                ) && 
                (
                    this.Data1 == input.Data1 ||
                    (this.Data1 != null &&
                    this.Data1.Equals(input.Data1))
                ) && 
                (
                    this.Data2 == input.Data2 ||
                    (this.Data2 != null &&
                    this.Data2.Equals(input.Data2))
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
                if (this.Command1 != null)
                    hashCode = hashCode * 59 + this.Command1.GetHashCode();
                if (this.Command2 != null)
                    hashCode = hashCode * 59 + this.Command2.GetHashCode();
                if (this.Data1 != null)
                    hashCode = hashCode * 59 + this.Data1.GetHashCode();
                if (this.Data2 != null)
                    hashCode = hashCode * 59 + this.Data2.GetHashCode();
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