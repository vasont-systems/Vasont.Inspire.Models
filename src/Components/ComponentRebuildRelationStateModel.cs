//-------------------------------------------------------------
// <copyright file="ComponentRebuildRelationStateModel.cs" company="GlobalLink Vasont">
// Copyright (c) GlobalLink Vasont. All rights reserved.
// </copyright>
//-------------------------------------------------------------
namespace Vasont.Inspire.Models.Components
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// This class contains the export state for a rebuild relation request worker within the application.
    /// </summary>
    public class ComponentRebuildRelationStateModel
    {
        /// <summary>
        /// Gets or sets the rebuild identity used for rebuild.
        /// </summary>
        public Guid RebuildId { get; set; }

        /// <summary>
        /// Gets or sets a list of components within the database that are to be rebuilt.
        /// </summary>
        public List<ComponentRebuildRelationModel> Components { get; set; } = new List<ComponentRebuildRelationModel>();

        /// <summary>
        /// Gets or sets a list of current components to rebuild.
        /// </summary>
        public List<long> ComponentIds { get; set; } = new List<long>();
    }
}