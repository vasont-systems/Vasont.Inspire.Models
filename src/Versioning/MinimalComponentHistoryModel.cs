//-----------------------------------------------------------------------
// <copyright file="MinimalComponentHistoryModel.cs" company="GlobalLink Vasont">
// Copyright (c) GlobalLink Vasont. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------
namespace Vasont.Inspire.Models.Versioning
{
    using System;
    using Vasont.Inspire.Models.Components;

    /// <summary>
    /// This class represents a minimal implementation of a component history model.
    /// </summary>
    public class MinimalComponentHistoryModel : MinimalComponentModel, IChangesetSnapshot
    {
        /// <summary>
        /// Gets or sets the associated changeset identity.
        /// </summary>
        public Guid ChangesetId { get; set; }

        /// <summary>
        /// Gets or sets the related changeset number.
        /// </summary>
        public long ChangesetNumber { get; set; }

        /// <summary>
        /// Gets or sets the related changeset label.
        /// </summary>
        public string Label { get; set; }

        /// <summary>
        /// Gets or sets the related changeset comment.
        /// </summary>
        public string Comment { get; set; }

        /// <summary>
        /// Gets or sets the reconstructed folder path.
        /// </summary>
        public string FolderPath { get; set; }

        /// <summary>
        /// Gets or sets the related changeset date time when the changeset was saved.
        /// </summary>
        public DateTime ChangesetDate { get; set; }

        /// <summary>
        /// Gets or sets the action type to execute against the changeset action target.
        /// </summary>
        public ChangesetSnapshotActionType Action { get; set; }

        /// <summary>
        /// Gets or sets the action process type to execute against the changeset action target.
        /// </summary>
        public string ProcessType { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the history record was a restoral.
        /// </summary>
        public bool Restored { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the related component history has new content that has changed from previous histories.
        /// </summary>
        public bool ContentChanged { get; set; }

        /// <summary>
        /// Gets a value indicating whether the component can be restored.
        /// </summary>
        public bool CanRestore => this.Action != ChangesetSnapshotActionType.Delete && !this.LatestSnapshot;

        /// <summary>
        /// Gets or sets a value indicating whether this component is the latest snapshot.
        /// </summary>
        public bool LatestSnapshot { get; set; }

        /// <summary>
        /// Gets or sets the name of the user who esigned.
        /// </summary>
        public string EsignedBy { get; set; }

        /// <summary>
        /// Gets or sets the date when this record got esigned.
        /// </summary>
        public DateTime EsignedDate { get; set; }
    }
}
