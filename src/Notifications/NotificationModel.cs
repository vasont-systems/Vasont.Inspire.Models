﻿//-----------------------------------------------------------------------
// <copyright file="NotificationModel.cs" company="GlobalLink Vasont">
// Copyright (c) GlobalLink Vasont. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------
namespace Vasont.Inspire.Models.Notifications
{
    using System;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    /// <summary>
    /// Contains an enumerated list of available notification types.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    [Obsolete("Use local DTOs", false)]
    public enum NotificationType
    {
        /// <summary>
        /// A notification message alert.
        /// </summary>
        Message,

        /// <summary>
        /// A notification about a given folder.
        /// </summary>
        Folder,

        /// <summary>
        /// A notification about a given component.
        /// </summary>
        Component,

        /// <summary>
        /// A notification about a given review.
        /// </summary>
        Review,

        /// <summary>
        /// A notification about a given project.
        /// </summary>
        Project
    }

    /// <summary>
    /// Contains an enumerated list of notification target types.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    [Obsolete("Use local DTOs", false)]
    public enum NotificationTarget
    {
        /// <summary>
        /// Notify a specific user.
        /// </summary>
        User,

        /// <summary>
        /// Notify all users of a specific tenant.
        /// </summary>
        Tenant,

        /// <summary>
        /// Notify all users. All tenants. Admin only.
        /// </summary>
        All
    }

    /// <summary>
    /// Contains an enumerated list of notification states.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    [Obsolete("Use local DTOs", false)]
    public enum NotificationState
    {
        /// <summary>
        /// The notification is unread.
        /// </summary>
        Unread,

        /// <summary>
        /// The notification is read.
        /// </summary>
        Read,

        /// <summary>
        /// The notification is archived.
        /// </summary>
        Archived
    }

    /// <summary>
    /// Contains an enumerated list of available notification alert statuses.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    [Obsolete("Use local DTOs", false)]
    public enum NotificationMessageAlertStatus
    {
        /// <summary>
        /// The specified notification has no alert status.
        /// </summary>
        /// <remarks>No icon necessary.</remarks>
        None,

        /// <summary>
        /// The specified notification is for information.
        /// </summary>
        /// <remarks>Can denote with an information icon.</remarks>
        Info,

        /// <summary>
        /// The specified notification is for a warning.
        /// </summary>
        /// <remarks>Can denote with a yield icon.</remarks>
        Warning,

        /// <summary>
        /// The specified notification is for a failure.
        /// </summary>
        /// <remarks>Can denote with a red/stop icon.</remarks>
        Failure,

        /// <summary>
        /// The specified notification is for a finished alert.
        /// </summary>
        /// <remarks>Can denote with a checkered flag or green icon.</remarks>
        Finished
    }

    /// <summary>
    /// This class represents a notification message to be sent.
    /// </summary>
    /// <typeparam name="TModel">Contains the model type.</typeparam>
    /// <typeparam name="TTargetId">Contains the target identity type.</typeparam>
    [Obsolete("Use local DTOs", false)]
    public class NotificationModel<TModel, TTargetId>
    {
        /// <summary>
        /// Gets or sets a unique message identity.
        /// </summary>
        public Guid NotificationId { get; set; } = Guid.NewGuid();

        /// <summary>
        /// Gets or sets the notification date time in UTC.
        /// </summary>
        public DateTime NotificationDate { get; set; } = DateTime.UtcNow;

        /// <summary>
        /// Gets or sets the notification type.
        /// </summary>
        public NotificationType Type { get; set; } = NotificationType.Message;

        /// <summary>
        /// Gets or sets the notification state to pass to the system.
        /// </summary>
        public NotificationState State { get; set; } = NotificationState.Unread;

        /// <summary>
        /// Gets or sets the target type.
        /// </summary>
        public NotificationTarget Target { get; set; } = NotificationTarget.User;

        /// <summary>
        /// Gets or sets the tenant identity for the notification message.
        /// </summary>
        public string TenantId { get; set; }

        /// <summary>
        /// Gets or sets the notification target identity.
        /// </summary>
        public TTargetId TargetId { get; set; }

        /// <summary>
        /// Gets or sets the message alert status type.
        /// </summary>
        public NotificationMessageAlertStatus Alert { get; set; } = NotificationMessageAlertStatus.None;

        /// <summary>
        /// Gets or sets the additional notification model to be sent to the client.
        /// </summary>
        public TModel Model { get; set; }
    }
}