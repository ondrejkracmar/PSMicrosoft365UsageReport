#nullable enable
using System.Runtime.Serialization;
using PSMicrosoft365UsageReport.Interface;

namespace PSMicrosoft365UsageReport.Report
{
    /// <summary>
    /// Represents detailed information about Microsoft 365 active users within an organization.
    /// This includes report refresh details, user-specific information, license statuses, last activity dates, and assigned product details for various services.
    /// </summary>
    [DataContract]
    public class Office365ActiveUserDetail : IReport
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Office365ActiveUserDetail"/> class.
        /// </summary>
        public Office365ActiveUserDetail() { }

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
        /// The unique identifier (UPN) of the user within the organization.
        /// </summary>
        [DataMember(Name = "UserPrincipalName")]
        public string? UserPrincipalName { get; set; }

        /// <summary>
        /// The display name of the user.
        /// </summary>
        [DataMember(Name = "DisplayName")]
        public string? DisplayName { get; set; }

        /// <summary>
        /// Indicates if the user has an Exchange license.
        /// </summary>
        [DataMember(Name = "HasExchangeLicense")]
        public string? HasExchangeLicense { get; set; }

        /// <summary>
        /// Indicates if the user has a OneDrive license.
        /// </summary>
        [DataMember(Name = "HasOneDriveLicense")]
        public string? HasOneDriveLicense { get; set; }

        /// <summary>
        /// Indicates if the user has a SharePoint license.
        /// </summary>
        [DataMember(Name = "HasSharePointLicense")]
        public string? HasSharePointLicense { get; set; }

        /// <summary>
        /// Indicates if the user has a Skype for Business license.
        /// </summary>
        [DataMember(Name = "HasSkypeForBusinessLicense")]
        public string? HasSkypeForBusinessLicense { get; set; }

        /// <summary>
        /// Indicates if the user has a Yammer license.
        /// </summary>
        [DataMember(Name = "HasYammerLicense")]
        public string? HasYammerLicense { get; set; }

        /// <summary>
        /// Indicates if the user has a Teams license.
        /// </summary>
        [DataMember(Name = "HasTeamsLicense")]
        public string? HasTeamsLicense { get; set; }

        /// <summary>
        /// The last date of activity in Exchange.
        /// </summary>
        [DataMember(Name = "ExchangeLastActivityDate")]
        public string? ExchangeLastActivityDate { get; set; }

        /// <summary>
        /// The last date of activity in OneDrive.
        /// </summary>
        [DataMember(Name = "OneDriveLastActivityDate")]
        public string? OneDriveLastActivityDate { get; set; }

        /// <summary>
        /// The last date of activity in SharePoint.
        /// </summary>
        [DataMember(Name = "SharePointLastActivityDate")]
        public string? SharePointLastActivityDate { get; set; }

        /// <summary>
        /// The last date of activity in Skype for Business.
        /// </summary>
        [DataMember(Name = "SkypeForBusinessLastActivityDate")]
        public string? SkypeForBusinessLastActivityDate { get; set; }

        /// <summary>
        /// The last date of activity in Yammer.
        /// </summary>
        [DataMember(Name = "YammerLastActivityDate")]
        public string? YammerLastActivityDate { get; set; }

        /// <summary>
        /// The last date of activity in Teams.
        /// </summary>
        [DataMember(Name = "TeamsLastActivityDate")]
        public string? TeamsLastActivityDate { get; set; }

        /// <summary>
        /// The date when the Exchange license was assigned.
        /// </summary>
        [DataMember(Name = "ExchangeLicenseAssignDate")]
        public string? ExchangeLicenseAssignDate { get; set; }

        /// <summary>
        /// The date when the OneDrive license was assigned.
        /// </summary>
        [DataMember(Name = "OneDriveLicenseAssignDate")]
        public string? OneDriveLicenseAssignDate { get; set; }

        /// <summary>
        /// The date when the SharePoint license was assigned.
        /// </summary>
        [DataMember(Name = "SharePointLicenseAssignDate")]
        public string? SharePointLicenseAssignDate { get; set; }

        /// <summary>
        /// The date when the Skype for Business license was assigned.
        /// </summary>
        [DataMember(Name = "SkypeForBusinessLicenseAssignDate")]
        public string? SkypeForBusinessLicenseAssignDate { get; set; }

        /// <summary>
        /// The date when the Yammer license was assigned.
        /// </summary>
        [DataMember(Name = "YammerLicenseAssignDate")]
        public string? YammerLicenseAssignDate { get; set; }

        /// <summary>
        /// The date when the Teams license was assigned.
        /// </summary>
        [DataMember(Name = "TeamsLicenseAssignDate")]
        public string? TeamsLicenseAssignDate { get; set; }

        /// <summary>
        /// The list of assigned products for the user.
        /// </summary>
        [DataMember(Name = "AssignedProducts")]
        public string? AssignedProducts { get; set; }
    }
}
