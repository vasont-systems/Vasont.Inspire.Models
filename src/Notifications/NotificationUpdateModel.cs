//-----------------------------------------------------------------------
// <copyright file="NotificationUpdateModel.cs" company="GlobalLink Vasont">
// Copyright (c) GlobalLink Vasont. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------
namespace Vasont.Inspire.Models.Notifications
{
    /// <summary>
    /// This model represents the inputs for a notification message update call within the Inspire application.
    /// </summary>
    public class NotificationUpdateModel
    {
        /// <summary>
        /// Gets or sets the notification state of the message.
        /// </summary>
        public NotificationState State { get; set; }
    }
}