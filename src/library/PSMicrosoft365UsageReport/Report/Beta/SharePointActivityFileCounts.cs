using System.Runtime.Serialization;
using PSMicrosoft365UsageReport.Interface;

namespace PSMicrosoft365UsageReport.Report.Beta
{
    /// <summary>
    /// Class representing the response data for the SharePointActivityFileCounts report.
    /// Implements the <see cref="IReport"/> interface.
    /// </summary>
    public class SharePointActivityFileCounts : IReport
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
        /// The count of files synced on SharePoint sites, represented as a nullable integer.
        /// </summary>
        public int? Synced { get; set; }

        /// <summary>
        /// The count of files shared internally on SharePoint sites, represented as a nullable integer.
        /// </summary>
        public int? SharedInternally { get; set; }

        /// <summary>
        /// The count of files shared externally on SharePoint sites, represented as a nullable integer.
        /// </summary>
        public int? SharedExternally { get; set; }
    }
}
