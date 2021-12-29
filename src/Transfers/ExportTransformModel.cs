//-------------------------------------------------------------
// <copyright file="ExportTransformModel.cs" company="GlobalLink Vasont">
// Copyright (c) GlobalLink Vasont. All rights reserved.
// </copyright>
//-------------------------------------------------------------
namespace Vasont.Inspire.Models.Transfers
{
    /// <summary>
    /// This class represents an export transform model within the application.
    /// </summary>
    public class ExportTransformModel
    {
        /// <summary>
        /// Gets or sets the export transform identity.
        /// </summary>
        public long ExportTransformId { get; set; }

        /// <summary>
        /// Gets or sets the export id.
        /// </summary>
        public long ExportId { get; set; }

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