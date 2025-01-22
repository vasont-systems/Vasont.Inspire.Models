//-----------------------------------------------------------------------
// <copyright file="DetailedProjectAssignmentModel.cs" company="GlobalLink Vasont">
// Copyright (c) GlobalLink Vasont. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------
using System;

namespace Vasont.Inspire.Models.Projects
{
    /// <summary>
    /// This class contains the values for a project assignment along with minimal project details.
    /// </summary>
    [Obsolete("use local DTOs", false)]
    public class DetailedProjectAssignmentModel : ProjectAssignmentModel
    {
        /// <summary>
        /// Gets or sets the associated project.
        /// </summary>
        public MinimalProjectModel Project { get; set; }
    }
}