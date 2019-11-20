//-----------------------------------------------------------------------
// <copyright file="MicroUserModel.cs" company="Vasont Systems">
// Copyright (c) Vasont Systems. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------
namespace Vasont.Inspire.Models.Security
{
    /// <summary>
    /// This class contains the bare minimum properties to represent a user in the interface.
    /// </summary>
    public class MicroUserModel
    {
        /// <summary>
        /// Gets or sets the unique identity of the user.
        /// </summary>
        public long UserId { get; set; }

        /// <summary>
        /// Gets or sets the user's e-mail address.
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// Gets or sets the user full name.
        /// </summary>
        public string FullName { get; set; }

        /// <summary>
        /// Gets or sets the user name of the user.
        /// </summary>
        public string UserName { get; set; }
    }
}