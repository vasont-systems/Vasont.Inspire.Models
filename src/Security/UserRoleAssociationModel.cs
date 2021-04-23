//-------------------------------------------------------------
// <copyright file="UserRoleAssociationModel.cs" company="GlobalLink Vasont">
// Copyright (c) GlobalLink Vasont. All rights reserved.
// </copyright>
//-------------------------------------------------------------
namespace Vasont.Inspire.Models.Security
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using Vasont.Inspire.Core.Extensions;

    /// <summary>
    /// Contains an enumerated list of security types.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum SecurityType
    {
        /// <summary>
        /// The security type is a system user.
        /// </summary>
        User,

        /// <summary>
        /// The security type is a system role.
        /// </summary>
        Role
    }

    /// <summary>
    /// This class is a model representation of a user or role that is associated with a related record.
    /// </summary>
    public class UserRoleAssociationModel
    {
        /// <summary>
        /// Gets or sets the unique identity of the participant.
        /// </summary>
        public long Id { get; set; }

        /// <summary>
        /// Gets or sets the external user identity value.
        /// </summary>
        public string ExternalUserId { get; set; }

        /// <summary>
        /// Gets or sets the participant security type. (i.e. User or Role)
        /// </summary>
        public SecurityType SecurityType { get; set; }

        /// <summary>
        /// Gets or sets the participant user type. (i.e. Standard or Support)
        /// </summary>
        public UserType UserType { get; set; }

        /// <summary>
        /// Gets or sets the type via a string.
        /// </summary>
        [JsonIgnore]
        public string SecurityTypeText
        {
            get => this.SecurityType.ToString();
            set => this.SecurityType = value.ToEnum<SecurityType>();
        }

        /// <summary>
        /// Gets or sets the type via a string.
        /// </summary>
        [JsonIgnore]
        public string UserTypeText
        {
            get => this.UserType.ToString();
            set => this.UserType = value.ToEnum<UserType>();
        }

        /// <summary>
        /// Gets or sets the name of the participant.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the participant description.
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets the participant description.
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// Gets or sets a list of participant memberships.
        /// </summary>
        public List<string> Memberships { get; set; } = new List<string>();
    }
}