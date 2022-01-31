# IO.Swagger.Model.TrackIdIdOnlyRestDto
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | the track id (e.g. &#x27;COM0100100&#x27;).&lt;br&gt;Format is &amp;lt;\&quot;COM\&quot;|\&quot;SYS\&quot;|\&quot;SEN\&quot;&amp;gt;&amp;lt;TSI&amp;gt; &amp;lt;CTI&amp;gt;&lt;br&gt;&lt;br&gt;The first three characters represent the current tracker mode,&lt;br&gt;&amp;nbsp;&amp;nbsp;COM&#x3D;Composite Tracker,&lt;br&gt;&amp;nbsp;&amp;nbsp;SYS&#x3D;System Tracker and&lt;br&gt;&amp;nbsp;&amp;nbsp;SEN &#x3D; Sensor Tracker.&lt;br&gt;The next 2 digits represent the Tracker Unit Number (TSI).&lt;br&gt;The last 5 digits represent the Local Track ID (CTI)&lt;br&gt;(and must be exactly 5 digits long to be valid).&lt;br&gt;&lt;br&gt;Example Value: &#x27;COM0100002&#x27; is from the Composite Tracker, uses 1 as the TSI and 2 as the CTI. | [optional] 
**Links** | [**List&lt;Link&gt;**](Link.md) | *method&#x3D;GET*Provides link relations as URLs using the REST &#x27;hateoas&#x27; convention (for REST delivered data).&lt;br&gt;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;The &#x27;self&#x27; link references this rest object, including any specified query criteria | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

