#nullable enable
using System.Runtime.Serialization;
using PSMicrosoft365UsageReport.Interface;

namespace PSMicrosoft365UsageReport.Report
{
    /// <summary>
    /// Represents the number of group activities across various group workloads within an organization.
    /// This includes details on the Report Refresh Date, reporting period, and activity counts for services such as Exchange and Yammer.
    /// </summary>
    [DataContract]
    public class Office365GroupsActivityCounts : IReport
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Office365GroupsActivityCounts"/> class.
        /// </summary>
        public Office365GroupsActivityCounts() { }

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
        /// The count of emails received by groups in Exchange.
        /// </summary>
        [DataMember(Name = "Exchange Emails Received")]
        public int? ExchangeEmailsReceived { get; set; }

        /// <summary>
        /// The count of messages posted in Yammer groups.
        /// </summary>
        [DataMember(Name = "Yammer Messages Posted")]
        public int? YammerMessagesPosted { get; set; }

        /// <summary>
        /// The count of messages read in Yammer groups.
        /// </summary>
        [DataMember(Name = "Yammer Messages Read")]
        public int? YammerMessagesRead { get; set; }

        /// <summary>
        /// The count of messages liked in Yammer groups.
        /// </summary>
        [DataMember(Name = "Yammer Messages Liked")]
        public int? YammerMessagesLiked { get; set; }
    }
}
