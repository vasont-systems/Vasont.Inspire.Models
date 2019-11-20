//-------------------------------------------------------------
// <copyright file="ElementRelationModel.cs" company="Vasont Systems">
// Copyright (c) Vasont Systems. All rights reserved.
// </copyright>
//-------------------------------------------------------------
namespace Vasont.Inspire.Models.Transfers
{
    /// <summary>
    /// This class represents an element relation model for exporting.
    /// </summary>
    public class ElementRelationModel
    {
        /// <summary>
        /// Gets or sets the unique identity of the relation.
        /// </summary>
        public long RelationId { get; set; }

        /// <summary>
        /// Gets or sets the string of the element name.
        /// </summary>
        public string ElementName { get; set; }
    }
}
