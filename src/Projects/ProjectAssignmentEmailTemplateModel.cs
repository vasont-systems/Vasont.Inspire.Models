//-----------------------------------------------------------------------------------
// <copyright file="ProjectAssignmentEmailTemplateModel.cs" company="GlobalLink Vasont">
// Copyright (c) GlobalLink Vasont. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------------------
namespace Vasont.Inspire.Models.Projects
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    /// <summary>
    /// Contains an enumerated list of assignment notification types
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum AssignmentNoticeType
    {
        /// <summary>
        /// New assignment notification.
        /// </summary>
        NewAssignment,

        /// <summary>
        /// Reassignment notification.
        /// </summary>
        Reassignment,

        /// <summary>
        /// Deleted assignment notification.
        /// </summary>
        DeletedAssignment,

        /// <summary>
        /// Completed assignment notification.
        /// </summary>
        CompletedAssignment,

        /// <summary>
        /// Cancelled assignment notification.
        /// </summary>
        CancelledAssignment,

        /// <summary>
        /// Created assignment notification.
        /// This is typically used to notify somebody other than the assignee about a created assignment.
        /// </summary>
        CreatedAssignment,

        /// <summary>
        /// Created assignment for a change request.
        /// This is used to notify any additional notification users that are specified on the assignment.
        /// </summary>
        CreatedChangeRequest,

        /// <summary>
        /// Completed assignment for a change request.
        /// This is used to notify any additional notification users that are specified on the assignment.
        /// </summary>
        CompletedChangeRequest,

        /// <summary>
        /// Cancelled assignment for a change request.
        /// This is used to notify any additional notification users that are specified on the assignment.
        /// </summary>
        CancelledChangeRequest,
    }

    /// <summary>
    /// This class contains the project assignment email template model.
    /// </summary>
    public class ProjectAssignmentEmailTemplateModel
    {
        /// <summary>
        /// Gets or sets the project assignment identity value.
        /// </summary>
        public long ProjectAssignmentId { get; set; }

        /// <summary>
        /// Gets or sets the assignment notice type.
        /// </summary>
        public AssignmentNoticeType AssignmentNoticeType { get; set; }

        /// <summary>
        /// Gets or sets the template name.
        /// </summary>
        public string TemplateName { get; set; }
    }
}
