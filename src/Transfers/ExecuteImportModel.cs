﻿//-------------------------------------------------------------
// <copyright file="ExecuteImportModel.cs" company="GlobalLink Vasont">
// Copyright (c) GlobalLink Vasont. All rights reserved.
// </copyright>
//-------------------------------------------------------------
namespace Vasont.Inspire.Models.Transfers
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// This class represents parameters passed into the ExecuteImport API call.
    /// </summary>
    [Obsolete("Use local DTOs", true)]
    public class ExecuteImportModel
    {
        /// <summary>
        /// Gets or sets the import identity used for the importing of the components specified.
        /// </summary>
        public long? ImportId { get; set; }

        /// <summary>
        /// Gets or sets the working folder path.
        /// </summary>
        public string WorkingFolderPath { get; set; }

        /// <summary>
        /// Gets or sets the file paths to import.
        /// </summary>
        public List<string> FilePaths { get; set; } = new List<string>();

        /// <summary>
        /// Gets or sets the target folder identity.
        /// </summary>
        public long TargetFolderId { get; set; }

        /// <summary>
        /// Gets or sets the target project folder identity.
        /// </summary>
        public long TargetProjectFolderId { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether results notifications are sent.
        /// </summary>
        public bool SendResultNotification { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the files are deleted after import.
        /// </summary>
        public bool DeleteFiles { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether sub-folders are to be auto-generated.
        /// </summary>
        public bool CreateTargetSubfolders { get; set; }

        /// <summary>
        /// Gets or sets the number of minutes the worker timeout will last.
        /// </summary>
        public int WorkerCacheLifeTimeoutMinutes { get; set; } = 14200;

        /// <summary>
        /// Gets or sets a value indicating whether import will process in the background or return when completed.
        /// </summary>
        public bool WaitForCompletion { get; set; } = false;
    }
}
