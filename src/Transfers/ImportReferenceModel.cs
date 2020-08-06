//-------------------------------------------------------------
// <copyright file="ImportReferenceModel.cs" company="GlobalLink Vasont">
// Copyright (c) GlobalLink Vasont. All rights reserved.
// </copyright>
//-------------------------------------------------------------
namespace Vasont.Inspire.Models.Transfers
{
    using System;
    using Newtonsoft.Json;
    using Vasont.Inspire.Models.Components;

    /// <summary>
    /// This class represents a reference between one component and another component.
    /// </summary>
    public class ImportReferenceModel
    {
        /// <summary>
        /// Gets or sets the identity of the target component.
        /// </summary>
        public long TargetComponentId { get; set; }

        /// <summary>
        /// Gets or sets the unique identity of the target component content record.
        /// </summary>
        public Guid TargetUniqueId { get; set; }

        /// <summary>
        /// Gets or sets the relation identity used for the relationship.
        /// </summary>
        public long RelationId { get; set; }

        /// <summary>
        /// Gets or sets the source component identity.
        /// </summary>
        public long SourceComponentId { get; set; }

        /// <summary>
        /// Gets or sets the element name of the element that points to the target component.
        /// </summary>
        public string SourceElementName { get; set; }

        /// <summary>
        /// Gets or sets the element attribute name of the element that points to the target component.
        /// </summary>
        public string SourceAttributeName { get; set; }

        /// <summary>
        /// Gets or sets the element attribute value of the element attribute that points to the target component.
        /// </summary>
        public string SourceAttributeValue { get; set; }

        /// <summary>
        /// Gets or sets the element name of the target element within the target component.
        /// </summary>
        public string TargetElementName { get; set; }

        /// <summary>
        /// Gets or sets the element attribute name of the target element within the target component.
        /// </summary>
        public string TargetAttributeName { get; set; }

        /// <summary>
        /// Gets or sets the attribute value of the target element within the target component.
        /// </summary>
        public string TargetAttributeValue { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the reference is invalid.
        /// </summary>
        public bool Invalid { get; set; }

        /// <summary>
        /// Gets or sets the user identity used for the creator of the relationship record.
        /// </summary>
        public long CreatorUserId { get; set; }

        /// <summary>
        /// Gets or sets the word count of the component relation text.
        /// </summary>
        public int WordCount { get; set; }

        /// <summary>
        /// Gets or sets the component reference of the specified type.
        /// </summary>
        [JsonIgnore]
        public IComponentReference ComponentReference { get; set; }
    }
}