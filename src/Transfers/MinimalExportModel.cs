//-------------------------------------------------------------
// <copyright file="MinimalExportModel.cs" company="GlobalLink Vasont">
// Copyright (c) GlobalLink Vasont. All rights reserved.
// </copyright>
//-------------------------------------------------------------
namespace Vasont.Inspire.Models.Transfers
{
    /// <summary>
    /// This class represents a minimal export model for use within the application.
    /// </summary>
    public class MinimalExportModel
    {
        /// <summary>
        /// Gets or sets the unique identity of the export.
        /// </summary>
        public long ExportId { get; set; }

        /// <summary>
        /// Gets or sets the name of the export.
        /// </summary>
        public string Name { get; set; }
    }
}