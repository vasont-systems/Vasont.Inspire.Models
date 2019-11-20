//-----------------------------------------------------------------------
// <copyright file="FolderBrowseModel.cs" company="Vasont Systems">
// Copyright (c) Vasont Systems. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace Vasont.Inspire.Models.Components
{
    using System;
    using Security;

    /// <summary>
    /// This class represents a folder returned from the folder API query.
    /// </summary>
    public class FolderBrowseModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FolderBrowseModel"/> class.
        /// </summary>
        public FolderBrowseModel()
        {
            this.Permissions = new PermissionModel();
            this.UniqueId = Guid.NewGuid();
        }

        /// <summary>
        /// Gets or sets the unique identity for this folder.
        /// </summary>
        public long FolderId { get; set; }

        /// <summary>
        /// Gets or sets the unique identity of the parent folder.
        /// </summary>
        public long? ParentFolderId { get; set; }

        /// <summary>
        /// Gets or sets the folder name.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets a globally unique identity for the folder.
        /// </summary>
        public Guid UniqueId { get; set; }

        /// <summary>
        /// Gets or sets a description of the folder.
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this folder has at least one child folder.
        /// </summary>
        public bool HasChildren { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the folder contains any components.
        /// </summary>
        public bool HasComponents { get; set; }

        /// <summary>
        /// Gets or sets the permissions for this folder item.
        /// </summary>
        public PermissionModel Permissions { get; set; }
    }
}