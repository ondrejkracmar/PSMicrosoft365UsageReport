#nullable enable
using System.Runtime.Serialization;
using PSMicrosoft365UsageReport.Interface;

namespace PSMicrosoft365UsageReport.Report
{
    /// <summary>
    /// Represents email activity counts within an organization, including data on report refresh,
    /// report date, report period, and activity details such as sending, receiving, and reading emails,
    /// as well as meeting-related interactions.
    /// </summary>
    [DataContract]
    public class EmailActivityCounts : IReport
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EmailActivityCounts"/> class.
        /// </summary>
        public EmailActivityCounts() { }

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
        /// Indicates data related to sending actions.
        /// </summary>
        [DataMember(Name = "Send")]
        public int? Send { get; set; }

        /// <summary>
        /// Indicates data related to receiving actions.
        /// </summary>
        [DataMember(Name = "Receive")]
        public int? Receive { get; set; }

        /// <summary>
        /// Indicates data related to reading actions.
        /// </summary>
        [DataMember(Name = "Read")]
        public int? Read { get; set; }

        /// <summary>
        /// Data on the number or details of created meetings.
        /// </summary>
        [DataMember(Name = "Meeting Created")]
        public int? MeetingCreated { get; set; }

        /// <summary>
        /// Data on the interactions with created meetings.
        /// </summary>
        [DataMember(Name = "Meeting Interacted")]
        public int? MeetingInteracted { get; set; }
    }
}
