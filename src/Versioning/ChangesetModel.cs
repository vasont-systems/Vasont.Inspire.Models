//-----------------------------------------------------------------------
// <copyright file="ChangesetModel.cs" company="GlobalLink Vasont">
// Copyright (c) GlobalLink Vasont. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------
namespace Vasont.Inspire.Models.Versioning
{
    using System;
    using System.Collections.Generic;
    using Vasont.Inspire.Models.Components;
    using Vasont.Inspire.Models.Security;

    /// <summary>
    /// This model represents a changeset record within the application.
    /// </summary>
    public class ChangesetModel
    {
        /// <summary>
        /// Gets or sets the unique identity of the changeset.
        /// </summary>
        public Guid ChangesetId { get; set; } = Guid.NewGuid();

        /// <summary>
        /// Gets or sets a friendly unique identity value for display.
        /// </summary>
        public long ChangesetNumber { get; set; }

        /// <summary>
        /// Gets or sets the date time stamp for the changeset.
        /// </summary>
        public DateTime ChangesetDate { get; set; } = DateTime.UtcNow;

        /// <summary>
        /// Gets or sets the user model of the creator of the changeset.
        /// </summary>
        public MinimalUserModel User { get; set; } = new MinimalUserModel();

        /// <summary>
        /// Gets or sets the label of the changeset.
        /// </summary>
        public string Label { get; set; }

        /// <summary>
        /// Gets or sets an optional comment for the changeset.
        /// </summary>
        public string Comment { get; set; }

        /// <summary>
        /// Gets or sets an optional processtype for the changeset.
        /// </summary>
        public string ProcessType { get; set; }

        /// <summary>
        /// Gets or sets an action for the changeset.
        /// </summary>
        public ChangesetSnapshotActionType Action { get; set; }

        /// <summary>
        /// Gets a list of changeset targets associated with the changeset.
        /// </summary>
        public List<ChangesetSnapshotModel> Snapshots { get; set; } = new List<ChangesetSnapshotModel>();

        /// <summary>
        /// Gets a list of components associated with the changeset.
        /// </summary>
        public List<MicroComponentModel> Components { get; set; } = new List<MicroComponentModel>();
    }
}
