//--------------------------------------------------------------------------
// <copyright file="FolderComponentsQueryModel.cs" company="GlobalLink Vasont">
// Copyright (c) GlobalLink Vasont. All rights reserved.
// </copyright>
//--------------------------------------------------------------------------
namespace Vasont.Inspire.Models.Components
{
    using System.Collections.Generic;
    using Common;
    using Vasont.Inspire.Models.Search;

    /// <summary>
    /// This class contains parameters passed to the query for retrieving components within a folder.
    /// </summary>
    public class FolderComponentsQueryModel : PaginatedQueryRequestModel
    {
        /// <summary>
        /// Gets or sets the identity of the folder.
        /// </summary>
        public long FolderId { get; set; }

        /// <summary>
        /// Gets or sets the optional identity of a project.
        /// </summary>
        public long ProjectId { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether all sub-folders are included in search results.
        /// </summary>
        public bool IncludeSubFolders { get; set; } = true;

        /// <summary>
        /// Gets or sets the text of the component search.
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