//-----------------------------------------------------------------------
// <copyright file="MicroProjectAssignmentStateModel.cs" company="GlobalLink Vasont">
// Copyright (c) GlobalLink Vasont. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------
namespace Vasont.Inspire.Models.Projects
{
    /// <summary>
    /// This class represents the absolute minimum values of project assignment state for application display.
    /// </summary>
    public class MicroProjectAssignmentStateModel
    {
        /// <summary>
        /// Gets or sets the project assignment state identity value.
        /// </summary>
        public ProjectAssignmentStateType ProjectAssignmentStateId { get; set; }

        /// <summary>
        /// Gets or sets the project assignment state name.
        /// </summary>
        public string Name { get; set; }
    }
}
