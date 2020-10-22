//-----------------------------------------------------------------------
// <copyright file="ReviewDiscussionResultModel.cs" company="GlobalLink Vasont">
// Copyright (c) GlobalLink Vasont. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------
namespace Vasont.Inspire.Models.Reviews
{
    using System.Collections.Generic;

    /// <summary>
    /// This class represents the results of a review discussion request.
    /// </summary>
    public class ReviewDiscussionResultModel
    {
        /// <summary>
        /// Gets or sets the total number of review discussions.
        /// </summary>
        public long TotalCount { get; set; }

        /// <summary>
        /// Gets or sets the resulting review discussions from the request.
        /// </summary>
        public List<ReviewDiscussionBrowseModel> ReviewDiscussions { get; set; } = new List<ReviewDiscussionBrowseModel>();
    }
}