//-------------------------------------------------------------
// <copyright file="MinimalExportStateModel.cs" company="Vasont Systems">
// Copyright (c) Vasont Systems. All rights reserved.
// </copyright>
//-------------------------------------------------------------
namespace Vasont.Inspire.Models.Transfers
{
    using System.Collections.Generic;

    /// <summary>
    /// This class contains the absolute minimum properties needed to send to a client.
    /// </summary>
    public class MinimalExportStateModel
    {
        /// <summary>
        /// Gets or sets the download URL to retrieve the export.
        /// </summary>
        public string DownloadUrl { get; set; }

        /// <summary>
        /// Gets or sets a list of minimal export component information models.
        /// </summary>
        public List<MinimalExportComponentModel> Components { get; set; } = new List<MinimalExportComponentModel>();
    }
}
