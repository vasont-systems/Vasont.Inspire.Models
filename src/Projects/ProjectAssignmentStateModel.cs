//---------------------------------------------------------------------------
// <copyright file="ProjectAssignmentStateModel.cs" company="GlobalLink Vasont">
// Copyright (c) GlobalLink Vasont. All rights reserved.
// </copyright>
//---------------------------------------------------------------------------
namespace Vasont.Inspire.Models.Projects
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using Vasont.Inspire.Core.Extensions;

    /// <summary>
    /// Contains an enumerated list of project assignment state types.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum ProjectAssignmentStateType
    {
        /// <summary>
        /// Contains a value that indicates the assignment is ready to work on.
        /// </summary>
        ToDo,

        /// <summary>
        /// Contains a value that indicates the assignment is being worked on.
        /// </summary>
        InProgress,

        /// <summary>
        /// Contains a value that indicates the assignment has been completed.
        /// </summary>
        Completed,

        /// <summary>
        /// Contains a value that indicates the assignment has been cancelled.
        /// </summary>
        Cancelled
    }

    /// <summary>
    /// This class represents a project assignment state model within projects.
    /// </summary>
    public class ProjectAssignmentStateModel
    {        
        /// <summary>
        /// Gets or sets the project assignment state identity.
        /// </summary>
        [JsonIgnore]
        public ProjectAssignmentStateType AssignmentState { get; set; } = ProjectAssignmentStateType.ToDo;

        /// <summary>
        /// Gets or sets the project assignment state name.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the project assignment state via a textual value.
        /// </summary>
        public string ProjectAssignmentStateId
        {
            get => this.AssignmentState.ToString();
            set => this.AssignmentState = value.ToEnum<ProjectAssignmentStateType>();
        }
    }
}
