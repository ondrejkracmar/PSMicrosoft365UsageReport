using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSMicrosoft365UsageReport.UsageReport
{
    /// <summary>
    /// Class representing a response property in a usage report.
    /// </summary>
    public class ResponseProperty
    {
        /// <summary>
        /// Constructor for the ResponseProperty class.
        /// </summary>
        public ResponseProperty()
        {

        }

        /// <summary>
        /// The name of the response property.
        /// </summary>
        public string? Name { get; set; } = string.Empty;

        /// <summary>
        /// The expression or formula used in the response property.
        /// </summary>
        public string? Expression { get; set; } = string.Empty;
    }
}
