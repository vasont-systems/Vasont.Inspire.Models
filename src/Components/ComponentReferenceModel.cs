//-------------------------------------------------------------
// <copyright file="ComponentReferenceModel.cs" company="GlobalLink Vasont">
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
    public class ComponentReferenceModel
    {
        /// <summary>
        ///  Gets or sets the component relation identity.
        /// </summary>
        public long ComponentRelationId { get; set; }

        /// <summary>
        ///  Gets or sets the relation type identity.
        /// </summary>
        public long RelationId { get; set; }

        /// <summary>
        ///  Gets or sets a value indicating whether the reference is invalid.
        /// </summary>
        public bool Invalid { get; set; }

        /// <summary>
        ///  Gets or sets the source component identity.
        /// </summary>
        public long SourceComponentId { get; set; }

        /// <summary>
        ///  Gets or sets the source component type identity.
        /// </summary>
        public long SourceComponentTypeId { get; set; }

        /// <summary>
        ///  Gets or sets the source component type name.
        /// </summary>
        public string SourceComponentTypeName { get; set; }

        /// <summary>
        ///  Gets or sets the source component name.
        /// </summary>
        public string SourceName { get; set; }

        /// <summary>
        ///  Gets or sets the schema standard.
        /// </summary>
        public string SchemaStandard { get; set; }

        /// <summary>
        ///  Gets or sets the target component identity.
        /// </summary>
        public long? TargetComponentId { get; set; }

        /// <summary>
        ///  Gets or sets the target component type identity.
        /// </summary>
        public long? TargetComponentTypeId { get; set; }

        /// <summary>
        ///  Gets or sets the target component type name.
        /// </summary>
        public string TargetComponentTypeName { get; set; }

        /// <summary>
        ///  Gets or sets the target component state.
        /// </summary>
        public ComponentStateType TargetComponentState { get; set; }

        /// <summary>
        ///  Gets or sets the target component filename.
        /// </summary>
        public string TargetComponentFileName { get; set; }

        /// <summary>
        ///  Gets or sets the target component lock.
        /// </summary>
        public ComponentLockModel Lock { get; set; }

        /// <summary>
        ///  Gets or sets the source component lock.
        /// </summary>
        public ComponentLockModel SourceLock { get; set; }

        /// <summary>
        ///  Gets or sets the target folder id.
        /// </summary>
        public long TargetFolderId { get; set; }

        /// <summary>
        ///  Gets or sets the target folder path.
        /// </summary>
        public string TargetFolderPath { get; set; }

        /// <summary>
        ///  Gets or sets the target component name.
        /// </summary>
        public string TargetName { get; set; }

        /// <summary>
        ///  Gets or sets a value indicating whether target is editable.
        /// </summary>
        public bool IsTargetEditable { get; set; }

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
    }
}