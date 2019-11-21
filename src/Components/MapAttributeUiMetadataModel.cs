//-------------------------------------------------------------
// <copyright file="MapAttributeUiMetadataModel.cs" company="GlobalLink Vasont">
// Copyright (c) GlobalLink Vasont. All rights reserved.
// </copyright>
//-------------------------------------------------------------
namespace Vasont.Inspire.Models.Components
{
    using Schema;

    /// <summary>
    /// This class defines the UI metadata properties for an attribute within the map editor data.
    /// </summary>
    public class MapAttributeUiMetadataModel
    {
        /// <summary>
        /// Gets or sets the identity of the configuration record used for the attribute.
        /// </summary>
        public string ConfigAttributeId { get; set; }

        /// <summary>
        /// Gets or sets the display name for the attribute.
        /// </summary>
        public string DisplayName { get; set; }

        /// <summary>
        /// Gets or sets the attribute definition type.
        /// </summary>
        public ComponentConfigurationAttributeType AttributeType { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the attribute is required.
        /// </summary>
        public bool Required { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the attribute is read only.
        /// </summary>
        public bool ReadOnly { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the attribute is visible in the user interface.
        /// </summary>
        public bool Visible { get; set; }

        /// <summary>
        /// Gets or sets a sort order value for displaying the attribute.
        /// </summary>
        public int SortOrder { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the attribute is configured for profiling.
        /// </summary>
        public bool Profiled { get; set; }

        /// <summary>
        /// Gets or sets an optional regular expression string for attribute value input validation.
        /// </summary>
        public string RegEx { get; set; }
    }
}