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
        [DataMember(Name = "Report Refresh Date")]
        public string? ReportRefreshDate { get; set; }

        /// <summary>
        /// The period covered by the report.
        /// </summary>
        [DataMember(Name = "Report Period")]
        public int? ReportPeriod { get; set; }

        /// <summary>
        /// The date associated with the report.
        /// </summary>
        [DataMember(Name = "Report Date")]
        public string? ReportDate { get; set; }

        /// <summary>
        /// The count of public teams in Microsoft Teams.
        /// </summary>
        [DataMember(Name = "Public Teams")]
        public int? PublicTeams { get; set; }

        /// <summary>
        /// The count of active public teams in Microsoft Teams.
        /// </summary>
        [DataMember(Name = "Active Public Teams")]
        public int? ActivePublicTeams { get; set; }

        /// <summary>
        /// The count of private teams in Microsoft Teams.
        /// </summary>
        [DataMember(Name = "Private Teams")]
        public int? PrivateTeams { get; set; }

        /// <summary>
        /// The count of active private teams in Microsoft Teams.
        /// </summary>
        [DataMember(Name = "Active Private Teams")]
        public int? ActivePrivateTeams { get; set; }
    }
}
