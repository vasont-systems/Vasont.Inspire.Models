﻿//---------------------------------------------------------------------
// <copyright file="MinimalComponentModel.cs" company="GlobalLink Vasont">
// Copyright (c) GlobalLink Vasont. All rights reserved.
// </copyright>
//---------------------------------------------------------------------
namespace Vasont.Inspire.Models.Components
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using Security;
    using Vasont.Inspire.Core.Extensions;
    using Vasont.Inspire.Core.Storage;
    using Vasont.Inspire.Models.Common;
    using Vasont.Inspire.Models.Projects;

    /// <summary>
    /// Contains an enumerated list of component state types.
    /// </summary>
    [Obsolete("Use local enums", false)]
    [JsonConverter(typeof(StringEnumConverter))]
    public enum ComponentStateType
    {
        /// <summary>
        /// Contains a value that indicates the component is draft.
        /// </summary>
        Draft,

        /// <summary>
        /// Contains a value that indicates the component has been approved.
        /// </summary>
        Approved,

        /// <summary>
        /// Contains a value that indicates the component has invalid relationships.
        /// </summary>
        Invalid,

        /// <summary>
        /// Contains a value that indicates the component has been modified and needs translation.
        /// </summary>
        NeedsTranslation,

        /// <summary>
        /// Contains a value that indicates the component is electronically signed.
        /// </summary>
        Signed
    }

    /// <summary>
    /// Contains an enumerated list of component branch types.
    /// </summary>
    [Obsolete("Use local enums", false)]
    [JsonConverter(typeof(StringEnumConverter))]
    public enum ComponentBranchType
    {
        /// <summary>
        /// Contains a value that indicates the component is not a branch and does not have a branch.
        /// </summary>
        None,

        /// <summary>
        /// Contains a value that indicates the component is branch component.
        /// </summary>
        IsBranch,

        /// <summary>
        /// Contains a value that indicates the component has a branch.
        /// </summary>
        HasBranch,

        /// <summary>
        /// Contains a value that indicates the component is a branch component and has a branch.
        /// </summary>
        IsBoth
    }

    /// <summary>
    /// Contains an enumerated list of component attachment types.
    /// </summary>
    [Obsolete("Use local enums", false)]
    [JsonConverter(typeof(StringEnumConverter))]
    public enum ComponentAttachmentType
    {
        /// <summary>
        /// Contains a value that indicates the component has no attachments.
        /// </summary>
        None,

        /// <summary>
        /// Contains a value that indicates the component is an attachment.
        /// </summary>
        IsAttachment,

        /// <summary>
        /// Contains a value that indicates the component has an attachment.
        /// </summary>
        HasAttachment,

        /// <summary>
        /// Contains a value that indicates the component is an attachment and has an attachment.
        /// </summary>
        IsBoth
    }

    /// <summary>
    /// This class represents a component model with minimal information that will used for interaction with application user interfaces.
    /// </summary>
    [Obsolete("Use local DTOs", false)]
    public class MinimalComponentModel : CreatedUpdaterModelBase
    {
        /// <summary>
        /// Contains the item type for the specified minimal component.
        /// </summary>
        private ProjectFolderItemType itemType;

        #region Public Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="MinimalComponentModel" /> class.
        /// </summary>
        public MinimalComponentModel()
            : this(PermissionFlags.None)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MinimalComponentModel" /> class.
        /// </summary>
        /// <param name="permissions">Contains an optional permissions value for the minimal component model.</param>
        public MinimalComponentModel(PermissionFlags permissions)
        {
            this.ComponentType = new MinimalComponentTypeModel();
            this.itemType = ProjectFolderItemType.Component;
            this.State = ComponentStateType.Draft;
            this.BranchType = ComponentBranchType.None;
            this.AttachmentType = ComponentAttachmentType.None;
            this.Permissions = new PermissionModel(permissions);
            this.FollowedByUsers = new List<MinimalUserModel>();
        }

        #endregion

        #region Public Properties

        /// <summary>
        /// Gets or sets the unique identity of the component.
        /// </summary>
        public long ComponentId { get; set; }

        /// <summary>
        /// Gets or sets the component type identity value.
        /// </summary>
        public long ComponentTypeId { get; set; }

        /// <summary>
        /// Gets or sets the component type.
        /// </summary>
        public MinimalComponentTypeModel ComponentType { get; set; }

        /// <summary>
        /// Gets or sets the component metrics information.
        /// </summary>
        public ComponentMetricsModel Metrics { get; set; }

        /// <summary>
        /// Gets or sets the folder in which the component is stored.
        /// </summary>
        public MinimalFolderModel Folder { get; set; }

        /// <summary>
        /// Gets a value indicating whether the component is an image.
        /// </summary>
        public bool IsImage => this.ComponentType != null && this.ComponentType.Binary && Files.IsImageFile(this.FileName);

        /// <summary>
        /// Gets or sets the binary component content type name.
        /// </summary>
        public string ContentType { get; set; }

        /// <summary>
        /// Gets or sets the component title.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the language code of component content.
        /// </summary>
        public string LanguageCode { get; set; }

        /// <summary>
        /// Gets or sets the language name.
        /// </summary>
        public string LanguageName { get; set; }

        /// <summary>
        /// Gets or sets the file name of the component.
        /// </summary>
        public string FileName { get; set; }

        /// <summary>
        /// Gets or sets the component state information.
        /// </summary>
        public ComponentStateType State { get; set; }

        /// <summary>
        /// Gets or sets the state on the model via string name.
        /// </summary>
        [JsonIgnore]
        public string StateName
        {
            get => this.State.ToString();

            set => this.State = value.ToEnum<ComponentStateType>();
        }

        /// <summary>
        /// Gets or sets the globally unique identity value for the component content.
        /// </summary>
        public Guid UniqueId { get; set; }

        /// <summary>
        /// Gets or sets the hash of the content.
        /// </summary>
        public string HashKey { get; set; }

        /// <summary>
        /// Gets or sets the lock information related to the component.
        /// </summary>
        public ComponentLockModel Lock { get; set; }

        /// <summary>
        /// Gets or sets the permissions model for the component.
        /// </summary>
        public PermissionModel Permissions { get; set; }

        /// <summary>
        /// Gets or sets the component virtual path.
        /// </summary>
        public string VirtualPath { get; set; }

        /// <summary>
        /// Gets or sets the project item type.
        /// </summary>
        public ProjectFolderItemType Type
        {
            get
            {
                // if binary...
                if (this.itemType == ProjectFolderItemType.Component && this.ComponentType != null && this.ComponentType.Binary)
                {
                    // use image if component is known image
                    this.itemType = this.IsImage ? ProjectFolderItemType.Image : ProjectFolderItemType.Binary;
                }

                return this.itemType;
            }

            set => this.itemType = value != ProjectFolderItemType.Folder ? value : ProjectFolderItemType.Component;
        }

        /// <summary>
        /// Gets or sets a value indicating whether this component can translate.
        /// </summary>
        public bool CanTranslate { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this component is followed.
        /// </summary>
        public bool IsFollowed { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this component is followed by current user.
        /// </summary>
        public bool IsFollowedByCurrentUser { get; set; }

        /// <summary>
        /// Gets or sets a list of users following the component.
        /// </summary>
        public List<MinimalUserModel> FollowedByUsers { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this component is shared.
        /// </summary>
        public bool IsShared { get; set; }

        /// <summary>
        /// Gets or sets the number of components referencing the component.
        /// </summary>
        public long SharedComponentsCount { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this component is referenced.
        /// </summary>
        public bool IsReferenced { get; set; }

        /// <summary>
        /// Gets or sets the number of distinct components referencing the component.
        /// </summary>
        public long ReferencedComponentsCount { get; set; }

        /// <summary>
        /// Gets or sets the component branch type.
        /// </summary>
        public ComponentBranchType BranchType { get; set; }

        /// <summary>
        /// Gets or sets the component attachment type.
        /// </summary>
        public ComponentAttachmentType AttachmentType { get; set; }

        /// <summary>
        /// Gets or sets the most recent component access information.
        /// </summary>
        public MinimalComponentUserAccessModel MostRecentAccess { get; set; }

        /// <summary>
        /// Gets or sets the number of component accesses.
        /// </summary>
        public int UserAccessCount { get; set; }

        /// <summary>
        /// Gets or sets the current version label.
        /// </summary>
        public string VersionLabel { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the current version comment.
        /// </summary>
        public string VersionComment { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the current esignature date.
        /// </summary>
        public DateTime? SignedDate { get; set; }

        /// <summary>
        /// Gets or sets the current esignature signed by user name.
        /// </summary>
        public string SignedBy { get; set; } = string.Empty;

        #endregion
    }
}