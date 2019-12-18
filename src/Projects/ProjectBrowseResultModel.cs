//-------------------------------------------------------------
// <copyright file="ProjectBrowseResultModel.cs" company="GlobalLink Vasont">
// Copyright (c) GlobalLink Vasont. All rights reserved.
// </copyright>
//-------------------------------------------------------------
namespace Vasont.Inspire.Models.Projects
{
    using System.Collections.Generic;

    /// <summary>
    /// This class represents the results of a project browse query request.
    /// </summary>
    public class ProjectBrowseResultModel
    {
        /// <summary>
        /// Gets or sets the total number of projects.
        /// </summary>
        public long TotalCount { get; set; }

        /// <summary>
        /// Gets or sets the resulting projects from the query request.
        /// </summary>
        public List<ProjectBrowseModel> Projects { get; set; } = new List<ProjectBrowseModel>();
    }
}