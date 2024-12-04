using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSMicrosoft365UsageReport.UsageReport
{
    /// <summary>
    /// Class representing the definition of a usage report.
    /// </summary>
    public class Definition
    {
        /// <summary>
        /// Constructor for the Definition class.
        /// </summary>
        public Definition()
        {
            ResponseProperty = Array.Empty<ResponseProperty>();
        }

        /// <summary>
        /// The name of the function that this definition represents.
        /// </summary>
        public string? Function { get; set; } = string.Empty;

        /// <summary>
        /// Parameters for this definition.
        /// </summary>
        public Parameters? Parameters { get; set; }

        /// <summary>
        /// Response properties for this definition.
        /// </summary>
        public ResponseProperty[] ResponseProperty { get; set; }
    }
}
