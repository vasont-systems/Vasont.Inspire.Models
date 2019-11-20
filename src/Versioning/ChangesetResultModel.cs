//---------------------------------------------------------------------------
// <copyright file="ChangesetResultModel.cs" company="Vasont Systems">
// Copyright (c) Vasont Systems. All rights reserved.
// </copyright>
//---------------------------------------------------------------------------
namespace Vasont.Inspire.Models.Versioning
{
    using System.Collections.Generic;

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
        public List<ChangesetModel> Changesets { get; set; }
    }
}
