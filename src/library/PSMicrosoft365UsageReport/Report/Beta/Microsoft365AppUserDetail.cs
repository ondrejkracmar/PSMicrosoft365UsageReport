#nullable enable
using System.Runtime.Serialization;
using PSMicrosoft365UsageReport.Interface;

namespace PSMicrosoft365UsageReport.Report.Beta
{
    /// <summary>
    /// Class representing the response data for the Microsoft365AppUserDetail report.
    /// Implements the <see cref="IReport"/> interface.
    /// </summary>
    public class Microsoft365AppUserDetail : IReport
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
        /// The user principal name (UPN) of the user, represented as a nullable string.
        /// </summary>
        public string? UserPrincipalName { get; set; }

        /// <summary>
        /// The last activation date of the user, represented as a nullable string.
        /// </summary>
        public string? LastActivationDate { get; set; }

        /// <summary>
        /// The last activity date of the user, represented as a nullable string.
        /// </summary>
        public string? LastActivityDate { get; set; }

        /// <summary>
        /// The count of active users on the Windows platform, represented as a nullable integer.
        /// </summary>
        public int? Windows { get; set; }

        /// <summary>
        /// The count of active users on the Mac platform, represented as a nullable integer.
        /// </summary>
        public int? Mac { get; set; }

        /// <summary>
        /// The count of active users on the Mobile platform, represented as a nullable integer.
        /// </summary>
        public int? Mobile { get; set; }

        /// <summary>
        /// The count of active users on the Web platform, represented as a nullable integer.
        /// </summary>
        public int? Web { get; set; }

        /// <summary>
        /// The count of active users for Outlook, represented as a nullable integer.
        /// </summary>
        public int? Outlook { get; set; }

        /// <summary>
        /// The count of active users for Word, represented as a nullable integer.
        /// </summary>
        public int? Word { get; set; }

        /// <summary>
        /// The count of active users for Excel, represented as a nullable integer.
        /// </summary>
        public int? Excel { get; set; }

        /// <summary>
        /// The count of active users for PowerPoint, represented as a nullable integer.
        /// </summary>
        public int? PowerPoint { get; set; }

        /// <summary>
        /// The count of active users for OneNote, represented as a nullable integer.
        /// </summary>
        public int? OneNote { get; set; }

        /// <summary>
        /// The count of active users for Teams, represented as a nullable integer.
        /// </summary>
        public int? Teams { get; set; }

        /// <summary>
        /// The count of active users for Outlook on Windows, represented as a nullable integer.
        /// </summary>
        public int? OutlookWindows { get; set; }

        /// <summary>
        /// The count of active users for Word on Windows, represented as a nullable integer.
        /// </summary>
        public int? WordWindows { get; set; }

        /// <summary>
        /// The count of active users for Excel on Windows, represented as a nullable integer.
        /// </summary>
        public int? ExcelWindows { get; set; }

        /// <summary>
        /// The count of active users for PowerPoint on Windows, represented as a nullable integer.
        /// </summary>
        public int? PowerPointWindows { get; set; }

        /// <summary>
        /// The count of active users for OneNote on Windows, represented as a nullable integer.
        /// </summary>
        public int? OneNoteWindows { get; set; }

        /// <summary>
        /// The count of active users for Teams on Windows, represented as a nullable integer.
        /// </summary>
        public int? TeamsWindows { get; set; }

        /// <summary>
        /// The count of active users for Outlook on Mac, represented as a nullable integer.
        /// </summary>
        public int? OutlookMac { get; set; }

        /// <summary>
        /// The count of active users for Word on Mac, represented as a nullable integer.
        /// </summary>
        public int? WordMac { get; set; }

        /// <summary>
        /// The count of active users for Excel on Mac, represented as a nullable integer.
        /// </summary>
        public int? ExcelMac { get; set; }

        /// <summary>
        /// The count of active users for PowerPoint on Mac, represented as a nullable integer.
        /// </summary>
        public int? PowerPointMac { get; set; }

        /// <summary>
        /// The count of active users for OneNote on Mac, represented as a nullable integer.
        /// </summary>
        public int? OneNoteMac { get; set; }

        /// <summary>
        /// The count of active users for Teams on Mac, represented as a nullable integer.
        /// </summary>
        public int? TeamsMac { get; set; }

        /// <summary>
        /// The count of active users for Outlook on Mobile, represented as a nullable integer.
        /// </summary>
        public int? OutlookMobile { get; set; }

        /// <summary>
        /// The count of active users for Word on Mobile, represented as a nullable integer.
        /// </summary>
        public int? WordMobile { get; set; }

        /// <summary>
        /// The count of active users for Excel on Mobile, represented as a nullable integer.
        /// </summary>
        public int? ExcelMobile { get; set; }

        /// <summary>
        /// The count of active users for PowerPoint on Mobile, represented as a nullable integer.
        /// </summary>
        public int? PowerPointMobile { get; set; }

        /// <summary>
        /// The count of active users for OneNote on Mobile, represented as a nullable integer.
        /// </summary>
        public int? OneNoteMobile { get; set; }

        /// <summary>
        /// The count of active users for Teams on Mobile, represented as a nullable integer.
        /// </summary>
        public int? TeamsMobile { get; set; }

        /// <summary>
        /// The count of active users for Outlook on Web, represented as a nullable integer.
        /// </summary>
        public int? OutlookWeb { get; set; }

        /// <summary>
        /// The count of active users for Word on Web, represented as a nullable integer.
        /// </summary>
        public int? WordWeb { get; set; }

        /// <summary>
        /// The count of active users for Excel on Web, represented as a nullable integer.
        /// </summary>
        public int? ExcelWeb { get; set; }

        /// <summary>
        /// The count of active users for PowerPoint on Web, represented as a nullable integer.
        /// </summary>
        public int? PowerPointWeb { get; set; }

        /// <summary>
        /// The count of active users for OneNote on Web, represented as a nullable integer.
        /// </summary>
        public int? OneNoteWeb { get; set; }

        /// <summary>
        /// The count of active users for Teams on Web, represented as a nullable integer.
        /// </summary>
        public int? TeamsWeb { get; set; }
    }
}
