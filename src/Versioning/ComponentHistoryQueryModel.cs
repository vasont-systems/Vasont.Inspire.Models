//--------------------------------------------------------------------------
// <copyright file="ComponentHistoryQueryModel.cs" company="GlobalLink Vasont">
// Copyright (c) GlobalLink Vasont. All rights reserved.
// </copyright>
//--------------------------------------------------------------------------
namespace Vasont.Inspire.Models.Versioning
{
    using Common;
    using System.Collections.Generic;
    using Vasont.Inspire.Models.Search;

    /// <summary>
    /// This model class represents parameters passed in from a paging grid listing a component's history.
    /// </summary>
    public sealed class ComponentHistoryQueryModel : PaginatedQueryRequestModel
    {
        /// <summary>
        /// Gets or sets the component to retrieve history on.
        /// </summary>
        public long ComponentId { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether to include components deleted by other users.
        /// </summary>
        public bool IncludeAllUsers { get; set; }

        /// <summary>
        /// Gets or sets a value indicating search text.
        /// </summary>
        public string SearchText { get; set; }

        /// <summary>
        /// Gets or sets an optional list of ad-hoc query built filters
        /// </summary>
        public List<AdHocQueryFilterModel> QueryFilters { get; set; } = new List<AdHocQueryFilterModel>();

        /// <summary>
        /// Gets or sets an optional list of ad-hoc query built filters with the display values
        /// </summary>
        public List<AdHocQueryFilterModel> QueryFiltersWithDisplayValues { get; set; } = new List<AdHocQueryFilterModel>();

        /// <summary>
        /// Gets or sets the name of the selected query.
        /// </summary>
        public string QueryName { get; set; }

        /// <summary>
        /// Gets or sets a comma delimited list of component type document types to add to the query expression.
        /// </summary>
        public string FilterByComponentTypes { get; set; }

        /// <summary>
        /// Gets or sets a comma delimited list of content type keys to add to the query expression.
        /// </summary>
        public string FilterByContentTypes { get; set; }
    }
}
