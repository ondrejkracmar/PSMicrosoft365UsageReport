#nullable enable
using System.Runtime.Serialization;
using PSMicrosoft365UsageReport.Interface;

namespace PSMicrosoft365UsageReport.Report
{
    /// <summary>
    /// Represents the number of team activities across Microsoft Teams.
    /// This includes details on the Report Refresh Date, reporting period, and counts of various activities such as active users, channels, meetings, messages, and reactions.
    /// </summary>
    [DataContract]
    public class TeamsTeamActivityCounts : IReport
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TeamsTeamActivityCounts"/> class.
        /// </summary>
        public TeamsTeamActivityCounts() { }

        /// <summary>
        /// The date when the report was last refreshed.
        /// </summary>
        [DataMember(Name = "Report Refresh Date")]
        public string? ReportRefreshDate { get; set; }

        /// <summary>
        /// The date associated with the report.
        /// </summary>
        [DataMember(Name = "Report Date")]
        public string? ReportDate { get; set; }

        /// <summary>
        /// The period covered by the report.
        /// </summary>
        [DataMember(Name = "Report Period")]
        public int? ReportPeriod { get; set; }

        /// <summary>
        /// The number of active users in Microsoft Teams.
        /// </summary>
        [DataMember(Name = "Active Users")]
        public int? ActiveUsers { get; set; }

        /// <summary>
        /// The number of active channels in Microsoft Teams.
        /// </summary>
        [DataMember(Name = "Active Channels")]
        public int? ActiveChannels { get; set; }

        /// <summary>
        /// The number of guest users in Microsoft Teams.
        /// </summary>
        [DataMember(Name = "Guests")]
        public int? Guests { get; set; }

        /// <summary>
        /// The number of reactions in Microsoft Teams.
        /// </summary>
        [DataMember(Name = "Reactions")]
        public int? Reactions { get; set; }

        /// <summary>
        /// The number of meetings organized in Microsoft Teams.
        /// </summary>
        [DataMember(Name = "Meetings Organized")]
        public int? MeetingsOrganized { get; set; }

        /// <summary>
        /// The number of post messages in Microsoft Teams.
        /// </summary>
        [DataMember(Name = "Post Messages")]
        public int? PostMessages { get; set; }

        /// <summary>
        /// The number of channel messages in Microsoft Teams.
        /// </summary>
        [DataMember(Name = "Channel Messages")]
        public int? ChannelMessages { get; set; }

        /// <summary>
        /// The number of active shared channels in Microsoft Teams.
        /// </summary>
        [DataMember(Name = "Active Shared Channels")]
        public int? ActiveSharedChannels { get; set; }

        /// <summary>
        /// The number of active external users in Microsoft Teams.
        /// </summary>
        [DataMember(Name = "Active External Users")]
        public int? ActiveExternalUsers { get; set; }

        /// <summary>
        /// The number of reply messages in Microsoft Teams.
        /// </summary>
        [DataMember(Name = "Reply Messages")]
        public int? ReplyMessages { get; set; }

        /// <summary>
        /// The number of urgent messages in Microsoft Teams.
        /// </summary>
        [DataMember(Name = "Urgent Messages")]
        public int? UrgentMessages { get; set; }

        /// <summary>
        /// The number of mentions in Microsoft Teams.
        /// </summary>
        [DataMember(Name = "Mentions")]
        public int? Mentions { get; set; }
    }
}
