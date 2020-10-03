//--------------------------------------------------------------------
// <copyright file="ReviewDiscussionModel.cs" company="GlobalLink Vasont">
// Copyright (c) GlobalLink Vasont. All rights reserved.
// </copyright>
//--------------------------------------------------------------------
namespace Vasont.Inspire.Models.Reviews
{
    using System;

    /// <summary>
    /// This class represents a review discussion associated with a review.
    /// </summary>
    public class ReviewDiscussionModel
    {
        /// <summary>
        /// Gets or sets the identity of the review discussion.
        /// </summary>
        public long ReviewDiscussionId { get; set; }

        /// <summary>
        /// Gets or sets the identity of the review.
        /// </summary>
        public long ReviewId { get; set; }

        /// <summary>
        /// Gets or sets the userid that created the review discussion.
        /// </summary>
        public int UserId { get; set; }

        /// <summary>
        /// Gets or sets the date and time when the review discussion was created.
        /// </summary>
        public DateTime CreateDate { get; set; } = DateTime.UtcNow;

        /// <summary>
        /// Gets or sets the review discussion content.
        /// </summary>
        public string Content { get; set; }
    }
}
