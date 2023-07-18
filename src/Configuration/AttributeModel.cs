//-------------------------------------------------------------
// <copyright file="AttributeModel.cs" company="GlobalLink Vasont">
// Copyright (c) GlobalLink Vasont. All rights reserved.
// </copyright>
//-------------------------------------------------------------
namespace Vasont.Inspire.Models.Configuration
{
    using System;

    /// <summary>
    /// This class represents an attribute within the system and is to be used for interaction with application user interfaces.
    /// </summary>
    [Obsolete("Use local DTOs", false)]
    public class AttributeModel
    {
        /// <summary>
        /// Gets or sets the Id of the element.
        /// </summary>
        public long AttributeId { get; set; }

        /// <summary>
        /// Gets or sets the name of the element.
        /// </summary>
        public string AttributeName { get; set; }

        /// <summary>
        /// Gets or sets the display name of the element.
        /// </summary>
        public string AttributeDisplayName { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets a value indicating whether the attribute is a profiling attribute.
        /// </summary>
        public bool Profiled { get; set; } = false;

        /// <summary>
        /// Gets or sets a value indicating whether the attribute is an identifier.
        /// </summary>
        public bool Identifier { get; set; } = false;

        /// <summary>
        /// Gets or sets the schema standard key name for the attribute.
        /// </summary>
        public string SchemaStandardKeyName { get; set; } = string.Empty;
    }
}