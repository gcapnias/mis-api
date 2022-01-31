# IO.Swagger.Api.DefaultApi

All URIs are relative to */api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetGtcTrack**](DefaultApi.md#getgtctrack) | **GET** /gtctracks/{id} | Get GTC Track
[**GetGtcTracks**](DefaultApi.md#getgtctracks) | **GET** /gtctracks | Get multiple GTC tracks

<a name="getgtctrack"></a>
# **GetGtcTrack**
> TrackGtcRestDto GetGtcTrack (string id, string expand = null)

Get GTC Track

Specifies a real-time GTC (Global Track Correlator) track. The caller requests the track of interest via track id, and 'expand' settings for track fields of interest (none for default).<br><br>Please note:<br>&nbsp;&nbsp;&nbsp;Permissions assigned to the user will automatically and implicitly limit what is retrieved (eg, 'Radar' permission is required to see any Radar track data     and 'BFT' permission is required to see data sourced from such)<br><br><b>List of recently introduced fields:</b><br>&nbsp;&nbsp;&nbsp;maxDelayInterval  (6/2021):<br>Added due to a recent change to the GTC Tracker's behavior in that it now has the potential to send out track's less frequently. (Slower moving tracks are sent out less frequently.) 

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetGtcTrackExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var id = id_example;  // string | the track id (e.g. 'R1S3_100').<br>Format is R&lt;region&gt;S&lt;Tracker Source unit number&gt;_&lt;track id&gt;<br>Example value of R1S3_100 represents Region 1, Tracker Source unit number 3, track id 100.<br><br>
            var expand = expand_example;  // string | Expands data seen by using any combination of 'detail' or 'sources'. Eg, 'expand=detail,sources'. (See the above Response Class section, Model breakout for a detailed list of the 'detail' (TrackGtcDetail) and 'sources' (TrackGtcSource) data (optional) 

            try
            {
                // Get GTC Track
                TrackGtcRestDto result = apiInstance.GetGtcTrack(id, expand);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.GetGtcTrack: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| the track id (e.g. &#x27;R1S3_100&#x27;).&lt;br&gt;Format is R&amp;lt;region&amp;gt;S&amp;lt;Tracker Source unit number&amp;gt;_&amp;lt;track id&amp;gt;&lt;br&gt;Example value of R1S3_100 represents Region 1, Tracker Source unit number 3, track id 100.&lt;br&gt;&lt;br&gt; | 
 **expand** | **string**| Expands data seen by using any combination of &#x27;detail&#x27; or &#x27;sources&#x27;. Eg, &#x27;expand&#x3D;detail,sources&#x27;. (See the above Response Class section, Model breakout for a detailed list of the &#x27;detail&#x27; (TrackGtcDetail) and &#x27;sources&#x27; (TrackGtcSource) data | [optional] 

### Return type

[**TrackGtcRestDto**](TrackGtcRestDto.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getgtctracks"></a>
# **GetGtcTracks**
> TrackGtcsRestDto GetGtcTracks (string boundingRect = null, string expand = null, string name = null, string updateSince = null, string trackSources = null, string preferredTrackSource = null, bool? hideSingleLinks = null, int? page = null, int? size = null)

Get multiple GTC tracks

Specifies real-time GTC (Global Track Correlator) tracks. The caller requests the tracks of interest via specifying search criteria (none for all tracks), 'expand' settings for track fields of interest (none for default), and page settings to specify the page of interest (none for default).<br><br>This data is available via both REST and WebSockets.<br><br>Please note:<br>&nbsp;&nbsp;&nbsp;Permissions assigned to the user will automatically and implicitly limit what is retrieved (eg, 'Radar' permission is required to see any Radar track data     and 'BFT' permission is required to see data sourced from such)<br>&nbsp;&nbsp;&nbsp;Multiple query types (see 'Parameter') can be applied.<br>&nbsp;&nbsp;&nbsp;Links are given as an aid for further API queries.<br><br><b>List of recently introduced fields:</b><br>&nbsp;&nbsp;&nbsp;maxDelayInterval  (6/2021):<br>Added due to a recent change to the GTC Tracker's behavior in that it now has the potential to send out track's less frequently. (Slower moving tracks are sent out less frequently.) 

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetGtcTracksExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var boundingRect = boundingRect_example;  // string | Filters tracks to a bounding rectangular region whose sides parallel the latitude and longitude axes.<br>(Decimal Degrees, North Positive / East Positive)</br> Format is &lt;upper lat&gt;, &lt;left lon&gt;, &lt;lower lat&gt;, &lt;right lon&gt;<br>Example Value: 33.75,-118.50,33.25,-118.19 (optional) 
            var expand = expand_example;  // string | Expands data seen by using any combination of 'detail' or 'sources'. Eg, 'expand=detail,sources'. (See the above Response Class section, Model breakout for a detailed list of the 'detail' (TrackGtcDetail) and 'sources' (TrackGtcSource) data (optional) 
            var name = name_example;  // string | Returns tracks that have a complete or partial name match. (optional) 
            var updateSince = updateSince_example;  // string | Returns tracks that have been updated since (greater than) a specific time.<br>This is useful for clients that are continually polling the server.<br><br>&nbsp;&nbsp;&nbsp;&nbsp;Example Value: 2019-03-14T14:55:00Z specifies a year-month-day followed by 24-hour hours:minutes:seconds in GMT time<br><br>Note that to support usability the pagination query is ignored with this argument; all matched items will be returned. (optional) 
            var trackSources = trackSources_example;  // string | Returns tracks which have contributions from the given track sources which are not necessarly the preferred track source. Track sources are put together from a combination of Radar,AIS,Generic,NRT,Pending,Unknown,Other.<br> The 4 acceptable combinations:<br> (1) trackSource:  where the given trackSource contributes,  (2) OR(trackSource1, trackSource2, optional-trackSource3)  where any given trackSource contributes,  (3) AND(trackSource1, trackSource2, optional-trackSource3)  where all given trackSources contribute,  (4) ONLY(trackSource1, optional-trackSource2, optional-trackSource3)  where only (and all of) the given trackSource(s) contribute,  (5) NOT(trackSource1, optional-trackSource2, optional-trackSource3)  where none of the given trackSource(s) contribute.<br> Example 1: Generic - returns those tracks which have a Generic type providing one of the sources<br> Example 2: AND(AIS,Radar) - returns those tracks which have both AIS and Radar providing sources<br> Example 3: ONLY(Radar) - returns those tracks which ONLY have Radar providing the sources (optional) 
            var preferredTrackSource = preferredTrackSource_example;  // string | Returns tracks based on the 'preferred' (or 'primary') specified track source.  The track source is one of Radar,AIS,Generic,NRT,Pending,Unknown,Other (optional) 
            var hideSingleLinks = true;  // bool? | If 'true', hide the links for the enclosed single track entries in order to reduce use of the network bandwidth. It defaults to 'false' (ie, show the links). It is suggested to set this to 'true' if the links are not referenced. (optional) 
            var page = 56;  // int? | 1-based page number (optional)  (default to 1)
            var size = 56;  // int? | size of each page (optional)  (default to 20)

            try
            {
                // Get multiple GTC tracks
                TrackGtcsRestDto result = apiInstance.GetGtcTracks(boundingRect, expand, name, updateSince, trackSources, preferredTrackSource, hideSingleLinks, page, size);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.GetGtcTracks: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **boundingRect** | **string**| Filters tracks to a bounding rectangular region whose sides parallel the latitude and longitude axes.&lt;br&gt;(Decimal Degrees, North Positive / East Positive)&lt;/br&gt; Format is &amp;lt;upper lat&amp;gt;, &amp;lt;left lon&amp;gt;, &amp;lt;lower lat&amp;gt;, &amp;lt;right lon&amp;gt;&lt;br&gt;Example Value: 33.75,-118.50,33.25,-118.19 | [optional] 
 **expand** | **string**| Expands data seen by using any combination of &#x27;detail&#x27; or &#x27;sources&#x27;. Eg, &#x27;expand&#x3D;detail,sources&#x27;. (See the above Response Class section, Model breakout for a detailed list of the &#x27;detail&#x27; (TrackGtcDetail) and &#x27;sources&#x27; (TrackGtcSource) data | [optional] 
 **name** | **string**| Returns tracks that have a complete or partial name match. | [optional] 
 **updateSince** | **string**| Returns tracks that have been updated since (greater than) a specific time.&lt;br&gt;This is useful for clients that are continually polling the server.&lt;br&gt;&lt;br&gt;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;Example Value: 2019-03-14T14:55:00Z specifies a year-month-day followed by 24-hour hours:minutes:seconds in GMT time&lt;br&gt;&lt;br&gt;Note that to support usability the pagination query is ignored with this argument; all matched items will be returned. | [optional] 
 **trackSources** | **string**| Returns tracks which have contributions from the given track sources which are not necessarly the preferred track source. Track sources are put together from a combination of Radar,AIS,Generic,NRT,Pending,Unknown,Other.&lt;br&gt; The 4 acceptable combinations:&lt;br&gt; (1) trackSource:  where the given trackSource contributes,  (2) OR(trackSource1, trackSource2, optional-trackSource3)  where any given trackSource contributes,  (3) AND(trackSource1, trackSource2, optional-trackSource3)  where all given trackSources contribute,  (4) ONLY(trackSource1, optional-trackSource2, optional-trackSource3)  where only (and all of) the given trackSource(s) contribute,  (5) NOT(trackSource1, optional-trackSource2, optional-trackSource3)  where none of the given trackSource(s) contribute.&lt;br&gt; Example 1: Generic - returns those tracks which have a Generic type providing one of the sources&lt;br&gt; Example 2: AND(AIS,Radar) - returns those tracks which have both AIS and Radar providing sources&lt;br&gt; Example 3: ONLY(Radar) - returns those tracks which ONLY have Radar providing the sources | [optional] 
 **preferredTrackSource** | **string**| Returns tracks based on the &#x27;preferred&#x27; (or &#x27;primary&#x27;) specified track source.  The track source is one of Radar,AIS,Generic,NRT,Pending,Unknown,Other | [optional] 
 **hideSingleLinks** | **bool?**| If &#x27;true&#x27;, hide the links for the enclosed single track entries in order to reduce use of the network bandwidth. It defaults to &#x27;false&#x27; (ie, show the links). It is suggested to set this to &#x27;true&#x27; if the links are not referenced. | [optional] 
 **page** | **int?**| 1-based page number | [optional] [default to 1]
 **size** | **int?**| size of each page | [optional] [default to 20]

### Return type

[**TrackGtcsRestDto**](TrackGtcsRestDto.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
