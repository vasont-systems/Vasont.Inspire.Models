﻿//-----------------------------------------------------------------------
// <copyright file="ExportRequestModel.cs" company="GlobalLink Vasont">
// Copyright (c) GlobalLink Vasont. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------
namespace Vasont.Inspire.Models.Transfers
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// This class contains properties and information to request the system to start an export process.
    /// </summary>
    public class ExportRequestModel 
    {
        /// <summary>
        /// Gets or sets the changeset identity related to the components that are to be exported.
        /// </summary>
        public Guid ChangesetId { get; set; }

        /// <summary>
        /// Gets or sets the export identity used for the exporting of the components specified.
        /// </summary>
        public long ExportId { get; set; }

        /// <summary>
        /// Gets or sets a list of component identities to export.
        /// </summary>
        public List<long> ComponentIdsToExport { get; set; } = new List<long>();

        /// <summary>
        /// Gets or sets a value indicating whether the exported content is always archived to a zip file.
        /// </summary>
        public bool AlwaysZipResults { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether [send notification].
        /// </summary>
        public bool SendNotification { get; set; } = true;

        /// <summary>
        /// Gets or sets an optional list of profile filters.
        /// </summary>
        public List<ExportProfileAttributeFilterModel> ProfileFilters { get; set; } = new List<ExportProfileAttributeFilterModel>();
    }
}