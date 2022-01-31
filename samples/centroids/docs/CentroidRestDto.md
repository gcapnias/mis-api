# IO.Swagger.Model.CentroidRestDto
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClusterAzimuthBam** | **int?** | [0-65535]: azimuth of the cluster in BAMS (0 true north. value increases in clockwise direction. 32768 (65536/2) represents 180 degrees) | [optional] 
**ClusterRangeBin** | **int?** | range bin of the cluster | [optional] 
**PeakAmp** | **int?** | [0-127]: peak amplitude of the centroid | [optional] 
**Shape** | [**List&lt;CentroidShapesRestDto&gt;**](CentroidShapesRestDto.md) | array of centroid data which forms a centroid shape | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

