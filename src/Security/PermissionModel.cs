//-------------------------------------------------------------
// <copyright file="PermissionModel.cs" company="Vasont Systems">
// Copyright (c) Vasont Systems. All rights reserved.
// </copyright>
//-------------------------------------------------------------
namespace Vasont.Inspire.Models.Security
{
    using Newtonsoft.Json;

    /// <summary>
    /// This class provides properties to represent the permission flags within a <see cref="PermissionFlags"/> value.
    /// </summary>
    public class PermissionModel
    {
        #region Public Constructors
        /// <summary>
        /// Initializes a new instance of the <see cref="PermissionModel"/> class.
        /// </summary>
        public PermissionModel()
            : this(PermissionFlags.None)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PermissionModel"/> class.
        /// </summary>
        /// <param name="permission">Contains the permission flag for the model to represent.</param>
        public PermissionModel(int permission)
            : this((PermissionFlags)(permission > 0 ? permission : 0))
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PermissionModel"/> class.
        /// </summary>
        /// <param name="permission">Contains the permission flag for the model to represent.</param>
        public PermissionModel(PermissionFlags permission)
        {
            this.Permissions = permission;
            this.CheckCanRead();
        }
        #endregion

        #region Public Properties
        /// <summary>
        /// Gets or sets a value indicating whether the read permission is set.
        /// </summary>
        public bool CanRead
        {
            get => this.Permissions.CanRead();

            // check to ensure no other permission is set. If you can't read, you shouldn't be able to do anything so set to none.
            set => this.Permissions = value || (int)this.Permissions >= 1 ? this.Permissions |= PermissionFlags.Read : this.Permissions = PermissionFlags.None;
        }

        /// <summary>
        /// Gets or sets a value indicating whether the create permission is set.
        /// </summary>
        public bool CanCreate
        {
            get => this.Permissions.CanCreate();

            set
            {
                this.Permissions = value ? this.Permissions |= PermissionFlags.Create : this.Permissions &= ~PermissionFlags.Create;
                this.CheckCanRead();
            }
        }

        /// <summary>
        /// Gets or sets a value indicating whether the update permission is set.
        /// </summary>
        public bool CanUpdate
        {
            get => this.Permissions.CanUpdate();

            set
            {
                this.Permissions = value ? this.Permissions |= PermissionFlags.Update : this.Permissions &= ~PermissionFlags.Update;
                this.CheckCanRead();
            }
        }

        /// <summary>
        /// Gets or sets a value indicating whether the delete permission is set.
        /// </summary>
        public bool CanDelete
        {
            get => this.Permissions.CanDelete();

            set
            {
                this.Permissions = value ? this.Permissions |= PermissionFlags.Delete : this.Permissions &= ~PermissionFlags.Delete;
                this.CheckCanRead();
            }
        }

        /// <summary>
        /// Gets or sets a value indicating whether the read permission is set.
        /// </summary>
        public bool CanSetPermissions
        {
            get => this.Permissions.CanSetPermissions();

            set
            {
                this.Permissions = value ? this.Permissions |= PermissionFlags.SetPermissions : this.Permissions &= ~PermissionFlags.SetPermissions;
                this.CheckCanRead();
            }
        }

        /// <summary>
        /// Gets or sets a value indicating whether the read permission is set.
        /// </summary>
        public bool CanRename
        {
            get => this.Permissions.CanRename();

            set
            {
                this.Permissions = value ? this.Permissions |= PermissionFlags.Rename : this.Permissions &= ~PermissionFlags.Rename;
                this.CheckCanRead();
            }
        }

        /// <summary>
        /// Gets or sets a value indicating whether the read permission is set.
        /// </summary>
        public bool AllPermissions
        {
            get => this.Permissions.HasAllPermissions();

            set => this.Permissions = value ? PermissionFlags.All : PermissionFlags.None;
        }

        /// <summary>
        /// Gets or sets the Permissions code of the permission model.
        /// </summary>
        public PermissionFlags Permissions { get; set; }

        /// <summary>
        /// Gets or sets the permissions property via an integer value.
        /// </summary>
        [JsonIgnore]
        public int PermissionsValue
        {
            get => (int)this.Permissions;

            set => this.Permissions = (PermissionFlags)value;
        }
        #endregion

        #region Private Methods
        /// <summary>
        /// This method is used to check if the read permission should be set.
        /// </summary>
        private void CheckCanRead()
        {
            // set read permission if the user has read permission or another higher permission is set
            this.CanRead = (int)this.Permissions >= 1;
        }
        #endregion
    }
}