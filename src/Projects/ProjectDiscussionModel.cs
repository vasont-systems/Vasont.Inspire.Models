//-----------------------------------------------------------------------
// <copyright file="ProjectDiscussionModel.cs" company="GlobalLink Vasont">
// Copyright (c) GlobalLink Vasont. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------
namespace Vasont.Inspire.Models.Projects
{
    using System;
    using Vasont.Inspire.Models.Security;

    /// <summary>
    /// This class represents a project discussion for use in transferring project details to the application.
    /// </summary>
    public class ProjectDiscussionModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectDiscussionModel"/> class.
        /// </summary>
        public ProjectDiscussionModel()
        {
            this.CreatedDate = DateTime.UtcNow;
            this.Author = new MinimalUserModel();
        }

        /// <summary>
        /// Gets or sets the project discussion identity value.
        /// </summary>
        public long ProjectDiscussionId { get; set; }

        /// <summary>
        /// Gets or sets the related project identity value.
        /// </summary>
        public long ProjectId { get; set; }

        /// <summary>
        /// Gets or sets the author information about the project discussion message.
        /// </summary>
        public MinimalUserModel Author { get; set; }

        /// <summary>
        /// Gets or sets the date and time of the discussion message creation.
        /// </summary>
        public DateTime CreatedDate { get; set; }

        /// <summary>
        /// Gets or sets the discussion message.
        /// </summary>
        public string Message { get; set; }
    }
}
