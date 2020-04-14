//-------------------------------------------------------------
// <copyright file="ProjectBrowseModel.cs" company="GlobalLink Vasont">
// Copyright (c) GlobalLink Vasont. All rights reserved.
// </copyright>
//-------------------------------------------------------------
namespace Vasont.Inspire.Models.Projects
{
    using System;
    using System.Collections.Generic;
    using Vasont.Inspire.Models.Security;

    /// <summary>
    /// This class represents a minimal project browse model within the application.
    /// </summary>
    public class ProjectBrowseModel
    {
        /// <summary>
        /// Gets or sets the project identity value.
        /// </summary>
        public long ProjectId { get; set; }

        /// <summary>
        /// Gets or sets the project title.
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Gets or sets the project description.
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets the project owner's full name.
        /// </summary>
        public string OwnerFullName { get; set; }

        /// <summary>
        /// Gets or sets the project owner's email address
        /// </summary>
        public string OwnerEmail { get; set; }

        /// <summary>
        /// Gets or sets the project owner's email address
        /// </summary>
        public MicroUserModel Owner { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the project has been completed.
        /// </summary>
        public bool Completed { get; set; }

        /// <summary>
        /// Gets or sets the project completion date time.
        /// </summary>
        public DateTime? CompletedDate { get; set; }

        /// <summary>
        /// Gets or sets the project completed by date time.
        /// </summary>
        public DateTime? CompleteByDate { get; set; }

        /// <summary>
        /// Gets or sets the project created date time.
        /// </summary>
        public DateTime? CreatedDate { get; set; }

        /// <summary>
        /// Gets or sets the project due date time.
        /// </summary>
        public DateTime? DueDate { get; set; }

        /// <summary>
        /// Gets or sets the project updated date time.
        /// </summary>
        public DateTime? UpdatedDate { get; set; }

        /// <summary>
        /// Gets or sets the number of components assigned to this project.
        /// </summary>
        public int ComponentCount { get; set; }

        /// <summary>
        /// Gets or sets the number of project assignments that have not been started.
        /// </summary>
        public int ToDoAssignmentCount { get; set; }

        /// <summary>
        /// Gets or sets the number of project assignments that are in progress.
        /// </summary>
        public int InProgressAssignmentCount { get; set; }

        /// <summary>
        /// Gets or sets the number of project assignments that are completed.
        /// </summary>
        public int CompletedAssignmentCount { get; set; }

        /// <summary>
        /// Gets or sets the number of project assignments that are cancelled.
        /// </summary>
        public int CancelledAssignmentCount { get; set; }

        /// <summary>
        /// Gets or sets the most recent project access information.
        /// </summary>
        public string MostRecentAccessFullName { get; set; }

        /// <summary>
        /// Gets or sets the most recent project access email.
        /// </summary>
        public string MostRecentAccessEmail { get; set; }

        /// <summary>
        /// Gets or sets the most recent project access date.
        /// </summary>
        public DateTime? MostRecentAccessDate { get; set; }

        /// <summary>
        /// Gets or sets a list of languages codes.
        /// </summary>
        public List<string> Languages { get; set; } = new List<string>();
    }
}