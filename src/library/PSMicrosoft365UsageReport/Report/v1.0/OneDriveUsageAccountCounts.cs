using System.Runtime.Serialization;
using PSMicrosoft365UsageReport.Interface;

namespace PSMicrosoft365UsageReport.Report
{
    /// <summary>
    /// Represents the trend in the number of active OneDrive for Business sites.
    /// Any site on which users viewed, modified, uploaded, downloaded, shared, or synced files is considered an active site.
    /// This includes details on the Report Refresh Date, reporting period, site type, and counts of total and active sites.
    /// </summary>
    [DataContract]
    public class OneDriveUsageAccountCounts : IReport
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OneDriveUsageAccountCounts"/> class.
        /// </summary>
        public OneDriveUsageAccountCounts() { }

        /// <summary>
        /// The date when the report was last refreshed.
        /// </summary>
        [DataMember(Name = "Report Refresh Date")]
        public string? ReportRefreshDate { get; set; }

        /// <summary>
        /// The date associated with the report.
        /// </summary>
        [DataMember(Name = "Report Date")]
        public string? ReportDate { get; set; }

        /// <summary>
        /// The period covered by the report.
        /// </summary>
        [DataMember(Name = "Report Period")]
        public int? ReportPeriod { get; set; }

        /// <summary>
        /// The type of site (e.g., personal or shared).
        /// </summary>
        [DataMember(Name = "Site Type")]
        public string? SiteType { get; set; }

        /// <summary>
        /// The total number of OneDrive sites.
        /// </summary>
        [DataMember(Name = "Total")]
        public int? Total { get; set; }

        /// <summary>
        /// The count of active OneDrive sites.
        /// </summary>
        [DataMember(Name = "Active")]
        public int? Active { get; set; }
    }
}
