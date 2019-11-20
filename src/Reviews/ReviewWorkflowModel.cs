//-------------------------------------------------------------------
// <copyright file="ReviewWorkflowModel.cs" company="Vasont Systems">
// Copyright (c) Vasont Systems. All rights reserved.
// </copyright>
//-------------------------------------------------------------------
namespace Vasont.Inspire.Models.Reviews
{
    using System;
    using System.Collections.Generic;
    using Vasont.Inspire.Models.Security;
    using Workflow;

    /// <summary>
    /// This class is a model representation of a review workflow within the application.
    /// </summary>
    public class ReviewWorkflowModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ReviewWorkflowModel"/> class.
        /// </summary>
        public ReviewWorkflowModel()
        {
            this.WorkflowModel = new WorkflowModel();
            this.Submittals = new List<ReviewWorkflowSubmittalModel>();
            this.Owner = new MicroUserModel();
        }

        /// <summary>
        /// Gets or sets the identity of the associated review.
        /// </summary>
        public long ReviewId { get; set; }

        /// <summary>
        /// Gets or sets the identity of the associated project.
        /// </summary>
        public long? ProjectId { get; set; }

        /// <summary>
        /// Gets or sets the identity of the associated workflow model.
        /// </summary>
        public WorkflowModel WorkflowModel { get; set; }

        /// <summary>
        /// Gets or sets the name of the review workflow.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the description of the review workflow.
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets the name of the template that the review workflow was created from.
        /// </summary>
        public string TemplateName { get; set; }

        /// <summary>
        /// Gets or sets the current status of the workflow.
        /// </summary>
        public string Status { get; set; }

        /// <summary>
        /// Gets or sets the current status of the workflow.
        /// </summary>
        public WorkflowState State { get; set; }

        /// <summary>
        /// Gets or sets the date and time when the workflow was created.
        /// </summary>
        public DateTime CreatedDate { get; set; }

        /// <summary>
        /// Gets or sets the user model of the user who created the workflow.
        /// </summary>
        public MicroUserModel Owner { get; set; }

        /// <summary>
        /// Gets or sets the date and time when the workflow is due.
        /// </summary>
        public DateTime? DueDate { get; set; }

        /// <summary>
        /// Gets or sets the date and time when the workflow was completed.
        /// </summary>
        public DateTime? CompletedDate { get; set; }

        /// <summary>
        /// Gets or sets a list of review workflow submittals.
        /// </summary>
        public List<ReviewWorkflowSubmittalModel> Submittals { get; set; }
    }
}