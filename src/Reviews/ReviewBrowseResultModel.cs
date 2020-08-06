//-----------------------------------------------------------------------
// <copyright file="ReviewBrowseResultModel.cs" company="GlobalLink Vasont">
// Copyright (c) GlobalLink Vasont. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------
namespace Vasont.Inspire.Models.Reviews
{
    using System.Collections.Generic;

    /// <summary>
    /// This class represents the results of a review browse query request.
    /// </summary>
    public class ReviewBrowseResultModel
    {
        /// <summary>
        /// Gets or sets the total number of reviews.
        /// </summary>
        public long TotalCount { get; set; }

        /// <summary>
        /// Gets or sets the resulting reviews from the query request.
        /// </summary>
        public List<ReviewModel> Reviews { get; set; } = new List<ReviewModel>();
    }
}