# IO.Swagger.Api.DefaultApi

All URIs are relative to */api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CommandAssignTrack**](DefaultApi.md#commandassigntrack) | **POST** /cameras/{id}/assignTrack | Assign Track to Camera
[**CommandDeassignTrack**](DefaultApi.md#commanddeassigntrack) | **POST** /cameras/{id}/deassignTrack | Deassign Track from Camera
[**CommandGenericCommand**](DefaultApi.md#commandgenericcommand) | **POST** /cameras/{id}/genericCommand | Apply a Generic command
[**CommandGoToPosition**](DefaultApi.md#commandgotoposition) | **POST** /cameras/{id}/gotoPosition | Point Camera to a Location
[**CommandNudge**](DefaultApi.md#commandnudge) | **POST** /cameras/{id}/nudge | Nudge the Camera
[**CommandPanTiltZoom**](DefaultApi.md#commandpantiltzoom) | **POST** /cameras/{id}/panTiltZoom | Pan, tilt, and zoom the Camera
[**CommandPelcoCommand**](DefaultApi.md#commandpelcocommand) | **POST** /cameras/{id}/pelcoCommand | Apply a Pelco command
[**GetCamera**](DefaultApi.md#getcamera) | **GET** /cameras/{id} | Get Camera status
[**GetCameraImage**](DefaultApi.md#getcameraimage) | **GET** /cameras/{id}/image | Get Camera Image
[**GetCameras**](DefaultApi.md#getcameras) | **GET** /cameras | Get Cameras status

<a name="commandassigntrack"></a>
# **CommandAssignTrack**
> void CommandAssignTrack (CameraCommandAssignTrackRestDto body, byte[] id)

Assign Track to Camera

Assign the camera to a track by changing the 'trackToAssign' field.<br>See the \"Parameters\" section, \"Model\" sub-section for this items data name, type, and acceptable value.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CommandAssignTrackExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var body = new CameraCommandAssignTrackRestDto(); // CameraCommandAssignTrackRestDto | Track to assign to the camera.<br>For example:<br>{  "trackToAssign": "COM0100002"}
            var id = B;  // byte[] | the camera id

            try
            {
                // Assign Track to Camera
                apiInstance.CommandAssignTrack(body, id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.CommandAssignTrack: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**CameraCommandAssignTrackRestDto**](CameraCommandAssignTrackRestDto.md)| Track to assign to the camera.&lt;br&gt;For example:&lt;br&gt;{  &quot;trackToAssign&quot;: &quot;COM0100002&quot;} | 
 **id** | **byte[]**| the camera id | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="commanddeassigntrack"></a>
# **CommandDeassignTrack**
> void CommandDeassignTrack (byte[] id)

Deassign Track from Camera

This command will deassign any tracks which might currently be assigned to a camera

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CommandDeassignTrackExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var id = B;  // byte[] | the camera id

            try
            {
                // Deassign Track from Camera
                apiInstance.CommandDeassignTrack(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.CommandDeassignTrack: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **byte[]**| the camera id | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="commandgenericcommand"></a>
# **CommandGenericCommand**
> void CommandGenericCommand (CameraCommandGenericRestDto body, byte[] id)

Apply a Generic command

Command the camera via a 'Generic' command.<br>See the \"Parameters\" section, \"Model\" sub-section for this items data name, type, and acceptable value.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CommandGenericCommandExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var body = new CameraCommandGenericRestDto(); // CameraCommandGenericRestDto | Generic Command data to command the camera.<br>For example:<br>{ "command" : "PanTilt", "value1" : 7.75, "value2" : 89.5 }
            var id = B;  // byte[] | the camera id

            try
            {
                // Apply a Generic command
                apiInstance.CommandGenericCommand(body, id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.CommandGenericCommand: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**CameraCommandGenericRestDto**](CameraCommandGenericRestDto.md)| Generic Command data to command the camera.&lt;br&gt;For example:&lt;br&gt;{ &quot;command&quot; : &quot;PanTilt&quot;, &quot;value1&quot; : 7.75, &quot;value2&quot; : 89.5 } | 
 **id** | **byte[]**| the camera id | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="commandgotoposition"></a>
# **CommandGoToPosition**
> void CommandGoToPosition (CameraCommandPositionRestDto body, byte[] id)

Point Camera to a Location

Supply the latitude and longitude in which to point the camera.<br>See the \"Parameters\" section, \"Model\" sub-section for this items data name, type, and acceptable value.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CommandGoToPositionExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var body = new CameraCommandPositionRestDto(); // CameraCommandPositionRestDto | Latitude and longitude in which to point the camera.<br>For example:<br>{ "gotoPosition": {  "latitude":33,   "longitude":-180} }
            var id = B;  // byte[] | the camera id

            try
            {
                // Point Camera to a Location
                apiInstance.CommandGoToPosition(body, id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.CommandGoToPosition: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**CameraCommandPositionRestDto**](CameraCommandPositionRestDto.md)| Latitude and longitude in which to point the camera.&lt;br&gt;For example:&lt;br&gt;{ &quot;gotoPosition&quot;: {  &quot;latitude&quot;:33,   &quot;longitude&quot;:-180} } | 
 **id** | **byte[]**| the camera id | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="commandnudge"></a>
# **CommandNudge**
> void CommandNudge (CameraCommandNudgeRestDto body, byte[] id)

Nudge the Camera

'Nudge' the camera's direction a few degrees in any combination of four directions.<br>See the \"Parameters\" section, \"Model\" sub-section for this items data name, type, and acceptable value.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CommandNudgeExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var body = new CameraCommandNudgeRestDto(); // CameraCommandNudgeRestDto | Direction and degrees in which to 'nudge' the camera.<br>For example:<br>{ "up": 1, "left":2 }
            var id = B;  // byte[] | the camera id

            try
            {
                // Nudge the Camera
                apiInstance.CommandNudge(body, id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.CommandNudge: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**CameraCommandNudgeRestDto**](CameraCommandNudgeRestDto.md)| Direction and degrees in which to &#x27;nudge&#x27; the camera.&lt;br&gt;For example:&lt;br&gt;{ &quot;up&quot;: 1, &quot;left&quot;:2 } | 
 **id** | **byte[]**| the camera id | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="commandpantiltzoom"></a>
# **CommandPanTiltZoom**
> void CommandPanTiltZoom (CameraCommandPanTiltZoomRestDto body, byte[] id)

Pan, tilt, and zoom the Camera

Perform any combination of panning, tilting, or zooming the camera<br>See the \"Parameters\" section, \"Model\" sub-section for this items data name, type, and acceptable value.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CommandPanTiltZoomExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var body = new CameraCommandPanTiltZoomRestDto(); // CameraCommandPanTiltZoomRestDto | Parameters to pan, tilt, or zoom the camera.<br>For example:<br>{  "pan": 90}
            var id = B;  // byte[] | the camera id

            try
            {
                // Pan, tilt, and zoom the Camera
                apiInstance.CommandPanTiltZoom(body, id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.CommandPanTiltZoom: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**CameraCommandPanTiltZoomRestDto**](CameraCommandPanTiltZoomRestDto.md)| Parameters to pan, tilt, or zoom the camera.&lt;br&gt;For example:&lt;br&gt;{  &quot;pan&quot;: 90} | 
 **id** | **byte[]**| the camera id | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="commandpelcocommand"></a>
# **CommandPelcoCommand**
> void CommandPelcoCommand (CameraCommandPelcoRestDto body, byte[] id)

Apply a Pelco command

Command the camera via a 'Pelco' command.<br>See the \"Parameters\" section, \"Model\" sub-section for this items data name, type, and acceptable value.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CommandPelcoCommandExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var body = new CameraCommandPelcoRestDto(); // CameraCommandPelcoRestDto | Pelco Command.<br>For example:<br>{ "command1" : 3, "command2" : 5, "data1" : 7, "data2" : 0 }
            var id = B;  // byte[] | the camera id

            try
            {
                // Apply a Pelco command
                apiInstance.CommandPelcoCommand(body, id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.CommandPelcoCommand: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**CameraCommandPelcoRestDto**](CameraCommandPelcoRestDto.md)| Pelco Command.&lt;br&gt;For example:&lt;br&gt;{ &quot;command1&quot; : 3, &quot;command2&quot; : 5, &quot;data1&quot; : 7, &quot;data2&quot; : 0 } | 
 **id** | **byte[]**| the camera id | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getcamera"></a>
# **GetCamera**
> CameraRestDto GetCamera (byte[] id)

Get Camera status

Get the status for a specific camera

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetCameraExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var id = B;  // byte[] | the camera id

            try
            {
                // Get Camera status
                CameraRestDto result = apiInstance.GetCamera(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.GetCamera: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **byte[]**| the camera id | 

### Return type

[**CameraRestDto**](CameraRestDto.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getcameraimage"></a>
# **GetCameraImage**
> List<int?> GetCameraImage (int? id, string cacheId = null)

Get Camera Image

Retrieves the current Camera Image as a jpeg

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetCameraImageExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var id = 56;  // int? | the camera id
            var cacheId = cacheId_example;  // string | Optional user-chosen value to provide a 'context' for the request.<br>This serves two purposes:<br>First, to ensure the request goes to the server instead of being cached at the browser, and,<br>Secondly, to correlate the request with the return (this information is in the 'location' of the header).<br>This value is otherwise ignored by the server and can be any value. (optional) 

            try
            {
                // Get Camera Image
                List&lt;int?&gt; result = apiInstance.GetCameraImage(id, cacheId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.GetCameraImage: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| the camera id | 
 **cacheId** | **string**| Optional user-chosen value to provide a &#x27;context&#x27; for the request.&lt;br&gt;This serves two purposes:&lt;br&gt;First, to ensure the request goes to the server instead of being cached at the browser, and,&lt;br&gt;Secondly, to correlate the request with the return (this information is in the &#x27;location&#x27; of the header).&lt;br&gt;This value is otherwise ignored by the server and can be any value. | [optional] 

### Return type

**List<int?>**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getcameras"></a>
# **GetCameras**
> CamerasRestDto GetCameras ()

Get Cameras status

Returns all camera statuses in the system, thereby providing the means to be aware of all cameras in the system. Note that the returned array of cameras is not paged.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetCamerasExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();

            try
            {
                // Get Cameras status
                CamerasRestDto result = apiInstance.GetCameras();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.GetCameras: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**CamerasRestDto**](CamerasRestDto.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
