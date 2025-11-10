#nullable enable
using System.Runtime.Serialization;
using PSMicrosoft365UsageReport.Interface;

namespace PSMicrosoft365UsageReport.Report
{
    /// <summary>
    /// Represents the total number of files and the count of active files across all group sites associated with a Microsoft 365 group.
    /// This includes details on the Report Refresh Date, reporting period, and counts for files that were viewed, edited, or synced.
    /// </summary>
    [DataContract]
    public class Office365GroupsActivityFileCounts : IReport
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Office365GroupsActivityFileCounts"/> class.
        /// </summary>
        public Office365GroupsActivityFileCounts() { }

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
        /// The total count of files that were viewed or edited across group sites.
        /// </summary>
        [DataMember(Name = "Total")]
        public int? Total { get; set; }

        /// <summary>
        /// The count of files that were synced across group sites.
        /// </summary>
        [DataMember(Name = "Active")]
        public int? Active { get; set; }
    }
}
