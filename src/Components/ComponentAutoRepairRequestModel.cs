//-------------------------------------------------------------
// <copyright file="ComponentAutoRepairRequestModel.cs" company="GlobalLink Vasont">
// Copyright (c) GlobalLink Vasont. All rights reserved.
// </copyright>
//-------------------------------------------------------------
namespace Vasont.Inspire.Models.Components
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// This class contains properties and information to request the system to start an auto repair process.
    /// </summary>
    public class ComponentAutoRepairRequestModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ComponentAutoRepairRequestModel"/> class.
        /// </summary>
        public ComponentAutoRepairRequestModel()
        {
            this.ComponentIdsToRepair = new List<long>();
            this.SendNotification = true;
            this.WorkerCacheLifeTimeoutMinutes = 14200;
            this.RepairAll = false;
        }

        /// <summary>
        /// Gets or sets the repair identity used for repair.
        /// </summary>
        public Guid AutoRepairId { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether to check valid components.
        /// </summary>
        public bool RepairAll { get; set; }

        /// <summary>
        /// Gets or sets a list of component identities to repair.
        /// </summary>
        public List<long> ComponentIdsToRepair { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether [send notification].
        /// </summary>
        public bool SendNotification { get; set; }

        /// <summary>
        /// Gets or sets the number of minutes the worker timeout will last.
        /// </summary>
        public int WorkerCacheLifeTimeoutMinutes { get; set; }
    }
}
