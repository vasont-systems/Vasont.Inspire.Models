//-----------------------------------------------------------------------
// <copyright file="PublishingProfileModel.cs" company="GlobalLink Vasont">
// Copyright (c) GlobalLink Vasont. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------
namespace Vasont.Inspire.Models.Publishing
{
    using System;
    using Vasont.Inspire.Models.Components;
    using Vasont.Inspire.Models.Security;
    using Vasont.Inspire.Models.Transfers;

    /// <summary>
    /// This model class represents the profile detail for a publishing profile.
    /// </summary>
    public class PublishingProfileModel
    {
        /// <summary>
        /// Gets or sets the profile identity.
        /// </summary>
        public long ProfileId { get; set; }

        /// <summary>
        /// Gets or sets the profile name.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the description of the profile.
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets the component identity.
        /// </summary>
        public long ComponentId { get; set; }

        /// <summary>
        /// Gets or sets the component information about the component associated with the publishing profile.
        /// </summary>
        public MicroComponentModel Component { get; set; } = new MicroComponentModel();

        /// <summary>
        /// Gets or sets a value indicating whether the profile should be validated.
        /// </summary>
        public bool SkipXmlValidation { get; set; } = false;

        /// <summary>
        /// Gets or sets the filter condition for the profile.
        /// </summary>
        public string Filter { get; set; }

        /// <summary>
        /// Gets or sets a value indicating with the export config id.
        /// </summary>
        public long ExportId { get; set; }

        /// <summary>
        /// Gets or sets the export configuration associated with the publishing profile.
        /// </summary>
        public MinimalExportModel ExportConfig { get; set; } = new MinimalExportModel();

        /// <summary>
        /// Gets or sets a value indicating whether the publishing profile is archived.
        /// </summary>
        public bool Archived { get; set; }

        /// <summary>
        /// Gets or sets the publishing profile archival date time.
        /// </summary>
        public DateTime? ArchivedDate { get; set; }

        /// <summary>
        /// Gets or sets the date time when the profile was created.
        /// </summary>
        public DateTime CreatedDate { get; set; }

        /// <summary>
        /// Gets or sets the user information about the user who last updated the profile.
        /// </summary>
        public MinimalUserModel CreatedBy { get; set; } = new MinimalUserModel();

        /// <summary>
        /// Gets or sets the date time when the profile was last updated.
        /// </summary>
        public DateTime UpdatedDate { get; set; }

        /// <summary>
        /// Gets or sets the user information about the user who last updated the profile.
        /// </summary>
        public MinimalUserModel UpdatedBy { get; set; } = new MinimalUserModel();

        /// <summary>
        /// Gets or sets the date time when the profile was last published.
        /// </summary>
        public DateTime? LastPublishedDate { get; set; }

        /// <summary>
        /// Gets or sets the user information about the user who last published the profile.
        /// </summary>
        public MinimalUserModel LastPublishedBy { get; set; } = new MinimalUserModel();
    }
}
