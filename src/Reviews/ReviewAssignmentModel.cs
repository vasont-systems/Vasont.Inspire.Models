//---------------------------------------------------------------------
// <copyright file="ReviewAssignmentModel.cs" company="GlobalLink Vasont">
// Copyright (c) GlobalLink Vasont. All rights reserved.
// </copyright>
//---------------------------------------------------------------------
namespace Vasont.Inspire.Models.Reviews
{
    using System;
    using Newtonsoft.Json;
    using Vasont.Inspire.Models.Security;

    /// <summary>
    /// This class represents a review assignment within the application.
    /// </summary>
    public class ReviewAssignmentModel
    {
        /// <summary>
        /// Gets or sets the review identity value.
        /// </summary>
        public long ReviewId { get; set; }

        /// <summary>
        /// Gets or sets the review title.
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Gets or sets the review coordinator user information.
        /// </summary>
        public MinimalUserModel Coordinator { get; set; } = new MinimalUserModel();

        /// <summary>
        /// Gets or sets the review state information.
        /// </summary>
        public ReviewStateType State { get; set; }

        /// <summary>
        /// Gets or sets the date time when the review should be started.
        /// </summary>
        public DateTime? StartDate { get; set; }

        /// <summary>
        /// Gets or sets the review due date time.
        /// </summary>
        public DateTime? DueDate { get; set; }

        /// <summary>
        /// Gets or sets the percentage of components reviewed by the reviewer.
        /// </summary>
        public virtual int PercentageCompleted { get; set; }

        /// <summary>
        /// Gets or sets the review user identity.
        /// </summary>
        [JsonIgnore]
        public long ReviewerUserId { get; set; }
    }
}
