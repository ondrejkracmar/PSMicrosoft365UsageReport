#nullable enable
using System.Runtime.Serialization;
using PSMicrosoft365UsageReport.Interface;

namespace PSMicrosoft365UsageReport.Report
{
    /// <summary>
    /// Represents the amount of storage used by mailboxes in an organization.
    /// This includes details on the Report Refresh Date, report date, and the total storage used in bytes.
    /// </summary>
    [DataContract]
    public class MailboxUsageStorage : IReport
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MailboxUsageStorage"/> class.
        /// </summary>
        public MailboxUsageStorage() { }

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
        /// The total storage used by mailboxes, in bytes.
        /// </summary>
        [DataMember(Name = "StorageUsedByte")]
        public long StorageUsedByte { get; set; }
    }
}
