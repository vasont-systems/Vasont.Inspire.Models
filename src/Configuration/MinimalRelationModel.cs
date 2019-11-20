//-----------------------------------------------------------------------
// <copyright file="MinimalRelationModel.cs" company="Vasont Systems">
// Copyright (c) Vasont Systems. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace Vasont.Inspire.Models.Configuration
{
    /// <summary>
    /// This class represents a minimal relation model within the system.
    /// </summary>
    public class MinimalRelationModel
    {
        /// <summary>
        /// Gets or sets the identity of the relation.
        /// </summary>
        public long RelationId { get; set; }

        /// <summary>
        /// Gets or sets the name of the relation.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the description of the relation.
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the relation is currently active.
        /// </summary>
        public bool Active { get; set; }
    }
}