//-------------------------------------------------------------
// <copyright file="ExportSelectionModel.cs" company="Vasont Systems">
// Copyright (c) Vasont Systems. All rights reserved.
// </copyright>
//-------------------------------------------------------------
namespace Vasont.Inspire.Models.Transfers
{
    using System.Collections.Generic;

    /// <summary>
    /// This class represents an export selection model for use within the application.
    /// </summary>
    public class ExportSelectionModel
    {
        /// <summary>
        /// Gets or sets the list of minimal export models.
        /// </summary>
        public List<MinimalExportModel> ExportModels { get; set; } = new List<MinimalExportModel>();

        /// <summary>
        /// Gets or sets a value indicating whether or not the system has defined Profile Attributes;
        /// </summary>
        public bool HasProfiled { get; set; }
    }
}