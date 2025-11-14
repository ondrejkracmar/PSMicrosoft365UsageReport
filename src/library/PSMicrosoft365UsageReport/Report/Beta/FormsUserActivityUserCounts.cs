#nullable enable
using System.Runtime.Serialization;
using PSMicrosoft365UsageReport.Interface;

namespace PSMicrosoft365UsageReport.Report.Beta
{
    /// <summary>
    /// Class representing the response data for the FormsUserActivityUserCounts report.
    /// Implements the <see cref="IReport"/> interface.
    /// </summary>
    public class FormsUserActivityUserCounts : IReport
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FormsUserActivityUserCounts"/> class.
        /// </summary>
        public FormsUserActivityUserCounts()
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
        /// The user principal name (UPN) of the user, represented as a nullable string.
        /// </summary>
        public string? UserPrincipalName { get; set; }

        /// <summary>
        /// The count of forms created by the user, represented as a nullable integer.
        /// </summary>
        public int? CreatedCount { get; set; }

        /// <summary>
        /// The count of forms responded to by the user, represented as a nullable integer.
        /// </summary>
        public int? RespondedCount { get; set; }

        /// <summary>
        /// The date of the user's last activity, represented as a nullable string.
        /// </summary>
        public string? LastActivityDate { get; set; }
    }
}
