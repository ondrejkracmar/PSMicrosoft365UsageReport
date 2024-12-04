using System.Runtime.Serialization;
using PSMicrosoft365UsageReport.Interface;

namespace PSMicrosoft365UsageReport.Report.Beta
{
    /// <summary>
    /// Class representing the response data for the EmailActivityUserDetail report.
    /// Implements the <see cref="IReport"/> interface.
    /// </summary>
    public class EmailActivityUserDetail : IReport
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EmailActivityUserDetail"/> class.
        /// </summary>
        public EmailActivityUserDetail()
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
        /// Indicates whether the user is deleted, represented as a nullable boolean.
        /// </summary>
        public string? IsDeleted { get; set; }

        /// <summary>
        /// The date the user was deleted, represented as a nullable string.
        /// </summary>
        public string? DeletedDate { get; set; }

        /// <summary>
        /// The date of the user's last activity, represented as a nullable string.
        /// </summary>
        public string? LastActivityDate { get; set; }

        /// <summary>
        /// The count of emails sent by the user, represented as a nullable integer.
        /// </summary>
        public int? SendCount { get; set; }

        /// <summary>
        /// The count of emails received by the user, represented as a nullable integer.
        /// </summary>
        public int? ReceiveCount { get; set; }

        /// <summary>
        /// The count of emails read by the user, represented as a nullable integer.
        /// </summary>
        public int? ReadCount { get; set; }

        /// <summary>
        /// The count of meetings created by the user, represented as a nullable integer.
        /// </summary>
        public int? MeetingCreatedCount { get; set; }

        /// <summary>
        /// The count of meetings interacted with by the user, represented as a nullable integer.
        /// </summary>
        public int? MeetingInteractedCount { get; set; }

        /// <summary>
        /// The assigned products for the user, represented as a nullable string.
        /// </summary>
        public string[]? AssignedProducts { get; set; }
    }
}
