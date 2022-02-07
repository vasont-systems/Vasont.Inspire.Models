//-----------------------------------------------------------------------
// <copyright file="PublishingProfileHistoryModel.cs" company="GlobalLink Vasont">
// Copyright (c) GlobalLink Vasont. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------
namespace Vasont.Inspire.Models.Publishing
{
    using System;
    using Vasont.Inspire.Models.Security;

    /// <summary>
    /// This model class represents the profile history detail for a publishing profile.
    /// </summary>
    public class PublishingProfileHistoryModel
    {
        /// <summary>
        /// Gets or sets the publish history identity.
        /// </summary>
        public long PublishHistoryId { get; set; }

        /// <summary>
        /// Gets or sets the publish profile identity.
        /// </summary>
        public long PublishProfileId { get; set; }

        /// <summary>
        /// Gets or sets the date time when the profile was published.
        /// </summary>
        public DateTime PublishedDate { get; set; }

        /// <summary>
        /// Gets or sets the user information about the user who last updated the profile.
        /// </summary>
        public MinimalUserModel PublishedBy { get; set; } = new MinimalUserModel();
    }
}