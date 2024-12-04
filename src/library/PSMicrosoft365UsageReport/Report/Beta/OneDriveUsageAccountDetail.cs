using System.Runtime.Serialization;
using PSMicrosoft365UsageReport.Interface;

namespace PSMicrosoft365UsageReport.Report.Beta
{
    /// <summary>
    /// Class representing the response data for the OneDriveUsageAccountDetail report.
    /// Implements the <see cref="IReport"/> interface.
    /// </summary>
    public class OneDriveUsageAccountDetail : IReport
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
        /// The URL of the OneDrive site, represented as a nullable string.
        /// </summary>
        public string? SiteURL { get; set; }

        /// <summary>
        /// The principal name of the OneDrive site owner, represented as a nullable string.
        /// </summary>
        public string? OwnerPrincipalName { get; set; }

        /// <summary>
        /// The display name of the OneDrive site owner, represented as a nullable string.
        /// </summary>
        public string? OwnerDisplayName { get; set; }

        /// <summary>
        /// Indicates whether the OneDrive site is deleted, represented as a nullable boolean.
        /// </summary>
        public string? IsDeleted { get; set; }

        /// <summary>
        /// The date of the last activity on the OneDrive site, represented as a nullable string.
        /// </summary>
        public string? LastActivityDate { get; set; }

        /// <summary>
        /// The count of active files on the OneDrive site, represented as a nullable integer.
        /// </summary>
        public int? ActiveFileCount { get; set; }

        /// <summary>
        /// The total storage used by the OneDrive site in bytes, represented as a nullable long.
        /// </summary>
        public long? StorageUsedByte { get; set; }

        /// <summary>
        /// The total storage allocated to the OneDrive site in bytes, represented as a nullable long.
        /// </summary>
        public long? StorageAllocatedByte { get; set; }
    }
}
