//-----------------------------------------------------------------------
// <copyright file="MinimalProjectUserAccessModel.cs" company="GlobalLink Vasont">
// Copyright (c) GlobalLink Vasont. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------
namespace Vasont.Inspire.Models.Projects
{
    using System;
    using Vasont.Inspire.Models.Security;

    /// <summary>
    /// This class represents a user access defined within a <see cref="ProjectModel"/> class. It is a stripped down version
    /// of the <see cref="ProjectUserAccessModel"/> and returns only essential information related to the user access of the project.
    /// </summary>
    [Obsolete("use local DTOs", false)]
    public class MinimalProjectUserAccessModel
    {
        /// <summary>
        /// Gets or sets the user identity of the user accessing the project.
        /// </summary>
        public MinimalUserModel User { get; set; }

        /// <summary>
        /// Gets or sets the date time when the project was last accessed.
        /// </summary>
        public DateTime LastAccessedDate { get; set; }
    }
}
