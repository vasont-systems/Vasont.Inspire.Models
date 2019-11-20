//-----------------------------------------------------------------------
// <copyright file="ProjectModel.cs" company="Vasont Systems">
// Copyright (c) Vasont Systems. All rights reserved.
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
        /// Initializes a new instance of the <see cref="ProjectModel"/> class.
        /// </summary>
        public ProjectModel()
        {
            this.FolderItems = new List<ProjectFolderItemModel>();
            this.Assignments = new List<ProjectAssignmentModel>();
            this.UserAccesses = new List<MinimalProjectUserAccessModel>();
            this.Participants = new List<ProjectParticipantModel>();
            this.Workflows = new List<ProjectWorkflowDisplayModel>();
        }

        /// <summary>
        /// Gets or sets a list of <see cref="ProjectDiscussionModel"/> objects.
        /// </summary>
        public List<ProjectDiscussionModel> Discussions { get; set; }

        /// <summary>
        /// Gets or sets a list of <see cref="ProjectFolderItemModel"/> objects.
        /// </summary>
        public List<ProjectFolderItemModel> FolderItems { get; set; }

        /// <summary>
        /// Gets or sets a list of <see cref="ProjectAssignmentModel"/> objects.
        /// </summary>
        public List<ProjectAssignmentModel> Assignments { get; set; }

        /// <summary>
        /// Gets or sets a list of <see cref="ProjectUserAccessModel"/> objects.
        /// </summary>
        public List<MinimalProjectUserAccessModel> UserAccesses { get; set; }

        /// <summary>
        /// Gets or sets a list of workflows related to the project.
        /// </summary>
        public List<ProjectWorkflowDisplayModel> Workflows { get; set; }
    }
}
