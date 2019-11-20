//-----------------------------------------------------------------------
// <copyright file="MinimalFolderHistoryModel.cs" company="Vasont Systems">
// Copyright (c) Vasont Systems. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------
namespace Vasont.Inspire.Models.Versioning
{
    using System;
    using Vasont.Inspire.Models.Components;

    /// <summary>
    /// This class represents a minimal implementation of a component history model.
    /// </summary>
    public class MinimalFolderHistoryModel : MinimalFolderModel, IChangesetSnapshot
    {
        /// <summary>
        /// Gets or sets the associated changeset identity.
        /// </summary>
        public Guid ChangesetId { get; set; }

        /// <summary>
        /// Gets or sets the action type to execute against the changeset action target.
        /// </summary>
        public ChangesetSnapshotActionType Action { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the history record was a restoral.
        /// </summary>
        public bool Restored { get; set; }
    }
}
