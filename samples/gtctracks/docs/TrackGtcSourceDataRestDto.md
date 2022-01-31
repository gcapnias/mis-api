# IO.Swagger.Model.TrackGtcSourceDataRestDto
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Affiliation** | **string** | Affiliation of this track (Not shown if &#x27;Unknown&#x27;) | [optional] 
**Classification** | **string** | Classification of this track (Not shown if &#x27;Unknown&#x27;) | [optional] 
**Kinematics** | [**KinematicsRestDto**](KinematicsRestDto.md) |  | [optional] 
**LocalId** | **int?** | the local track id | 
**MOfn** | **int?** | Number of times this track seen in last 10 consecutive radar scans. (Applicable only for Radar Tracks) | [optional] 
**Maneuvering** | **string** | Represents whether the track is maneuvering or not. | [optional] 
**Name** | **string** | name of the track as set by AIS or user. This field is DEPRECATED and may no longer be populated. Rely on the name field at the top level (under TrackGtc) | 
**PosUncertainty** | **int?** | area of positional uncertainty around this track (meters) | 
**Position** | [**GeoPosRestDto**](GeoPosRestDto.md) |  | 
**Quality** | **byte[]** | [0-15]: quality of this track | 
**State** | **string** | current state of this track (&#x27;Dropped&#x27; means track has either been specifically dropped or has not been updated by the tracker and will be removed from the system) | 
**TrackSource** | [**TrackGtcSourceRestDto**](TrackGtcSourceRestDto.md) |  | [optional] 
**TrackingManual** | **string** | Represents how the tracker handles this track for Radar Tracks. Set to &#x27;Manual&#x27; if tracking manually | [optional] 
**TurnRate** | **float?** | [-12.0 to 12.0]: Turn rate of this track (degrees per second) {Source AIS Transponder or Radar} | [optional] 
**UpdateDelta** | **int?** | [0 to 255]: delta time since the track was last seen (seconds)  {Source AIS Transponder or Radar} | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

