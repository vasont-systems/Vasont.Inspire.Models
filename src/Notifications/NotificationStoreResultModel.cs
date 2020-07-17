//-----------------------------------------------------------------------
// <copyright file="NotificationStoreResultModel.cs" company="GlobalLink Vasont">
// Copyright (c) GlobalLink Vasont. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------
namespace Vasont.Inspire.Models.Notifications
{
    using System.Collections.Generic;

    /// <summary>
    /// This class represents the results of a notifications store query request.
    /// </summary>
    public class NotificationStoreResultModel
    {
        /// <summary>
        /// Gets or sets the total number of notifications for the user.
        /// </summary>
        public long TotalCount { get; set; }

        /// <summary>
        /// Gets or sets the resulting notifications from the query request.
        /// </summary>
        public List<NotificationStoreModel> Notifications { get; set; } = new List<NotificationStoreModel>();
    }
}
