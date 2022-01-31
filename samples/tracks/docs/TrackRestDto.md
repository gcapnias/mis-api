# IO.Swagger.Model.TrackRestDto
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Affiliation** | **string** | Affiliation of this track | [optional] 
**AisHeading** | **int?** | Heading of this track (degrees true) {Source AIS Transponder} | [optional] 
**AisNavStatus** | [**AisNavStatusRestDto**](AisNavStatusRestDto.md) |  | [optional] 
**AisTurnRate** | **float?** | [-12.0 to 12.0]: Turn rate of this track (degrees per second) {Source AIS Transponder} | [optional] 
**AisUpdateDelta** | **int?** | [0 to 255]: delta time since the last AIS message was received from the track&#x27;s AIS transponder (seconds) | [optional] 
**Bearing** | **float?** | [0.0 to 359.9]: track&#x27;s bearing from the reference point (degrees true) {Landbased: w.r.t Tracker Position, Shipboard: w.r.t Ownship Position} | 
**Boarding** | **string** | Current boarding status of this track, used for Boarding Operations | [optional] 
**Classification** | **string** | Classification of this track | [optional] 
**Details** | [**TrackDetailRestDto**](TrackDetailRestDto.md) |  | [optional] 
**Id** | **string** | the resource identifier; the track id (like &#x27;COM0100100&#x27;) | [optional] 
**Iff** | [**TrackIffRestDto**](TrackIffRestDto.md) |  | [optional] 
**IsSourceGtc** | **bool?** | if this gets reported as &#x27;true&#x27; then it signifies the source of all tracks is from the GTC tracker instead of the Composite Tracker. (This field is absent means the same as &#x27;false&#x27;.) This means the data fields are to be interpreted based on the GTC track field&#x27;s descriptions and the track reporting interval follows the GTC track reporting interval. (See the GTC track field &#x27;maxDelayInterval&#x27; to see more information on this.) This is reported at the top-level enclosing object; ie, it is not reported for each single track if it&#x27;s a multi-track lookup | [optional] 
**Kinematics** | [**KinematicsRestDto**](KinematicsRestDto.md) |  | [optional] 
**Links** | [**List&lt;Link&gt;**](Link.md) | *method&#x3D;GET*Provides link relations as URLs using the REST &#x27;hateoas&#x27; convention (for REST delivered data).&lt;br&gt;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;The &#x27;self&#x27; link references this rest object, including any specified query criteria,&lt;br&gt;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;The &#x27;rel/detail&#x27; link references this track&#x27;s detailed information,&lt;br&gt;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;The &#x27;rel/iff&#x27; link references this track&#x27;s IFF information, and exists if there is IFF information,&lt;br&gt;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;The &#x27;rel/ship&#x27; link references this track&#x27;s associated Ship, and exists if one can be found in the system. | [optional] 
**Name** | **string** | name of the track as set by AIS or user | 
**PosUncertainty** | **int?** | area of positional uncertainty around this track (meters) | 
**Position** | [**GeoPosRestDto**](GeoPosRestDto.md) |  | 
**Quality** | **int?** | [Auto Tracks: 0-36, Manual Tracks: 0-120]: quality of this track | 
**Range** | **float?** | track&#x27;s range from the reference point (meters) {Landbased: w.r.t Tracker Position, Shipboard: w.r.t Ownship Position} | 
**SensorSrcs** | **List&lt;string&gt;** | String array representing all the sensors contributing to this track | [optional] 
**State** | **string** | current state of this track (&#x27;Dropped&#x27; means track has either been specifically dropped OR has not been updated by the tracker and will be removed from the system) | 
**Time** | **string** | time this track was updated by the Composite Tracker | 
**TrackIDsResetTime** | **int?** | this value is used to communicate if the Track Ids are reset and no longer related to their past Ids. This value gets changed if the Tracker is restarted or all tracks are dropped. Compare this with the previous track id reset time to know if the IDs represent the same track. This is reported at the top-level enclosing object; ie, it is not reported for each single track if it&#x27;s a multi-track lookup | [optional] 
**UpdatingSrc** | **string** | [&#x27;NA&#x27; or &#x27;RP01&#x27;-&#x27;RP64&#x27; or &#x27;AIS&#x27; or &#x27;GEN01&#x27;-&#x27;GEN16&#x27;]: last updating source for this track | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

