#nullable enable
using System.Runtime.Serialization;
using PSMicrosoft365UsageReport.Interface;

namespace PSMicrosoft365UsageReport.Report.Beta
{
    /// <summary>
    /// Class representing the response data for the MailboxUsageQuotaStatusMailboxCounts report.
    /// Implements the <see cref="IReport"/> interface.
    /// </summary>
    public class MailboxUsageQuotaStatusMailboxCounts : IReport
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MailboxUsageQuotaStatusMailboxCounts"/> class.
        /// </summary>
        public MailboxUsageQuotaStatusMailboxCounts()
        {
        }

        /// <summary>
        /// The date when the report was last refreshed, represented as a nullable string.
        /// </summary>
        public string? ReportRefreshDate { get; set; }

        /// <summary>
        /// The date of the report, represented as a nullable string.
        /// </summary>
        public string? ReportDate { get; set; }

        /// <summary>
        /// The period covered by the report in days, represented as a nullable integer.
        /// </summary>
        public int? ReportPeriod { get; set; }

        /// <summary>
        /// The count of user mailboxes under the quota limit, represented as a nullable integer.
        /// </summary>
        public int? UnderLimit { get; set; }

        /// <summary>
        /// The count of user mailboxes that have received a warning, represented as a nullable integer.
        /// </summary>
        public int? WarningIssued { get; set; }

        /// <summary>
        /// The count of user mailboxes where sending is prohibited, represented as a nullable integer.
        /// </summary>
        public int? SendProhibited { get; set; }

        /// <summary>
        /// The count of user mailboxes where sending and receiving are prohibited, represented as a nullable integer.
        /// </summary>
        public int? SendReceiveProhibited { get; set; }

        /// <summary>
        /// The count of user mailboxes with an indeterminate quota status, represented as a nullable integer.
        /// </summary>
        public int? Indeterminate { get; set; }
    }
}
