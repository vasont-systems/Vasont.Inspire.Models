//-----------------------------------------------------------------------
// <copyright file="ProjectUserAccessModel.cs" company="Vasont Systems">
// Copyright (c) Vasont Systems. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace Vasont.Inspire.Models.Projects
{
    using System;

    /// <summary>
    /// This class represents a project access record for a specific user within the application.
    /// </summary>
    public class ProjectUserAccessModel
    {
        /// <summary>
        /// Gets or sets the associated project identity value.
        /// </summary>
        public long ProjectId { get; set; }

        /// <summary>
        /// Gets or sets the user identity of the user accessing the project.
        /// </summary>
        public long UserId { get; set; }

        /// <summary>
        /// Gets or sets the date time when the project was last accessed.
        /// </summary>
        public DateTime LastAccessedDate { get; set; }

        /// <summary>
        /// Gets or sets the related project title.
        /// </summary>
        public string ProjectTitle { get; set; }

        /// <summary>
        /// Gets or sets the related user name.
        /// </summary>
        public string UserName { get; set; }
    }
}