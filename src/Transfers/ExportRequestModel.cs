//-----------------------------------------------------------------------
// <copyright file="ExportRequestModel.cs" company="GlobalLink Vasont">
// Copyright (c) GlobalLink Vasont. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------
namespace Vasont.Inspire.Models.Transfers
{
    using System.Collections.Generic;
    using Vasont.Inspire.Models.Versioning;

    /// <summary>
    /// This class contains properties and information to request the system to start an export process.
    /// </summary>
    public class ExportRequestModel
    {
        /// <summary>
        /// Gets or sets the changeset identity related to the components that are to be exported.
        /// </summary>
        public List<ChangesetRequestModel> ChangesetsToExport { get; set; } = new List<ChangesetRequestModel>();

        /// <summary>
        /// Gets or sets the export identity used for the exporting of the components specified.
        /// </summary>
        public long ExportId { get; set; }

        /// <summary>
        /// Gets or sets the user identity for whom the request is generated.
        /// </summary>
        public long UserId { get; set; }

        /// <summary>
        /// Gets or sets the optional publish profile identity.
        /// </summary>
        public long PublishProfileId { get; set; }

        /// <summary>
        /// Gets or sets a list of component identities to export.
        /// </summary>
        public List<long> ComponentIdsToExport { get; set; } = new List<long>();

        /// <summary>
        /// Gets or sets a value indicating whether the exported content is always archived to a zip file.
        /// </summary>
        public bool AlwaysZipResults { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether notifications are sent.
        /// </summary>
        public bool SendNotification { get; set; } = true;

        /// <summary>
        /// Gets or sets an optional list of profile filters.
        /// </summary>
        public List<ExportProfileAttributeFilterModel> ProfileFilters { get; set; } = new List<ExportProfileAttributeFilterModel>();

        /// <summary>
        /// Gets or sets a value indicating whether the exported content should be locked.
        /// </summary>
        public bool LockForEdit { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the exported content should be validated.
        /// </summary>
        public bool SkipXmlValidation { get; set; } = false;

        /// <summary>
        /// Gets or sets a value indicating whether the file subfolder structure should be created during export.
        /// </summary>
        public bool CreateSubfolders { get; set; } = false;
    }
}