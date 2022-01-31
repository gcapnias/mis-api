# IO.Swagger.Model.TracksRestDto
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**IsSourceGtc** | **bool?** | if this gets reported as &#x27;true&#x27; then it signifies the source of all tracks is from the GTC tracker instead of the Composite Tracker. (This field is absent means the same as &#x27;false&#x27;.) This means the data fields are to be interpreted based on the GTC track field&#x27;s descriptions and the track reporting interval follows the GTC track reporting interval. (See the GTC track field &#x27;maxDelayInterval&#x27; to see more information on this.) This is reported at the top-level enclosing object; ie, it is not reported for each single track if it&#x27;s a multi-track lookup | [optional] 
**Items** | [**List&lt;TrackRestDto&gt;**](TrackRestDto.md) | An array of Tracks matching the query criteria | [optional] 
**Links** | [**List&lt;Link&gt;**](Link.md) | *method&#x3D;GET*Provides link relations as URLs using the REST &#x27;hateoas&#x27; convention (for REST delivered data).&lt;br&gt;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;The &#x27;self&#x27; link references this rest object, including any specified query criteria | [optional] 
**TotalItems** | **long?** | Total number of elements matching the query filter and not limited by page size | [optional] 
**TrackIDsResetTime** | **int?** | this value is used to communicate if the Track Ids are reset and no longer related to their past Ids. This value gets changed if the Tracker is restarted or all tracks are dropped. Compare this with the previous track id reset time to know if the IDs represent the same track. This is reported at the top-level enclosing object; ie, it is not reported for each single track if it&#x27;s a multi-track lookup | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

