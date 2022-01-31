# IO.Swagger.Model.TrackGtcsRestDto
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Items** | [**List&lt;TrackGtcRestDto&gt;**](TrackGtcRestDto.md) | An array of GTC Tracks matching the query criteria | [optional] 
**Links** | [**List&lt;Link&gt;**](Link.md) | *method&#x3D;GET*Provides link relations as URLs using the REST &#x27;hateoas&#x27; convention (for REST delivered data).&lt;br&gt;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;The &#x27;self&#x27; link references this rest object, including any specified query criteria | [optional] 
**MaxDelayInterval** | **int?** | Maximum delayed interval (in seconds) that a track can be reported from the Tracker. The delay interval of tracks will vary from no delay (if no delay this field is absent) to this given reported interval. (The delay is based on speed; the slower the speed the greater the delay.) The track update time field matches the reported time even if the track is delayed (and the &#x27;updateSince&#x27; query results work accordingly.) This is reported at the top-level enclosing object; ie, it is not reported for each single track if it&#x27;s a multi-track lookup | [optional] 
**TotalItems** | **long?** | Total number of elements matching the query filter and not limited by page size (Shown for REST delivered data) | [optional] 
**TrackIDsResetTime** | **int?** | this value is used to communicate if the Track Ids are reset and no longer related to their past Ids. This value gets changed if the Tracker is restarted or all tracks are dropped. Compare this with the previous track id reset time to know if the IDs represent the same track. This is reported at the top-level enclosing object; ie, it is not reported for each single track if it&#x27;s a multi-track lookup | [optional] 
**Ws** | [**WsHeaderInfoRestDto**](WsHeaderInfoRestDto.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

