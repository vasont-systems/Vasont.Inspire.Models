//-----------------------------------------------------------------------
// <copyright file="ChangesetRequestModel.cs" company="GlobalLink Vasont">
// Copyright (c) GlobalLink Vasont. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------
namespace Vasont.Inspire.Models.Versioning
{
    using System;

    /// <summary>
    /// This class represents a changeset request within the application.
    /// </summary>
    public class ChangesetRequestModel
    {
        /// <summary>
        /// Gets or sets the Component identity.
        /// </summary>
        public long ComponentId { get; set; }

        /// <summary>
        /// Gets or sets the changeset identity
        /// </summary>
        public Guid ChangesetId { get; set; }
    }
}
