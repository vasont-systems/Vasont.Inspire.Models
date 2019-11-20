//--------------------------------------------------------------------------
// <copyright file="ChangesetQueryModel.cs" company="Vasont Systems">
// Copyright (c) Vasont Systems. All rights reserved.
// </copyright>
//--------------------------------------------------------------------------
namespace Vasont.Inspire.Models.Versioning
{
    using Common;

    /// <summary>
    /// This model class represents parameters passed in from a paging grid listing of changeset history.
    /// </summary>
    public sealed class ChangesetQueryModel : PaginatedQueryRequestModel
    {
        /// <summary>
        /// Gets or sets the search text to find within changeset labels and/or comments.
        /// </summary>
        public string SearchText { get; set; }
    }
}
