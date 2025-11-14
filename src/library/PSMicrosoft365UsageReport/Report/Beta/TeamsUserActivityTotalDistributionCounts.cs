#nullable enable
using System.Runtime.Serialization;
using PSMicrosoft365UsageReport.Interface;

namespace PSMicrosoft365UsageReport.Report.Beta
{
    /// <summary>
    /// Class representing the response data for the TeamsUserActivityTotalDistributionCounts report.
    /// Implements the <see cref="IReport"/> interface.
    /// </summary>
    public class TeamsUserActivityTotalDistributionCounts : IReport
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
        /// The number of team chat messages in the report period, represented as a nullable integer.
        /// </summary>
        public int? TeamChatMessages { get; set; }

        /// <summary>
        /// The number of post messages in the report period, represented as a nullable integer.
        /// </summary>
        public int? PostMessages { get; set; }

        /// <summary>
        /// The number of reply messages in the report period, represented as a nullable integer.
        /// </summary>
        public int? ReplyMessages { get; set; }

        /// <summary>
        /// The number of private chat messages in the report period, represented as a nullable integer.
        /// </summary>
        public int? PrivateChatMessages { get; set; }

        /// <summary>
        /// The number of calls in the report period, represented as a nullable integer.
        /// </summary>
        public int? Calls { get; set; }

        /// <summary>
        /// The number of meetings in the report period, represented as a nullable integer.
        /// </summary>
        public int? Meetings { get; set; }

        /// <summary>
        /// The number of team chat messages in the report period, represented as a nullable integer.
        /// </summary>
        public int? TeamChatMessageCount { get; set; }

        /// <summary>
        /// The total audio duration in the report period, represented as a nullable double.
        /// </summary>
        public double? AudioDuration { get; set; }

        /// <summary>
        /// The total video duration in the report period, represented as a nullable double.
        /// </summary>
        public double? VideoDuration { get; set; }

        /// <summary>
        /// The total screen share duration in the report period, represented as a nullable double.
        /// </summary>
        public double? ScreenShareDuration { get; set; }

        /// <summary>
        /// The number of meetings organized in the report period, represented as a nullable integer.
        /// </summary>
        public int? MeetingsOrganized { get; set; }

        /// <summary>
        /// The number of meetings attended in the report period, represented as a nullable integer.
        /// </summary>
        public int? MeetingsAttended { get; set; }
    }
}
