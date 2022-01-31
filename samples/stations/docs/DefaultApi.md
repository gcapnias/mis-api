# IO.Swagger.Api.DefaultApi

All URIs are relative to */api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetStationData**](DefaultApi.md#getstationdata) | **GET** /stations/{id} | Get Station Data
[**GetStationsDatas**](DefaultApi.md#getstationsdatas) | **GET** /stations | Get Stations

<a name="getstationdata"></a>
# **GetStationData**
> StationRestDto GetStationData (string id, string expand = null)

Get Station Data

Requests Station data for the station identified by the IP Address

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetStationDataExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var id = id_example;  // string | the station id (an IP address)
            var expand = expand_example;  // string | Provides extra detail for some of the fields.<br>Value: [detail] (optional) 

            try
            {
                // Get Station Data
                StationRestDto result = apiInstance.GetStationData(id, expand);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.GetStationData: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| the station id (an IP address) | 
 **expand** | **string**| Provides extra detail for some of the fields.&lt;br&gt;Value: [detail] | [optional] 

### Return type

[**StationRestDto**](StationRestDto.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getstationsdatas"></a>
# **GetStationsDatas**
> StationsRestDto GetStationsDatas (string expand = null)

Get Stations

Requests Station data for all Stations in the system

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetStationsDatasExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var expand = expand_example;  // string | Provides extra detail for some of the fields.<br>Value: [detail] (optional) 

            try
            {
                // Get Stations
                StationsRestDto result = apiInstance.GetStationsDatas(expand);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.GetStationsDatas: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **expand** | **string**| Provides extra detail for some of the fields.&lt;br&gt;Value: [detail] | [optional] 

### Return type

[**StationsRestDto**](StationsRestDto.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
