# IO.Swagger.Api.DefaultApi

All URIs are relative to */api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetShip**](DefaultApi.md#getship) | **GET** /ships/{id} | Get Ship
[**GetShipDetail**](DefaultApi.md#getshipdetail) | **GET** /ships/{id}/detail | Get Ship&#x27;s Detail
[**GetShips**](DefaultApi.md#getships) | **GET** /ships | Get Ships
[**PostGetExternalData**](DefaultApi.md#postgetexternaldata) | **POST** /ships/get_external_data/{id_type_and_value} | post_getExternalData
[**PostShip**](DefaultApi.md#postship) | **POST** /ships | Create Ship
[**PutShip**](DefaultApi.md#putship) | **PUT** /ships/{id} | Update Ship

<a name="getship"></a>
# **GetShip**
> Ship GetShip (int? id, string expand = null)

Get Ship

This is the root representation of a specific ship object; it provides sufficient identification information to represent the ship object to the user. In addition to this data, it provides links to children and other associated objects, allowing one to gather all available information about a stored ship.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetShipExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var id = 56;  // int? | the ship id
            var expand = expand_example;  // string | Allows links to be expanded inline.<br>Values: detail (optional) 

            try
            {
                // Get Ship
                Ship result = apiInstance.GetShip(id, expand);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.GetShip: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| the ship id | 
 **expand** | **string**| Allows links to be expanded inline.&lt;br&gt;Values: detail | [optional] 

### Return type

[**Ship**](Ship.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getshipdetail"></a>
# **GetShipDetail**
> ShipDetailRestDto GetShipDetail (int? id)

Get Ship's Detail

This endpoint returns additional ship details including ship registry, construction, characteristics and contact information.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetShipDetailExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var id = 56;  // int? | the ship id

            try
            {
                // Get Ship's Detail
                ShipDetailRestDto result = apiInstance.GetShipDetail(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.GetShipDetail: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| the ship id | 

### Return type

[**ShipDetailRestDto**](ShipDetailRestDto.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getships"></a>
# **GetShips**
> ShipsRestDto GetShips (bool? create = null, string expand = null, string imoNumber = null, string lastUpdate = null, string mmsiNumber = null, string shipName = null, int? page = null, int? size = null)

Get Ships

This is the primary means of searching ships.<br>It represents an array of ships that meet the specified search parameters.<br>Note that only one of the 'search' types of query 'Parameter Types' can be set at a time<br>&nbsp;&nbsp;&nbsp;&nbsp;(only one of imoNumber, lastUpdate, mmsiNumber, or shipName).<br>Note that the returned array of ships is paged.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetShipsExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var create = true;  // bool? | *hidden* (optional) 
            var expand = expand_example;  // string | Allows links to be expanded inline.<br>Values: detail (optional) 
            var imoNumber = imoNumber_example;  // string | Return all ships that have a complete or partial IMO match. (optional) 
            var lastUpdate = lastUpdate_example;  // string | Return all ships that have had data updated or have been created since the given datetime.<br><br>&nbsp;&nbsp;&nbsp;&nbsp;Example Value: 2019-03-14T14:55:00Z specifies a year-month-day followed by 24-hour hours:minutes:seconds in GMT time<br><br>Note that to support usability the pagination query is ignored with this argument; all matched items will be returned. (optional) 
            var mmsiNumber = mmsiNumber_example;  // string | Return all ships that have a complete or partial MMSI match. (optional) 
            var shipName = shipName_example;  // string | Return all ships that have a complete or partial Ship Name match. (optional) 
            var page = 56;  // int? | 1-based page number (optional)  (default to 1)
            var size = 56;  // int? | size of each page (optional)  (default to 20)

            try
            {
                // Get Ships
                ShipsRestDto result = apiInstance.GetShips(create, expand, imoNumber, lastUpdate, mmsiNumber, shipName, page, size);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.GetShips: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **create** | **bool?**| *hidden* | [optional] 
 **expand** | **string**| Allows links to be expanded inline.&lt;br&gt;Values: detail | [optional] 
 **imoNumber** | **string**| Return all ships that have a complete or partial IMO match. | [optional] 
 **lastUpdate** | **string**| Return all ships that have had data updated or have been created since the given datetime.&lt;br&gt;&lt;br&gt;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;Example Value: 2019-03-14T14:55:00Z specifies a year-month-day followed by 24-hour hours:minutes:seconds in GMT time&lt;br&gt;&lt;br&gt;Note that to support usability the pagination query is ignored with this argument; all matched items will be returned. | [optional] 
 **mmsiNumber** | **string**| Return all ships that have a complete or partial MMSI match. | [optional] 
 **shipName** | **string**| Return all ships that have a complete or partial Ship Name match. | [optional] 
 **page** | **int?**| 1-based page number | [optional] [default to 1]
 **size** | **int?**| size of each page | [optional] [default to 20]

### Return type

[**ShipsRestDto**](ShipsRestDto.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="postgetexternaldata"></a>
# **PostGetExternalData**
> HttpEntityobject PostGetExternalData (string idTypeAndValue)

post_getExternalData

post_getExternalData

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PostGetExternalDataExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var idTypeAndValue = idTypeAndValue_example;  // string | id_type_and_value

            try
            {
                // post_getExternalData
                HttpEntityobject result = apiInstance.PostGetExternalData(idTypeAndValue);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.PostGetExternalData: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **idTypeAndValue** | **string**| id_type_and_value | 

### Return type

[**HttpEntityobject**](HttpEntityobject.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="postship"></a>
# **PostShip**
> Ship PostShip (Ship body = null)

Create Ship

Creates Ship item for any combination of basic and detailed information.<br>Note that the type of ship data must be specified in the sourceType of Ais, Manual, or External.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PostShipExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var body = new Ship(); // Ship | model (optional) 

            try
            {
                // Create Ship
                Ship result = apiInstance.PostShip(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.PostShip: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**Ship**](Ship.md)| model | [optional] 

### Return type

[**Ship**](Ship.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="putship"></a>
# **PutShip**
> Ship PutShip (int? id, Ship body = null)

Update Ship

Updates Ship item for any combination of basic and detailed information.<br>Note that the type of ship data must be specified in the sourceType of Ais, Manual, or External.<br>Note that unset input results in no change.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PutShipExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var id = 56;  // int? | the ship id
            var body = new Ship(); // Ship | model (optional) 

            try
            {
                // Update Ship
                Ship result = apiInstance.PutShip(id, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.PutShip: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| the ship id | 
 **body** | [**Ship**](Ship.md)| model | [optional] 

### Return type

[**Ship**](Ship.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
