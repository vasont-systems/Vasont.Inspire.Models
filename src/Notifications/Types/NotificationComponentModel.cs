//-----------------------------------------------------------------------
// <copyright file="NotificationComponentModel.cs" company="GlobalLink Vasont">
// Copyright (c) GlobalLink Vasont. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------
namespace Vasont.Inspire.Models.Notifications.Types
{
    using System;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using Vasont.Inspire.Models.Components;

    /// <summary>
    /// Contains an enumerated list of available component action notifications.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum NotificationComponentAction
    {
        /// <summary>
        /// The specified component was added to the specified parent folder.
        /// </summary>
        Added,

        /// <summary>
        /// The specified component was updated.
        /// </summary>
        Updated,

        /// <summary>
        /// The specified component was removed.
        /// </summary>
        Removed,

        /// <summary>
        /// The specified component was moved to the specified parent folder.
        /// </summary>
        Moved
    }

    /// <summary>
    /// This class represents a folder notification message.
    /// </summary>
    public class NotificationComponentModel : NotificationModelBase
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
        public NotificationComponentAction Action { get; set; }

        /// <summary>
        /// Gets or sets the specified folder name.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the specified folder path.
        /// </summary>
        public string Path { get; set; }

        /// <summary>
        /// Gets or sets the component model information about the component that was changed.
        /// </summary>
        public MicroComponentModel Component { get; set; }
    }
}