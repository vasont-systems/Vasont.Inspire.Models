//--------------------------------------------------------------------
// <copyright file="ReviewDiscussionReplyBrowseModel.cs" company="GlobalLink Vasont">
// Copyright (c) GlobalLink Vasont. All rights reserved.
// </copyright>
//--------------------------------------------------------------------
namespace Vasont.Inspire.Models.Reviews
{
    using System;
    using Vasont.Inspire.Models.Security;

    /// <summary>
    /// This class represents a review discussion  reply associated with a review discussion.
    /// </summary>
    public class ReviewDiscussionReplyBrowseModel
    {
        /// <summary>
        /// Gets or sets the identity of the review discussion reply.
        /// </summary>
        public long ReviewDiscussionReplyId { get; set; }

        /// <summary>
        /// Gets or sets the identity of the review discussion.
        /// </summary>
        public long ReviewDiscussionId { get; set; }

        /// <summary>
        /// Gets or sets the user information.
        /// </summary>
        public MinimalUserModel User { get; set; }

        /// <summary>
        /// Gets or sets the date and time when the review discussion reply was created.
        /// </summary>
        public DateTime CreateDate { get; set; } = DateTime.UtcNow;

        /// <summary>
        /// Gets or sets the review discussion reply content.
        /// </summary>
        public string Content { get; set; }
    }
}
