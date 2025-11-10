#nullable enable
using System.Runtime.Serialization;
using PSMicrosoft365UsageReport.Interface;

namespace PSMicrosoft365UsageReport.Report
{
    /// <summary>
    /// Represents the total storage used across all group mailboxes and group sites within an organization.
    /// This includes details on the Report Refresh Date, reporting period, and storage used in bytes by mailboxes and sites.
    /// </summary>
    [DataContract]
    public class Office365GroupsActivityStorage : IReport
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Office365GroupsActivityStorage"/> class.
        /// </summary>
        public Office365GroupsActivityStorage() { }

        /// <summary>
        /// The date when the report was last refreshed.
        /// </summary>
        [DataMember(Name = "ReportRefreshDate")]
        public string? ReportRefreshDate { get; set; }

        /// <summary>
        /// The date associated with the report.
        /// </summary>
        [DataMember(Name = "ReportDate")]
        public string? ReportDate { get; set; }

        /// <summary>
        /// The period covered by the report.
        /// </summary>
        [DataMember(Name = "ReportPeriod")]
        public int? ReportPeriod { get; set; }

        /// <summary>
        /// The total storage used by group mailboxes in bytes.
        /// </summary>
        [DataMember(Name = "MailboxStorageUsedByte")]
        public long MailboxStorageUsedByte { get; set; }

        /// <summary>
        /// The total storage used by group sites in bytes.
        /// </summary>
        [DataMember(Name = "SiteStorageUsedByte")]
        public long SiteStorageUsedByte { get; set; }
    }
}
