#nullable enable
using System.Runtime.Serialization;
using PSMicrosoft365UsageReport.Interface;

namespace PSMicrosoft365UsageReport.Report
{
    /// <summary>
    /// Represents a report on the trend in the number of active users for each Microsoft 365 app (Outlook, Word, Excel, PowerPoint, OneNote, and Teams) within an organization.
    /// This includes details on the Report Refresh Date, report period, and active user counts by app.
    /// </summary>
    [DataContract]
    public class Microsoft365AppUserCounts : IReport
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Microsoft365AppUserCounts"/> class.
        /// </summary>
        public Microsoft365AppUserCounts() { }

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
        /// The count of active users for Outlook.
        /// </summary>
        [DataMember(Name = "Outlook")]
        public int? Outlook { get; set; }

        /// <summary>
        /// The count of active users for Word.
        /// </summary>
        [DataMember(Name = "Word")]
        public int? Word { get; set; }

        /// <summary>
        /// The count of active users for Excel.
        /// </summary>
        [DataMember(Name = "Excel")]
        public int? Excel { get; set; }

        /// <summary>
        /// The count of active users for PowerPoint.
        /// </summary>
        [DataMember(Name = "PowerPoint")]
        public int? PowerPoint { get; set; }

        /// <summary>
        /// The count of active users for OneNote.
        /// </summary>
        [DataMember(Name = "OneNote")]
        public int? OneNote { get; set; }

        /// <summary>
        /// The count of active users for Teams.
        /// </summary>
        [DataMember(Name = "Teams")]
        public int? Teams { get; set; }
    }
}
