//-----------------------------------------------------------------------
// <copyright file="ProjectAssignmentModel.cs" company="GlobalLink Vasont">
// Copyright (c) GlobalLink Vasont. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------
namespace Vasont.Inspire.Models.Projects
{
    using System;
    using System.Collections.Generic;
    using Security;
    using Vasont.Inspire.Models.Components;

    /// <summary>
    /// This class represents a project assignment within the application.
    /// </summary>
    public class ProjectAssignmentModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectAssignmentModel"/> class.
        /// </summary>
        public ProjectAssignmentModel()
        {
            this.Components = new List<MinimalComponentModel>();
            this.EmailTemplates = new List<ProjectAssignmentEmailTemplateModel>();
            this.CreatedDate = DateTime.UtcNow;
            this.UpdatedDate = DateTime.UtcNow;
        }

        /// <summary>
        /// Gets or sets the project assignment identity value.
        /// </summary>
        public long ProjectAssignmentId { get; set; }

        /// <summary>
        /// Gets or sets the associated project identity value.
        /// </summary>
        public long ProjectId { get; set; }

        /// <summary>
        /// Gets or sets the associated project title value.
        /// </summary>
        public string ProjectTitle { get; set; }

        /// <summary>
        /// Gets or sets a related project assignment activity object.
        /// </summary>
        public ProjectActivityModel ProjectActivity { get; set; }

        /// <summary>
        /// Gets or sets the date time when the assignment should start.
        /// </summary>
        public DateTime? StartByDate { get; set; }

        /// <summary>
        /// Gets or sets the date time when the assignment actually started.
        /// </summary>
        public DateTime? ActualStartDate { get; set; }

        /// <summary>
        /// Gets or sets the date time when the assignment should be completed.
        /// </summary>
        public DateTime? CompleteByDate { get; set; }

        /// <summary>
        /// Gets or sets the date time when the assignment was completed.
        /// </summary>
        public DateTime? ActualCompletionDate { get; set; }

        /// <summary>
        /// Gets or sets a value containing the assignment state.
        /// </summary>
        public ProjectAssignmentStateModel State { get; set; }

        /// <summary>
        /// Gets or sets a date time indicating when the assignment is due.
        /// </summary>
        public DateTime? DueDate { get; set; }

        /// <summary>
        /// Gets or sets the project assignment description.
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether there's active workflow.
        /// </summary>
        public bool RequiresInput { get; set; }

        /// <summary>
        /// Gets or sets the name of the workflow associated with the assignment.
        /// </summary>
        public string WorkflowName { get; set; }

        /// <summary>
        /// Gets or sets a date time when the assignment was created.
        /// </summary>
        public DateTime CreatedDate { get; set; }

        /// <summary>
        /// Gets or sets a date time when the assignment was last updated.
        /// </summary>
        public DateTime UpdatedDate { get; set; }

        /// <summary>
        /// Gets or sets the model of the user who assigned to the assignment.
        /// </summary>
        public MinimalUserModel UpdatedBy { get; set; }

        /// <summary>
        /// Gets or sets the model of the user who last updated the record.
        /// </summary>
        public MinimalUserModel AssignedUser { get; set; }

        /// <summary>
        /// Gets or sets a list of <see cref="MinimalComponentModel"/> objects representing components assigned to the assignment.
        /// </summary>
        public List<MinimalComponentModel> Components { get; set; }

        /// <summary>
        /// Gets or sets a string of semicolon delimited e-mail addresses that are added to 
        /// the completion and cancellation notification e-mails related to this assignment.
        /// </summary>
        public string AdditionalNotificationEmails { get; set; }

        /// <summary>
        /// Gets or sets a list of alternate email templates to be used with additional notifications;
        /// </summary>
        public List<ProjectAssignmentEmailTemplateModel> EmailTemplates { get; set; }

        /// <summary>
        /// Gets or sets the project workflow submittal that is associated with this assignment. 
        /// </summary>
        public ProjectWorkflowSubmittalModel ProjectWorkflowSubmittal { get; set; }
    }
}