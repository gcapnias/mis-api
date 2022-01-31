# IO.Swagger.Model.TrackPostParametersRestDto
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ExtTrkId** | **int?** | [1 to 65535]: optionally supplied tracking number strictly for the benefit of the user to associate with the created track and not used by MIS | [optional] 
**Location** | [**GeoLocationRestDto**](GeoLocationRestDto.md) |  | [optional] 
**SearchRadius** | **float?** | optionally supplied search radius in meters around the &#x27;location&#x27; parameter within which to create the track. (Defaults to 100.0 meters)&lt;br/&gt;Adjust this parameter when an operator creates a track from the user interface. The current range scale and viewport pixel density will define the meters per pixel, which will drive the searchRadius value. As a general example, if using 1920x1080 display at 1 NMI range scale the search radius may be 25-50 meters and at 10 NMI may be 250-500 meters. | [optional] 
**Type** | **string** | optionally supplied type of track | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

