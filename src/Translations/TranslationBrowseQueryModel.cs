//---------------------------------------------------------------------------
// <copyright file="TranslationBrowseQueryModel.cs" company="GlobalLink Vasont">
// Copyright (c) GlobalLink Vasont. All rights reserved.
// </copyright>
//---------------------------------------------------------------------------

namespace Vasont.Inspire.Models.Translations
{
    using System.Collections.Generic;
    using Common;
    using Vasont.Inspire.Models.Search;

    /// <summary>
    /// This class contains parameters passed to the query for retrieving translations.
    /// </summary>
    public class TranslationBrowseQueryModel : PaginatedQueryRequestModel
    {
        /// <summary>
        /// Gets or sets a value indicating whether or not to include archived translations.
        /// </summary>
        public bool IncludeArchived { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether or not to include completed translations.
        /// </summary>
        public bool IncludeCompleted { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether or not to include cancelled translations.
        /// </summary>
        public bool IncludeCancelled { get; set; }

        /// <summary>
        /// Gets or sets search text that will be used to filter results.
        /// </summary>
        public string SearchText { get; set; }

        /// <summary>
        /// Gets or sets a list of job states to filter results by.
        /// </summary>
        public List<string> JobStates { get; set; } = new List<string>();

        /// <summary>
        /// Gets or sets an optional list of ad-hoc query built filters.
        /// </summary>
        public List<AdHocQueryFilterModel> QueryFilters { get; set; } = new List<AdHocQueryFilterModel>();

        /// <summary>
        /// Gets or sets an optional list of ad-hoc query built filters with the display values.
        /// </summary>
        public List<AdHocQueryFilterModel> QueryFiltersWithDisplayValues { get; set; } = new List<AdHocQueryFilterModel>();

        /// <summary>
        /// Gets or sets the name of the selected query.
        /// </summary>
        public string QueryName { get; set; }
    }
}