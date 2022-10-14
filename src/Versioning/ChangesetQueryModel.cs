//--------------------------------------------------------------------------
// <copyright file="ChangesetQueryModel.cs" company="GlobalLink Vasont">
// Copyright (c) GlobalLink Vasont. All rights reserved.
// </copyright>
//--------------------------------------------------------------------------
namespace Vasont.Inspire.Models.Versioning
{
    using System;
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

        /// <summary>
        /// Gets or sets the start date of the changeset lookup.
        /// </summary>
        public DateTime StartDate { get; set; }

        /// <summary>
        /// Gets or sets the end date of the changeset lookup.
        /// </summary>
        public DateTime EndDate { get; set; }
    }
}
