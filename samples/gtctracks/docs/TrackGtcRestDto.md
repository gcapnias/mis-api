# IO.Swagger.Model.TrackGtcRestDto
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Affiliation** | **string** | Affiliation of this track (Not shown if &#x27;Unknown&#x27;) {Source AIS Transponder} | [optional] 
**AisClass** | **string** | Class of AIS. &#x27;B&#x27; for Class B, not shown for class A {source AIS Transponder} | [optional] 
**AisHeading** | **float?** | Heading of this track (degrees true) {Source AIS Transponder} | [optional] 
**AisIndicators** | **List&lt;string&gt;** | AIS indicator flags. Not shown if none.{source AIS Transponder} | [optional] 
**AisNavStatus** | [**AisNavStatusRestDto**](AisNavStatusRestDto.md) |  | [optional] 
**Boarding** | **string** | Current boarding status of this track, used for Boarding Operations. (Not shown for &#x27;NoInterest&#x27; boarding status) | [optional] 
**Classification** | **string** | Classification of this track (Not shown if &#x27;Unknown&#x27;) {Source AIS Transponder} | [optional] 
**Detail** | [**TrackGtcDetailRestDto**](TrackGtcDetailRestDto.md) |  | [optional] 
**Kinematics** | [**KinematicsRestDto**](KinematicsRestDto.md) |  | [optional] 
**Links** | [**List&lt;Link&gt;**](Link.md) | *method&#x3D;GET*Provides link relations as URLs using the REST &#x27;hateoas&#x27; convention (for REST delivered data).&lt;br&gt;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;The &#x27;self&#x27; link references this rest object, including any specified query criteria | [optional] 
**MaxDelayInterval** | **int?** | Maximum delayed interval (in seconds) that a track can be reported from the Tracker. The delay interval of tracks will vary from no delay (if no delay this field is absent) to this given reported interval. (The delay is based on speed; the slower the speed the greater the delay.) The track update time field matches the reported time even if the track is delayed (and the &#x27;updateSince&#x27; query results work accordingly.) This is reported at the top-level enclosing object; ie, it is not reported for each single track if it&#x27;s a multi-track lookup | [optional] 
**Name** | **string** | name of the track as set by AIS or user | 
**PosUncertainty** | **int?** | area of positional uncertainty around this track (meters) | 
**Position** | [**GeoPosRestDto**](GeoPosRestDto.md) |  | 
**PreferredTrackSource** | [**TrackGtcSourceRestDto**](TrackGtcSourceRestDto.md) |  | [optional] 
**Quality** | **byte[]** | [0-15]: quality of this track | 
**Sources** | [**List&lt;TrackGtcSourceDataRestDto&gt;**](TrackGtcSourceDataRestDto.md) | ranked order of the various sources available to the Track Correlator tracker for this track. Available if the expand parameter includes &#x27;sources&#x27; | [optional] 
**State** | **string** | current state of this track (&#x27;Dropped&#x27; means track has either been specifically dropped or has not been updated by the tracker and will be removed from the system). Not shown if &#x27;Steady&#x27; | 
**Time** | **string** | time this track was updated by the Tracker | 
**TrackIDsResetTime** | **int?** | this value is used to communicate if the Track Ids are reset and no longer related to their past Ids. This value gets changed if the Tracker is restarted or all tracks are dropped. Compare this with the previous track id reset time to know if the IDs represent the same track. This is reported at the top-level enclosing object; ie, it is not reported for each single track if it&#x27;s a multi-track lookup | [optional] 
**TrackId** | **string** | the track id (eg &#x27;R1S3_17).&lt;br&gt;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;Represents a Global Track Correlator track starting with &#x27;R&#x27; for region and then the region number,&lt;br&gt;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;followed by &#x27;S&#x27; for source and then the &#x27;TSI&#x27; (Track Source Id),&lt;br&gt;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;followed by &#x27;_&#x27; and then the id within this Region and Source | [optional] 
**TurnRate** | **float?** | [-12.0 to 12.0]: Turn rate of this track (degrees per second) {Source AIS Transponder or Radar} | [optional] 
**UpdateDelta** | **int?** | [0 to 255]: delta time since the track was last seen (seconds)  {Source AIS Transponder or Radar} | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

