//-----------------------------------------------------------------------
// <copyright file="ProjectActivityModel.cs" company="GlobalLink Vasont">
// Copyright (c) GlobalLink Vasont. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------
namespace Vasont.Inspire.Models.Projects
{
    using System;
    using Vasont.Inspire.Models.Common;

    /// <summary>
    /// This class represents a project activity for use in defining an assignment within a project.
    /// </summary>
    public class ProjectActivityModel : CreatedUpdaterModelBase
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectActivityModel" /> class.
        /// </summary>
        public ProjectActivityModel()
        {
            this.CreatedDate = DateTime.UtcNow;
            this.UpdatedDate = DateTime.UtcNow;
        }

        /// <summary>
        /// Gets or sets the project activity identity value.
        /// </summary>
        public long ProjectActivityId { get; set; }

        /// <summary>
        /// Gets or sets the name of the project activity.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the description of the project activity.
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether a task using this activity will be required within the project.
        /// </summary>
        public bool Required { get; set; }
    }
}