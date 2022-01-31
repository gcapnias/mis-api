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
    /// Container for multiple GTC Tracks
    /// </summary>
    [DataContract]
        public partial class TrackGtcsRestDto :  IEquatable<TrackGtcsRestDto>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TrackGtcsRestDto" /> class.
        /// </summary>
        /// <param name="items">An array of GTC Tracks matching the query criteria.</param>
        /// <param name="links">*method&#x3D;GET*Provides link relations as URLs using the REST &#x27;hateoas&#x27; convention (for REST delivered data).&lt;br&gt;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;The &#x27;self&#x27; link references this rest object, including any specified query criteria.</param>
        /// <param name="maxDelayInterval">Maximum delayed interval (in seconds) that a track can be reported from the Tracker. The delay interval of tracks will vary from no delay (if no delay this field is absent) to this given reported interval. (The delay is based on speed; the slower the speed the greater the delay.) The track update time field matches the reported time even if the track is delayed (and the &#x27;updateSince&#x27; query results work accordingly.) This is reported at the top-level enclosing object; ie, it is not reported for each single track if it&#x27;s a multi-track lookup.</param>
        /// <param name="totalItems">Total number of elements matching the query filter and not limited by page size (Shown for REST delivered data).</param>
        /// <param name="trackIDsResetTime">this value is used to communicate if the Track Ids are reset and no longer related to their past Ids. This value gets changed if the Tracker is restarted or all tracks are dropped. Compare this with the previous track id reset time to know if the IDs represent the same track. This is reported at the top-level enclosing object; ie, it is not reported for each single track if it&#x27;s a multi-track lookup.</param>
        /// <param name="ws">ws.</param>
        public TrackGtcsRestDto(List<TrackGtcRestDto> items = default(List<TrackGtcRestDto>), List<Link> links = default(List<Link>), int? maxDelayInterval = default(int?), long? totalItems = default(long?), int? trackIDsResetTime = default(int?), WsHeaderInfoRestDto ws = default(WsHeaderInfoRestDto))
        {
            this.Items = items;
            this.Links = links;
            this.MaxDelayInterval = maxDelayInterval;
            this.TotalItems = totalItems;
            this.TrackIDsResetTime = trackIDsResetTime;
            this.Ws = ws;
        }
        
        /// <summary>
        /// An array of GTC Tracks matching the query criteria
        /// </summary>
        /// <value>An array of GTC Tracks matching the query criteria</value>
        [DataMember(Name="items", EmitDefaultValue=false)]
        public List<TrackGtcRestDto> Items { get; set; }

        /// <summary>
        /// *method&#x3D;GET*Provides link relations as URLs using the REST &#x27;hateoas&#x27; convention (for REST delivered data).&lt;br&gt;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;The &#x27;self&#x27; link references this rest object, including any specified query criteria
        /// </summary>
        /// <value>*method&#x3D;GET*Provides link relations as URLs using the REST &#x27;hateoas&#x27; convention (for REST delivered data).&lt;br&gt;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;The &#x27;self&#x27; link references this rest object, including any specified query criteria</value>
        [DataMember(Name="links", EmitDefaultValue=false)]
        public List<Link> Links { get; set; }

        /// <summary>
        /// Maximum delayed interval (in seconds) that a track can be reported from the Tracker. The delay interval of tracks will vary from no delay (if no delay this field is absent) to this given reported interval. (The delay is based on speed; the slower the speed the greater the delay.) The track update time field matches the reported time even if the track is delayed (and the &#x27;updateSince&#x27; query results work accordingly.) This is reported at the top-level enclosing object; ie, it is not reported for each single track if it&#x27;s a multi-track lookup
        /// </summary>
        /// <value>Maximum delayed interval (in seconds) that a track can be reported from the Tracker. The delay interval of tracks will vary from no delay (if no delay this field is absent) to this given reported interval. (The delay is based on speed; the slower the speed the greater the delay.) The track update time field matches the reported time even if the track is delayed (and the &#x27;updateSince&#x27; query results work accordingly.) This is reported at the top-level enclosing object; ie, it is not reported for each single track if it&#x27;s a multi-track lookup</value>
        [DataMember(Name="maxDelayInterval", EmitDefaultValue=false)]
        public int? MaxDelayInterval { get; set; }

        /// <summary>
        /// Total number of elements matching the query filter and not limited by page size (Shown for REST delivered data)
        /// </summary>
        /// <value>Total number of elements matching the query filter and not limited by page size (Shown for REST delivered data)</value>
        [DataMember(Name="totalItems", EmitDefaultValue=false)]
        public long? TotalItems { get; set; }

        /// <summary>
        /// this value is used to communicate if the Track Ids are reset and no longer related to their past Ids. This value gets changed if the Tracker is restarted or all tracks are dropped. Compare this with the previous track id reset time to know if the IDs represent the same track. This is reported at the top-level enclosing object; ie, it is not reported for each single track if it&#x27;s a multi-track lookup
        /// </summary>
        /// <value>this value is used to communicate if the Track Ids are reset and no longer related to their past Ids. This value gets changed if the Tracker is restarted or all tracks are dropped. Compare this with the previous track id reset time to know if the IDs represent the same track. This is reported at the top-level enclosing object; ie, it is not reported for each single track if it&#x27;s a multi-track lookup</value>
        [DataMember(Name="trackIDsResetTime", EmitDefaultValue=false)]
        public int? TrackIDsResetTime { get; set; }

        /// <summary>
        /// Gets or Sets Ws
        /// </summary>
        [DataMember(Name="ws", EmitDefaultValue=false)]
        public WsHeaderInfoRestDto Ws { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TrackGtcsRestDto {\n");
            sb.Append("  Items: ").Append(Items).Append("\n");
            sb.Append("  Links: ").Append(Links).Append("\n");
            sb.Append("  MaxDelayInterval: ").Append(MaxDelayInterval).Append("\n");
            sb.Append("  TotalItems: ").Append(TotalItems).Append("\n");
            sb.Append("  TrackIDsResetTime: ").Append(TrackIDsResetTime).Append("\n");
            sb.Append("  Ws: ").Append(Ws).Append("\n");
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
            return this.Equals(input as TrackGtcsRestDto);
        }

        /// <summary>
        /// Returns true if TrackGtcsRestDto instances are equal
        /// </summary>
        /// <param name="input">Instance of TrackGtcsRestDto to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TrackGtcsRestDto input)
        {
            if (input == null)
                return false;

            return 
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
                    this.MaxDelayInterval == input.MaxDelayInterval ||
                    (this.MaxDelayInterval != null &&
                    this.MaxDelayInterval.Equals(input.MaxDelayInterval))
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
                ) && 
                (
                    this.Ws == input.Ws ||
                    (this.Ws != null &&
                    this.Ws.Equals(input.Ws))
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
                if (this.Items != null)
                    hashCode = hashCode * 59 + this.Items.GetHashCode();
                if (this.Links != null)
                    hashCode = hashCode * 59 + this.Links.GetHashCode();
                if (this.MaxDelayInterval != null)
                    hashCode = hashCode * 59 + this.MaxDelayInterval.GetHashCode();
                if (this.TotalItems != null)
                    hashCode = hashCode * 59 + this.TotalItems.GetHashCode();
                if (this.TrackIDsResetTime != null)
                    hashCode = hashCode * 59 + this.TrackIDsResetTime.GetHashCode();
                if (this.Ws != null)
                    hashCode = hashCode * 59 + this.Ws.GetHashCode();
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