//-------------------------------------------------------------
// <copyright file="ExportDownloadUrlModel.cs" company="GlobalLink Vasont">
// Copyright (c) GlobalLink Vasont. All rights reserved.
// </copyright>
//-------------------------------------------------------------
namespace Vasont.Inspire.Models.Transfers
{
    using System;

    /// <summary>
    /// This class defines an export download URL details model.
    /// </summary>
    public class ExportDownloadUrlModel
    {
        /// <summary>
        /// Gets or sets the export context identity value.
        /// </summary>
        public Guid ExportContextId { get; set; }

        /// <summary>
        /// Gets or sets the export download owning user.
        /// </summary>
        public string UserName { get; set; }

        /// <summary>
        /// Gets or sets the export download owner user id.
        /// </summary>
        public long UserId { get; set; }
    }
}