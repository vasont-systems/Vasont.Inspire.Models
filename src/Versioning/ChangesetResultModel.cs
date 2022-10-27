//---------------------------------------------------------------------------
// <copyright file="ChangesetResultModel.cs" company="GlobalLink Vasont">
// Copyright (c) GlobalLink Vasont. All rights reserved.
// </copyright>
//---------------------------------------------------------------------------
namespace Vasont.Inspire.Models.Versioning
{
    using System.Collections.Generic;
    using Vasont.Inspire.Models.Components;

    /// <summary>
    /// This class represents the results of a paged changeset history query request.
    /// </summary>
    public sealed class ChangesetResultModel
    {
        /// <summary>
        /// Gets or sets the total number of history records found.
        /// </summary>
        public long TotalCount { get; set; }

        /// <summary>
        /// Gets or sets the resulting changeset records for the specified page.
        /// </summary>
        public List<ChangesetModel> Changesets { get; set; } = new List<ChangesetModel>();

        /// <summary>
        /// Gets or sets the components related to a changeset.
        /// </summary>
        public List<MicroComponentModel> Components { get; set; } = new List<MicroComponentModel>();
    }
}
