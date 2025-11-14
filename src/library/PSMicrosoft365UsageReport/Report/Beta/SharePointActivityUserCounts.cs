#nullable enable
using System.Runtime.Serialization;
using PSMicrosoft365UsageReport.Interface;

namespace PSMicrosoft365UsageReport.Report.Beta
{
    /// <summary>
    /// Class representing the response data for the SharePointActivityUserCounts report.
    /// Implements the <see cref="IReport"/> interface.
    /// </summary>
    public class SharePointActivityUserCounts : IReport
    {
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
        /// The count of users who visited a page, represented as a nullable integer.
        /// </summary>
        public int? VisitedPage { get; set; }

        /// <summary>
        /// The count of users who viewed or edited files, represented as a nullable integer.
        /// </summary>
        public int? ViewedOrEdited { get; set; }

        /// <summary>
        /// The count of users who synced files, represented as a nullable integer.
        /// </summary>
        public int? Synced { get; set; }

        /// <summary>
        /// The count of users who shared files internally, represented as a nullable integer.
        /// </summary>
        public int? SharedInternally { get; set; }

        /// <summary>
        /// The count of users who shared files externally, represented as a nullable integer.
        /// </summary>
        public int? SharedExternally { get; set; }
    }
}
