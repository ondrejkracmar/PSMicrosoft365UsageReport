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
        [DataMember(Name = "ReportRefreshDate")]
        public string? ReportRefreshDate { get; set; }

        /// <summary>
        /// The period covered by the report.
        /// </summary>
        [DataMember(Name = "ReportPeriod")]
        public int? ReportPeriod { get; set; }

        /// <summary>
        /// The unique identifier of the user.
        /// </summary>
        [DataMember(Name = "UserId")]
        public string? UserId { get; set; }

        /// <summary>
        /// The principal name of the user.
        /// </summary>
        [DataMember(Name = "UserPrincipalName")]
        public string? UserPrincipalName { get; set; }

        /// <summary>
        /// Indicates if the user is deleted.
        /// </summary>
        [DataMember(Name = "IsDeleted")]
        public string? IsDeleted { get; set; }

        /// <summary>
        /// The date when the user was deleted, if applicable.
        /// </summary>
        [DataMember(Name = "DeletedDate")]
        public string? DeletedDate { get; set; }

        /// <summary>
        /// The last date of activity for the user in Microsoft Teams.
        /// </summary>
        [DataMember(Name = "LastActivityDate")]
        public string? LastActivityDate { get; set; }

        /// <summary>
        /// Names of tenants with which the shared channel is associated.
        /// </summary>
        [DataMember(Name = "SharedChannelTenantDisplayNames")]
        public string? SharedChannelTenantDisplayNames { get; set; }

        /// <summary>
        /// The count of team chat messages sent by the user.
        /// </summary>
        [DataMember(Name = "TeamChatMessageCount")]
        public int? TeamChatMessageCount { get; set; }

        /// <summary>
        /// The count of private chat messages sent by the user.
        /// </summary>
        [DataMember(Name = "PrivateChatMessageCount")]
        public int? PrivateChatMessageCount { get; set; }

        /// <summary>
        /// The count of calls made by the user.
        /// </summary>
        [DataMember(Name = "CallCount")]
        public int? CallCount { get; set; }

        /// <summary>
        /// The count of meetings attended by the user.
        /// </summary>
        [DataMember(Name = "MeetingCount")]
        public int? MeetingCount { get; set; }

        /// <summary>
        /// The count of post messages sent by the user.
        /// </summary>
        [DataMember(Name = "PostMessages")]
        public int? PostMessages { get; set; }

        /// <summary>
        /// The count of reply messages sent by the user.
        /// </summary>
        [DataMember(Name = "ReplyMessages")]
        public int? ReplyMessages { get; set; }

        /// <summary>
        /// The count of urgent messages sent by the user.
        /// </summary>
        [DataMember(Name = "UrgentMessages")]
        public int? UrgentMessages { get; set; }

        /// <summary>
        /// The count of meetings organized by the user.
        /// </summary>
        [DataMember(Name = "MeetingsOrganizedCount")]
        public int? MeetingsOrganizedCount { get; set; }

        /// <summary>
        /// The count of meetings attended by the user.
        /// </summary>
        [DataMember(Name = "MeetingsAttendedCount")]
        public int? MeetingsAttendedCount { get; set; }

        /// <summary>
        /// The count of ad hoc meetings organized by the user.
        /// </summary>
        [DataMember(Name = "AdHocMeetingsOrganizedCount")]
        public int? AdHocMeetingsOrganizedCount { get; set; }

        /// <summary>
        /// The count of ad hoc meetings attended by the user.
        /// </summary>
        [DataMember(Name = "AdHocMeetingsAttendedCount")]
        public int? AdHocMeetingsAttendedCount { get; set; }

        /// <summary>
        /// The count of scheduled one-time meetings organized by the user.
        /// </summary>
        [DataMember(Name = "ScheduledOneTimeMeetingsOrganizedCount")]
        public int? ScheduledOneTimeMeetingsOrganizedCount { get; set; }

        /// <summary>
        /// The count of scheduled one-time meetings attended by the user.
        /// </summary>
        [DataMember(Name = "ScheduledOneTimeMeetingsAttendedCount")]
        public int? ScheduledOneTimeMeetingsAttendedCount { get; set; }

        /// <summary>
        /// The count of scheduled recurring meetings organized by the user.
        /// </summary>
        [DataMember(Name = "ScheduledRecurringMeetingsOrganizedCount")]
        public int? ScheduledRecurringMeetingsOrganizedCount { get; set; }

        /// <summary>
        /// The count of scheduled recurring meetings attended by the user.
        /// </summary>
        [DataMember(Name = "ScheduledRecurringMeetingsAttendedCount")]
        public int? ScheduledRecurringMeetingsAttendedCount { get; set; }

        /// <summary>
        /// The duration of audio usage in Microsoft Teams, in SO8601 duration.
        /// </summary>
        [DataMember(Name = "AudioDuration")]
        public string? AudioDuration { get; set; }

        /// <summary>
        /// The duration of video usage in Microsoft Teams, in SO8601 duration
        /// </summary>
        [DataMember(Name = "VideoDuration")]
        public string? VideoDuration { get; set; }

        /// <summary>
        /// The duration of screen sharing in Microsoft Teams, in SO8601 duration.
        /// </summary>
        [DataMember(Name = "ScreenShareDuration")]
        public string? ScreenShareDuration { get; set; }

        /// <summary>
        /// The duration of audio usage in seconds.
        /// </summary>
        [DataMember(Name = "AudioDurationInSeconds")]
        public int? AudioDurationInSeconds { get; set; }

        /// <summary>
        /// The duration of video usage in seconds.
        /// </summary>
        [DataMember(Name = "VideoDurationInSeconds")]
        public int? VideoDurationInSeconds { get; set; }

        /// <summary>
        /// The duration of screen sharing in seconds.
        /// </summary>
        [DataMember(Name = "ScreenShareDurationInSeconds")]
        public int? ScreenShareDurationInSeconds { get; set; }

        /// <summary>
        /// Indicates if the user has other actions recorded in Microsoft Teams.
        /// </summary>
        [DataMember(Name = "HasOtherAction")]
        public string? HasOtherAction { get; set; }

        /// <summary>
        /// Indicates if the user is licensed for Microsoft Teams.
        /// </summary>
        [DataMember(Name = "IsLicensed")]
        public string? IsLicensed { get; set; }
    }
}
