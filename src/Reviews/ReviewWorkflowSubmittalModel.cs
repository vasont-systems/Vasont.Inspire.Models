//----------------------------------------------------------------------------
// <copyright file="ReviewWorkflowSubmittalModel.cs" company="GlobalLink Vasont">
// Copyright (c) GlobalLink Vasont. All rights reserved.
// </copyright>
//----------------------------------------------------------------------------
namespace Vasont.Inspire.Models.Reviews
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// This class is a model representation of a review workflow submittal within the application.
    /// </summary>
    public class ReviewWorkflowSubmittalModel
    {
        /// <summary>
        /// Gets or sets the identity of the review workflow submittal.
        /// </summary>
        public long ReviewWorkflowSubmittalId { get; set; }

        /// <summary>
        /// Gets or sets the identity of the associated review workflow.
        /// </summary>
        public long ReviewId { get; set; }

        /// <summary>
        /// Gets or sets a list of reviewer identities associated with the submittal.
        /// </summary>
        public List<long> ReviewerIds { get; set; } = new List<long>();

        /// <summary>
        /// Gets or sets the identity of the workflow activity.
        /// </summary>
        public string WorkflowActivityId { get; set; }

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
    }
}
