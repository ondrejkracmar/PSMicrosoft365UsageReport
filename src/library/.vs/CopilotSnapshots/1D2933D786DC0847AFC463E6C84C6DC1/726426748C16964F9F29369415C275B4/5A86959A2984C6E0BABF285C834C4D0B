#nullable enable
using System.Runtime.Serialization;
using PSMicrosoft365UsageReport.Interface;

namespace PSMicrosoft365UsageReport.Report
{
    /// <summary>
    /// Represents the trend in the number of active users on SharePoint. 
    /// A user is considered active if they executed a file activity (save, sync, modify, or share) or visited a page within the specified time period.
    /// This includes details on the Report Refresh Date, reporting period, and counts of various user activities.
    /// </summary>
    [DataContract]
    public class SharePointActivityUserCounts : IReport
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SharePointActivityUserCounts"/> class.
        /// </summary>
        public SharePointActivityUserCounts() { }

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
        /// The count of users who visited a page.
        /// </summary>
        [DataMember(Name = "Visited Page")]
        public int? VisitedPage { get; set; }

        /// <summary>
        /// The count of users who viewed or edited files.
        /// </summary>
        [DataMember(Name = "Viewed Or Edited")]
        public int? ViewedOrEdited { get; set; }

        /// <summary>
        /// The count of users who synced files.
        /// </summary>
        [DataMember(Name = "Synced")]
        public int? Synced { get; set; }

        /// <summary>
        /// The count of users who shared files internally.
        /// </summary>
        [DataMember(Name = "Shared Internally")]
        public int? SharedInternally { get; set; }

        /// <summary>
        /// The count of users who shared files externally.
        /// </summary>
        [DataMember(Name = "Shared Externally")]
        public int? SharedExternally { get; set; }
    }
}