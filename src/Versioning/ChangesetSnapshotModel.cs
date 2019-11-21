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
        /// Create a target
        /// </summary>
        [Description("c")]
        Create,

        /// <summary>
        /// Update a target
        /// </summary>
        [Description("u")]
        Update,

        /// <summary>
        /// Update a component target including content
        /// </summary>
        [Description("u")]
        UpdateWithContent,

        /// <summary>
        /// Delete a target
        /// </summary>
        [Description("d")]
        Delete,

        /// <summary>
        /// Move a target
        /// </summary>
        [Description("m")]
        Move,

        /// <summary>
        /// Create a target on demand
        /// </summary>
        [Description("o")]
        OnDemand
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
        /// Initializes a new instance of the <see cref="ChangesetSnapshotModel"/> class.
        /// </summary>
        public ChangesetSnapshotModel()
            : this(ChangesetSnapshotActionType.Create)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChangesetSnapshotModel"/> class.
        /// </summary>
        /// <param name="actionType">Contains the action on the target model.</param>
        /// <param name="restored">Contains a value indicating whether the snapshot action was a restoral of a previous history record.</param>
        public ChangesetSnapshotModel(ChangesetSnapshotActionType actionType, bool restored = false)
        {
            this.Action = actionType;
            this.Restored = restored;
        }

        #endregion

        #region Common Shared Public Properties
        /// <summary>
        /// Gets or sets the action type to execute against the changeset action target.
        /// </summary>
        public ChangesetSnapshotActionType Action { get; set; }

        /// <summary>
        /// Gets the target type of the changeset snapshot type.
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
