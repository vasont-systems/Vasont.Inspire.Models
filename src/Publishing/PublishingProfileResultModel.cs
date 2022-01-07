//----------------------------------------------------------------------------
// <copyright file="PublishingProfileResultModel.cs" company="GlobalLink Vasont">
// Copyright (c) GlobalLink Vasont. All rights reserved.
// </copyright>
//----------------------------------------------------------------------------
namespace Vasont.Inspire.Models.Publishing
{
    using System.Collections.Generic;

    /// <summary>
    /// This class represents the results of a publishing profile query request.
    /// </summary>
    public class PublishingProfileResultModel
    {
        /// <summary>
        /// Gets or sets the total number of publishing profiles.
        /// </summary>
        public long TotalCount { get; set; }

        /// <summary>
        /// Gets or sets the resulting publishing profiles from the query request.
        /// </summary>
        public List<PublishingProfileModel> PublishingProfiles { get; set; } = new List<PublishingProfileModel>();
    }
}
