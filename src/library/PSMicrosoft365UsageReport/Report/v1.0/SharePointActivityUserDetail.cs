#nullable enable
using System.Runtime.Serialization;
using PSMicrosoft365UsageReport.Interface;

namespace PSMicrosoft365UsageReport.Report
{
    /// <summary>
    /// Represents detailed information about SharePoint activity by individual users.
    /// This includes details on the Report Refresh Date, reporting period, user activity counts, and file interaction statistics.
    /// </summary>
    [DataContract]
    public class SharePointActivityUserDetail : IReport
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SharePointActivityUserDetail"/> class.
        /// </summary>
        public SharePointActivityUserDetail() { }

        /// <summary>
        /// The date when the report was last refreshed.
        /// </summary>
        [DataMember(Name = "ReportRefreshDate")]
        public string? ReportRefreshDate { get; set; }

        /// <summary>
        /// The period covered by the report.
        /// </summary>
        [DataMember(Name = "ReportPeriod")]
        public int? ReportPeriod { get; set; }

        /// <summary>
        /// The unique identifier (UPN) of the user within the organization.
        /// </summary>
        [DataMember(Name = "UserPrincipalName")]
        public string? UserPrincipalName { get; set; }

        /// <summary>
        /// Indicates if the user is deleted.
        /// </summary>
        [DataMember(Name = "IsDeleted")]
        public string? IsDeleted { get; set; }

        /// <summary>
        /// The date when the user was deleted, if applicable.
        /// </summary>
        [DataMember(Name = "DeletedDate")]
        public string? DeletedDate { get; set; }

        /// <summary>
        /// The last date on which the user performed an activity in SharePoint.
        /// </summary>
        [DataMember(Name = "LastActivityDate")]
        public string? LastActivityDate { get; set; }

        /// <summary>
        /// The count of files viewed or edited by the user.
        /// </summary>
        [DataMember(Name = "ViewedOrEditedFileCount")]
        public int? ViewedOrEditedFileCount { get; set; }

        /// <summary>
        /// The count of files synced by the user.
        /// </summary>
        [DataMember(Name = "SyncedFileCount")]
        public int? SyncedFileCount { get; set; }

        /// <summary>
        /// The count of files shared internally by the user.
        /// </summary>
        [DataMember(Name = "SharedInternallyFileCount")]
        public int? SharedInternallyFileCount { get; set; }

        /// <summary>
        /// The count of files shared externally by the user.
        /// </summary>
        [DataMember(Name = "SharedExternallyFileCount")]
        public int? SharedExternallyFileCount { get; set; }

        /// <summary>
        /// The count of pages visited by the user.
        /// </summary>
        [DataMember(Name = "VisitedPageCount")]
        public int? VisitedPageCount { get; set; }

        /// <summary>
        /// The list of products assigned to the user.
        /// </summary>
        [DataMember(Name = "AssignedProducts")]
        public string? AssignedProducts { get; set; }
    }
}
