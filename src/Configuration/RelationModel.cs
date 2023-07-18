//-----------------------------------------------------------------------
// <copyright file="RelationModel.cs" company="GlobalLink Vasont">
// Copyright (c) GlobalLink Vasont. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------
namespace Vasont.Inspire.Models.Configuration
{
    using System;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    /// <summary>
    /// Contains an enumerated list of relation key names.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    [Obsolete("Use local Enums", false)]
    public enum RelationKeyName
    {
        /// <summary>
        /// No Key Name
        /// </summary>
        None,

        /// <summary>
        /// Identifies a relation created from a branch.
        /// </summary>
        Branch,

        /// <summary>
        /// Identifies a relation created from a translation.
        /// </summary>
        Translation,

        /// <summary>
        /// Identifies a relation created from a Docbook fileref.
        /// </summary>
        Fileref,

        /// <summary>
        /// Identifies a relation created from a Docbook href.
        /// </summary>
        DocbookHref,

        /// <summary>
        /// Identifies a relation created from a Docbook linkend.
        /// </summary>
        Linkend,

        /// <summary>
        /// Identifies a relation created from a Docbook xpointer.
        /// </summary>
        Xpointer,

        /// <summary>
        /// Identifies a relation created from an Attachment.
        /// </summary>
        Attachment
    }

    /// <summary>
    /// This class represents a relation model within the system.
    /// </summary>
    [Obsolete("Use local DTOs", false)]
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