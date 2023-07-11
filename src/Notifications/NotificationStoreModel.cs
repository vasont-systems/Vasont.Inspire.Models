//-----------------------------------------------------------------------
// <copyright file="NotificationStoreModel.cs" company="GlobalLink Vasont">
// Copyright (c) GlobalLink Vasont. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------
namespace Vasont.Inspire.Models.Notifications
{
    using System;
    using Vasont.Inspire.Models.Notifications.Types;

    /// <summary>
    /// This model represents a notification alert that has been stored in the user's store for load on UI/Profile startup.
    /// </summary>
    [Obsolete("Use local DTOs", false)]
    public class NotificationStoreModel
    {
        /// <summary>
        /// Gets or sets the Notification identity.
        /// </summary>
        public Guid NotificationId { get; set; }

        /// <summary>
        /// Gets or sets the user identity.
        /// </summary>
        public long UserId { get; set; }

        /// <summary>
        /// Gets or sets the notification date.
        /// </summary>
        public DateTime NotificationDate { get; set; }

        /// <summary>
        /// Gets or sets the alert state of the notification.
        /// </summary>
        public NotificationMessageAlertStatus Alert { get; set; }

        /// <summary>
        /// Gets or sets the notification state.
        /// </summary>
        public NotificationState State { get; set; }

        /// <summary>
        /// Gets or sets the target type.
        /// </summary>
        public NotificationTarget Target { get; set; }

        /// <summary>
        /// Gets or sets the type of notification.
        /// </summary>
        public NotificationType Type { get; set; }

        /// <summary>
        /// Gets or sets the message model properties.
        /// </summary>
        public NotificationMessageModel Message { get; set; }
    }
}