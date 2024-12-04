using System.Runtime.Serialization;
using PSMicrosoft365UsageReport.Interface;

namespace PSMicrosoft365UsageReport.Report.Beta
{
    /// <summary>
    /// Class representing the response data for the TeamsDeviceUsageUserDetail report.
    /// Implements the <see cref="IReport"/> interface.
    /// </summary>
    public class TeamsDeviceUsageUserDetail : IReport
    {
        /// <summary>
        /// The date when the report was last refreshed, represented as a nullable string.
        /// </summary>
        public string? ReportRefreshDate { get; set; }

        /// <summary>
        /// The period covered by the report in days, represented as a nullable integer.
        /// </summary>
        public int? ReportPeriod { get; set; }

        /// <summary>
        /// The unique identifier for the user, represented as a nullable string.
        /// </summary>
        public string? UserId { get; set; }

        /// <summary>
        /// The user principal name (UPN) of the user, represented as a nullable string.
        /// </summary>
        public string? UserPrincipalName { get; set; }

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
        /// The number of times the user used Microsoft Teams on the web, represented as a nullable integer.
        /// </summary>
        public int? UsedWeb { get; set; }

        /// <summary>
        /// The number of times the user used Microsoft Teams on Windows Phone, represented as a nullable integer.
        /// </summary>
        public int? UsedWindowsPhone { get; set; }

        /// <summary>
        /// The number of times the user used Microsoft Teams on iOS devices, represented as a nullable integer.
        /// </summary>
        public int? UsediOS { get; set; }

        /// <summary>
        /// The number of times the user used Microsoft Teams on Mac devices, represented as a nullable integer.
        /// </summary>
        public int? UsedMac { get; set; }

        /// <summary>
        /// The number of times the user used Microsoft Teams on Android Phone, represented as a nullable integer.
        /// </summary>
        public int? UsedAndroidPhone { get; set; }

        /// <summary>
        /// The number of times the user used Microsoft Teams on Windows devices, represented as a nullable integer.
        /// </summary>
        public int? UsedWindows { get; set; }

        /// <summary>
        /// The number of times the user used Microsoft Teams on Chrome OS, represented as a nullable integer.
        /// </summary>
        public int? UsedChromeOS { get; set; }

        /// <summary>
        /// The number of times the user used Microsoft Teams on Linux devices, represented as a nullable integer.
        /// </summary>
        public int? UsedLinux { get; set; }

        /// <summary>
        /// Indicates whether the user is licensed for Microsoft Teams, represented as a nullable boolean.
        /// </summary>
        public string? IsLicensed { get; set; }
    }
}
