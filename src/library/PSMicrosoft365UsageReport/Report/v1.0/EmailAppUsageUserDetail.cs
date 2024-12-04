using System.ComponentModel;
using System.Runtime.Serialization;
using PSMicrosoft365UsageReport.Interface;

namespace PSMicrosoft365UsageReport.Report
{
    /// <summary>
    /// Represents detailed information about user activities across various email applications within an organization.
    /// This includes report refresh details, user-specific information, and activity counts across multiple email applications
    /// such as Mail for Mac, Outlook for different platforms, and other email protocols.
    /// </summary>
    [DataContract]
    public class EmailAppUsageUserDetail : IReport
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EmailAppUsageUserDetail"/> class.
        /// </summary>
        public EmailAppUsageUserDetail() { }

        /// <summary>
        /// The date when the report was last refreshed.
        /// </summary>
        [DataMember(Name = "Report Refresh Date")]
        public string? ReportRefreshDate { get; set; } = string.Empty;
        // Explicit interface implementation

        /// <summary>
        /// The period covered by the report.
        /// </summary>
        [DataMember(Name = "Report Period")]
        public int? ReportPeriod { get; set; }

        /// <summary>
        /// The unique identifier (UPN) of the user within the organization.
        /// </summary>
        [DataMember(Name = "User Principal Name")]
        public string? UserPrincipalName { get; set; }

        /// <summary>
        /// The display name of the user.
        /// </summary>
        [DataMember(Name = "Display Name")]
        public string? DisplayName { get; set; }

        /// <summary>
        /// Indicates whether the user account is deleted.
        /// </summary>
        [DataMember(Name = "Is Deleted")]
        public string? IsDeleted { get; set; }

        /// <summary>
        /// The date when the user account was deleted, if applicable.
        /// </summary>
        [DataMember(Name = "Deleted Date")]
        public string? DeletedDate { get; set; }

        /// <summary>
        /// The last date on which the user performed an activity.
        /// </summary>
        [DataMember(Name = "Last Activity Date")]
        public string? LastActivityDate { get; set; }

        /// <summary>
        /// The count of unique user activities in Mail for Mac.
        /// </summary>
        [DataMember(Name = "Mail For Mac")]
        public string? MailForMac { get; set; }

        /// <summary>
        /// The count of unique user activities in Outlook for Mac.
        /// </summary>
        [DataMember(Name = "Outlook For Mac")]
        public string? OutlookForMac { get; set; }

        /// <summary>
        /// The count of unique user activities in Outlook for Windows.
        /// </summary>
        [DataMember(Name = "Outlook For Windows")]
        public string? OutlookForWindows { get; set; }

        /// <summary>
        /// The count of unique user activities in Outlook for Mobile.
        /// </summary>
        [DataMember(Name = "Outlook For Mobile")]
        public string? OutlookForMobile { get; set; }

        /// <summary>
        /// The count of unique user activities in other email clients on mobile.
        /// </summary>
        [DataMember(Name = "Other For Mobile")]
        public string? OtherForMobile { get; set; }

        /// <summary>
        /// The count of unique user activities in Outlook for Web.
        /// </summary>
        [DataMember(Name = "Outlook For Web")]
        public string? OutlookForWeb { get; set; }

        /// <summary>
        /// The count of unique user activities using a POP3 application.
        /// </summary>
        [DataMember(Name = "POP3 App")]
        public string? POP3App { get; set; }

        /// <summary>
        /// The count of unique user activities using an IMAP4 application.
        /// </summary>
        [DataMember(Name = "IMAP4 App")]
        public string? IMAP4App { get; set; }

        /// <summary>
        /// The count of unique user activities using an SMTP application.
        /// </summary>
        [DataMember(Name = "SMTP App")]
        public string? SMTPApp { get; set; }
    }
}
