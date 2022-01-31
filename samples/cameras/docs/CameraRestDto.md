# IO.Swagger.Model.CameraRestDto
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**CameraType** | **string** | Type of camera | [optional] 
**FieldOfView** | [**BearingFieldOfViewRestDto**](BearingFieldOfViewRestDto.md) |  | [optional] 
**Id** | **byte[]** | the resource identifier; the camera id | [optional] 
**IsAutoTiltOn** | **bool?** | [false, true]: boolean representing whether the auto-tilt feature is on | [optional] 
**IsPowerOn** | **bool?** | [false, true]: boolean representing the state of the camera&#x27;s power; not shown if server is offline (value is unknown and not applicable) | [optional] 
**IsServerOffline** | **bool?** | [true]: boolean representing if the camera server is offline (else the field is not shown) | [optional] 
**Links** | [**List&lt;Link&gt;**](Link.md) | *method&#x3D;GET*Provides link relations as URLs using the REST &#x27;hateoas&#x27; convention (for REST delivered data).&lt;br&gt;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;The &#x27;self&#x27; link references this rest object, including any specified query criteria,&lt;br&gt;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;The &#x27;rel/track&#x27; link references the track this camera is following, if any. | [optional] 
**Name** | **string** | given name of this camera | [optional] 
**Pan** | **float?** | [0.0 to 359.99]: camera&#x27;s bearing direction in degrees (0 degrees is true north) | [optional] 
**Position** | [**GeoPosRestDto**](GeoPosRestDto.md) |  | [optional] 
**Tilt** | **float?** | [0.0 to 180.0]: camera&#x27;s tilt in degrees (90 degrees at the horizontal, 0 degrees is fully tilted down) | [optional] 
**TrackingStatus** | **string** | tracking status of the camera | [optional] 
**Zoom** | **float?** | [0.0 to 100.0]: camera&#x27;s zoom percentage | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

