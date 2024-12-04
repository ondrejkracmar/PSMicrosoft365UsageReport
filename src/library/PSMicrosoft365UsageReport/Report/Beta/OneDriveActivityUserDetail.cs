using System.Runtime.Serialization;
using PSMicrosoft365UsageReport.Interface;

namespace PSMicrosoft365UsageReport.Report.Beta
{
    /// <summary>
    /// Class representing the response data for the OneDriveActivityUserDetail report.
    /// Implements the <see cref="IReport"/> interface.
    /// </summary>
    public class OneDriveActivityUserDetail : IReport
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
        /// The user principal name (UPN) of the user, represented as a nullable string.
        /// </summary>
        public string? UserPrincipalName { get; set; }

        /// <summary>
        /// Indicates whether the user is deleted, represented as a nullable boolean.
        /// </summary>
        public string? IsDeleted { get; set; }

        /// <summary>
        /// The date the user was deleted, represented as a nullable string.
        /// </summary>
        public string? DeletedDate { get; set; }

        /// <summary>
        /// The date of the user's last activity, represented as a nullable string.
        /// </summary>
        public string? LastActivityDate { get; set; }

        /// <summary>
        /// The count of files shared internally by the user, represented as a nullable integer.
        /// </summary>
        public int? SharedInternallyFileCount { get; set; }

        /// <summary>
        /// The count of files synced by the user, represented as a nullable integer.
        /// </summary>
        public int? SyncedFileCount { get; set; }

        /// <summary>
        /// The count of files viewed or edited by the user, represented as a nullable integer.
        /// </summary>
        public int? ViewedOrEditedFileCount { get; set; }

        /// <summary>
        /// The count of files shared externally by the user, represented as a nullable integer.
        /// </summary>
        public int? SharedExternallyFileCount { get; set; }

        /// <summary>
        /// The products assigned to the user, represented as a nullable string.
        /// </summary>
        public string[]? AssignedProducts { get; set; }
    }
}
