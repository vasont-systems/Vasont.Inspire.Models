﻿//-------------------------------------------------------------
// <copyright file="ExportModel.cs" company="GlobalLink Vasont">
// Copyright (c) GlobalLink Vasont. All rights reserved.
// </copyright>
//-------------------------------------------------------------

namespace Vasont.Inspire.Models.Transfers
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using Vasont.Inspire.Models.Components;
    using Vasont.Inspire.Models.Plugins;

    /// <summary>
    /// Contains an enumerated list of export types.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum ExportType
    {
        /// <summary>
        /// The export is standard.
        /// </summary>
        Standard,

        /// <summary>
        /// The export is used to publish.
        /// </summary>
        Publish
    }

    /// <summary>
    /// This class represents an export model for use within the application.
    /// </summary>
    public class ExportModel : MinimalExportModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ExportModel"/> class.
        /// </summary>
        public ExportModel()
        {
            this.ExportRelations = new List<MinimalExportRelationModel>();
            this.ComponentTypes = new List<MinimalComponentTypeModel>();
            this.Plugins = new List<ExportPluginModel>();
            this.Type = ExportType.Standard;
        }

        /// <summary>
        /// Gets or sets a description of the export.
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the export is currently active.
        /// </summary>
        public bool Active { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this is a default export..
        /// </summary>
        public bool Default { get; set; }

        /// <summary>
        /// Gets or sets the export type.
        /// </summary>
        public ExportType Type { get; set; }

        /// <summary>
        /// Gets or sets a list of <see cref="MinimalExportRelationModel"/>  objects that will be processed by the export.
        /// </summary>
        public List<MinimalExportRelationModel> ExportRelations { get; set; }

        /// <summary>
        /// Gets or sets a list of <see cref="MinimalComponentTypeModel"/> objects that define which component types are allowed to be used with the export.
        /// </summary>
        public List<MinimalComponentTypeModel> ComponentTypes { get; set; }

        /// <summary>
        /// Gets or sets a list of <see cref="ExportPluginModel"/> objects that are to be used with the export.
        /// </summary>
        public List<ExportPluginModel> Plugins { get; set; }
    }
}
