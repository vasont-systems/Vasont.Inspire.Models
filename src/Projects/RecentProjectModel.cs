//-----------------------------------------------------------------------
// <copyright file="RecentProjectModel.cs" company="Vasont Systems">
// Copyright (c) Vasont Systems. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------
namespace Vasont.Inspire.Models.Projects
{
    /// <summary>
    /// This model class represents the minimal project detail for a recent projects list.
    /// </summary>
    public class RecentProjectModel
    {
        /// <summary>
        /// Gets or sets the project identity.
        /// </summary>
        public long ProjectId { get; set; }

        /// <summary>
        /// Gets or sets the project title.
        /// </summary>
        public string Title { get; set; }
    }
}
