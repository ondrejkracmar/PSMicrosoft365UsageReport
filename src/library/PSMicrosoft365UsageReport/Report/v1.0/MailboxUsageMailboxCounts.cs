using System.Runtime.Serialization;
using PSMicrosoft365UsageReport.Interface;

namespace PSMicrosoft365UsageReport.Report
{
    /// <summary>
    /// Represents the total number of user mailboxes in an organization and the number of active mailboxes each day of the reporting period.
    /// This includes details on the Report Refresh Date, report date, total mailboxes, and active mailboxes.
    /// </summary>
    [DataContract]
    public class MailboxUsageMailboxCounts : IReport
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MailboxUsageMailboxCounts"/> class.
        /// </summary>
        public MailboxUsageMailboxCounts() { }

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
        /// The total number of user mailboxes in the organization.
        /// </summary>
        [DataMember(Name = "Total")]
        public int? Total { get; set; }

        /// <summary>
        /// The number of active mailboxes in the organization.
        /// </summary>
        [DataMember(Name = "Active")]
        public int? Active { get; set; }
    }
}
