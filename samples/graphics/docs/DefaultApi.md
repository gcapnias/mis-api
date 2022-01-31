# IO.Swagger.Api.DefaultApi

All URIs are relative to */api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateGraphic**](DefaultApi.md#creategraphic) | **POST** /graphics/{unitNumber} | Create a Graphic
[**DeleteGraphic**](DefaultApi.md#deletegraphic) | **DELETE** /graphics/{unitNumber}/{graphicId} | Delete graphic
[**GetGraphic**](DefaultApi.md#getgraphic) | **GET** /graphics/{unitNumber}/{graphicId} | Get Graphic
[**GetGraphicsForUnit**](DefaultApi.md#getgraphicsforunit) | **GET** /graphics/{unitNumber} | Get Graphics for the Unit
[**UpdateGraphic**](DefaultApi.md#updategraphic) | **PUT** /graphics/{unitNumber}/{graphicId} | Update a Graphic

<a name="creategraphic"></a>
# **CreateGraphic**
> HttpEntityGraphicRestDto CreateGraphic (GraphicCreateInRestDto body, int? unitNumber)

Create a Graphic

Create a Graphic with the supplied parameters.<br><br>When this request is made it will immediately respond with the graphic ID allocated and a pending state of pending creation.<br>Please note the following:<br>&nbsp;&nbsp;The RP Manager will not accept duplicate graphics (same shape and processing type). (This is one of the reasons for failure.)<br>&nbsp;&nbsp;To check on the status use follow-up GET requests (use the 'single' GET and not the 'multi' GET) to detect whether this request is fully accepted or not (timed-out and considered failed). Only the 'single' GET will return a pending/failed create request. The graphic ID returned is made available to support this. <br><br> Note that if many graphic change requests (add/delete/update) are made close together in time then there will be a delay in the response from the Graphics server (RP Manager). <br>This results in a false timeout being reported by MIS. <br>And note that for this case the graphics will be accepted and will eventually be seen. <br>For example, if there are 40 adds done with each one spaced a few seconds apart, this will result in a false timeout but the graphics will eventually be seen. <br>This situation needs to be considered by clients to MIS. <br>See the \"Parameters\" section for details of what to provide.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CreateGraphicExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var body = new GraphicCreateInRestDto(); // GraphicCreateInRestDto | Parameters to create a Graphic.<br>A copy and pastable example of settings is:<br>{<br>&nbsp;"graphicProcessingType": "ACQUISITION_WINDOW",<br>&nbsp;"circle": {<br>&nbsp; &nbsp;"center": {<br>&nbsp; &nbsp;&nbsp;"latitude": 33.754257,<br>&nbsp; &nbsp;&nbsp;"longitude": -118.216557<br>&nbsp;&nbsp; },<br>&nbsp;&nbsp; "radius": 100<br>&nbsp;}<br>}
            var unitNumber = 56;  // int? | the unit number (id) of the rp or tracker

            try
            {
                // Create a Graphic
                HttpEntityGraphicRestDto result = apiInstance.CreateGraphic(body, unitNumber);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.CreateGraphic: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**GraphicCreateInRestDto**](GraphicCreateInRestDto.md)| Parameters to create a Graphic.&lt;br&gt;A copy and pastable example of settings is:&lt;br&gt;{&lt;br&gt;&amp;nbsp;&quot;graphicProcessingType&quot;: &quot;ACQUISITION_WINDOW&quot;,&lt;br&gt;&amp;nbsp;&quot;circle&quot;: {&lt;br&gt;&amp;nbsp; &amp;nbsp;&quot;center&quot;: {&lt;br&gt;&amp;nbsp; &amp;nbsp;&amp;nbsp;&quot;latitude&quot;: 33.754257,&lt;br&gt;&amp;nbsp; &amp;nbsp;&amp;nbsp;&quot;longitude&quot;: -118.216557&lt;br&gt;&amp;nbsp;&amp;nbsp; },&lt;br&gt;&amp;nbsp;&amp;nbsp; &quot;radius&quot;: 100&lt;br&gt;&amp;nbsp;}&lt;br&gt;} | 
 **unitNumber** | **int?**| the unit number (id) of the rp or tracker | 

### Return type

[**HttpEntityGraphicRestDto**](HttpEntityGraphicRestDto.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="deletegraphic"></a>
# **DeleteGraphic**
> void DeleteGraphic (int? unitNumber, int? graphicId)

Delete graphic

Deletes a graphic at the given unit with the given id. Deletes are shown as 'pending' until they are deleted by the RP Manager. Deletion can fail.<br><br> Note that if many graphic change requests (add/delete/update) are made close together in time then there will be a delay in the response from the Graphics server (RP Manager). <br>This results in a false timeout being reported by MIS. <br>And note that for this case the graphics will be accepted and will eventually be seen. <br>For example, if there are 40 adds done with each one spaced a few seconds apart, this will result in a false timeout but the graphics will eventually be seen. <br>This situation needs to be considered by clients to MIS. 

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DeleteGraphicExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var unitNumber = 56;  // int? | the unit number (id) of the rp or tracker
            var graphicId = 56;  // int? | the graphic ID

            try
            {
                // Delete graphic
                apiInstance.DeleteGraphic(unitNumber, graphicId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.DeleteGraphic: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **unitNumber** | **int?**| the unit number (id) of the rp or tracker | 
 **graphicId** | **int?**| the graphic ID | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getgraphic"></a>
# **GetGraphic**
> GraphicRestDto GetGraphic (int? unitNumber, int? graphicId)

Get Graphic

Request a specific Graphic by Unit Number and Graphic ID.<br><br> This API (the 'single' GET) is the only API which will show the pending status of a pending-create (as performed via POST) graphic. (And like the 'multi' GET, it will show the data accepted at the RP and not that requested by MIS.) <br><br> Note that if many graphic change requests (add/delete/update) are made close together in time then there will be a delay in the response from the Graphics server (RP Manager). <br>This results in a false timeout being reported by MIS. <br>And note that for this case the graphics will be accepted and will eventually be seen. <br>For example, if there are 40 adds done with each one spaced a few seconds apart, this will result in a false timeout but the graphics will eventually be seen. <br>This situation needs to be considered by clients to MIS. 

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetGraphicExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var unitNumber = 56;  // int? | the unit number (id) of the rp or tracker
            var graphicId = 56;  // int? | the graphic ID

            try
            {
                // Get Graphic
                GraphicRestDto result = apiInstance.GetGraphic(unitNumber, graphicId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.GetGraphic: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **unitNumber** | **int?**| the unit number (id) of the rp or tracker | 
 **graphicId** | **int?**| the graphic ID | 

### Return type

[**GraphicRestDto**](GraphicRestDto.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getgraphicsforunit"></a>
# **GetGraphicsForUnit**
> GraphicsRestDto GetGraphicsForUnit (int? unitNumber, string updateSince = null, string graphicProcessingType = null, int? page = null, int? size = null)

Get Graphics for the Unit

Get all Graphics matching the criteria for the specific Radar (Tracker). </br></br> Note that only that which is accepted and known by the RP Manager is shown; no pending-create graphics are shown, and for pending-update the newest data is not shown, and pending-deletes are shown because they are not yet considered deleted. </br></br> It is recommended to use the 'GET /graphics/{unitNumber}/{graphicId} instead of this API to monitor the status of any pending graphic.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetGraphicsForUnitExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var unitNumber = 56;  // int? | the unit number (id) of the rp or tracker
            var updateSince = updateSince_example;  // string | Returns graphics that have been updated since (greater than) a specific time.<br>This is useful for clients that are continually polling the server.<br><br>&nbsp;&nbsp;&nbsp;&nbsp;Example Value: 2019-03-14T14:55:00.050Z specifies a year-month-day followed by 24-hour hours:minutes:seconds.milliseconds in GMT time<br><br>Note that to support usability the pagination query is ignored with this argument; all matched items will be returned.</br></br>While this will show updated graphics, it will not show when graphics are deleted. (optional) 
            var graphicProcessingType = graphicProcessingType_example;  // string | How tracks within this region are acquired or processed. Can search for one of the following: TRACK_LAND_MASK, IMAGE_LAND_MASK, ACQUISITION_WINDOW, GUARD_ALARM, THRESHOLD_BIAS_MAP, SPECIAL1, SPECIAL2, ACQUISITION_AIS, ACQUISITION_IFF, ACQUISITION_RESERVED_1, ACQUISITION_RESERVED_2, DEAD_RECKONING, MANEUVERING_SENSITIVITY (optional) 
            var page = 56;  // int? | 1-based page number (optional)  (default to 1)
            var size = 56;  // int? | size of each page (optional)  (default to 20)

            try
            {
                // Get Graphics for the Unit
                GraphicsRestDto result = apiInstance.GetGraphicsForUnit(unitNumber, updateSince, graphicProcessingType, page, size);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.GetGraphicsForUnit: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **unitNumber** | **int?**| the unit number (id) of the rp or tracker | 
 **updateSince** | **string**| Returns graphics that have been updated since (greater than) a specific time.&lt;br&gt;This is useful for clients that are continually polling the server.&lt;br&gt;&lt;br&gt;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;Example Value: 2019-03-14T14:55:00.050Z specifies a year-month-day followed by 24-hour hours:minutes:seconds.milliseconds in GMT time&lt;br&gt;&lt;br&gt;Note that to support usability the pagination query is ignored with this argument; all matched items will be returned.&lt;/br&gt;&lt;/br&gt;While this will show updated graphics, it will not show when graphics are deleted. | [optional] 
 **graphicProcessingType** | **string**| How tracks within this region are acquired or processed. Can search for one of the following: TRACK_LAND_MASK, IMAGE_LAND_MASK, ACQUISITION_WINDOW, GUARD_ALARM, THRESHOLD_BIAS_MAP, SPECIAL1, SPECIAL2, ACQUISITION_AIS, ACQUISITION_IFF, ACQUISITION_RESERVED_1, ACQUISITION_RESERVED_2, DEAD_RECKONING, MANEUVERING_SENSITIVITY | [optional] 
 **page** | **int?**| 1-based page number | [optional] [default to 1]
 **size** | **int?**| size of each page | [optional] [default to 20]

### Return type

[**GraphicsRestDto**](GraphicsRestDto.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="updategraphic"></a>
# **UpdateGraphic**
> void UpdateGraphic (GraphicUpdateInRestDto body, int? unitNumber, int? graphicId)

Update a Graphic

Update a Graphic with the supplied parameters.<br><br>When this request is made it will immediately respond with a pending state of pending update.<br><br>Please note the following:<br>&nbsp;&nbsp;A PUT is not allowed if the graphic is waiting (pending) on any operation.<br>&nbsp;&nbsp;Attempting to change the type of graphic shape will fail (eg, can't change from circle to polygon).<br>&nbsp;&nbsp;The RP Manager will not accept duplicate graphics (same shape and processing type). (This is one of the reasons for failure.)<br>&nbsp;&nbsp;To check on the status use follow-up GET requests to detect whether this request is fully accepted or not (timed-out and considered failed). <br><br> Note that if many graphic change requests (add/delete/update) are made close together in time then there will be a delay in the response from the Graphics server (RP Manager). <br>This results in a false timeout being reported by MIS. <br>And note that for this case the graphics will be accepted and will eventually be seen. <br>For example, if there are 40 adds done with each one spaced a few seconds apart, this will result in a false timeout but the graphics will eventually be seen. <br>This situation needs to be considered by clients to MIS. <br>See the \"Parameters\" section for details of what to provide.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class UpdateGraphicExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var body = new GraphicUpdateInRestDto(); // GraphicUpdateInRestDto | Parameters to update a Graphic.<br>A copy and pastable example of settings is:<br>{<br>&nbsp;"circle": {<br>&nbsp; &nbsp;"center": {<br>&nbsp; &nbsp;&nbsp;"latitude": 33.754257,<br>&nbsp; &nbsp;&nbsp;"longitude": -118.216557<br>&nbsp;&nbsp; },<br>&nbsp;&nbsp; "radius": 100<br>&nbsp;}<br>}
            var unitNumber = 56;  // int? | the unit number (id) of the rp or tracker
            var graphicId = 56;  // int? | the graphic ID

            try
            {
                // Update a Graphic
                apiInstance.UpdateGraphic(body, unitNumber, graphicId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.UpdateGraphic: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**GraphicUpdateInRestDto**](GraphicUpdateInRestDto.md)| Parameters to update a Graphic.&lt;br&gt;A copy and pastable example of settings is:&lt;br&gt;{&lt;br&gt;&amp;nbsp;&quot;circle&quot;: {&lt;br&gt;&amp;nbsp; &amp;nbsp;&quot;center&quot;: {&lt;br&gt;&amp;nbsp; &amp;nbsp;&amp;nbsp;&quot;latitude&quot;: 33.754257,&lt;br&gt;&amp;nbsp; &amp;nbsp;&amp;nbsp;&quot;longitude&quot;: -118.216557&lt;br&gt;&amp;nbsp;&amp;nbsp; },&lt;br&gt;&amp;nbsp;&amp;nbsp; &quot;radius&quot;: 100&lt;br&gt;&amp;nbsp;}&lt;br&gt;} | 
 **unitNumber** | **int?**| the unit number (id) of the rp or tracker | 
 **graphicId** | **int?**| the graphic ID | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
