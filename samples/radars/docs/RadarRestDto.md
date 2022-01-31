# IO.Swagger.Model.RadarRestDto
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AntennaRpm** | **float?** | measured RPM value of the radar | 
**Control** | [**RadarControlRestDto**](RadarControlRestDto.md) |  | 
**Detail** | [**RadarDetailRestDto**](RadarDetailRestDto.md) |  | 
**Id** | **int?** | [1-64]: the resource identifier; the radar id (the Radar Processor unit number) | [optional] 
**IsNotUpdating** | **bool?** | [true]: boolean representing if this resource is no longer being updated or seen in the system and will soon no longer be accessible from the API | 
**Links** | [**List&lt;Link&gt;**](Link.md) | *method&#x3D;GET*Provides link relations as URLs using the REST &#x27;hateoas&#x27; convention (for REST delivered data).&lt;br&gt;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;The &#x27;self&#x27; link references this rest object, including any specified query criteria | 
**Position** | [**GeoPosRestDto**](GeoPosRestDto.md) |  | [optional] 
**Prf** | **int?** | current PRF (Pulse Repetition Frequency) of the radar | 
**PulseWidth** | **int?** | pulse width of a pulsed magnetron radar in nanoseconds | 
**RadarFamily** | **string** | type of radar (shown if it is in the set of given possible values) | 
**RadarFullName** | **string** | RP Station Name followed by the Radar Name as in &#x27;RP Station X:Radar A&#x27; | [optional] 
**TransmitFrequency** | **double?** | transmit frequency of a solid state radar in kHz | 
**WarmupCountdown** | **int?** | time in seconds until the radar is warmed and in Standby Mode. A -1 indicates the countdown is not active | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

