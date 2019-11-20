//---------------------------------------------------------------------------
// <copyright file="ComponentHistoryResultModel.cs" company="Vasont Systems">
// Copyright (c) Vasont Systems. All rights reserved.
// </copyright>
//---------------------------------------------------------------------------
namespace Vasont.Inspire.Models.Versioning
{
    using System.Collections.Generic;

    /// <summary>
    /// This class represents the results of a paged component history query request.
    /// </summary>
    public sealed class ComponentHistoryResultModel
    {
        /// <summary>
        /// Gets or sets the total number of history records found.
        /// </summary>
        public long TotalCount { get; set; }

        /// <summary>
        /// Gets or sets the resulting history records for the specified page.
        /// </summary>
        public List<MinimalComponentHistoryModel> History { get; set; }
    }
}
