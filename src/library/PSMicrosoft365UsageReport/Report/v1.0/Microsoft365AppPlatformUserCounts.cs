using System.Runtime.Serialization;
using PSMicrosoft365UsageReport.Interface;

namespace PSMicrosoft365UsageReport.Report
{
    /// <summary>
    /// Represents a report on the trend of active users across Microsoft 365 apps for each platform (Windows, Mac, web, and mobile) within an organization.
    /// This includes details on the Report Refresh Date, report period, and active user counts by platform.
    /// </summary>
    [DataContract]
    public class Microsoft365AppPlatformUserCounts : IReport
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Microsoft365AppPlatformUserCounts"/> class.
        /// </summary>
        public Microsoft365AppPlatformUserCounts() { }

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
        /// The count of active users on the Windows platform.
        /// </summary>
        [DataMember(Name = "Windows")]
        public int? Windows { get; set; }

        /// <summary>
        /// The count of active users on the Mac platform.
        /// </summary>
        [DataMember(Name = "Mac")]
        public int? Mac { get; set; }

        /// <summary>
        /// The count of active users on mobile platforms.
        /// </summary>
        [DataMember(Name = "Mobile")]
        public int? Mobile { get; set; }

        /// <summary>
        /// The count of active users on the web platform.
        /// </summary>
        [DataMember(Name = "Web")]
        public int? Web { get; set; }
    }
}
