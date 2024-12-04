using System.Runtime.Serialization;
using PSMicrosoft365UsageReport.Interface;

namespace PSMicrosoft365UsageReport.Report.Beta
{
    /// <summary>
    /// Class representing the response data for the TeamsDeviceUsageUserCounts report.
    /// Implements the <see cref="IReport"/> interface.
    /// </summary>
    public class TeamsDeviceUsageUserCounts : IReport
    {
        /// <summary>
        /// The date when the report was last refreshed, represented as a nullable string.
        /// </summary>
        public string? ReportRefreshDate { get; set; }

        /// <summary>
        /// The period covered by the report in days, represented as a nullable integer.
        /// </summary>
        public int? ReportPeriod { get; set; }

        /// <summary>
        /// The date of the report, represented as a nullable string.
        /// </summary>
        public string? ReportDate { get; set; }

        /// <summary>
        /// The number of daily unique users using Microsoft Teams on web devices, represented as a nullable integer.
        /// </summary>
        public int? Web { get; set; }

        /// <summary>
        /// The number of daily unique users using Microsoft Teams on Windows Phone devices, represented as a nullable integer.
        /// </summary>
        public int? WindowsPhone { get; set; }

        /// <summary>
        /// The number of daily unique users using Microsoft Teams on Android Phone devices, represented as a nullable integer.
        /// </summary>
        public int? AndroidPhone { get; set; }

        /// <summary>
        /// The number of daily unique users using Microsoft Teams on iOS devices, represented as a nullable integer.
        /// </summary>
        public int? iOS { get; set; }

        /// <summary>
        /// The number of daily unique users using Microsoft Teams on Mac devices, represented as a nullable integer.
        /// </summary>
        public int? Mac { get; set; }

        /// <summary>
        /// The number of daily unique users using Microsoft Teams on Windows devices, represented as a nullable integer.
        /// </summary>
        public int? Windows { get; set; }

        /// <summary>
        /// The number of daily unique users using Microsoft Teams on Chrome OS devices, represented as a nullable integer.
        /// </summary>
        public int? ChromeOS { get; set; }

        /// <summary>
        /// The number of daily unique users using Microsoft Teams on Linux devices, represented as a nullable integer.
        /// </summary>
        public int? Linux { get; set; }
    }
}
