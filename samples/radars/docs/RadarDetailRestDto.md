# IO.Swagger.Model.RadarDetailRestDto
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**F21x7Status** | [**F21x7StatusTypeRestDto**](F21x7StatusTypeRestDto.md) |  | 
**Id** | **int?** | [1-64]: the resource identifier; the radar id (the Radar Processor unit number) | [optional] 
**IsAcProtectionPsActive** | **bool?** | is the AC protection power supply active. Available with expand&#x3D;detail | 
**IsAcProtectionPsPowered** | **bool?** | is the AC protection power supply powered. Available with expand&#x3D;detail | 
**IsAutotuned** | **bool?** | is the radar being auto tuned as opposed to manually tuned. Available with expand&#x3D;detail | 
**IsHvPsActive** | **bool?** | is the High Voltage Power Supply active. Available with expand&#x3D;detail | 
**IsHvPsPowered** | **bool?** | is the High Voltage Power Supply powered. Available with expand&#x3D;detail | 
**IsLvPsActive** | **bool?** | is the Low Voltage Power Supply active. Available with expand&#x3D;detail | 
**IsLvPsPowered** | **bool?** | is the Low Voltage Power Supply powered. Available with expand&#x3D;detail | 
**IsMagnetronPowered** | **bool?** | is magnetron power provided. Not available for all Radars (e.g., not available for Terma Radars). Available with expand&#x3D;detail | 
**IsMotorPowered** | **bool?** | is power provided to the motor. Available with expand&#x3D;detail | 
**IsMotorTurning** | **bool?** | is radar&#x27;s readback status saying motor is turning. Available with expand&#x3D;detail | 
**IsMotorTurningCommanded** | **bool?** | is motor commanded to turn. Available with expand&#x3D;detail | 
**IsPerformanceMonitorActivated** | **bool?** | is the performance monitor activated. Available with expand&#x3D;detail | 
**IsRtModulePowered** | **bool?** | is there power to the RT module. Available with expand&#x3D;detail | 
**IsRtPowered** | **bool?** | is the RT powered | 
**IsSignalBearingGeneratorPowered** | **bool?** | is the signal bearing generator powered. Available with expand&#x3D;detail | 
**IsTransmitTriggerActive** | **bool?** | is the transmit trigger active. Available with expand&#x3D;detail | 
**KelvinHughesRadarInfo** | [**KelvinHughesRadarInfoRestDto**](KelvinHughesRadarInfoRestDto.md) |  | 
**Links** | [**List&lt;Link&gt;**](Link.md) | *method&#x3D;GET*Provides link relations as URLs using the REST &#x27;hateoas&#x27; convention (for REST delivered data).&lt;br&gt;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;The &#x27;self&#x27; link references this rest object, including any specified query criteria | 
**MagnetronCurrent** | **float?** | magnetron current value sensed by the radar. Not available for all Radars (e.g., not available for Terma Radars). Available with expand&#x3D;detail | 
**MainBangSuppressLevel** | **float?** | main bang suppression level sensed by the radar. Available with expand&#x3D;detail | 
**MainBangSuppressTiming** | **float?** | main bang timing level sensed by the radar. Available with expand&#x3D;detail | 
**MicCurrent** | **float?** | MIC current value sensed by the radar. Available with expand&#x3D;detail | 
**OrderedTuneVoltage** | **float?** | ordered voltage sent to the radar which controls the tune of the radar&#x27;s receiver. Available with expand&#x3D;detail | 
**RfCoarseTune** | **int?** | RF coarse value used to generate the ordered voltage. Available with expand&#x3D;detail | 
**RfFineTune** | **int?** | RF fine value used to generate the ordered voltage. Available with expand&#x3D;detail | 
**TuneIndicator** | **float?** | the RF Tune readback value, it indicates how well the receiver is tuned. A value &lt;&#x3D; 1.0 is badly tuned or there is something wrong with the radar system and &lt;&#x3D; 1.4 is poorly tuned, otherwise it is considered acceptable. Available with expand&#x3D;detail | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

