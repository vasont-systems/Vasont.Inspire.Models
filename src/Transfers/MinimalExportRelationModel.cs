//-------------------------------------------------------------
// <copyright file="MinimalExportRelationModel.cs" company="GlobalLink Vasont">
// Copyright (c) GlobalLink Vasont. All rights reserved.
// </copyright>
//-------------------------------------------------------------
namespace Vasont.Inspire.Models.Transfers
{
    /// <summary>
    /// This class represents an export relation record model within the application.
    /// </summary>
    public class MinimalExportRelationModel
    {
        /// <summary>
        /// Gets or sets the export relation identity.
        /// </summary>
        public long ExportRelationId { get; set; }

        /// <summary>
        /// Gets or sets the export id.
        /// </summary>
        public long ExportId { get; set; }

        /// <summary>
        /// Gets or sets the related relation model.
        /// </summary>
        public long RelationId { get; set; }

        /// <summary>
        /// Gets or sets the relation name
        /// </summary>
        public string RelationName { get; set; }

        /// <summary>
        /// Gets or sets the relation description
        /// </summary>
        public string RelationDescription { get; set; }

        /// <summary>
        /// Gets or sets the XML Link Name
        /// </summary>
        public string XmlLinkName { get; set; }

        /// <summary>
        /// Gets or sets an optional element identity.
        /// </summary>
        public long? ElementId { get; set; }

        /// <summary>
        /// Gets or sets an optional element name.
        /// </summary>
        public string ElementName { get; set; }
    }
}