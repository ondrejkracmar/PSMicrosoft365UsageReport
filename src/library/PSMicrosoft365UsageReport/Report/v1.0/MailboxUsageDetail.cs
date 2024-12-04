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
        [DataMember(Name = "Report Refresh Date")]
        public string? ReportRefreshDate { get; set; }

        /// <summary>
        /// The period covered by the report.
        /// </summary>
        [DataMember(Name = "Report Period")]
        public int? ReportPeriod { get; set; }

        /// <summary>
        /// The unique identifier (UPN) of the user within the organization.
        /// </summary>
        [DataMember(Name = "User Principal Name")]
        public string? UserPrincipalName { get; set; }

        /// <summary>
        /// The display name of the user.
        /// </summary>
        [DataMember(Name = "Display Name")]
        public string? DisplayName { get; set; }

        /// <summary>
        /// Indicates whether the user account is deleted.
        /// </summary>
        [DataMember(Name = "Is Deleted")]
        public string? IsDeleted { get; set; }

        /// <summary>
        /// The date when the user account was deleted, if applicable.
        /// </summary>
        [DataMember(Name = "Deleted Date")]
        public string? DeletedDate { get; set; }

        /// <summary>
        /// The date when the mailbox was created.
        /// </summary>
        [DataMember(Name = "Created Date")]
        public string? CreatedDate { get; set; }

        /// <summary>
        /// The last date on which the user performed an activity.
        /// </summary>
        [DataMember(Name = "Last Activity Date")]
        public string? LastActivityDate { get; set; }

        /// <summary>
        /// The number of items in the mailbox.
        /// </summary>
        [DataMember(Name = "Item Count")]
        public long ItemCount { get; set; }

        /// <summary>
        /// The total storage used by the mailbox, in bytes.
        /// </summary>
        [DataMember(Name = "Storage Used (Byte)")]
        public long StorageUsedByte { get; set; }

        /// <summary>
        /// The storage limit at which a warning is issued, in bytes.
        /// </summary>
        [DataMember(Name = "Issue Warning Quota (Byte)")]
        public long IssueWarningQuotaByte { get; set; }

        /// <summary>
        /// The storage limit at which sending is prohibited, in bytes.
        /// </summary>
        [DataMember(Name = "Prohibit Send Quota (Byte)")]
        public long ProhibitSendQuotaByte { get; set; }

        /// <summary>
        /// The storage limit at which both sending and receiving are prohibited, in bytes.
        /// </summary>
        [DataMember(Name = "Prohibit Send/Receive Quota (Byte)")]
        public long ProhibitSendReceiveQuotaByte { get; set; }

        /// <summary>
        /// The number of deleted items in the mailbox.
        /// </summary>
        [DataMember(Name = "Deleted Item Count")]
        public long DeletedItemCount { get; set; }

        /// <summary>
        /// The total size of deleted items, in bytes.
        /// </summary>
        [DataMember(Name = "Deleted Item Size (Byte)")]
        public long DeletedItemSizeByte { get; set; }

        /// <summary>
        /// The storage quota for deleted items, in bytes.
        /// </summary>
        [DataMember(Name = "Deleted Item Quota (Byte)")]
        public long DeletedItemQuotaByte { get; set; }

        /// <summary>
        /// Indicates whether the user has an archive mailbox.
        /// </summary>
        [DataMember(Name = "Has Archive")]
        public string? HasArchive { get; set; }
    }
}
