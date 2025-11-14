#nullable enable
using System.Runtime.Serialization;
using PSMicrosoft365UsageReport.Interface;

namespace PSMicrosoft365UsageReport.Report.Beta
{
    /// <summary>
    /// Class representing the response data for the TeamsTeamCounts report.
    /// Implements the <see cref="IReport"/> interface.
    /// </summary>
    public class TeamsTeamCounts : IReport
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
        /// The date of the report, represented as a nullable string.
        /// </summary>
        public string? ReportDate { get; set; }

        /// <summary>
        /// The number of public teams in Microsoft Teams, represented as a nullable integer.
        /// </summary>
        public int? PublicTeams { get; set; }

        /// <summary>
        /// The number of active public teams in Microsoft Teams, represented as a nullable integer.
        /// </summary>
        public int? ActivePublicTeams { get; set; }

        /// <summary>
        /// The number of private teams in Microsoft Teams, represented as a nullable integer.
        /// </summary>
        public int? PrivateTeams { get; set; }

        /// <summary>
        /// The number of active private teams in Microsoft Teams, represented as a nullable integer.
        /// </summary>
        public int? ActivePrivateTeams { get; set; }
    }
}
