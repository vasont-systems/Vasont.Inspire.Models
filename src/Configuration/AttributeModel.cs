//-------------------------------------------------------------
// <copyright file="AttributeModel.cs" company="Vasont Systems">
// Copyright (c) Vasont Systems. All rights reserved.
// </copyright>
//-------------------------------------------------------------
namespace Vasont.Inspire.Models.Configuration
{
    /// <summary>
    /// This class represents an attribute within the system and is to be used for interaction with application user interfaces.
    /// </summary>
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
    }
}