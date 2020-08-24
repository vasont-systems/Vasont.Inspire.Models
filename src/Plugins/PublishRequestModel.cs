//-------------------------------------------------------------------
// <copyright file="PublishRequestModel.cs" company="GlobalLink Vasont">
// Copyright (c) GlobalLink Vasont. All rights reserved.
// </copyright>
//-------------------------------------------------------------------
namespace Vasont.Inspire.Models.Plugins
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using Vasont.Inspire.Models.Security;

    /// <summary>
    /// Contains an enumerated list of publish types.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum PublishType
    {
        /// <summary>
        /// Contains a value that indicates publishing a PDF.
        /// </summary>
        Pdf,

        /// <summary>
        /// Contains a value that indicates publishing to HTML.
        /// </summary>
        Html,

        /// <summary>
        /// Contains a value that indicates publishing to the Zoomin web site.
        /// </summary>
        Zoomin,

        /// <summary>
        /// Contains a value that indicates publishing to DocBook.
        /// </summary>
        DocBook,

        /// <summary>
        /// Contains a value that indicates publishing to AntennaHouse PDF.
        /// </summary>
        AntennaHousePdf
    }

    /// <summary>
    /// This class represents a Publishing Request model.
    /// </summary>
    public class PublishRequestModel
    {
        /// <summary>
        /// Gets or sets the identity of the identity of the root component to be published.
        /// </summary>
        public long RootComponentId { get; set; }

        /// <summary>
        /// Gets or sets the root file name value.
        /// </summary>
        public string RootFileName { get; set; }

        /// <summary>
        /// Gets or sets a minimal model for the user.
        /// </summary>
        public MinimalUserModel User { get; set; }

        /// <summary>
        /// Gets or sets the domainKey the User is logged into.
        /// </summary>
        public string DomainKey { get; set; }

        /// <summary>
        /// Gets or sets the publish type.
        /// </summary>
        public PublishType Type { get; set; }

        /// <summary>
        /// Gets or sets the DITA Toolkit Version.
        /// </summary>
        public string DitaToolkitVersion { get; set; }

        /// <summary>
        /// Gets or sets the publish configuration name.
        /// </summary>
        public string PublishConfigName { get; set; }

        /// <summary>
        /// Gets or sets the webhook url.
        /// </summary>
        public Uri WebhookUrl { get; set; }

        /// <summary>
        /// Gets or sets values containing the publish parameters.
        /// </summary>
        public Dictionary<string, string> PublishParameters { get; set; } = new Dictionary<string, string>();
    }
}
