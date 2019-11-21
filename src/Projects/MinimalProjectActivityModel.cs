//-----------------------------------------------------------------------
// <copyright file="MinimalProjectActivityModel.cs" company="GlobalLink Vasont">
// Copyright (c) GlobalLink Vasont. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------
namespace Vasont.Inspire.Models.Projects
{
    /// <summary>
    /// This class represents a minimal project activity description.
    /// </summary>
    public class MinimalProjectActivityModel
    {
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
