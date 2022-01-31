# IO.Swagger.Model.CameraServiceRestDto
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**CameraId** | **byte[]** | ID of the Camera | 
**IsPowerOn** | **bool?** | Specifies whether the Camera power is on | 
**IsServerOffline** | **bool?** | Specifies if the the Camera server is offline. Presented only if camera server is offline | [optional] 
**Links** | [**List&lt;Link&gt;**](Link.md) | *method&#x3D;GET*Provides link relations as URLs using the REST &#x27;hateoas&#x27; convention (for REST delivered data).&lt;br&gt;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;The &#x27;rel/camera&#x27; link references the associated camera and can be used to access further information via the REST Cameras Endpoint | 
**Name** | **string** | Name of the Camera | 
**Position** | [**GeoPosRestDto**](GeoPosRestDto.md) |  | [optional] 
**ReportedTime** | [**ReportedTimeRestDto**](ReportedTimeRestDto.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

