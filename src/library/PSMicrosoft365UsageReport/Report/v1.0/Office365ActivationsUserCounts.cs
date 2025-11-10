#nullable enable
using System.Runtime.Serialization;
using PSMicrosoft365UsageReport.Interface;

namespace PSMicrosoft365UsageReport.Report
{
    /// <summary>
    /// Represents the count of users that are enabled and those that have activated the Office subscription on desktop or devices or shared computers within an organization.
    /// This includes details on the Report Refresh Date, product type, assigned licenses, activations, and shared computer activations.
    /// </summary>
    [DataContract]
    public class Office365ActivationsUserCounts : IReport
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Office365ActivationsUserCounts"/> class.
        /// </summary>
        public Office365ActivationsUserCounts() { }

        /// <summary>
        /// The date when the report was last refreshed.
        /// </summary>
        [DataMember(Name = "ReportRefreshDate")]
        public string? ReportRefreshDate { get; set; }

        /// <summary>
        /// The period covered by the report.
        /// </summary>
        [DataMember(Name = "ReportPeriod")]
        public int? ReportPeriod { get; set; }

        /// <summary>
        /// The type of Microsoft365 product.
        /// </summary>
        [DataMember(Name = "ProductType")]
        public string? ProductType { get; set; }

        /// <summary>
        /// The count of users assigned an Office subscription.
        /// </summary>
        [DataMember(Name = "Assigned")]
        public int? Assigned { get; set; }

        /// <summary>
        /// The count of users who have activated the Office subscription.
        /// </summary>
        [DataMember(Name = "Activated")]
        public int? Activated { get; set; }

        /// <summary>
        /// The count of shared computer activations.
        /// </summary>
        [DataMember(Name = "SharedComputerActivation")]
        public int? SharedComputerActivation { get; set; }
    }
}
