//----------------------------------------------------------------------------
// <copyright file="MinimalProfileAttributeModel.cs" company="GlobalLink Vasont">
// Copyright (c) GlobalLink Vasont. All rights reserved.
// </copyright>
//---------------------------------------------------------------------------
namespace Vasont.Inspire.Models.Components.Schema
{
    /// <summary>
    /// This class defines the properties of a minimal profile attribute model.
    /// </summary>
    public class MinimalProfileAttributeModel
    {
        /// <summary>
        /// Gets or sets the identity of the attribute within the component configuration attribute table.
        /// </summary>
        public long AttributeId { get; set; }

        /// <summary>
        /// Gets or sets the simple display name of the attribute.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the XML rendering text for the attribute.
        /// </summary>
        public string XmlName { get; set; }
    }
}