//-----------------------------------------------------------------------
// <copyright file="NotificationModelBase.cs" company="GlobalLink Vasont">
// Copyright (c) GlobalLink Vasont. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------
namespace Vasont.Inspire.Models.Notifications
{
    using System.Collections.Generic;

    /// <summary>
    /// This abstract class contains properties that are to be applied to all notification model classes.
    /// </summary>
    public abstract class NotificationModelBase
    {
        /// <summary>
        /// Gets or sets an optional set of metadata for the notification message.
        /// </summary>
        public Dictionary<string, string> Metadata { get; set; } = new Dictionary<string, string>();
    }
}
