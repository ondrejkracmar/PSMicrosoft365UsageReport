#nullable enable
using System.Runtime.Serialization;
using PSMicrosoft365UsageReport.Interface;

namespace PSMicrosoft365UsageReport.Report.Beta
{
    /// <summary>
    /// Class representing the response data for the OneDriveActivityFileCounts report.
    /// Implements the <see cref="IReport"/> interface.
    /// </summary>
    public class OneDriveActivityFileCounts : IReport
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
        /// The count of files viewed or edited, represented as a nullable integer.
        /// </summary>
        public int? ViewedOrEdited { get; set; }

        /// <summary>
        /// The count of files synced, represented as a nullable integer.
        /// </summary>
        public int? Synced { get; set; }

        /// <summary>
        /// The count of files shared internally, represented as a nullable integer.
        /// </summary>
        public int? SharedInternally { get; set; }

        /// <summary>
        /// The count of files shared externally, represented as a nullable integer.
        /// </summary>
        public int? SharedExternally { get; set; }
    }
}
