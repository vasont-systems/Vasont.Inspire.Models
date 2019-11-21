//-------------------------------------------------------------
// <copyright file="ComponentAutoRepairStateModel.cs" company="GlobalLink Vasont">
// Copyright (c) GlobalLink Vasont. All rights reserved.
// </copyright>
//-------------------------------------------------------------
namespace Vasont.Inspire.Models.Components
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// This class contains the export state for an auto repair request worker within the application.
    /// </summary>
    public class ComponentAutoRepairStateModel
    {
        /// <summary>
        /// Gets or sets the repair identity used for repair.
        /// </summary>
        public Guid AutoRepairId { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether to check valid components.
        /// </summary>
        public bool RepairAll { get; set; }

        /// <summary>
        /// Gets or sets a list of components within the database that are to be repaired.
        /// </summary>
        public List<ComponentAutoRepairModel> Components { get; set; } = new List<ComponentAutoRepairModel>();

        /// <summary>
        /// Gets or sets a list of current components to repair.
        /// </summary>
        public List<long> ComponentIds { get; set; } = new List<long>();
    }
}
