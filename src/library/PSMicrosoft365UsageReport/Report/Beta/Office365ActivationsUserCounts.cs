#nullable enable
using System.Runtime.Serialization;
using PSMicrosoft365UsageReport.Interface;

namespace PSMicrosoft365UsageReport.Report.Beta
{
    /// <summary>
    /// Class representing the response data for the Office365ActivationsUserCounts report.
    /// Implements the <see cref="IReport"/> interface.
    /// </summary>
    public class Office365ActivationsUserCounts : IReport
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Office365ActivationsUserCounts"/> class.
        /// </summary>
        public Office365ActivationsUserCounts()
        {
        }

        /// <summary>
        /// The date when the report was last refreshed, represented as a nullable string.
        /// </summary>
        public string? ReportRefreshDate { get; set; }

        /// <summary>
        /// The period covered by the report in days, represented as a nullable integer.
        /// </summary>
        public int? ReportPeriod { get; set; }

        /// <summary>
        /// The type of product for which the activation count is reported, represented as a nullable string.
        /// </summary>
        public string? ProductType { get; set; }

        /// <summary>
        /// The count of users assigned with the product, represented as a nullable integer.
        /// </summary>
        public int? Assigned { get; set; }

        /// <summary>
        /// The count of users who activated the product, represented as a nullable integer.
        /// </summary>
        public int? Activated { get; set; }

        /// <summary>
        /// The count of activations using shared computer activation, represented as a nullable integer.
        /// </summary>
        public int? SharedComputerActivation { get; set; }
    }
}
