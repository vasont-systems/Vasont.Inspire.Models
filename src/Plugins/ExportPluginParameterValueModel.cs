//-------------------------------------------------------------
// <copyright file="ExportPluginParameterValueModel.cs" company="Vasont Systems">
// Copyright (c) 2019 Vasont Systems. All rights reserved.
// </copyright>
//-------------------------------------------------------------
namespace Vasont.Inspire.Models.Plugins
{
    /// <summary>
    /// This class represents Export plugin parameter values within the application.
    /// </summary>
    public class ExportPluginParameterValueModel
    {
        /// <summary>
        /// Gets or sets the identity of the export plugin parameter value.
        /// </summary>
        public long ExportPluginParameterValueId { get; set; }

        /// <summary>
        /// Gets or sets the identity of the export plugin.
        /// </summary>
        public long ExportPluginId { get; set; }

        /// <summary>
        /// Gets or sets the identity of the plugin parameter.
        /// </summary>
        public long PluginParameterId { get; set; }

        /// <summary>
        /// Gets or sets the value of the sort order.
        /// </summary>
        public short SortOrder { get; set; }

        /// <summary>
        /// Gets or sets the value of the plugin parameter.
        /// </summary>
        public string Value { get; set; }
    }
}