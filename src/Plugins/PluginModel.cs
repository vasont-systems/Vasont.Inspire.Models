//-----------------------------------------------------------
// <copyright file="PluginModel.cs" company="GlobalLink Vasont">
// Copyright (c) GlobalLink Vasont. All rights reserved.
// </copyright>
//-----------------------------------------------------------
namespace Vasont.Inspire.Models.Plugins
{
    /// <summary>
    /// This class represents a plugin within the application.
    /// </summary>
    public class PluginModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PluginModel"/> class.
        /// </summary>
        public PluginModel()
        {
            this.SystemEvent = new SystemEventModel();
        }

        /// <summary>
        /// Gets or sets the identity of the plugin.
        /// </summary>
        public long PluginId { get; set; }

        /// <summary>
        /// Gets or sets the name of the plugin.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the plugin is repeatable for a specific export.
        /// </summary>
        public bool Repeatable { get; set; }

        /// <summary>
        /// Gets or sets the system event associated with the plugin.
        /// </summary>
        public SystemEventModel SystemEvent { get; set; }
    }
}