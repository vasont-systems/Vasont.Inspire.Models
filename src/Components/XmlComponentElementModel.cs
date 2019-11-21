//-----------------------------------------------------------------------
// <copyright file="XmlComponentElementModel.cs" company="GlobalLink Vasont">
// Copyright (c) GlobalLink Vasont. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------
namespace Vasont.Inspire.Models.Components
{
    /// <summary>
    /// This class represents an XML Element within an XML Component in the application
    /// </summary>
    public class XmlComponentElementModel
    {
        /// <summary>
        /// Gets or sets the document root id for the element.
        /// </summary>
        public string RootId { get; set; }

        /// <summary>
        /// Gets or sets the element name.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the element id.
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// Gets or sets the element value.
        /// </summary>
        public string Value { get; set; }
    }
}
