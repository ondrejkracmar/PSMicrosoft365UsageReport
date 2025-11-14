#nullable enable
using System.Runtime.Serialization;
using PSMicrosoft365UsageReport.Interface;

namespace PSMicrosoft365UsageReport.Report.Beta
{
    /// <summary>
    /// Class representing the response data for the TeamsTeamActivityDetail report.
    /// Implements the <see cref="IReport"/> interface.
    /// </summary>
    public class TeamsTeamActivityDetail : IReport
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
        /// The unique identifier for the team, represented as a nullable string.
        /// </summary>
        public string? TeamId { get; set; }

        /// <summary>
        /// The name of the team, represented as a nullable string.
        /// </summary>
        public string? TeamName { get; set; }

        /// <summary>
        /// The type of team (e.g., private, public), represented as a nullable string.
        /// </summary>
        public string? TeamType { get; set; }

        /// <summary>
        /// The date of the last activity on the team, represented as a nullable string.
        /// </summary>
        public string? LastActivityDate { get; set; }

        /// <summary>
        /// The number of active users in the team, represented as a nullable integer.
        /// </summary>
        public int? ActiveUsers { get; set; }

        /// <summary>
        /// The number of active channels in the team, represented as a nullable integer.
        /// </summary>
        public int? ActiveChannels { get; set; }

        /// <summary>
        /// The number of guests in the team, represented as a nullable integer.
        /// </summary>
        public int? Guests { get; set; }

        /// <summary>
        /// The number of reactions in the team, represented as a nullable integer.
        /// </summary>
        public int? Reactions { get; set; }

        /// <summary>
        /// The number of meetings organized in the team, represented as a nullable integer.
        /// </summary>
        public int? MeetingsOrganized { get; set; }

        /// <summary>
        /// The number of post messages in the team, represented as a nullable integer.
        /// </summary>
        public int? PostMessages { get; set; }

        /// <summary>
        /// The number of reply messages in the team, represented as a nullable integer.
        /// </summary>
        public int? ReplyMessages { get; set; }

        /// <summary>
        /// The number of channel messages in the team, represented as a nullable integer.
        /// </summary>
        public int? ChannelMessages { get; set; }

        /// <summary>
        /// The number of urgent messages in the team, represented as a nullable integer.
        /// </summary>
        public int? UrgentMessages { get; set; }

        /// <summary>
        /// The number of mentions in the team, represented as a nullable integer.
        /// </summary>
        public int? Mentions { get; set; }

        /// <summary>
        /// The number of active shared channels in the team, represented as a nullable integer.
        /// </summary>
        public int? ActiveSharedChannels { get; set; }

        /// <summary>
        /// The number of active external users in the team, represented as a nullable integer.
        /// </summary>
        public int? ActiveExternalUsers { get; set; }
    }
}
