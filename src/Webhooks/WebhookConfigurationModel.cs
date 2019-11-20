﻿//-------------------------------------------------------------------------
// <copyright file="WebhookConfigurationModel.cs" company="Vasont Systems">
// Copyright (c) Vasont Systems. All rights reserved.
// </copyright>
//-------------------------------------------------------------------------
namespace Vasont.Inspire.Models.Webhooks
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    /// <summary>
    /// Contains an enumerated list of webhook names.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum WebhookConfigurationNameType
    {
        /// <summary>
        /// The Zoomin Feedback webhook.
        /// </summary>
        ZoominFeedback,

        /// <summary>
        /// The Zoomin new content webhook.
        /// </summary>
        ZoominNewContent
    }

    /// <summary>
    /// Contains an enumerated list of webhook configuration value types.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum WebhookConfigurationValueType
    {
        /// <summary>
        /// Contains the value that indicates the property is related to a project.
        /// </summary>
        Project,

        /// <summary>
        /// Contains the value that indicates the property is related to a project activity.
        /// </summary>
        ProjectActivity,

        /// <summary>
        /// Contains the value that indicates the property is related to a component type.
        /// </summary>
        ComponentType,

        /// <summary>
        /// Contains the value that indicates the property is related to a folder.
        /// </summary>
        Folder,

        /// <summary>
        /// Contains the value that indicates the property is related to a text value.
        /// </summary>
        Text,

        /// <summary>
        /// Contains the value that indicates the property is related to a numeric value.
        /// </summary>
        Number,

        /// <summary>
        /// Contains the value that indicates the property is a secret string.
        /// </summary>
        Secret
    }

    /// <summary>
    /// This class represents a webhook configuration used with webhook API calls.
    /// </summary>
    public class WebhookConfigurationModel
    {
        /// <summary>
        /// Gets or sets the webhook name.
        /// </summary>
        public WebhookConfigurationNameType Name { get; set; }

        /// <summary>
        /// Gets or sets the property name.
        /// </summary>
        public string PropertyName { get; set; }

        /// <summary>
        /// Gets or sets the property value.
        /// </summary>
        public string PropertyValue { get; set; }

        /// <summary>
        /// Gets or sets the value type.
        /// </summary>
        public WebhookConfigurationValueType ValueType { get; set; }
    }
}
