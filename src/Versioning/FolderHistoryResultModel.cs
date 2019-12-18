//---------------------------------------------------------------------------
// <copyright file="FolderHistoryResultModel.cs" company="GlobalLink Vasont">
// Copyright (c) GlobalLink Vasont. All rights reserved.
// </copyright>
//---------------------------------------------------------------------------
namespace Vasont.Inspire.Models.Versioning
{
    using System.Collections.Generic;

    /// <summary>
    /// This class represents the results of a paged component history query request.
    /// </summary>
    public sealed class FolderHistoryResultModel
    {
        /// <summary>
        /// Gets or sets the total number of history records found.
        /// </summary>
        public long TotalCount { get; set; }

        /// <summary>
        /// Gets or sets the resulting history records for the specified page.
        /// </summary>
        public List<MinimalFolderHistoryModel> History { get; set; } = new List<MinimalFolderHistoryModel>();
    }
}
