#nullable enable
using System.Runtime.Serialization;
using PSMicrosoft365UsageReport.Interface;

namespace PSMicrosoft365UsageReport.Report
{
    /// <summary>
    /// Represents the count of daily active users within the reporting period for various Office 365 products.
    /// This includes details on the Report Refresh Date, reporting period, and daily active user counts by product (Office 365, Exchange, OneDrive, etc.).
    /// </summary>
    [DataContract]
    public class Office365ActiveUserCounts : IReport
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Office365ActiveUserCounts"/> class.
        /// </summary>
        public Office365ActiveUserCounts() { }

        /// <summary>
        /// The date when the report was last refreshed.
        /// </summary>
        [DataMember(Name = "Report Refresh Date")]
        public string? ReportRefreshDate { get; set; }

        /// <summary>
        /// The date associated with the report.
        /// </summary>
        [DataMember(Name = "Report Date")]
        public string? ReportDate { get; set; }

        /// <summary>
        /// The period covered by the report.
        /// </summary>
        [DataMember(Name = "Report Period")]
        public int? ReportPeriod { get; set; }

        /// <summary>
        /// The count of daily active users for Office 365.
        /// </summary>
        [DataMember(Name = "Office 365")]
        public int? Office365 { get; set; }

        /// <summary>
        /// The count of daily active users for Exchange.
        /// </summary>
        [DataMember(Name = "Exchange")]
        public int? Exchange { get; set; }

        /// <summary>
        /// The count of daily active users for OneDrive.
        /// </summary>
        [DataMember(Name = "OneDrive")]
        public int? OneDrive { get; set; }

        /// <summary>
        /// The count of daily active users for SharePoint.
        /// </summary>
        [DataMember(Name = "SharePoint")]
        public int? SharePoint { get; set; }

        /// <summary>
        /// The count of daily active users for Skype for Business.
        /// </summary>
        [DataMember(Name = "Skype For Business")]
        public int? SkypeForBusiness { get; set; }

        /// <summary>
        /// The count of daily active users for Yammer.
        /// </summary>
        [DataMember(Name = "Yammer")]
        public int? Yammer { get; set; }

        /// <summary>
        /// The count of daily active users for Teams.
        /// </summary>
        [DataMember(Name = "Teams")]
        public int? Teams { get; set; }
    }
}
