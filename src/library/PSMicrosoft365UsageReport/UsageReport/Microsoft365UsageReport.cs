using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSMicrosoft365UsageReport.UsageReport
{
    /// <summary>
    /// Class representing a Microsoft 365 usage report.
    /// </summary>
    public class Microsoft365UsageReport
    {
        /// <summary>
        /// Constructor for the Microsoft365UsageReport class.
        /// </summary>
        public Microsoft365UsageReport()
        {
            Format = Array.Empty<string>();
        }

        /// <summary>
        /// The name of the usage report.
        /// </summary>
        public string? Name { get; set; } = string.Empty;

        /// <summary>
        /// A brief description of the usage report.
        /// </summary>
        public string? Description { get; set; } = string.Empty;

        /// <summary>
        /// The utility or purpose of the report.
        /// </summary>
        public string? Utility { get; set; } = string.Empty;

        /// <summary>
        /// The associated service for the usage report.
        /// </summary>
        public string? Service { get; set; } = string.Empty;

        /// <summary>
        /// The type of the report.
        /// </summary>
        public string? Type { get; set; } = string.Empty;

        /// <summary>
        /// The version of the report.
        /// </summary>
        public string? Version { get; set; } = string.Empty;

        /// <summary>
        /// The output format(s) supported by the report.
        /// </summary>
        public string?[] Format { get; set; }

        /// <summary>
        /// The definition of the report containing detailed specifications.
        /// </summary>
        public Definition? Definition { get; set; }
    }
}
