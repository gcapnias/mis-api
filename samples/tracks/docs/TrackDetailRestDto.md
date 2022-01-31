# IO.Swagger.Model.TrackDetailRestDto
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AcqMode** | **string** | Represents how the track was initiated by the tracker, automatically through a graphic or manually by the operator (or AIS) | 
**AisAntPos** | [**AisAntPosRestDto**](AisAntPosRestDto.md) |  | [optional] 
**AisEta** | **string** | The Estimated Time of Arrival {Source AIS Transponder} | [optional] 
**AisFixingDevice** | [**AisFixingDeviceRestDto**](AisFixingDeviceRestDto.md) |  | [optional] 
**AisMaxDraft** | **float?** | [0 to 25.5]: Max draft (draught) of the track (meters) {Source AIS Transponder} | [optional] 
**AisTypeOfShip** | [**AisShipTypeRestDto**](AisShipTypeRestDto.md) |  | [optional] 
**ExtTrkId** | **int?** | A track Id that was provided from an external source | [optional] 
**Id** | **string** | the resource identifier; the track id (like &#x27;COM0100100&#x27;) | [optional] 
**ImoNumber** | **int?** | IMO number | [optional] 
**Links** | [**List&lt;Link&gt;**](Link.md) | *method&#x3D;GET*Provides link relations as URLs using the REST &#x27;hateoas&#x27; convention (for REST delivered data).&lt;br&gt;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;The &#x27;self&#x27; link references this rest object, including any specified query criteria | [optional] 
**MmsiNumber** | **int?** | MMSI number | [optional] 
**SizeType** | [**AisSizeRestDto**](AisSizeRestDto.md) |  | [optional] 
**SpecialIndicators** | **List&lt;string&gt;** | An array of strings representing special indicators about this track&lt;br&gt;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;Interpretation:&lt;br&gt;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;HighInterest / NmeaReportable: Legacy use&lt;br&gt;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;BFT: Track is transmitting valid encrypted position reports&lt;br&gt;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;ToiLocal: Track designated as a TOI from a local source&lt;br&gt;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;ToiRemote: Track designated as a TOI from a remote source&lt;br&gt;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;DscDistress: Track sent a DSC Distressed Vessel signal | [optional] 
**TrkMode** | **string** | Represents how the tracker is currently tracking this track, manual tracks are handled differently than auto tracks. {See Track Quality} | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

