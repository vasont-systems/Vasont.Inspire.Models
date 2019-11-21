//----------------------------------------------------------------------------
// <copyright file="ComponentAttributeValueModel.cs" company="GlobalLink Vasont">
// Copyright (c) GlobalLink Vasont. All rights reserved.
// </copyright>
//----------------------------------------------------------------------------
namespace Vasont.Inspire.Models.Components.Schema
{
    using System.Collections.Generic;

    /// <summary>
    /// This class defines the properties of a component configuration attribute value model.
    /// </summary>
    public class ComponentAttributeValueModel
    {        
        /// <summary>
        /// Gets or sets the identity of the attribute value.
        /// </summary>
        public long AttributeValueId { get; set; }

        /// <summary>
        /// Gets or sets the identity of the attribute that this value is associated with.
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
        /// Gets or sets a sort order value for displaying the attribute value.
        /// </summary>
        public int SortOrder { get; set; }

        /// <summary>
        /// Gets or sets a list of profile attribute groups that are associated with the component attribute value.
        /// </summary>
        public List<ProfileAttributeGroupModel> Groups { get; set; } = new List<ProfileAttributeGroupModel>();
    }
}