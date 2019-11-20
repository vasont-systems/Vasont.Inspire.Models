//-------------------------------------------------------------
// <copyright file="ComponentConfigurationModel.cs" company="Vasont Systems">
// Copyright (c) Vasont Systems. All rights reserved.
// </copyright>
//-------------------------------------------------------------
namespace Vasont.Inspire.Models.Components.Schema
{
    using System;
    using System.Collections.Generic;
    using Vasont.Inspire.Models.Security;

    /// <summary>
    /// This class represents a component structure configuration model.
    /// </summary>
    public class ComponentConfigurationModel
    {
        /// <summary>
        /// Gets or sets the unique identity of the configuration.
        /// </summary>
        public long ConfigurationId { get; set; }

        /// <summary>
        /// Gets or sets the map configuration title.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the component type associated with this configuration.
        /// </summary>
        public MinimalComponentTypeModel ComponentType { get; set; }
        
        /// <summary>
        /// Gets or sets a list of elements that define the structure and relationships within the component.
        /// </summary>
        public List<ComponentElementModel> Elements { get; set; } = new List<ComponentElementModel>();

        /// <summary>
        /// Gets or sets the date time when the record was created.
        /// </summary>
        public DateTime CreatedDate { get; set; }

        /// <summary>
        /// Gets or sets the user model of the creating user.
        /// </summary>
        public MinimalUserModel CreatedBy { get; set; }

        /// <summary>
        /// Gets or sets the date time when the record was last updated.
        /// </summary>
        public DateTime UpdatedDate { get; set; }

        /// <summary>
        /// Gets or sets the user model of the updating user.
        /// </summary>
        public MinimalUserModel UpdatedBy { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the component type is active.
        /// </summary>
        public bool Active { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the component type is a default.
        /// </summary>
        public bool Default { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the component can be used with the content editor.
        /// </summary>
        public bool CanUseContentEditor { get; set; }

        /// <summary>
        /// Gets or sets the JSON configuration value.
        /// </summary>
        public string JsonConfig { get; set; }
    }
}
