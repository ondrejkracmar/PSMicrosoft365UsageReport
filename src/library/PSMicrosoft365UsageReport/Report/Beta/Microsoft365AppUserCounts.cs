#nullable enable
using System.Runtime.Serialization;
using PSMicrosoft365UsageReport.Interface;

namespace PSMicrosoft365UsageReport.Report.Beta
{
    /// <summary>
    /// Class representing the response data for the Microsoft365AppUserCounts report.
    /// Implements the <see cref="IReport"/> interface.
    /// </summary>
    public class Microsoft365AppUserCounts : IReport
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Microsoft365AppUserCounts"/> class.
        /// </summary>
        public Microsoft365AppUserCounts()
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
    }
}
