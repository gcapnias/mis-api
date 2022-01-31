# IO.Swagger.Model.AlarmCpaRestDto
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AlarmId** | **int?** | ID of the Alarm | [optional] 
**Distance** | **int?** | [1 and greater]: Distance which along with time defines the CPA (Closest Point of Approach) alarm (in meters) | [optional] 
**Links** | [**List&lt;Link&gt;**](Link.md) | *method&#x3D;GET*Provides link relations as URLs using the REST &#x27;hateoas&#x27; convention (for REST delivered data).&lt;br&gt;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;The &#x27;self&#x27; link references this rest object, including any specified query criteria | [optional] 
**Time** | **int?** | [1 and greater]: Time which along with distance defines the CPA (Closest Point of Approach) alarm (in seconds) | [optional] 
**TrackIds** | [**TrackIdsIdOnlyRestDto**](TrackIdsIdOnlyRestDto.md) |  | [optional] 
**Type** | **string** | Type of Alarm | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

