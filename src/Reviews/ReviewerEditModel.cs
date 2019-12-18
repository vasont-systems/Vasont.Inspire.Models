//-----------------------------------------------------------------
// <copyright file="ReviewerEditModel.cs" company="GlobalLink Vasont">
// Copyright (c) GlobalLink Vasont. All rights reserved.
// </copyright>
//-----------------------------------------------------------------
namespace Vasont.Inspire.Models.Reviews
{
    using System;
    using System.Collections.Generic;
    using Vasont.Inspire.Models.Security;
    using Vasont.Inspire.Models.Workflow;

    /// <summary>
    /// This class represents a reviewer edit within the application.
    /// </summary>
    public class ReviewerEditModel
    {
        /// <summary>
        /// Gets or sets the identity of the review.
        /// </summary>
        public long ReviewId { get; set; }

        /// <summary>
        /// Gets or sets the review title.
        /// </summary>
        public string ReviewTitle { get; set; }

        /// <summary>
        /// Gets or sets the review coordinator user information.
        /// </summary>
        public MinimalUserModel Coordinator { get; set; }

        /// <summary>
        /// Gets or sets the data and time the review is due.
        /// </summary>
        public DateTime? DueDate { get; set; }

        /// <summary>
        /// Gets or sets the reviewer identity.
        /// </summary>
        public long ReviewerUserId { get; set; }

        /// <summary>
        /// Gets or sets the state of the reviewer.
        /// </summary>
        public ReviewerStateType ReviewerState { get; set; } = ReviewerStateType.Reviewing;

        /// <summary>
        /// Gets or sets a value indicating whether the reviewer can make comments.
        /// </summary>
        public bool CanComment { get; set; } = true;

        /// <summary>
        /// Gets or sets a value indicating whether the reviewer can make track changes.
        /// </summary>
        public bool CanTrackChanges { get; set; }

        /// <summary>
        /// Gets or sets the date and time when the reviewer component was completed.
        /// </summary>
        public DateTime? CompletedDate { get; set; }

        /// <summary>
        /// Gets or sets the reviewer components associated with this review.
        /// </summary>
        public List<ReviewerComponentEditModel> ReviewerComponents { get; set; } = new List<ReviewerComponentEditModel>();

        /// <summary>
        /// Gets or sets a list of transitions that can occur after the user completes their reviewer session.
        /// </summary>
        public List<WorkflowNextTransitionModel> Transitions { get; set; } = new List<WorkflowNextTransitionModel>();
    }
}
