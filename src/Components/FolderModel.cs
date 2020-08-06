//-----------------------------------------------------------------------
// <copyright file="FolderModel.cs" company="GlobalLink Vasont">
// Copyright (c) GlobalLink Vasont. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace Vasont.Inspire.Models.Components
{
    using System;
    using System.Collections.Generic;
    using Vasont.Inspire.Models.Common;

    /// <summary>
    /// This class represents a component folder for use within the application.
    /// </summary>
    public class FolderModel : CreatedUpdaterModelBase
    {
        /// <summary>
        /// Gets or sets the unique identity of the folder.
        /// </summary>
        public long FolderId { get; set; }

        /// <summary>
        /// Gets or sets a globally unique identity for the folder.
        /// </summary>
        public Guid UniqueId { get; set; }

        /// <summary>
        /// Gets or sets the identity of the parent folder.
        /// </summary>
        public long? ParentFolderId { get; set; }

        /// <summary>
        /// Gets or sets the name of the folder.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets a description of the folder.
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets a list of <see cref="FolderModel" /> objects that are children of the folder.
        /// </summary>
        public List<FolderModel> Children { get; set; } = new List<FolderModel>();

        /// <summary>
        /// Gets or sets the folder path.
        /// </summary>
        public string Path { get; set; }
    }
}