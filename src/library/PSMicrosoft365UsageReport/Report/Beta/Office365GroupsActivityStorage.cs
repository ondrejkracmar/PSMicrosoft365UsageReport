#nullable enable
using System.Runtime.Serialization;
using PSMicrosoft365UsageReport.Interface;

namespace PSMicrosoft365UsageReport.Report.Beta
{
    /// <summary>
    /// Class representing the response data for the Office365GroupsActivityStorage report.
    /// Implements the <see cref="IReport"/> interface.
    /// </summary>
    public class Office365GroupsActivityStorage : IReport
    {
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
        /// The total mailbox storage used across all group mailboxes, represented as a nullable long.
        /// </summary>
        public long? MailboxStorageUsedByte { get; set; }

        /// <summary>
        /// The total site storage used across all group sites, represented as a nullable long.
        /// </summary>
        public long? SiteStorageUsedByte { get; set; }
    }
}
