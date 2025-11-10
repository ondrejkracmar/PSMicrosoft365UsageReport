#nullable enable
using System.Runtime.Serialization;
using PSMicrosoft365UsageReport.Interface;

namespace PSMicrosoft365UsageReport.Report
{
    /// <summary>
    /// Represents detailed information about Microsoft 365 group activity by individual group within an organization.
    /// This includes report refresh details, group-specific information, activity counts, and storage usage across various services like Exchange, SharePoint, and Yammer.
    /// </summary>
    [DataContract]
    public class Office365GroupsActivityDetail : IReport
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Office365GroupsActivityDetail"/> class.
        /// </summary>
        public Office365GroupsActivityDetail() { }

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
        /// The unique identifier of the group.
        /// </summary>
        [DataMember(Name = "GroupId")]
        public string? GroupId { get; set; }

        /// <summary>
        /// The display name of the group.
        /// </summary>
        [DataMember(Name = "GroupDisplayName")]
        public string? GroupDisplayName { get; set; }

        /// <summary>
        /// Indicates if the group is deleted.
        /// </summary>
        [DataMember(Name = "IsDeleted")]
        public string? IsDeleted { get; set; }

        /// <summary>
        /// The principal name of the group owner.
        /// </summary>
        [DataMember(Name = "OwnerPrincipalName")]
        public string? OwnerPrincipalName { get; set; }

        /// <summary>
        /// The date of the last activity in the group.
        /// </summary>
        [DataMember(Name = "LastActivityDate")]
        public string? LastActivityDate { get; set; }

        /// <summary>
        /// The type of the group (e.g., Office 365, Security).
        /// </summary>
        [DataMember(Name = "GroupType")]
        public string? GroupType { get; set; }

        /// <summary>
        /// The count of members in the group.
        /// </summary>
        [DataMember(Name = "MemberCount")]
        public int? MemberCount { get; set; }

        /// <summary>
        /// The count of external members in the group.
        /// </summary>
        [DataMember(Name = "ExternalMemberCount")]
        public int? ExternalMemberCount { get; set; }

        /// <summary>
        /// The count of emails received by the group in Exchange.
        /// </summary>
        [DataMember(Name = "ExchangeReceivedEmailCount")]
        public int? ExchangeReceivedEmailCount { get; set; }

        /// <summary>
        /// The count of active files in the group's SharePoint site.
        /// </summary>
        [DataMember(Name = "SharePointActiveFileCount")]
        public int? SharePointActiveFileCount { get; set; }

        /// <summary>
        /// The count of messages posted in the group's Yammer feed.
        /// </summary>
        [DataMember(Name = "YammerPostedMessageCount")]
        public int? YammerPostedMessageCount { get; set; }

        /// <summary>
        /// The count of messages read in the group's Yammer feed.
        /// </summary>
        [DataMember(Name = "YammerReadMessageCount")]
        public int? YammerReadMessageCount { get; set; }

        /// <summary>
        /// The count of messages liked in the group's Yammer feed.
        /// </summary>
        [DataMember(Name = "YammerLikedMessageCount")]
        public int? YammerLikedMessageCount { get; set; }

        /// <summary>
        /// The total item count in the group's Exchange mailbox.
        /// </summary>
        [DataMember(Name = "ExchangeMailboxTotalItemCount")]
        public int? ExchangeMailboxTotalItemCount { get; set; }

        /// <summary>
        /// The storage used by the group's Exchange mailbox in bytes.
        /// </summary>
        [DataMember(Name = "ExchangeMailboxStorageUsedByte")]
        public long ExchangeMailboxStorageUsedByte { get; set; }

        /// <summary>
        /// The total file count in the group's SharePoint site.
        /// </summary>
        [DataMember(Name = "SharePointTotalFileCount")]
        public int? SharePointTotalFileCount { get; set; }

        /// <summary>
        /// The storage used by the group's SharePoint site in bytes.
        /// </summary>
        [DataMember(Name = "SharePointSiteStorageUsedByte")]
        public long SharePointSiteStorageUsedByte { get; set; }
    }
}
