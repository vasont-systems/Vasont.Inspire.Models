//--------------------------------------------------------------------------
// <copyright file="FolderHistoryQueryModel.cs" company="GlobalLink Vasont">
// Copyright (c) GlobalLink Vasont. All rights reserved.
// </copyright>
//--------------------------------------------------------------------------
namespace Vasont.Inspire.Models.Versioning
{
    using Common;

    /// <summary>
    /// This model class represents parameters passed in from a paging grid listing a folder's history.
    /// </summary>
    public sealed class FolderHistoryQueryModel : PaginatedQueryRequestModel
    {
        /// <summary>
        /// Gets or sets the folder to retrieve history on.
        /// </summary>
        public long FolderId { get; set; }
    }
}
