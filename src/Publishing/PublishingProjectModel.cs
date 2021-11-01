//-----------------------------------------------------------------------
// <copyright file="PublishingProjectModel.cs" company="GlobalLink Vasont">
// Copyright (c) GlobalLink Vasont. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------
namespace Vasont.Inspire.Models.Publishing
{
    using System;
    using Vasont.Inspire.Models.Security;

    /// <summary>
    /// This model class represents the project detail for a publishing project.
    /// </summary>
    public class PublishingProjectModel
    {
        /// <summary>
        /// Gets or sets the project identity.
        /// </summary>
        public long ProjectId { get; set; }

        /// <summary>
        /// Gets or sets the project title.
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Gets or sets the description of the project.
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets the component identity.
        /// </summary>
        public long ComponentId { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the project should be validated.
        /// </summary>
        public bool SkipValidation { get; set; } = false;

        /// <summary>
        /// Gets or sets the filter condition for the project.
        /// </summary>
        public string Filter { get; set; }

        /// <summary>
        /// Gets or sets a value indicating with the export config id.
        /// </summary>
        public long ExportId { get; set; }

        /// <summary>
        /// Gets or sets the date time when the project was created.
        /// </summary>
        public DateTime CreatedDate { get; set; }

        /// <summary>
        /// Gets or sets the user information about the user who last updated the project.
        /// </summary>
        public MinimalUserModel CreatedBy { get; set; } = new MinimalUserModel();

        /// <summary>
        /// Gets or sets the date time when the project was last updated.
        /// </summary>
        public DateTime UpdatedDate { get; set; }

        /// <summary>
        /// Gets or sets the user information about the user who last updated the project.
        /// </summary>
        public MinimalUserModel UpdatedBy { get; set; } = new MinimalUserModel();

        /// <summary>
        /// Gets or sets the date time when the project was last published.
        /// </summary>
        public DateTime LastPublishedDate { get; set; }

        /// <summary>
        /// Gets or sets the user information about the user who last published the project.
        /// </summary>
        public MinimalUserModel LastPublishedBy { get; set; } = new MinimalUserModel();
    }
}
