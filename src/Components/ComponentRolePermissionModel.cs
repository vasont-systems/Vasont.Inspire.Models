//-----------------------------------------------------------------------
// <copyright file="ComponentRolePermissionModel.cs" company="Vasont Systems">
// Copyright (c) Vasont Systems. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------
namespace Vasont.Inspire.Models.Components
{
    using Security;
    using Vasont.Inspire.Models.Common;

    /// <summary>
    /// This class represents a component role permission configuration within the application.
    /// </summary>
    public class ComponentRolePermissionModel : MicroCreatedUpdaterModelBase
    {
        /// <summary>
        /// Gets or sets the associated component that the role is assigned to with the permission.
        /// </summary>
        public long ComponentId { get; set; }

        /// <summary>
        /// Gets or sets the associated role that is assigned the permission to a component.
        /// </summary>
        public long RoleId { get; set; }

        /// <summary>
        /// Gets or sets the name of the granted role.
        /// </summary>
        public string AssignedRoleName { get; set; }

        /// <summary>
        /// Gets or sets the permission code.
        /// </summary>
        public PermissionFlags Permission { get; set; }
    }
}