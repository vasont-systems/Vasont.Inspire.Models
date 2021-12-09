//-------------------------------------------------------------
// <copyright file="ImportRequestFileModel.cs" company="GlobalLink Vasont">
// Copyright (c) GlobalLink Vasont. All rights reserved.
// </copyright>
//-------------------------------------------------------------
namespace Vasont.Inspire.Models.Transfers
{
    /// <summary>
    /// This class contains properties and information for a file that is being imported.
    /// </summary>
    public class ImportRequestFileModel
    {
        /// <summary>
        /// Gets or sets a the file name that is being imported.
        /// </summary>
        public string FileName { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the file should be unzipped and each file within the zip file imported separately.
        /// </summary>
        public bool UnzipFile { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the file subfolder structure should be created in the application.
        /// </summary>
        public bool CreateTargetSubfolders { get; set; }
    }
}
