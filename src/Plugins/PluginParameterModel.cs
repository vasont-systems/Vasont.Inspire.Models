﻿//-------------------------------------------------------------
// <copyright file="PluginParameterModel.cs" company="GlobalLink Vasont">
// Copyright (c) GlobalLink Vasont. All rights reserved.
// </copyright>
//-------------------------------------------------------------
namespace Vasont.Inspire.Models.Plugins
{
    using System;

    /// TODO: Remove model.
    /// <summary>
    /// This class represents a plugin parameter within the application.
    /// </summary>
    [Obsolete("No longer used, in favor of DTOs in the projects.")]
    public class PluginParameterModel
    {
        /// <summary>
        /// Gets or sets the identity of the Plugin Parameter.
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