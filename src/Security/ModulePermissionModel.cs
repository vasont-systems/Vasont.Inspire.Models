//-------------------------------------------------------------
// <copyright file="ModulePermissionModel.cs" company="Vasont Systems">
// Copyright (c) Vasont Systems. All rights reserved.
// </copyright>
//-------------------------------------------------------------

namespace Vasont.Inspire.Models.Security
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using Vasont.Inspire.Models.Common;

    /// <summary>
    /// Contains an enumerated list of participant types.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum ModulePermissionHolderType
    {
        /// <summary>
        /// The permission holder is a system user.
        /// </summary>
        User,

        /// <summary>
        /// The permission holder is a system role.
        /// </summary>
        Role
    }

    /// <summary>
    /// This class is represents a module permission associated with a module and a related user or role.
    /// </summary>
    public class ModulePermissionModel : CreatedUpdaterModelBase
    {
        #region Private Fields
        /// <summary>
        /// Contains the unique role identity value.
        /// </summary>
        private long roleId;

        /// <summary>
        /// Contains the unique user identity value.
        /// </summary>
        private long userId;
        #endregion

        /// <summary>
        /// Gets or sets the unique identity value.
        /// </summary>
        public string UniqueId { get; set; }

        /// <summary>
        /// Gets or sets the unique user module permission identity
        /// </summary>
        public long ModuleUserPermissionId { get; set; }

        /// <summary>
        /// Gets or sets the unique role module permission identity
        /// </summary>
        public long ModuleRolePermissionId { get; set; }

        /// <summary>
        /// Gets or sets the parent module identity value.
        /// </summary>
        public long ModuleId { get; set; }

        /// <summary>
        /// Gets or sets the user/role name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the role identity value.
        /// </summary>
        public long RoleId
        {
            get => this.roleId;

            set
            {
                this.roleId = value;
                this.UniqueId = $"role_{value}_{this.ModuleRolePermissionId}";
                this.Type = ModulePermissionHolderType.Role;
            }
        }

        /// <summary>
        /// Gets or sets the user identity value.
        /// </summary>
        public long UserId
        {
            get => this.userId;

            set
            {
                this.userId = value;
                this.UniqueId = $"user_{value}_{this.ModuleUserPermissionId}";
                this.Type = ModulePermissionHolderType.User;
            }
        }

        /// <summary>
        /// Gets or sets the module permission holder type.
        /// </summary>
        public ModulePermissionHolderType Type { get; set; }

        /// <summary>
        /// Gets or sets the module permission flags.
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
        /// Gets or sets a value indicating whether the permission holder can read records within the module.
        /// </summary>
        public bool CanRead { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the permission holder can create records within the module.
        /// </summary>
        public bool CanCreate { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the permission holder can update records within the module.
        /// </summary>
        public bool CanUpdate { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the permission holder can delete records within the module.
        /// </summary>
        public bool CanDelete { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the permission holder can rename records within a module.
        /// </summary>
        public bool CanRename { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the permission holder can set permissions on records within the module.
        /// </summary>
        public bool CanSetPermissions { get; set; }
    }
}
