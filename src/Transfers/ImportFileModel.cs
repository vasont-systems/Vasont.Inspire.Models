//-------------------------------------------------------------
// <copyright file="ImportFileModel.cs" company="Vasont Systems">
// Copyright (c) Vasont Systems. All rights reserved.
// </copyright>
//-------------------------------------------------------------
namespace Vasont.Inspire.Models.Transfers
{
    using Vasont.Inspire.Models.Components.Sync;

    /// <summary>
    /// This class contains import information about the file that is to be imported.
    /// </summary>
    public class ImportFileModel
    {
        /// <summary>
        /// Gets or sets the full path to the local file to be imported.
        /// </summary>
        public string LocalFilePath { get; set; }

        /// <summary>
        /// Gets or sets the user identity that shall be used to associate with the file during creation or update.
        /// </summary>
        public long ImportUserId { get; set; }

        /// <summary>
        /// Gets or sets the folder identity where the component is expected to be stored within the application.
        /// </summary>
        public long TargetFolderId { get; set; }

        /// <summary>
        /// Gets or sets the sync import request model associated with the import process.
        /// </summary>
        public SyncImportRequestModel SyncRequestModel { get; set; }
    }
}