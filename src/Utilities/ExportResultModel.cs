//-----------------------------------------------------------------------
// <copyright file="ExportResultModel.cs" company="Vasont Systems">
//     Copyright (c) Vasont Systems. All rights reserved.
// </copyright>
// <author>Steve Sargent</author>
//-----------------------------------------------------------------------

namespace Vasont.Inspire.Models.Utilities
{
    /// <summary>
    /// This class represents an export returned from the exports API query.
    /// </summary>
    public class ExportResultModel
    {
        /// <summary>
        /// Gets or sets the unique identity for this export.
        /// </summary>
        public long ExportId { get; set; }

        /// <summary>
        /// Gets or sets the export name.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the export description.
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the export is a default.
        /// </summary>
        public bool Default { get; set; }
    }
}