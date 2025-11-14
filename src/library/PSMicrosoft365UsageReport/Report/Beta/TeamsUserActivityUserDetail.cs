#nullable enable
using System.Runtime.Serialization;
using PSMicrosoft365UsageReport.Interface;

namespace PSMicrosoft365UsageReport.Report.Beta
{
    /// <summary>
    /// Class representing the response data for the TeamsUserActivityUserDetail report.
    /// Implements the <see cref="IReport"/> interface.
    /// </summary>
    public class TeamsUserActivityUserDetail : IReport
    {
        /// <summary>
        /// The date when the report was last refreshed, represented as a nullable string.
        /// </summary>
        public string? ReportRefreshDate { get; set; }

        /// <summary>
        /// The period covered by the report, represented as a nullable integer.
        /// </summary>
        public int? ReportPeriod { get; set; }

        /// <summary>
        /// The user ID, represented as a nullable string.
        /// </summary>
        public string? UserId { get; set; }

        /// <summary>
        /// The user principal name, represented as a nullable string.
        /// </summary>
        public string? UserPrincipalName { get; set; }

        /// <summary>
        /// Indicates if the user is deleted, represented as a nullable boolean.
        /// </summary>
        public string? IsDeleted { get; set; }

        /// <summary>
        /// The date the user was deleted, represented as a nullable string.
        /// </summary>
        public string? DeletedDate { get; set; }

        /// <summary>
        /// The last activity date of the user, represented as a nullable string.
        /// </summary>
        public string? LastActivityDate { get; set; }

        /// <summary>
        /// The shared channel tenant display names, represented as a nullable string.
        /// </summary>
        public string? SharedChannelTenantDisplayNames { get; set; }

        /// <summary>
        /// The number of team chat messages by the user, represented as a nullable integer.
        /// </summary>
        public int? TeamChatMessageCount { get; set; }

        /// <summary>
        /// The number of private chat messages by the user, represented as a nullable integer.
        /// </summary>
        public int? PrivateChatMessageCount { get; set; }

        /// <summary>
        /// The number of calls by the user, represented as a nullable integer.
        /// </summary>
        public int? CallCount { get; set; }

        /// <summary>
        /// The number of meetings attended by the user, represented as a nullable integer.
        /// </summary>
        public int? MeetingCount { get; set; }

        /// <summary>
        /// The number of post messages by the user, represented as a nullable integer.
        /// </summary>
        public int? PostMessages { get; set; }

        /// <summary>
        /// The number of reply messages by the user, represented as a nullable integer.
        /// </summary>
        public int? ReplyMessages { get; set; }

        /// <summary>
        /// The number of urgent messages by the user, represented as a nullable integer.
        /// </summary>
        public int? UrgentMessages { get; set; }

        /// <summary>
        /// The number of meetings organized by the user, represented as a nullable integer.
        /// </summary>
        public int? MeetingsOrganizedCount { get; set; }

        /// <summary>
        /// The number of meetings attended by the user, represented as a nullable integer.
        /// </summary>
        public int? MeetingsAttendedCount { get; set; }

        /// <summary>
        /// The number of ad hoc meetings organized by the user, represented as a nullable integer.
        /// </summary>
        public int? AdHocMeetingsOrganizedCount { get; set; }

        /// <summary>
        /// The number of ad hoc meetings attended by the user, represented as a nullable integer.
        /// </summary>
        public int? AdHocMeetingsAttendedCount { get; set; }

        /// <summary>
        /// The number of scheduled one-time meetings organized by the user, represented as a nullable integer.
        /// </summary>
        public int? ScheduledOneTimeMeetingsOrganizedCount { get; set; }

        /// <summary>
        /// The number of scheduled one-time meetings attended by the user, represented as a nullable integer.
        /// </summary>
        public int? ScheduledOneTimeMeetingsAttendedCount { get; set; }

        /// <summary>
        /// The number of scheduled recurring meetings organized by the user, represented as a nullable integer.
        /// </summary>
        public int? ScheduledRecurringMeetingsOrganizedCount { get; set; }

        /// <summary>
        /// The number of scheduled recurring meetings attended by the user, represented as a nullable integer.
        /// </summary>
        public int? ScheduledRecurringMeetingsAttendedCount { get; set; }

        /// <summary>
        /// The audio duration in the report period, represented as a nullable double.
        /// </summary>
        public string? AudioDuration { get; set; }

        /// <summary>
        /// The video duration in the report period, represented as a nullable double.
        /// </summary>
        public string? VideoDuration { get; set; }

        /// <summary>
        /// The screen share duration in the report period, represented as a nullable double.
        /// </summary>
        public string? ScreenShareDuration { get; set; }

        /// <summary>
        /// The audio duration in seconds, represented as a nullable double.
        /// </summary>
        public double? AudioDurationInSeconds { get; set; }

        /// <summary>
        /// The video duration in seconds, represented as a nullable double.
        /// </summary>
        public double? VideoDurationInSeconds { get; set; }

        /// <summary>
        /// The screen share duration in seconds, represented as a nullable double.
        /// </summary>
        public double? ScreenShareDurationInSeconds { get; set; }

        /// <summary>
        /// Indicates if there is any other action, represented as a nullable boolean.
        /// </summary>
        public string? HasOtherAction { get; set; }

        /// <summary>
        /// Indicates if the user is licensed, represented as a nullable boolean.
        /// </summary>
        public string? IsLicensed { get; set; }
    }
}
