//-------------------------------------------------------------
// <copyright file="ElementModel.cs" company="GlobalLink Vasont">
// Copyright (c) GlobalLink Vasont. All rights reserved.
// </copyright>
//-------------------------------------------------------------
namespace Vasont.Inspire.Models.Configuration
{
    /// <summary>
    /// This class represents an element within the system and is to be used for interaction with application user interfaces.
    /// </summary>
    public class ElementModel
    {
        /// <summary>
        /// Gets or sets the Id of the element.
        /// </summary>
        public long ElementId { get; set; }

        /// <summary>
        /// Gets or sets the name of the element.
        /// </summary>
        public string ElementName { get; set; }
    }
}