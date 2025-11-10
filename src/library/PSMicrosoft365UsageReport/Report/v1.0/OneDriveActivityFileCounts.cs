#nullable enable
using System.Runtime.Serialization;
using PSMicrosoft365UsageReport.Interface;

namespace PSMicrosoft365UsageReport.Report
{
    /// <summary>
    /// Represents the number of unique, licensed users who performed file interactions with any OneDrive account.
    /// This includes details on the Report Refresh Date, reporting period, and counts of file activities such as viewing, editing, syncing, and sharing.
    /// </summary>
    [DataContract]
    public class OneDriveActivityFileCounts : IReport
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OneDriveActivityFileCounts"/> class.
        /// </summary>
        public OneDriveActivityFileCounts() { }

        /// <summary>
        /// The date when the report was last refreshed.
        /// </summary>
        [DataMember(Name = "ReportRefreshDate")]
        public string? ReportRefreshDate { get; set; }

        /// <summary>
        /// The date associated with the report.
        /// </summary>
        [DataMember(Name = "ReportDate")]
        public string? ReportDate { get; set; }

        /// <summary>
        /// The period covered by the report.
        /// </summary>
        [DataMember(Name = "ReportPeriod")]
        public int? ReportPeriod { get; set; }

        /// <summary>
        /// The count of files that were viewed or edited.
        /// </summary>
        [DataMember(Name = "ViewedOrEdited")]
        public int? ViewedOrEdited { get; set; }

        /// <summary>
        /// The count of files that were synced.
        /// </summary>
        [DataMember(Name = "Synced")]
        public int? Synced { get; set; }

        /// <summary>
        /// The count of files shared internally.
        /// </summary>
        [DataMember(Name = "SharedInternally")]
        public int? SharedInternally { get; set; }

        /// <summary>
        /// The count of files shared externally.
        /// </summary>
        [DataMember(Name = "SharedExternally")]
        public int? SharedExternally { get; set; }
    }
}