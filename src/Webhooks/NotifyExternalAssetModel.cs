//---------------------------------------------------------------------------
// <copyright file="NotifyExternalAssetModel.cs" company="GlobalLink Vasont">
// Copyright (c) GlobalLink Vasont. All rights reserved.
// </copyright>
//---------------------------------------------------------------------------
namespace Vasont.Inspire.Models.Webhooks
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    /// <summary>
    /// This class contains the model used for an external asset modification notification.
    /// Notification is set out for all users following components that reference external asset.
    /// Notification is set out for project owners for projects of components that reference external asset.
    /// </summary>

    [Obsolete("Vasont.Inspire.Models.Webhooks.NotifyExternalAssetModel is deprecated. Please use Vasont.Inspire.Shared.Models/Webhook.NotifyExternalAssetDto instead.")]
    public class NotifyExternalAssetModel
    {
        /// <summary>
        /// Gets or sets the identity of the request.
        /// </summary>
        public Guid RequestId { get; set; }

        /// <summary>
        ///  Gets or sets the event.
        /// </summary>
        /// <value>The event.</value>
        [StringLength(1)]
        [Column(TypeName = "char(1)")]
        public string Event { get; set; }

        /// <summary>
        /// Gets or sets the url to the external asset provider.
        /// </summary>
        /// <value>The asset url.</value>
        public string AssetUrl { get; set; }

        /// <summary>
        ///  Gets or sets the optional asset identifier.
        /// </summary>
        /// <value>The asset identifier.</value>
        public string AssetId { get; set; }

        /// <summary>
        ///  Gets or sets the optional asset name.
        /// </summary>
        /// <value>The asset name.</value>
        public string AssetName { get; set; }

        /// <summary>
        ///  Gets or sets the asset metadata.
        /// </summary>
        /// <value>The asset metadata.</value>
        public string Metadata { get; set; }
    }
}