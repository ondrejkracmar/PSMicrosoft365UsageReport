using System.Runtime.Serialization;
using PSMicrosoft365UsageReport.Interface;

namespace PSMicrosoft365UsageReport.Report
{
    /// <summary>
    /// Represents detailed information about OneDrive usage by individual accounts within an organization.
    /// This includes details on the Report Refresh Date, reporting period, account activity, storage usage, and owner information.
    /// </summary>
    [DataContract]
    public class OneDriveUsageAccountDetail : IReport
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OneDriveUsageAccountDetail"/> class.
        /// </summary>
        public OneDriveUsageAccountDetail() { }

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
        /// The URL of the OneDrive site.
        /// </summary>
        [DataMember(Name = "Site URL")]
        public string? SiteURL { get; set; }

        /// <summary>
        /// The principal name of the OneDrive site owner.
        /// </summary>
        [DataMember(Name = "Owner Principal Name")]
        public string? OwnerPrincipalName { get; set; }

        /// <summary>
        /// The display name of the OneDrive site owner.
        /// </summary>
        [DataMember(Name = "Owner Display Name")]
        public string? OwnerDisplayName { get; set; }

        /// <summary>
        /// Indicates if the OneDrive site is deleted.
        /// </summary>
        [DataMember(Name = "Is Deleted")]
        public string? IsDeleted { get; set; }

        /// <summary>
        /// The date of the last activity on the OneDrive site.
        /// </summary>
        [DataMember(Name = "Last Activity Date")]
        public string? LastActivityDate { get; set; }

        /// <summary>
        /// The count of active files on the OneDrive site.
        /// </summary>
        [DataMember(Name = "Active File Count")]
        public int? ActiveFileCount { get; set; }

        /// <summary>
        /// The storage used by the OneDrive site in bytes.
        /// </summary>
        [DataMember(Name = "Storage Used (Byte)")]
        public long StorageUsedByte { get; set; }

        /// <summary>
        /// The storage allocated to the OneDrive site in bytes.
        /// </summary>
        [DataMember(Name = "Storage Allocated (Byte)")]
        public long StorageAllocatedByte { get; set; }
    }
}
