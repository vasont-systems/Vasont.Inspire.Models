//-----------------------------------------------------------------------
// <copyright file="MinimalProjectModel.cs" company="GlobalLink Vasont">
// Copyright (c) GlobalLink Vasont. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace Vasont.Inspire.Models.Projects
{
    using System;
    using System.Collections.Generic;
    using Vasont.Inspire.Models.Common;
    using Vasont.Inspire.Models.Security;

    /// <summary>
    /// This class represents a minimal project model within the application.
    /// </summary>
    public class MinimalProjectModel
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
        /// Gets or sets the project owner's user information.
        /// </summary>
        public MinimalUserModel Owner { get; set; } = new MinimalUserModel();

        /// <summary>
        /// Gets or sets the date time when the project was created.
        /// </summary>
        public DateTime CreatedDate { get; set; }

        /// <summary>
        /// Gets or sets the project start by date time.
        /// </summary>
        public DateTime? StartByDate { get; set; }

        /// <summary>
        /// Gets or sets the project actual start date time.
        /// </summary>
        public DateTime? ActualStartDate { get; set; }

        /// <summary>
        /// Gets or sets the project completed by date time.
        /// </summary>
        public DateTime? CompleteByDate { get; set; }

        /// <summary>
        /// Gets or sets the project due date time.
        /// </summary>
        public DateTime? DueDate { get; set; }

        /// <summary>
        /// Gets or sets the date time when the project was last updated.
        /// </summary>
        public DateTime UpdatedDate { get; set; }

        /// <summary>
        /// Gets or sets the user information about the user who last updated the project.
        /// </summary>
        public MinimalUserModel UpdatedBy { get; set; } = new MinimalUserModel();

        /// <summary>
        /// Gets or sets a value indicating whether the project is complete.
        /// </summary>
        public bool Completed { get; set; }

        /// <summary>
        /// Gets or sets the project completion date time.
        /// </summary>
        public DateTime? CompletedDate { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the project is archived.
        /// </summary>
        public bool Archived { get; set; }

        /// <summary>
        /// Gets or sets the project archival date time.
        /// </summary>
        public DateTime? ArchivedDate { get; set; }

        /// <summary>
        /// Gets or sets the number of components assigned to this project.
        /// </summary>
        public int ComponentCount { get; set; }

        /// <summary>
        /// Gets or sets the number of project discussion messages.
        /// </summary>
        public int DiscussionMessageCount { get; set; }

        /// <summary>
        /// Gets or sets the number of project pending assignments.
        /// </summary>
        public int PendingAssignmentCount { get; set; }

        /// <summary>
        /// Gets or sets the number of project started assignments.
        /// </summary>
        public int StartedAssignmentCount { get; set; }

        /// <summary>
        /// Gets or sets the number of project completed assignments.
        /// </summary>
        public int CompletedAssignmentCount { get; set; }

        /// <summary>
        /// Gets or sets the type of project. Owned, Participating, Owned/Participating.
        /// </summary>
        public string Type { get; set; }

        /// <summary>
        /// Gets or sets the optional default system folder identity value.
        /// </summary>
        public long? SystemFolderId { get; set; }

        /// <summary>
        /// Gets or sets the optional default system folder name.
        /// </summary>
        public string SystemFolderName { get; set; }

        /// <summary>
        /// Gets or sets the optional default system path name.
        /// </summary>
        public string SystemFolderPath { get; set; }

        /// <summary>
        /// Gets or sets the most recent project access information.
        /// </summary>
        public MinimalProjectUserAccessModel MostRecentAccess { get; set; }

        /// <summary>
        /// Gets or sets the number of project accesses.
        /// </summary>
        public int UserAccessCount { get; set; }

        /// <summary>
        /// Gets or sets a list of <see cref="MinimalLanguageModel"/> objects.
        /// </summary>
        public List<MinimalLanguageModel> Languages { get; set; } = new List<MinimalLanguageModel>();

        /// <summary>
        /// Gets or sets a list of <see cref="ProjectParticipantModel"/> objects.
        /// </summary>
        public List<ProjectParticipantModel> Participants { get; set; } = new List<ProjectParticipantModel>();
    }
}
