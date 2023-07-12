//--------------------------------------------------------------------------
// <copyright file="PublishingProfileHistoryQueryModel.cs" company="GlobalLink Vasont">
// Copyright (c) GlobalLink Vasont. All rights reserved.
// </copyright>
//--------------------------------------------------------------------------
namespace Vasont.Inspire.Models.Publishing
{
    using Common;

    /// <summary>
    /// This model class represents parameters passed in from a paging grid listing of publishing profile histories.
    /// </summary>
    public sealed class PublishingProfileHistoryQueryModel : PaginatedQueryRequestModel
    {
        /// <summary>
        /// Gets or sets the identity of the publishing profile to retrieve histories for.
        /// </summary>
        public long ProfileId { get; set; }

        /// <summary>
        /// Gets or sets search text that will be used to filter the publishing profile histories.
        /// </summary>
        public string SearchText { get; set; }
    }
}