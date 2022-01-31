# IO.Swagger.Model.RadarImageSettingRestDto
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Center** | [**GeoReferenceRestDto**](GeoReferenceRestDto.md) |  | 
**Id** | **int?** | the resource identifier; the radar image id (as returned in the POST radarImage request).&lt;br&gt;This field is used in a response; it is not settable by the client | [optional] 
**ImageAging** | **string** | [&#x27;none&#x27;, &#x27;continuous&#x27; or a numeric range from 1 to 3600]: defines whether to use image aging, and if a number is supplied it specifies the seconds to use for image aging.&lt;br&gt;Defaults to 15 | [optional] 
**ImageUrl** | **string** | URL by which the image can be retrieved.&lt;br&gt;This field is used in a response; it is not settable by the client | 
**Links** | [**List&lt;Link&gt;**](Link.md) | *method&#x3D;GET*Provides link relations as URLs using the REST &#x27;hateoas&#x27; convention (for REST delivered data).&lt;br&gt;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;The &#x27;self&#x27; link references this rest object,&lt;br&gt;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;The &#x27;rel/radarImage&#x27; link references the Radar Image data of this resource | [optional] 
**LowerLeft** | [**GeoReferenceRestDto**](GeoReferenceRestDto.md) |  | 
**MetersPerPixel** | **float?** | specifies the meters per pixel - - the granularity of the image. This along with the windowDimension width and height determines the geographic coverage of the image.&lt;br&gt;Minimum allowed value is 0.1.&lt;br&gt;Defaults to 3.0 | 
**Radars** | [**List&lt;RIRadarRestDto&gt;**](RIRadarRestDto.md) | radar(s) to use to generate the image.&lt;br&gt;Note that at least one of the given radars must be generating the data needed for the Radar Image else a HTTP error response will be returned | 
**UpperRight** | [**GeoReferenceRestDto**](GeoReferenceRestDto.md) |  | 
**WindowDimension** | [**RIWindowRestDto**](RIWindowRestDto.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

