//-----------------------------------------------------------------------
// <copyright file="NotificationStoreQueryModel.cs" company="GlobalLink Vasont">
// Copyright (c) GlobalLink Vasont. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------
namespace Vasont.Inspire.Models.Notifications
{
    using System.Collections.Generic;
    using Vasont.Inspire.Models.Common;

    /// <summary>
    /// This class represents a notification store query model used in paging interfaces for notification messages.
    /// </summary>
    public class NotificationStoreQueryModel : PaginatedQueryRequestModel
    {
        /// <summary>
        /// Gets or sets a string used for filtering notification results.
        /// </summary>
        public string SearchText { get; set; }

        /// <summary>
        /// Gets or sets a list of states to filter by. An empty list will return not filter by state.
        /// </summary>
        public List<NotificationState> State { get; set; } = new List<NotificationState>();
    }
}