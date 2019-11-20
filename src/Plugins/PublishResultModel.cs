//------------------------------------------------------------------
// <copyright file="PublishResultModel.cs" company="Vasont Systems">
// Copyright (c) Vasont Systems. All rights reserved.
// </copyright>
//------------------------------------------------------------------
namespace Vasont.Inspire.Models.Plugins
{
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
    }
}
