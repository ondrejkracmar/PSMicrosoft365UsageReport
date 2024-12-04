using System.Runtime.Serialization;
using PSMicrosoft365UsageReport.Interface;

namespace PSMicrosoft365UsageReport.Report.Beta
{
    /// <summary>
    /// Class representing the response data for the TeamsUserActivityDistributionTotalUserCounts report.
    /// Implements the <see cref="IReport"/> interface.
    /// </summary>
    public class TeamsUserActivityDistributionTotalUserCounts : IReport
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
    }
}
