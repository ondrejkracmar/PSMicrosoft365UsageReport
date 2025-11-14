#nullable enable
using System.Runtime.Serialization;
using PSMicrosoft365UsageReport.Interface;

namespace PSMicrosoft365UsageReport.Report.Beta
{
    /// <summary>
    /// Class representing the response data for the EmailAppUsageVersionsUserCounts report.
    /// Implements the <see cref="IReport"/> interface.
    /// </summary>
    public class EmailAppUsageVersionsUserCounts : IReport
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EmailAppUsageVersionsUserCounts"/> class.
        /// </summary>
        public EmailAppUsageVersionsUserCounts()
        {
        }

        /// <summary>
        /// The date when the report was last refreshed, represented as a nullable string.
        /// </summary>
        public string? ReportRefreshDate { get; set; }

        /// <summary>
        /// The period covered by the report in days, represented as a nullable integer.
        /// </summary>
        public int? ReportPeriod { get; set; }

        /// <summary>
        /// The count of unique users using Outlook 2007, represented as a nullable integer.
        /// </summary>
        public int? Outlook2007 { get; set; }

        /// <summary>
        /// The count of unique users using Outlook 2010, represented as a nullable integer.
        /// </summary>
        public int? Outlook2010 { get; set; }

        /// <summary>
        /// The count of unique users using Outlook 2013, represented as a nullable integer.
        /// </summary>
        public int? Outlook2013 { get; set; }

        /// <summary>
        /// The count of unique users using Outlook 2016, represented as a nullable integer.
        /// </summary>
        public int? Outlook2016 { get; set; }

        /// <summary>
        /// The count of unique users using Outlook 2019, represented as a nullable integer.
        /// </summary>
        public int? Outlook2019 { get; set; }

        /// <summary>
        /// The count of unique users using Outlook M365, represented as a nullable integer.
        /// </summary>
        public int? OutlookM365 { get; set; }

        /// <summary>
        /// The count of unique users whose Outlook version is undetermined, represented as a nullable integer.
        /// </summary>
        public int? Undetermined { get; set; }
    }
}
