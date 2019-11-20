//-------------------------------------------------------------
// <copyright file="MapNodeUiMetadataModel.cs" company="Vasont Systems">
// Copyright (c) Vasont Systems. All rights reserved.
// </copyright>
//-------------------------------------------------------------
namespace Vasont.Inspire.Models.Components
{
    using Schema;

    /// <summary>
    /// This class represents the metadata associated to the model.
    /// </summary>
    public class MapNodeUiMetadataModel
    {
        /// <summary>
        /// Gets or sets the identity of the configuration used for the element.
        /// </summary>
        public string ConfigElementId { get; set; }

        /// <summary>
        /// Gets or sets the display name for the element.
        /// </summary>
        public string DisplayName { get; set; }
        
        /// <summary>
        /// Gets or sets the element definition type.
        /// </summary>
        public ComponentConfigurationElementType ElementType { get; set; }

        /// <summary>
        /// Gets or sets the element definition role.
        /// </summary>
        public ComponentConfigurationElementModeRole ElementRole { get; set; }
    }
}