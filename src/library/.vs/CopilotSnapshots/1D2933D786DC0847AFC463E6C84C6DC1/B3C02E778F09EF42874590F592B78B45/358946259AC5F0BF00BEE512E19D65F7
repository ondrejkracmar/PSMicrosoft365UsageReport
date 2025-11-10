#nullable enable
using System.Runtime.Serialization;
using PSMicrosoft365UsageReport.Interface;

namespace PSMicrosoft365UsageReport.Report.Beta
{
    /// <summary>
    /// Class representing the response data for the MailboxUsageDetail report.
    /// Implements the <see cref="IReport"/> interface.
    /// </summary>
    [DataContract]
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
        [DataMember(Name = "ReportRefreshDate")]
        public string? ReportRefreshDate { get; set; }

        /// <summary>
        /// The period covered by the report in days, represented as a nullable string.
        /// </summary>
        [DataMember(Name = "ReportPeriod")]
        public int? ReportPeriod { get; set; }

        /// <summary>
        /// The user principal name (UPN) of the user, represented as a nullable string.
        /// </summary>
        [DataMember(Name = "UserPrincipalName")]
        public string? UserPrincipalName { get; set; }

        /// <summary>
        /// The display name of the user, represented as a nullable string.
        /// </summary>
        [DataMember(Name = "DisplayName")]
        public string? DisplayName { get; set; }

        /// <summary>
        /// Indicates whether the user is deleted, represented as a nullable boolean.
        /// </summary>
        [DataMember(Name = "IsDeleted")]
        public string? IsDeleted { get; set; }

        /// <summary>
        /// The date the user was deleted, represented as a nullable string.
        /// </summary>
        [DataMember(Name = "DeletedDate")]
        public string? DeletedDate { get; set; }

        /// <summary>
        /// The date the mailbox was created, represented as a nullable string.
        /// </summary>
        [DataMember(Name = "CreatedDate")]
        public string? CreatedDate { get; set; }

        /// <summary>
        /// The date of the user's last activity, represented as a nullable string.
        /// </summary>
        [DataMember(Name = "LastActivityDate")]
        public string? LastActivityDate { get; set; }

        /// <summary>
        /// The total item count in the mailbox, represented as a nullable integer.
        /// </summary>
        [DataMember(Name = "ItemCount")]
        public int? ItemCount { get; set; }

        /// <summary>
        /// The total storage used by the mailbox in bytes, represented as a nullable long.
        /// </summary>
        [DataMember(Name = "StorageUsedInBytes")]
        public long? StorageUsedInBytes { get; set; }

        /// <summary>
        /// The warning quota in bytes before issuing a warning, represented as a nullable long.
        /// </summary>
        [DataMember(Name = "IssueWarningQuotaInBytes")]
        public long? IssueWarningQuotaInBytes { get; set; }

        /// <summary>
        /// The quota in bytes before sending is prohibited, represented as a nullable long.
        /// </summary>
        [DataMember(Name = "ProhibitSendQuotaInBytes")]
        public long? ProhibitSendQuotaInBytes { get; set; }

        /// <summary>
        /// The quota in bytes before sending and receiving are prohibited, represented as a nullable long.
        /// </summary>
        [DataMember(Name = "ProhibitSendReceiveQuotaInBytes")]
        public long? ProhibitSendReceiveQuotaInBytes { get; set; }

        /// <summary>
        /// The count of deleted items in the mailbox, represented as a nullable integer.
        /// </summary>
        [DataMember(Name = "DeletedItemCount")]
        public int? DeletedItemCount { get; set; }

        /// <summary>
        /// The total size of deleted items in bytes, represented as a nullable long.
        /// </summary>
        [DataMember(Name = "DeletedItemSizeInBytes")]
        public long? DeletedItemSizeInBytes { get; set; }

        /// <summary>
        /// The quota in bytes for deleted items, represented as a nullable long.
        /// </summary>
        [DataMember(Name = "DeletedItemQuota")]
        public long? DeletedItemQuota { get; set; }

        /// <summary>
        /// Indicates whether the user has an archive mailbox, represented as a nullable boolean.
        /// </summary>
        [DataMember(Name = "HasArchive")]
        public string? HasArchive { get; set; }
    }
}
