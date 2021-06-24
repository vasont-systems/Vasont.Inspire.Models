//----------------------------------------------------------------------
// <copyright file="TranslationIntegrationModel.cs" company="GlobalLink Vasont">
// Copyright (c) GlobalLink Vasont. All rights reserved.
// </copyright>
//----------------------------------------------------------------------
namespace Vasont.Inspire.Models.Translations
{
    using System;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using Vasont.Inspire.Models.Security;

    /// <summary>
    /// This enumeration represents the Translation Integration Methods used in the application.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum IntegrationMethodType
    {
        /// <summary>
        /// The unknown type
        /// </summary>
        Unknown = -1,

        /// <summary>
        /// The manual
        /// </summary>
        Manual = 0,

        /// <summary>
        /// The transport
        /// </summary>
        Transport = 1,

        /// <summary>
        /// The global link connect
        /// </summary>
        GlobalLinkConnect = 2,

        /// <summary>
        /// The global link connect cloud
        /// </summary>
        GlobalLinkConnectCloud = 3,

        /// <summary>
        /// The global link rest API
        /// </summary>
        GlobalLinkRestApi = 4
    }

    /// <summary>
    /// This class is a model representation of a translation integration within the application.
    /// </summary>
    public class TranslationIntegrationModel
    {
        /// <summary>
        /// Gets or sets the translation integration identifier.
        /// </summary>
        /// <value>
        /// The translation integration identifier.
        /// </value>
        public long TranslationIntegrationId { get; set; }

        /// <summary>
        /// Gets or sets the display name.
        /// </summary>
        /// <value>
        /// The display name.
        /// </value>
        public string DisplayName { get; set; }

        /// <summary>
        /// Gets or sets the description.
        /// </summary>
        /// <value>
        /// The description.
        /// </value>
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets the integration method.
        /// </summary>
        /// <value>
        /// The integration method.
        /// </value>
        public IntegrationMethodType IntegrationMethod { get; set; }

        /// <summary>
        /// Gets or sets the created date.
        /// </summary>
        /// <value>
        /// The created date.
        /// </value>
        public DateTime CreatedDate { get; set; }

        /// <summary>
        /// Gets or sets the created by.
        /// </summary>
        /// <value>
        /// The created by.
        /// </value>
        public long CreatedBy { get; set; }

        /// <summary>
        /// Gets or sets the created by user.
        /// </summary>
        /// <value>
        /// The created by user.
        /// </value>
        public MicroUserModel CreatedByUser { get; set; }

        /// <summary>
        /// Gets or sets the last updated date.
        /// </summary>
        /// <value>
        /// The last updated date.
        /// </value>
        public DateTime? LastUpdatedDate { get; set; }

        /// <summary>
        /// Gets or sets the last updated by.
        /// </summary>
        /// <value>
        /// The last updated by.
        /// </value>
        public long? LastUpdatedBy { get; set; }

        /// <summary>
        /// Gets or sets the last updated by user.
        /// </summary>
        /// <value>
        /// The last updated by user.
        /// </value>
        public MicroUserModel LastUpdatedByUser { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this <see cref="TranslationIntegrationModel"/> is active.
        /// </summary>
        /// <value>
        ///   <c>true</c> if active; otherwise, <c>false</c>.
        /// </value>
        public bool Active { get; set; }

        /// <summary>
        /// Gets or sets the configuration json.
        /// </summary>
        /// <value>
        /// The configuration json.
        /// </value>
        public string ConfigurationJson { get; set; }
    }
}
