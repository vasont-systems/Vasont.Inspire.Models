//-------------------------------------------------------------
// <copyright file="ExecuteImportModel.cs" company="GlobalLink Vasont">
// Copyright (c) GlobalLink Vasont. All rights reserved.
// </copyright>
//-------------------------------------------------------------
namespace Vasont.Inspire.Models.Transfers
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    /// <summary>
    /// This class represents parameters passed into the ExecuteImport API call.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public class ExecuteImportModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ExecuteImportModel"/> class.
        /// </summary>
        public ExecuteImportModel()
        {
            this.WorkerCacheLifeTimeoutMinutes = 14200;
        }

        /// <summary>
        /// Gets or sets the working folder path.
        /// </summary>
        public string WorkingFolderPath { get; set; }

        /// <summary>
        /// Gets or sets the file paths to import.
        /// </summary>
        public List<string> FilePaths { get; set; }

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
        public int WorkerCacheLifeTimeoutMinutes { get; set; }
    }
}
