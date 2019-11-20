//-----------------------------------------------------------------------
// <copyright file="ReviewModel.cs" company="Vasont Systems">
// Copyright (c) Vasont Systems. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------
namespace Vasont.Inspire.Models.Reviews
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using Vasont.Inspire.Models.Security;

    /// <summary>
    /// Contains an enumerated list of review state types.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum ReviewStateType
    {
        /// <summary>
        /// Contains a value that indicates reviewing is active.
        /// </summary>
        Reviewing,

        /// <summary>
        /// Contains a value that indicates resolving is active.
        /// </summary>
        Resolving,

        /// <summary>
        /// Contains a value that indicates the review has been completed.
        /// </summary>
        Completed,

        /// <summary>
        /// Contains a value that indicates the review has been cancelled.
        /// </summary>
        Cancelled
    }

    /// <summary>
    /// This class represents a review within the application.
    /// </summary>
    public class ReviewModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ReviewModel"/> class.
        /// </summary>
        public ReviewModel()
        {
            this.Coordinator = new MinimalUserModel();
            this.CreatedBy = new MinimalUserModel();
            this.UpdatedBy = new MinimalUserModel();
            this.State = ReviewStateType.Reviewing;
            this.CreatedDate = this.UpdatedDate = DateTime.UtcNow;
            this.Components = new List<ReviewComponentModel>();
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
        /// Gets or sets a value indicating whether the current user is a reviewer.
        /// </summary>
        public bool IsReviewer { get; set; }

        /// <summary>
        /// Gets or sets the reviewers associated with the review.
        /// </summary>
        public List<ReviewerModel> Reviewers { get; set; }

        /// <summary>
        /// Gets or sets the review components associated with the review.
        /// </summary>
        public List<ReviewComponentModel> Components { get; set; }

        /// <summary>
        /// Gets or sets the review workflow associated with the review.
        /// </summary>
        public ReviewWorkflowModel ReviewWorkflow { get; set; }
    }
}
