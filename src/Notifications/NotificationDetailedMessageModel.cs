﻿//-----------------------------------------------------------------------
// <copyright file="NotificationDetailedMessageModel.cs" company="GlobalLink Vasont">
// Copyright (c) GlobalLink Vasont. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------
namespace Vasont.Inspire.Models.Notifications
{
    using System;

    /// <summary>
    /// This class represents a detailedmessage.
    /// </summary>
    [Obsolete("Use local DTOs", false)]
    public class NotificationDetailedMessageModel
    {
        /// <summary>
        /// Gets or sets the identity for the notification message.
        /// </summary>
        public Guid NotificationMessageId { get; set; }

        /// <summary>
        /// Gets or sets the identity for the detailed message.
        /// </summary>
        public Guid MessageId { get; set; }

        /// <summary>
        /// Gets or sets the unique identity for the message.
        /// </summary>
        public Guid UniqueId { get; set; }

        /// <summary>
        /// Gets or sets the detailed message content body in optional HTML format.
        /// </summary>
        public string Message { get; set; }
    }
}