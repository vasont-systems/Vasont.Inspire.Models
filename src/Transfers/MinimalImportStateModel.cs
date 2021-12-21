//-------------------------------------------------------------
// <copyright file="MinimalImportStateModel.cs" company="GlobalLink Vasont">
// Copyright (c) GlobalLink Vasont. All rights reserved.
// </copyright>
//-------------------------------------------------------------
namespace Vasont.Inspire.Models.Transfers
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// This class contains the absolute maximum information we can send the client at this time.
    /// </summary>
    public class MinimalImportStateModel
    {
        /// <summary>
        /// Gets or sets the target project folder where imported components shall be assigned.
        /// </summary>
        public long TargetProjectFolderId { get; set; }

        /// <summary>
        /// Gets or sets the original folder for import.
        /// </summary>
        public long TargetFolderId { get; set; }

        /// <summary>
        /// Gets or sets a list of subfolders that were created.
        /// </summary>
        public List<Tuple<string, string, long>> Subfolders { get; set; } = new List<Tuple<string, string, long>>();

        /// <summary>
        /// Gets or sets the external system used for the sync update.
        /// </summary>
        public long SyncExternalSystemId { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the sync table shall be updated once the import has been processed.
        /// </summary>
        public bool SyncUpdate { get; set; }

        /// <summary>
        /// Gets or sets a list of components to be imported within the import process.
        /// </summary>
        public List<MinimalImportComponentModel> Components { get; set; } = new List<MinimalImportComponentModel>();
    }
}