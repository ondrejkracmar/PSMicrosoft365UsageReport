#nullable enable
using System.Runtime.Serialization;
using PSMicrosoft365UsageReport.Interface;

namespace PSMicrosoft365UsageReport.Report
{
    /// <summary>
    /// Represents the count of unique users for each email application used within an organization. 
    /// This includes information on the Report Refresh Date, report period, and user counts for 
    /// various email applications such as Mail for Mac, Outlook for different platforms, and other email protocols.
    /// </summary>
    [DataContract]
    public class EmailAppUsageAppsUserCounts : IReport
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EmailAppUsageAppsUserCounts"/> class.
        /// </summary>
        public EmailAppUsageAppsUserCounts() { }

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
        /// The count of unique users using Mail for Mac.
        /// </summary>
        [DataMember(Name = "MailForMac")]
        public int? MailForMac { get; set; }

        /// <summary>
        /// The count of unique users using Outlook for Mac.
        /// </summary>
        [DataMember(Name = "OutlookForMac")]
        public int? OutlookForMac { get; set; }

        /// <summary>
        /// The count of unique users using Outlook for Windows.
        /// </summary>
        [DataMember(Name = "OutlookForWindows")]
        public int? OutlookForWindows { get; set; }

        /// <summary>
        /// The count of unique users using Outlook for Mobile.
        /// </summary>
        [DataMember(Name = "OutlookForMobile")]
        public int? OutlookForMobile { get; set; }

        /// <summary>
        /// The count of unique users using other email clients on mobile.
        /// </summary>
        [DataMember(Name = "OtherForMobile")]
        public int? OtherForMobile { get; set; }

        /// <summary>
        /// The count of unique users using Outlook for Web.
        /// </summary>
        [DataMember(Name = "OutlookForWeb")]
        public int? OutlookForWeb { get; set; }

        /// <summary>
        /// The count of unique users using a POP3 application.
        /// </summary>
        [DataMember(Name = "POP3App")]
        public int? POP3App { get; set; }

        /// <summary>
        /// The count of unique users using an IMAP4 application.
        /// </summary>
        [DataMember(Name = "IMAP4App")]
        public int? IMAP4App { get; set; }

        /// <summary>
        /// The count of unique users using an SMTP application.
        /// </summary>
        [DataMember(Name = "SMTPApp")]
        public int? SMTPApp { get; set; }
    }
}
