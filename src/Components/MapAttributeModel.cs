//-----------------------------------------------------------------------
// <copyright file="MapAttributeModel.cs" company="GlobalLink Vasont">
// Copyright (c) GlobalLink Vasont. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace Vasont.Inspire.Models.Components
{
    /// <summary>
    /// This class represents a map attribute definition for the application.
    /// </summary>
    public class MapAttributeModel
    {
        /// <summary>
        /// Gets or sets the attribute name.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the attribute value.
        /// </summary>
        public string Value { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this is a tracked attribute within the Inspire map configuration.
        /// </summary>
        public bool IsTracked { get; set; }

        /// <summary>
        /// Gets or sets the UI metadata for the attribute.
        /// </summary>
        public MapAttributeUiMetadataModel Metadata { get; set; } = new MapAttributeUiMetadataModel();
    }
}
