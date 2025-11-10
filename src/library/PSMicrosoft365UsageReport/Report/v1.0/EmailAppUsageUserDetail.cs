#nullable enable
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
        [DataMember(Name = "ReportRefreshDate")]
        public string? ReportRefreshDate { get; set; } = string.Empty;

        /// <summary>
        /// The period covered by the report.
        /// </summary>
        [DataMember(Name = "ReportPeriod")]
        public int? ReportPeriod { get; set; }

        /// <summary>
        /// The unique identifier (UPN) of the user within the organization.
        /// </summary>
        [DataMember(Name = "UserPrincipalName")]
        public string? UserPrincipalName { get; set; }

        /// <summary>
        /// The display name of the user.
        /// </summary>
        [DataMember(Name = "DisplayName")]
        public string? DisplayName { get; set; }

        /// <summary>
        /// Indicates whether the user account is deleted.
        /// </summary>
        [DataMember(Name = "IsDeleted")]
        public string? IsDeleted { get; set; }

        /// <summary>
        /// The date when the user account was deleted, if applicable.
        /// </summary>
        [DataMember(Name = "DeletedDate")]
        public string? DeletedDate { get; set; }

        /// <summary>
        /// The last date on which the user performed an activity.
        /// </summary>
        [DataMember(Name = "LastActivityDate")]
        public string? LastActivityDate { get; set; }

        /// <summary>
        /// The count of unique user activities in Mail for Mac.
        /// </summary>
        [DataMember(Name = "MailForMac")]
        public string? MailForMac { get; set; }

        /// <summary>
        /// The count of unique user activities in Outlook for Mac.
        /// </summary>
        [DataMember(Name = "OutlookForMac")]
        public string? OutlookForMac { get; set; }

        /// <summary>
        /// The count of unique user activities in Outlook for Windows.
        /// </summary>
        [DataMember(Name = "OutlookForWindows")]
        public string? OutlookForWindows { get; set; }

        /// <summary>
        /// The count of unique user activities in Outlook for Mobile.
        /// </summary>
        [DataMember(Name = "OutlookForMobile")]
        public string? OutlookForMobile { get; set; }

        /// <summary>
        /// The count of unique user activities in other email clients on mobile.
        /// </summary>
        [DataMember(Name = "OtherForMobile")]
        public string? OtherForMobile { get; set; }

        /// <summary>
        /// The count of unique user activities in Outlook for Web.
        /// </summary>
        [DataMember(Name = "OutlookForWeb")]
        public string? OutlookForWeb { get; set; }

        /// <summary>
        /// The count of unique user activities using a POP3 application.
        /// </summary>
        [DataMember(Name = "POP3App")]
        public string? POP3App { get; set; }

        /// <summary>
        /// The count of unique user activities using an IMAP4 application.
        /// </summary>
        [DataMember(Name = "IMAP4App")]
        public string? IMAP4App { get; set; }

        /// <summary>
        /// The count of unique user activities using an SMTP application.
        /// </summary>
        [DataMember(Name = "SMTPApp")]
        public string? SMTPApp { get; set; }
    }
}
