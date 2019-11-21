//-----------------------------------------------------------------------
// <copyright file="ProjectFilters.cs" company="GlobalLink Vasont">
// Copyright (c) GlobalLink Vasont. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------
namespace Vasont.Inspire.Models.Projects
{
    using Vasont.Inspire.Core.Extensions;

    /// <summary>
    /// This class contains all the filter properties used to modify a project search query.
    /// </summary>
    public sealed class ProjectFilters
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectFilters"/> class.
        /// </summary>
        public ProjectFilters()
        {
            this.Direction = SortDirection.Asc;
            this.MaximumRows = 0;
        }

        /// <summary>
        /// Gets or sets the filter on project title.
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Gets or sets the filter order by column name.
        /// </summary>
        public string OrderByName { get; set; }

        /// <summary>
        /// Gets or sets the order by sort direction.
        /// </summary>
        public SortDirection Direction { get; set; }

        /// <summary>
        /// Gets or sets the maximum rows to return.
        /// </summary>
        public int MaximumRows { get; set; }
    }
}
