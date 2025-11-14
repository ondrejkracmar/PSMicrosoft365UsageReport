#nullable enable
using System.Runtime.Serialization;
using PSMicrosoft365UsageReport.Interface;

namespace PSMicrosoft365UsageReport.Report
{
    /// <summary>
    /// Represents the daily total number of groups and the count of active groups based on email conversations, Yammer posts, and SharePoint file activities.
    /// This includes details on the Report Refresh Date, reporting period, and counts of total and active groups.
    /// </summary>
    [DataContract]
    public class Office365GroupsActivityGroupCounts : IReport
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Office365GroupsActivityGroupCounts"/> class.
        /// </summary>
        public Office365GroupsActivityGroupCounts() { }

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
        /// The total number of groups in the organization.
        /// </summary>
        [DataMember(Name = "Total")]
        public int? Total { get; set; }

        /// <summary>
        /// The count of active groups based on activity in email, Yammer, and SharePoint.
        /// </summary>
        [DataMember(Name = "Active")]
        public int? Active { get; set; }
    }
}
