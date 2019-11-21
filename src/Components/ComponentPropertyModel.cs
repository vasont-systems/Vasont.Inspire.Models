//-----------------------------------------------------------------------
// <copyright file="ComponentPropertyModel.cs" company="GlobalLink Vasont">
// Copyright (c) GlobalLink Vasont. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------
namespace Vasont.Inspire.Models.Components
{
    /// <summary>
    /// This class represents a component property within the application.
    /// </summary>
    public class ComponentPropertyModel
    {
        /// <summary>
        /// Gets or sets the property identity value.
        /// </summary>
        public long PropertyId { get; set; }

        /// <summary>
        /// Gets or sets the unique name key for the property.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the display name for the property.
        /// </summary>
        public string DisplayName { get; set; }
    }
}