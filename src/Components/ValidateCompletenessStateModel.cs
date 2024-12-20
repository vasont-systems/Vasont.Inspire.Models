﻿//-------------------------------------------------------------
// <copyright file="ValidateCompletenessStateModel.cs" company="GlobalLink Vasont">
// Copyright (c) GlobalLink Vasont. All rights reserved.
// </copyright>
//-------------------------------------------------------------
namespace Vasont.Inspire.Models.Components
{
    using System;
    using System.Collections.Generic;
    using Vasont.Inspire.Models.Transfers;

    /// <summary>
    /// This class contains the state for component completeness request worker within the application.
    /// </summary>
    [Obsolete("Use local DTOs", true)]
    public class ValidateCompletenessStateModel
    {
        /// <summary>
        /// Gets or sets the process identity.
        /// </summary>
        public Guid ProcessId { get; set; }

        /// <summary>
        /// Gets or sets a value indicating the export configuration id to use when selecting references.
        /// </summary>
        public long ExportId { get; set; }

        /// <summary>
        /// Gets or sets an optional list of profile filters.
        /// </summary>
        public List<ExportProfileAttributeFilterModel> ProfileFilters { get; set; } = new List<ExportProfileAttributeFilterModel>();

        /// <summary>
        /// Gets or sets a list of source component names.
        /// </summary>
        public List<string> SourceComponentNames { get; set; } = new List<string>();

        /// <summary>
        /// Gets or sets a list of current components to process.
        /// </summary>
        public List<long> ComponentIds { get; set; } = new List<long>();

        /// <summary>
        /// Gets or sets the xml content to validate.
        /// </summary>
        public string XmlContent { get; set; }
    }
}
