//-------------------------------------------------------------
// <copyright file="ImportTransformModel.cs" company="GlobalLink Vasont">
// Copyright (c) GlobalLink Vasont. All rights reserved.
// </copyright>
//-------------------------------------------------------------
namespace Vasont.Inspire.Models.Transfers
{
    /// <summary>
    /// This class represents an import transform model within the application.
    /// </summary>
    public class ImportTransformModel
    {
        /// <summary>
        /// Gets or sets the import transform identity.
        /// </summary>
        public long ImportTransformId { get; set; }

        /// <summary>
        /// Gets or sets the import id.
        /// </summary>
        public long ImportId { get; set; }

        /// <summary>
        /// Gets or sets the component id for the XSLT component.
        /// </summary>
        public long ComponentId { get; set; }

        /// <summary>
        /// Gets or sets the component name for the XSLT component.
        /// </summary>
        public string ComponentName { get; set; }

        /// <summary>
        /// Gets or sets the order for the transform.
        /// </summary>
        public int SortOrder { get; set; }
    }
}