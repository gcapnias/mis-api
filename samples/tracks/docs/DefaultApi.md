# IO.Swagger.Api.DefaultApi

All URIs are relative to */api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**DeleteTrack**](DefaultApi.md#deletetrack) | **DELETE** /tracks/{id} | Delete a Track
[**DeleteTracks**](DefaultApi.md#deletetracks) | **DELETE** /tracks | Delete all Tracks from the System
[**GetCompositeTrackType**](DefaultApi.md#getcompositetracktype) | **GET** /tracks/{id} | Get Track
[**GetCompositeTrackTypes**](DefaultApi.md#getcompositetracktypes) | **GET** /tracks | Get Tracks
[**GetTrackDetail**](DefaultApi.md#gettrackdetail) | **GET** /tracks/{id}/detail | Get Track&#x27;s details
[**GetTrackIff**](DefaultApi.md#gettrackiff) | **GET** /tracks/{id}/iff | Get Track&#x27;s IFF information
[**PostTrack**](DefaultApi.md#posttrack) | **POST** /tracks | Create a Manual Track
[**UpdateTrackAffiliation**](DefaultApi.md#updatetrackaffiliation) | **PUT** /tracks/{id}/affiliation | Update the Track Affiliation
[**UpdateTrackBoarding**](DefaultApi.md#updatetrackboarding) | **PUT** /tracks/{id}/boarding | Update the Track Boarding
[**UpdateTrackClassification**](DefaultApi.md#updatetrackclassification) | **PUT** /tracks/{id}/classification | Update the Track Classification
[**UpdateTrackKinematics**](DefaultApi.md#updatetrackkinematics) | **PUT** /tracks/{id}/kinematics | Update the Track Kinematics
[**UpdateTrackName**](DefaultApi.md#updatetrackname) | **PUT** /tracks/{id}/name | Update the Track Name
[**UpdateTrackPosition**](DefaultApi.md#updatetrackposition) | **PUT** /tracks/{id}/position | Update the Track Position

<a name="deletetrack"></a>
# **DeleteTrack**
> void DeleteTrack (string id)

Delete a Track

Deletes the specified track from the system.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DeleteTrackExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var id = id_example;  // string | the track id (e.g. 'COM0100100').<br>Format is &lt;\"COM\"|\"SYS\"|\"SEN\"&gt;&lt;TSI&gt; &lt;CTI&gt;<br><br>The first three characters represent the current tracker mode,<br>&nbsp;&nbsp;COM=Composite Tracker,<br>&nbsp;&nbsp;SYS=System Tracker and<br>&nbsp;&nbsp;SEN = Sensor Tracker.<br>The next 2 digits represent the Tracker Unit Number (TSI).<br>The last 5 digits represent the Local Track ID (CTI)<br>(and must be exactly 5 digits long to be valid).<br><br>Example Value: 'COM0100002' is from the Composite Tracker, uses 1 as the TSI and 2 as the CTI.

            try
            {
                // Delete a Track
                apiInstance.DeleteTrack(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.DeleteTrack: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| the track id (e.g. &#x27;COM0100100&#x27;).&lt;br&gt;Format is &amp;lt;\&quot;COM\&quot;|\&quot;SYS\&quot;|\&quot;SEN\&quot;&amp;gt;&amp;lt;TSI&amp;gt; &amp;lt;CTI&amp;gt;&lt;br&gt;&lt;br&gt;The first three characters represent the current tracker mode,&lt;br&gt;&amp;nbsp;&amp;nbsp;COM&#x3D;Composite Tracker,&lt;br&gt;&amp;nbsp;&amp;nbsp;SYS&#x3D;System Tracker and&lt;br&gt;&amp;nbsp;&amp;nbsp;SEN &#x3D; Sensor Tracker.&lt;br&gt;The next 2 digits represent the Tracker Unit Number (TSI).&lt;br&gt;The last 5 digits represent the Local Track ID (CTI)&lt;br&gt;(and must be exactly 5 digits long to be valid).&lt;br&gt;&lt;br&gt;Example Value: &#x27;COM0100002&#x27; is from the Composite Tracker, uses 1 as the TSI and 2 as the CTI. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="deletetracks"></a>
# **DeleteTracks**
> void DeleteTracks ()

Delete all Tracks from the System

Delete all tracks from the system; both those automatically acquired and manual.<br>

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DeleteTracksExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();

            try
            {
                // Delete all Tracks from the System
                apiInstance.DeleteTracks();
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.DeleteTracks: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getcompositetracktype"></a>
# **GetCompositeTrackType**
> TrackRestDto GetCompositeTrackType (string id, string expand = null)

Get Track

Root representation of a specific track object; providing sufficient identification and kinematic information to represent the track object to the user. In addition to this data, it provides links to children and other associated objects, allowing one to gather all available information about a real-time track.<br>Please note:<br>&nbsp;&nbsp;&nbsp;Permissions assigned to the user will automatically and implicitly limit what is retrieved (eg, 'Radar' permission is required to see any Radar track data     and 'BFT' permission is required to see data sourced from such)<br><br><b>List of recently introduced fields:</b><br>&nbsp;&nbsp;&nbsp;isSourceGtc (6/2021):<br>Added to indicate that the source of the /tracks endpoint data is from the GTC Tracker, not the Composite Tracker. (Availability of data on the /tracks endpoint is provided as a convenience to users of this endpoint. There is generally only one Tracker type running within the system so this data would not otherwise be available.) However, there are several implications of this: <br>&nbsp;&nbsp;&nbsp;&nbsp;- the data fields are to be interpreted based on the GTC track field's descriptions instead (eg, the 'quality' field has a different range when the data is sourced by GTC), <br>&nbsp;&nbsp;&nbsp;&nbsp;- and the track reporting interval follows the GTC track reporting interval. (See the GTC track field 'maxDelayInterval' to see more information on this.)

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetCompositeTrackTypeExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var id = id_example;  // string | the track id (e.g. 'COM0100100').<br>Format is &lt;\"COM\"|\"SYS\"|\"SEN\"&gt;&lt;TSI&gt; &lt;CTI&gt;<br><br>The first three characters represent the current tracker mode,<br>&nbsp;&nbsp;COM=Composite Tracker,<br>&nbsp;&nbsp;SYS=System Tracker and<br>&nbsp;&nbsp;SEN = Sensor Tracker.<br>The next 2 digits represent the Tracker Unit Number (TSI).<br>The last 5 digits represent the Local Track ID (CTI)<br>(and must be exactly 5 digits long to be valid).<br><br>Example Value: 'COM0100002' is from the Composite Tracker, uses 1 as the TSI and 2 as the CTI.
            var expand = expand_example;  // string | Allows links to be expanded inline.<br>Values: any combination of [detail, iff]<br>Example Value: detail,iff.<br><br>Permissions Note: Users without RadarTracks permission may not ask for IFF data.<br> (optional) 

            try
            {
                // Get Track
                TrackRestDto result = apiInstance.GetCompositeTrackType(id, expand);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.GetCompositeTrackType: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| the track id (e.g. &#x27;COM0100100&#x27;).&lt;br&gt;Format is &amp;lt;\&quot;COM\&quot;|\&quot;SYS\&quot;|\&quot;SEN\&quot;&amp;gt;&amp;lt;TSI&amp;gt; &amp;lt;CTI&amp;gt;&lt;br&gt;&lt;br&gt;The first three characters represent the current tracker mode,&lt;br&gt;&amp;nbsp;&amp;nbsp;COM&#x3D;Composite Tracker,&lt;br&gt;&amp;nbsp;&amp;nbsp;SYS&#x3D;System Tracker and&lt;br&gt;&amp;nbsp;&amp;nbsp;SEN &#x3D; Sensor Tracker.&lt;br&gt;The next 2 digits represent the Tracker Unit Number (TSI).&lt;br&gt;The last 5 digits represent the Local Track ID (CTI)&lt;br&gt;(and must be exactly 5 digits long to be valid).&lt;br&gt;&lt;br&gt;Example Value: &#x27;COM0100002&#x27; is from the Composite Tracker, uses 1 as the TSI and 2 as the CTI. | 
 **expand** | **string**| Allows links to be expanded inline.&lt;br&gt;Values: any combination of [detail, iff]&lt;br&gt;Example Value: detail,iff.&lt;br&gt;&lt;br&gt;Permissions Note: Users without RadarTracks permission may not ask for IFF data.&lt;br&gt; | [optional] 

### Return type

[**TrackRestDto**](TrackRestDto.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getcompositetracktypes"></a>
# **GetCompositeTrackTypes**
> TracksRestDto GetCompositeTrackTypes (string boundingRect = null, string expand = null, string name = null, string sensorSrc = null, string updateSince = null, string updateSrc = null, int? page = null, int? size = null)

Get Tracks

This is the primary means of searching the real-time tracks in the system. An array of tracks is returned, allowing a client to select the desired track for more detailed information.<br><br>Please note that:<br>&nbsp;&nbsp;&nbsp;Permissions assigned to the user will automatically and implicitly limit what is retrieved (eg, 'Radar' permission is required to see any Radar track data     and 'BFT' permission is required to see data sourced from such)<br>&nbsp;&nbsp;&nbsp;Multiple query types (see 'Parameter') can be applied,<br><br><b>List of recently introduced fields:</b><br>&nbsp;&nbsp;&nbsp;isSourceGtc (6/2021):<br>Added to indicate that the source of the /tracks endpoint data is from the GTC Tracker, not the Composite Tracker. (Availability of data on the /tracks endpoint is provided as a convenience to users of this endpoint. There is generally only one Tracker type running within the system so this data would not otherwise be available.) However, there are several implications of this: <br>&nbsp;&nbsp;&nbsp;&nbsp;- the data fields are to be interpreted based on the GTC track field's descriptions instead (eg, the 'quality' field has a different range when the data is sourced by GTC), <br>&nbsp;&nbsp;&nbsp;&nbsp;- and the track reporting interval follows the GTC track reporting interval. (See the GTC track field 'maxDelayInterval' to see more information on this.)

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetCompositeTrackTypesExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var boundingRect = boundingRect_example;  // string | Filters tracks to a bounding rectangular region whose sides parallel the latitude and longitude axes.<br>(Decimal Degrees, North Positive / East Positive)</br> Format is &lt;upper lat&gt;, &lt;left lon&gt;, &lt;lower lat&gt;, &lt;right lon&gt;<br>Example Value: 33.75,-118.50,33.25,-118.19 (optional) 
            var expand = expand_example;  // string | Allows links to be expanded inline.<br>Values: any combination of [detail, iff]<br>Example Value: detail,iff.<br><br>Permissions Note: Users without RadarTracks permission may not ask for IFF data.<br> (optional) 
            var name = name_example;  // string | Returns tracks that have a complete or partial name match. (optional) 
            var sensorSrc = sensorSrc_example;  // string | Returns tracks that have correlation with specific sensor type(s).<br>Values: Special combination of [Radar, AIS, IFF, DF, Generic, Video, Sonar, AIS-A, AIS-B, Air]<br>Note that 'AIS' is a convenience for including both AIS Class A and AIS Class B tracks.<br>Several different operations are accepted:<br>- --Provide a single Sensor,<br>- --Provide 'AND' or 'OR' to require all of (AND) or one of (OR) sensors to be present in the track,<br>   (requires multiple sensors as arguments),<br>- --Provide 'NOT' to exclude tracks having the sensor(s) present,<br>- --Provide 'ONLY' to include tracks which match the given sensor.<br>   (requres a single sensor as argument),<br>Example 1: 'Radar' returns Radar correlated tracks.<br>Example 2: 'AND(Radar,AIS)' returns tracks correlated with both Radar AND any combo of AIS-A or AIS-B.<br>Example 3: 'OR(Radar,AIS)' returns tracks correlated with Radar OR AIS-A OR AIS-B.<br>Example 4: 'ONLY(AIS)' returns tracks correlated ONLY WITH AIS (any combo of AIS-A or AIS-B).<br>Example 5: 'NOT(Radar,AIS)' returns tracks NOT correlated with Radar or AIS-A or AIS-B.<br><br>Permissions Note: Users without RadarTracks permission will have all Radar-only tracks and radar data filtered out.<br> (optional) 
            var updateSince = updateSince_example;  // string | Returns tracks that have been updated since (greater than) a specific time.<br>This is useful for clients that are continually polling the server.<br><br>&nbsp;&nbsp;&nbsp;&nbsp;Example Value: 2019-03-14T14:55:00Z specifies a year-month-day followed by 24-hour hours:minutes:seconds in GMT time<br><br>Note that to support usability the pagination query is ignored with this argument; all matched items will be returned. (optional) 
            var updateSrc = updateSrc_example;  // string | Returns tracks that have been updated with a specific sensor.<br>Value: [RP&lt;unit_num&gt;, AIS, GEN&lt;unit_num&gt;]<br>Example Values: RP4, RP04<br>Permissions Note: Users without RadarTracks permission will not be allowed to query for Radar (RP) type of tracks.<br> (optional) 
            var page = 56;  // int? | 1-based page number (optional)  (default to 1)
            var size = 56;  // int? | size of each page (optional)  (default to 20)

            try
            {
                // Get Tracks
                TracksRestDto result = apiInstance.GetCompositeTrackTypes(boundingRect, expand, name, sensorSrc, updateSince, updateSrc, page, size);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.GetCompositeTrackTypes: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **boundingRect** | **string**| Filters tracks to a bounding rectangular region whose sides parallel the latitude and longitude axes.&lt;br&gt;(Decimal Degrees, North Positive / East Positive)&lt;/br&gt; Format is &amp;lt;upper lat&amp;gt;, &amp;lt;left lon&amp;gt;, &amp;lt;lower lat&amp;gt;, &amp;lt;right lon&amp;gt;&lt;br&gt;Example Value: 33.75,-118.50,33.25,-118.19 | [optional] 
 **expand** | **string**| Allows links to be expanded inline.&lt;br&gt;Values: any combination of [detail, iff]&lt;br&gt;Example Value: detail,iff.&lt;br&gt;&lt;br&gt;Permissions Note: Users without RadarTracks permission may not ask for IFF data.&lt;br&gt; | [optional] 
 **name** | **string**| Returns tracks that have a complete or partial name match. | [optional] 
 **sensorSrc** | **string**| Returns tracks that have correlation with specific sensor type(s).&lt;br&gt;Values: Special combination of [Radar, AIS, IFF, DF, Generic, Video, Sonar, AIS-A, AIS-B, Air]&lt;br&gt;Note that &#x27;AIS&#x27; is a convenience for including both AIS Class A and AIS Class B tracks.&lt;br&gt;Several different operations are accepted:&lt;br&gt;- --Provide a single Sensor,&lt;br&gt;- --Provide &#x27;AND&#x27; or &#x27;OR&#x27; to require all of (AND) or one of (OR) sensors to be present in the track,&lt;br&gt;   (requires multiple sensors as arguments),&lt;br&gt;- --Provide &#x27;NOT&#x27; to exclude tracks having the sensor(s) present,&lt;br&gt;- --Provide &#x27;ONLY&#x27; to include tracks which match the given sensor.&lt;br&gt;   (requres a single sensor as argument),&lt;br&gt;Example 1: &#x27;Radar&#x27; returns Radar correlated tracks.&lt;br&gt;Example 2: &#x27;AND(Radar,AIS)&#x27; returns tracks correlated with both Radar AND any combo of AIS-A or AIS-B.&lt;br&gt;Example 3: &#x27;OR(Radar,AIS)&#x27; returns tracks correlated with Radar OR AIS-A OR AIS-B.&lt;br&gt;Example 4: &#x27;ONLY(AIS)&#x27; returns tracks correlated ONLY WITH AIS (any combo of AIS-A or AIS-B).&lt;br&gt;Example 5: &#x27;NOT(Radar,AIS)&#x27; returns tracks NOT correlated with Radar or AIS-A or AIS-B.&lt;br&gt;&lt;br&gt;Permissions Note: Users without RadarTracks permission will have all Radar-only tracks and radar data filtered out.&lt;br&gt; | [optional] 
 **updateSince** | **string**| Returns tracks that have been updated since (greater than) a specific time.&lt;br&gt;This is useful for clients that are continually polling the server.&lt;br&gt;&lt;br&gt;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;Example Value: 2019-03-14T14:55:00Z specifies a year-month-day followed by 24-hour hours:minutes:seconds in GMT time&lt;br&gt;&lt;br&gt;Note that to support usability the pagination query is ignored with this argument; all matched items will be returned. | [optional] 
 **updateSrc** | **string**| Returns tracks that have been updated with a specific sensor.&lt;br&gt;Value: [RP&amp;lt;unit_num&amp;gt;, AIS, GEN&amp;lt;unit_num&amp;gt;]&lt;br&gt;Example Values: RP4, RP04&lt;br&gt;Permissions Note: Users without RadarTracks permission will not be allowed to query for Radar (RP) type of tracks.&lt;br&gt; | [optional] 
 **page** | **int?**| 1-based page number | [optional] [default to 1]
 **size** | **int?**| size of each page | [optional] [default to 20]

### Return type

[**TracksRestDto**](TracksRestDto.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="gettrackdetail"></a>
# **GetTrackDetail**
> TrackDetailRestDto GetTrackDetail (string id)

Get Track's details

This endpoint returns additional track details.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetTrackDetailExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var id = id_example;  // string | the track id (e.g. 'COM0100100').<br>Format is &lt;\"COM\"|\"SYS\"|\"SEN\"&gt;&lt;TSI&gt; &lt;CTI&gt;<br><br>The first three characters represent the current tracker mode,<br>&nbsp;&nbsp;COM=Composite Tracker,<br>&nbsp;&nbsp;SYS=System Tracker and<br>&nbsp;&nbsp;SEN = Sensor Tracker.<br>The next 2 digits represent the Tracker Unit Number (TSI).<br>The last 5 digits represent the Local Track ID (CTI)<br>(and must be exactly 5 digits long to be valid).<br><br>Example Value: 'COM0100002' is from the Composite Tracker, uses 1 as the TSI and 2 as the CTI.

            try
            {
                // Get Track's details
                TrackDetailRestDto result = apiInstance.GetTrackDetail(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.GetTrackDetail: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| the track id (e.g. &#x27;COM0100100&#x27;).&lt;br&gt;Format is &amp;lt;\&quot;COM\&quot;|\&quot;SYS\&quot;|\&quot;SEN\&quot;&amp;gt;&amp;lt;TSI&amp;gt; &amp;lt;CTI&amp;gt;&lt;br&gt;&lt;br&gt;The first three characters represent the current tracker mode,&lt;br&gt;&amp;nbsp;&amp;nbsp;COM&#x3D;Composite Tracker,&lt;br&gt;&amp;nbsp;&amp;nbsp;SYS&#x3D;System Tracker and&lt;br&gt;&amp;nbsp;&amp;nbsp;SEN &#x3D; Sensor Tracker.&lt;br&gt;The next 2 digits represent the Tracker Unit Number (TSI).&lt;br&gt;The last 5 digits represent the Local Track ID (CTI)&lt;br&gt;(and must be exactly 5 digits long to be valid).&lt;br&gt;&lt;br&gt;Example Value: &#x27;COM0100002&#x27; is from the Composite Tracker, uses 1 as the TSI and 2 as the CTI. | 

### Return type

[**TrackDetailRestDto**](TrackDetailRestDto.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="gettrackiff"></a>
# **GetTrackIff**
> TrackIffRestDto GetTrackIff (string id)

Get Track's IFF information

This endpoint returns additional information on IFF tracks. This information is only provided if IFF PCRPs are included in the system

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetTrackIffExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var id = id_example;  // string | the track id (e.g. 'COM0100100').<br>Format is &lt;\"COM\"|\"SYS\"|\"SEN\"&gt;&lt;TSI&gt; &lt;CTI&gt;<br><br>The first three characters represent the current tracker mode,<br>&nbsp;&nbsp;COM=Composite Tracker,<br>&nbsp;&nbsp;SYS=System Tracker and<br>&nbsp;&nbsp;SEN = Sensor Tracker.<br>The next 2 digits represent the Tracker Unit Number (TSI).<br>The last 5 digits represent the Local Track ID (CTI)<br>(and must be exactly 5 digits long to be valid).<br><br>Example Value: 'COM0100002' is from the Composite Tracker, uses 1 as the TSI and 2 as the CTI.

            try
            {
                // Get Track's IFF information
                TrackIffRestDto result = apiInstance.GetTrackIff(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.GetTrackIff: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| the track id (e.g. &#x27;COM0100100&#x27;).&lt;br&gt;Format is &amp;lt;\&quot;COM\&quot;|\&quot;SYS\&quot;|\&quot;SEN\&quot;&amp;gt;&amp;lt;TSI&amp;gt; &amp;lt;CTI&amp;gt;&lt;br&gt;&lt;br&gt;The first three characters represent the current tracker mode,&lt;br&gt;&amp;nbsp;&amp;nbsp;COM&#x3D;Composite Tracker,&lt;br&gt;&amp;nbsp;&amp;nbsp;SYS&#x3D;System Tracker and&lt;br&gt;&amp;nbsp;&amp;nbsp;SEN &#x3D; Sensor Tracker.&lt;br&gt;The next 2 digits represent the Tracker Unit Number (TSI).&lt;br&gt;The last 5 digits represent the Local Track ID (CTI)&lt;br&gt;(and must be exactly 5 digits long to be valid).&lt;br&gt;&lt;br&gt;Example Value: &#x27;COM0100002&#x27; is from the Composite Tracker, uses 1 as the TSI and 2 as the CTI. | 

### Return type

[**TrackIffRestDto**](TrackIffRestDto.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="posttrack"></a>
# **PostTrack**
> void PostTrack (TrackPostParametersRestDto body)

Create a Manual Track

Create a manual track with the supplied parameters.<br>See the \"Parameters\" section for details.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PostTrackExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var body = new TrackPostParametersRestDto(); // TrackPostParametersRestDto | Parameters to create a track.<br>Note that only the latitude and longitude parameters are required; defaults are provided for others or capabilities are not provided.<br>A copy and pastable example of settings is:<br>{  "location": {<br>  &nbsp;&nbsp;&nbsp;"latitude": 33.73301,<br>  &nbsp;&nbsp;&nbsp;"longitude": -118.18548<br>  },<br> "extTrkId": 101<br>}

            try
            {
                // Create a Manual Track
                apiInstance.PostTrack(body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.PostTrack: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**TrackPostParametersRestDto**](TrackPostParametersRestDto.md)| Parameters to create a track.&lt;br&gt;Note that only the latitude and longitude parameters are required; defaults are provided for others or capabilities are not provided.&lt;br&gt;A copy and pastable example of settings is:&lt;br&gt;{  &quot;location&quot;: {&lt;br&gt;  &amp;nbsp;&amp;nbsp;&amp;nbsp;&quot;latitude&quot;: 33.73301,&lt;br&gt;  &amp;nbsp;&amp;nbsp;&amp;nbsp;&quot;longitude&quot;: -118.18548&lt;br&gt;  },&lt;br&gt; &quot;extTrkId&quot;: 101&lt;br&gt;} | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="updatetrackaffiliation"></a>
# **UpdateTrackAffiliation**
> void UpdateTrackAffiliation (TrackAffiliationRestDto body, string id)

Update the Track Affiliation

Update the track's affiliation by changing the 'affiliation' field.<br>See the \"Parameters\" section, \"Model\" sub-section for this items data name, type, and acceptable value.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class UpdateTrackAffiliationExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var body = new TrackAffiliationRestDto(); // TrackAffiliationRestDto | Parameter to update a track's affiliation.<br>For example:<br>{  "affiliation":"Friendly"}
            var id = id_example;  // string | the track id (e.g. 'COM0100100').<br>Format is &lt;\"COM\"|\"SYS\"|\"SEN\"&gt;&lt;TSI&gt; &lt;CTI&gt;<br><br>The first three characters represent the current tracker mode,<br>&nbsp;&nbsp;COM=Composite Tracker,<br>&nbsp;&nbsp;SYS=System Tracker and<br>&nbsp;&nbsp;SEN = Sensor Tracker.<br>The next 2 digits represent the Tracker Unit Number (TSI).<br>The last 5 digits represent the Local Track ID (CTI)<br>(and must be exactly 5 digits long to be valid).<br><br>Example Value: 'COM0100002' is from the Composite Tracker, uses 1 as the TSI and 2 as the CTI.

            try
            {
                // Update the Track Affiliation
                apiInstance.UpdateTrackAffiliation(body, id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.UpdateTrackAffiliation: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**TrackAffiliationRestDto**](TrackAffiliationRestDto.md)| Parameter to update a track&#x27;s affiliation.&lt;br&gt;For example:&lt;br&gt;{  &quot;affiliation&quot;:&quot;Friendly&quot;} | 
 **id** | **string**| the track id (e.g. &#x27;COM0100100&#x27;).&lt;br&gt;Format is &amp;lt;\&quot;COM\&quot;|\&quot;SYS\&quot;|\&quot;SEN\&quot;&amp;gt;&amp;lt;TSI&amp;gt; &amp;lt;CTI&amp;gt;&lt;br&gt;&lt;br&gt;The first three characters represent the current tracker mode,&lt;br&gt;&amp;nbsp;&amp;nbsp;COM&#x3D;Composite Tracker,&lt;br&gt;&amp;nbsp;&amp;nbsp;SYS&#x3D;System Tracker and&lt;br&gt;&amp;nbsp;&amp;nbsp;SEN &#x3D; Sensor Tracker.&lt;br&gt;The next 2 digits represent the Tracker Unit Number (TSI).&lt;br&gt;The last 5 digits represent the Local Track ID (CTI)&lt;br&gt;(and must be exactly 5 digits long to be valid).&lt;br&gt;&lt;br&gt;Example Value: &#x27;COM0100002&#x27; is from the Composite Tracker, uses 1 as the TSI and 2 as the CTI. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="updatetrackboarding"></a>
# **UpdateTrackBoarding**
> void UpdateTrackBoarding (TrackBoardingRestDto body, string id)

Update the Track Boarding

Update the track's boarding status by changing the 'boarding' field.<br>See the \"Parameters\" section, \"Model\" sub-section for this items data name, type, and acceptable value.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class UpdateTrackBoardingExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var body = new TrackBoardingRestDto(); // TrackBoardingRestDto | Parameter to update a track's boarding status.<br>For example:<br>{  "boarding":"Interest"}
            var id = id_example;  // string | the track id (e.g. 'COM0100100').<br>Format is &lt;\"COM\"|\"SYS\"|\"SEN\"&gt;&lt;TSI&gt; &lt;CTI&gt;<br><br>The first three characters represent the current tracker mode,<br>&nbsp;&nbsp;COM=Composite Tracker,<br>&nbsp;&nbsp;SYS=System Tracker and<br>&nbsp;&nbsp;SEN = Sensor Tracker.<br>The next 2 digits represent the Tracker Unit Number (TSI).<br>The last 5 digits represent the Local Track ID (CTI)<br>(and must be exactly 5 digits long to be valid).<br><br>Example Value: 'COM0100002' is from the Composite Tracker, uses 1 as the TSI and 2 as the CTI.

            try
            {
                // Update the Track Boarding
                apiInstance.UpdateTrackBoarding(body, id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.UpdateTrackBoarding: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**TrackBoardingRestDto**](TrackBoardingRestDto.md)| Parameter to update a track&#x27;s boarding status.&lt;br&gt;For example:&lt;br&gt;{  &quot;boarding&quot;:&quot;Interest&quot;} | 
 **id** | **string**| the track id (e.g. &#x27;COM0100100&#x27;).&lt;br&gt;Format is &amp;lt;\&quot;COM\&quot;|\&quot;SYS\&quot;|\&quot;SEN\&quot;&amp;gt;&amp;lt;TSI&amp;gt; &amp;lt;CTI&amp;gt;&lt;br&gt;&lt;br&gt;The first three characters represent the current tracker mode,&lt;br&gt;&amp;nbsp;&amp;nbsp;COM&#x3D;Composite Tracker,&lt;br&gt;&amp;nbsp;&amp;nbsp;SYS&#x3D;System Tracker and&lt;br&gt;&amp;nbsp;&amp;nbsp;SEN &#x3D; Sensor Tracker.&lt;br&gt;The next 2 digits represent the Tracker Unit Number (TSI).&lt;br&gt;The last 5 digits represent the Local Track ID (CTI)&lt;br&gt;(and must be exactly 5 digits long to be valid).&lt;br&gt;&lt;br&gt;Example Value: &#x27;COM0100002&#x27; is from the Composite Tracker, uses 1 as the TSI and 2 as the CTI. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="updatetrackclassification"></a>
# **UpdateTrackClassification**
> void UpdateTrackClassification (TrackClassificationRestDto body, string id)

Update the Track Classification

Update the track's classification status by changing the 'classification' field.<br>See the \"Parameters\" section, \"Model\" sub-section for this items data name, type, and acceptable value.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class UpdateTrackClassificationExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var body = new TrackClassificationRestDto(); // TrackClassificationRestDto | Parameter to update a track's classification status.<br>For example:<br>{  "classification":"Unknown"}
            var id = id_example;  // string | the track id (e.g. 'COM0100100').<br>Format is &lt;\"COM\"|\"SYS\"|\"SEN\"&gt;&lt;TSI&gt; &lt;CTI&gt;<br><br>The first three characters represent the current tracker mode,<br>&nbsp;&nbsp;COM=Composite Tracker,<br>&nbsp;&nbsp;SYS=System Tracker and<br>&nbsp;&nbsp;SEN = Sensor Tracker.<br>The next 2 digits represent the Tracker Unit Number (TSI).<br>The last 5 digits represent the Local Track ID (CTI)<br>(and must be exactly 5 digits long to be valid).<br><br>Example Value: 'COM0100002' is from the Composite Tracker, uses 1 as the TSI and 2 as the CTI.

            try
            {
                // Update the Track Classification
                apiInstance.UpdateTrackClassification(body, id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.UpdateTrackClassification: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**TrackClassificationRestDto**](TrackClassificationRestDto.md)| Parameter to update a track&#x27;s classification status.&lt;br&gt;For example:&lt;br&gt;{  &quot;classification&quot;:&quot;Unknown&quot;} | 
 **id** | **string**| the track id (e.g. &#x27;COM0100100&#x27;).&lt;br&gt;Format is &amp;lt;\&quot;COM\&quot;|\&quot;SYS\&quot;|\&quot;SEN\&quot;&amp;gt;&amp;lt;TSI&amp;gt; &amp;lt;CTI&amp;gt;&lt;br&gt;&lt;br&gt;The first three characters represent the current tracker mode,&lt;br&gt;&amp;nbsp;&amp;nbsp;COM&#x3D;Composite Tracker,&lt;br&gt;&amp;nbsp;&amp;nbsp;SYS&#x3D;System Tracker and&lt;br&gt;&amp;nbsp;&amp;nbsp;SEN &#x3D; Sensor Tracker.&lt;br&gt;The next 2 digits represent the Tracker Unit Number (TSI).&lt;br&gt;The last 5 digits represent the Local Track ID (CTI)&lt;br&gt;(and must be exactly 5 digits long to be valid).&lt;br&gt;&lt;br&gt;Example Value: &#x27;COM0100002&#x27; is from the Composite Tracker, uses 1 as the TSI and 2 as the CTI. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="updatetrackkinematics"></a>
# **UpdateTrackKinematics**
> void UpdateTrackKinematics (KinematicsRestDto body, string id)

Update the Track Kinematics

Update the track's kinematics by changing the 'kinematics' field.<br>See the \"Parameters\" section, \"Model\" sub-section for this items data name, type, and acceptable value.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class UpdateTrackKinematicsExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var body = new KinematicsRestDto(); // KinematicsRestDto | Parameter to update a track's kinematics.<br>For example:<br>{ "course":90.0, "speed":10.3 } 
            var id = id_example;  // string | the track id (e.g. 'COM0100100').<br>Format is &lt;\"COM\"|\"SYS\"|\"SEN\"&gt;&lt;TSI&gt; &lt;CTI&gt;<br><br>The first three characters represent the current tracker mode,<br>&nbsp;&nbsp;COM=Composite Tracker,<br>&nbsp;&nbsp;SYS=System Tracker and<br>&nbsp;&nbsp;SEN = Sensor Tracker.<br>The next 2 digits represent the Tracker Unit Number (TSI).<br>The last 5 digits represent the Local Track ID (CTI)<br>(and must be exactly 5 digits long to be valid).<br><br>Example Value: 'COM0100002' is from the Composite Tracker, uses 1 as the TSI and 2 as the CTI.

            try
            {
                // Update the Track Kinematics
                apiInstance.UpdateTrackKinematics(body, id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.UpdateTrackKinematics: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**KinematicsRestDto**](KinematicsRestDto.md)| Parameter to update a track&#x27;s kinematics.&lt;br&gt;For example:&lt;br&gt;{ &quot;course&quot;:90.0, &quot;speed&quot;:10.3 }  | 
 **id** | **string**| the track id (e.g. &#x27;COM0100100&#x27;).&lt;br&gt;Format is &amp;lt;\&quot;COM\&quot;|\&quot;SYS\&quot;|\&quot;SEN\&quot;&amp;gt;&amp;lt;TSI&amp;gt; &amp;lt;CTI&amp;gt;&lt;br&gt;&lt;br&gt;The first three characters represent the current tracker mode,&lt;br&gt;&amp;nbsp;&amp;nbsp;COM&#x3D;Composite Tracker,&lt;br&gt;&amp;nbsp;&amp;nbsp;SYS&#x3D;System Tracker and&lt;br&gt;&amp;nbsp;&amp;nbsp;SEN &#x3D; Sensor Tracker.&lt;br&gt;The next 2 digits represent the Tracker Unit Number (TSI).&lt;br&gt;The last 5 digits represent the Local Track ID (CTI)&lt;br&gt;(and must be exactly 5 digits long to be valid).&lt;br&gt;&lt;br&gt;Example Value: &#x27;COM0100002&#x27; is from the Composite Tracker, uses 1 as the TSI and 2 as the CTI. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="updatetrackname"></a>
# **UpdateTrackName**
> void UpdateTrackName (TrackNameRestDto body, string id)

Update the Track Name

Update the track name by changing the 'name' field.<br>See the \"Parameters\" section, \"Model\" sub-section for this items data name, type, and acceptable value.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class UpdateTrackNameExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var body = new TrackNameRestDto(); // TrackNameRestDto | Parameter to update a track's name.<br>For example:<br>{  "name": "myTrack"}
            var id = id_example;  // string | the track id (e.g. 'COM0100100').<br>Format is &lt;\"COM\"|\"SYS\"|\"SEN\"&gt;&lt;TSI&gt; &lt;CTI&gt;<br><br>The first three characters represent the current tracker mode,<br>&nbsp;&nbsp;COM=Composite Tracker,<br>&nbsp;&nbsp;SYS=System Tracker and<br>&nbsp;&nbsp;SEN = Sensor Tracker.<br>The next 2 digits represent the Tracker Unit Number (TSI).<br>The last 5 digits represent the Local Track ID (CTI)<br>(and must be exactly 5 digits long to be valid).<br><br>Example Value: 'COM0100002' is from the Composite Tracker, uses 1 as the TSI and 2 as the CTI.

            try
            {
                // Update the Track Name
                apiInstance.UpdateTrackName(body, id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.UpdateTrackName: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**TrackNameRestDto**](TrackNameRestDto.md)| Parameter to update a track&#x27;s name.&lt;br&gt;For example:&lt;br&gt;{  &quot;name&quot;: &quot;myTrack&quot;} | 
 **id** | **string**| the track id (e.g. &#x27;COM0100100&#x27;).&lt;br&gt;Format is &amp;lt;\&quot;COM\&quot;|\&quot;SYS\&quot;|\&quot;SEN\&quot;&amp;gt;&amp;lt;TSI&amp;gt; &amp;lt;CTI&amp;gt;&lt;br&gt;&lt;br&gt;The first three characters represent the current tracker mode,&lt;br&gt;&amp;nbsp;&amp;nbsp;COM&#x3D;Composite Tracker,&lt;br&gt;&amp;nbsp;&amp;nbsp;SYS&#x3D;System Tracker and&lt;br&gt;&amp;nbsp;&amp;nbsp;SEN &#x3D; Sensor Tracker.&lt;br&gt;The next 2 digits represent the Tracker Unit Number (TSI).&lt;br&gt;The last 5 digits represent the Local Track ID (CTI)&lt;br&gt;(and must be exactly 5 digits long to be valid).&lt;br&gt;&lt;br&gt;Example Value: &#x27;COM0100002&#x27; is from the Composite Tracker, uses 1 as the TSI and 2 as the CTI. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="updatetrackposition"></a>
# **UpdateTrackPosition**
> void UpdateTrackPosition (GeoPosRestDto body, string id)

Update the Track Position

Update the track position by changing the 'position' field.<br>See the \"Parameters\" section, \"Model\" sub-section for this items data name, type, and acceptable value.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class UpdateTrackPositionExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var body = new GeoPosRestDto(); // GeoPosRestDto | Parameter to update a track's position.<br>For example:<br>{ "latitude":33.7, "longitude":-118 } 
            var id = id_example;  // string | the track id (e.g. 'COM0100100').<br>Format is &lt;\"COM\"|\"SYS\"|\"SEN\"&gt;&lt;TSI&gt; &lt;CTI&gt;<br><br>The first three characters represent the current tracker mode,<br>&nbsp;&nbsp;COM=Composite Tracker,<br>&nbsp;&nbsp;SYS=System Tracker and<br>&nbsp;&nbsp;SEN = Sensor Tracker.<br>The next 2 digits represent the Tracker Unit Number (TSI).<br>The last 5 digits represent the Local Track ID (CTI)<br>(and must be exactly 5 digits long to be valid).<br><br>Example Value: 'COM0100002' is from the Composite Tracker, uses 1 as the TSI and 2 as the CTI.

            try
            {
                // Update the Track Position
                apiInstance.UpdateTrackPosition(body, id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.UpdateTrackPosition: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**GeoPosRestDto**](GeoPosRestDto.md)| Parameter to update a track&#x27;s position.&lt;br&gt;For example:&lt;br&gt;{ &quot;latitude&quot;:33.7, &quot;longitude&quot;:-118 }  | 
 **id** | **string**| the track id (e.g. &#x27;COM0100100&#x27;).&lt;br&gt;Format is &amp;lt;\&quot;COM\&quot;|\&quot;SYS\&quot;|\&quot;SEN\&quot;&amp;gt;&amp;lt;TSI&amp;gt; &amp;lt;CTI&amp;gt;&lt;br&gt;&lt;br&gt;The first three characters represent the current tracker mode,&lt;br&gt;&amp;nbsp;&amp;nbsp;COM&#x3D;Composite Tracker,&lt;br&gt;&amp;nbsp;&amp;nbsp;SYS&#x3D;System Tracker and&lt;br&gt;&amp;nbsp;&amp;nbsp;SEN &#x3D; Sensor Tracker.&lt;br&gt;The next 2 digits represent the Tracker Unit Number (TSI).&lt;br&gt;The last 5 digits represent the Local Track ID (CTI)&lt;br&gt;(and must be exactly 5 digits long to be valid).&lt;br&gt;&lt;br&gt;Example Value: &#x27;COM0100002&#x27; is from the Composite Tracker, uses 1 as the TSI and 2 as the CTI. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
