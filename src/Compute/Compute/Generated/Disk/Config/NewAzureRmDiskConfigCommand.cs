//
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
using Microsoft.WindowsAzure.Commands.Common.CustomAttributes;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Management.Automation;

namespace Microsoft.Azure.Commands.Compute.Automation
{
    [CmdletOutputBreakingChange(typeof(PSDisk),
                                DeprecatedOutputProperties = new string[] { "EncryptionSettings" },
                                NewOutputProperties = new string[] { "EncryptionSettingsCollection", "HyperVGeneration", "DiskState" })]
    [Cmdlet(VerbsCommon.New, ResourceManager.Common.AzureRMConstants.AzureRMPrefix + "DiskConfig", SupportsShouldProcess = true)]
    [OutputType(typeof(PSDisk))]
    public partial class NewAzureRmDiskConfigCommand : Microsoft.Azure.Commands.ResourceManager.Common.AzureRMCmdlet
    {
        [Parameter(
            Mandatory = false,
            Position = 0,
            ValueFromPipelineByPropertyName = true)]
        [Alias("AccountType")]
        [PSArgumentCompleter("Standard_LRS", "Premium_LRS", "StandardSSD_LRS", "UltraSSD_LRS")]
        public string SkuName { get; set; }

        [Parameter(
            Mandatory = false,
            Position = 1,
            ValueFromPipelineByPropertyName = true)]
        public OperatingSystemTypes? OsType { get; set; }

        [Parameter(
            Mandatory = false,
            Position = 2,
            ValueFromPipelineByPropertyName = true)]
        public int DiskSizeGB { get; set; }

        [Parameter(
            Mandatory = false,
            Position = 3,
            ValueFromPipelineByPropertyName = true)]
        [LocationCompleter("Microsoft.Compute/disks")]
        public string Location { get; set; }

        [Parameter(
            Mandatory = false,
            ValueFromPipelineByPropertyName = true)]
        public string[] Zone { get; set; }

        [Parameter(
            Mandatory = false,
            ValueFromPipelineByPropertyName = true)]
        public int DiskIOPSReadWrite { get; set; }

        [Parameter(
            Mandatory = false,
            ValueFromPipelineByPropertyName = true)]
        public int DiskMBpsReadWrite { get; set; }

        [Parameter(
            Mandatory = false,
            ValueFromPipelineByPropertyName = true)]
        public Hashtable Tag { get; set; }

        [Parameter(
            Mandatory = false,
            ValueFromPipelineByPropertyName = true)]
        public string CreateOption { get; set; }

        [Parameter(
            Mandatory = false,
            ValueFromPipelineByPropertyName = true)]
        public string StorageAccountId { get; set; }

        [Parameter(
            Mandatory = false,
            ValueFromPipelineByPropertyName = true)]
        public ImageDiskReference ImageReference { get; set; }

        [Parameter(
            Mandatory = false,
            ValueFromPipelineByPropertyName = true)]
        public string SourceUri { get; set; }

        [Parameter(
            Mandatory = false,
            ValueFromPipelineByPropertyName = true)]
        public string SourceResourceId { get; set; }

        [Parameter(
            Mandatory = false,
            ValueFromPipelineByPropertyName = true)]
        public bool? EncryptionSettingsEnabled { get; set; }

        [Parameter(
            Mandatory = false,
            ValueFromPipelineByPropertyName = true)]
        public KeyVaultAndSecretReference DiskEncryptionKey { get; set; }

        [Parameter(
            Mandatory = false,
            ValueFromPipelineByPropertyName = true)]
        public KeyVaultAndKeyReference KeyEncryptionKey { get; set; }

        protected override void ProcessRecord()
        {
            if (ShouldProcess("Disk", "New"))
            {
                Run();
            }
        }

        private void Run()
        {
            // Sku
            DiskSku vSku = null;

            // CreationData
            CreationData vCreationData = null;

            // EncryptionSettingsCollection
            EncryptionSettingsCollection vEncryptionSettingsCollection = null;

            if (this.MyInvocation.BoundParameters.ContainsKey("SkuName"))
            {
                if (vSku == null)
                {
                    vSku = new DiskSku();
                }
                vSku.Name = this.SkuName;
            }

            if (this.MyInvocation.BoundParameters.ContainsKey("CreateOption"))
            {
                if (vCreationData == null)
                {
                    vCreationData = new CreationData();
                }
                vCreationData.CreateOption = this.CreateOption;
            }

            if (this.MyInvocation.BoundParameters.ContainsKey("StorageAccountId"))
            {
                if (vCreationData == null)
                {
                    vCreationData = new CreationData();
                }
                vCreationData.StorageAccountId = this.StorageAccountId;
            }

            if (this.MyInvocation.BoundParameters.ContainsKey("ImageReference"))
            {
                if (vCreationData == null)
                {
                    vCreationData = new CreationData();
                }
                vCreationData.ImageReference = this.ImageReference;
            }

            if (this.MyInvocation.BoundParameters.ContainsKey("SourceUri"))
            {
                if (vCreationData == null)
                {
                    vCreationData = new CreationData();
                }
                vCreationData.SourceUri = this.SourceUri;
            }

            if (this.MyInvocation.BoundParameters.ContainsKey("SourceResourceId"))
            {
                if (vCreationData == null)
                {
                    vCreationData = new CreationData();
                }
                vCreationData.SourceResourceId = this.SourceResourceId;
            }

            if (this.MyInvocation.BoundParameters.ContainsKey("EncryptionSettingsEnabled"))
            {
                if (vEncryptionSettingsCollection == null)
                {
                    vEncryptionSettingsCollection = new EncryptionSettingsCollection();
                }
                vEncryptionSettingsCollection.Enabled = (bool) this.EncryptionSettingsEnabled;
            }

            if (this.MyInvocation.BoundParameters.ContainsKey("DiskEncryptionKey"))
            {
                if (vEncryptionSettingsCollection == null)
                {
                    vEncryptionSettingsCollection = new EncryptionSettingsCollection();
                }

                if (vEncryptionSettingsCollection.EncryptionSettings == null)
                {
                    vEncryptionSettingsCollection.EncryptionSettings = new List<EncryptionSettingsElement>();
                }

                if (vEncryptionSettingsCollection.EncryptionSettings.Count == 0)
                {
                    vEncryptionSettingsCollection.EncryptionSettings.Add(new EncryptionSettingsElement());
                }

                vEncryptionSettingsCollection.EncryptionSettings[0].DiskEncryptionKey = this.DiskEncryptionKey;
            }

            if (this.MyInvocation.BoundParameters.ContainsKey("KeyEncryptionKey"))
            {
                if (vEncryptionSettingsCollection == null)
                {
                    vEncryptionSettingsCollection = new EncryptionSettingsCollection();
                }

                if (vEncryptionSettingsCollection.EncryptionSettings == null)
                {
                    vEncryptionSettingsCollection.EncryptionSettings = new List<EncryptionSettingsElement>();
                }

                if (vEncryptionSettingsCollection.EncryptionSettings.Count == 0)
                {
                    vEncryptionSettingsCollection.EncryptionSettings.Add(new EncryptionSettingsElement());
                }

                vEncryptionSettingsCollection.EncryptionSettings[0].KeyEncryptionKey = this.KeyEncryptionKey;
            }

            var vDisk = new PSDisk
            {
                Zones = this.MyInvocation.BoundParameters.ContainsKey("Zone") ? this.Zone : null,
                OsType = this.MyInvocation.BoundParameters.ContainsKey("OsType") ? this.OsType : (OperatingSystemTypes?)null,
                DiskSizeGB = this.MyInvocation.BoundParameters.ContainsKey("DiskSizeGB") ? this.DiskSizeGB : (int?)null,
                DiskIOPSReadWrite = this.MyInvocation.BoundParameters.ContainsKey("DiskIOPSReadWrite") ? this.DiskIOPSReadWrite : (int?)null,
                DiskMBpsReadWrite = this.MyInvocation.BoundParameters.ContainsKey("DiskMBpsReadWrite") ? this.DiskMBpsReadWrite : (int?)null,
                Location = this.MyInvocation.BoundParameters.ContainsKey("Location") ? this.Location : null,
                Tags = this.MyInvocation.BoundParameters.ContainsKey("Tag") ? this.Tag.Cast<DictionaryEntry>().ToDictionary(ht => (string)ht.Key, ht => (string)ht.Value) : null,
                Sku = vSku,
                CreationData = vCreationData,
                EncryptionSettingsCollection = vEncryptionSettingsCollection,
            };

            WriteObject(vDisk);
        }
    }
}
