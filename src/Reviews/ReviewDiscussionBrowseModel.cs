﻿//--------------------------------------------------------------------
// <copyright file="ReviewDiscussionBrowseModel.cs" company="GlobalLink Vasont">
// Copyright (c) GlobalLink Vasont. All rights reserved.
// </copyright>
//--------------------------------------------------------------------
namespace Vasont.Inspire.Models.Reviews
{
    using System;
    using System.Collections.Generic;
    using Vasont.Inspire.Models.Security;

    /// <summary>
    /// This class represents review discussions and review discussion replies within the application.
    /// </summary>
    public class ReviewDiscussionBrowseModel
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
        /// Gets or sets the review discussion user information.
        /// </summary>
        public MinimalUserModel User { get; set; } = new MinimalUserModel();

        /// <summary>
        /// Gets or sets the date and time when the review discussion was created.
        /// </summary>
        public DateTime CreatedDate { get; set; } = DateTime.UtcNow;

        /// <summary>
        /// Gets or sets the review discussion subject.
        /// </summary>
        public string Subject { get; set; }

        /// <summary>
        /// Gets or sets the review discussion content.
        /// </summary>
        public string Content { get; set; }

        /// <summary>
        /// Gets or sets the review discussion replies.
        /// </summary>
        public List<ReviewDiscussionReplyModel> ReviewDiscussionReplys { get; set; } = new List<ReviewDiscussionReplyModel>();
    }
}
