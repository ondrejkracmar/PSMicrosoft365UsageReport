using System.Runtime.Serialization;
using PSMicrosoft365UsageReport.Interface;

namespace PSMicrosoft365UsageReport.Report
{
    /// <summary>
    /// Represents the number of Microsoft Teams users by activity type.
    /// This includes details on the Report Refresh Date, reporting date, and counts of user activities such as messages, calls, meetings, and duration of audio, video, and screen sharing.
    /// </summary>
    [DataContract]
    public class TeamsUserActivityCounts : IReport
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TeamsUserActivityCounts"/> class.
        /// </summary>
        public TeamsUserActivityCounts() { }

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
        /// The count of team chat messages in Microsoft Teams.
        /// </summary>
        [DataMember(Name = "Team Chat Messages")]
        public int? TeamChatMessages { get; set; }

        /// <summary>
        /// The count of post messages in Microsoft Teams.
        /// </summary>
        [DataMember(Name = "Post Messages")]
        public int? PostMessages { get; set; }

        /// <summary>
        /// The count of reply messages in Microsoft Teams.
        /// </summary>
        [DataMember(Name = "Reply Messages")]
        public int? ReplyMessages { get; set; }

        /// <summary>
        /// The count of private chat messages in Microsoft Teams.
        /// </summary>
        [DataMember(Name = "Private Chat Messages")]
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
        /// The duration of audio usage in Microsoft Teams, in SO 8601 duration.
        /// </summary>
        [DataMember(Name = "Audio Duration")]
        public string? AudioDuration { get; set; }

        /// <summary>
        /// The duration of video usage in Microsoft Teams, in SO 8601 duration.
        /// </summary>
        [DataMember(Name = "Video Duration")]
        public string? VideoDuration { get; set; }

        /// <summary>
        /// The duration of screen sharing in Microsoft Teams, in SO 8601 duration.
        /// </summary>
        [DataMember(Name = "Screen Share Duration")]
        public string? ScreenShareDuration { get; set; }

        /// <summary>
        /// The number of meetings organized by users in Microsoft Teams.
        /// </summary>
        [DataMember(Name = "Meetings Organized")]
        public int? MeetingsOrganized { get; set; }

        /// <summary>
        /// The number of meetings attended by users in Microsoft Teams.
        /// </summary>
        [DataMember(Name = "Meetings Attended")]
        public int? MeetingsAttended { get; set; }
    }
}
