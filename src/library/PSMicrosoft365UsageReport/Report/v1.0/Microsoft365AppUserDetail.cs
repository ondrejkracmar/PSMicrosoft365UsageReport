using System.Runtime.Serialization;
using PSMicrosoft365UsageReport.Interface;

namespace PSMicrosoft365UsageReport.Report
{
    /// <summary>
    /// Represents detailed information about which Microsoft 365 apps and platforms users have used within an organization.
    /// This includes report refresh details, user-specific information, last activation and activity dates, and app usage counts across multiple platforms.
    /// </summary>
    [DataContract]
    public class Microsoft365AppUserDetail : IReport
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Microsoft365AppUserDetail"/> class.
        /// </summary>
        public Microsoft365AppUserDetail() { }

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
        /// The unique identifier (UPN) of the user within the organization.
        /// </summary>
        [DataMember(Name = "User Principal Name")]
        public string? UserPrincipalName { get; set; }

        /// <summary>
        /// The last date on which the user activated an app.
        /// </summary>
        [DataMember(Name = "Last Activation Date")]
        public string? LastActivationDate { get; set; }

        /// <summary>
        /// The last date on which the user performed an activity.
        /// </summary>
        [DataMember(Name = "Last Activity Date")]
        public string? LastActivityDate { get; set; }

        /// <summary>
        /// The count of active users on the Windows platform.
        /// </summary>
        [DataMember(Name = "Windows")]
        public int? Windows { get; set; }

        /// <summary>
        /// The count of active users on the Mac platform.
        /// </summary>
        [DataMember(Name = "Mac")]
        public int? Mac { get; set; }

        /// <summary>
        /// The count of active users on the Mobile platform.
        /// </summary>
        [DataMember(Name = "Mobile")]
        public int? Mobile { get; set; }

        /// <summary>
        /// The count of active users on the Web platform.
        /// </summary>
        [DataMember(Name = "Web")]
        public int? Web { get; set; }

        /// <summary>
        /// The count of active users for Outlook.
        /// </summary>
        [DataMember(Name = "Outlook")]
        public int? Outlook { get; set; }

        /// <summary>
        /// The count of active users for Word.
        /// </summary>
        [DataMember(Name = "Word")]
        public int? Word { get; set; }

        /// <summary>
        /// The count of active users for Excel.
        /// </summary>
        [DataMember(Name = "Excel")]
        public int? Excel { get; set; }

        /// <summary>
        /// The count of active users for PowerPoint.
        /// </summary>
        [DataMember(Name = "PowerPoint")]
        public int? PowerPoint { get; set; }

        /// <summary>
        /// The count of active users for OneNote.
        /// </summary>
        [DataMember(Name = "OneNote")]
        public int? OneNote { get; set; }

        /// <summary>
        /// The count of active users for Teams.
        /// </summary>
        [DataMember(Name = "Teams")]
        public int? Teams { get; set; }

        // Platform-specific usage for each app

        /// <summary>
        /// The count of active users for Outlook on Windows.
        /// </summary>
        [DataMember(Name = "Outlook (Windows)")]
        public int? OutlookWindows { get; set; }

        /// <summary>
        /// The count of active users for Word on Windows.
        /// </summary>
        [DataMember(Name = "Word (Windows)")]
        public int? WordWindows { get; set; }

        /// <summary>
        /// The count of active users for Excel on Windows.
        /// </summary>
        [DataMember(Name = "Excel (Windows)")]
        public int? ExcelWindows { get; set; }

        /// <summary>
        /// The count of active users for PowerPoint on Windows.
        /// </summary>
        [DataMember(Name = "PowerPoint (Windows)")]
        public int? PowerPointWindows { get; set; }

        /// <summary>
        /// The count of active users for OneNote on Windows.
        /// </summary>
        [DataMember(Name = "OneNote (Windows)")]
        public int? OneNoteWindows { get; set; }

        /// <summary>
        /// The count of active users for Teams on Windows.
        /// </summary>
        [DataMember(Name = "Teams (Windows)")]
        public int? TeamsWindows { get; set; }

        /// <summary>
        /// The count of active users for Outlook on Mac.
        /// </summary>
        [DataMember(Name = "Outlook (Mac)")]
        public int? OutlookMac { get; set; }

        /// <summary>
        /// The count of active users for Word on Mac.
        /// </summary>
        [DataMember(Name = "Word (Mac)")]
        public int? WordMac { get; set; }

        /// <summary>
        /// The count of active users for Excel on Mac.
        /// </summary>
        [DataMember(Name = "Excel (Mac)")]
        public int? ExcelMac { get; set; }

        /// <summary>
        /// The count of active users for PowerPoint on Mac.
        /// </summary>
        [DataMember(Name = "PowerPoint (Mac)")]
        public int? PowerPointMac { get; set; }

        /// <summary>
        /// The count of active users for OneNote on Mac.
        /// </summary>
        [DataMember(Name = "OneNote (Mac)")]
        public int? OneNoteMac { get; set; }

        /// <summary>
        /// The count of active users for Teams on Mac.
        /// </summary>
        [DataMember(Name = "Teams (Mac)")]
        public int? TeamsMac { get; set; }

        /// <summary>
        /// The count of active users for Outlook on Mobile.
        /// </summary>
        [DataMember(Name = "Outlook (Mobile)")]
        public int? OutlookMobile { get; set; }

        /// <summary>
        /// The count of active users for Word on Mobile.
        /// </summary>
        [DataMember(Name = "Word (Mobile)")]
        public int? WordMobile { get; set; }

        /// <summary>
        /// The count of active users for Excel on Mobile.
        /// </summary>
        [DataMember(Name = "Excel (Mobile)")]
        public int? ExcelMobile { get; set; }

        /// <summary>
        /// The count of active users for PowerPoint on Mobile.
        /// </summary>
        [DataMember(Name = "PowerPoint (Mobile)")]
        public int? PowerPointMobile { get; set; }

        /// <summary>
        /// The count of active users for OneNote on Mobile.
        /// </summary>
        [DataMember(Name = "OneNote (Mobile)")]
        public int? OneNoteMobile { get; set; }

        /// <summary>
        /// The count of active users for Teams on Mobile.
        /// </summary>
        [DataMember(Name = "Teams (Mobile)")]
        public int? TeamsMobile { get; set; }

        /// <summary>
        /// The count of active users for Outlook on Web.
        /// </summary>
        [DataMember(Name = "Outlook (Web)")]
        public int? OutlookWeb { get; set; }

        /// <summary>
        /// The count of active users for Word on Web.
        /// </summary>
        [DataMember(Name = "Word (Web)")]
        public int? WordWeb { get; set; }

        /// <summary>
        /// The count of active users for Excel on Web.
        /// </summary>
        [DataMember(Name = "Excel (Web)")]
        public int? ExcelWeb { get; set; }

        /// <summary>
        /// The count of active users for PowerPoint on Web.
        /// </summary>
        [DataMember(Name = "PowerPoint (Web)")]
        public int? PowerPointWeb { get; set; }

        /// <summary>
        /// The count of active users for OneNote on Web.
        /// </summary>
        [DataMember(Name = "OneNote (Web)")]
        public int? OneNoteWeb { get; set; }

        /// <summary>
        /// The count of active users for Teams on Web.
        /// </summary>
        [DataMember(Name = "Teams (Web)")]
        public int? TeamsWeb { get; set; }
    }
}
