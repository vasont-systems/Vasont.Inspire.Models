//-----------------------------------------------------------------------
// <copyright file="SyncImportRequestModel.cs" company="Vasont Systems">
// Copyright (c) Vasont Systems. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------
namespace Vasont.Inspire.Models.Components.Sync
{
    /// <summary>
    /// This class represents an external component sync request to import a file.
    /// </summary>
    public class SyncImportRequestModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SyncImportRequestModel"/> class.
        /// </summary>
        public SyncImportRequestModel()
        {
            this.SendNotification = true;
        }
        
        /// <summary>
        /// Gets or sets the inspire file name.
        /// </summary>
        public string InspireFileName { get; set; }

        /// <summary>
        /// Gets or sets the unique identity of the inspire user that will be assigned to component updates during the import process.
        /// </summary>
        public long InspireUserId { get; set; }

        /// <summary>
        /// Gets or sets the unique identity of the folder that new components will be imported into.
        /// </summary>
        public long TargetFolderId { get; set; }

        /// <summary>
        /// Gets or sets the unique identity associated with the external component.
        /// </summary>
        public long ExternalComponentId { get; set; }

        /// <summary>
        /// Gets or sets the file name of the external component.
        /// </summary>
        public string ExternalFileName { get; set; }
        
        /// <summary>
        /// Gets or sets a value indicating whether [send notification].
        /// </summary>
        public bool SendNotification { get; set; }
    }
}
