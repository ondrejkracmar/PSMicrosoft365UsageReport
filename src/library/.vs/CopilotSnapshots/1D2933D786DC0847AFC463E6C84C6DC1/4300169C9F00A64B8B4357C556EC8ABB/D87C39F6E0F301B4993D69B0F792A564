#nullable enable
using System.Runtime.Serialization;
using PSMicrosoft365UsageReport.Interface;

namespace PSMicrosoft365UsageReport.Report
{
    /// <summary>
    /// Represents the count of user mailboxes in each quota category within an organization.
    /// This includes details on the Report Refresh Date, report period, and mailbox counts for various quota statuses
    /// such as under limit, warning issued, send prohibited, and send/receive prohibited.
    /// </summary>
    [DataContract]
    public class MailboxUsageQuotaStatusMailboxCounts : IReport
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MailboxUsageQuotaStatusMailboxCounts"/> class.
        /// </summary>
        public MailboxUsageQuotaStatusMailboxCounts() { }

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
        /// The count of mailboxes under the storage limit.
        /// </summary>
        [DataMember(Name = "UnderLimit")]
        public int? UnderLimit { get; set; }

        /// <summary>
        /// The count of mailboxes for which a warning has been issued due to nearing the storage limit.
        /// </summary>
        [DataMember(Name = "WarningIssued")]
        public int? WarningIssued { get; set; }

        /// <summary>
        /// The count of mailboxes where sending is prohibited due to reaching the storage limit.
        /// </summary>
        [DataMember(Name = "SendProhibited")]
        public int? SendProhibited { get; set; }

        /// <summary>
        /// The count of mailboxes where both sending and receiving are prohibited due to reaching the storage limit.
        /// </summary>
        [DataMember(Name = "SendReceiveProhibited")]
        public int? SendReceiveProhibited { get; set; }

        /// <summary>
        /// The count of mailboxes in an indeterminate quota status.
        /// </summary>
        [DataMember(Name = "Indeterminate")]
        public int? Indeterminate { get; set; }
    }
}
