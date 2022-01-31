# IO.Swagger.Api.DefaultApi

All URIs are relative to */api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetRadarImage**](DefaultApi.md#getradarimage) | **GET** /radarImages/{id} | Get Radar Image
[**GetRadarImageSetting**](DefaultApi.md#getradarimagesetting) | **GET** /radarImages/{id}/settings | Get Radar Image settings
[**PostRadarImageSetting**](DefaultApi.md#postradarimagesetting) | **POST** /radarImages | Create Radar Image resource
[**UpdateRadarImageSetting**](DefaultApi.md#updateradarimagesetting) | **PATCH** /radarImages/{id}/settings | Update Radar Image settings

<a name="getradarimage"></a>
# **GetRadarImage**
> List<int?> GetRadarImage (int? id)

Get Radar Image

Retrieves the current Radar Image as a .png based on the latest settings.<br/><br>Please Note:<br><ul><li>- A new image is available every 0.5 seconds.<li>- An empty image results when the 'window' area given in the POST does not find sufficient Radar return. Try expanding or moving the 'window' accordingly.</li></ul>

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetRadarImageExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var id = 56;  // int? | the radar image id (as returned in the POST radarImage request)

            try
            {
                // Get Radar Image
                List&lt;int?&gt; result = apiInstance.GetRadarImage(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.GetRadarImage: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| the radar image id (as returned in the POST radarImage request) | 

### Return type

**List<int?>**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getradarimagesetting"></a>
# **GetRadarImageSetting**
> RadarImageSettingRestDto GetRadarImageSetting (int? id)

Get Radar Image settings

Retrieve the settings used for processing a Radar Image.<br>Note that only the operator who created the Radar Image (via POST) can perform this GET.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetRadarImageSettingExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var id = 56;  // int? | the radar image id (as returned in the POST radarImage request)

            try
            {
                // Get Radar Image settings
                RadarImageSettingRestDto result = apiInstance.GetRadarImageSetting(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.GetRadarImageSetting: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| the radar image id (as returned in the POST radarImage request) | 

### Return type

[**RadarImageSettingRestDto**](RadarImageSettingRestDto.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="postradarimagesetting"></a>
# **PostRadarImageSetting**
> RadarImageSettingRestDto PostRadarImageSetting (RadarImageSettingRestDto body = null)

Create Radar Image resource

Create a Radar Image resource with custom settings.<br>This API call is the first of two steps needed for retrieving Radar Images. (The second step being the 'GET /radarImages' API.)<br>This sets up the resource for later GETs of a Radar Image, and whose settings can be retrieved or changed via the GET or PATCH of the Radar Image settings.<br><br>Please Note:<br><ul><li>- The resource is automatically removed from the system once no rest requests (GET or PATCH) for this resource have been made for a minute.</li><li>- A limited number of Radar Image resources can exist in the system simultaneously; exceeding that amount will result in failure and require a later retry.</li><li>- Only a few fields need to be provided; the rest will be set to a reasonable default. See the \"Parameters\" section, \"Description\" column for further details.</li><li>- The rpNum(s) field, which represents the Radar(s), require at least one to be active for an image to result at 'GET /radarImages' request time. If none are active, this will result with a 4xx status at 'GET /radarImages' request time. (Hint: see the 'GET /radars' API for currently active radars.)</li><li>- The request class and the response class are the same. However not all fields are used in the request. See the \"Parameters\" section, \"Data Type\" column, \"Model\" for those fields available.</li></ul>

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PostRadarImageSettingExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var body = new RadarImageSettingRestDto(); // RadarImageSettingRestDto | There are reasonable default settings for all fields except the rpNum(s) and center.<br>Hint: Valid rpNum values can be discovered via the 'GET /radars' API.<br>A copy and paste-able example of settings are:<br>{ "radars": [ { "rpNum": 22 } ],<br>"center": {<br>   "latitude": 33.74,<br>   "longitude": -118.16<br>  }<br>} (optional) 

            try
            {
                // Create Radar Image resource
                RadarImageSettingRestDto result = apiInstance.PostRadarImageSetting(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.PostRadarImageSetting: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**RadarImageSettingRestDto**](RadarImageSettingRestDto.md)| There are reasonable default settings for all fields except the rpNum(s) and center.&lt;br&gt;Hint: Valid rpNum values can be discovered via the &#x27;GET /radars&#x27; API.&lt;br&gt;A copy and paste-able example of settings are:&lt;br&gt;{ &quot;radars&quot;: [ { &quot;rpNum&quot;: 22 } ],&lt;br&gt;&quot;center&quot;: {&lt;br&gt;   &quot;latitude&quot;: 33.74,&lt;br&gt;   &quot;longitude&quot;: -118.16&lt;br&gt;  }&lt;br&gt;} | [optional] 

### Return type

[**RadarImageSettingRestDto**](RadarImageSettingRestDto.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="updateradarimagesetting"></a>
# **UpdateRadarImageSetting**
> RadarImageSettingRestDto UpdateRadarImageSetting (int? id, RadarImageSettingRestDto body = null)

Update Radar Image settings

Update the settings used for processing a Radar Image. <br>Note that fields not provided will remain unchanged, and that only the operator who created the Radar Image (via POST) can perform this PATCH.<br>See the POST operation, \"Implementation Notes\" section, for further usage notes

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class UpdateRadarImageSettingExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var id = 56;  // int? | the radar image id (as returned in the POST radarImage request)
            var body = new RadarImageSettingRestDto(); // RadarImageSettingRestDto | Specify the Radar Image settings to be changed (optional) 

            try
            {
                // Update Radar Image settings
                RadarImageSettingRestDto result = apiInstance.UpdateRadarImageSetting(id, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.UpdateRadarImageSetting: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| the radar image id (as returned in the POST radarImage request) | 
 **body** | [**RadarImageSettingRestDto**](RadarImageSettingRestDto.md)| Specify the Radar Image settings to be changed | [optional] 

### Return type

[**RadarImageSettingRestDto**](RadarImageSettingRestDto.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
