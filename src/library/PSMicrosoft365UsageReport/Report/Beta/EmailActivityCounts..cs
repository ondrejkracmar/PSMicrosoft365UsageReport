#nullable enable
using System.Runtime.Serialization;
using PSMicrosoft365UsageReport.Interface;

namespace PSMicrosoft365UsageReport.Report.Beta
{
    /// <summary>
    /// Class representing the response data for the EmailActivityCounts report.
    /// Implements the <see cref="IReport"/> interface.
    /// </summary>
    public class EmailActivityCounts : IReport
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EmailActivityCounts"/> class.
        /// </summary>
        public EmailActivityCounts()
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
        /// The number of emails sent, represented as a nullable integer.
        /// </summary>
        public int? Send { get; set; }

        /// <summary>
        /// The number of emails received, represented as a nullable integer.
        /// </summary>
        public int? Receive { get; set; }

        /// <summary>
        /// The number of emails read, represented as a nullable integer.
        /// </summary>
        public int? Read { get; set; }

        /// <summary>
        /// The number of meetings created, represented as a nullable integer.
        /// </summary>
        public int? MeetingCreated { get; set; }

        /// <summary>
        /// The number of meetings interacted with, represented as a nullable integer.
        /// </summary>
        public int? MeetingInteracted { get; set; }
    }
}
