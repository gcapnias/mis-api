# IO.Swagger.Model.RadarControlRestDto
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClutterMode** | **string** | clutter mode (typically Manual, Semi-Auto, or Full-Auto) | [optional] 
**Controller** | **string** | ip address of the Radar&#x27;s primary controller | [optional] 
**ControllerName** | **string** | name of the station which has control. If it is the &#x27;MIS&#x27; station, then the loginId of the user is typically also shown | [optional] 
**GainControl** | **int?** | [0-100]: gain control | [optional] 
**IrControl** | **string** | interference rejection control | [optional] 
**IsAdjunctRp** | **bool?** | [false, true] is the Radar an &#x27;Adjunct&#x27; RP (can only change a limited set of fields) | [optional] 
**IsNotUpdating** | **bool?** | [true]: boolean representing if this resource is no longer being updated or seen in the system and will soon no longer be accessible from the API | [optional] 
**Links** | [**List&lt;Link&gt;**](Link.md) | *method&#x3D;GET*Provides link relations as URLs using the REST &#x27;hateoas&#x27; convention (for REST delivered data).&lt;br&gt;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;The &#x27;self&#x27; link references this rest object, including any specified query criteria | 
**RadarMode** | **string** | pulse mode of the radar | 
**RadarState** | **string** | radar state for this radar | [optional] 
**RainControl** | **int?** | [0-100]: control for rain clutter | [optional] 
**RangeScale** | **int?** | [24 or 48]: range scale setting (applies only if Kelvin Hughes type of radar) | [optional] 
**RpNum** | **int?** | [1-64]: RP Number of the radar | 
**SeaControl** | **int?** | [0-100]: control for sea clutter | [optional] 
**TermaProfile** | **int?** | [0-15]: Terma Profile setting for the radar. (Not shown if not a Terma Radar or if the profile is not set or if the SSR system does not know the profile) | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

