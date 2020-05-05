//-----------------------------------------------------------------------
// <copyright file="MinimalComponentTypeModel.cs" company="GlobalLink Vasont">
// Copyright (c) GlobalLink Vasont. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------
namespace Vasont.Inspire.Models.Components
{
    using System;
    using System.Linq;
    using Vasont.Inspire.Models.Common;

    /// <summary>
    /// This class represents a minimal component type model within the system.
    /// </summary>
    public class MinimalComponentTypeModel
    {
        /// <summary>
        /// Gets or sets the identity of the component type.
        /// </summary>
        public long ComponentTypeId { get; set; }

        /// <summary>
        /// Gets or sets the name of the component type.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the description of the component type.
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the component type is binary. If binary is false, the component type
        /// relates to XML content.
        /// </summary>
        public bool Binary { get; set; }

        /// <summary>
        /// Gets or sets the document type.
        /// </summary>
        public string DocumentType { get; set; }

        /// <summary>
        /// Gets or sets the schema standard.
        /// </summary>
        public string SchemaStandard { get; set; }

        /// <summary>
        /// Gets a value indicating whether the component type is able to be edited by the internal XML editor.
        /// </summary>
        public bool IsEditable => !this.Binary && this.DocumentType != null;

        /// <summary>
        /// Gets a value indicating whether the component is a map that is
        /// </summary>
        public bool IsMap => this.DocumentType != null && ComponentStandards.MapDocumentTypeNames.Contains(this.DocumentType, StringComparer.OrdinalIgnoreCase);

        /// <summary>
        /// Gets a value indicating whether the component can be sent to publishing.
        /// </summary>
        public bool CanPublish => !this.Binary && !this.IsWorkflow;

        /// <summary>
        /// Gets a value indicating whether the component is a workflow
        /// </summary>
        public bool IsWorkflow => this.DocumentType != null && this.DocumentType.Equals("workflow", StringComparison.OrdinalIgnoreCase);
    }
}