//-----------------------------------------------------------------------
// <copyright file="RestoreComponentRequestModel.cs" company="GlobalLink Vasont">
// Copyright (c) GlobalLink Vasont. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------
namespace Vasont.Inspire.Core.Versioning.Models
{
    using System;
    using Vasont.Inspire.Models.Versioning;

    /// <summary>
    /// This class represents a component or history changeset restore request.
    /// </summary>
    public class RestoreComponentRequestModel
    {
        /// <summary>
        /// Gets or sets the guid for a changeset for a restore request.
        /// </summary>
        public Guid ChangesetId { get; set; }

        /// <summary>
        /// Gets or sets the component identity for a restore request.
        /// </summary>
        public long ComponentId { get; set; }

        /// <summary>
        /// Gets or sets the restore options for a restore request.
        /// </summary>
        public RestoreOptionsModel RestoreOptions { get; set; }
    }
}