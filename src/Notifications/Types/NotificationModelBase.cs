//-----------------------------------------------------------------------
// <copyright file="NotificationModelBase.cs" company="GlobalLink Vasont">
// Copyright (c) GlobalLink Vasont. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------
namespace Vasont.Inspire.Models.Notifications.Types
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;

    /// <summary>
    /// This abstract class contains properties that are to be applied to all notification model classes.
    /// </summary>
    [Obsolete("Use local DTOs", false)]
    public abstract class NotificationModelBase
    {
        /// <summary>
        /// Gets or sets the metadata string and deserializes JSON formatted metadata into the Metadata dictionary.
        /// </summary>
        [JsonIgnore]
        public string MetadataModel
        {
            get
            {
                return JsonConvert.SerializeObject(this.Metadata);
            }

            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    this.Metadata = JsonConvert.DeserializeObject<Dictionary<string, string>>(value);
                }
            }
        }

        /// <summary>
        /// Gets or sets an optional set of metadata for the notification message.
        /// </summary>
        public Dictionary<string, string> Metadata { get; set; } = new Dictionary<string, string>();
    }
}