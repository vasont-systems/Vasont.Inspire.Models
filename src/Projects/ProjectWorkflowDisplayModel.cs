//---------------------------------------------------------------------------
// <copyright file="ProjectWorkflowDisplayModel.cs" company="GlobalLink Vasont">
// Copyright (c) GlobalLink Vasont. All rights reserved.
// </copyright>
//---------------------------------------------------------------------------
namespace Vasont.Inspire.Models.Projects
{
    using System;
    using Vasont.Inspire.Models.Security;
    using Vasont.Inspire.Models.Workflow;

    /// <summary>
    /// This class is a model representation of a project workflow display within the application.
    /// </summary>
    public class ProjectWorkflowDisplayModel
    {
        /// <summary>
        /// Gets or sets the identity of the associated project.
        /// </summary>
        public long ProjectId { get; set; }

        /// <summary>
        /// Gets or sets the identity of the project workflow.
        /// </summary>
        public long ProjectWorkflowId { get; set; }

        /// <summary>
        /// Gets or sets the identity of the associated review.
        /// </summary>
        public long ReviewId { get; set; }

        /// <summary>
        /// Gets or sets the name of the workflow.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the description of the workflow.
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets the current status of the workflow.
        /// </summary>
        public string Status { get; set; }

        /// <summary>
        /// Gets or sets the current state of the workflow.
        /// </summary>
        public WorkflowState State { get; set; }

        /// <summary>
        /// Gets or sets the type of workflow.
        /// </summary>
        public WorkflowType Type { get; set; }

        /// <summary>
        /// Gets or sets the date and time when the workflow was created.
        /// </summary>
        public DateTime CreatedDate { get; set; }

        /// <summary>
        /// Gets or sets the user model of the user who created the workflow.
        /// </summary>
        public MicroUserModel Owner { get; set; } = new MicroUserModel();

        /// <summary>
        /// Gets or sets the date and time when the workflow is due.
        /// </summary>
        public DateTime? DueDate { get; set; }

        /// <summary>
        /// Gets or sets the date and time when the workflow was completed.
        /// </summary>
        public DateTime? CompletedDate { get; set; }
    }
}