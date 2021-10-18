//-------------------------------------------------------------
// <copyright file="ExternalAssetModel.cs" company="GlobalLink Vasont">
// Copyright (c) GlobalLink Vasont. All rights reserved.
// </copyright>
//-------------------------------------------------------------
namespace Vasont.Inspire.Models.Components
{
    using System;
    using Vasont.Inspire.Models.Security;

    /// <summary>
    ///  This class model represents a component reference with an external asset.
    /// </summary>
    public class ExternalAssetModel
    {
        /// <summary>
        ///  Gets or sets the component external asset identifier.
        /// </summary>
        /// <value>The component external asset identifier.</value>
        public long ExternalAssetId { get; set; }

        /// <summary>
        ///  Gets or sets the action.
        /// </summary>
        /// <value>The action.</value>
        public string Action { get; set; }

        /// <summary>
        /// Gets or sets the source component type identity value.
        /// </summary>
        public long SourceComponentId { get; set; }

        /// <summary>
        /// Gets or sets the source component.
        /// </summary>
        /// <value>
        /// The source component.
        /// </value>
        public MinimalComponentModel SourceComponent { get; set; }

        /// <summary>
        ///  Gets or sets the url to the external asset provider.
        /// </summary>
        /// <value>The target url.</value>
        public string TargetUrl { get; set; }

        /// <summary>
        ///  Gets or sets the target external asset identifier.
        /// </summary>
        /// <value>The target external asset identifier.</value>
        public long TargetId { get; set; }

        /// <summary>
        ///  Gets or sets the target name.
        /// </summary>
        /// <value>The target name.</value>
        public string TargetName { get; set; }

        /// <summary>
        ///  Gets or sets the target metadata.
        /// </summary>
        /// <value>The target metadata.</value>
        public string Metadata { get; set; }

        /// <summary>
        ///  Gets or sets the target notification date.
        /// </summary>
        /// <value>The target metadata.</value>
        public DateTime NotificationDate { get; set; }

        /// <summary>
        ///  Gets or sets a value indicating whether the external asset exists.
        /// </summary>
        /// <value>The target state.</value>
        public bool IsValid { get; set; } = false;
    }
}