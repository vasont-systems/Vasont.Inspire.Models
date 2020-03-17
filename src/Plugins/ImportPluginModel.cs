//-----------------------------------------------------------------
// <copyright file="ImportPluginModel.cs" company="GlobalLink Vasont">
// Copyright (c) GlobalLink Vasont. All rights reserved.
// </copyright>
//-----------------------------------------------------------------
namespace Vasont.Inspire.Models.Plugins
{
    using System.Collections.Generic;

    /// <summary>
    /// This class represents an import plugin within the application.
    /// </summary>
    public class ImportPluginModel
    {
        /// <summary>
        /// Gets or sets the identity of the import plugin.
        /// </summary>
        public long ImportPluginId { get; set; }

        /// <summary>
        /// Gets or sets the identity of the import.
        /// </summary>
        public long ImportId { get; set; }

        /// <summary>
        /// Gets or sets the identity of the plugin.
        /// </summary>
        public long PluginId { get; set; }

        /// <summary>
        /// Gets or sets the plugin.
        /// </summary>
        public PluginModel Plugin { get; set; }

        /// <summary>
        /// Gets or sets the plugin parameter values.
        /// </summary>
        public List<ImportPluginParameterValueModel> PluginParameterValues { get; set; } = new List<ImportPluginParameterValueModel>();

        /// <summary>
        /// Gets or sets the sort order in which this plugin will be processed.
        /// </summary>
        public int SortOrder { get; set; }
    }
}
