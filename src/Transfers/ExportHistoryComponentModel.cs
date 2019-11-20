//-------------------------------------------------------------
// <copyright file="ExportHistoryComponentModel.cs" company="Vasont Systems">
// Copyright (c) Vasont Systems. All rights reserved.
// </copyright>
//-------------------------------------------------------------
namespace Vasont.Inspire.Models.Transfers
{
    using System;

    /// <summary>
    /// Contains the history lookup properties for components that will be exported.
    /// </summary>
    public sealed class ExportHistoryComponentModel
    {
        /// <summary>
        /// Gets or sets the related changeset identity.
        /// </summary>
        public Guid ChangesetId { get; set; }

        /// <summary>
        /// Gets or sets the component identity.
        /// </summary>
        public long ComponentId { get; set; }
    }
}
