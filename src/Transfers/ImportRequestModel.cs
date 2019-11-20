﻿//-------------------------------------------------------------
// <copyright file="ImportRequestModel.cs" company="Vasont Systems">
// Copyright (c) Vasont Systems. All rights reserved.
// </copyright>
//-------------------------------------------------------------
namespace Vasont.Inspire.Models.Transfers
{
    using System.Collections.Generic;
    using Microsoft.AspNetCore.Http;

    /// <summary>
    /// This class contains properties and information to request the system to start an import process.
    /// </summary>
    public class ImportRequestModel
    {
        /// <summary>
        /// Gets or sets the identity of the folder where new components created by the import process will be stored.
        /// </summary>
        public long FolderId { get; set; }

        /// <summary>
        /// Gets or sets the identity of the project folder where new components created by the import process will be stored.
        /// </summary>
        public long ProjectFolderId { get; set; }

        /// <summary>
        /// Gets or sets a list of <see cref="ImportRequestFileModel"/> that defines files to be imported.
        /// </summary>
        public List<ImportRequestFileModel> ImportFiles { get; set; } = new List<ImportRequestFileModel>();

        /// <summary>
        /// Gets or sets a list of form file objects.
        /// </summary>
        public List<IFormFile> Files { get; set; } = new List<IFormFile>();
    }
}
