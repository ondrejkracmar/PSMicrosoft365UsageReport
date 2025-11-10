#nullable enable
using System.Runtime.Serialization;
using PSMicrosoft365UsageReport.Interface;

namespace PSMicrosoft365UsageReport.Report
{
    /// <summary>
    /// Represents the total number of files across all OneDrive sites and the count of active files.
    /// A file is considered active if it has been saved, synced, modified, or shared within the specified time period.
    /// This includes details on the Report Refresh Date, reporting period, site type, and file activity counts.
    /// </summary>
    [DataContract]
    public class OneDriveUsageFileCounts : IReport
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OneDriveUsageFileCounts"/> class.
        /// </summary>
        public OneDriveUsageFileCounts() { }

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
        /// The type of site (e.g., personal or shared).
        /// </summary>
        [DataMember(Name = "SiteType")]
        public string? SiteType { get; set; }

        /// <summary>
        /// The total number of files across all OneDrive sites.
        /// </summary>
        [DataMember(Name = "Total")]
        public int? Total { get; set; }

        /// <summary>
        /// The count of active files across all OneDrive sites.
        /// </summary>
        [DataMember(Name = "Active")]
        public int? Active { get; set; }
    }
}
