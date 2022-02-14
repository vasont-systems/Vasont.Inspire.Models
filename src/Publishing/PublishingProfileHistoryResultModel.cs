//----------------------------------------------------------------------------
// <copyright file="PublishingProfileHistoryResultModel.cs" company="GlobalLink Vasont">
// Copyright (c) GlobalLink Vasont. All rights reserved.
// </copyright>
//----------------------------------------------------------------------------
namespace Vasont.Inspire.Models.Publishing
{
    using System.Collections.Generic;

    /// <summary>
    /// This class represents the results of a publishing profile history query request.
    /// </summary>
    public class PublishingProfileHistoryResultModel
    {
        /// <summary>
        /// Gets or sets the total number of publishing profile histories.
        /// </summary>
        public long TotalCount { get; set; }

        /// <summary>
        /// Gets or sets the resulting publishing profile histories from the query request.
        /// </summary>
        public List<PublishingProfileHistoryModel> PublishingProfileHistories { get; set; } = new List<PublishingProfileHistoryModel>();
    }
}