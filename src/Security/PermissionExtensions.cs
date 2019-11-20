//-------------------------------------------------------------
// <copyright file="PermissionExtensions.cs" company="Vasont Systems">
// Copyright (c) Vasont Systems. All rights reserved.
// </copyright>
//-------------------------------------------------------------
namespace Vasont.Inspire.Models.Security
{
    /// <summary>
    /// This class contains extensions for the permissions flags enumeration
    /// </summary>
    public static class PermissionExtensions
    {
        /// <summary>
        /// Determine if the permissions contains a Create permission.
        /// </summary>
        /// <param name="permission">Contains the <see cref="PermissionFlags"/> enumeration to evaluate</param>
        /// <returns>Returns a value indicating whether the flags contains a Create permission.</returns>
        public static bool CanCreate(this PermissionFlags permission)
        {
            return (permission & PermissionFlags.Create) > 0;
        }

        /// <summary>
        /// Determine if the permissions contains a Read permission.
        /// </summary>
        /// <param name="permission">Contains the <see cref="PermissionFlags"/> enumeration to evaluate</param>
        /// <returns>Returns a value indicating whether the flags contains a Read permission.</returns>
        public static bool CanRead(this PermissionFlags permission)
        {
            return (permission & PermissionFlags.Read) > 0;
        }

        /// <summary>
        /// Determine if the permissions contains a Update permission.
        /// </summary>
        /// <param name="permission">Contains the <see cref="PermissionFlags"/> enumeration to evaluate</param>
        /// <returns>Returns a value indicating whether the flags contains a Update permission.</returns>
        public static bool CanUpdate(this PermissionFlags permission)
        {
            return (permission & PermissionFlags.Update) > 0;
        }

        /// <summary>
        /// Determine if the permissions contains a Delete permission.
        /// </summary>
        /// <param name="permission">Contains the <see cref="PermissionFlags"/> enumeration to evaluate</param>
        /// <returns>Returns a value indicating whether the flags contains a Delete permission.</returns>
        public static bool CanDelete(this PermissionFlags permission)
        {
            return (permission & PermissionFlags.Delete) > 0;
        }

        /// <summary>
        /// Determine if the permissions contains a SetPermissions permission.
        /// </summary>
        /// <param name="permission">Contains the <see cref="PermissionFlags"/> enumeration to evaluate</param>
        /// <returns>Returns a value indicating whether the flags contains a SetPermissions permission.</returns>
        public static bool CanSetPermissions(this PermissionFlags permission)
        {
            return (permission & PermissionFlags.SetPermissions) > 0;
        }

        /// <summary>
        /// Determine if the permissions contains a Rename permission.
        /// </summary>
        /// <param name="permission">Contains the <see cref="PermissionFlags"/> enumeration to evaluate</param>
        /// <returns>Returns a value indicating whether the flags contains a Rename permission.</returns>
        public static bool CanRename(this PermissionFlags permission)
        {
            return (permission & PermissionFlags.Rename) > 0;
        }
        
        /// <summary>
        /// Determine if the permissions contains all permissions.
        /// </summary>
        /// <param name="permission">Contains the <see cref="PermissionFlags"/> enumeration to evaluate</param>
        /// <returns>Returns a value indicating whether the flags contains all permissions.</returns>
        public static bool HasAllPermissions(this PermissionFlags permission)
        {
            return (permission & PermissionFlags.All) > 0;
        }
    }
}