#nullable enable
using System.Runtime.Serialization;
using PSMicrosoft365UsageReport.Interface;

namespace PSMicrosoft365UsageReport.Report.Beta
{
    /// <summary>
    /// Class representing the response data for the Office365GroupsActivityDetail report.
    /// Implements the <see cref="IReport"/> interface.
    /// </summary>
    public class Office365GroupsActivityDetail : IReport
    {
        /// <summary>
        /// The date when the report was last refreshed, represented as a nullable string.
        /// </summary>
        public string? ReportRefreshDate { get; set; }

        /// <summary>
        /// The period covered by the report in days, represented as a nullable integer.
        /// </summary>
        public int? ReportPeriod { get; set; }

        /// <summary>
        /// The unique identifier of the group, represented as a nullable string.
        /// </summary>
        public string? GroupId { get; set; }

        /// <summary>
        /// The display name of the group, represented as a nullable string.
        /// </summary>
        public string? GroupDisplayName { get; set; }

        /// <summary>
        /// Indicates whether the group is deleted, represented as a nullable boolean.
        /// </summary>
        public string? IsDeleted { get; set; }

        /// <summary>
        /// The principal name of the group owner, represented as a nullable string.
        /// </summary>
        public string? OwnerPrincipalName { get; set; }

        /// <summary>
        /// The date of the group's last activity, represented as a nullable string.
        /// </summary>
        public string? LastActivityDate { get; set; }

        /// <summary>
        /// The type of the group, represented as a nullable string.
        /// </summary>
        public string? GroupType { get; set; }

        /// <summary>
        /// The count of members in the group, represented as a nullable integer.
        /// </summary>
        public int? MemberCount { get; set; }

        /// <summary>
        /// The count of external members in the group, represented as a nullable integer.
        /// </summary>
        public int? ExternalMemberCount { get; set; }

        /// <summary>
        /// The count of emails received by the group in Exchange, represented as a nullable integer.
        /// </summary>
        public int? ExchangeReceivedEmailCount { get; set; }

        /// <summary>
        /// The count of active files in the group's SharePoint site, represented as a nullable integer.
        /// </summary>
        public int? SharePointActiveFileCount { get; set; }

        /// <summary>
        /// The count of messages posted in Yammer by the group, represented as a nullable integer.
        /// </summary>
        public int? YammerPostedMessageCount { get; set; }

        /// <summary>
        /// The count of messages read in Yammer by the group, represented as a nullable integer.
        /// </summary>
        public int? YammerReadMessageCount { get; set; }

        /// <summary>
        /// The count of messages liked in Yammer by the group, represented as a nullable integer.
        /// </summary>
        public int? YammerLikedMessageCount { get; set; }

        /// <summary>
        /// The total count of items in the group's Exchange mailbox, represented as a nullable integer.
        /// </summary>
        public int? ExchangeMailboxTotalItemCount { get; set; }

        /// <summary>
        /// The count of messages in Teams channels for the group, represented as a nullable integer.
        /// </summary>
        public int? TeamsChannelMessagesCount { get; set; }

        /// <summary>
        /// The count of meetings organized in Teams by the group, represented as a nullable integer.
        /// </summary>
        public int? TeamsMeetingsOrganizedCount { get; set; }

        /// <summary>
        /// The total storage used by the group's Exchange mailbox in bytes, represented as a nullable long.
        /// </summary>
        public long? ExchangeMailboxStorageUsedByte { get; set; }

        /// <summary>
        /// The total count of files in the group's SharePoint site, represented as a nullable integer.
        /// </summary>
        public int? SharePointTotalFileCount { get; set; }

        /// <summary>
        /// The total storage used by the group's SharePoint site in bytes, represented as a nullable long.
        /// </summary>
        public long? SharePointSiteStorageUsedByte { get; set; }
    }
}
