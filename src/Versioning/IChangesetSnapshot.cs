//-----------------------------------------------------------------------
// <copyright file="IChangesetSnapshot.cs" company="GlobalLink Vasont">
// Copyright (c) GlobalLink Vasont. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------
namespace Vasont.Inspire.Models.Versioning
{
    using System;

    /// <summary>
    /// Contains a minimum implementation of the baseline history table properties.
    /// </summary>
    public interface IChangesetSnapshot
    {
        /// <summary>
        /// Gets or sets the associated changeset identity.
        /// </summary>
        Guid ChangesetId { get; set; }

        /// <summary>
        /// Gets or sets the action type to execute against the changeset action target.
        /// </summary>
        ChangesetSnapshotActionType Action { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the history record was a restoral.
        /// </summary>
        bool Restored { get; set; }
    }
}
