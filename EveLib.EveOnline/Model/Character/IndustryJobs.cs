﻿using System;
using System.Xml.Serialization;

namespace eZet.EveLib.EveOnline.Model.Character {
    [Serializable]
    [XmlRoot("result", IsNullable = false)]
    public class IndustryJobs {
        public enum CompletedStatusType {
            [XmlEnum("0")] Failed,
            [XmlEnum("1")] Delivered,
            [XmlEnum("2")] Aborted,
            [XmlEnum("3")] GmAborted,
            [XmlEnum("4")] Unanchored,
            [XmlEnum("5")] Destroyed
        }

        [XmlElement("rowset")]
        public RowCollection<IndustryJob> Jobs { get; set; }

        [Serializable]
        [XmlRoot("row")]
        public class IndustryJob {
            [XmlAttribute("jobID")]
            public long JobId { get; set; }

            [XmlAttribute("assemblyLineID")]
            public long AssemblyLineId { get; set; }

            [XmlAttribute("containerID")]
            public long ContainerId { get; set; }

            [XmlAttribute("installedItemID")]
            public long InstalledItemId { get; set; }

            [XmlAttribute("installedItemLocationID")]
            public long InstalledItemLocationId { get; set; }

            [XmlAttribute("installedItemQuantity")]
            public int InstalledItemQuantity { get; set; }

            [XmlAttribute("installedItemProductivityLevel")]
            public int InstalledItemProducivityLevel { get; set; }

            [XmlAttribute("installedItemMaterialLevel")]
            public int InstalledItemMaterialLevel { get; set; }

            [XmlAttribute("installedItemLicenseProductionRunsRemaining")]
            public int InstalledItemLicenseProductionRunsRemaining { get; set; }

            [XmlAttribute("outputLocationID")]
            public long OutputLocationId { get; set; }

            [XmlAttribute("installerID")]
            public long InstallerId { get; set; }

            [XmlAttribute("runs")]
            public int Runs { get; set; }

            [XmlAttribute("licensedProductionRuns")]
            public int LicensedProductionRuns { get; set; }

            [XmlAttribute("installedInSolarSystemID")]
            public long InstalledInSolarSystemId { get; set; }

            [XmlAttribute("containerLocationID")]
            public long ContainerLocationId { get; set; }

            [XmlAttribute("materialMultiplier")]
            public float MaterialMultiplier { get; set; }

            [XmlAttribute("charMaterialMultiplier")]
            public float CharMaterialMultiplier { get; set; }

            [XmlAttribute("timeMultiplier")]
            public float TimeMultiplier { get; set; }

            [XmlAttribute("charTimeMultiplier")]
            public float CharTimeMultiplier { get; set; }

            [XmlAttribute("installedItemTypeID")]
            public long InstalledItemTypeId { get; set; }

            [XmlAttribute("outputTypeID")]
            public long OutputTypeId { get; set; }

            [XmlAttribute("containerTypeID")]
            public long containerTypeId { get; set; }

            [XmlAttribute("intalledItemCopy")]
            public bool InstalledItemCopy { get; set; }

            [XmlAttribute("completed")]
            public bool Completed { get; set; }

            [XmlAttribute("completedSuccessfully")]
            public bool CompletedSuccessfully { get; set; }

            [XmlAttribute("installedItemFlag")]
            public int InstalledItemFlag { get; set; }

            [XmlAttribute("outputFlag")]
            public int OutputFlag { get; set; }

            [XmlAttribute("activityID")]
            public int ActivityId { get; set; }

            [XmlAttribute("completedStatus")]
            public CompletedStatusType CompletedStatus { get; set; }

            [XmlIgnore]
            public DateTime InstallTime { get; private set; }

            [XmlAttribute("installTime")]
            public string InstallTimeAsString {
                get { return InstallTime.ToString(XmlHelper.DateFormat); }
                set { InstallTime = DateTime.ParseExact(value, XmlHelper.DateFormat, null); }
            }

            [XmlIgnore]
            public DateTime BeginProductionTime { get; private set; }

            [XmlAttribute("beginProductionTime")]
            public string BeginProductionTimeAsString {
                get { return BeginProductionTime.ToString(XmlHelper.DateFormat); }
                set { BeginProductionTime = DateTime.ParseExact(value, XmlHelper.DateFormat, null); }
            }

            [XmlIgnore]
            public DateTime EndProductionTime { get; private set; }

            [XmlAttribute("endProductionTime")]
            public string EndProductionTimeAsString {
                get { return EndProductionTime.ToString(XmlHelper.DateFormat); }
                set { EndProductionTime = DateTime.ParseExact(value, XmlHelper.DateFormat, null); }
            }

            [XmlIgnore]
            public DateTime PauseProductionTime { get; private set; }

            [XmlAttribute("pauseProductionTime")]
            public string PauseProductionTimeAsString {
                get { return PauseProductionTime.ToString(XmlHelper.DateFormat); }
                set { PauseProductionTime = DateTime.ParseExact(value, XmlHelper.DateFormat, null); }
            }
        }
    }
}