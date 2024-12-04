using System.Runtime.Serialization;
using PSMicrosoft365UsageReport.Interface;

namespace PSMicrosoft365UsageReport.Report.Beta
{
    /// <summary>
    /// Class representing the response data for the SharePointSiteUsageDetail report.
    /// Implements the <see cref="IReport"/> interface.
    /// </summary>
    public class SharePointSiteUsageDetail : IReport
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
        /// The principal name of the site owner, represented as a nullable string.
        /// </summary>
        public string? OwnerPrincipalName { get; set; }

        /// <summary>
        /// The display name of the site owner, represented as a nullable string.
        /// </summary>
        public string? OwnerDisplayName { get; set; }

        /// <summary>
        /// Indicates whether the site is deleted, represented as a nullable boolean.
        /// </summary>
        public string? IsDeleted { get; set; }

        /// <summary>
        /// The date of the last activity on the site, represented as a nullable string.
        /// </summary>
        public string? LastActivityDate { get; set; }

        /// <summary>
        /// The unique identifier of the site, represented as a nullable string.
        /// </summary>
        public string? SiteId { get; set; }

        /// <summary>
        /// The URL of the site, represented as a nullable string.
        /// </summary>
        public string? SiteURL { get; set; }

        /// <summary>
        /// The sensitivity label ID of the site, represented as a nullable string.
        /// </summary>
        public string? SiteSensitivityLabelId { get; set; }

        /// <summary>
        /// The external sharing status of the site, represented as a nullable string.
        /// </summary>
        public string? ExternalSharing { get; set; }

        /// <summary>
        /// The unmanaged device policy of the site, represented as a nullable string.
        /// </summary>
        public string? UnmanagedDevicePolicy { get; set; }

        /// <summary>
        /// The geographic location of the site, represented as a nullable string.
        /// </summary>
        public string? GeoLocation { get; set; }

        /// <summary>
        /// The total number of files on the site, represented as a nullable integer.
        /// </summary>
        public int? FileCount { get; set; }

        /// <summary>
        /// The count of active files on the site, represented as a nullable integer.
        /// </summary>
        public int? ActiveFileCount { get; set; }

        /// <summary>
        /// The total count of page views on the site, represented as a nullable integer.
        /// </summary>
        public int? PageViewCount { get; set; }

        /// <summary>
        /// The total count of pages visited on the site, represented as a nullable integer.
        /// </summary>
        public int? VisitedPageCount { get; set; }

        /// <summary>
        /// The count of anonymous links created on the site, represented as a nullable integer.
        /// </summary>
        public int? AnonymousLinkCount { get; set; }

        /// <summary>
        /// The count of company links created on the site, represented as a nullable integer.
        /// </summary>
        public int? CompanyLinkCount { get; set; }

        /// <summary>
        /// The count of secure links created for guests, represented as a nullable integer.
        /// </summary>
        public int? SecureLinkForGuestCount { get; set; }

        /// <summary>
        /// The count of secure links created for members, represented as a nullable integer.
        /// </summary>
        public int? SecureLinkForMemberCount { get; set; }

        /// <summary>
        /// The total storage used by the site in bytes, represented as a nullable long.
        /// </summary>
        public long? StorageUsedByte { get; set; }

        /// <summary>
        /// The total storage allocated to the site in bytes, represented as a nullable long.
        /// </summary>
        public long? StorageAllocatedByte { get; set; }

        /// <summary>
        /// The root web template of the site, represented as a nullable string.
        /// </summary>
        public string? RootWebTemplate { get; set; }
    }
}
