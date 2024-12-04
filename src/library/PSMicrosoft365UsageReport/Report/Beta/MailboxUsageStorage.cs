using System.Runtime.Serialization;
using PSMicrosoft365UsageReport.Interface;

namespace PSMicrosoft365UsageReport.Report.Beta
{
    /// <summary>
    /// Class representing the response data for the MailboxUsageStorage report.
    /// Implements the <see cref="IReport"/> interface.
    /// </summary>
    public class MailboxUsageStorage : IReport
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MailboxUsageStorage"/> class.
        /// </summary>
        public MailboxUsageStorage()
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
        /// The total storage used in the organization in bytes, represented as a nullable long.
        /// </summary>
        public long? StorageUsedByte { get; set; }
    }
}
