//-----------------------------------------------------------------------
// <copyright file="NotifyUsersModel.cs" company="GlobalLink Vasont">
// Copyright (c) GlobalLink Vasont. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------
namespace Vasont.Inspire.Models.Notifications
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// This model represents the inputs for notifying list of users via notification / email / slack.
    /// </summary>
    [Obsolete("Use local DTOs", false)]
    public class NotifyUsersModel
    {
        /// <summary>
        /// Gets or sets the list of user identifiers.
        /// </summary>
        public List<long> UserIds { get; set; }

        /// <summary>
        /// Gets or sets the subject for the notification or email.
        /// </summary>
        public string Subject { get; set; }

        /// <summary>
        /// Gets or sets the summary message to display to the user in notification toasts.
        /// </summary>
        public string Summary { get; set; }

        /// <summary>
        /// Gets or sets the html body.
        /// </summary>
        public string HtmlBody { get; set; }

        /// <summary>
        /// Gets or sets the optional text body.
        /// </summary>
        public string TextBody { get; set; }

        /// <summary>
        /// Gets or sets the optional markdown body.
        /// </summary>
        public string MarkdownBody { get; set; }
    }
}