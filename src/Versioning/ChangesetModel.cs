//-----------------------------------------------------------------------
// <copyright file="ChangesetModel.cs" company="Vasont Systems">
// Copyright (c) Vasont Systems. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------
namespace Vasont.Inspire.Models.Versioning
{
    using System;
    using System.Collections.Generic;
    using Vasont.Inspire.Models.Security;

    /// <summary>
    /// This model represents a changeset record within the application.
    /// </summary>
    public class ChangesetModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ChangesetModel"/> class.
        /// </summary>
        public ChangesetModel()
        {
            this.ChangesetId = Guid.NewGuid();
            this.ChangesetDate = DateTime.UtcNow;
            this.User = new MinimalUserModel();
            this.Snapshots = new List<ChangesetSnapshotModel>();
        }

        /// <summary>
        /// Gets or sets the unique identity of the changeset.
        /// </summary>
        public Guid ChangesetId { get; set; }

        /// <summary>
        /// Gets or sets a friendly unique identity value for display.
        /// </summary>
        public long ChangesetNumber { get; set; }

        /// <summary>
        /// Gets or sets the date time stamp for the changeset.
        /// </summary>
        public DateTime ChangesetDate { get; set; }

        /// <summary>
        /// Gets or sets the user model of the creator of the changeset.
        /// </summary>
        public MinimalUserModel User { get; set; }

        /// <summary>
        /// Gets or sets the label of the changeset.
        /// </summary>
        public string Label { get; set; }

        /// <summary>
        /// Gets or sets an optional comment for the changeset.
        /// </summary>
        public string Comment { get; set; }

        /// <summary>
        /// Gets a list of changeset targets associated with the changeset.
        /// </summary>
        public List<ChangesetSnapshotModel> Snapshots { get; }
    }
}
