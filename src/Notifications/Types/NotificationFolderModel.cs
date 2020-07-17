//-----------------------------------------------------------------------
// <copyright file="NotificationFolderModel.cs" company="GlobalLink Vasont">
// Copyright (c) GlobalLink Vasont. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------
namespace Vasont.Inspire.Models.Notifications.Types
{
    using System;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    /// <summary>
    /// Contains an enumerated list of available folder action notifications.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum NotificationFolderAction
    {
        /// <summary>
        /// The specified folder was updated.
        /// </summary>
        Updated,

        /// <summary>
        /// The specified folder was removed.
        /// </summary>
        Removed,

        /// <summary>
        /// The specified folder was moved.
        /// </summary>
        Moved,

        /// <summary>
        /// Content was added to the specified parent folder.
        /// </summary>
        ContentAdded,

        /// <summary>
        /// Content was removed from the specified parent folder.
        /// </summary>
        ContentRemoved
    }

    /// <summary>
    /// This class represents a folder notification message.
    /// </summary>
    public class NotificationFolderModel : NotificationModelBase
    {
        /// <summary>
        /// Gets or sets the specified folder identity.
        /// </summary>
        public long FolderId { get; set; }

        /// <summary>
        /// Gets or sets the specified folder unique identity.
        /// </summary>
        public Guid UniqueId { get; set; }

        /// <summary>
        /// Gets or sets the specified folder action.
        /// </summary>
        public NotificationFolderAction Action { get; set; }

        /// <summary>
        /// Gets or sets the specified folder name.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the specified folder path.
        /// </summary>
        public string Path { get; set; }
    }
}