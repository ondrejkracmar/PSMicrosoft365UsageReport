#nullable enable
using System.Runtime.Serialization;
using PSMicrosoft365UsageReport.Interface;

namespace PSMicrosoft365UsageReport.Report
{
    /// <summary>
    /// Represents detailed email activity data for individual users within an organization. 
    /// This includes information on the last Report Refresh Date, report period, and specific 
    /// user activity details such as sending and receiving email counts and user information.
    /// </summary>
    [DataContract]
    public class EmailActivityUserDetail : IReport
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EmailActivityUserDetail"/> class.
        /// </summary>
        public EmailActivityUserDetail() { }

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
        /// The last date on which the user performed an activity.
        /// </summary>
        [DataMember(Name = "Last Activity Date")]
        public string? LastActivityDate { get; set; }

        /// <summary>
        /// The count of emails sent by the user.
        /// </summary>
        [DataMember(Name = "Send Count")]
        public int? SendCount { get; set; }

        /// <summary>
        /// The count of emails received by the user.
        /// </summary>
        [DataMember(Name = "Receive Count")]
        public int? ReceiveCount { get; set; }
    }
}
