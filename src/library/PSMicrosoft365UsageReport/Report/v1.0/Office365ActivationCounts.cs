#nullable enable
using System.Runtime.Serialization;
using PSMicrosoft365UsageReport.Interface;

namespace PSMicrosoft365UsageReport.Report
{
    /// <summary>
    /// Represents the count of Microsoft 365 activations on various platforms and devices within an organization.
    /// This includes details on the Report Refresh Date, product type, and activation counts by platform (Windows, Mac, Android, iOS, and Windows 10 Mobile).
    /// </summary>
    [DataContract]
    public class Office365ActivationCounts : IReport
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Office365ActivationCounts"/> class.
        /// </summary>
        public Office365ActivationCounts() { }

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
        /// The type of Microsoft 365 product.
        /// </summary>
        [DataMember(Name = "ProductType")]
        public string? ProductType { get; set; }

        /// <summary>
        /// The count of activations on Windows devices.
        /// </summary>
        [DataMember(Name = "Windows")]
        public int? Windows { get; set; }

        /// <summary>
        /// The count of activations on Mac devices.
        /// </summary>
        [DataMember(Name = "Mac")]
        public int? Mac { get; set; }

        /// <summary>
        /// The count of activations on Android devices.
        /// </summary>
        [DataMember(Name = "Android")]
        public int? Android { get; set; }

        /// <summary>
        /// The count of activations on iOS devices.
        /// </summary>
        [DataMember(Name = "AppleiOS")]
        public int? AppleiOS { get; set; }

        /// <summary>
        /// The count of activations on Windows 10 Mobile devices.
        /// </summary>
        [DataMember(Name = "Windows10Mobile")]
        public int? Windows10Mobile { get; set; }
    }
}
