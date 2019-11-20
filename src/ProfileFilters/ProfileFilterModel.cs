//------------------------------------------------------------------
// <copyright file="ProfileFilterModel.cs" company="Vasont Systems">
// Copyright (c) Vasont Systems. All rights reserved.
// </copyright>
//------------------------------------------------------------------
namespace Vasont.Inspire.Models.ProfileFilters
{
    using System.Collections.Generic;
    using Vasont.Inspire.Models.Security;

    /// <summary>
    /// This class defines the properties of a profile filter model.
    /// </summary>
    public class ProfileFilterModel
    {
        /// <summary>
        /// Gets or sets the identity of the profile filter.
        /// </summary>
        public long ProfileFilterId { get; set; }

        /// <summary>
        /// Gets or sets the owner of the profile filter.
        /// </summary>
        public MicroUserModel Owner { get; set; }

        /// <summary>
        /// Gets or sets the title of the profile filter.
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Gets or sets the description of the profile filter.
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the profile filter is shared.
        /// </summary>
        public bool SystemShared { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the profile filter is currently active.
        /// </summary>
        public bool Active { get; set; } = true;

        /// <summary>
        /// Gets or sets a list attribute values that are included in the profile filter.
        /// </summary>
        public List<ProfileFilterAttributeModel> AttributeValues { get; set; } = new List<ProfileFilterAttributeModel>();

        /// <summary>
        /// Gets or sets a list of users that this profile filter is shared with.
        /// </summary>
        public List<MicroUserModel> SharedUsers { get; set; } = new List<MicroUserModel>();

        /// <summary>
        /// Gets or sets a list of roles that this profile filter is shared with.
        /// </summary>
        public List<MinimalRoleModel> SharedRoles { get; set; } = new List<MinimalRoleModel>();
    }
}