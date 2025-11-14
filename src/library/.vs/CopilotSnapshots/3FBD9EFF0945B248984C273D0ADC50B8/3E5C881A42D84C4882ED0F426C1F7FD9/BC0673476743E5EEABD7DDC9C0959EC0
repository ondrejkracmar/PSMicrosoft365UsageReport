#nullable enable
using System.Runtime.Serialization;
using PSMicrosoft365UsageReport.Interface;

namespace PSMicrosoft365UsageReport.Report.Beta
{
    /// <summary>
    /// Class representing the response data for the MailboxUsageDetail report.
    /// Implements the <see cref="IReport"/> interface.
    /// </summary>
    public class MailboxUsageDetail : IReport
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MailboxUsageDetail"/> class.
        /// </summary>
        public MailboxUsageDetail()
        {
        }

        /// <summary>
        /// The date when the report was last refreshed, represented as a nullable string.
        /// </summary>
        public string? ReportRefreshDate { get; set; }

        /// <summary>
        /// The period covered by the report in days, represented as a nullable string.
        /// </summary>
        public int? ReportPeriod { get; set; }

        /// <summary>
        /// The user principal name (UPN) of the user, represented as a nullable string.
        /// </summary>
        public string? UserPrincipalName { get; set; }

        /// <summary>
        /// The display name of the user, represented as a nullable string.
        /// </summary>
        public string? DisplayName { get; set; }

        /// <summary>
        /// Indicates whether the user is deleted, represented as a nullable boolean.
        /// </summary>
        public string? IsDeleted { get; set; }

        /// <summary>
        /// The date the user was deleted, represented as a nullable string.
        /// </summary>
        public string? DeletedDate { get; set; }

        /// <summary>
        /// The date the mailbox was created, represented as a nullable string.
        /// </summary>
        public string? CreatedDate { get; set; }

        /// <summary>
        /// The date of the user's last activity, represented as a nullable string.
        /// </summary>
        public string? LastActivityDate { get; set; }

        /// <summary>
        /// The total item count in the mailbox, represented as a nullable integer.
        /// </summary>
        public int? ItemCount { get; set; }

        /// <summary>
        /// The total storage used by the mailbox in bytes, represented as a nullable long.
        /// </summary>
        public long? StorageUsedByte { get; set; }

        /// <summary>
        /// The warning quota in bytes before issuing a warning, represented as a nullable long.
        /// </summary>
        public long? IssueWarningQuotaByte { get; set; }

        /// <summary>
        /// The quota in bytes before sending is prohibited, represented as a nullable long.
        /// </summary>
        public long? ProhibitSendQuotaByte { get; set; }

        /// <summary>
        /// The quota in bytes before sending and receiving are prohibited, represented as a nullable long.
        /// </summary>
        public long? ProhibitSendReceiveQuotaByte { get; set; }

        /// <summary>
        /// The count of deleted items in the mailbox, represented as a nullable integer.
        /// </summary>
        public int? DeletedItemCount { get; set; }

        /// <summary>
        /// The total size of deleted items in bytes, represented as a nullable long.
        /// </summary>
        public long? DeletedItemSizeByte { get; set; }

        /// <summary>
        /// The quota in bytes for deleted items, represented as a nullable long.
        /// </summary>
        public long? DeletedItemQuotaByte { get; set; }

        /// <summary>
        /// Indicates whether the user has an archive mailbox, represented as a nullable boolean.
        /// </summary>
        public string? HasArchive { get; set; }
    }
}
