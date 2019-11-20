//-------------------------------------------------------------------------
// <copyright file="ReviewerEditCompleteModel.cs" company="Vasont Systems">
// Copyright (c) Vasont Systems. All rights reserved.
// </copyright>
//-------------------------------------------------------------------------
namespace Vasont.Inspire.Models.Reviews
{
    /// <summary>
    /// This class represents a reviewer edit that is being completed.
    /// </summary>
    public class ReviewerEditCompleteModel
    {
        /// <summary>
        /// Gets or sets the identity of the review.
        /// </summary>
        public long ReviewId { get; set; }

        /// <summary>
        /// Gets or sets the identity of the user.
        /// </summary>
        public long UserId { get; set; }

        /// <summary>
        /// Gets or sets a comment associated with the reviewer.
        /// </summary>
        public string Comment { get; set; }

        /// <summary>
        /// Gets or sets the identity of the transition to initiate when this reviewer session completes.
        /// </summary>
        public string NextTransitionId { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this reviewer will be included in the next workflow reviewing activity.
        /// </summary>
        public bool UserInNextWorkflowActivity { get; set; }
    }
}
