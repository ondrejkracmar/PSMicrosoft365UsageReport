#nullable enable
using System.Runtime.Serialization;
using PSMicrosoft365UsageReport.Interface;

namespace PSMicrosoft365UsageReport.Report
{
    /// <summary>
    /// Represents the trend of storage allocated and consumed in SharePoint during the reporting period.
    /// This includes details on the Report Refresh Date, reporting period, site type, and storage used in bytes.
    /// </summary>
    [DataContract]
    public class SharePointSiteUsageStorage : IReport
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SharePointSiteUsageStorage"/> class.
        /// </summary>
        public SharePointSiteUsageStorage() { }

        /// <summary>
        /// The date when the report was last refreshed.
        /// </summary>
        [DataMember(Name = "Report Refresh Date")]
        public string? ReportRefreshDate { get; set; }

        /// <summary>
        /// The date associated with the report.
        /// </summary>
        [DataMember(Name = "Report Date")]
        public string? ReportDate { get; set; }

        /// <summary>
        /// The period covered by the report.
        /// </summary>
        [DataMember(Name = "Report Period")]
        public int? ReportPeriod { get; set; }

        /// <summary>
        /// The type of SharePoint site (e.g., personal or shared).
        /// </summary>
        [DataMember(Name = "Site Type")]
        public string? SiteType { get; set; }

        /// <summary>
        /// The amount of storage used in bytes.
        /// </summary>
        [DataMember(Name = "Storage Used (Byte)")]
        public long StorageUsedByte { get; set; }
    }
}
