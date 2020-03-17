//-----------------------------------------------------------------------
// <copyright file="BaseLoadModel.cs" company="GlobalLink Vasont">
// Copyright (c) GlobalLink Vasont. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------
namespace Vasont.Inspire.Models.Components
{
    using System;

    /// <summary>
    /// This class represents a base set of common editor loading models.
    /// </summary>
    public abstract class BaseLoadModel
    {
        /// <summary>
        /// Gets or sets the hyperlink reference name to the component to load.
        /// </summary>
        public string Href { get; set; }

        /// <summary>
        /// Gets or sets the component identity.
        /// </summary>
        public long ComponentId { get; set; }

        /// <summary>
        /// Gets or sets the component changeset for historic record retrieval
        /// </summary>
        public Guid ChangesetId { get; set; } = Guid.Empty;
    }
}
