using System.Runtime.Serialization;
using PSMicrosoft365UsageReport.Interface;

namespace PSMicrosoft365UsageReport.Report.Beta
{
    /// <summary>
    /// Class representing the response data for the Office365ActivationCounts report.
    /// Implements the <see cref="IReport"/> interface.
    /// </summary>
    public class Office365ActivationCounts : IReport
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Office365ActivationCounts"/> class.
        /// </summary>
        public Office365ActivationCounts()
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
        /// The count of activations on Windows devices, represented as a nullable integer.
        /// </summary>
        public int? Windows { get; set; }

        /// <summary>
        /// The count of activations on Mac devices, represented as a nullable integer.
        /// </summary>
        public int? Mac { get; set; }

        /// <summary>
        /// The count of activations on Android devices, represented as a nullable integer.
        /// </summary>
        public int? Android { get; set; }

        /// <summary>
        /// The count of activations on iOS devices, represented as a nullable integer.
        /// </summary>
        public int? iOS { get; set; }

        /// <summary>
        /// The count of activations on Windows 10 Mobile devices, represented as a nullable integer.
        /// </summary>
        public int? Windows10Mobile { get; set; }
    }
}
