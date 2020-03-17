//-----------------------------------------------------------------
// <copyright file="ImportPluginParameterValueModel.cs" company="GlobalLink Vasont">
// Copyright (c) GlobalLink Vasont. All rights reserved.
// </copyright>
//-----------------------------------------------------------------
namespace Vasont.Inspire.Models.Plugins
{
    /// <summary>
    /// This class represents an import plugin parameter value within the application.
    /// </summary>
    public class ImportPluginParameterValueModel
    {
        /// <summary>
        /// Gets or sets the identity of the import plugin parameter value.
        /// </summary>
        public long ImportPluginParameterValueId { get; set; }

        /// <summary>
        /// Gets or sets the identity of the import plugin.
        /// </summary>
        public long ImportPluginId { get; set; }

        /// <summary>
        /// Gets or sets the identity of the plugin parameter.
        /// </summary>
        public long PluginParameterId { get; set; }

        /// <summary>
        /// Gets or sets the value of the sort order.
        /// </summary>
        public int SortOrder { get; set; }

        /// <summary>
        /// Gets or sets the value of the plugin parameter.
        /// </summary>
        public string Value { get; set; }
    }
}
