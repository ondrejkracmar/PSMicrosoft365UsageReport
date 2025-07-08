#nullable enable
using System.Runtime.Serialization;
using PSMicrosoft365UsageReport.Interface;

namespace PSMicrosoft365UsageReport.Report
{
    /// <summary>
    /// Represents the count of unique users by Outlook desktop version within an organization.
    /// This includes information on the Report Refresh Date, report period, and user counts for 
    /// various Outlook desktop versions such as Outlook 2007, 2010, 2013, 2016, 2019, and Outlook M365.
    /// </summary>
    [DataContract]
    public class EmailAppUsageVersionsUserCounts : IReport
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EmailAppUsageVersionsUserCounts"/> class.
        /// </summary>
        public EmailAppUsageVersionsUserCounts() { }

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
        /// The count of unique users using Outlook 2007.
        /// </summary>
        [DataMember(Name = "Outlook 2007")]
        public int? Outlook2007 { get; set; }

        /// <summary>
        /// The count of unique users using Outlook 2010.
        /// </summary>
        [DataMember(Name = "Outlook 2010")]
        public int? Outlook2010 { get; set; }

        /// <summary>
        /// The count of unique users using Outlook 2013.
        /// </summary>
        [DataMember(Name = "Outlook 2013")]
        public int? Outlook2013 { get; set; }

        /// <summary>
        /// The count of unique users using Outlook 2016.
        /// </summary>
        [DataMember(Name = "Outlook 2016")]
        public int? Outlook2016 { get; set; }

        /// <summary>
        /// The count of unique users using Outlook 2019.
        /// </summary>
        [DataMember(Name = "Outlook 2019")]
        public int? Outlook2019 { get; set; }

        /// <summary>
        /// The count of unique users using Outlook M365.
        /// </summary>
        [DataMember(Name = "Outlook M365")]
        public int? OutlookM365 { get; set; }
    }
}
