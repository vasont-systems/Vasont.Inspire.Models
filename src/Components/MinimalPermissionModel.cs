//-----------------------------------------------------------------------
// <copyright file="MinimalPermissionModel.cs" company="GlobalLink Vasont">
// Copyright (c) GlobalLink Vasont. All rights reserved.
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
        public PermissionFlags Permission
        {
            get
            {
                PermissionFlags result = PermissionFlags.None;

                if (this.CanCreate)
                {
                    result |= PermissionFlags.Create;
                }

                if (this.CanRead)
                {
                    result |= PermissionFlags.Read;
                }

                if (this.CanUpdate)
                {
                    result |= PermissionFlags.Update;
                }

                if (this.CanDelete)
                {
                    result |= PermissionFlags.Delete;
                }

                if (this.CanSetPermissions)
                {
                    result |= PermissionFlags.SetPermissions;
                }

                if (this.CanRename)
                {
                    result |= PermissionFlags.Rename;
                }

                return result;
            }

            set
            {
                this.CanCreate = value.CanCreate();
                this.CanRead = value.CanRead();
                this.CanUpdate = value.CanUpdate();
                this.CanDelete = value.CanDelete();
                this.CanRename = value.CanRename();
                this.CanSetPermissions = value.CanSetPermissions();
            }
        }

        /// <summary>
        /// Gets or sets a value indicating whether the permission holder can read records within the folder.
        /// </summary>
        public bool CanRead { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the permission holder can create records within the folder.
        /// </summary>
        public bool CanCreate { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the permission holder can update records within the folder.
        /// </summary>
        public bool CanUpdate { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the permission holder can delete records within the folder.
        /// </summary>
        public bool CanDelete { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the permission holder can rename records within a folder.
        /// </summary>
        public bool CanRename { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the permission holder can set permissions on records within the folder.
        /// </summary>
        public bool CanSetPermissions { get; set; }
    }
}
