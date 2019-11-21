//-----------------------------------------------------------------
// <copyright file="ReviewDetailModel.cs" company="GlobalLink Vasont">
// Copyright (c) GlobalLink Vasont. All rights reserved.
// </copyright>
//-----------------------------------------------------------------
namespace Vasont.Inspire.Models.Reviews
{
    using System;
    using System.Collections.Generic;
    using Vasont.Inspire.Models.Security;

    /// <summary>
    /// This class represents a review within the application.
    /// </summary>
    public class ReviewDetailModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ReviewDetailModel"/> class.
        /// </summary>
        public ReviewDetailModel()
        {
            this.Coordinator = new MinimalUserModel();
            this.CreatedBy = new MinimalUserModel();
            this.UpdatedBy = new MinimalUserModel();
            this.State = ReviewStateType.Reviewing;
            this.CreatedDate = this.UpdatedDate = DateTime.UtcNow;
            this.Components = new List<ReviewComponentDetailModel>();
            this.Reviewers = new List<ReviewerModel>();
        }

        /// <summary>
        /// Gets or sets the identity of the review.
        /// </summary>
        public long ReviewId { get; set; }

        /// <summary>
        /// Gets or sets the review title.
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Gets or sets the review description.
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets the review coordinator user information.
        /// </summary>
        public MinimalUserModel Coordinator { get; set; }

        /// <summary>
        /// Gets or sets the review state information.
        /// </summary>
        public ReviewStateType State { get; set; }

        /// <summary>
        /// Gets or sets the reviewer state information if the current user is a reviewer for this review.
        /// </summary>
        public ReviewerStateType ReviewerState { get; set; }

        /// <summary>
        /// Gets or sets the date time when the review should be started.
        /// </summary>
        public DateTime? StartDate { get; set; }

        /// <summary>
        /// Gets or sets the data and time the review is due.
        /// </summary>
        public DateTime? DueDate { get; set; }

        /// <summary>
        /// Gets or sets the date and time that the review was completed.
        /// </summary>
        public DateTime? CompletedDate { get; set; }

        /// <summary>
        /// Gets or sets the date and time when the review was created.
        /// </summary>
        public DateTime CreatedDate { get; set; }

        /// <summary>
        /// Gets or sets the date and time when the review was last updated.
        /// </summary>
        public DateTime UpdatedDate { get; set; }

        /// <summary>
        /// Gets or sets the user information about the user who created the review.
        /// </summary>
        public MinimalUserModel CreatedBy { get; set; }

        /// <summary>
        /// Gets or sets the user information about the user who last updated the review.
        /// </summary>
        public MinimalUserModel UpdatedBy { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the review is archived.
        /// </summary>
        public bool Archived { get; set; }

        /// <summary>
        /// Gets or sets the reviewers associated with the review.
        /// </summary>
        public List<ReviewerModel> Reviewers { get; set; }

        /// <summary>
        /// Gets or sets the review components detail associated with the review.
        /// </summary>
        public List<ReviewComponentDetailModel> Components { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the review is related to workflow.
        /// </summary>
        public bool HasWorkflow { get; set; }
    }
}
