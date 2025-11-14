#nullable enable
using System.Runtime.Serialization;
using PSMicrosoft365UsageReport.Interface;

namespace PSMicrosoft365UsageReport.Report.Beta
{
    /// <summary>
    /// Class representing the response data for the Microsoft365AppPlatformUserCounts report.
    /// Implements the <see cref="IReport"/> interface.
    /// </summary>
    public class Microsoft365AppPlatformUserCounts : IReport
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Microsoft365AppPlatformUserCounts"/> class.
        /// </summary>
        public Microsoft365AppPlatformUserCounts()
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
        /// The count of active users on the Windows platform, represented as a nullable integer.
        /// </summary>
        public int? Windows { get; set; }

        /// <summary>
        /// The count of active users on the Mac platform, represented as a nullable integer.
        /// </summary>
        public int? Mac { get; set; }

        /// <summary>
        /// The count of active users on the Mobile platform, represented as a nullable integer.
        /// </summary>
        public int? Mobile { get; set; }

        /// <summary>
        /// The count of active users on the Web platform, represented as a nullable integer.
        /// </summary>
        public int? Web { get; set; }
    }
}
