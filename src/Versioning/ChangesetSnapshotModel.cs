//-----------------------------------------------------------------------
// <copyright file="ChangesetSnapshotModel.cs" company="GlobalLink Vasont">
// Copyright (c) GlobalLink Vasont. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------
namespace Vasont.Inspire.Models.Versioning
{
    using System;
    using System.ComponentModel;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using Vasont.Inspire.Models.Common;
    using Vasont.Inspire.Models.Components;

    /// <summary>
    /// Contains an enumerated list of available changeset snapshot action types.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum ChangesetSnapshotActionType
    {
        /// <summary>
        /// A component was created.
        /// </summary>
        [Description("c")]
        Create,

        /// <summary>
        /// A component was updated without content (Move/Rename).
        /// </summary>
        [Description("u")]
        Update,

        /// <summary>
        /// A component was updated with content.
        /// </summary>
        [Description("u")]
        UpdateWithContent,

        /// <summary>
        /// A component was deleted.
        /// </summary>
        [Description("d")]
        Delete,

        /// <summary>
        /// A component was moved.
        /// </summary>
        [Description("m")]
        Move,

        /// <summary>
        /// A component was versioned on demand.
        /// </summary>
        [Description("o")]
        OnDemand,

        /// <summary>
        /// A component was branched.
        /// </summary>
        [Description("b")]
        Branch,

        /// <summary>
        /// A component was translated.
        /// </summary>
        [Description("t")]
        Translate,

        /// <summary>
        /// A component was published.
        /// </summary>
        [Description("p")]
        Publish,

        /// <summary>
        /// A component was reviewed.
        /// </summary>
        [Description("r")]
        Review
    }

    /// <summary>
    /// Contains an enumerated list of available changeset snapshot process types.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum ChangesetSnapshotProcessType
    {
        /// <summary>
        /// A component was created new from template.
        /// </summary>
        CreateNew,

        /// <summary>
        /// A component was created with a Save As.
        /// </summary>
        SaveAs,

        /// <summary>
        /// A component was updated with a submit.
        /// </summary>
        Submit,

        /// <summary>
        /// A component was created as a branch.
        /// </summary>
        Branch,

        /// <summary>
        /// A target component was created or updated for translation.
        /// </summary>
        Translate,

        /// <summary>
        /// A component was updated by review.
        /// </summary>
        Review,

        /// <summary>
        /// A component created or updated with an import.
        /// </summary>
        Import
    }

    /// <summary>
    /// Contains an enumerated list of available changeset snapshot types.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum ChangesetSnapshotType
    {
        /// <summary>
        /// A Component target of an action within a versioning changeset
        /// </summary>
        Component,

        /// <summary>
        /// A Folder target of an action within a versioning changeset
        /// </summary>
        Folder,

        /// <summary>
        /// A Component tag snapshot
        /// </summary>
        ComponentTag,

        /// <summary>
        /// A component property snapshot
        /// </summary>
        ComponentProperty
    }

    /// <summary>
    /// This model represents an individual changeset snapshot target within an overall history changeset.
    /// </summary>
    public class ChangesetSnapshotModel : MicroCreatedUpdaterModelBase
    {
        #region Public Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="ChangesetSnapshotModel" /> class.
        /// </summary>
        public ChangesetSnapshotModel()
            : this(ChangesetSnapshotActionType.Create)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChangesetSnapshotModel" /> class.
        /// </summary>
        /// <param name="actionType">Contains the action on the target model.</param>
        /// <param name="restored">Contains a value indicating whether the snapshot action was a restoral of a previous history record.</param>
        /// <param name="processType">Contains an optional process type on the target model.</param>
        public ChangesetSnapshotModel(ChangesetSnapshotActionType actionType, bool restored = false, string processType = "None")
        {
            this.Action = actionType;
            this.Restored = restored;
            this.ProcessType = processType;
        }

        #endregion

        #region Common Shared Public Properties

        /// <summary>
        /// Gets or sets the action type to execute against the changeset action target.
        /// </summary>
        public ChangesetSnapshotActionType Action { get; set; }

        /// <summary>
        /// Gets or sets the optional process type creating the changeset.
        /// </summary>
        public string ProcessType { get; set; }

        /// <summary>
        /// Gets or sets the target type of the changeset snapshot type.
        /// </summary>
        public ChangesetSnapshotType SnapshotType { get; set; }

        /// <summary>
        /// Gets or sets the identity of the changeset target object.
        /// </summary>
        public long Id { get; set; }

        /// <summary>
        /// Gets or sets the related changeset identity.
        /// </summary>
        public Guid ChangesetId { get; set; }

        /// <summary>
        /// Gets or sets the name of the snapshot.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the parent folder model.
        /// </summary>
        public MinimalFolderModel ParentFolder { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this snapshot was a restoral from a previous history record.
        /// </summary>
        public bool Restored { get; set; }

        #endregion

        #region Extended Properties

        /// <summary>
        /// Gets or sets the component specific properties for the changeset target model.
        /// </summary>
        public ComponentSnapshotExtendedProperties ComponentProperties { get; set; }

        /// <summary>
        /// Gets or sets the folder specific properties for the changeset target model.
        /// </summary>
        public FolderSnapshotExtendedProperties FolderProperties { get; set; }

        /// <summary>
        /// Gets or sets the component property specific properties for the changeset target model.
        /// </summary>
        public PropertySnapshotExtendedProperties PropertyProperties { get; set; }

        #endregion
    }
}