//------------------------------------------------------------------
// <copyright file="PublishResultModel.cs" company="GlobalLink Vasont">
// Copyright (c) GlobalLink Vasont. All rights reserved.
// </copyright>
//------------------------------------------------------------------
namespace Vasont.Inspire.Models.Plugins
{
    using System.Collections.Generic;

    /// <summary>
    /// This class represents a Publishing Request.
    /// </summary>
    public class PublishResultModel
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
        /// Gets or sets the root component name value.
        /// </summary>
        public string RootComponentName { get; set; }

        /// <summary>
        /// Gets or sets the email address of the user who requested the publish.
        /// </summary>
        public string UserEmail { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the publish process was successfully initiated.
        /// </summary>
        public bool PublishInitiated { get; set; }

        /// <summary>
        /// Gets or sets a value containing errors that occurred when attempting to initiate publishing.
        /// </summary>
        public string PublishInitiateErrors { get; set; }

        /// <summary>
        /// Gets or sets a value containing the full path of the published file.
        /// </summary>
        public string ResultFilePath { get; set; }

        /// <summary>
        /// Gets or sets the publish type.
        /// </summary>
        public PublishType Type { get; set; }

        /// <summary>
        /// Gets or sets the publish configuration name.
        /// </summary>
        public string PublishConfigName { get; set; }

        /// <summary>
        /// Gets or sets the optional identity of the publish profile associated with the result.
        /// </summary>
        public long PublishProfileId { get; set; }

        /// <summary>
        /// Gets or sets a list of strings containing any warning messages for the published file.
        /// </summary>
        public List<string> WarningMessages { get; set; } = new List<string>();
    }
}
