//-------------------------------------------------------------
// <copyright file="ImportRequestModel.cs" company="GlobalLink Vasont">
// Copyright (c) GlobalLink Vasont. All rights reserved.
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
        /// Gets or sets a value indicating whether import will process in the background or return when completed.
        /// </summary>
        public bool WaitForCompletion { get; set; } = false;

        /// <summary>
        /// Gets or sets a value indicating whether notifications are sent.
        /// </summary>
        public bool SendNotification { get; set; } = true;

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
