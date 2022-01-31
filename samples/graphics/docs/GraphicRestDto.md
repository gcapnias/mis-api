# IO.Swagger.Model.GraphicRestDto
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Circle** | [**GraphicCircleRestDto**](GraphicCircleRestDto.md) |  | [optional] 
**GraphicId** | **int?** | the graphic ID | [optional] 
**GraphicProcessingType** | **string** | How tracks within this region are acquired or processed. The values which can be reported are one of TRACK_LAND_MASK, IMAGE_LAND_MASK, ACQUISITION_WINDOW, GUARD_ALARM, THRESHOLD_BIAS_MAP, SPECIAL1, SPECIAL2, ACQUISITION_AIS, ACQUISITION_IFF, ACQUISITION_RESERVED_1, ACQUISITION_RESERVED_2, DEAD_RECKONING, MANEUVERING_SENSITIVITY | [optional] 
**Links** | [**List&lt;Link&gt;**](Link.md) | *method&#x3D;GET*Provides link relations as URLs using the REST &#x27;hateoas&#x27; convention (for REST delivered data).&lt;br&gt;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;The &#x27;self&#x27; link references this rest object, including any specified query criteria | [optional] 
**PendingState** | **string** | the pending state of the graphic in response to a request (POST,PUT,DELETE) accepted at the MIS. Shown as one of a pending state, a failed state, or not shown. (The typical case is that the request is accepted by the RP server within a couple of seconds and the showing the pending state is very short-lived.) &lt;/br&gt;If and when the request is accepted by the RP server (as determined by a positive acknowledgement at MIS) then the pending state is cleared and no longer shown. &lt;/br&gt;If the request is not accepted by the RP server (as determined by lack of a positive acknowledgement at MIS) then the request eventually goes (after 1 to 30 seconds or so) from a pending state to a failed state and this failed state is shown for about 10 seconds before being cleared. &lt;/br&gt;Therefore it is recommended that the user of this API poll for this response via the &#x27;GET /graphics/{unitNumber}/{graphicId}&#x27; endpoint to know the status.&lt;/br&gt;Please note that a &#x27;Create Graphic&#x27; (POST) is shown only from the &#x27;GET /graphics/{unitNumber}/{graphicId}&#x27; endpoint and not the &#x27;GET /graphics/{unitNumber}&#x27; endpoint.  | [optional] 
**Polygon** | [**List&lt;GeoLatLonRestDto&gt;**](GeoLatLonRestDto.md) | definition of a simple polygon (closed with no intersections). (circle and polygon are exclusive) | [optional] 
**UnitNumber** | **int?** | the unit number (id) of the rp or tracker | [optional] 
**UpdateTime** | **string** | this communicates any changes to the graphic. It is set by the PCRP at creation or update of the graphic (or upon restart of the PCRP, all times are set to the restart time) | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

