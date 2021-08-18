//----------------------------------------------------------------------
// <copyright file="ReviewBrowseQueryModel.cs" company="GlobalLink Vasont">
// Copyright (c) GlobalLink Vasont. All rights reserved.
// </copyright>
//----------------------------------------=-----------------------------
namespace Vasont.Inspire.Models.Reviews
{
    using System.Collections.Generic;
    using Common;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using Vasont.Inspire.Models.Search;

    /// <summary>
    /// Contains an enumerated list of revidw type flags.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum BrowseReviewResultType
    {
        /// <summary>
        /// All Reviews
        /// </summary>
        All,

        /// <summary>
        /// All Review Participants
        /// </summary>
        Participating,

        /// <summary>
        /// Review Coordinator
        /// </summary>
        Owned,

        /// <summary>
        /// System Administrators
        /// </summary>
        Admin
    }

    /// <summary>
    /// This class contains parameters passed to the query for retrieving reviews.
    /// </summary>
    public class ReviewBrowseQueryModel : PaginatedQueryRequestModel
    {
        /// <summary>
        /// Gets or sets a project type.
        /// </summary>
        public BrowseReviewResultType Type { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether or not to include archived reviews.
        /// </summary>
        public bool IncludeArchived { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether or not to include completed reviews.
        /// </summary>
        public bool IncludeCompleted { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether or not to include cancelled reviews.
        /// </summary>
        public bool IncludeCancelled { get; set; }

        /// <summary>
        /// Gets or sets search text that will be used to filter results.
        /// </summary>
        public string SearchText { get; set; }

        /// <summary>
        /// Gets or sets an optional list of ad-hoc query built filters.
        /// </summary>
        public List<AdHocQueryFilterModel> QueryFilters { get; set; } = new List<AdHocQueryFilterModel>();

        /// <summary>
        /// Gets or sets an optional list of ad-hoc query built filters with the display values.
        /// </summary>
        public List<AdHocQueryFilterModel> QueryFiltersWithDisplayValues { get; set; }

        /// <summary>
        /// Gets or sets the name of the selected query.
        /// </summary>
        public string QueryName { get; set; }
    }
}