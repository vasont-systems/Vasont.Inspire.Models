//---------------------------------------------------------------------------
// <copyright file="ProjectAssignmentBrowseQueryModel.cs" company="GlobalLink Vasont">
// Copyright (c) GlobalLink Vasont. All rights reserved.
// </copyright>
//---------------------------------------------------------------------------
namespace Vasont.Inspire.Models.Projects
{
    using System;
    using System.Collections.Generic;
    using Vasont.Inspire.Core.Extensions;
    using Vasont.Inspire.Models.Search;

    /// <summary>
    /// This class contains parameters passed to the query for retrieving project assignments.
    /// </summary>
    public class ProjectAssignmentBrowseQueryModel
    {
        /// <summary>
        ///  Gets or sets the name of the column to sort by.
        /// </summary>
        public string[] Sort { get; set; } = Array.Empty<string>();

        /// <summary>
        ///  Gets or sets the sort direction.
        /// </summary>
        public SortDirection[] Dir { get; set; } = Array.Empty<SortDirection>();

        /// <summary>
        /// Gets or sets an optional list of ad-hoc query built filters.
        /// </summary>
        public List<AdHocQueryFilterModel> QueryFilters { get; set; } = new List<AdHocQueryFilterModel>();

        /// <summary>
        /// Gets or sets an optional list of ad-hoc query built filters with the display values.
        /// </summary>
        public List<AdHocQueryFilterModel> QueryFiltersWithDisplayValues { get; set; } = new List<AdHocQueryFilterModel>();
    }
}
