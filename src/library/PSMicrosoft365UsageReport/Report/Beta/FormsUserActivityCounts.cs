#nullable enable
using System.Runtime.Serialization;
using PSMicrosoft365UsageReport.Interface;

namespace PSMicrosoft365UsageReport.Report.Beta
{
    /// <summary>
    /// Class representing the response data for the FormsUserActivityCounts report.
    /// Implements the <see cref="IReport"/> interface.
    /// </summary>
    public class FormsUserActivityCounts : IReport
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FormsUserActivityCounts"/> class.
        /// </summary>
        public FormsUserActivityCounts()
        {
        }

        /// <summary>
        /// The date when the report was last refreshed, represented as a nullable string.
        /// </summary>
        public string? ReportRefreshDate { get; set; }

        /// <summary>
        /// The period covered by the report in days, represented as a nullable integer.
        /// </summary>
        public int? ReportPeriod { get; set; }

        /// <summary>
        /// The activity count for forms, represented as a nullable integer.
        /// </summary>
        public int? Forms { get; set; }

        /// <summary>
        /// The count of authenticated responses, represented as a nullable integer.
        /// </summary>
        public int? AuthenticatedResponses { get; set; }

        /// <summary>
        /// The count of anonymous responses, represented as a nullable integer.
        /// </summary>
        public int? AnonymousResponses { get; set; }

        /// <summary>
        /// The date of the last activity, represented as a nullable string.
        /// </summary>
        public string? LastActivityDate { get; set; }
    }
}
