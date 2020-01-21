//-------------------------------------------------------------
// <copyright file="ComponentRelationModel.cs" company="GlobalLink Vasont">
// Copyright (c) GlobalLink Vasont. All rights reserved.
// </copyright>
//-------------------------------------------------------------
namespace Vasont.Inspire.Models.Components
{
    using System;
    using Vasont.Inspire.Models.Security;

    /// <summary>
    ///  This class model represents a component reference found within the data repository
    ///  FindComponentRelations call.
    /// </summary>
    public class ComponentRelationModel
    {
        /// <summary>
        ///  Gets or sets the component relation identity.
        /// </summary>
        public long ComponentRelationId { get; set; }

        /// <summary>
        /// Gets or sets the relation identifier.
        /// </summary>
        /// <value>
        /// The relation identifier.
        /// </value>
        public long RelationId { get; set; }

        /// <summary>
        /// Gets or sets the source component.
        /// </summary>
        /// <value>
        /// The source component.
        /// </value>
        public MinimalComponentModel SourceComponent { get; set; }

        /// <summary>
        /// Gets or sets the target component.
        /// </summary>
        /// <value>
        /// The target component.
        /// </value>
        public MinimalComponentModel TargetComponent { get; set; }

        /// <summary>
        ///  Gets or sets a value indicating whether the reference is invalid.
        /// </summary>
        public bool Invalid { get; set; }

        /// <summary>
        ///  Gets or sets the schema standard.
        /// </summary>
        public string SchemaStandard { get; set; }

        /// <summary>
        ///  Gets or sets the reference relation name.
        /// </summary>
        public string RelationName { get; set; }

        /// <summary>
        ///  Gets or sets the reference relation XML Link type name.
        /// </summary>
        public string XmlLinkTypeName { get; set; }

        /// <summary>
        ///  Gets or sets the source attribute name.
        /// </summary>
        public string SourceAttributeName { get; set; }

        /// <summary>
        ///  Gets or sets the target attribute name.
        /// </summary>
        public string TargetAttributeName { get; set; }

        /// <summary>
        ///  Gets or sets the source element name.
        /// </summary>
        public string SourceElementName { get; set; }

        /// <summary>
        ///  Gets or sets the source attribute value.
        /// </summary>
        public string SourceAttributeValue { get; set; }

        /// <summary>
        ///  Gets or sets the target element name.
        /// </summary>
        public string TargetElementName { get; set; }

        /// <summary>
        ///  Gets or sets the target attribute value.
        /// </summary>
        public string TargetAttributeValue { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this instance is target editable.
        /// </summary>
        /// <value>
        ///   <c>true</c> if this instance is target editable; otherwise, <c>false</c>.
        /// </value>
        public bool IsTargetEditable { get; set; }

        /// <summary>
        ///  Gets or sets the status of the component relation.
        /// </summary>
        public string Status { get; set; }

        /// <summary>
        ///  Gets or sets the permissions model for the component.
        /// </summary>
        public PermissionModel Permissions { get; set; }

        /// <summary>
        ///  Gets or sets the created date for the component relation.
        /// </summary>
        public DateTime CreatedDate { get; set; }

        /// <summary>
        ///  Gets or sets the label for the component relation.
        /// </summary>
        public string Label { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether an update should be performed using the target information specified.
        /// </summary>
        public bool UpdateUsingTargetInfo { get; set; }

        /// <summary>
        /// Gets or sets the source component type identity value.
        /// </summary>
        public long SourceComponentId { get; set; }

        /// <summary>
        /// Gets or sets the target component type identity value.
        /// </summary>
        public long? TargetComponentId { get; set; }

        /// <summary>
        /// Gets or sets the created by user information model.
        /// </summary>
        public MicroUserModel CreatedBy { get; set; }
    }
}