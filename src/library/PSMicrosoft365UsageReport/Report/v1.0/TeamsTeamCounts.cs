#nullable enable
using System.Runtime.Serialization;
using PSMicrosoft365UsageReport.Interface;

namespace PSMicrosoft365UsageReport.Report
{
    /// <summary>
    /// Represents the number of teams of a particular type in an instance of Microsoft Teams.
    /// This includes details on the Report Refresh Date, reporting date, and counts of public and private teams, as well as their active statuses.
    /// </summary>
    [DataContract]
    public class TeamsTeamCounts : IReport
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TeamsTeamCounts"/> class.
        /// </summary>
        public TeamsTeamCounts() { }

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
        /// The date associated with the report.
        /// </summary>
        [DataMember(Name = "ReportDate")]
        public string? ReportDate { get; set; }

        /// <summary>
        /// The count of public teams in Microsoft Teams.
        /// </summary>
        [DataMember(Name = "PublicTeams")]
        public int? PublicTeams { get; set; }

        /// <summary>
        /// The count of active public teams in Microsoft Teams.
        /// </summary>
        [DataMember(Name = "ActivePublicTeams")]
        public int? ActivePublicTeams { get; set; }

        /// <summary>
        /// The count of private teams in Microsoft Teams.
        /// </summary>
        [DataMember(Name = "PrivateTeams")]
        public int? PrivateTeams { get; set; }

        /// <summary>
        /// The count of active private teams in Microsoft Teams.
        /// </summary>
        [DataMember(Name = "ActivePrivateTeams")]
        public int? ActivePrivateTeams { get; set; }
    }
}
