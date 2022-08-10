//-----------------------------------------------------------------------
// <copyright file="NotificationMessageModel.cs" company="GlobalLink Vasont">
// Copyright (c) GlobalLink Vasont. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------
namespace Vasont.Inspire.Models.Notifications.Types
{
    /// <summary>
    /// This class represents a message.
    /// </summary>
    public class NotificationMessageModel : NotificationModelBase
    {
        /// <summary>
        /// Gets or sets the message subject.
        /// </summary>
        public string Subject { get; set; }

        /// <summary>
        /// Gets or sets the summary message to display to the user in notification toasts.
        /// </summary>
        public string Summary { get; set; }

        /// <summary>
        /// Gets or sets the message content body in optional HTML format.
        /// </summary>
        public string HtmlBody { get; set; }

        /// <summary>
        /// Gets or sets the detailed message content body in optional HTML format.
        /// </summary>
        public string DetailedHtmlBody { get; set; }
    }
}