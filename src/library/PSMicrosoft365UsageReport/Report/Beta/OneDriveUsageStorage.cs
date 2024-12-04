using System.Runtime.Serialization;
using PSMicrosoft365UsageReport.Interface;

namespace PSMicrosoft365UsageReport.Report.Beta
{
    /// <summary>
    /// Class representing the response data for the OneDriveUsageStorage report.
    /// Implements the <see cref="IReport"/> interface.
    /// </summary>
    public class OneDriveUsageStorage : IReport
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
        /// The type of site (e.g., personal or business), represented as a nullable string.
        /// </summary>
        public string? SiteType { get; set; }

        /// <summary>
        /// The total storage used in OneDrive for Business, represented as a nullable long.
        /// </summary>
        public long? StorageUsedByte { get; set; }
    }
}
