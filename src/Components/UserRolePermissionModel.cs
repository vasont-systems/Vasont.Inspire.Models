//-------------------------------------------------------------
// <copyright file="UserRolePermissionModel.cs" company="Vasont Systems">
// Copyright (c) Vasont Systems. All rights reserved.
// </copyright>
//-------------------------------------------------------------
namespace Vasont.Inspire.Models.Components
{
    using Vasont.Inspire.Models.Security;

    /// <summary>
    /// This class is used to define a set of permissions for a given user or role.
    /// </summary>
    public class UserRolePermissionModel
    {
        #region Private Fields
        /// <summary>
        /// Contains the unique identifier of the folder permission model.
        /// </summary>
        private string uniqueId;
        
        /// <summary>
        /// Contains the unique user identity value.
        /// </summary>
        private long userId;

        /// <summary>
        /// Contains the unique role identity value.
        /// </summary>
        private long roleId;

        #endregion

        /// <summary>
        /// Initializes a new instance of the <see cref="UserRolePermissionModel"/> class.
        /// </summary>
        public UserRolePermissionModel()
        {
            this.Permissions = new PermissionModel();
        }

        /// <summary>
        /// Gets or sets the unique identity of the permission item.
        /// </summary>
        public string Id
        {
            get => !string.IsNullOrWhiteSpace(this.uniqueId) ? this.uniqueId : this.uniqueId = this.GenerateUniqueId();

            set => this.uniqueId = value;
        }

        /// <summary>
        /// Gets or sets the unique identity of the user.
        /// </summary>
        public long UserId
        {
            get => this.userId;

            set
            {
                this.userId = value;
                this.Id = "User_" + value;
            }
        }

        /// <summary>
        /// Gets or sets the unique identity of the role.
        /// </summary>
        public long RoleId
        {
            get => this.roleId;

            set
            {
                this.roleId = value;
                this.Id = "Role_" + value;
            }
        }

        /// <summary>
        /// Gets or sets the type (i.e. User or Role).
        /// </summary>
        public SecurityType Type { get; set; }

        /// <summary>
        /// Gets or sets the name of the user or role.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the user or role description.
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets the permissions model for the specified user or role.
        /// </summary>
        public PermissionModel Permissions { get; set; }

        #region Conditional Folder Serialization Methods
        /// <summary>
        /// This method is called by the serializer to determine if the property UserId should be rendered.
        /// </summary>
        /// <returns>Returns a value indicating whether to render the related property.</returns>
        public bool ShouldSerializeUserId()
        {
            return this.Type == SecurityType.User;
        }

        /// <summary>
        /// This method is called by the serializer to determine if the property RoleId should be rendered.
        /// </summary>
        /// <returns>Returns a value indicating whether to render the related property.</returns>
        public bool ShouldSerializeRoleId()
        {
            return this.Type == SecurityType.Role;
        }
        #endregion

        #region Private Methods
        /// <summary>
        /// This method is used to generate the unique identity for the model.
        /// </summary>
        /// <returns>Returns a unique identity string.</returns>
        private string GenerateUniqueId()
        {
            return this.Type == SecurityType.Role ? "Role_" + this.roleId : "User_" + this.userId;
        }
        #endregion
    }
}