#nullable enable
using System.Runtime.Serialization;
using PSMicrosoft365UsageReport.Interface;

namespace PSMicrosoft365UsageReport.Report
{
    /// <summary>
    /// Represents detailed information about Microsoft Teams user activity by individual users.
    /// This includes details on the Report Refresh Date, reporting period, activity counts, and duration for various activity types.
    /// </summary>
    [DataContract]
    public class TeamsUserActivityUserDetail :IReport
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TeamsUserActivityUserDetail"/> class.
        /// </summary>
        public TeamsUserActivityUserDetail() { }

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
        /// The unique identifier of the user.
        /// </summary>
        [DataMember(Name = "User Id")]
        public string? UserId { get; set; }

        /// <summary>
        /// The principal name of the user.
        /// </summary>
        [DataMember(Name = "User Principal Name")]
        public string? UserPrincipalName { get; set; }

        /// <summary>
        /// Indicates if the user is deleted.
        /// </summary>
        [DataMember(Name = "Is Deleted")]
        public string? IsDeleted { get; set; }

        /// <summary>
        /// The date when the user was deleted, if applicable.
        /// </summary>
        [DataMember(Name = "Deleted Date")]
        public string? DeletedDate { get; set; }

        /// <summary>
        /// The last date of activity for the user in Microsoft Teams.
        /// </summary>
        [DataMember(Name = "Last Activity Date")]
        public string? LastActivityDate { get; set; }

        /// <summary>
        /// Names of tenants with which the shared channel is associated.
        /// </summary>
        [DataMember(Name = "Shared Channel Tenant Display Names")]
        public string? SharedChannelTenantDisplayNames { get; set; }

        /// <summary>
        /// The count of team chat messages sent by the user.
        /// </summary>
        [DataMember(Name = "Team Chat Message Count")]
        public int? TeamChatMessageCount { get; set; }

        /// <summary>
        /// The count of private chat messages sent by the user.
        /// </summary>
        [DataMember(Name = "Private Chat Message Count")]
        public int? PrivateChatMessageCount { get; set; }

        /// <summary>
        /// The count of calls made by the user.
        /// </summary>
        [DataMember(Name = "Call Count")]
        public int? CallCount { get; set; }

        /// <summary>
        /// The count of meetings attended by the user.
        /// </summary>
        [DataMember(Name = "Meeting Count")]
        public int? MeetingCount { get; set; }

        /// <summary>
        /// The count of post messages sent by the user.
        /// </summary>
        [DataMember(Name = "Post Messages")]
        public int? PostMessages { get; set; }

        /// <summary>
        /// The count of reply messages sent by the user.
        /// </summary>
        [DataMember(Name = "Reply Messages")]
        public int? ReplyMessages { get; set; }

        /// <summary>
        /// The count of urgent messages sent by the user.
        /// </summary>
        [DataMember(Name = "Urgent Messages")]
        public int? UrgentMessages { get; set; }

        /// <summary>
        /// The count of meetings organized by the user.
        /// </summary>
        [DataMember(Name = "Meetings Organized Count")]
        public int? MeetingsOrganizedCount { get; set; }

        /// <summary>
        /// The count of meetings attended by the user.
        /// </summary>
        [DataMember(Name = "Meetings Attended Count")]
        public int? MeetingsAttendedCount { get; set; }

        /// <summary>
        /// The count of ad hoc meetings organized by the user.
        /// </summary>
        [DataMember(Name = "Ad Hoc Meetings Organized Count")]
        public int? AdHocMeetingsOrganizedCount { get; set; }

        /// <summary>
        /// The count of ad hoc meetings attended by the user.
        /// </summary>
        [DataMember(Name = "Ad Hoc Meetings Attended Count")]
        public int? AdHocMeetingsAttendedCount { get; set; }

        /// <summary>
        /// The count of scheduled one-time meetings organized by the user.
        /// </summary>
        [DataMember(Name = "Scheduled One-time Meetings Organized Count")]
        public int? ScheduledOneTimeMeetingsOrganizedCount { get; set; }

        /// <summary>
        /// The count of scheduled one-time meetings attended by the user.
        /// </summary>
        [DataMember(Name = "Scheduled One-time Meetings Attended Count")]
        public int? ScheduledOneTimeMeetingsAttendedCount { get; set; }

        /// <summary>
        /// The count of scheduled recurring meetings organized by the user.
        /// </summary>
        [DataMember(Name = "Scheduled Recurring Meetings Organized Count")]
        public int? ScheduledRecurringMeetingsOrganizedCount { get; set; }

        /// <summary>
        /// The count of scheduled recurring meetings attended by the user.
        /// </summary>
        [DataMember(Name = "Scheduled Recurring Meetings Attended Count")]
        public int? ScheduledRecurringMeetingsAttendedCount { get; set; }

        /// <summary>
        /// The duration of audio usage in Microsoft Teams, in SO 8601 duration.
        /// </summary>
        [DataMember(Name = "Audio Duration")]
        public string? AudioDuration { get; set; }

        /// <summary>
        /// The duration of video usage in Microsoft Teams, in SO 8601 duration
        /// </summary>
        [DataMember(Name = "Video Duration")]        
        public string? VideoDuration { get; set; }

        /// <summary>
        /// The duration of screen sharing in Microsoft Teams, in SO 8601 duration.
        /// </summary>
        [DataMember(Name = "Screen Share Duration")]
        public int? ScreenShareDuration { get; set; }

        /// <summary>
        /// The duration of audio usage in seconds.
        /// </summary>
        [DataMember(Name = "Audio Duration In Seconds")]
        public int? AudioDurationInSeconds { get; set; }

        /// <summary>
        /// The duration of video usage in seconds.
        /// </summary>
        [DataMember(Name = "Video Duration In Seconds")]
        public int? VideoDurationInSeconds { get; set; }

        /// <summary>
        /// The duration of screen sharing in seconds.
        /// </summary>
        [DataMember(Name = "Screen Share Duration In Seconds")]
        public int? ScreenShareDurationInSeconds { get; set; }

        /// <summary>
        /// Indicates if the user has other actions recorded in Microsoft Teams.
        /// </summary>
        [DataMember(Name = "Has Other Action")]
        public string? HasOtherAction { get; set; }

        /// <summary>
        /// Indicates if the user is licensed for Microsoft Teams.
        /// </summary>
        [DataMember(Name = "Is Licensed")]
        public string? IsLicensed { get; set; }
    }
}
