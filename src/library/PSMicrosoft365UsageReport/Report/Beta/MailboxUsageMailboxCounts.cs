#nullable enable
using System.Runtime.Serialization;
using PSMicrosoft365UsageReport.Interface;

namespace PSMicrosoft365UsageReport.Report.Beta
{
    /// <summary>
    /// Class representing the response data for the MailboxUsageMailboxCounts report.
    /// Implements the <see cref="IReport"/> interface.
    /// </summary>
    public class MailboxUsageMailboxCounts : IReport
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MailboxUsageMailboxCounts"/> class.
        /// </summary>
        public MailboxUsageMailboxCounts()
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
        /// The total number of user mailboxes during the reporting period, represented as a nullable integer.
        /// </summary>
        public int? Total { get; set; }

        /// <summary>
        /// The total number of active user mailboxes during the reporting period, represented as a nullable integer.
        /// </summary>
        public int? Active { get; set; }
    }
}
