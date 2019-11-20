//-------------------------------------------------------------
// <copyright file="PluginParameterModel.cs" company="Vasont Systems">
// Copyright (c) 2019 Vasont Systems. All rights reserved.
// </copyright>
//-------------------------------------------------------------
namespace Vasont.Inspire.Models.Plugins
{
    /// <summary>
    /// This class represents a plugin parameter within the application.
    /// </summary>
    public class PluginParameterModel
    {
        /// <summary>
        /// Gets or sets the identity of the Plugin Parameter
        /// </summary>
        public long PluginParameterId { get; set; }

        /// <summary>
        /// Gets or sets the identity of the plugin this parameter is associated with.
        /// </summary>
        public long PluginId { get; set; }

        /// <summary>
        /// Gets or sets the name of the parameter.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether or not this parameter is required.
        /// </summary>
        public bool Required { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether or not this parameter is repeatable.
        /// </summary>
        public bool Repeatable { get; set; }
    }
}