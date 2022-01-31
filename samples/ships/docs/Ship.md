# IO.Swagger.Model.Ship
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AisName** | **string** | AIS representation of name. {Source AIS Transponder} | [optional] 
**CallSign** | **string** | Call Sign | [optional] 
**Country** | **string** | *method&#x3D;POST_OR_PUT*Alpha 3 Code of the country | [optional] 
**FlagUrl** | **string** | *method&#x3D;GET*Image URL to the ship&#x27;s registered country&#x27;s flag | [optional] 
**FullName** | **string** | Full ship name. {Populated by aisName if nothing else has been entered} | 
**Id** | **int?** | the resource identifier; the ship id | [optional] 
**ImoNumber** | **string** | IMO number | [optional] 
**Links** | [**List&lt;Link&gt;**](Link.md) | *method&#x3D;GET*Provides link relations as URLs using the REST &#x27;hateoas&#x27; convention (for REST delivered data).&lt;br&gt;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;The &#x27;self&#x27; link references this rest object, including any specified query criteria,&lt;br&gt;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;The &#x27;rel/detail&#x27; link references the ship&#x27;s detailed information,&lt;br&gt;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;The &#x27;rel/countries&#x27; link references the ship&#x27;s registered country | [optional] 
**MmsiNumber** | **string** | MMSI number | [optional] 
**ShipDetail** | [**ShipDetailRestDto**](ShipDetailRestDto.md) |  | [optional] 
**SourceType** | **string** | *method&#x3D;POST_OR_PUT*[&#x27;Ais&#x27; or &#x27;Manual&#x27; or &#x27;External&#x27;]: The source type of the data | [optional] 
**ThumbnailUrl** | **string** | *method&#x3D;GET*Image URL to the ship&#x27;s primary photo | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

