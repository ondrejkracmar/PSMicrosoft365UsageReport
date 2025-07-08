#nullable enable
using System.Runtime.Serialization;
using PSMicrosoft365UsageReport.Interface;

namespace PSMicrosoft365UsageReport.Report
{
    /// <summary>
    /// Represents the number of pages viewed across all SharePoint sites.
    /// This includes details on the Report Refresh Date, reporting period, site type, and the count of page views.
    /// </summary>
    [DataContract]
    public class SharePointSiteUsagePages : IReport
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SharePointSiteUsagePages"/> class.
        /// </summary>
        public SharePointSiteUsagePages() { }

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
        /// The count of page views across all SharePoint sites.
        /// </summary>
        [DataMember(Name = "Page View Count")]
        public int? PageViewCount { get; set; }
    }
}
