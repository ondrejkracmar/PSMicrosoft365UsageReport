#nullable enable
using System.Runtime.Serialization;
using PSMicrosoft365UsageReport.Interface;

namespace PSMicrosoft365UsageReport.Report.Beta
{
    /// <summary>
    /// Class representing the response data for the Office365ActiveUserDetail report.
    /// Implements the <see cref="IReport"/> interface.
    /// </summary>
    public class Office365ActiveUserDetail : IReport
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Office365ActiveUserDetail"/> class.
        /// </summary>
        public Office365ActiveUserDetail()
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
        /// The user principal name (UPN) of the user, represented as a nullable string.
        /// </summary>
        public string? UserPrincipalName { get; set; }

        /// <summary>
        /// The display name of the user, represented as a nullable string.
        /// </summary>
        public string? DisplayName { get; set; }

        /// <summary>
        /// Indicates whether the user has an Exchange license, represented as a nullable boolean.
        /// </summary>
        public string? HasExchangeLicense { get; set; }

        /// <summary>
        /// Indicates whether the user has a OneDrive license, represented as a nullable boolean.
        /// </summary>
        public string? HasOneDriveLicense { get; set; }

        /// <summary>
        /// Indicates whether the user has a SharePoint license, represented as a nullable boolean.
        /// </summary>
        public string? HasSharePointLicense { get; set; }

        /// <summary>
        /// Indicates whether the user has a Skype for Business license, represented as a nullable boolean.
        /// </summary>
        public string? HasSkypeForBusinessLicense { get; set; }

        /// <summary>
        /// Indicates whether the user has a Yammer license, represented as a nullable boolean.
        /// </summary>
        public string? HasYammerLicense { get; set; }

        /// <summary>
        /// Indicates whether the user has a Teams license, represented as a nullable boolean.
        /// </summary>
        public string? HasTeamsLicense { get; set; }

        /// <summary>
        /// The last activity date for Exchange, represented as a nullable string.
        /// </summary>
        public string? ExchangeLastActivityDate { get; set; }

        /// <summary>
        /// The last activity date for OneDrive, represented as a nullable string.
        /// </summary>
        public string? OneDriveLastActivityDate { get; set; }

        /// <summary>
        /// The last activity date for SharePoint, represented as a nullable string.
        /// </summary>
        public string? SharePointLastActivityDate { get; set; }

        /// <summary>
        /// The last activity date for Skype for Business, represented as a nullable string.
        /// </summary>
        public string? SkypeForBusinessLastActivityDate { get; set; }

        /// <summary>
        /// The last activity date for Yammer, represented as a nullable string.
        /// </summary>
        public string? YammerLastActivityDate { get; set; }

        /// <summary>
        /// The last activity date for Teams, represented as a nullable string.
        /// </summary>
        public string? TeamsLastActivityDate { get; set; }

        /// <summary>
        /// The license assign date for Exchange, represented as a nullable string.
        /// </summary>
        public string? ExchangeLicenseAssignDate { get; set; }

        /// <summary>
        /// The license assign date for OneDrive, represented as a nullable string.
        /// </summary>
        public string? OneDriveLicenseAssignDate { get; set; }

        /// <summary>
        /// The license assign date for SharePoint, represented as a nullable string.
        /// </summary>
        public string? SharePointLicenseAssignDate { get; set; }

        /// <summary>
        /// The license assign date for Skype for Business, represented as a nullable string.
        /// </summary>
        public string? SkypeForBusinessLicenseAssignDate { get; set; }

        /// <summary>
        /// The license assign date for Yammer, represented as a nullable string.
        /// </summary>
        public string? YammerLicenseAssignDate { get; set; }

        /// <summary>
        /// The license assign date for Teams, represented as a nullable string.
        /// </summary>
        public string? TeamsLicenseAssignDate { get; set; }

        /// <summary>
        /// The list of products assigned to the user, represented as a nullable string.
        /// </summary>
        public string[]? AssignedProducts { get; set; }
    }
}
