#nullable enable
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
        [DataMember(Name = "ReportRefreshDate")]
        public string? ReportRefreshDate { get; set; }

        /// <summary>
        /// The period covered by the report.
        /// </summary>
        [DataMember(Name = "ReportPeriod")]
        public int? ReportPeriod { get; set; }

        /// <summary>
        /// The unique identifier of the user.
        /// </summary>
        [DataMember(Name = "UserId")]
        public string? UserId { get; set; }

        /// <summary>
        /// The principal name of the user.
        /// </summary>
        [DataMember(Name = "UserPrincipalName")]
        public string? UserPrincipalName { get; set; }

        /// <summary>
        /// Indicates if the user is deleted.
        /// </summary>
        [DataMember(Name = "IsDeleted")]
        public string? IsDeleted { get; set; }

        /// <summary>
        /// The date when the user was deleted, if applicable.
        /// </summary>
        [DataMember(Name = "DeletedDate")]
        public string? DeletedDate { get; set; }

        /// <summary>
        /// The last date of activity for the user in Microsoft Teams.
        /// </summary>
        [DataMember(Name = "LastActivityDate")]
        public string? LastActivityDate { get; set; }

        /// <summary>
        /// Indicates if the user accessed Teams via the web.
        /// </summary>
        [DataMember(Name = "UsedWeb")]
        public string? UsedWeb { get; set; }

        /// <summary>
        /// Indicates if the user accessed Teams via Windows Phone.
        /// </summary>
        [DataMember(Name = "UsedWindowsPhone")]
        public string? UsedWindowsPhone { get; set; }

        /// <summary>
        /// Indicates if the user accessed Teams via iOS.
        /// </summary>
        [DataMember(Name = "UsediOS")]
        public string? UsediOS { get; set; }

        /// <summary>
        /// Indicates if the user accessed Teams via Mac.
        /// </summary>
        [DataMember(Name = "UsedMac")]
        public string? UsedMac { get; set; }

        /// <summary>
        /// Indicates if the user accessed Teams via Android Phone.
        /// </summary>
        [DataMember(Name = "UsedAndroidPhone")]
        public string? UsedAndroidPhone { get; set; }

        /// <summary>
        /// Indicates if the user accessed Teams via Windows.
        /// </summary>
        [DataMember(Name = "UsedWindows")]
        public string? UsedWindows { get; set; }

        /// <summary>
        /// Indicates if the user accessed Teams via Chrome OS.
        /// </summary>
        [DataMember(Name = "UsedChromeOS")]
        public string? UsedChromeOS { get; set; }

        /// <summary>
        /// Indicates if the user accessed Teams via Linux.
        /// </summary>
        [DataMember(Name = "UsedLinux")]
        public string? UsedLinux { get; set; }

        /// <summary>
        /// Indicates if the user is licensed for Microsoft Teams.
        /// </summary>
        [DataMember(Name = "IsLicensed")]
        public string? IsLicensed { get; set; }
    }
}
