#nullable enable
using System.Runtime.Serialization;
using PSMicrosoft365UsageReport.Interface;

namespace PSMicrosoft365UsageReport.Report
{
    /// <summary>
    /// Represents detailed information about users who have activated Microsoft 365 within an organization.
    /// This includes details on the Report Refresh Date, user information, product type, last activation date, and device/platform activations.
    /// </summary>
    [DataContract]
    public class Office365ActivationsUserDetail : IReport
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Office365ActivationsUserDetail"/> class.
        /// </summary>
        public Office365ActivationsUserDetail() { }

        /// <summary>
        /// The date when the report was last refreshed.
        /// </summary>
        [DataMember(Name = "Report Refresh Date")]
        public string? ReportRefreshDate { get; set; }

        /// <summary>
        /// The period covered by the report.
        /// </summary>
        [DataMember(Name = "Report Period")]
        public int? ReportPeriod { get; set; }

        /// <summary>
        /// The unique identifier (UPN) of the user within the organization.
        /// </summary>
        [DataMember(Name = "User Principal Name")]
        public string? UserPrincipalName { get; set; }

        /// <summary>
        /// The display name of the user.
        /// </summary>
        [DataMember(Name = "Display Name")]
        public string? DisplayName { get; set; }

        /// <summary>
        /// The type of Microsoft 365 product.
        /// </summary>
        [DataMember(Name = "Product Type")]
        public string? ProductType { get; set; }

        /// <summary>
        /// The last date on which the user activated the product.
        /// </summary>
        [DataMember(Name = "Last Activated Date")]
        public string? LastActivatedDate { get; set; }

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
        /// The count of activations on iOS devices.
        /// </summary>
        [DataMember(Name = "iOS")]
        public int? AppleiOS { get; set; }

        /// <summary>
        /// The count of activations on Windows 10 Mobile devices.
        /// </summary>
        [DataMember(Name = "Windows 10 Mobile")]
        public int? Windows10Mobile { get; set; }

        /// <summary>
        /// The count of activations on Android devices.
        /// </summary>
        [DataMember(Name = "Android")]
        public int? Android { get; set; }

        /// <summary>
        /// Indicates whether the product was activated on a shared computer.
        /// </summary>
        [DataMember(Name = "Activated On Shared Computer")]
        public string? ActivatedOnSharedComputer { get; set; }
    }
}
