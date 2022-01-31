# IO.Swagger.Api.DefaultApi

All URIs are relative to */api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetAlert**](DefaultApi.md#getalert) | **GET** /alerts/{id} | Get Alert
[**GetAlerts**](DefaultApi.md#getalerts) | **GET** /alerts | Get Alerts

<a name="getalert"></a>
# **GetAlert**
> AlertRestDto GetAlert (long? id)

Get Alert

Returns a specific Alert. This includes all available data for the alert.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetAlertExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var id = 789;  // long? | the alert id

            try
            {
                // Get Alert
                AlertRestDto result = apiInstance.GetAlert(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.GetAlert: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **long?**| the alert id | 

### Return type

[**AlertRestDto**](AlertRestDto.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getalerts"></a>
# **GetAlerts**
> AlertsRestDto GetAlerts (string updateSince = null, int? page = null, int? size = null)

Get Alerts

Searches for alerts in the system based on the given criteria.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetAlertsExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var updateSince = updateSince_example;  // string | Returns alerts that have been updated since (greater than) a specific time.<br>This is useful for clients that are continually polling the server.<br><br>&nbsp;&nbsp;&nbsp;&nbsp;Example Value: 2019-03-14T14:55:00Z specifies a year-month-day followed by 24-hour hours:minutes:seconds in GMT time<br><br>Note that to support usability the pagination query is ignored with this argument; all matched items will be returned. (optional) 
            var page = 56;  // int? | 1-based page number (optional)  (default to 1)
            var size = 56;  // int? | size of each page (optional)  (default to 20)

            try
            {
                // Get Alerts
                AlertsRestDto result = apiInstance.GetAlerts(updateSince, page, size);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.GetAlerts: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **updateSince** | **string**| Returns alerts that have been updated since (greater than) a specific time.&lt;br&gt;This is useful for clients that are continually polling the server.&lt;br&gt;&lt;br&gt;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;Example Value: 2019-03-14T14:55:00Z specifies a year-month-day followed by 24-hour hours:minutes:seconds in GMT time&lt;br&gt;&lt;br&gt;Note that to support usability the pagination query is ignored with this argument; all matched items will be returned. | [optional] 
 **page** | **int?**| 1-based page number | [optional] [default to 1]
 **size** | **int?**| size of each page | [optional] [default to 20]

### Return type

[**AlertsRestDto**](AlertsRestDto.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
