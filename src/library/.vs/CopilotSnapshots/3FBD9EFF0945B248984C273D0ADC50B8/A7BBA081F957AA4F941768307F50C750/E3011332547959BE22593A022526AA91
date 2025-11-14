#nullable enable
using System.Runtime.Serialization;
using PSMicrosoft365UsageReport.Interface;

namespace PSMicrosoft365UsageReport.Report
{
    /// <summary>
    /// Represents the count of unique users that connected to Exchange Online using various email applications.
    /// This includes information on the Report Refresh Date, report period, and user counts for different email applications
    /// such as Mail for Mac, Outlook for multiple platforms, and other email protocols.
    /// </summary>
    [DataContract]
    public class EmailAppUsageUserCounts : IReport
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EmailAppUsageUserCounts"/> class.
        /// </summary>
        public EmailAppUsageUserCounts() { }

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
        /// The count of unique users using Mail for Mac.
        /// </summary>
        [DataMember(Name = "Mail For Mac")]
        public int? MailForMac { get; set; }

        /// <summary>
        /// The count of unique users using Outlook for Mac.
        /// </summary>
        [DataMember(Name = "Outlook For Mac")]
        public int? OutlookForMac { get; set; }

        /// <summary>
        /// The count of unique users using Outlook for Windows.
        /// </summary>
        [DataMember(Name = "Outlook For Windows")]
        public int? OutlookForWindows { get; set; }

        /// <summary>
        /// The count of unique users using Outlook for Mobile.
        /// </summary>
        [DataMember(Name = "Outlook For Mobile")]
        public int? OutlookForMobile { get; set; }

        /// <summary>
        /// The count of unique users using other email clients on mobile.
        /// </summary>
        [DataMember(Name = "Other For Mobile")]
        public int? OtherForMobile { get; set; }

        /// <summary>
        /// The count of unique users using Outlook for Web.
        /// </summary>
        [DataMember(Name = "Outlook For Web")]
        public int? OutlookForWeb { get; set; }

        /// <summary>
        /// The count of unique users using a POP3 application.
        /// </summary>
        [DataMember(Name = "POP3 App")]
        public int? POP3App { get; set; }

        /// <summary>
        /// The count of unique users using an IMAP4 application.
        /// </summary>
        [DataMember(Name = "IMAP4 App")]
        public int? IMAP4App { get; set; }

        /// <summary>
        /// The count of unique users using an SMTP application.
        /// </summary>
        [DataMember(Name = "SMTP App")]
        public int? SMTPApp { get; set; }
    }
}
