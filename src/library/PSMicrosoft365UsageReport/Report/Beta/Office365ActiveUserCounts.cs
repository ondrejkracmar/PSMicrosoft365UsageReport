using System.Runtime.Serialization;
using PSMicrosoft365UsageReport.Interface;

namespace PSMicrosoft365UsageReport.Report.Beta
{
    /// <summary>
    /// Class representing the response data for the Office365ActiveUserCounts report.
    /// Implements the <see cref="IReport"/> interface.
    /// </summary>
    public class Office365ActiveUserCounts : IReport
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Office365ActiveUserCounts"/> class.
        /// </summary>
        public Office365ActiveUserCounts()
        {
        }

        /// <summary>
        /// The date when the report was last refreshed, represented as a nullable string.
        /// </summary>
        public string? ReportRefreshDate { get; set; }

        /// <summary>
        /// The date of the report, represented as a nullable string.
        /// </summary>
        public string? ReportDate { get; set; }

        /// <summary>
        /// The period covered by the report in days, represented as a nullable integer.
        /// </summary>
        public int? ReportPeriod { get; set; }

        /// <summary>
        /// The count of daily active users for Office 365, represented as a nullable integer.
        /// </summary>
        public int? Office365 { get; set; }

        /// <summary>
        /// The count of daily active users for Exchange, represented as a nullable integer.
        /// </summary>
        public int? Exchange { get; set; }

        /// <summary>
        /// The count of daily active users for OneDrive, represented as a nullable integer.
        /// </summary>
        public int? OneDrive { get; set; }

        /// <summary>
        /// The count of daily active users for SharePoint, represented as a nullable integer.
        /// </summary>
        public int? SharePoint { get; set; }

        /// <summary>
        /// The count of daily active users for Skype for Business, represented as a nullable integer.
        /// </summary>
        public int? SkypeForBusiness { get; set; }

        /// <summary>
        /// The count of daily active users for Yammer, represented as a nullable integer.
        /// </summary>
        public int? Yammer { get; set; }

        /// <summary>
        /// The count of daily active users for Teams, represented as a nullable integer.
        /// </summary>
        public int? Teams { get; set; }
    }
}
