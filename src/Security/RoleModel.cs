//-----------------------------------------------------------------------
// <copyright file="RoleModel.cs" company="GlobalLink Vasont">
// Copyright (c) GlobalLink Vasont. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------
namespace Vasont.Inspire.Models.Security
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// This model class represents a security role within the application.
    /// </summary>
    public class RoleModel : MinimalRoleModel
    {
        #region Public Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="RoleModel"/> class.
        /// </summary>
        public RoleModel()
            : this(string.Empty)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RoleModel"/> class.
        /// </summary>
        /// <param name="roleName">Contains the name of the role.</param>
        public RoleModel(string roleName)
        {
            this.Users = new List<MinimalUserModel>();
            this.Name = roleName;
            this.CreatedDate = DateTime.UtcNow;
            this.UpdatedDate = DateTime.UtcNow;
        }

        #endregion

        #region Public Properties

        /// <summary>
        /// Gets or sets the record created date time.
        /// </summary>
        public DateTime CreatedDate { get; set; }

        /// <summary>
        /// Gets or sets the user model for the creating user.
        /// </summary>
        public MinimalUserModel CreatedBy { get; set; }

        /// <summary>
        /// Gets or sets the record last updated date time.
        /// </summary>
        public DateTime UpdatedDate { get; set; }

        /// <summary>
        /// Gets or sets the user model for the updating user.
        /// </summary>
        public MinimalUserModel UpdatedBy { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the role is automatically added to users when
        /// they are synchronized via the application subscription Redis channel.
        /// </summary>
        public bool Default { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the save as function should to include the permissions role.
        /// </summary>
        public bool IncludePermissions { get; set; }

        /// <summary>
        /// Gets or sets a list of user models assigned to this role.
        /// </summary>
        public List<MinimalUserModel> Users { get; set; }

        #endregion
    }
}