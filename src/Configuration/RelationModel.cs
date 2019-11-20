﻿//-----------------------------------------------------------------------
// <copyright file="RelationModel.cs" company="Vasont Systems">
// Copyright (c) Vasont Systems. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace Vasont.Inspire.Models.Configuration
{
    /// <summary>
    /// Contains an enumerated list of relation key names.
    /// </summary>
    public enum RelationKeyName
    {
        /// <summary>
        /// Identifies a relation created from a branch.
        /// </summary>
        Branch,

        /// <summary>
        /// Identifies a relation created from a translation.
        /// </summary>
        Translation
    }

    /// <summary>
    /// This class represents a relation model within the system.
    /// </summary>
    public class RelationModel
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
        /// Gets or sets the XML link type model.
        /// </summary>
        public XmlLinkTypeModel XmlLinkType { get; set; } = new XmlLinkTypeModel();

        /// <summary>
        /// Gets or sets a value indicating whether the relation is currently active.
        /// </summary>
        public bool Active { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this is a system relation.
        /// </summary>
        public bool SystemRelation { get; set; }

        /// <summary>
        /// Gets or sets the key name of the relation.
        /// </summary>
        public RelationKeyName KeyName { get; set; }
    }
}