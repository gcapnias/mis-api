# IO.Swagger.Model.ShipDetailRestDto
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AisDest** | **string** | Ship Destination as per AIS | [optional] 
**AisDestArrTime** | **string** | Ship Destination arrival time as per AIS. &lt;br&gt;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;Example Value: 2019-03-14T14:55:00Z specifies a year-month-day followed by 24-hour hours:minutes:seconds in GMT time | [optional] 
**AisShipType** | **string** | *method&#x3D;GET*String representation of the ship type and cargo {Source AIS Transponder} | [optional] 
**AisShipTypeCode** | **int?** | Numerical code representation of the ship type and cargo from ITU-R M.1371 {Source AIS Transponder} | [optional] 
**Beam** | **float?** | Overall beam/width of ship (meters) | [optional] 
**ClassificationSociety** | **string** | The non-governmental organization that has validated and classified this ship | [optional] 
**CrewSize** | **int?** | Standard crew size required to operate this ship | [optional] 
**DeadWeight** | **int?** | Dead weight / carrying capacity of the ship (tons) | [optional] 
**EmailAddress** | **string** | Standard email address to contact ship or ship liaison | [optional] 
**FaxNumber** | **string** | Standard fax number to contact ship or ship liaison | [optional] 
**FormerNames** | [**List&lt;FormerShipName&gt;**](FormerShipName.md) | Former names that have been used by this ship | [optional] 
**GrossTonnage** | **int?** | Overall internal volume of the ship | [optional] 
**Id** | **int?** | the resource identifier; the ship id | [optional] 
**InmarsatNumber** | **string** | Contact number for ships fitted with Inmarsat | [optional] 
**Length** | **float?** | Overall length of ship (meters) | [optional] 
**Links** | [**List&lt;Link&gt;**](Link.md) | *method&#x3D;GET*Provides link relations as URLs using the REST &#x27;hateoas&#x27; convention (for REST delivered data).&lt;br&gt;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;The &#x27;self&#x27; link references this rest object, including any specified query criteria,&lt;br&gt;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;The &#x27;rel/portOfRegistry&#x27; link references the ship&#x27;s port of registry | [optional] 
**ManagerCompany** | **int?** | *hidden* | [optional] 
**MaxCapacity** | **int?** | Maximum capacity including crew, support personnel and passengers | [optional] 
**OperatorCompany** | **int?** | *hidden* | [optional] 
**OtherShipIds** | [**List&lt;OtherShipId&gt;**](OtherShipId.md) | Additional identification numbers associated with this ship {key/value pairs} | [optional] 
**OwnerCompany** | **int?** | *hidden* | [optional] 
**PassengerCapacity** | **int?** | Maximum number of passenger supported by this ship | [optional] 
**PhoneNumber** | **string** | Standard phone number to contact ship or ship liaison | [optional] 
**RegistryPort** | **string** | *method&#x3D;POST_OR_PUT*This is the &#x27;locode&#x27;; the International code for uniquely identifying this port | [optional] 
**StaticDraft** | **float?** | Static draft (meters) | [optional] 
**VesselClass** | **string** | The classification given to this ship by the classification society | [optional] 
**YearOfBuild** | **int?** | Four digit representation of the year the ship was built | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

