//-----------------------------------------------------------------------
// <copyright file="ProjectModel.cs" company="GlobalLink Vasont">
// Copyright (c) GlobalLink Vasont. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------
namespace Vasont.Inspire.Models.Projects
{
    using System.Collections.Generic;

    /// <summary>
    /// This class represents a project within the application.
    /// </summary>
    public class ProjectModel : MinimalProjectModel
    {
        /// <summary>
        /// Gets or sets a list of <see cref="ProjectDiscussionModel"/> objects.
        /// </summary>
        public List<ProjectDiscussionModel> Discussions { get; set; } = new List<ProjectDiscussionModel>();

        /// <summary>
        /// Gets or sets a list of <see cref="ProjectAssignmentModel"/> objects.
        /// </summary>
        public List<ProjectAssignmentModel> Assignments { get; set; } = new List<ProjectAssignmentModel>();

        /// <summary>
        /// Gets or sets a list of <see cref="ProjectUserAccessModel"/> objects.
        /// </summary>
        public List<MinimalProjectUserAccessModel> UserAccesses { get; set; } = new List<MinimalProjectUserAccessModel>();

        /// <summary>
        /// Gets or sets a list of workflows related to the project.
        /// </summary>
        public List<ProjectWorkflowDisplayModel> Workflows { get; set; } = new List<ProjectWorkflowDisplayModel>();
    }
}
