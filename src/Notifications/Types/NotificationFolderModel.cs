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
    [Obsolete("Use local DTOs", false)]
    public enum NotificationFolderAction
    {
        /// <summary>
        /// The specified folder was added.
        /// </summary>
        Added,

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
        Moved
    }

    /// <summary>
    /// This class represents a folder notification message.
    /// </summary>
    [Obsolete("Use local DTOs", false)]
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
        /// Gets or sets the parent folder identity.
        /// </summary>
        public long? ParentFolderId { get; set; }

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