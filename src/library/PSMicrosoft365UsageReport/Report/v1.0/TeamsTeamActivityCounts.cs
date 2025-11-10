#nullable enable
using System.Runtime.Serialization;
using PSMicrosoft365UsageReport.Interface;

namespace PSMicrosoft365UsageReport.Report
{
    /// <summary>
    /// Represents the number of team activities across Microsoft Teams.
    /// This includes details on the Report Refresh Date, reporting period, and counts of various activities such as active users, channels, meetings, messages, and reactions.
    /// </summary>
    public class TeamsTeamActivityCounts : IReport
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TeamsTeamActivityCounts"/> class.
        /// </summary>
        public TeamsTeamActivityCounts() { }

        /// <summary>
        /// The date when the report was last refreshed.
        /// </summary>
        [DataMember(Name = "ReportRefreshDate")]
        public string? ReportRefreshDate { get; set; }

        /// <summary>
        /// The date associated with the report.
        /// </summary>
        [DataMember(Name = "ReportDate")]
        public string? ReportDate { get; set; }

        /// <summary>
        /// The period covered by the report.
        /// </summary>
        [DataMember(Name = "ReportPeriod")]
        public int? ReportPeriod { get; set; }

        /// <summary>
        /// The number of active users in Microsoft Teams.
        /// </summary>
        [DataMember(Name = "ActiveUsers")]
        public int? ActiveUsers { get; set; }

        /// <summary>
        /// The number of active channels in Microsoft Teams.
        /// </summary>
        [DataMember(Name = "ActiveChannels")]
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
        [DataMember(Name = "MeetingsOrganized")]
        public int? MeetingsOrganized { get; set; }

        /// <summary>
        /// The number of post messages in Microsoft Teams.
        /// </summary>
        [DataMember(Name = "PostMessages")]
        public int? PostMessages { get; set; }

        /// <summary>
        /// The number of channel messages in Microsoft Teams.
        /// </summary>
        [DataMember(Name = "ChannelMessages")]
        public int? ChannelMessages { get; set; }

        /// <summary>
        /// The number of active shared channels in Microsoft Teams.
        /// </summary>
        [DataMember(Name = "ActiveSharedChannels")]
        public int? ActiveSharedChannels { get; set; }

        /// <summary>
        /// The number of active external users in Microsoft Teams.
        /// </summary>
        [DataMember(Name = "ActiveExternalUsers")]
        public int? ActiveExternalUsers { get; set; }

        /// <summary>
        /// The number of reply messages in Microsoft Teams.
        /// </summary>
        [DataMember(Name = "ReplyMessages")]
        public int? ReplyMessages { get; set; }

        /// <summary>
        /// The number of urgent messages in Microsoft Teams.
        /// </summary>
        [DataMember(Name = "UrgentMessages")]
        public int? UrgentMessages { get; set; }

        /// <summary>
        /// The number of mentions in Microsoft Teams.
        /// </summary>
        [DataMember(Name = "Mentions")]
        public int? Mentions { get; set; }
    }
}
