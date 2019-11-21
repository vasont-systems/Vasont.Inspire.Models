//-----------------------------------------------------------------------
// <copyright file="CreateSnapshotModel.cs" company="GlobalLink Vasont">
// Copyright (c) GlobalLink Vasont. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------
namespace Vasont.Inspire.Models.Versioning
{
    /// <summary>
    /// This class contains values for creating a new snapshot.
    /// </summary>
    public class CreateSnapshotModel
    {
        /// <summary>
        /// Gets or sets the identity of the component.
        /// </summary>
        public long ComponentId { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether or not to include referenced content.
        /// </summary>
        public bool IncludeReferencedContent { get; set; }

        /// <summary>
        /// Gets or sets an optional name for the snapshot.
        /// </summary>
        public string Label { get; set; }

        /// <summary>
        /// Gets or sets an optional comment for the snapshot.
        /// </summary>
        public string Comment { get; set; }
    }
}
