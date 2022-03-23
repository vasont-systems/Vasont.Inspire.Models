//-----------------------------------------------------------------------
// <copyright file="NotifyUsersModel.cs" company="GlobalLink Vasont">
// Copyright (c) GlobalLink Vasont. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------
namespace Vasont.Inspire.Models.Notifications
{
    using System.Collections.Generic;

    /// <summary>
    /// This model represents the inputs for sending a notification to list of users.
    /// </summary>
    public class NotifyUsersModel
    {
        /// <summary>
        /// Gets or sets the list of user identifiers.
        /// </summary>
        public List<long> UserIds { get; set; }

        /// <summary>
        /// Gets or sets the notification message subject.
        /// </summary>
        public string NotificationSubject { get; set; }

        /// <summary>
        /// Gets or sets the summary message to display to the user in notification toasts.
        /// </summary>
        public string NotificationSummary { get; set; }

        /// <summary>
        /// Gets or sets the message content body in optional HTML format.
        /// </summary>
        public string NotificationHtmlBody { get; set; }

        /// <summary>
        /// Gets or sets the slack message in optional Markdown format.
        /// </summary>
        public string SlackMessage { get; set; }
    }
}