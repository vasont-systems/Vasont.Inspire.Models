//-------------------------------------------------------------
// <copyright file="ValidateCompletenessStateModel.cs" company="GlobalLink Vasont">
// Copyright (c) GlobalLink Vasont. All rights reserved.
// </copyright>
//-------------------------------------------------------------
namespace Vasont.Inspire.Models.Components
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// This class contains the state for component completeness request worker within the application.
    /// </summary>
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
        /// Gets or sets a list of source component names.
        /// </summary>
        public List<string> SourceComponentNames { get; set; }

        /// <summary>
        /// Gets or sets a list of current components to process.
        /// </summary>
        public List<long> ComponentIds { get; set; } = new List<long>();
    }
}
