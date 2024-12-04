using System.Runtime.Serialization;
using PSMicrosoft365UsageReport.Interface;

namespace PSMicrosoft365UsageReport.Report
{
    /// <summary>
    /// Represents detailed information about SharePoint site usage.
    /// This includes details on the Report Refresh Date, reporting period, site activity, file and page usage statistics, storage usage, and owner information.
    /// </summary>
    [DataContract]
    public class SharePointSiteUsageDetail : IReport
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SharePointSiteUsageDetail"/> class.
        /// </summary>
        public SharePointSiteUsageDetail() { }

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
        /// The principal name of the site owner.
        /// </summary>
        [DataMember(Name = "Owner Principal Name")]
        public string? OwnerPrincipalName { get; set; }

        /// <summary>
        /// The display name of the site owner.
        /// </summary>
        [DataMember(Name = "Owner Display Name")]
        public string? OwnerDisplayName { get; set; }

        /// <summary>
        /// Indicates if the site is deleted.
        /// </summary>
        [DataMember(Name = "Is Deleted")]
        public string? IsDeleted { get; set; }

        /// <summary>
        /// The last date of activity on the site.
        /// </summary>
        [DataMember(Name = "Last Activity Date")]
        public string? LastActivityDate { get; set; }

        /// <summary>
        /// The unique identifier of the site.
        /// </summary>
        [DataMember(Name = "Site Id")]
        public string? SiteId { get; set; }

        /// <summary>
        /// The URL of the site.
        /// </summary>
        [DataMember(Name = "Site URL")]
        public string? SiteURL { get; set; }

        /// <summary>
        /// The total count of files on the site.
        /// </summary>
        [DataMember(Name = "File Count")]
        public int? FileCount { get; set; }

        /// <summary>
        /// The count of active files on the site.
        /// </summary>
        [DataMember(Name = "Active File Count")]
        public int? ActiveFileCount { get; set; }

        /// <summary>
        /// The count of page views on the site.
        /// </summary>
        [DataMember(Name = "Page View Count")]
        public int? PageViewCount { get; set; }

        /// <summary>
        /// The count of unique pages visited on the site.
        /// </summary>
        [DataMember(Name = "Visited Page Count")]
        public int? VisitedPageCount { get; set; }

        /// <summary>
        /// The amount of storage used by the site in bytes.
        /// </summary>
        [DataMember(Name = "Storage Used (Byte)")]
        public long StorageUsedByte { get; set; }

        /// <summary>
        /// The amount of storage allocated to the site in bytes.
        /// </summary>
        [DataMember(Name = "Storage Allocated (Byte)")]
        public long StorageAllocatedByte { get; set; }

        /// <summary>
        /// The template used for the root web of the site.
        /// </summary>
        [DataMember(Name = "Root Web Template")]
        public string? RootWebTemplate { get; set; }
    }
}
