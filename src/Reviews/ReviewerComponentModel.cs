//----------------------------------------------------------------------
// <copyright file="ReviewerComponentModel.cs" company="GlobalLink Vasont">
// Copyright (c) GlobalLink Vasont. All rights reserved.
// </copyright>
//----------------------------------------------------------------------
namespace Vasont.Inspire.Models.Reviews
{
    using System;

    /// <summary>
    /// This class represents a reviewer component within the application.
    /// </summary>
    public class ReviewerComponentModel
    {
        /// <summary>
        /// Gets or sets the identity of the reviewer component.
        /// </summary>
        public long ReviewerComponentId { get; set; }

        /// <summary>
        /// Gets or sets the identity of the review component.
        /// </summary>
        public long ReviewComponentId { get; set; }

        /// <summary>
        /// Gets or sets the identity of the review.
        /// </summary>
        public long ReviewId { get; set; }

        /// <summary>
        /// Gets or sets the identity of the reviewer user.
        /// </summary>
        public long UserId { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the reviewer component has been completed.
        /// </summary>
        public bool Completed { get; set; }

        /// <summary>
        /// Gets or sets the date and time that the review component was last saved.
        /// </summary>
        public DateTime? SavedDate { get; set; }

        /// <summary>
        /// Gets or sets the reviewer component comment.
        /// </summary>
        public string Comment { get; set; }
    }
}
