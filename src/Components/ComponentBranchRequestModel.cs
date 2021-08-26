//-------------------------------------------------------------
// <copyright file="ComponentBranchRequestModel.cs" company="GlobalLink Vasont">
// Copyright (c) GlobalLink Vasont. All rights reserved.
// </copyright>
//-------------------------------------------------------------
namespace Vasont.Inspire.Models.Components
{
    using System.Collections.Generic;

    /// <summary>
    /// This class contains properties and information to request the system to create a component branch.
    /// </summary>
    public class ComponentBranchRequestModel
    {
        /// <summary>
        /// Gets or sets the new branch name to be used.
        /// </summary>
        public string BranchName { get; set; }

        /// <summary>
        /// Gets or sets the identity of the root component of the branch.
        /// </summary>
        public long SourceComponentId { get; set; }

        /// <summary>
        /// Gets or sets the identity of the folder of the new branch.
        /// </summary>
        public long TargetFolderId { get; set; }

        /// <summary>
        /// Gets or sets the identities of the components related to the source component of the new branch.
        /// </summary>
        public List<long> ChildComponentIds { get; set; } = new List<long>();

        /// <summary>
        /// Gets or sets the identity of the project to be added to.
        /// </summary>
        public long ProjectId { get; set; }

        /// <summary>
        /// Gets or sets the identity of the project folder to be added to.
        /// </summary>
        public long ProjectFolderId { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether notifications are sent after branch.
        /// </summary>
        public bool SendNotification { get; set; } = true;

        /// <summary>
        /// Gets or sets a value indicating whether the request contains ids for referenced components.
        /// </summary>
        public bool IncludesReferencedComponents { get; set; } = true;

        /// <summary>
        /// Gets or sets the identity of the export configuration.
        /// </summary>
        public long ExportId { get; set; } = 0;

        /// <summary>
        /// Gets or sets the number of minutes the worker timeout will last.
        /// </summary>
        public int WorkerCacheLifeTimeoutMinutes { get; set; } = 14200;
    }
}