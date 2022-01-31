# IO.Swagger.Model.FormerShipName
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**CallSign** | **string** | Previous Call Sign of the ship | [optional] 
**Country** | **string** | *method&#x3D;POST_OR_PUT*Alpha 3 Code as per ISO 3166-1 alpha-3 codes | [optional] 
**LastReported** | **string** | Date the ship was last reported with this name. &lt;br&gt;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;Example Value: 2019-03-14T14:55:00Z specifies a year-month-day followed by 24-hour hours:minutes:seconds in GMT time | [optional] 
**Links** | [**List&lt;Link&gt;**](Link.md) | *method&#x3D;GET*Provides link relations as URLs using the REST &#x27;hateoas&#x27; convention (for REST delivered data).&lt;br&gt;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;The &#x27;self&#x27; link references this rest object, including any specified query criteria&lt;br&gt;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;The &#x27;rel/country&#x27; link references the ship&#x27;s registered country during this time | [optional] 
**Name** | **string** | Previous name of ship | 
**StatusCode** | **int?** | *hidden* | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

