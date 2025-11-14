#nullable enable
using System.Runtime.Serialization;
using PSMicrosoft365UsageReport.Interface;

namespace PSMicrosoft365UsageReport.Report
{
    /// <summary>
    /// Represents the number of Microsoft Teams daily unique users by device type.
    /// This includes details on the Report Refresh Date, reporting period, and counts of unique users by various device types.
    /// </summary>
    [DataContract]
    public class TeamsDeviceUsageUserCounts : IReport
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TeamsDeviceUsageUserCounts"/> class.
        /// </summary>
        public TeamsDeviceUsageUserCounts() { }

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
        /// The date associated with the report.
        /// </summary>
        [DataMember(Name = "ReportDate")]
        public string? ReportDate { get; set; }

        /// <summary>
        /// The count of unique users accessing Microsoft Teams via the web.
        /// </summary>
        [DataMember(Name = "Web")]
        public int? Web { get; set; }

        /// <summary>
        /// The count of unique users accessing Microsoft Teams via Windows Phone.
        /// </summary>
        [DataMember(Name = "WindowsPhone")]
        public int? WindowsPhone { get; set; }

        /// <summary>
        /// The count of unique users accessing Microsoft Teams via Android Phone.
        /// </summary>
        [DataMember(Name = "AndroidPhone")]
        public int? AndroidPhone { get; set; }

        /// <summary>
        /// The count of unique users accessing Microsoft Teams via iOS.
        /// </summary>
        [DataMember(Name = "iOS")]
        public int? iOS { get; set; }

        /// <summary>
        /// The count of unique users accessing Microsoft Teams via Mac.
        /// </summary>
        [DataMember(Name = "Mac")]
        public int? Mac { get; set; }

        /// <summary>
        /// The count of unique users accessing Microsoft Teams via Windows.
        /// </summary>
        [DataMember(Name = "Windows")]
        public int? Windows { get; set; }

        /// <summary>
        /// The count of unique users accessing Microsoft Teams via Chrome OS.
        /// </summary>
        [DataMember(Name = "ChromeOS")]
        public int? ChromeOS { get; set; }

        /// <summary>
        /// The count of unique users accessing Microsoft Teams via Linux.
        /// </summary>
        [DataMember(Name = "Linux")]
        public int? Linux { get; set; }
    }
}
