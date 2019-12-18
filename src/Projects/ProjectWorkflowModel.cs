//--------------------------------------------------------------------
// <copyright file="ProjectWorkflowModel.cs" company="GlobalLink Vasont">
// Copyright (c) GlobalLink Vasont. All rights reserved.
// </copyright>
//--------------------------------------------------------------------
namespace Vasont.Inspire.Models.Projects
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Vasont.Inspire.Core.Extensions;
    using Vasont.Inspire.Models.Components;
    using Vasont.Inspire.Models.Security;
    using Vasont.Inspire.Models.Workflow;

    /// <summary>
    /// This class is a model representation of a project workflow within the application.
    /// </summary>
    public class ProjectWorkflowModel
    {
        /// <summary>
        /// Gets or sets the identity of the project workflow.
        /// </summary>
        public long ProjectWorkflowId { get; set; }

        /// <summary>
        /// Gets or sets the identity of the associated project.
        /// </summary>
        public long ProjectId { get; set; }

        /// <summary>
        /// Gets or sets the identity of the associated workflow model.
        /// </summary>
        public WorkflowModel WorkflowModel { get; set; } = new WorkflowModel();

        /// <summary>
        /// Gets or sets the name of the project workflow.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the description of the project workflow.
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets the name of the template that the project workflow was created from.
        /// </summary>
        public string TemplateName { get; set; }

        /// <summary>
        /// Gets or sets the current status of the workflow.
        /// </summary>
        public string Status { get; set; }

        /// <summary>
        /// Gets or sets the current state of the workflow.
        /// </summary>
        public WorkflowState State { get; set; }

        /// <summary>
        /// Gets or sets the state via text string.
        /// </summary>
        [JsonIgnore]
        public string StateText
        {
            get => this.State.ToString();
            set => this.State = value.ToEnum<WorkflowState>();
        }

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

        /// <summary>
        /// Gets or sets the identity of the workflow activity to initiate for a new project workflow.
        /// </summary>
        public string InitialActivityId { get; set; }

        /// <summary>
        /// Gets or sets the identity of the user for workflow activity to initiate for a new project workflow.
        /// </summary>
        public long InitialActivityUserId { get; set; }

        /// <summary>
        /// Gets or sets the components that will be applied to the initial project assignment.
        /// </summary>
        public List<MinimalComponentModel> InitialComponents { get; set; } = new List<MinimalComponentModel>();

        /// <summary>
        /// Gets or sets a list of project assignment workflow submittals.
        /// </summary>
        public List<ProjectWorkflowSubmittalModel> Submittals { get; set; } = new List<ProjectWorkflowSubmittalModel>();
    }
}