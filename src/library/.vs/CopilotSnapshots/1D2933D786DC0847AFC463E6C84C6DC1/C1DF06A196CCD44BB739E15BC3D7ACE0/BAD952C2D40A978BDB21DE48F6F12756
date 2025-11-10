#nullable enable
using System.Runtime.Serialization;
using PSMicrosoft365UsageReport.Interface;

namespace PSMicrosoft365UsageReport.Report
{
    /// <summary>
    /// Represents the number of unique pages visited by users on SharePoint sites.
    /// This includes details on the Report Refresh Date, reporting period, and the count of visited pages.
    /// </summary>
    [DataContract]
    public class SharePointActivityPages : IReport
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SharePointActivityPages"/> class.
        /// </summary>
        public SharePointActivityPages() { }

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
        /// The count of unique pages visited by users.
        /// </summary>
        [DataMember(Name = "VisitedPageCount")]
        public int? VisitedPageCount { get; set; }
    }
}
