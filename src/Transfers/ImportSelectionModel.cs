//-------------------------------------------------------------
// <copyright file="ImportSelectionModel.cs" company="GlobalLink Vasont">
// Copyright (c) GlobalLink Vasont. All rights reserved.
// </copyright>
//-------------------------------------------------------------
namespace Vasont.Inspire.Models.Transfers
{
    using System.Collections.Generic;

    /// <summary>
    /// This class represents an import selection model for use within the application.
    /// </summary>
    public class ImportSelectionModel
    {
        /// <summary>
        /// Gets or sets the list of minimal import models.
        /// </summary>
        public List<MinimalImportModel> ImportModels { get; set; } = new List<MinimalImportModel>();
    }
}