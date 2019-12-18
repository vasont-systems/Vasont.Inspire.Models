//-----------------------------------------------------------------------
// <copyright file="QueryModel.cs" company="GlobalLink Vasont">
// Copyright (c) GlobalLink Vasont. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------
namespace Vasont.Inspire.Models.Components
{
    using System.Collections.Generic;
    using Vasont.Inspire.Models.Common;
    using Vasont.Inspire.Models.Security;

    /// <summary>
    /// This class represents a query within the system and is to be used for interaction with application user interfaces.
    /// </summary>
    public class QueryModel : CreatedUpdaterModelBase
    {
        /// <summary>
        /// Gets or sets the unique identity of the query.
        /// </summary>
        public long QueryId { get; set; }

        /// <summary>
        /// Gets or sets the project owner's user information.
        /// </summary>
        public MicroUserModel Owner { get; set; } = new MicroUserModel();

        /// <summary>
        /// Gets or sets the query title.
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Gets or sets the query description.
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets the query contents.
        /// </summary>
        public string Contents { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the query is available to all system users.
        /// </summary>
        public bool SystemShared { get; set; }

        /// <summary>
        /// Gets or sets the group name for display.
        /// </summary>
        public string GroupName { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the query is active.
        /// </summary>
        public bool Active { get; set; }

        /// <summary>
        /// Gets or sets a list of <see cref="UserRoleAssociationModel"/> objects.
        /// </summary>
        public List<UserRoleAssociationModel> Participants { get; set; } = new List<UserRoleAssociationModel>();
    }
}
