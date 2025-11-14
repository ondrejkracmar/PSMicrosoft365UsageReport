#nullable enable
using System.Runtime.Serialization;
using PSMicrosoft365UsageReport.Interface;

namespace PSMicrosoft365UsageReport.Report.Beta
{
    /// <summary>
    /// Class representing the response data for the Office365ServicesUserCounts report.
    /// Implements the <see cref="IReport"/> interface.
    /// </summary>
    public class Office365ServicesUserCounts : IReport
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
        /// The count of active Exchange users, represented as a nullable integer.
        /// </summary>
        public int? ExchangeActive { get; set; }

        /// <summary>
        /// The count of inactive Exchange users, represented as a nullable integer.
        /// </summary>
        public int? ExchangeInactive { get; set; }

        /// <summary>
        /// The count of active OneDrive users, represented as a nullable integer.
        /// </summary>
        public int? OneDriveActive { get; set; }

        /// <summary>
        /// The count of inactive OneDrive users, represented as a nullable integer.
        /// </summary>
        public int? OneDriveInactive { get; set; }

        /// <summary>
        /// The count of active SharePoint users, represented as a nullable integer.
        /// </summary>
        public int? SharePointActive { get; set; }

        /// <summary>
        /// The count of inactive SharePoint users, represented as a nullable integer.
        /// </summary>
        public int? SharePointInactive { get; set; }

        /// <summary>
        /// The count of active Skype for Business users, represented as a nullable integer.
        /// </summary>
        public int? SkypeForBusinessActive { get; set; }

        /// <summary>
        /// The count of inactive Skype for Business users, represented as a nullable integer.
        /// </summary>
        public int? SkypeForBusinessInactive { get; set; }

        /// <summary>
        /// The count of active Yammer users, represented as a nullable integer.
        /// </summary>
        public int? YammerActive { get; set; }

        /// <summary>
        /// The count of inactive Yammer users, represented as a nullable integer.
        /// </summary>
        public int? YammerInactive { get; set; }

        /// <summary>
        /// The count of active Teams users, represented as a nullable integer.
        /// </summary>
        public int? TeamsActive { get; set; }

        /// <summary>
        /// The count of inactive Teams users, represented as a nullable integer.
        /// </summary>
        public int? TeamsInactive { get; set; }

        /// <summary>
        /// The count of active Office 365 users, represented as a nullable integer.
        /// </summary>
        public int? Office365Active { get; set; }

        /// <summary>
        /// The count of inactive Office 365 users, represented as a nullable integer.
        /// </summary>
        public int? Office365Inactive { get; set; }
    }
}
