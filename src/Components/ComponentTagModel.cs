//-----------------------------------------------------------------
// <copyright file="ComponentTagModel.cs" company="GlobalLink Vasont">
// Copyright (c) GlobalLink Vasont. All rights reserved.
// </copyright>
//-----------------------------------------------------------------
namespace Vasont.Inspire.Models.Components
{
    using System.Collections.Generic;

    /// <summary>
    /// This class represents a component tag model with information that will used for interaction with application user interfaces.
    /// </summary>
    public class ComponentTagModel
    {
        /// <summary>
        /// Gets or sets the identity of the component.
        /// </summary>
        public long ComponentId { get; set; }

        /// <summary>
        /// Gets or sets a list of tags associated with the component.
        /// </summary>
        public List<TagModel> Tags { get; set; } = new List<TagModel>();

        /// <summary>
        /// Gets or sets a comma delimited list of tag identities.
        /// </summary>
        public string TagIds { get; set; }
    }
}
