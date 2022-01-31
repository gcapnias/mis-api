# IO.Swagger.Api.DefaultApi

All URIs are relative to */api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**DeleteAlarm**](DefaultApi.md#deletealarm) | **DELETE** /alarms/{id} | Drop an Alarm
[**GetAlarm**](DefaultApi.md#getalarm) | **GET** /alarms/{id} | Get an Alarm
[**GetAlarmTracks**](DefaultApi.md#getalarmtracks) | **GET** /alarms/{id}/tracks | Get the Alarms tracks
[**GetAlarms**](DefaultApi.md#getalarms) | **GET** /alarms | Get all types of Alarms
[**GetAnchorWatchAlarm**](DefaultApi.md#getanchorwatchalarm) | **GET** /alarms/anchorWatch/{id} | Get an Anchor Watch Alarm
[**GetAnchorWatchAlarms**](DefaultApi.md#getanchorwatchalarms) | **GET** /alarms/anchorWatch | Get Anchor Watch Alarms
[**GetCpaAlarm**](DefaultApi.md#getcpaalarm) | **GET** /alarms/cpa/{id} | Get a CPA Alarm
[**GetCpaAlarms**](DefaultApi.md#getcpaalarms) | **GET** /alarms/cpa | Get CPA Alarms
[**GetProximityAlarm**](DefaultApi.md#getproximityalarm) | **GET** /alarms/proximity/{id} | Get a Proximity Alarm
[**GetProximityAlarms**](DefaultApi.md#getproximityalarms) | **GET** /alarms/proximity | Get Proximity Alarms
[**GetShallowDepthAlarm**](DefaultApi.md#getshallowdepthalarm) | **GET** /alarms/shallowDepth/{id} | Get a Shallow Depth Alarm
[**GetShallowDepthAlarms**](DefaultApi.md#getshallowdepthalarms) | **GET** /alarms/shallowDepth | Get Shallow Depth Alarms
[**GetStateChangedAlarm**](DefaultApi.md#getstatechangedalarm) | **GET** /alarms/stateChanged/{id} | Get a State Changed Alarm
[**GetStateChangedAlarms**](DefaultApi.md#getstatechangedalarms) | **GET** /alarms/stateChanged | Get State Changed Alarms
[**PostAddTrack**](DefaultApi.md#postaddtrack) | **POST** /alarms/{id}/tracks/add/{trackId} | Add the track to the specified Alarm
[**PostAnchorWatchAlarm**](DefaultApi.md#postanchorwatchalarm) | **POST** /alarms/anchorWatch | Create an Anchor Watch Alarm
[**PostCpaAlarm**](DefaultApi.md#postcpaalarm) | **POST** /alarms/cpa | Create a CPA Alarm
[**PostDeleteTrack**](DefaultApi.md#postdeletetrack) | **POST** /alarms/{id}/tracks/delete/{trackId} | Remove the track from the specified Alarm
[**PostProximityAlarm**](DefaultApi.md#postproximityalarm) | **POST** /alarms/proximity | Create a Proximity Alarm
[**PostShallowDepthAlarm**](DefaultApi.md#postshallowdepthalarm) | **POST** /alarms/shallowDepth | Create a Shallow Depth Alarm
[**PostStateChangedAlarm**](DefaultApi.md#poststatechangedalarm) | **POST** /alarms/stateChanged | Create a State Changed Alarm
[**PutAnchorWatchAlarm**](DefaultApi.md#putanchorwatchalarm) | **PUT** /alarms/anchorWatch/{id} | Update an Anchor Watch Alarm
[**PutCpaAlarm**](DefaultApi.md#putcpaalarm) | **PUT** /alarms/cpa/{id} | Update a CPA Alarm
[**PutProximityAlarm**](DefaultApi.md#putproximityalarm) | **PUT** /alarms/proximity/{id} | Update a Proximity Alarm
[**PutShallowDepthAlarm**](DefaultApi.md#putshallowdepthalarm) | **PUT** /alarms/shallowDepth/{id} | Update a Shallow Depth Alarm

<a name="deletealarm"></a>
# **DeleteAlarm**
> void DeleteAlarm (int? id)

Drop an Alarm

Request the Alarm with the given ID to be dropped from the system.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DeleteAlarmExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var id = 56;  // int? | the alarm id

            try
            {
                // Drop an Alarm
                apiInstance.DeleteAlarm(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.DeleteAlarm: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| the alarm id | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getalarm"></a>
# **GetAlarm**
> AlarmRestDto GetAlarm (int? id, string expand = null)

Get an Alarm

Requests an Alarm in the system, providing high level information for it

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetAlarmExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var id = 56;  // int? | the alarm id
            var expand = expand_example;  // string | Provides information on which tracks are associated with the alarm.<br>Value: [tracks] (optional) 

            try
            {
                // Get an Alarm
                AlarmRestDto result = apiInstance.GetAlarm(id, expand);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.GetAlarm: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| the alarm id | 
 **expand** | **string**| Provides information on which tracks are associated with the alarm.&lt;br&gt;Value: [tracks] | [optional] 

### Return type

[**AlarmRestDto**](AlarmRestDto.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getalarmtracks"></a>
# **GetAlarmTracks**
> TrackIdsIdOnlyRestDto GetAlarmTracks (int? id)

Get the Alarms tracks

Requests the ids of the track associated with the specified Alarm

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetAlarmTracksExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var id = 56;  // int? | the alarm id

            try
            {
                // Get the Alarms tracks
                TrackIdsIdOnlyRestDto result = apiInstance.GetAlarmTracks(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.GetAlarmTracks: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| the alarm id | 

### Return type

[**TrackIdsIdOnlyRestDto**](TrackIdsIdOnlyRestDto.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getalarms"></a>
# **GetAlarms**
> AlarmsRestDto GetAlarms (string expand = null, int? page = null, int? size = null)

Get all types of Alarms

Requests all Alarms in the system, providing high level information for them

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetAlarmsExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var expand = expand_example;  // string | Provides information on which tracks are associated with the alarm.<br>Value: [tracks] (optional) 
            var page = 56;  // int? | 1-based page number (optional)  (default to 1)
            var size = 56;  // int? | size of each page (optional)  (default to 20)

            try
            {
                // Get all types of Alarms
                AlarmsRestDto result = apiInstance.GetAlarms(expand, page, size);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.GetAlarms: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **expand** | **string**| Provides information on which tracks are associated with the alarm.&lt;br&gt;Value: [tracks] | [optional] 
 **page** | **int?**| 1-based page number | [optional] [default to 1]
 **size** | **int?**| size of each page | [optional] [default to 20]

### Return type

[**AlarmsRestDto**](AlarmsRestDto.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getanchorwatchalarm"></a>
# **GetAnchorWatchAlarm**
> AlarmAnchorWatchRestDto GetAnchorWatchAlarm (int? id, string expand = null)

Get an Anchor Watch Alarm

Requests an Anchor Watch Alarm as identified by its id

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetAnchorWatchAlarmExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var id = 56;  // int? | the alarm id
            var expand = expand_example;  // string | Provides information on which tracks are associated with the alarm.<br>Value: [tracks] (optional) 

            try
            {
                // Get an Anchor Watch Alarm
                AlarmAnchorWatchRestDto result = apiInstance.GetAnchorWatchAlarm(id, expand);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.GetAnchorWatchAlarm: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| the alarm id | 
 **expand** | **string**| Provides information on which tracks are associated with the alarm.&lt;br&gt;Value: [tracks] | [optional] 

### Return type

[**AlarmAnchorWatchRestDto**](AlarmAnchorWatchRestDto.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getanchorwatchalarms"></a>
# **GetAnchorWatchAlarms**
> AlarmAnchorWatchsRestDto GetAnchorWatchAlarms (string expand = null, int? page = null, int? size = null)

Get Anchor Watch Alarms

Requests all Anchor Watch Alarms in the system.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetAnchorWatchAlarmsExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var expand = expand_example;  // string | Provides information on which tracks are associated with the alarm.<br>Value: [tracks] (optional) 
            var page = 56;  // int? | 1-based page number (optional)  (default to 1)
            var size = 56;  // int? | size of each page (optional)  (default to 20)

            try
            {
                // Get Anchor Watch Alarms
                AlarmAnchorWatchsRestDto result = apiInstance.GetAnchorWatchAlarms(expand, page, size);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.GetAnchorWatchAlarms: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **expand** | **string**| Provides information on which tracks are associated with the alarm.&lt;br&gt;Value: [tracks] | [optional] 
 **page** | **int?**| 1-based page number | [optional] [default to 1]
 **size** | **int?**| size of each page | [optional] [default to 20]

### Return type

[**AlarmAnchorWatchsRestDto**](AlarmAnchorWatchsRestDto.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getcpaalarm"></a>
# **GetCpaAlarm**
> AlarmCpaRestDto GetCpaAlarm (int? id, string expand = null)

Get a CPA Alarm

Requests a CPA Alarm as identified by its id

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetCpaAlarmExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var id = 56;  // int? | the alarm id
            var expand = expand_example;  // string | Provides information on which tracks are associated with the alarm.<br>Value: [tracks] (optional) 

            try
            {
                // Get a CPA Alarm
                AlarmCpaRestDto result = apiInstance.GetCpaAlarm(id, expand);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.GetCpaAlarm: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| the alarm id | 
 **expand** | **string**| Provides information on which tracks are associated with the alarm.&lt;br&gt;Value: [tracks] | [optional] 

### Return type

[**AlarmCpaRestDto**](AlarmCpaRestDto.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getcpaalarms"></a>
# **GetCpaAlarms**
> AlarmCpasRestDto GetCpaAlarms (string expand = null, int? page = null, int? size = null)

Get CPA Alarms

Requests all CPA Alarms in the system (closest point of approach).

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetCpaAlarmsExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var expand = expand_example;  // string | Provides information on which tracks are associated with the alarm.<br>Value: [tracks] (optional) 
            var page = 56;  // int? | 1-based page number (optional)  (default to 1)
            var size = 56;  // int? | size of each page (optional)  (default to 20)

            try
            {
                // Get CPA Alarms
                AlarmCpasRestDto result = apiInstance.GetCpaAlarms(expand, page, size);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.GetCpaAlarms: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **expand** | **string**| Provides information on which tracks are associated with the alarm.&lt;br&gt;Value: [tracks] | [optional] 
 **page** | **int?**| 1-based page number | [optional] [default to 1]
 **size** | **int?**| size of each page | [optional] [default to 20]

### Return type

[**AlarmCpasRestDto**](AlarmCpasRestDto.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getproximityalarm"></a>
# **GetProximityAlarm**
> AlarmProximityRestDto GetProximityAlarm (int? id, string expand = null)

Get a Proximity Alarm

Requests a Proximity Alarm as identified by its id

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetProximityAlarmExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var id = 56;  // int? | the alarm id
            var expand = expand_example;  // string | Provides information on which tracks are associated with the alarm.<br>Value: [tracks] (optional) 

            try
            {
                // Get a Proximity Alarm
                AlarmProximityRestDto result = apiInstance.GetProximityAlarm(id, expand);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.GetProximityAlarm: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| the alarm id | 
 **expand** | **string**| Provides information on which tracks are associated with the alarm.&lt;br&gt;Value: [tracks] | [optional] 

### Return type

[**AlarmProximityRestDto**](AlarmProximityRestDto.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getproximityalarms"></a>
# **GetProximityAlarms**
> AlarmProximitysRestDto GetProximityAlarms (string expand = null, int? page = null, int? size = null)

Get Proximity Alarms

Requests all Proximity Alarms in the system.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetProximityAlarmsExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var expand = expand_example;  // string | Provides information on which tracks are associated with the alarm.<br>Value: [tracks] (optional) 
            var page = 56;  // int? | 1-based page number (optional)  (default to 1)
            var size = 56;  // int? | size of each page (optional)  (default to 20)

            try
            {
                // Get Proximity Alarms
                AlarmProximitysRestDto result = apiInstance.GetProximityAlarms(expand, page, size);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.GetProximityAlarms: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **expand** | **string**| Provides information on which tracks are associated with the alarm.&lt;br&gt;Value: [tracks] | [optional] 
 **page** | **int?**| 1-based page number | [optional] [default to 1]
 **size** | **int?**| size of each page | [optional] [default to 20]

### Return type

[**AlarmProximitysRestDto**](AlarmProximitysRestDto.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getshallowdepthalarm"></a>
# **GetShallowDepthAlarm**
> AlarmShallowDepthRestDto GetShallowDepthAlarm (int? id, string expand = null)

Get a Shallow Depth Alarm

Requests a Shallow Depth Alarm as identified by its id

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetShallowDepthAlarmExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var id = 56;  // int? | the alarm id
            var expand = expand_example;  // string | Provides information on which tracks are associated with the alarm.<br>Value: [tracks] (optional) 

            try
            {
                // Get a Shallow Depth Alarm
                AlarmShallowDepthRestDto result = apiInstance.GetShallowDepthAlarm(id, expand);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.GetShallowDepthAlarm: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| the alarm id | 
 **expand** | **string**| Provides information on which tracks are associated with the alarm.&lt;br&gt;Value: [tracks] | [optional] 

### Return type

[**AlarmShallowDepthRestDto**](AlarmShallowDepthRestDto.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getshallowdepthalarms"></a>
# **GetShallowDepthAlarms**
> AlarmShallowDepthsRestDto GetShallowDepthAlarms (string expand = null, int? page = null, int? size = null)

Get Shallow Depth Alarms

Requests all Shallow Depth Alarms in the system.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetShallowDepthAlarmsExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var expand = expand_example;  // string | Provides information on which tracks are associated with the alarm.<br>Value: [tracks] (optional) 
            var page = 56;  // int? | 1-based page number (optional)  (default to 1)
            var size = 56;  // int? | size of each page (optional)  (default to 20)

            try
            {
                // Get Shallow Depth Alarms
                AlarmShallowDepthsRestDto result = apiInstance.GetShallowDepthAlarms(expand, page, size);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.GetShallowDepthAlarms: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **expand** | **string**| Provides information on which tracks are associated with the alarm.&lt;br&gt;Value: [tracks] | [optional] 
 **page** | **int?**| 1-based page number | [optional] [default to 1]
 **size** | **int?**| size of each page | [optional] [default to 20]

### Return type

[**AlarmShallowDepthsRestDto**](AlarmShallowDepthsRestDto.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getstatechangedalarm"></a>
# **GetStateChangedAlarm**
> AlarmStateChangedRestDto GetStateChangedAlarm (int? id, string expand = null)

Get a State Changed Alarm

Requests a State Changed Alarm as identified by its id

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetStateChangedAlarmExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var id = 56;  // int? | the alarm id
            var expand = expand_example;  // string | Provides information on which tracks are associated with the alarm.<br>Value: [tracks] (optional) 

            try
            {
                // Get a State Changed Alarm
                AlarmStateChangedRestDto result = apiInstance.GetStateChangedAlarm(id, expand);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.GetStateChangedAlarm: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| the alarm id | 
 **expand** | **string**| Provides information on which tracks are associated with the alarm.&lt;br&gt;Value: [tracks] | [optional] 

### Return type

[**AlarmStateChangedRestDto**](AlarmStateChangedRestDto.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getstatechangedalarms"></a>
# **GetStateChangedAlarms**
> AlarmStateChangedsRestDto GetStateChangedAlarms (string expand = null, int? page = null, int? size = null)

Get State Changed Alarms

Requests all State Changed Alarms in the system.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetStateChangedAlarmsExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var expand = expand_example;  // string | Provides information on which tracks are associated with the alarm.<br>Value: [tracks] (optional) 
            var page = 56;  // int? | 1-based page number (optional)  (default to 1)
            var size = 56;  // int? | size of each page (optional)  (default to 20)

            try
            {
                // Get State Changed Alarms
                AlarmStateChangedsRestDto result = apiInstance.GetStateChangedAlarms(expand, page, size);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.GetStateChangedAlarms: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **expand** | **string**| Provides information on which tracks are associated with the alarm.&lt;br&gt;Value: [tracks] | [optional] 
 **page** | **int?**| 1-based page number | [optional] [default to 1]
 **size** | **int?**| size of each page | [optional] [default to 20]

### Return type

[**AlarmStateChangedsRestDto**](AlarmStateChangedsRestDto.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="postaddtrack"></a>
# **PostAddTrack**
> void PostAddTrack (int? id, string trackId)

Add the track to the specified Alarm

This adds the requested track to the Alarm.<br>If the track is already associated with the alarm no change is made and the request is accepted. (Note that if the track doesn't exist in the system then a 'Resource not found status' is returned.)

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PostAddTrackExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var id = 56;  // int? | the alarm id
            var trackId = trackId_example;  // string | the track id (e.g. 'COM0100100').<br>Format is &lt;\"COM\"|\"SYS\"|\"SEN\"&gt;&lt;TSI&gt; &lt;CTI&gt;<br><br>The first three characters represent the current tracker mode,<br>&nbsp;&nbsp;COM=Composite Tracker,<br>&nbsp;&nbsp;SYS=System Tracker and<br>&nbsp;&nbsp;SEN = Sensor Tracker.<br>The next 2 digits represent the Tracker Unit Number (TSI).<br>The last 5 digits represent the Local Track ID (CTI)<br>(and must be exactly 5 digits long to be valid).<br><br>Example Value: 'COM0100002' is from the Composite Tracker, uses 1 as the TSI and 2 as the CTI.

            try
            {
                // Add the track to the specified Alarm
                apiInstance.PostAddTrack(id, trackId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.PostAddTrack: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| the alarm id | 
 **trackId** | **string**| the track id (e.g. &#x27;COM0100100&#x27;).&lt;br&gt;Format is &amp;lt;\&quot;COM\&quot;|\&quot;SYS\&quot;|\&quot;SEN\&quot;&amp;gt;&amp;lt;TSI&amp;gt; &amp;lt;CTI&amp;gt;&lt;br&gt;&lt;br&gt;The first three characters represent the current tracker mode,&lt;br&gt;&amp;nbsp;&amp;nbsp;COM&#x3D;Composite Tracker,&lt;br&gt;&amp;nbsp;&amp;nbsp;SYS&#x3D;System Tracker and&lt;br&gt;&amp;nbsp;&amp;nbsp;SEN &#x3D; Sensor Tracker.&lt;br&gt;The next 2 digits represent the Tracker Unit Number (TSI).&lt;br&gt;The last 5 digits represent the Local Track ID (CTI)&lt;br&gt;(and must be exactly 5 digits long to be valid).&lt;br&gt;&lt;br&gt;Example Value: &#x27;COM0100002&#x27; is from the Composite Tracker, uses 1 as the TSI and 2 as the CTI. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="postanchorwatchalarm"></a>
# **PostAnchorWatchAlarm**
> AlarmIdRestDto PostAnchorWatchAlarm (AlarmAnchorWatchInputRestDto body)

Create an Anchor Watch Alarm

Create an Anchor Watch Alarm with the supplied parameters.<br>See the \"Parameters\" section for details of this parameter.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PostAnchorWatchAlarmExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var body = new AlarmAnchorWatchInputRestDto(); // AlarmAnchorWatchInputRestDto | Parameter to create an Anchor Watch Alarm.<br>A copy and pastable example of settings is:<br>{  "distance": 500<br>}

            try
            {
                // Create an Anchor Watch Alarm
                AlarmIdRestDto result = apiInstance.PostAnchorWatchAlarm(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.PostAnchorWatchAlarm: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**AlarmAnchorWatchInputRestDto**](AlarmAnchorWatchInputRestDto.md)| Parameter to create an Anchor Watch Alarm.&lt;br&gt;A copy and pastable example of settings is:&lt;br&gt;{  &quot;distance&quot;: 500&lt;br&gt;} | 

### Return type

[**AlarmIdRestDto**](AlarmIdRestDto.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="postcpaalarm"></a>
# **PostCpaAlarm**
> AlarmIdRestDto PostCpaAlarm (AlarmCpaInputRestDto body)

Create a CPA Alarm

Create a CPA Alarm with the supplied parameters.<br>Any combination of tracks within the given parameters will trigger the alarm (seen as an alert).<br>See the \"Parameters\" section for details of these parameters.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PostCpaAlarmExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var body = new AlarmCpaInputRestDto(); // AlarmCpaInputRestDto | Parameters to create a CPA Alarm.<br>Note that both distance and time are required.<br>A copy and pastable example of settings is:<br>{  "distance": 500,<br>  "time": 300<br>}

            try
            {
                // Create a CPA Alarm
                AlarmIdRestDto result = apiInstance.PostCpaAlarm(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.PostCpaAlarm: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**AlarmCpaInputRestDto**](AlarmCpaInputRestDto.md)| Parameters to create a CPA Alarm.&lt;br&gt;Note that both distance and time are required.&lt;br&gt;A copy and pastable example of settings is:&lt;br&gt;{  &quot;distance&quot;: 500,&lt;br&gt;  &quot;time&quot;: 300&lt;br&gt;} | 

### Return type

[**AlarmIdRestDto**](AlarmIdRestDto.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="postdeletetrack"></a>
# **PostDeleteTrack**
> void PostDeleteTrack (int? id, string trackId)

Remove the track from the specified Alarm

This removes the track from the Alarm.<br>If the track isn't already associated with the alarm no change is made and the request is still accepted.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PostDeleteTrackExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var id = 56;  // int? | the alarm id
            var trackId = trackId_example;  // string | the track id (e.g. 'COM0100100').<br>Format is &lt;\"COM\"|\"SYS\"|\"SEN\"&gt;&lt;TSI&gt; &lt;CTI&gt;<br><br>The first three characters represent the current tracker mode,<br>&nbsp;&nbsp;COM=Composite Tracker,<br>&nbsp;&nbsp;SYS=System Tracker and<br>&nbsp;&nbsp;SEN = Sensor Tracker.<br>The next 2 digits represent the Tracker Unit Number (TSI).<br>The last 5 digits represent the Local Track ID (CTI)<br>(and must be exactly 5 digits long to be valid).<br><br>Example Value: 'COM0100002' is from the Composite Tracker, uses 1 as the TSI and 2 as the CTI.

            try
            {
                // Remove the track from the specified Alarm
                apiInstance.PostDeleteTrack(id, trackId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.PostDeleteTrack: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| the alarm id | 
 **trackId** | **string**| the track id (e.g. &#x27;COM0100100&#x27;).&lt;br&gt;Format is &amp;lt;\&quot;COM\&quot;|\&quot;SYS\&quot;|\&quot;SEN\&quot;&amp;gt;&amp;lt;TSI&amp;gt; &amp;lt;CTI&amp;gt;&lt;br&gt;&lt;br&gt;The first three characters represent the current tracker mode,&lt;br&gt;&amp;nbsp;&amp;nbsp;COM&#x3D;Composite Tracker,&lt;br&gt;&amp;nbsp;&amp;nbsp;SYS&#x3D;System Tracker and&lt;br&gt;&amp;nbsp;&amp;nbsp;SEN &#x3D; Sensor Tracker.&lt;br&gt;The next 2 digits represent the Tracker Unit Number (TSI).&lt;br&gt;The last 5 digits represent the Local Track ID (CTI)&lt;br&gt;(and must be exactly 5 digits long to be valid).&lt;br&gt;&lt;br&gt;Example Value: &#x27;COM0100002&#x27; is from the Composite Tracker, uses 1 as the TSI and 2 as the CTI. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="postproximityalarm"></a>
# **PostProximityAlarm**
> AlarmIdRestDto PostProximityAlarm (AlarmProximityInputRestDto body)

Create a Proximity Alarm

Create a Proximity Alarm with the supplied parameters.<br>See the \"Parameters\" section for details of this parameter.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PostProximityAlarmExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var body = new AlarmProximityInputRestDto(); // AlarmProximityInputRestDto | Parameter to create a Proximity Alarm.<br>A copy and pastable example of settings is:<br>{  "distance": 500<br>}

            try
            {
                // Create a Proximity Alarm
                AlarmIdRestDto result = apiInstance.PostProximityAlarm(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.PostProximityAlarm: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**AlarmProximityInputRestDto**](AlarmProximityInputRestDto.md)| Parameter to create a Proximity Alarm.&lt;br&gt;A copy and pastable example of settings is:&lt;br&gt;{  &quot;distance&quot;: 500&lt;br&gt;} | 

### Return type

[**AlarmIdRestDto**](AlarmIdRestDto.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="postshallowdepthalarm"></a>
# **PostShallowDepthAlarm**
> AlarmIdRestDto PostShallowDepthAlarm (AlarmShallowDepthInputRestDto body)

Create a Shallow Depth Alarm

Create a Shallow Depth Alarm with the supplied parameters.<br>See the \"Parameters\" section for details of this parameter.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PostShallowDepthAlarmExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var body = new AlarmShallowDepthInputRestDto(); // AlarmShallowDepthInputRestDto | Parameter to create a Shallow Depth Alarm.<br>A copy and pastable example of settings is:<br>{  "distance": 500<br>}

            try
            {
                // Create a Shallow Depth Alarm
                AlarmIdRestDto result = apiInstance.PostShallowDepthAlarm(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.PostShallowDepthAlarm: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**AlarmShallowDepthInputRestDto**](AlarmShallowDepthInputRestDto.md)| Parameter to create a Shallow Depth Alarm.&lt;br&gt;A copy and pastable example of settings is:&lt;br&gt;{  &quot;distance&quot;: 500&lt;br&gt;} | 

### Return type

[**AlarmIdRestDto**](AlarmIdRestDto.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="poststatechangedalarm"></a>
# **PostStateChangedAlarm**
> AlarmIdRestDto PostStateChangedAlarm ()

Create a State Changed Alarm

Create a State Changed Alarm to detect if the state of the specified track(s) have changed.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PostStateChangedAlarmExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();

            try
            {
                // Create a State Changed Alarm
                AlarmIdRestDto result = apiInstance.PostStateChangedAlarm();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.PostStateChangedAlarm: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**AlarmIdRestDto**](AlarmIdRestDto.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="putanchorwatchalarm"></a>
# **PutAnchorWatchAlarm**
> void PutAnchorWatchAlarm (AlarmAnchorWatchInputRestDto body, int? id)

Update an Anchor Watch Alarm

Update an Anchor Watch Alarm with the supplied parameter.<br>See the \"Parameters\" section for detail of this parameter.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PutAnchorWatchAlarmExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var body = new AlarmAnchorWatchInputRestDto(); // AlarmAnchorWatchInputRestDto | Parameter to update an Anchor Watch Alarm.<br>A copy and pastable example of settings is:<br>{  "distance": 500<br>}
            var id = 56;  // int? | the alarm id

            try
            {
                // Update an Anchor Watch Alarm
                apiInstance.PutAnchorWatchAlarm(body, id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.PutAnchorWatchAlarm: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**AlarmAnchorWatchInputRestDto**](AlarmAnchorWatchInputRestDto.md)| Parameter to update an Anchor Watch Alarm.&lt;br&gt;A copy and pastable example of settings is:&lt;br&gt;{  &quot;distance&quot;: 500&lt;br&gt;} | 
 **id** | **int?**| the alarm id | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="putcpaalarm"></a>
# **PutCpaAlarm**
> void PutCpaAlarm (AlarmCpaInputRestDto body, int? id)

Update a CPA Alarm

Update a CPA Alarm with the supplied parameters.<br>See the \"Parameters\" section for details of these parameters.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PutCpaAlarmExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var body = new AlarmCpaInputRestDto(); // AlarmCpaInputRestDto | Parameters to update a CPA Alarm.<br>Note that both distance and time are required.<br>A copy and pastable example of settings is:<br>{  "distance": 500,<br>  "time": 300<br>}
            var id = 56;  // int? | the alarm id

            try
            {
                // Update a CPA Alarm
                apiInstance.PutCpaAlarm(body, id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.PutCpaAlarm: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**AlarmCpaInputRestDto**](AlarmCpaInputRestDto.md)| Parameters to update a CPA Alarm.&lt;br&gt;Note that both distance and time are required.&lt;br&gt;A copy and pastable example of settings is:&lt;br&gt;{  &quot;distance&quot;: 500,&lt;br&gt;  &quot;time&quot;: 300&lt;br&gt;} | 
 **id** | **int?**| the alarm id | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="putproximityalarm"></a>
# **PutProximityAlarm**
> void PutProximityAlarm (AlarmProximityInputRestDto body, int? id)

Update a Proximity Alarm

Update a Proximity Alarm with the supplied parameter.<br>See the \"Parameters\" section for detail of this parameter.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PutProximityAlarmExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var body = new AlarmProximityInputRestDto(); // AlarmProximityInputRestDto | Parameter to update a Proximity Alarm.<br>A copy and pastable example of settings is:<br>{  "distance": 500<br>}
            var id = 56;  // int? | the alarm id

            try
            {
                // Update a Proximity Alarm
                apiInstance.PutProximityAlarm(body, id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.PutProximityAlarm: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**AlarmProximityInputRestDto**](AlarmProximityInputRestDto.md)| Parameter to update a Proximity Alarm.&lt;br&gt;A copy and pastable example of settings is:&lt;br&gt;{  &quot;distance&quot;: 500&lt;br&gt;} | 
 **id** | **int?**| the alarm id | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="putshallowdepthalarm"></a>
# **PutShallowDepthAlarm**
> void PutShallowDepthAlarm (AlarmShallowDepthInputRestDto body, int? id)

Update a Shallow Depth Alarm

Update a Shallow Depth Alarm with the supplied parameter.<br>See the \"Parameters\" section for detail of this parameter.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PutShallowDepthAlarmExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var body = new AlarmShallowDepthInputRestDto(); // AlarmShallowDepthInputRestDto | Parameter to update a Shallow Depth Alarm.<br>A copy and pastable example of settings is:<br>{  "distance": 500<br>}
            var id = 56;  // int? | the alarm id

            try
            {
                // Update a Shallow Depth Alarm
                apiInstance.PutShallowDepthAlarm(body, id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.PutShallowDepthAlarm: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**AlarmShallowDepthInputRestDto**](AlarmShallowDepthInputRestDto.md)| Parameter to update a Shallow Depth Alarm.&lt;br&gt;A copy and pastable example of settings is:&lt;br&gt;{  &quot;distance&quot;: 500&lt;br&gt;} | 
 **id** | **int?**| the alarm id | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
