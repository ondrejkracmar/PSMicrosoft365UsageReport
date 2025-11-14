#nullable enable
using System.Runtime.Serialization;
using PSMicrosoft365UsageReport.Interface;

namespace PSMicrosoft365UsageReport.Report.Beta
{
    /// <summary>
    /// Class representing the response data for the TeamsTeamActivityDistributionCounts report.
    /// Implements the <see cref="IReport"/> interface.
    /// </summary>
    public class TeamsTeamActivityDistributionCounts : IReport
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
        /// The number of active users in the report period, represented as a nullable integer.
        /// </summary>
        public int? ActiveUsers { get; set; }

        /// <summary>
        /// The number of active channels in the report period, represented as a nullable integer.
        /// </summary>
        public int? ActiveChannels { get; set; }

        /// <summary>
        /// The number of guests in the report period, represented as a nullable integer.
        /// </summary>
        public int? Guests { get; set; }

        /// <summary>
        /// The number of reactions in the report period, represented as a nullable integer.
        /// </summary>
        public int? Reactions { get; set; }

        /// <summary>
        /// The number of meetings organized in the report period, represented as a nullable integer.
        /// </summary>
        public int? MeetingsOrganized { get; set; }

        /// <summary>
        /// The number of post messages in the report period, represented as a nullable integer.
        /// </summary>
        public int? PostMessages { get; set; }

        /// <summary>
        /// The number of channel messages in the report period, represented as a nullable integer.
        /// </summary>
        public int? ChannelMessages { get; set; }

        /// <summary>
        /// The number of active shared channels in the report period, represented as a nullable integer.
        /// </summary>
        public int? ActiveSharedChannels { get; set; }

        /// <summary>
        /// The number of active external users in the report period, represented as a nullable integer.
        /// </summary>
        public int? ActiveExternalUsers { get; set; }

        /// <summary>
        /// The number of reply messages in the report period, represented as a nullable integer.
        /// </summary>
        public int? ReplyMessages { get; set; }

        /// <summary>
        /// The number of urgent messages in the report period, represented as a nullable integer.
        /// </summary>
        public int? UrgentMessages { get; set; }

        /// <summary>
        /// The number of mentions in the report period, represented as a nullable integer.
        /// </summary>
        public int? Mentions { get; set; }
    }
}
