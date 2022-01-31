# IO.Swagger.Api.DefaultApi

All URIs are relative to */api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetRadarControl**](DefaultApi.md#getradarcontrol) | **GET** /radars/{id}/control | Get Radar Control Settings
[**GetRadarData**](DefaultApi.md#getradardata) | **GET** /radars/{id} | Get Radar Data
[**GetRadarDatas**](DefaultApi.md#getradardatas) | **GET** /radars | Get Radars Status
[**GetRadarDetail**](DefaultApi.md#getradardetail) | **GET** /radars/{id}/detail | Get Radar Detail
[**GetRadarTermaBiteMeasurements**](DefaultApi.md#getradartermabitemeasurements) | **GET** /radars/{id}/terma/BITE/measurements | Get Terma Radar BITE measurements
[**UpdateFilter**](DefaultApi.md#updatefilter) | **POST** /radars/{id}/control/filter | Provides Control of Radar Filtering
[**UpdateRadarMode**](DefaultApi.md#updateradarmode) | **POST** /radars/{id}/control/mode | Provides Control of Radar Mode
[**UpdateRadarState**](DefaultApi.md#updateradarstate) | **POST** /radars/{id}/control/state | Provides Control of Radar State
[**UpdateRangeScale**](DefaultApi.md#updaterangescale) | **POST** /radars/{id}/control/rangeScale | Provides Control of Range Scale
[**UpdateTermaProfile**](DefaultApi.md#updatetermaprofile) | **POST** /radars/{id}/control/termaProfile | Provides control of the Terma Profile

<a name="getradarcontrol"></a>
# **GetRadarControl**
> RadarControlRestDto GetRadarControl (int? id)

Get Radar Control Settings

Requests the Radar Control settings for the specified Radar

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetRadarControlExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var id = 56;  // int? | the radar id (the Radar Processor unit number)

            try
            {
                // Get Radar Control Settings
                RadarControlRestDto result = apiInstance.GetRadarControl(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.GetRadarControl: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| the radar id (the Radar Processor unit number) | 

### Return type

[**RadarControlRestDto**](RadarControlRestDto.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getradardata"></a>
# **GetRadarData**
> RadarRestDto GetRadarData (int? id, string expand = null)

Get Radar Data

Requests the Radar Data for the specified Radar

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetRadarDataExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var id = 56;  // int? | the radar id (the Radar Processor unit number)
            var expand = expand_example;  // string | Provides extra data. if 'control' is requested then control settings are provided. if 'detail' is requested then extra detail of the resource is provided. Any combination of these can be given.<br>Values: [control, detail] (optional) 

            try
            {
                // Get Radar Data
                RadarRestDto result = apiInstance.GetRadarData(id, expand);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.GetRadarData: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| the radar id (the Radar Processor unit number) | 
 **expand** | **string**| Provides extra data. if &#x27;control&#x27; is requested then control settings are provided. if &#x27;detail&#x27; is requested then extra detail of the resource is provided. Any combination of these can be given.&lt;br&gt;Values: [control, detail] | [optional] 

### Return type

[**RadarRestDto**](RadarRestDto.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getradardatas"></a>
# **GetRadarDatas**
> RadarsRestDto GetRadarDatas (string expand = null)

Get Radars Status

Requests Radar Data for all Radars in the system. (No paging or querying available).

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetRadarDatasExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var expand = expand_example;  // string | Provides extra data. if 'control' is requested then control settings are provided. if 'detail' is requested then extra detail of the resource is provided. Any combination of these can be given.<br>Values: [control, detail] (optional) 

            try
            {
                // Get Radars Status
                RadarsRestDto result = apiInstance.GetRadarDatas(expand);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.GetRadarDatas: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **expand** | **string**| Provides extra data. if &#x27;control&#x27; is requested then control settings are provided. if &#x27;detail&#x27; is requested then extra detail of the resource is provided. Any combination of these can be given.&lt;br&gt;Values: [control, detail] | [optional] 

### Return type

[**RadarsRestDto**](RadarsRestDto.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getradardetail"></a>
# **GetRadarDetail**
> RadarDetailRestDto GetRadarDetail (int? id)

Get Radar Detail

Requests the Radar Detail data for the specified Radar

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetRadarDetailExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var id = 56;  // int? | the radar id (the Radar Processor unit number)

            try
            {
                // Get Radar Detail
                RadarDetailRestDto result = apiInstance.GetRadarDetail(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.GetRadarDetail: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| the radar id (the Radar Processor unit number) | 

### Return type

[**RadarDetailRestDto**](RadarDetailRestDto.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getradartermabitemeasurements"></a>
# **GetRadarTermaBiteMeasurements**
> RadarTermaBiteMsRestDto GetRadarTermaBiteMeasurements (int? id, string updateSince = null, int? size = null)

Get Terma Radar BITE measurements

Provides all Terma BITE Measurements (Status, Errors, and Warnings) for a Terma Radar. No action is required for this data to be made available. <br/><br/><em>Important Note on Time Zones:</em><br/>For correct presentation, the MIS and the system interfacing with the Terma (the Radar Processor) require their system time to be set to the same Time Zone. If not, then the presented data will be offset in the same way the Time Zones are. <br/><br/>Note on using updateSince<br/>The recommended approach is to simply base the updateSince query value relative to the time of the data received and presented. This will overcome any differences in system time or Time Zones between the client, MIS, and the system supplying the Terma BITE data. <br/>E.g., if presented time of data received is 2019-03-14T14:55:00.050Z, then using a query of updateSince=2019-03-14T14:55:00.050Z will get all data since that time. <br/><br/>Note on Amount of Data Available<br/> Terma BITE data is constantly being received. MIS stores a limited amount of this Terma BITE data. Requesting data every 5 seconds should be sufficient to get all data since the last request without missing any. 

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetRadarTermaBiteMeasurementsExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var id = 56;  // int? | the radar id (the Radar Processor unit number)
            var updateSince = updateSince_example;  // string | Returns Terma BITE measurements that have been updated since (greater than) the rp_time.<br>This is useful for clients that are continually polling the server.<br>See the 'Note on using updateSince' above in the 'Implementation Notes' section. <br><br>&nbsp;&nbsp;&nbsp;&nbsp;Example Value: 2019-03-14T14:55:00.050Z specifies a year-month-day followed by 24-hour hours:minutes:seconds.milliseconds in GMT time<br><br>Note that the size query is ignored when this query is given; all matched items will be returned. (optional) 
            var size = 56;  // int? | How many entries to retrieve. Ignored if updateSince is given. Defaults to 20 (optional) 

            try
            {
                // Get Terma Radar BITE measurements
                RadarTermaBiteMsRestDto result = apiInstance.GetRadarTermaBiteMeasurements(id, updateSince, size);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.GetRadarTermaBiteMeasurements: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| the radar id (the Radar Processor unit number) | 
 **updateSince** | **string**| Returns Terma BITE measurements that have been updated since (greater than) the rp_time.&lt;br&gt;This is useful for clients that are continually polling the server.&lt;br&gt;See the &#x27;Note on using updateSince&#x27; above in the &#x27;Implementation Notes&#x27; section. &lt;br&gt;&lt;br&gt;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;Example Value: 2019-03-14T14:55:00.050Z specifies a year-month-day followed by 24-hour hours:minutes:seconds.milliseconds in GMT time&lt;br&gt;&lt;br&gt;Note that the size query is ignored when this query is given; all matched items will be returned. | [optional] 
 **size** | **int?**| How many entries to retrieve. Ignored if updateSince is given. Defaults to 20 | [optional] 

### Return type

[**RadarTermaBiteMsRestDto**](RadarTermaBiteMsRestDto.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="updatefilter"></a>
# **UpdateFilter**
> void UpdateFilter (FilterRestDto body, int? id)

Provides Control of Radar Filtering

Updates Radar Filtering controls. Please note not all combination of settings are allowed as further described below. Also, fields which are not provided use the current system setting.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class UpdateFilterExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var body = new FilterRestDto(); // FilterRestDto | Radar Filter settings
            var id = 56;  // int? | the radar id (the Radar Processor unit number)

            try
            {
                // Provides Control of Radar Filtering
                apiInstance.UpdateFilter(body, id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.UpdateFilter: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**FilterRestDto**](FilterRestDto.md)| Radar Filter settings | 
 **id** | **int?**| the radar id (the Radar Processor unit number) | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="updateradarmode"></a>
# **UpdateRadarMode**
> void UpdateRadarMode (RadarModeRestDto body, int? id)

Provides Control of Radar Mode

Updates Radar Mode

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class UpdateRadarModeExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var body = new RadarModeRestDto(); // RadarModeRestDto | Radar mode settings
            var id = 56;  // int? | the radar id (the Radar Processor unit number)

            try
            {
                // Provides Control of Radar Mode
                apiInstance.UpdateRadarMode(body, id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.UpdateRadarMode: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**RadarModeRestDto**](RadarModeRestDto.md)| Radar mode settings | 
 **id** | **int?**| the radar id (the Radar Processor unit number) | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="updateradarstate"></a>
# **UpdateRadarState**
> void UpdateRadarState (RadarStateRestDto body, int? id)

Provides Control of Radar State

Updates Radar State

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class UpdateRadarStateExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var body = new RadarStateRestDto(); // RadarStateRestDto | Radar state settings
            var id = 56;  // int? | the radar id (the Radar Processor unit number)

            try
            {
                // Provides Control of Radar State
                apiInstance.UpdateRadarState(body, id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.UpdateRadarState: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**RadarStateRestDto**](RadarStateRestDto.md)| Radar state settings | 
 **id** | **int?**| the radar id (the Radar Processor unit number) | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="updaterangescale"></a>
# **UpdateRangeScale**
> void UpdateRangeScale (RangeScaleRestDto body, int? id)

Provides Control of Range Scale

Updates Radar Range Scale

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class UpdateRangeScaleExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var body = new RangeScaleRestDto(); // RangeScaleRestDto | Range Scale Setting
            var id = 56;  // int? | the radar id (the Radar Processor unit number)

            try
            {
                // Provides Control of Range Scale
                apiInstance.UpdateRangeScale(body, id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.UpdateRangeScale: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**RangeScaleRestDto**](RangeScaleRestDto.md)| Range Scale Setting | 
 **id** | **int?**| the radar id (the Radar Processor unit number) | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="updatetermaprofile"></a>
# **UpdateTermaProfile**
> void UpdateTermaProfile (TermaProfileRestDto body, int? id)

Provides control of the Terma Profile

Updates Terma Profile

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class UpdateTermaProfileExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var body = new TermaProfileRestDto(); // TermaProfileRestDto | Terma Profile
            var id = 56;  // int? | the radar id (the Radar Processor unit number)

            try
            {
                // Provides control of the Terma Profile
                apiInstance.UpdateTermaProfile(body, id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.UpdateTermaProfile: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**TermaProfileRestDto**](TermaProfileRestDto.md)| Terma Profile | 
 **id** | **int?**| the radar id (the Radar Processor unit number) | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
