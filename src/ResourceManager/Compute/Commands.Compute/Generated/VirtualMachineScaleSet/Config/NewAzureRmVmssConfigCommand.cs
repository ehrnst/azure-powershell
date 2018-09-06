﻿//
// Copyright (c) Microsoft and contributors.  All rights reserved.
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//   http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
//
// See the License for the specific language governing permissions and
// limitations under the License.
//

// Warning: This code was generated by a tool.
//
// Changes to this file may cause incorrect behavior and will be lost if the
// code is regenerated.

using Microsoft.Azure.Commands.Compute.Automation.Models;
using Microsoft.Azure.Commands.ResourceManager.Common.ArgumentCompleters;
using Microsoft.Azure.Management.Compute.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Management.Automation;

namespace Microsoft.Azure.Commands.Compute.Automation
{
    [Cmdlet("New", ResourceManager.Common.AzureRMConstants.AzureRMPrefix + "VmssConfig", SupportsShouldProcess = true, DefaultParameterSetName = "DefaultParameterSet")]
    [OutputType(typeof(PSVirtualMachineScaleSet))]
    public partial class NewAzureRmVmssConfigCommand : Microsoft.Azure.Commands.ResourceManager.Common.AzureRMCmdlet
    {
        [Parameter(
            Mandatory = false,
            Position = 0,
            ValueFromPipelineByPropertyName = true)]
        public bool? Overprovision { get; set; }

        [Parameter(
            Mandatory = false,
            Position = 1,
            ValueFromPipelineByPropertyName = true)]
        [LocationCompleter("Microsoft.Compute/virtualMachineScaleSets")]
        public string Location { get; set; }

        [Parameter(
            Mandatory = false,
            Position = 2,
            ValueFromPipelineByPropertyName = true)]
        public Hashtable Tag { get; set; }

        [Parameter(
            Mandatory = false,
            Position = 3,
            ValueFromPipelineByPropertyName = true)]
        [Alias("AccountType")]
        public string SkuName { get; set; }

        [Parameter(
            Mandatory = false,
            Position = 4,
            ValueFromPipelineByPropertyName = true)]
        public string SkuTier { get; set; }

        [Parameter(
            Mandatory = false,
            Position = 5,
            ValueFromPipelineByPropertyName = true)]
        public int SkuCapacity { get; set; }

        [Parameter(
            Mandatory = false,
            Position = 6,
            ValueFromPipelineByPropertyName = true)]
        public UpgradeMode? UpgradePolicyMode { get; set; }

        [Parameter(
            Mandatory = false,
            Position = 7,
            ValueFromPipelineByPropertyName = true)]
        public VirtualMachineScaleSetOSProfile OsProfile { get; set; }

        [Parameter(
            Mandatory = false,
            Position = 8,
            ValueFromPipelineByPropertyName = true)]
        public VirtualMachineScaleSetStorageProfile StorageProfile { get; set; }

        [Parameter(
            Mandatory = false,
            Position = 9,
            ValueFromPipelineByPropertyName = true)]
        public VirtualMachineScaleSetNetworkConfiguration[] NetworkInterfaceConfiguration { get; set; }

        [Parameter(
            Mandatory = false,
            Position = 10,
            ValueFromPipelineByPropertyName = true)]
        public VirtualMachineScaleSetExtension[] Extension { get; set; }

        [Parameter(
            Mandatory = false,
            ValueFromPipelineByPropertyName = true)]
        public bool? SinglePlacementGroup { get; set; }

        [Parameter(
            Mandatory = false)]
        public SwitchParameter ZoneBalance { get; set; }

        [Parameter(
            Mandatory = false,
            ValueFromPipelineByPropertyName = true)]
        public int PlatformFaultDomainCount { get; set; }

        [Parameter(
            Mandatory = false,
            ValueFromPipelineByPropertyName = true)]
        public string[] Zone { get; set; }

        [Parameter(
            Mandatory = false,
            ValueFromPipelineByPropertyName = true)]
        public string PlanName { get; set; }

        [Parameter(
            Mandatory = false,
            ValueFromPipelineByPropertyName = true)]
        public string PlanPublisher { get; set; }

        [Parameter(
            Mandatory = false,
            ValueFromPipelineByPropertyName = true)]
        public string PlanProduct { get; set; }

        [Parameter(
            Mandatory = false,
            ValueFromPipelineByPropertyName = true)]
        public string PlanPromotionCode { get; set; }

        [Parameter(
            Mandatory = false,
            ValueFromPipelineByPropertyName = true)]
        public RollingUpgradePolicy RollingUpgradePolicy { get; set; }

        [Parameter(
            Mandatory = false)]
        public SwitchParameter AutoOSUpgrade { get; set; }

        [Parameter(
            Mandatory = false)]
        public bool DisableAutoRollback { get; set; }

        [Parameter(
            Mandatory = false,
            ValueFromPipelineByPropertyName = true)]
        public string HealthProbeId { get; set; }

        [Parameter(
            Mandatory = false,
            ValueFromPipelineByPropertyName = true)]
        public BootDiagnostics BootDiagnostic { get; set; }

        [Parameter(
            Mandatory = false,
            ValueFromPipelineByPropertyName = true)]
        public string LicenseType { get; set; }

        [Parameter(
            Mandatory = false,
            ValueFromPipelineByPropertyName = true)]
        public string Priority { get; set; }

        [Parameter(
            Mandatory = false,
            ValueFromPipelineByPropertyName = true)]
        [PSArgumentCompleter("Deallocate", "Delete")]
        public string EvictionPolicy { get; set; }

        [Parameter(
            Mandatory = true,
            ParameterSetName = "ExplicitIdentityParameterSet",
            ValueFromPipelineByPropertyName = true)]
        public ResourceIdentityType? IdentityType { get; set; }

        [Parameter(
            Mandatory = false,
            ParameterSetName = "ExplicitIdentityParameterSet",
            ValueFromPipelineByPropertyName = true)]
        public string[] IdentityId { get; set; }

        protected override void ProcessRecord()
        {
            if (ShouldProcess("VirtualMachineScaleSet", "New"))
            {
                Run();
            }
        }

        private void Run()
        {
            // Sku
            Microsoft.Azure.Management.Compute.Models.Sku vSku = null;

            // Plan
            Microsoft.Azure.Management.Compute.Models.Plan vPlan = null;

            // UpgradePolicy
            Microsoft.Azure.Management.Compute.Models.UpgradePolicy vUpgradePolicy = null;

            // VirtualMachineProfile
            Microsoft.Azure.Management.Compute.Models.VirtualMachineScaleSetVMProfile vVirtualMachineProfile = null;

            // Identity
            Microsoft.Azure.Management.Compute.Models.VirtualMachineScaleSetIdentity vIdentity = null;

            if (this.MyInvocation.BoundParameters.ContainsKey("SkuName"))
            {
                if (vSku == null)
                {
                    vSku = new Microsoft.Azure.Management.Compute.Models.Sku();
                }
                vSku.Name = this.SkuName;
            }

            if (this.MyInvocation.BoundParameters.ContainsKey("SkuTier"))
            {
                if (vSku == null)
                {
                    vSku = new Microsoft.Azure.Management.Compute.Models.Sku();
                }
                vSku.Tier = this.SkuTier;
            }

            if (this.MyInvocation.BoundParameters.ContainsKey("SkuCapacity"))
            {
                if (vSku == null)
                {
                    vSku = new Microsoft.Azure.Management.Compute.Models.Sku();
                }
                vSku.Capacity = this.SkuCapacity;
            }

            if (this.MyInvocation.BoundParameters.ContainsKey("PlanName"))
            {
                if (vPlan == null)
                {
                    vPlan = new Microsoft.Azure.Management.Compute.Models.Plan();
                }
                vPlan.Name = this.PlanName;
            }

            if (this.MyInvocation.BoundParameters.ContainsKey("PlanPublisher"))
            {
                if (vPlan == null)
                {
                    vPlan = new Microsoft.Azure.Management.Compute.Models.Plan();
                }
                vPlan.Publisher = this.PlanPublisher;
            }

            if (this.MyInvocation.BoundParameters.ContainsKey("PlanProduct"))
            {
                if (vPlan == null)
                {
                    vPlan = new Microsoft.Azure.Management.Compute.Models.Plan();
                }
                vPlan.Product = this.PlanProduct;
            }

            if (this.MyInvocation.BoundParameters.ContainsKey("PlanPromotionCode"))
            {
                if (vPlan == null)
                {
                    vPlan = new Microsoft.Azure.Management.Compute.Models.Plan();
                }
                vPlan.PromotionCode = this.PlanPromotionCode;
            }

            if (this.MyInvocation.BoundParameters.ContainsKey("UpgradePolicyMode"))
            {
                if (vUpgradePolicy == null)
                {
                    vUpgradePolicy = new Microsoft.Azure.Management.Compute.Models.UpgradePolicy();
                }
                vUpgradePolicy.Mode = this.UpgradePolicyMode;
            }

            if (this.MyInvocation.BoundParameters.ContainsKey("RollingUpgradePolicy"))
            {
                if (vUpgradePolicy == null)
                {
                    vUpgradePolicy = new Microsoft.Azure.Management.Compute.Models.UpgradePolicy();
                }
                vUpgradePolicy.RollingUpgradePolicy = this.RollingUpgradePolicy;
            }

            if (vUpgradePolicy == null)
            {
                vUpgradePolicy = new Microsoft.Azure.Management.Compute.Models.UpgradePolicy();
            }
            vUpgradePolicy.AutomaticOSUpgrade = this.AutoOSUpgrade.IsPresent;

            if (this.MyInvocation.BoundParameters.ContainsKey("DisableAutoRollback"))
            {
                if (vUpgradePolicy == null)
                {
                    vUpgradePolicy = new Microsoft.Azure.Management.Compute.Models.UpgradePolicy();
                }
                if (vUpgradePolicy.AutoOSUpgradePolicy == null)
                {
                    vUpgradePolicy.AutoOSUpgradePolicy = new Microsoft.Azure.Management.Compute.Models.AutoOSUpgradePolicy();
                }
                vUpgradePolicy.AutoOSUpgradePolicy.DisableAutoRollback = this.DisableAutoRollback;
            }

            if (this.MyInvocation.BoundParameters.ContainsKey("OsProfile"))
            {
                if (vVirtualMachineProfile == null)
                {
                    vVirtualMachineProfile = new Microsoft.Azure.Management.Compute.Models.VirtualMachineScaleSetVMProfile();
                }
                vVirtualMachineProfile.OsProfile = this.OsProfile;
            }

            if (this.MyInvocation.BoundParameters.ContainsKey("StorageProfile"))
            {
                if (vVirtualMachineProfile == null)
                {
                    vVirtualMachineProfile = new Microsoft.Azure.Management.Compute.Models.VirtualMachineScaleSetVMProfile();
                }
                vVirtualMachineProfile.StorageProfile = this.StorageProfile;
            }

            if (this.MyInvocation.BoundParameters.ContainsKey("HealthProbeId"))
            {
                if (vVirtualMachineProfile == null)
                {
                    vVirtualMachineProfile = new Microsoft.Azure.Management.Compute.Models.VirtualMachineScaleSetVMProfile();
                }
                if (vVirtualMachineProfile.NetworkProfile == null)
                {
                    vVirtualMachineProfile.NetworkProfile = new Microsoft.Azure.Management.Compute.Models.VirtualMachineScaleSetNetworkProfile();
                }
                if (vVirtualMachineProfile.NetworkProfile.HealthProbe == null)
                {
                    vVirtualMachineProfile.NetworkProfile.HealthProbe = new Microsoft.Azure.Management.Compute.Models.ApiEntityReference();
                }
                vVirtualMachineProfile.NetworkProfile.HealthProbe.Id = this.HealthProbeId;
            }

            if (this.MyInvocation.BoundParameters.ContainsKey("NetworkInterfaceConfiguration"))
            {
                if (vVirtualMachineProfile == null)
                {
                    vVirtualMachineProfile = new Microsoft.Azure.Management.Compute.Models.VirtualMachineScaleSetVMProfile();
                }
                if (vVirtualMachineProfile.NetworkProfile == null)
                {
                    vVirtualMachineProfile.NetworkProfile = new Microsoft.Azure.Management.Compute.Models.VirtualMachineScaleSetNetworkProfile();
                }
                vVirtualMachineProfile.NetworkProfile.NetworkInterfaceConfigurations = this.NetworkInterfaceConfiguration;
            }

            if (this.MyInvocation.BoundParameters.ContainsKey("BootDiagnostic"))
            {
                if (vVirtualMachineProfile == null)
                {
                    vVirtualMachineProfile = new Microsoft.Azure.Management.Compute.Models.VirtualMachineScaleSetVMProfile();
                }
                if (vVirtualMachineProfile.DiagnosticsProfile == null)
                {
                    vVirtualMachineProfile.DiagnosticsProfile = new Microsoft.Azure.Management.Compute.Models.DiagnosticsProfile();
                }
                vVirtualMachineProfile.DiagnosticsProfile.BootDiagnostics = this.BootDiagnostic;
            }

            if (this.MyInvocation.BoundParameters.ContainsKey("Extension"))
            {
                if (vVirtualMachineProfile == null)
                {
                    vVirtualMachineProfile = new Microsoft.Azure.Management.Compute.Models.VirtualMachineScaleSetVMProfile();
                }
                if (vVirtualMachineProfile.ExtensionProfile == null)
                {
                    vVirtualMachineProfile.ExtensionProfile = new Microsoft.Azure.Management.Compute.Models.VirtualMachineScaleSetExtensionProfile();
                }
                vVirtualMachineProfile.ExtensionProfile.Extensions = this.Extension;
            }

            if (this.MyInvocation.BoundParameters.ContainsKey("LicenseType"))
            {
                if (vVirtualMachineProfile == null)
                {
                    vVirtualMachineProfile = new Microsoft.Azure.Management.Compute.Models.VirtualMachineScaleSetVMProfile();
                }
                vVirtualMachineProfile.LicenseType = this.LicenseType;
            }

            if (this.MyInvocation.BoundParameters.ContainsKey("Priority"))
            {
                if (vVirtualMachineProfile == null)
                {
                    vVirtualMachineProfile = new Microsoft.Azure.Management.Compute.Models.VirtualMachineScaleSetVMProfile();
                }
                vVirtualMachineProfile.Priority = this.Priority;
            }

            if (this.MyInvocation.BoundParameters.ContainsKey("EvictionPolicy"))
            {
                if (vVirtualMachineProfile == null)
                {
                    vVirtualMachineProfile = new Microsoft.Azure.Management.Compute.Models.VirtualMachineScaleSetVMProfile();
                }
                vVirtualMachineProfile.EvictionPolicy = this.EvictionPolicy;
            }

            if (this.AssignIdentity.IsPresent)
            {
                if (vIdentity == null)
                {
                    vIdentity = new Microsoft.Azure.Management.Compute.Models.VirtualMachineScaleSetIdentity();
                }
                vIdentity.Type = ResourceIdentityType.SystemAssigned;
            }

            if (this.MyInvocation.BoundParameters.ContainsKey("IdentityType"))
            {
                if (vIdentity == null)
                {
                    vIdentity = new Microsoft.Azure.Management.Compute.Models.VirtualMachineScaleSetIdentity();
                }
                vIdentity.Type = this.IdentityType;
            }

            if (this.MyInvocation.BoundParameters.ContainsKey("IdentityId"))
            {
                if (vIdentity == null)
                {
                    vIdentity = new Microsoft.Azure.Management.Compute.Models.VirtualMachineScaleSetIdentity();
                }
                vIdentity.IdentityIds = this.IdentityId;
            }

            var vVirtualMachineScaleSet = new PSVirtualMachineScaleSet
            {
                Overprovision = this.MyInvocation.BoundParameters.ContainsKey("Overprovision") ? this.Overprovision : (bool?) null,
                SinglePlacementGroup = this.MyInvocation.BoundParameters.ContainsKey("SinglePlacementGroup") ? this.SinglePlacementGroup : (bool?) null,
                ZoneBalance = this.ZoneBalance.IsPresent ? true : (bool?) null,
                PlatformFaultDomainCount = this.MyInvocation.BoundParameters.ContainsKey("PlatformFaultDomainCount") ? this.PlatformFaultDomainCount : (int?) null,
                Zones = this.MyInvocation.BoundParameters.ContainsKey("Zone") ? this.Zone : null,
                Location = this.MyInvocation.BoundParameters.ContainsKey("Location") ? this.Location : null,
                Tags = this.MyInvocation.BoundParameters.ContainsKey("Tag") ? this.Tag.Cast<DictionaryEntry>().ToDictionary(ht => (string)ht.Key, ht => (string)ht.Value) : null,
                Sku = vSku,
                Plan = vPlan,
                UpgradePolicy = vUpgradePolicy,
                VirtualMachineProfile = vVirtualMachineProfile,
                Identity = vIdentity,
            };

            WriteObject(vVirtualMachineScaleSet);
        }
    }
}
