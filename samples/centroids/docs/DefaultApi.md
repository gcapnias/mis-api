# IO.Swagger.Api.DefaultApi

All URIs are relative to */api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetCentroids**](DefaultApi.md#getcentroids) | **GET** /centroids/{rp} | Get Centroids via WebSocket

<a name="getcentroids"></a>
# **GetCentroids**
> CentroidsRestDto GetCentroids (int? rp)

Get Centroids via WebSocket

Returns current Centroids associated with the Radar at the given RP.<br>(For documentation purposes, a sample return is performed)

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetCentroidsExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var rp = 56;  // int? | the radar id (the Radar Processor unit number)

            try
            {
                // Get Centroids via WebSocket
                CentroidsRestDto result = apiInstance.GetCentroids(rp);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.GetCentroids: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **rp** | **int?**| the radar id (the Radar Processor unit number) | 

### Return type

[**CentroidsRestDto**](CentroidsRestDto.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
