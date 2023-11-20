# Upcoming breaking changes in Azure PowerShell

## Az.Compute

### `New-AzDisk`

- Cmdlet breaking-change will happen to all parameter sets
  - Starting in November 2023 the "New-AzDisk" cmdlet will deploy with the Trusted Launch configuration by default. This includes defaulting the "HyperVGeneration" parameter to "v2". To know more about Trusted Launch, please visit https://aka.ms/TLaD
  - This change is expected to take effect from Az.Compute version: 7.0.0 and Az version: 11.0.0

### `New-AzVM`

- Cmdlet breaking-change will happen to all parameter sets
  - Starting in November 2023 the "New-AzVM" cmdlet will deploy with the Trusted Launch configuration by default. To know more about Trusted Launch, please visit https://aka.ms/TLaD
  - This change is expected to take effect from Az.Compute version: 7.0.0 and Az version: 11.0.0

### `New-AzVmss`

- Cmdlet breaking-change will happen to all parameter sets
  - Starting November 2023, the "New-AzVmss" cmdlet will default to Trusted Launch VMSS. For more info, visit https://aka.ms/TLaD.
  - This change is expected to take effect from Az.Compute version: 7.0.0 and Az version: 11.0.0

## Az.Maintenance

### `New-AzMaintenanceConfiguration`

- Parameter breaking-change will happen to all parameter sets
  - `-PostTask`
    - Parameter is being deprecated without being replaced
    - This change is expected to take effect from Az.Maintenance version: 2.0.0 and Az version: 11.0.0
  - `-PreTask`
    - Parameter is being deprecated without being replaced
    - This change is expected to take effect from Az.Maintenance version: 2.0.0 and Az version: 11.0.0

## Az.RecoveryServices

### `Get-AzRecoveryServicesVaultSettingsFile`

- Parameter breaking-change will happen to all parameter sets
  - `-Certificate`
    - Parameter is being deprecated without being replaced
    - This change is expected to take effect from Az.RecoveryServices version: 7.0.0 and Az version: 11.0.0

## Az.Resources

### `Get-AzPolicyAssignment`

- Cmdlet breaking-change will happen to all parameter sets
  - The output type 'Microsoft.Azure.Commands.ResourceManager.Cmdlets.Implementation.Policy.PsPolicyAssignment' is changing
  - The following properties in the output type are being deprecated : 'Properties'
  - The following properties are being added to the output type : 'Description' 'DisplayName' 'EnforcementMode' 'Metadata' 'NonComplianceMessages' 'NotScopes' 'Parameters' 'PolicyDefinitionId' 'Scope'
  - This change is expected to take effect from Az.Resources version: 7.0.0 and Az version: 11.0.0

### `Get-AzPolicyDefinition`

- Cmdlet breaking-change will happen to all parameter sets
  - The output type 'Microsoft.Azure.Commands.ResourceManager.Cmdlets.Implementation.Policy.PsPolicyDefinition' is changing
  - The following properties in the output type are being deprecated : 'Properties'
  - The following properties are being added to the output type : 'Description' 'DisplayName' 'Metadata' 'Mode' 'Parameters' 'PolicyRule' 'PolicyType'
  - This change is expected to take effect from Az.Resources version: 7.0.0 and Az version: 11.0.0

### `Get-AzPolicyExemption`

- Cmdlet breaking-change will happen to all parameter sets
  - The output type 'Microsoft.Azure.Commands.ResourceManager.Cmdlets.Implementation.Policy.PsPolicyExemption' is changing
  - The following properties in the output type are being deprecated : 'Properties'
  - The following properties are being added to the output type : 'Description' 'DisplayName' 'ExemptionCategory' 'ExpiresOn' 'Metadata' 'PolicyAssignmentId' 'PolicyDefinitionReferenceIds'
  - This change is expected to take effect from Az.Resources version: 7.0.0 and Az version: 11.0.0

### `Get-AzPolicySetDefinition`

- Cmdlet breaking-change will happen to all parameter sets
  - The output type 'Microsoft.Azure.Commands.ResourceManager.Cmdlets.Implementation.Policy.PsPolicySetDefinition' is changing
  - The following properties in the output type are being deprecated : 'Properties'
  - The following properties are being added to the output type : 'Description' 'DisplayName' 'Metadata' 'Parameters' 'PolicyDefinitionGroups' 'PolicyDefinitions' 'PolicyType'
  - This change is expected to take effect from Az.Resources version: 7.0.0 and Az version: 11.0.0

### `New-AzPolicyAssignment`

- Cmdlet breaking-change will happen to all parameter sets
  - The output type 'Microsoft.Azure.Commands.ResourceManager.Cmdlets.Implementation.Policy.PsPolicyAssignment' is changing
  - The following properties in the output type are being deprecated : 'Properties'
  - The following properties are being added to the output type : 'Description' 'DisplayName' 'EnforcementMode' 'Metadata' 'NonComplianceMessages' 'NotScopes' 'Parameters' 'PolicyDefinitionId' 'Scope'
  - This change is expected to take effect from Az.Resources version: 7.0.0 and Az version: 11.0.0

### `New-AzPolicyDefinition`

- Cmdlet breaking-change will happen to all parameter sets
  - The output type 'Microsoft.Azure.Commands.ResourceManager.Cmdlets.Implementation.Policy.PsPolicyDefinition' is changing
  - The following properties in the output type are being deprecated : 'Properties'
  - The following properties are being added to the output type : 'Description' 'DisplayName' 'Metadata' 'Mode' 'Parameters' 'PolicyRule' 'PolicyType'
  - This change is expected to take effect from Az.Resources version: 7.0.0 and Az version: 11.0.0

### `New-AzPolicyExemption`

- Cmdlet breaking-change will happen to all parameter sets
  - The output type 'Microsoft.Azure.Commands.ResourceManager.Cmdlets.Implementation.Policy.PsPolicyExemption' is changing
  - The following properties in the output type are being deprecated : 'Properties'
  - The following properties are being added to the output type : 'Description' 'DisplayName' 'ExemptionCategory' 'ExpiresOn' 'Metadata' 'PolicyAssignmentId' 'PolicyDefinitionReferenceIds'
  - This change is expected to take effect from Az.Resources version: 7.0.0 and Az version: 11.0.0

### `New-AzPolicySetDefinition`

- Cmdlet breaking-change will happen to all parameter sets
  - The output type 'Microsoft.Azure.Commands.ResourceManager.Cmdlets.Implementation.Policy.PsPolicySetDefinition' is changing
  - The following properties in the output type are being deprecated : 'Properties'
  - The following properties are being added to the output type : 'Description' 'DisplayName' 'Metadata' 'Parameters' 'PolicyDefinitionGroups' 'PolicyDefinitions' 'PolicyType'
  - This change is expected to take effect from Az.Resources version: 7.0.0 and Az version: 11.0.0

### `Set-AzPolicyAssignment`

- Cmdlet breaking-change will happen to all parameter sets
  - The output type 'Microsoft.Azure.Commands.ResourceManager.Cmdlets.Implementation.Policy.PsPolicyAssignment' is changing
  - The following properties in the output type are being deprecated : 'Properties'
  - The following properties are being added to the output type : 'Description' 'DisplayName' 'EnforcementMode' 'Metadata' 'NonComplianceMessages' 'NotScopes' 'Parameters' 'PolicyDefinitionId' 'Scope'
  - This change is expected to take effect from Az.Resources version: 7.0.0 and Az version: 11.0.0

### `Set-AzPolicyDefinition`

- Cmdlet breaking-change will happen to all parameter sets
  - The output type 'Microsoft.Azure.Commands.ResourceManager.Cmdlets.Implementation.Policy.PsPolicyDefinition' is changing
  - The following properties in the output type are being deprecated : 'Properties'
  - The following properties are being added to the output type : 'Description' 'DisplayName' 'Metadata' 'Mode' 'Parameters' 'PolicyRule' 'PolicyType'
  - This change is expected to take effect from Az.Resources version: 7.0.0 and Az version: 11.0.0

### `Set-AzPolicyExemption`

- Cmdlet breaking-change will happen to all parameter sets
  - The output type 'Microsoft.Azure.Commands.ResourceManager.Cmdlets.Implementation.Policy.PsPolicyExemption' is changing
  - The following properties in the output type are being deprecated : 'Properties'
  - The following properties are being added to the output type : 'Description' 'DisplayName' 'ExemptionCategory' 'ExpiresOn' 'Metadata' 'PolicyAssignmentId' 'PolicyDefinitionReferenceIds'
  - This change is expected to take effect from Az.Resources version: 7.0.0 and Az version: 11.0.0

### `Set-AzPolicySetDefinition`

- Cmdlet breaking-change will happen to all parameter sets
  - The output type 'Microsoft.Azure.Commands.ResourceManager.Cmdlets.Implementation.Policy.PsPolicySetDefinition' is changing
  - The following properties in the output type are being deprecated : 'Properties'
  - The following properties are being added to the output type : 'Description' 'DisplayName' 'Metadata' 'Parameters' 'PolicyDefinitionGroups' 'PolicyDefinitions' 'PolicyType'
  - This change is expected to take effect from Az.Resources version: 7.0.0 and Az version: 11.0.0

## Az.Storage

### `New-AzStorageAccount`

- Cmdlet breaking-change will happen to all parameter sets
  - Default value of AllowBlobPublicAccess and AllowCrossTenantReplication settings on storage account will be changed to False in the future release. 
  When AllowBlobPublicAccess is False on a storage account, container ACLs cannot be configured to allow anonymous access to blobs within the storage account. 
  When AllowCrossTenantReplication is False on a storage account, cross AAD tenant object replication is not allowed when setting up Object Replication policies.
  - This change is expected to take effect from Az.Storage version: 6.0.0 and Az version: 11.0.0

### `Set-AzStorageAccount`

- Parameter breaking-change will happen to all parameter sets
  - `-EnableLargeFileShare`
    - EnableLargeFileShare parameter will be deprecated in a future release.
    - This change is expected to take effect from Az.Storage version: 6.0.0 and Az version: 11.0.0

