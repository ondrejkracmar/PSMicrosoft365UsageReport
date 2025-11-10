#nullable enable
using System.Runtime.Serialization;
using PSMicrosoft365UsageReport.Interface;

namespace PSMicrosoft365UsageReport.Report
{
    /// <summary>
    /// Represents the count of unique users performing email activities within an organization, 
    /// including data on report refresh, report date, report period, and specific activities like 
    /// sending, receiving, and reading emails, as well as meeting-related interactions.
    /// </summary>
    [DataContract]
    public class EmailActivityUserCounts : IReport
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EmailActivityUserCounts"/> class.
        /// </summary>
        public EmailActivityUserCounts() { }

        /// <summary>
        /// The date when the report was last refreshed.
        /// </summary>
        [DataMember(Name = "ReportRefreshDate")]
        public string? ReportRefreshDate { get; set; }

        /// <summary>
        /// The date associated with the report.
        /// </summary>
        [DataMember(Name = "ReportDate")]
        public string? ReportDate { get; set; }

        /// <summary>
        /// The period covered by the report.
        /// </summary>
        [DataMember(Name = "ReportPeriod")]
        public int? ReportPeriod { get; set; }

        /// <summary>
        /// Indicates the count of unique users who sent emails.
        /// </summary>
        [DataMember(Name = "Send")]
        public int? Send { get; set; }

        /// <summary>
        /// Indicates the count of unique users who received emails.
        /// </summary>
        [DataMember(Name = "Receive")]
        public int? Receive { get; set; }

        /// <summary>
        /// Indicates the count of unique users who read emails.
        /// </summary>
        [DataMember(Name = "Read")]
        public int? Read { get; set; }

        /// <summary>
        /// Data on the number or details of meetings created by unique users.
        /// </summary>
        [DataMember(Name = "MeetingCreated")]
        public int? MeetingCreated { get; set; }

        /// <summary>
        /// Data on interactions with created meetings by unique users.
        /// </summary>
        [DataMember(Name = "MeetingInteracted")]
        public int? MeetingInteracted { get; set; }
    }
}
