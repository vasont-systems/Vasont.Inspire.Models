//-----------------------------------------------------------------------
// <copyright file="ReviewerNotificationModel.cs" company="GlobalLink Vasont">
// Copyright (c) GlobalLink Vasont. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------
namespace Vasont.Inspire.Models.Reviews
{
    using Vasont.Inspire.Models.Security;

    /// <summary>
    /// This class represents a reviewer notification sent from a review by the current user.
    /// </summary>
    public class ReviewerNotificationModel
    {
        /// <summary>
        /// Gets or sets the identity of the review.
        /// </summary>
        public long ReviewId { get; set; }

        /// <summary>
        /// Gets or sets the review title.
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Gets or sets the reviewer user information.
        /// </summary>
        public MinimalUserModel Reviewer { get; set; } = new MinimalUserModel();

        /// <summary>
        /// Gets or sets the reviewer notification message.
        /// </summary>
        public string Message { get; set; }
    }
}
