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
    /// ReportedTimeRestDto
    /// </summary>
    [DataContract]
        public partial class ReportedTimeRestDto :  IEquatable<ReportedTimeRestDto>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ReportedTimeRestDto" /> class.
        /// </summary>
        /// <param name="lastReported">Date and time of the last received report. &lt;br&gt;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;Example Value: 2019-03-14T14:55:00Z specifies a year-month-day followed by 24-hour hours:minutes:seconds in GMT time.</param>
        /// <param name="secondsSinceLastReport">How long ago the last report was received in seconds.</param>
        public ReportedTimeRestDto(string lastReported = default(string), int? secondsSinceLastReport = default(int?))
        {
            this.LastReported = lastReported;
            this.SecondsSinceLastReport = secondsSinceLastReport;
        }
        
        /// <summary>
        /// Date and time of the last received report. &lt;br&gt;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;Example Value: 2019-03-14T14:55:00Z specifies a year-month-day followed by 24-hour hours:minutes:seconds in GMT time
        /// </summary>
        /// <value>Date and time of the last received report. &lt;br&gt;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;Example Value: 2019-03-14T14:55:00Z specifies a year-month-day followed by 24-hour hours:minutes:seconds in GMT time</value>
        [DataMember(Name="lastReported", EmitDefaultValue=false)]
        public string LastReported { get; set; }

        /// <summary>
        /// How long ago the last report was received in seconds
        /// </summary>
        /// <value>How long ago the last report was received in seconds</value>
        [DataMember(Name="secondsSinceLastReport", EmitDefaultValue=false)]
        public int? SecondsSinceLastReport { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ReportedTimeRestDto {\n");
            sb.Append("  LastReported: ").Append(LastReported).Append("\n");
            sb.Append("  SecondsSinceLastReport: ").Append(SecondsSinceLastReport).Append("\n");
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
            return this.Equals(input as ReportedTimeRestDto);
        }

        /// <summary>
        /// Returns true if ReportedTimeRestDto instances are equal
        /// </summary>
        /// <param name="input">Instance of ReportedTimeRestDto to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ReportedTimeRestDto input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.LastReported == input.LastReported ||
                    (this.LastReported != null &&
                    this.LastReported.Equals(input.LastReported))
                ) && 
                (
                    this.SecondsSinceLastReport == input.SecondsSinceLastReport ||
                    (this.SecondsSinceLastReport != null &&
                    this.SecondsSinceLastReport.Equals(input.SecondsSinceLastReport))
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
                if (this.LastReported != null)
                    hashCode = hashCode * 59 + this.LastReported.GetHashCode();
                if (this.SecondsSinceLastReport != null)
                    hashCode = hashCode * 59 + this.SecondsSinceLastReport.GetHashCode();
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