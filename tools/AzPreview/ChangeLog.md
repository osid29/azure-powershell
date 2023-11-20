## 11.1.0 - December 2023
#### Az.Compute 7.1.0
* Added new parameter '-ElasticSanResourceId' to 'New-AzSnapshotConfig' cmdlet.
* Added new parameter '-OptimizedForFrequentAttach' to 'New-AzDiskConfig' cmdlet.
* Added new examples in 'New-AzVM' and 'New-AzVmss' for TrustedLaunch default usage.

#### Az.DataFactory 1.18.0
* Added support GoogleAds and LakeHouse in ADF
* Added support copyComputeScale And pipelineExternalComputeScale in 'Set-AzDataFactoryV2IntegrationRuntime' Command

#### Az.Resources 6.12.1
* Used utf8 encoding for reading stdout & stderr when invoking Bicep. [#23246]
* Fixed regression in 'Publish-AzBicepModule' [Azure/bicep/12461](https://github.com/Azure/bicep/issues/12461)

#### Az.ServiceFabric 3.3.1
* Fixed a bug that Get commands do not return all resources.

#### Az.Sql 4.12.0
* Added new parameters 'MaintenanceConfigurationId', 'DnsZone' to 'AzSqlInstancePool' cmdlets

#### Az.Storage 6.0.1
* Updated error message when storage context is missing in a cmdlet input 

