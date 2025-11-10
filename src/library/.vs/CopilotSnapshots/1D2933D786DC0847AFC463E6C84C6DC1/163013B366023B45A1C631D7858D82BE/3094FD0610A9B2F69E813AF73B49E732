#nullable enable
using System.Runtime.Serialization;
using PSMicrosoft365UsageReport.Interface;

namespace PSMicrosoft365UsageReport.Report
{
    /// <summary>
    /// Represents the trend of total and active SharePoint site counts during the reporting period.
    /// This includes details on the Report Refresh Date, reporting period, site type, and counts of total and active sites.
    /// </summary>
    [DataContract]
    public class SharePointSiteUsageSiteCounts : IReport
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SharePointSiteUsageSiteCounts"/> class.
        /// </summary>
        public SharePointSiteUsageSiteCounts() { }

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
        /// The total number of SharePoint sites.
        /// </summary>
        [DataMember(Name = "Total")]
        public int? Total { get; set; }

        /// <summary>
        /// The count of active SharePoint sites.
        /// </summary>
        [DataMember(Name = "Active")]
        public int? Active { get; set; }
    }
}
