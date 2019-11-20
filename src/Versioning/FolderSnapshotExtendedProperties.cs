//-----------------------------------------------------------------------
// <copyright file="FolderSnapshotExtendedProperties.cs" company="Vasont Systems">
// Copyright (c) Vasont Systems. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------
namespace Vasont.Inspire.Models.Versioning
{
    using System;

    /// <summary>
    /// This class contains folder specific properties for a changeset snapshot model.
    /// </summary>
    public sealed class FolderSnapshotExtendedProperties
    {
        /// <summary>
        /// Gets or sets the unique identity of the folder.
        /// </summary>
        public Guid UniqueId { get; set; }

        /// <summary>
        /// Gets or sets an optional description about the folder.
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets the path of the folder.
        /// </summary>
        public string Path { get; set; }
    }
}
