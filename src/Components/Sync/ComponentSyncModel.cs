//-----------------------------------------------------------------------
// <copyright file="ComponentSyncModel.cs" company="GlobalLink Vasont">
// Copyright (c) GlobalLink Vasont. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------
namespace Vasont.Inspire.Models.Components.Sync
{
    using System;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    /// <summary>
    /// Contains an enumerated list of component sync statuses.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum ComponentSyncStatus
    {
        /// <summary>
        /// A sync for the component is required.
        /// </summary>
        Required,

        /// <summary>
        /// The component is currently in sync.
        /// </summary>
        Synced,

        /// <summary>
        /// A sync for the component is pending.
        /// </summary>
        Pending,
    }

    /// <summary>
    /// This class represents a component sync model used for synchronization with external systems.
    /// </summary>
    public class ComponentSyncModel
    {
        /// <summary>
        /// Gets or sets the unique identity of the component sync record.
        /// </summary>
        public long ComponentSyncId { get; set; }

        /// <summary>
        /// Gets or sets the identity of the external system.
        /// </summary>
        public long ExternalSystemId { get; set; }

        /// <summary>
        /// Gets or sets the identity of the inspire component.
        /// </summary>
        public long ComponentId { get; set; }

        /// <summary>
        /// Gets or sets the updated date.
        /// </summary>
        public DateTime UpdatedDate { get; set; }

        /// <summary>
        /// Gets or sets the unique identity associated with the external component.
        /// </summary>
        public long? ExternalComponentId { get; set; }

        /// <summary>
        /// Gets or sets the file name of the external component.
        /// </summary>
        public string ExternalFileName { get; set; }

        /// <summary>
        /// Gets or sets the last date time when the record was synced.
        /// </summary>
        public DateTime? SyncDate { get; set; }

        /// <summary>
        /// Gets or sets the status of the component sync record.
        /// </summary>
        public ComponentSyncStatus SyncStatus { get; set; }

        /// <summary>
        /// Gets or sets the file name of the inspire component.
        /// </summary>
        public string FileName { get; set; }

        /// <summary>
        /// Gets or sets the name of the inspire component.
        /// </summary>
        public string ComponentName { get; set; }

        /// <summary>
        /// Gets or sets the identity of the user who last updated the inspire component.
        /// </summary>
        public long? UpdatedByUserId { get; set; }

        /// <summary>
        /// Gets or sets the name of the user who last updated the inspire component.
        /// </summary>
        public string UpdatedByUserName { get; set; }

        /// <summary>
        /// Gets or sets the component type identifier.
        /// </summary>
        public long ComponentTypeId { get; set; }

        /// <summary>
        /// Gets or sets the name of the locked by user.
        /// </summary>
        public string LockedByUserName { get; set; }

        /// <summary>
        /// Gets or sets the folder identifier.
        /// </summary>
        public long FolderId { get; set; }

        /// <summary>
        /// Gets or sets the name of the folder.
        /// </summary>
        public string FolderName { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether [updated successfully].
        /// </summary>
        public bool UpdatedSuccessfully { get; set; }
        
        /// <summary>
        /// This method returns the object as a JSON string representation.
        /// </summary>
        /// <returns>Returns the JSON string version of the model.</returns>
        public override string ToString()
        {
            return JsonConvert.SerializeObject(this);
        }
    }
}
