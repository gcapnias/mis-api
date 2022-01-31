# IO.Swagger.Model.AlertRestDto
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AckState** | **string** | acknowledgement status of the alert | 
**ActiveState** | **string** | active status of the alert | 
**AlertInternalId** | [**AlertInternalIdRestDto**](AlertInternalIdRestDto.md) |  | 
**AlertText** | **string** | high level description of the alert | 
**DetailedAlertText** | **string** | detailed level description of the alert | 
**Id** | **long?** | the resource identifier; the alert id | [optional] 
**IsMarkedForDeletion** | **bool?** | &#x27;true&#x27; if this alert is no longer present in the system and will soon be removed from reporting | 
**Links** | [**List&lt;Link&gt;**](Link.md) | *method&#x3D;GET*Provides link relations as URLs using the REST &#x27;hateoas&#x27; convention (for REST delivered data).&lt;br&gt;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;The &#x27;self&#x27; link references this rest object, including any specified query criteria,&lt;br&gt;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;The &#x27;rel/track&#x27; link references this alert&#x27;s associated track, if any | 
**Priority** | **string** | priority level of the alert | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

