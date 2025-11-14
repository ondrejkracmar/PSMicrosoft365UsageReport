#nullable enable
using System.Runtime.Serialization;
using PSMicrosoft365UsageReport.Interface;

namespace PSMicrosoft365UsageReport.Report.Beta
{
    /// <summary>
    /// Class representing the response data for the Office365GroupsActivityCounts report.
    /// Implements the <see cref="IReport"/> interface.
    /// </summary>
    public class Office365GroupsActivityCounts : IReport
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Office365GroupsActivityCounts"/> class.
        /// </summary>
        public Office365GroupsActivityCounts()
        {
        }

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
        /// The number of emails received in Exchange by groups, represented as a nullable integer.
        /// </summary>
        public int? ExchangeEmailsReceived { get; set; }

        /// <summary>
        /// The number of messages posted in Yammer by groups, represented as a nullable integer.
        /// </summary>
        public int? YammerMessagesPosted { get; set; }

        /// <summary>
        /// The number of messages read in Yammer by groups, represented as a nullable integer.
        /// </summary>
        public int? YammerMessagesRead { get; set; }

        /// <summary>
        /// The number of messages liked in Yammer by groups, represented as a nullable integer.
        /// </summary>
        public int? YammerMessagesLiked { get; set; }

        /// <summary>
        /// The number of channel messages in Teams by groups, represented as a nullable integer.
        /// </summary>
        public int? TeamsChannelMessages { get; set; }

        /// <summary>
        /// The number of meetings organized in Teams by groups, represented as a nullable integer.
        /// </summary>
        public int? TeamsMeetingsOrganized { get; set; }
    }
}
