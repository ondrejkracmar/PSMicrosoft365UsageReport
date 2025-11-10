#nullable enable
using System.Runtime.Serialization;
using PSMicrosoft365UsageReport.Interface;

namespace PSMicrosoft365UsageReport.Report
{
    /// <summary>
    /// Represents the count of users by activity type (active or inactive) for various Office 365 services within an organization.
    /// This includes details on the Report Refresh Date, reporting period, and user activity counts for services like Exchange, OneDrive, SharePoint, Skype for Business, Yammer, Teams, and Office 365.
    /// </summary>
    [DataContract]
    public class Office365ServicesUserCounts : IReport
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Office365ServicesUserCounts"/> class.
        /// </summary>
        public Office365ServicesUserCounts() { }

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
        /// The count of active users in Exchange.
        /// </summary>
        [DataMember(Name = "ExchangeActive")]
        public int? ExchangeActive { get; set; }

        /// <summary>
        /// The count of inactive users in Exchange.
        /// </summary>
        [DataMember(Name = "ExchangeInactive")]
        public int? ExchangeInactive { get; set; }

        /// <summary>
        /// The count of active users in OneDrive.
        /// </summary>
        [DataMember(Name = "OneDriveActive")]
        public int? OneDriveActive { get; set; }

        /// <summary>
        /// The count of inactive users in OneDrive.
        /// </summary>
        [DataMember(Name = "OneDriveInactive")]
        public int? OneDriveInactive { get; set; }

        /// <summary>
        /// The count of active users in SharePoint.
        /// </summary>
        [DataMember(Name = "SharePointActive")]
        public int? SharePointActive { get; set; }

        /// <summary>
        /// The count of inactive users in SharePoint.
        /// </summary>
        [DataMember(Name = "SharePointInactive")]
        public int? SharePointInactive { get; set; }

        /// <summary>
        /// The count of active users in Skype for Business.
        /// </summary>
        [DataMember(Name = "SkypeForBusinessActive")]
        public int? SkypeForBusinessActive { get; set; }

        /// <summary>
        /// The count of inactive users in Skype for Business.
        /// </summary>
        [DataMember(Name = "SkypeForBusinessInactive")]
        public int? SkypeForBusinessInactive { get; set; }

        /// <summary>
        /// The count of active users in Yammer.
        /// </summary>
        [DataMember(Name = "YammerActive")]
        public int? YammerActive { get; set; }

        /// <summary>
        /// The count of inactive users in Yammer.
        /// </summary>
        [DataMember(Name = "YammerInactive")]
        public int? YammerInactive { get; set; }

        /// <summary>
        /// The count of active users in Teams.
        /// </summary>
        [DataMember(Name = "TeamsActive")]
        public int? TeamsActive { get; set; }

        /// <summary>
        /// The count of inactive users in Teams.
        /// </summary>
        [DataMember(Name = "TeamsInactive")]
        public int? TeamsInactive { get; set; }

        /// <summary>
        /// The count of active users in Office 365.
        /// </summary>
        [DataMember(Name = "Office365Active")]
        public int? Office365Active { get; set; }

        /// <summary>
        /// The count of inactive users in Office 365.
        /// </summary>
        [DataMember(Name = "Office365Inactive")]
        public int? Office365Inactive { get; set; }
    }
}
