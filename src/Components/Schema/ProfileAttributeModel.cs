//---------------------------------------------------------------------
// <copyright file="ProfileAttributeModel.cs" company="GlobalLink Vasont">
// Copyright (c) GlobalLink Vasont. All rights reserved.
// </copyright>
//---------------------------------------------------------------------
namespace Vasont.Inspire.Models.Components.Schema
{
    using System.Collections.Generic;
    
    /// <summary>
    /// This class defines the properties of a profile attribute model.
    /// </summary>
    public class ProfileAttributeModel : MinimalProfileAttributeModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ProfileAttributeModel"/> class.
        /// </summary>
        public ProfileAttributeModel()
        {
            this.ValidValues = new List<ComponentAttributeValueModel>();
            this.Groups = new List<ProfileAttributeGroupModel>();
        }

        /// <summary>
        /// Gets or sets a value indicating whether the attribute is profiled.
        /// </summary>
        public bool Profiled { get; set; }

        /// <summary>
        /// Gets or sets a list valid values related to of key value pair objects containing valid values and display text for the attribute.
        /// </summary>
        public List<ComponentAttributeValueModel> ValidValues { get; set; }

        /// <summary>
        /// Gets or sets a list of profile attribute groups that are associated with the component attribute.
        /// </summary>
        public List<ProfileAttributeGroupModel> Groups { get; set; }
    }
}