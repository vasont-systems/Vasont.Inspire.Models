//-----------------------------------------------------------------------
// <copyright file="ComponentUserPermissionModel.cs" company="GlobalLink Vasont">
// Copyright (c) GlobalLink Vasont. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------
namespace Vasont.Inspire.Models.Components
{
    using Security;
    using Vasont.Inspire.Models.Common;

    /// <summary>
    /// This class represents a component user permission configuration within the application.
    /// </summary>
    public class ComponentUserPermissionModel : MicroCreatedUpdaterModelBase
    {
        /// <summary>
        /// Gets or sets the associated component that the user is assigned to with the permission.
        /// </summary>
        public long ComponentId { get; set; }

        /// <summary>
        /// Gets or sets the associated user that is assigned the permission to a component.
        /// </summary>
        public long UserId { get; set; }

        /// <summary>
        /// Gets or sets the name of the granted user.
        /// </summary>
        public string AssignedUserName { get; set; }

        /// <summary>
        /// Gets or sets the permission code.
        /// </summary>
        public PermissionFlags Permission { get; set; }
    }
}