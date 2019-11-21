//-------------------------------------------------------------
// <copyright file="MinimalProjectAssignmentModel.cs" company="GlobalLink Vasont">
// Copyright (c) GlobalLink Vasont. All rights reserved.
// </copyright>
//-------------------------------------------------------------
namespace Vasont.Inspire.Models.Projects
{
    using System;
    using System.Collections.Generic;
    using Vasont.Inspire.Models.Components;

    /// <summary>
    /// This class represents a minimal project assignment within the application.
    /// </summary>
    public class MinimalProjectAssignmentModel
    {
        /// <summary>
        /// Gets or sets the project assignment identity value.
        /// </summary>
        public long ProjectAssignmentId { get; set; }

        /// <summary>
        /// Gets or sets the associated project identity value.
        /// </summary>
        public long ProjectId { get; set; }

        /// <summary>
        /// Gets or sets the associated project title value.
        /// </summary>
        public string ProjectTitle { get; set; }

        /// <summary>
        /// Gets or sets a related project assignment activity object.
        /// </summary>
        public MinimalProjectActivityModel ProjectActivity { get; set; }

        /// <summary>
        /// Gets or sets a date time indicating when the assignment is due.
        /// </summary>
        public DateTime? DueDate { get; set; }

        /// <summary>
        /// Gets or sets the assignment state name.
        /// </summary>
        public string StateName { get; set; }

        /// <summary>
        /// Gets or sets a list of components related to the assignment.
        /// </summary>
        public List<MinimalComponentModel> Components { get; set; } = new List<MinimalComponentModel>();
    }
}