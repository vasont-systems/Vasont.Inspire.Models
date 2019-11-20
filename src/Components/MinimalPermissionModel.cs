//-----------------------------------------------------------------------
// <copyright file="MinimalPermissionModel.cs" company="Vasont Systems">
// Copyright (c) Vasont Systems. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------
namespace Vasont.Inspire.Models.Components
{
    using Vasont.Inspire.Models.Security;

    /// <summary>
    /// This model represents a minimal permission for a given user or role.
    /// </summary>
    public class MinimalPermissionModel
    {
        /// <summary>
        /// Gets or sets the associated user that is assigned the permission to a component.
        /// </summary>
        public long Id { get; set; }

        /// <summary>
        /// Gets or sets the name of the granted user.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the permission code.
        /// </summary>
        public PermissionFlags Permission { get; set; }
    }
}
