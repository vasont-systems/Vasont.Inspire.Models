//-------------------------------------------------------------
// <copyright file="ImportFileModel.cs" company="GlobalLink Vasont">
// Copyright (c) GlobalLink Vasont. All rights reserved.
// </copyright>
//-------------------------------------------------------------
namespace Vasont.Inspire.Models.Transfers
{
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
    }
}