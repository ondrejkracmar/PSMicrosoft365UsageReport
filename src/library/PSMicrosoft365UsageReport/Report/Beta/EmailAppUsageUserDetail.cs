using System.Runtime.Serialization;
using PSMicrosoft365UsageReport.Interface;

namespace PSMicrosoft365UsageReport.Report.Beta
{
    /// <summary>
    /// Class representing the response data for the EmailAppUsageUserDetail report.
    /// Implements the <see cref="IReport"/> interface.
    /// </summary>
    public class EmailAppUsageUserDetail : IReport
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EmailAppUsageUserDetail"/> class.
        /// </summary>
        public EmailAppUsageUserDetail()
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
        /// The user principal name (UPN) of the user, represented as a nullable string.
        /// </summary>
        public string? UserPrincipalName { get; set; }

        /// <summary>
        /// The display name of the user, represented as a nullable string.
        /// </summary>
        public string? DisplayName { get; set; }

        /// <summary>
        /// Indicates whether the user is deleted, represented as a nullable boolean.
        /// </summary>
        public string? IsDeleted { get; set; }

        /// <summary>
        /// The date the user was deleted, represented as a nullable string.
        /// </summary>
        public string? DeletedDate { get; set; }

        /// <summary>
        /// The date of the user's last activity, represented as a nullable string.
        /// </summary>
        public string? LastActivityDate { get; set; }

        /// <summary>
        /// The count of activities performed on Mail for Mac, represented as a nullable integer.
        /// </summary>
        public int? MailForMac { get; set; }

        /// <summary>
        /// The count of activities performed on Outlook for Mac, represented as a nullable integer.
        /// </summary>
        public int? OutlookForMac { get; set; }

        /// <summary>
        /// The count of activities performed on Outlook for Windows, represented as a nullable integer.
        /// </summary>
        public int? OutlookForWindows { get; set; }

        /// <summary>
        /// The count of activities performed on Outlook for Mobile, represented as a nullable integer.
        /// </summary>
        public int? OutlookForMobile { get; set; }

        /// <summary>
        /// The count of activities performed on other mobile email apps, represented as a nullable integer.
        /// </summary>
        public int? OtherForMobile { get; set; }

        /// <summary>
        /// The count of activities performed on Outlook for Web, represented as a nullable integer.
        /// </summary>
        public int? OutlookForWeb { get; set; }

        /// <summary>
        /// The count of activities performed on POP3 email apps, represented as a nullable integer.
        /// </summary>
        public int? POP3App { get; set; }

        /// <summary>
        /// The count of activities performed on IMAP4 email apps, represented as a nullable integer.
        /// </summary>
        public int? IMAP4App { get; set; }

        /// <summary>
        /// The count of activities performed on SMTP email apps, represented as a nullable integer.
        /// </summary>
        public int? SMTPApp { get; set; }
    }
}
