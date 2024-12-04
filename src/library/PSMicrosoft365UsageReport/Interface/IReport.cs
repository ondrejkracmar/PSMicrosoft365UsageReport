using System;

namespace PSMicrosoft365UsageReport.Interface
{
    /// <summary>
    /// Defines common properties for reports in the Microsoft 365 usage reporting system.
    /// </summary>
    public interface IReport
    {
        /// <summary>
        /// Gets or sets the date when the report was last refreshed.
        /// </summary>
        string? ReportRefreshDate { get; set; }

        /// <summary>
        /// Gets or sets the period covered by the report.
        /// </summary>
        int? ReportPeriod { get; set; }
    }
}
