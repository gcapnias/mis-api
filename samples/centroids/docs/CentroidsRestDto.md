# IO.Swagger.Model.CentroidsRestDto
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Items** | [**List&lt;CentroidRestDto&gt;**](CentroidRestDto.md) | centroids for the requested RP | [optional] 
**MetersPerRangeBin** | **float?** | meters per range bin (used to convert range-bin fields (such as clusterRangeBin) to meters) | [optional] 
**NotHeartbeating** | **int?** | [0,1] this field indicates the state of the system. If 1 then indicates there is no Heartbeat and it is very unlikely to have data. If missing (or 0) then indicates there is a Heartbeat, and data is expected (if the Radar is radiating) | [optional] 
**NumItems** | **int?** | number of centroids in this message | [optional] 
**PosTime** | **double?** | position time in (float) epoch seconds | [optional] 
**RadarLat** | **double?** | radar latitude in decimal degrees. Centroids are relative to this location. | [optional] 
**RadarLon** | **double?** | radar longitude in decimal degrees. Centroids are relative to this location. | [optional] 
**Rp** | **int?** | [1-64]: the resource identifier; the radar id (the Radar Processor unit number) | [optional] 
**Ws** | [**WsHeaderInfoRestDto**](WsHeaderInfoRestDto.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

