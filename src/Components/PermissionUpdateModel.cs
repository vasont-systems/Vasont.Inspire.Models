//---------------------------------------------------------------------
// <copyright file="PermissionUpdateModel.cs" company="Vasont Systems">
// Copyright (c) Vasont Systems. All rights reserved.
// </copyright>
//---------------------------------------------------------------------
namespace Vasont.Inspire.Models.Components
{
    using System.Collections.Generic;

    /// <summary>
    /// This class represents a model that will be used to view and update permissions for a given folder or component.
    /// </summary>
    public class PermissionUpdateModel
    {
        /// <summary>
        /// Gets or sets a value indicating whether the permissions are inherited from an ancestor folder.
        /// </summary>
        public bool Inherited { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the folder can be inherited.
        /// </summary>
        public bool CanInherit { get; set; }

        /// <summary>
        /// Gets or sets the folder identity.
        /// </summary>
        public long FolderId { get; set; }

        /// <summary>
        /// Gets or sets a list of component identities.
        /// </summary>
        public List<long> ComponentIds { get; set; } = new List<long>();

        /// <summary>
        /// Gets or sets a list of user and role permissions.
        /// </summary>
        public List<UserRolePermissionModel> UserRolePermissions { get; set; } = new List<UserRolePermissionModel>();
    }
}