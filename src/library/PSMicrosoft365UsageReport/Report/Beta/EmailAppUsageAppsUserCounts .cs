using System.Runtime.Serialization;
using PSMicrosoft365UsageReport.Interface;

namespace PSMicrosoft365UsageReport.Report.Beta
{
    /// <summary>
    /// Class representing the response data for the EmailAppUsageAppsUserCounts report.
    /// Implements the <see cref="IReport"/> interface.
    /// </summary>
    public class EmailAppUsageAppsUserCounts : IReport
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EmailAppUsageAppsUserCounts"/> class.
        /// </summary>
        public EmailAppUsageAppsUserCounts()
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
        /// The count of unique users using Mail for Mac, represented as a nullable integer.
        /// </summary>
        public int? MailForMac { get; set; }

        /// <summary>
        /// The count of unique users using Outlook for Mac, represented as a nullable integer.
        /// </summary>
        public int? OutlookForMac { get; set; }

        /// <summary>
        /// The count of unique users using Outlook for Windows, represented as a nullable integer.
        /// </summary>
        public int? OutlookForWindows { get; set; }

        /// <summary>
        /// The count of unique users using Outlook for Mobile, represented as a nullable integer.
        /// </summary>
        public int? OutlookForMobile { get; set; }

        /// <summary>
        /// The count of unique users using other email apps for mobile, represented as a nullable integer.
        /// </summary>
        public int? OtherForMobile { get; set; }

        /// <summary>
        /// The count of unique users using Outlook for Web, represented as a nullable integer.
        /// </summary>
        public int? OutlookForWeb { get; set; }

        /// <summary>
        /// The count of unique users using POP3 email apps, represented as a nullable integer.
        /// </summary>
        public int? POP3App { get; set; }

        /// <summary>
        /// The count of unique users using IMAP4 email apps, represented as a nullable integer.
        /// </summary>
        public int? IMAP4App { get; set; }

        /// <summary>
        /// The count of unique users using SMTP email apps, represented as a nullable integer.
        /// </summary>
        public int? SMTPApp { get; set; }
    }
}
