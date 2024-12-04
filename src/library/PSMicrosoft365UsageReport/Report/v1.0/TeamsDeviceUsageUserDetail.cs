using System.Runtime.Serialization;
using PSMicrosoft365UsageReport.Interface;

namespace PSMicrosoft365UsageReport.Report
{
    /// <summary>
    /// Represents detailed information about Microsoft Teams device usage by individual users.
    /// This includes details on the Report Refresh Date, reporting period, device usage by the user, and licensing information.
    /// </summary>
    [DataContract]
    public class TeamsDeviceUsageUserDetail : IReport
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TeamsDeviceUsageUserDetail"/> class.
        /// </summary>
        public TeamsDeviceUsageUserDetail() { }

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
        /// The unique identifier of the user.
        /// </summary>
        [DataMember(Name = "User Id")]
        public string? UserId { get; set; }

        /// <summary>
        /// The principal name of the user.
        /// </summary>
        [DataMember(Name = "User Principal Name")]
        public string? UserPrincipalName { get; set; }

        /// <summary>
        /// Indicates if the user is deleted.
        /// </summary>
        [DataMember(Name = "Is Deleted")]
        public string? IsDeleted { get; set; }

        /// <summary>
        /// The date when the user was deleted, if applicable.
        /// </summary>
        [DataMember(Name = "Deleted Date")]
        public string? DeletedDate { get; set; }

        /// <summary>
        /// The last date of activity for the user in Microsoft Teams.
        /// </summary>
        [DataMember(Name = "Last Activity Date")]
        public string? LastActivityDate { get; set; }

        /// <summary>
        /// Indicates if the user accessed Teams via the web.
        /// </summary>
        [DataMember(Name = "Used Web")]
        public string? UsedWeb { get; set; }

        /// <summary>
        /// Indicates if the user accessed Teams via Windows Phone.
        /// </summary>
        [DataMember(Name = "Used Windows Phone")]
        public string? UsedWindowsPhone { get; set; }

        /// <summary>
        /// Indicates if the user accessed Teams via iOS.
        /// </summary>
        [DataMember(Name = "Used iOS")]
        public string? UsediOS { get; set; }

        /// <summary>
        /// Indicates if the user accessed Teams via Mac.
        /// </summary>
        [DataMember(Name = "Used Mac")]
        public string? UsedMac { get; set; }

        /// <summary>
        /// Indicates if the user accessed Teams via Android Phone.
        /// </summary>
        [DataMember(Name = "Used Android Phone")]
        public string? UsedAndroidPhone { get; set; }

        /// <summary>
        /// Indicates if the user accessed Teams via Windows.
        /// </summary>
        [DataMember(Name = "Used Windows")]
        public string? UsedWindows { get; set; }

        /// <summary>
        /// Indicates if the user accessed Teams via Chrome OS.
        /// </summary>
        [DataMember(Name = "Used Chrome OS")]
        public string? UsedChromeOS { get; set; }

        /// <summary>
        /// Indicates if the user accessed Teams via Linux.
        /// </summary>
        [DataMember(Name = "Used Linux")]
        public string? UsedLinux { get; set; }

        /// <summary>
        /// Indicates if the user is licensed for Microsoft Teams.
        /// </summary>
        [DataMember(Name = "Is Licensed")]
        public string? IsLicensed { get; set; }
    }
}
