//-------------------------------------------------------------
// <copyright file="AttributeValueModel.cs" company="GlobalLink Vasont">
// Copyright (c) GlobalLink Vasont. All rights reserved.
// </copyright>
//-------------------------------------------------------------
using System.Collections.Generic;
using Vasont.Inspire.Models.Components.Schema;

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

        /// <summary>
        /// Gets or sets a list of profile attribute groups that are associated with the component attribute value.
        /// </summary>
        public List<ProfileAttributeGroupModel> Groups { get; set; } = new List<ProfileAttributeGroupModel>();
    }
}