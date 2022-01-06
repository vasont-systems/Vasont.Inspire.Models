//--------------------------------------------------------------------------
// <copyright file="PublishingProfileQueryModel.cs" company="GlobalLink Vasont">
// Copyright (c) GlobalLink Vasont. All rights reserved.
// </copyright>
//--------------------------------------------------------------------------
namespace Vasont.Inspire.Models.Publishing
{
    using Common;

    /// <summary>
    /// This model class represents parameters passed in from a paging grid listing of publishing profiles.
    /// </summary>
    public sealed class PublishingProfileQueryModel : PaginatedQueryRequestModel
    {
        /// <summary>
        /// Gets or sets search text that will be used to filter the publishing profiles.
        /// </summary>
        public string SearchText { get; set; }
    }
}
