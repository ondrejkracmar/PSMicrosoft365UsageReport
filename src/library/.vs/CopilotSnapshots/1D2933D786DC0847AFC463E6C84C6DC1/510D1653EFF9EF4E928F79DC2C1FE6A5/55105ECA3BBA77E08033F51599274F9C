#nullable enable
using System.Runtime.Serialization;
using PSMicrosoft365UsageReport.Interface;

namespace PSMicrosoft365UsageReport.Report
{
    /// <summary>
    /// Represents detailed information about OneDrive activity by individual users within an organization.
    /// This includes details on the Report Refresh Date, reporting period, user activity counts, and file interaction statistics.
    /// </summary>
    [DataContract]
    public class OneDriveActivityUserDetail : IReport
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OneDriveActivityUserDetail"/> class.
        /// </summary>
        public OneDriveActivityUserDetail() { }

        /// <summary>
        /// The date when the report was last refreshed.
        /// </summary>
        [DataMember(Name = "Report Refresh Date")]
        public string? ReportRefreshDate { get; set; }

        /// <summary>
        /// The period covered by the report.
        /// </summary>
        [DataMember(Name = "Report Period")]
        public int? ReportPeriod { get; set; }

        /// <summary>
        /// The unique identifier (UPN) of the user within the organization.
        /// </summary>
        [DataMember(Name = "User Principal Name")]
        public string? UserPrincipalName { get; set; }

        /// <summary>
        /// Indicates if the user is deleted.
        /// </summary>
        [DataMember(Name = "Is Deleted")]
        public string? IsDeleted { get; set; }

        /// <summary>
        /// The date when the user was deleted, if applicable.
        /// </summary>
        [DataMember(Name = "Deleted Date")]
        public string? DeletedDate { get; set; }

        /// <summary>
        /// The last date on which the user performed an activity in OneDrive.
        /// </summary>
        [DataMember(Name = "Last Activity Date")]
        public string? LastActivityDate { get; set; }

        /// <summary>
        /// The count of files shared internally by the user.
        /// </summary>
        [DataMember(Name = "Shared Internally File Count")]
        public int? SharedInternallyFileCount { get; set; }

        /// <summary>
        /// The count of files synced by the user.
        /// </summary>
        [DataMember(Name = "Synced File Count")]
        public int? SyncedFileCount { get; set; }

        /// <summary>
        /// The count of files viewed or edited by the user.
        /// </summary>
        [DataMember(Name = "Viewed Or Edited File Count")]
        public int? ViewedOrEditedFileCount { get; set; }

        /// <summary>
        /// The count of files shared externally by the user.
        /// </summary>
        [DataMember(Name = "Shared Externally File Count")]
        public int? SharedExternallyFileCount { get; set; }

        /// <summary>
        /// The list of products assigned to the user.
        /// </summary>
        [DataMember(Name = "Assigned Products")]
        public string[]? AssignedProducts { get; set; }
    }
}
