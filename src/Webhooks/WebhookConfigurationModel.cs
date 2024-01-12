//-------------------------------------------------------------------------
// <copyright file="WebhookConfigurationModel.cs" company="GlobalLink Vasont">
// Copyright (c) GlobalLink Vasont. All rights reserved.
// </copyright>
//-------------------------------------------------------------------------
namespace Vasont.Inspire.Models.Webhooks
{
    using System;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    /// <summary>
    /// Contains an enumerated list of webhook names.
    /// </summary>
    [Obsolete("Vasont.Inspire.Models.Webhooks.WebhookConfigurationNameType is deprecated. Please use Vasont.Inspire.Shared.Enums.WebhookConfigurationNameType instead.")]
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
        ZoominNewContent,

        /// <summary>
        /// The Publish result webhook.
        /// </summary>
        PublishResult,

        /// <summary>
        /// The project director notification webook.
        /// </summary>
        ProjectDirectorNotification,

        /// <summary>
        /// The oxygen session webhook.
        /// </summary>
        OxygenSession,

        /// <summary>
        /// The notify external asset webhook.
        /// </summary>
        NotifyExternalAsset,

        /// <summary>
        /// The Slack webhook.
        /// </summary>
        Slack,

        /// <summary>
        /// The ReportSession webhook.
        /// </summary>ss
        ReportSession,

        /// <summary>
        /// The SFTP translation notification.
        /// </summary>
        SftpTranslationNotification,
    }

    /// <summary>
    /// Contains an enumerated list of webhook configuration value types.
    /// </summary>
    [Obsolete("Vasont.Inspire.Models.Webhooks.WebhookConfigurationValueType is deprecated. Please use Vasont.Inspire.Shared.Enums.WebhookConfigurationValueType instead.")]
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
    [Obsolete("Vasont.Inspire.Models.Webhooks.WebhookConfigurationModel is deprecated. Please use Vasont.Inspire.Shared.Models/Webhook.WebhookConfigurationDto instead.")]
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
