//----------------------------------------------------------------------
// <copyright file="ReviewBrowseQueryModel.cs" company="Vasont Systems">
// Copyright (c) Vasont Systems. All rights reserved.
// </copyright>
//----------------------------------------=-----------------------------
namespace Vasont.Inspire.Models.Reviews
{
    using Common;

    /// <summary>
    /// This class contains parameters passed to the query for retrieving reviews.
    /// </summary>
    public class ReviewBrowseQueryModel : PaginatedQueryRequestModel
    {
        /// <summary>
        /// Gets or sets a value indicating whether or not to include archived reviews.
        /// </summary>
        public bool IncludeArchived { get; set; }

        /// <summary>
        /// Gets or sets search text that will be used to filter results.
        /// </summary>
        public string SearchText { get; set; }
    }
}