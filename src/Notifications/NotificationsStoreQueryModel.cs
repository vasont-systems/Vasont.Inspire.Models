﻿//-----------------------------------------------------------------------
// <copyright file="NotificationsStoreQueryModel.cs" company="GlobalLink Vasont">
// Copyright (c) GlobalLink Vasont. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------
namespace Vasont.Inspire.Models.Notifications
{
    using Vasont.Inspire.Models.Common;

    /// <summary>
    /// This class represents a notification store query model used in paging interfaces for notification messages.
    /// </summary>
    public class NotificationsStoreQueryModel : PaginatedQueryRequestModel
    {
        /// <summary>
        /// Contains a string used for filtering notification results.
        /// </summary>
        public string SearchText { get; set; }
    }
}
