//-----------------------------------------------------------------------
// <copyright file="MicroProjectAssignmentModel.cs" company="GlobalLink Vasont">
// Copyright (c) GlobalLink Vasont. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------
namespace Vasont.Inspire.Models.Projects
{
    using System;
    using System.Collections.Generic;
    using Vasont.Inspire.Models.Components;
    using Vasont.Inspire.Models.Security;

    /// <summary>
    /// This class contains the absolute minimum values for a project assignment for user interface usage.
    /// </summary>
    public class MicroProjectAssignmentModel
    {
        /// <summary>
        /// Gets or sets the project assignment identity value.
        /// </summary>
        public long ProjectAssignmentId { get; set; }

        /// <summary>
        /// Gets or sets the associated project.
        /// </summary>
        public MinimalProjectModel Project { get; set; }

        /// <summary>
        /// Gets or sets the assignment state name.
        /// </summary>
        public MicroProjectAssignmentStateModel State { get; set; }

        /// <summary>
        /// Gets or sets the model of the assigned user.
        /// </summary>
        public MicroUserModel AssignedUser { get; set; }

        /// <summary>
        /// Gets or sets the assignment due date.
        /// </summary>
        public DateTime? DueDate { get; set; }

        /// <summary>
        /// Gets or sets the assignment created date.
        /// </summary>
        public DateTime? CreatedDate { get; set; }

        /// <summary>
        /// Gets or sets the project assignment description.
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the assignment has active workflow.
        /// </summary>
        public bool RequiresInput { get; set; }

        /// <summary>
        /// Gets or sets the optional workflow name.
        /// </summary>
        public string WorkflowName { get; set; }

        /// <summary>
        /// Gets or sets the project workflow submittal model.
        /// </summary>
        public ProjectWorkflowSubmittalModel ProjectWorkflowSubmittal { get; set; }

        /// <summary>
        /// Gets or sets the project activity information.
        /// </summary>
        public MinimalProjectActivityModel ProjectActivity { get; set; }

        /// <summary>
        /// Gets or sets a list of components associated with the assignment.
        /// </summary>
        public List<MicroComponentModel> Components { get; set; } = new List<MicroComponentModel>();
    }
}