//--------------------------------------------------------------------------
// <copyright file="ProfileAttributeGroupModel.cs" company="Vasont Systems">
// Copyright (c) Vasont Systems. All rights reserved.
// </copyright>
//--------------------------------------------------------------------------
namespace Vasont.Inspire.Models.Components.Schema
{
    /// <summary>
    /// This class defines the properties of a profile attribute group model.
    /// </summary>
    public class ProfileAttributeGroupModel
    {
        /// <summary>
        /// Gets or sets the identity of the profile attribute group.
        /// </summary>
        public long ProfileAttributeGroupId { get; set; }

        /// <summary>
        /// Gets or sets the identity of the attribute that this group is related to.
        /// </summary>
        public long AttributeId { get; set; }

        /// <summary>
        /// Gets or sets the simple display name of the value.
        /// </summary>
        public string Display { get; set; }

        /// <summary>
        /// Gets or sets the value of the group.
        /// </summary>
        public string Value { get; set; }

        /// <summary>
        /// Gets or sets the sort order in which the group will be displayed within other groups for the same attribute.
        /// </summary>
        public int SortOrder { get; set; }
    }
}