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
    /// Container for multiple Tracks
    /// </summary>
    [DataContract]
        public partial class TracksRestDto :  IEquatable<TracksRestDto>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TracksRestDto" /> class.
        /// </summary>
        /// <param name="isSourceGtc">if this gets reported as &#x27;true&#x27; then it signifies the source of all tracks is from the GTC tracker instead of the Composite Tracker. (This field is absent means the same as &#x27;false&#x27;.) This means the data fields are to be interpreted based on the GTC track field&#x27;s descriptions and the track reporting interval follows the GTC track reporting interval. (See the GTC track field &#x27;maxDelayInterval&#x27; to see more information on this.) This is reported at the top-level enclosing object; ie, it is not reported for each single track if it&#x27;s a multi-track lookup.</param>
        /// <param name="items">An array of Tracks matching the query criteria.</param>
        /// <param name="links">*method&#x3D;GET*Provides link relations as URLs using the REST &#x27;hateoas&#x27; convention (for REST delivered data).&lt;br&gt;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;The &#x27;self&#x27; link references this rest object, including any specified query criteria.</param>
        /// <param name="totalItems">Total number of elements matching the query filter and not limited by page size.</param>
        /// <param name="trackIDsResetTime">this value is used to communicate if the Track Ids are reset and no longer related to their past Ids. This value gets changed if the Tracker is restarted or all tracks are dropped. Compare this with the previous track id reset time to know if the IDs represent the same track. This is reported at the top-level enclosing object; ie, it is not reported for each single track if it&#x27;s a multi-track lookup.</param>
        public TracksRestDto(bool? isSourceGtc = default(bool?), List<TrackRestDto> items = default(List<TrackRestDto>), List<Link> links = default(List<Link>), long? totalItems = default(long?), int? trackIDsResetTime = default(int?))
        {
            this.IsSourceGtc = isSourceGtc;
            this.Items = items;
            this.Links = links;
            this.TotalItems = totalItems;
            this.TrackIDsResetTime = trackIDsResetTime;
        }
        
        /// <summary>
        /// if this gets reported as &#x27;true&#x27; then it signifies the source of all tracks is from the GTC tracker instead of the Composite Tracker. (This field is absent means the same as &#x27;false&#x27;.) This means the data fields are to be interpreted based on the GTC track field&#x27;s descriptions and the track reporting interval follows the GTC track reporting interval. (See the GTC track field &#x27;maxDelayInterval&#x27; to see more information on this.) This is reported at the top-level enclosing object; ie, it is not reported for each single track if it&#x27;s a multi-track lookup
        /// </summary>
        /// <value>if this gets reported as &#x27;true&#x27; then it signifies the source of all tracks is from the GTC tracker instead of the Composite Tracker. (This field is absent means the same as &#x27;false&#x27;.) This means the data fields are to be interpreted based on the GTC track field&#x27;s descriptions and the track reporting interval follows the GTC track reporting interval. (See the GTC track field &#x27;maxDelayInterval&#x27; to see more information on this.) This is reported at the top-level enclosing object; ie, it is not reported for each single track if it&#x27;s a multi-track lookup</value>
        [DataMember(Name="isSourceGtc", EmitDefaultValue=false)]
        public bool? IsSourceGtc { get; set; }

        /// <summary>
        /// An array of Tracks matching the query criteria
        /// </summary>
        /// <value>An array of Tracks matching the query criteria</value>
        [DataMember(Name="items", EmitDefaultValue=false)]
        public List<TrackRestDto> Items { get; set; }

        /// <summary>
        /// *method&#x3D;GET*Provides link relations as URLs using the REST &#x27;hateoas&#x27; convention (for REST delivered data).&lt;br&gt;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;The &#x27;self&#x27; link references this rest object, including any specified query criteria
        /// </summary>
        /// <value>*method&#x3D;GET*Provides link relations as URLs using the REST &#x27;hateoas&#x27; convention (for REST delivered data).&lt;br&gt;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;The &#x27;self&#x27; link references this rest object, including any specified query criteria</value>
        [DataMember(Name="links", EmitDefaultValue=false)]
        public List<Link> Links { get; set; }

        /// <summary>
        /// Total number of elements matching the query filter and not limited by page size
        /// </summary>
        /// <value>Total number of elements matching the query filter and not limited by page size</value>
        [DataMember(Name="totalItems", EmitDefaultValue=false)]
        public long? TotalItems { get; set; }

        /// <summary>
        /// this value is used to communicate if the Track Ids are reset and no longer related to their past Ids. This value gets changed if the Tracker is restarted or all tracks are dropped. Compare this with the previous track id reset time to know if the IDs represent the same track. This is reported at the top-level enclosing object; ie, it is not reported for each single track if it&#x27;s a multi-track lookup
        /// </summary>
        /// <value>this value is used to communicate if the Track Ids are reset and no longer related to their past Ids. This value gets changed if the Tracker is restarted or all tracks are dropped. Compare this with the previous track id reset time to know if the IDs represent the same track. This is reported at the top-level enclosing object; ie, it is not reported for each single track if it&#x27;s a multi-track lookup</value>
        [DataMember(Name="trackIDsResetTime", EmitDefaultValue=false)]
        public int? TrackIDsResetTime { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TracksRestDto {\n");
            sb.Append("  IsSourceGtc: ").Append(IsSourceGtc).Append("\n");
            sb.Append("  Items: ").Append(Items).Append("\n");
            sb.Append("  Links: ").Append(Links).Append("\n");
            sb.Append("  TotalItems: ").Append(TotalItems).Append("\n");
            sb.Append("  TrackIDsResetTime: ").Append(TrackIDsResetTime).Append("\n");
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
            return this.Equals(input as TracksRestDto);
        }

        /// <summary>
        /// Returns true if TracksRestDto instances are equal
        /// </summary>
        /// <param name="input">Instance of TracksRestDto to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TracksRestDto input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.IsSourceGtc == input.IsSourceGtc ||
                    (this.IsSourceGtc != null &&
                    this.IsSourceGtc.Equals(input.IsSourceGtc))
                ) && 
                (
                    this.Items == input.Items ||
                    this.Items != null &&
                    input.Items != null &&
                    this.Items.SequenceEqual(input.Items)
                ) && 
                (
                    this.Links == input.Links ||
                    this.Links != null &&
                    input.Links != null &&
                    this.Links.SequenceEqual(input.Links)
                ) && 
                (
                    this.TotalItems == input.TotalItems ||
                    (this.TotalItems != null &&
                    this.TotalItems.Equals(input.TotalItems))
                ) && 
                (
                    this.TrackIDsResetTime == input.TrackIDsResetTime ||
                    (this.TrackIDsResetTime != null &&
                    this.TrackIDsResetTime.Equals(input.TrackIDsResetTime))
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
                if (this.IsSourceGtc != null)
                    hashCode = hashCode * 59 + this.IsSourceGtc.GetHashCode();
                if (this.Items != null)
                    hashCode = hashCode * 59 + this.Items.GetHashCode();
                if (this.Links != null)
                    hashCode = hashCode * 59 + this.Links.GetHashCode();
                if (this.TotalItems != null)
                    hashCode = hashCode * 59 + this.TotalItems.GetHashCode();
                if (this.TrackIDsResetTime != null)
                    hashCode = hashCode * 59 + this.TrackIDsResetTime.GetHashCode();
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
