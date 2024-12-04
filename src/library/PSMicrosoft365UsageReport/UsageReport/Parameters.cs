using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSMicrosoft365UsageReport.UsageReport
{
    /// <summary>
    /// Class representing the parameters for a usage report.
    /// </summary>
    public class Parameters
    {
        /// <summary>
        /// Constructor for the Parameters class.
        /// </summary>
        public Parameters()
        {
            Days = Array.Empty<string>();
        }

        /// <summary>
        /// Array of days included in the report.
        /// </summary>
        public string[] Days { get; set; }

        /// <summary>
        /// Specific date for the report.
        /// </summary>
        public string? Date { get; set; } = string.Empty;
    }
}
