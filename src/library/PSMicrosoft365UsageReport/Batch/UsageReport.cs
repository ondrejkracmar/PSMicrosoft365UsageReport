using System;
using PSMicrosoft365UsageReport.Interface;

namespace PSMicrosoft365UsageReport.Batch
{
    /// <summary>
    /// Represents a usage report result from a batch request
    /// </summary>
    public class UsageReport
    {
        /// <summary>
        /// Gets or sets the utility name
        /// </summary>
        public string Utility { get; set; }

        /// <summary>
        /// Gets or sets the service name
        /// </summary>
        public string Service { get; set; }

        /// <summary>
        /// Gets or sets the report type
        /// </summary>
        public string Type { get; set; }

        /// <summary>
        /// Gets or sets the report name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the report refresh date
        /// </summary>
        public string? ReportRefreshDate { get; set; }

        /// <summary>
        /// Gets or sets the report period
        /// </summary>
        public int ReportPeriod { get; set; }

        /// <summary>
        /// Gets or sets the report data
        /// </summary>
        public IReport[] Report { get; set; }
    }
}
