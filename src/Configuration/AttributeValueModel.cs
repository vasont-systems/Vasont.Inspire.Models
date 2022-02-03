//-------------------------------------------------------------
// <copyright file="AttributeValueModel.cs" company="GlobalLink Vasont">
// Copyright (c) GlobalLink Vasont. All rights reserved.
// </copyright>
//-------------------------------------------------------------
namespace Vasont.Inspire.Models.Configuration
{
    /// <summary>
    /// This class represents an attribute value ithin the system and is to be used for interaction with application user interfaces.
    /// </summary>
    public class AttributeValueModel
    {
        /// <summary>
        /// Gets or sets the attribute value id of the attribute.
        /// </summary>
        public long AttributeValueId { get; set; }

        /// <summary>
        /// Gets or sets the id of the attribute.
        /// </summary>
        public long AttributeId { get; set; }

        /// <summary>
        /// Gets or sets the simple display name of the value.
        /// </summary>
        public string Display { get; set; }

        /// <summary>
        /// Gets or sets the value.
        /// </summary>
        public string Value { get; set; }
    }
}