//-----------------------------------------------------------------------
// <copyright file="UserModel.cs" company="GlobalLink Vasont">
// Copyright (c) GlobalLink Vasont. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------
namespace Vasont.Inspire.Models.Security
{
    using System;
    using System.Collections.Generic;
    using Vasont.Inspire.Models.Notifications;

    /// <summary>
    /// This class represents a security user within the application.
    /// </summary>
    public class UserModel : MinimalUserModel
    {
        #region Public Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="UserModel" /> class.
        /// </summary>
        public UserModel()
            : this(string.Empty, string.Empty)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserModel" /> class.
        /// </summary>
        /// <param name="userName">Contains the user name of the account.</param>
        /// <param name="emailAddress">Contains the e-mail address of the account.</param>
        public UserModel(string userName, string emailAddress)
        {
            this.Roles = new List<MinimalRoleModel>();
            this.UserName = userName;
            this.Email = emailAddress;
            this.CreatedDate = DateTime.UtcNow;
            this.UpdatedDate = DateTime.UtcNow;
        }

        #endregion

        #region Public Properties

        /// <summary>
        /// Gets or sets the external user identity value.
        /// </summary>
        public string ExternalUserId { get; set; }

        /// <summary>
        /// Gets or sets the user type of the user model.
        /// </summary>
        public UserType UserType { get; set; }

        /// <summary>
        /// Gets or sets the user selected time-zone model.
        /// </summary>
        public TimeZoneModel TimeZone { get; set; }

        /// <summary>
        /// Gets or sets the date time when the account was created.
        /// </summary>
        public DateTime CreatedDate { get; set; }

        /// <summary>
        /// Gets or sets the user model for the creator user.
        /// </summary>
        public MinimalUserModel CreatedBy { get; set; }

        /// <summary>
        /// Gets or sets the date time when the account was last updated.
        /// </summary>
        public DateTime UpdatedDate { get; set; }

        /// <summary>
        /// Gets or sets the user model for the updating user.
        /// </summary>
        public MinimalUserModel UpdatedBy { get; set; }

        /// <summary>
        /// Gets or sets a list of associated roles.
        /// </summary>
        public List<MinimalRoleModel> Roles { get; set; }

        /// <summary>
        /// Gets or sets the user notes.
        /// </summary>
        public string Notes { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the user account is active.
        /// </summary>
        public bool Active { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the user can be deleted. Typically set to true if the user model matches the current user. The current user
        /// cannot delete themselves.
        /// </summary>
        public bool Deletable { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the user account is named.
        /// </summary>
        public bool Named { get; set; }

        /// <summary>
        ///  Gets or sets the notification user preferences.
        /// </summary>
        /// <value>The json object of user settings preferences.</value>
        public string NotificationSettings { get; set; }

        /// <summary>
        ///  Gets or sets the notification user preferences model.
        /// </summary>
        /// <value>The object model of user settings preferences.</value>
        public NotificationSettingsPreferenceModel NotificationSettingsModel { get; set; }

        #endregion
    }
}