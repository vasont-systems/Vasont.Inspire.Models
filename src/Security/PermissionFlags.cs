//-------------------------------------------------------------
// <copyright file="PermissionFlags.cs" company="Vasont Systems">
// Copyright (c) Vasont Systems. All rights reserved.
// </copyright>
//-------------------------------------------------------------
namespace Vasont.Inspire.Models.Security
{
    using System;

    /// <summary>
    /// Contains an enumerated list of permission flags.
    /// </summary>
    [Flags]
    public enum PermissionFlags
    {
        /// <summary>
        /// No permissions
        /// </summary>
        None = 0,

        /// <summary>
        /// Read data permission.
        /// </summary>
        Read = 1,

        /// <summary>
        /// Create data permission.
        /// </summary>
        Create = 2,

        /// <summary>
        /// Update data permission.
        /// </summary>
        Update = 4,

        /// <summary>
        /// Delete data permission.
        /// </summary>
        Delete = 8,

        /// <summary>
        /// Can Set security data permission.
        /// </summary>
        SetPermissions = 16,

        /// <summary>
        /// Has rename data permission.
        /// </summary>
        Rename = 32,

        /// <summary>
        /// Contains all permissions
        /// </summary>
        All = Create | Read | Update | Delete | SetPermissions | Rename
    }
}
