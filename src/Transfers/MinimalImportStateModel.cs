﻿//-------------------------------------------------------------
// <copyright file="MinimalImportStateModel.cs" company="Vasont Systems">
// Copyright (c) Vasont Systems. All rights reserved.
// </copyright>
//-------------------------------------------------------------
namespace Vasont.Inspire.Models.Transfers
{
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
