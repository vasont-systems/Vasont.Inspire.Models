//-------------------------------------------------------------
// <copyright file="ProjectBrowseQueryModel.cs" company="GlobalLink Vasont">
// Copyright (c) GlobalLink Vasont. All rights reserved.
// </copyright>
//-------------------------------------------------------------
namespace Vasont.Inspire.Models.Projects
{
    using Common;

    /// <summary>
    /// Contains an enumerated list of project type flags
    /// </summary>
    public enum BrowseProjectResultType
    {
        /// <summary>
        /// All Projects
        /// </summary>
        All,

        /// <summary>
        /// Project Participants
        /// </summary>
        Participating,

        /// <summary>
        /// Project Owner
        /// </summary>
        Owned,

        /// <summary>
        /// System Administrators
        /// </summary>
        Admin
    }

    /// <summary>
    /// This class contains parameters passed to the query for retrieving projects.
    /// </summary>
    public class ProjectBrowseQueryModel : PaginatedQueryRequestModel
    {
        /// <summary>
        /// Gets or sets a project type.
        /// </summary>
        public BrowseProjectResultType Type { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether or not to include completed projects.
        /// </summary>
        public bool IncludeCompleted { get; set; }

        /// <summary>
        /// Gets or sets search text that will be used to filter results.
        /// </summary>
        public string SearchText { get; set; }
    }
}