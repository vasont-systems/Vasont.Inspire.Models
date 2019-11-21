//-----------------------------------------------------------------------
// <copyright file="CreateChangesetModel.cs" company="GlobalLink Vasont">
// Copyright (c) GlobalLink Vasont. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------
namespace Vasont.Inspire.Models.Versioning
{
    /// <summary>
    /// This class contains values for creating a new changeset.
    /// </summary>
    public class CreateChangesetModel
    {
        /// <summary>
        /// Gets or sets the label of the changeset.
        /// </summary>
        public string Label { get; set; }

        /// <summary>
        /// Gets or sets an optional comment for the changeset.
        /// </summary>
        public string Comment { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the changeset is saved to the database automatically.
        /// </summary>
        public bool SaveAutomatically { get; set; } = true;
    }
}
