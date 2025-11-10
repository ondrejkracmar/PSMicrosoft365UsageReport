#nullable enable
using System.Runtime.Serialization;
using PSMicrosoft365UsageReport.Interface;

namespace PSMicrosoft365UsageReport.Report
{
    /// <summary>
    /// Represents the number of Microsoft Teams users by activity type.
    /// This includes details on the Report Refresh Date, reporting date, and counts of user activities such as team chat messages, private chat messages, calls, and meetings.
    /// </summary>
    [DataContract]
    public class TeamsUserActivityUserCounts : IReport
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TeamsUserActivityUserCounts"/> class.
        /// </summary>
        public TeamsUserActivityUserCounts() { }

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
        /// The count of team chat messages in Microsoft Teams.
        /// </summary>
        [DataMember(Name = "TeamChatMessages")]
        public int? TeamChatMessages { get; set; }

        /// <summary>
        /// The count of private chat messages in Microsoft Teams.
        /// </summary>
        [DataMember(Name = "PrivateChatMessages")]
        public int? PrivateChatMessages { get; set; }

        /// <summary>
        /// The count of calls in Microsoft Teams.
        /// </summary>
        [DataMember(Name = "Calls")]
        public int? Calls { get; set; }

        /// <summary>
        /// The count of meetings in Microsoft Teams.
        /// </summary>
        [DataMember(Name = "Meetings")]
        public int? Meetings { get; set; }

        /// <summary>
        /// The count of other actions performed in Microsoft Teams.
        /// </summary>
        [DataMember(Name = "OtherActions")]
        public int? OtherActions { get; set; }
    }
}
