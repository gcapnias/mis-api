# IO.Swagger.Model.TrackGtcDetailRestDto
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AisAntPos** | [**AisAntPosRestDto**](AisAntPosRestDto.md) |  | [optional] 
**AisEta** | **string** | The Estimated Time of Arrival {Source AIS Transponder} | [optional] 
**AisFixingDevice** | [**AisFixingDeviceRestDto**](AisFixingDeviceRestDto.md) |  | [optional] 
**AisMaxDraft** | **float?** | [0 to 25.5]: Max draft (draught) of the track (meters) {Source AIS Transponder} | [optional] 
**AisMessageId** | **int?** | The AIS reported message id {Source AIS Transponder} | [optional] 
**AisSize** | [**AisSizeRestDto**](AisSizeRestDto.md) |  | [optional] 
**AisTypeOfShip** | [**AisShipTypeRestDto**](AisShipTypeRestDto.md) |  | [optional] 
**CallSign** | **string** | Call Sign {Source AIS Transponder} | [optional] 
**Destination** | **string** | Destination {Source AIS Transponder} | [optional] 
**ExtTrkId** | **int?** | A track Id that was provided from an external source | [optional] 
**Imo** | **int?** | IMO number {Source AIS Transponder} | [optional] 
**MOfn** | **int?** | Number of times this track seen in last 10 consecutive radar scans. (Applicable only for Radar Tracks) | [optional] 
**Maneuvering** | **string** | Represents whether the track is maneuvering or not. | [optional] 
**Mmsi** | **int?** | MMSI number {Source AIS Transponder} | [optional] 
**SpecialIndicators** | **List&lt;string&gt;** | An array of strings representing special indicators about this track&lt;br&gt;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;Interpretation:&lt;br&gt;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;BFT: Track is transmitting valid encrypted position reports&lt;br&gt;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;DscDistress: Track sent a DSC Distressed Vessel signal | [optional] 
**TrackingManual** | **string** | Represents how the tracker handles this track for Radar Tracks. Set to &#x27;Manual&#x27; if tracking manually | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

