//-------------------------------------------------------------
// <copyright file="ComponentRebuildRelationRequestModel.cs" company="GlobalLink Vasont">
// Copyright (c) GlobalLink Vasont. All rights reserved.
// </copyright>
//-------------------------------------------------------------
namespace Vasont.Inspire.Models.Components
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// This class contains properties and information to request the system to start a rebuild relation process.
    /// </summary>
    [Obsolete("Use local DTOs", true)]
    public class ComponentRebuildRelationRequestModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ComponentRebuildRelationRequestModel" /> class.
        /// </summary>
        public ComponentRebuildRelationRequestModel()
        {
            this.ComponentIdsToRebuild = new List<long>();
            this.SendNotification = true;
            this.WorkerCacheLifeTimeoutMinutes = 14200;
        }

        /// <summary>
        /// Gets or sets the rebuild identity used for rebuild.
        /// </summary>
        public Guid RebuildId { get; set; }

        /// <summary>
        /// Gets or sets a list of component identities to rebuild.
        /// </summary>
        public List<long> ComponentIdsToRebuild { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether notifications are sent after rebuild.
        /// </summary>
        public bool SendNotification { get; set; }

        /// <summary>
        /// Gets or sets the number of minutes the worker timeout will last.
        /// </summary>
        public int WorkerCacheLifeTimeoutMinutes { get; set; }
    }
}
