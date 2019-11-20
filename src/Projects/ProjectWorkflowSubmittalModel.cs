//----------------------------------------------------------------------------
// <copyright file="ProjectWorkflowSubmittalModel.cs" company="Vasont Systems">
// Copyright (c) Vasont Systems. All rights reserved.
// </copyright>
//----------------------------------------------------------------------------
namespace Vasont.Inspire.Models.Projects
{
    using System;
    using System.Collections.Generic;
    using Vasont.Inspire.Models.Security;
    using Vasont.Inspire.Models.Workflow;

    /// <summary>
    /// This class is a model representation of a project workflow submittal within the application.
    /// </summary>
    public class ProjectWorkflowSubmittalModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectWorkflowSubmittalModel"/> class.
        /// </summary>
        public ProjectWorkflowSubmittalModel()
        {
            this.Transitions = new List<WorkflowNextTransitionModel>();
            this.ProjectAssignmentIds = new List<long>();
            this.AssignedUser = new MicroUserModel();
        }

        /// <summary>
        /// Gets or sets the identity of the project workflow submittal.
        /// </summary>
        public long ProjectWorkflowSubmittalId { get; set; }

        /// <summary>
        /// Gets or sets the identity of the associated project workflow.
        /// </summary>
        public long ProjectWorkflowId { get; set; }

        /// <summary>
        /// Gets or sets a list of project assignment identities associated with the submittal.
        /// </summary>
        public List<long> ProjectAssignmentIds { get; set; }

        /// <summary>
        /// Gets or sets the assigned user.
        /// </summary>
        public MicroUserModel AssignedUser { get; set; }

        /// <summary>
        /// Gets or sets the identity of the workflow activity.
        /// </summary>
        public string WorkflowActivityId { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the submittal requires user input.
        /// </summary>
        public bool RequiresInput { get; set; }

        /// <summary>
        /// Gets or sets the name of the workflow activity.
        /// </summary>
        public string WorkflowActivityName { get; set; }

        /// <summary>
        /// Gets or sets the date and time that the workflow activity was completed.
        /// </summary>
        public DateTime? CompletedDate { get; set; }

        /// <summary>
        /// Gets or sets the date and time when the workflow activity was created.
        /// </summary>
        public DateTime CreatedDate { get; set; }

        /// <summary>
        /// Gets or sets the identity of the transition to initiate when this activity completes.
        /// </summary>
        public string NextTransitionId { get; set; }

        /// <summary>
        /// Gets or sets the identity of the user who will be assigned to the next activity.
        /// </summary>
        public long NextTransitionUserId { get; set; }

        /// <summary>
        /// Gets or sets a list of transitions that can occur after the current activity is completed.
        /// </summary>
        public List<WorkflowNextTransitionModel> Transitions { get; set; }
    }
}
