using System.Runtime.Serialization;
using PSMicrosoft365UsageReport.Interface;

namespace PSMicrosoft365UsageReport.Report.Beta
{
    /// <summary>
    /// Class representing the response data for the TeamsTeamActivityCounts report.
    /// Implements the <see cref="IReport"/> interface.
    /// </summary>
    public class TeamsTeamActivityCounts : IReport
    {
        /// <summary>
        /// The date when the report was last refreshed, represented as a nullable string.
        /// </summary>
        public string? ReportRefreshDate { get; set; }

        /// <summary>
        /// The date of the report, represented as a nullable string.
        /// </summary>
        public string? ReportDate { get; set; }

        /// <summary>
        /// The period covered by the report in days, represented as a nullable integer.
        /// </summary>
        public int? ReportPeriod { get; set; }

        /// <summary>
        /// The number of active users in Microsoft Teams, represented as a nullable integer.
        /// </summary>
        public int? ActiveUsers { get; set; }

        /// <summary>
        /// The number of active channels in Microsoft Teams, represented as a nullable integer.
        /// </summary>
        public int? ActiveChannels { get; set; }

        /// <summary>
        /// The number of guests in Microsoft Teams, represented as a nullable integer.
        /// </summary>
        public int? Guests { get; set; }

        /// <summary>
        /// The number of reactions in Microsoft Teams, represented as a nullable integer.
        /// </summary>
        public int? Reactions { get; set; }

        /// <summary>
        /// The number of meetings organized in Microsoft Teams, represented as a nullable integer.
        /// </summary>
        public int? MeetingsOrganized { get; set; }

        /// <summary>
        /// The number of post messages in Microsoft Teams, represented as a nullable integer.
        /// </summary>
        public int? PostMessages { get; set; }

        /// <summary>
        /// The number of channel messages in Microsoft Teams, represented as a nullable integer.
        /// </summary>
        public int? ChannelMessages { get; set; }

        /// <summary>
        /// The number of active shared channels in Microsoft Teams, represented as a nullable integer.
        /// </summary>
        public int? ActiveSharedChannels { get; set; }

        /// <summary>
        /// The number of active external users in Microsoft Teams, represented as a nullable integer.
        /// </summary>
        public int? ActiveExternalUsers { get; set; }

        /// <summary>
        /// The number of reply messages in Microsoft Teams, represented as a nullable integer.
        /// </summary>
        public int? ReplyMessages { get; set; }

        /// <summary>
        /// The number of urgent messages in Microsoft Teams, represented as a nullable integer.
        /// </summary>
        public int? UrgentMessages { get; set; }

        /// <summary>
        /// The number of mentions in Microsoft Teams, represented as a nullable integer.
        /// </summary>
        public int? Mentions { get; set; }
    }
}
