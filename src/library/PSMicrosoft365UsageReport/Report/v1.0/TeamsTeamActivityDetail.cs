using System.Runtime.Serialization;
using PSMicrosoft365UsageReport.Interface;

namespace PSMicrosoft365UsageReport.Report
{
    /// <summary>
    /// Represents detailed information about Microsoft Teams activity by individual teams.
    /// This includes details on the Report Refresh Date, reporting period, team activity statistics, and user engagement metrics.
    /// </summary>
    [DataContract]
    public class TeamsTeamActivityDetail : IReport
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TeamsTeamActivityDetail"/> class.
        /// </summary>
        public TeamsTeamActivityDetail() { }

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
        /// The unique identifier for the team.
        /// </summary>
        [DataMember(Name = "Team Id")]
        public string? TeamId { get; set; }

        /// <summary>
        /// The name of the team.
        /// </summary>
        [DataMember(Name = "Team Name")]
        public string? TeamName { get; set; }

        /// <summary>
        /// The type of the team.
        /// </summary>
        [DataMember(Name = "Team Type")]
        public string? TeamType { get; set; }

        /// <summary>
        /// The last date on which there was activity in the team.
        /// </summary>
        [DataMember(Name = "Last Activity Date")]
        public string? LastActivityDate { get; set; }

        /// <summary>
        /// The number of active users in the team.
        /// </summary>
        [DataMember(Name = "Active Users")]
        public int? ActiveUsers { get; set; }

        /// <summary>
        /// The number of active channels in the team.
        /// </summary>
        [DataMember(Name = "Active Channels")]
        public int? ActiveChannels { get; set; }

        /// <summary>
        /// The number of guest users in the team.
        /// </summary>
        [DataMember(Name = "Guests")]
        public int? Guests { get; set; }

        /// <summary>
        /// The number of reactions in the team.
        /// </summary>
        [DataMember(Name = "Reactions")]
        public int? Reactions { get; set; }

        /// <summary>
        /// The number of meetings organized in the team.
        /// </summary>
        [DataMember(Name = "Meetings Organized")]
        public int? MeetingsOrganized { get; set; }

        /// <summary>
        /// The number of post messages in the team.
        /// </summary>
        [DataMember(Name = "Post Messages")]
        public int? PostMessages { get; set; }

        /// <summary>
        /// The number of reply messages in the team.
        /// </summary>
        [DataMember(Name = "Reply Messages")]
        public int? ReplyMessages { get; set; }

        /// <summary>
        /// The number of channel messages in the team.
        /// </summary>
        [DataMember(Name = "Channel Messages")]
        public int? ChannelMessages { get; set; }

        /// <summary>
        /// The number of urgent messages in the team.
        /// </summary>
        [DataMember(Name = "Urgent Messages")]
        public int? UrgentMessages { get; set; }

        /// <summary>
        /// The number of mentions in the team.
        /// </summary>
        [DataMember(Name = "Mentions")]
        public int? Mentions { get; set; }

        /// <summary>
        /// The number of active shared channels in the team.
        /// </summary>
        [DataMember(Name = "Active Shared Channels")]
        public int? ActiveSharedChannels { get; set; }

        /// <summary>
        /// The number of active external users in the team.
        /// </summary>
        [DataMember(Name = "Active External Users")]
        public int? ActiveExternalUsers { get; set; }
    }
}
