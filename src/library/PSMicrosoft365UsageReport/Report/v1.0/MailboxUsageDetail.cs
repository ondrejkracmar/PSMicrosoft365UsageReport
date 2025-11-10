#nullable enable
using System.Runtime.Serialization;
using PSMicrosoft365UsageReport.Interface;

namespace PSMicrosoft365UsageReport.Report
{
    /// <summary>
    /// Represents detailed information about mailbox usage for users within an organization.
    /// This includes report refresh details, user-specific information, mailbox usage metrics, and quota limits.
    /// </summary>
    [DataContract]
    public class MailboxUsageDetail : IReport
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MailboxUsageDetail"/> class.
        /// </summary>
        public MailboxUsageDetail() { }

        /// <summary>
        /// The date when the report was last refreshed.
        /// </summary>
        [DataMember(Name = "ReportRefreshDate")]
        public string? ReportRefreshDate { get; set; }

        /// <summary>
        /// The period covered by the report.
        /// </summary>
        [DataMember(Name = "ReportPeriod")]
        public int? ReportPeriod { get; set; }

        /// <summary>
        /// The unique identifier (UPN) of the user within the organization.
        /// </summary>
        [DataMember(Name = "UserPrincipalName")]
        public string? UserPrincipalName { get; set; }

        /// <summary>
        /// The display name of the user.
        /// </summary>
        [DataMember(Name = "DisplayName")]
        public string? DisplayName { get; set; }

        /// <summary>
        /// Indicates whether the user account is deleted.
        /// </summary>
        [DataMember(Name = "IsDeleted")]
        public string? IsDeleted { get; set; }

        /// <summary>
        /// The date when the user account was deleted, if applicable.
        /// </summary>
        [DataMember(Name = "DeletedDate")]
        public string? DeletedDate { get; set; }

        /// <summary>
        /// The date when the mailbox was created.
        /// </summary>
        [DataMember(Name = "CreatedDate")]
        public string? CreatedDate { get; set; }

        /// <summary>
        /// The last date on which the user performed an activity.
        /// </summary>
        [DataMember(Name = "LastActivityDate")]
        public string? LastActivityDate { get; set; }

        /// <summary>
        /// The number of items in the mailbox.
        /// </summary>
        [DataMember(Name = "ItemCount")]
        public long ItemCount { get; set; }

        /// <summary>
        /// The total storage used by the mailbox, in bytes.
        /// </summary>
        [DataMember(Name = "StorageUsedByte")]
        public long StorageUsedByte { get; set; }

        /// <summary>
        /// The storage limit at which a warning is issued, in bytes.
        /// </summary>
        [DataMember(Name = "IssueWarningQuotaByte")]
        public long IssueWarningQuotaByte { get; set; }

        /// <summary>
        /// The storage limit at which sending is prohibited, in bytes.
        /// </summary>
        [DataMember(Name = "ProhibitSendQuotaByte")]
        public long ProhibitSendQuotaByte { get; set; }

        /// <summary>
        /// The storage limit at which both sending and receiving are prohibited, in bytes.
        /// </summary>
        [DataMember(Name = "ProhibitSendReceiveQuotaBytes")]
        public long ProhibitSendReceiveQuotaBytes { get; set; }

        /// <summary>
        /// The number of deleted items in the mailbox.
        /// </summary>
        [DataMember(Name = "DeletedItemCount")]
        public long DeletedItemCount { get; set; }

        /// <summary>
        /// The total size of deleted items, in bytes.
        /// </summary>
        [DataMember(Name = "DeletedItemSizeByte")]
        public long DeletedItemSizeByte { get; set; }

        /// <summary>
        /// The storage quota for deleted items, in bytes.
        /// </summary>
        [DataMember(Name = "DeletedItemQuotaByte")]
        public long DeletedItemQuotaByte { get; set; }

        /// <summary>
        /// Indicates whether the user has an archive mailbox.
        /// </summary>
        [DataMember(Name = "HasArchive")]
        public string? HasArchive { get; set; }
    }
}
