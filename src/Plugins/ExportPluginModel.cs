//-----------------------------------------------------------------
// <copyright file="ExportPluginModel.cs" company="GlobalLink Vasont">
// Copyright (c) GlobalLink Vasont. All rights reserved.
// </copyright>
//-----------------------------------------------------------------
namespace Vasont.Inspire.Models.Plugins
{
    using System.Collections.Generic;

    /// <summary>
    /// This class represents an export plugin within the application.
    /// </summary>
    public class ExportPluginModel
    {
        /// <summary>
        /// Gets or sets the identity of the export plugin.
        /// </summary>
        public long ExportPluginId { get; set; }

        /// <summary>
        /// Gets or sets the identity of the export.
        /// </summary>
        public long ExportId { get; set; }

        /// <summary>
        /// Gets or sets the identity of the plugin.
        /// </summary>
        public long PluginId { get; set; }

        /// <summary>
        /// Gets or sets the plugin.
        /// </summary>
        public PluginModel Plugin { get; set; } = new PluginModel();

        /// <summary>
        /// Gets or sets the plugin parameter values.
        /// </summary>
        public List<ExportPluginParameterValueModel> PluginParameterValues { get; set; } = new List<ExportPluginParameterValueModel>();

        /// <summary>
        /// Gets or sets the sort order in which this plugin will be processed.
        /// </summary>
        public int SortOrder { get; set; }
    }
}