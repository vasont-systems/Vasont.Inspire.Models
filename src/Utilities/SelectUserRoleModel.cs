//-----------------------------------------------------------------------
// <copyright file="SelectUserRoleModel.cs" company="GlobalLink Vasont">
//     Copyright (c) GlobalLink Vasont. All rights reserved.
// </copyright>
// <author>Rob Kennedy</author>
//-----------------------------------------------------------------------

namespace Vasont.Inspire.Models.Utilities
{
    using System.Collections.Generic;
    using Vasont.Inspire.Models.Security;

    /// <summary>
    /// This class represents a user role returned from a available user role API query.
    /// </summary>
    public class SelectUserRoleModel
    {
        /// <summary>
        /// Gets or sets the unique identity for this role or model. It is a combination of "type" and identity value.
        /// </summary>
        public long UserRoleId { get; set; }

        /// <summary>
        /// Gets or sets the user or role name.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the user or role full name.
        /// </summary>
        public string FullName { get; set; }

        /// <summary>
        /// Gets or sets the user or role type.
        /// </summary>
        public SecurityType SecurityType { get; set; }

        /// <summary>
        /// Gets or sets the user type.
        /// </summary>
        public UserType UserType { get; set; }

        /// <summary>
        /// Gets or sets the user or role description.
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets the user e-mail address.
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// Gets or sets the profile image URL.
        /// </summary>
        public string ProfileImageUrl { get; set; }

        /// <summary>
        /// Gets or sets a comma-delimited list of related associations, such as roles for user types, and users for role types.
        /// </summary>
        public List<string> Memberships { get; set; } = new List<string>();
    }
}