//----------------------------------------------------------------------------
// <copyright file="TranslationExportStateModel.cs" company="GlobalLink Vasont">
// Copyright (c) GlobalLink Vasont. All rights reserved.
// </copyright>
//----------------------------------------------------------------------------
namespace Vasont.Inspire.Models.Translations
{
    using System.Collections.Generic;

    /// <summary>
    /// This class contains the translation export state model used in a translation export request.
    /// </summary>
    public class TranslationExportStateModel
    {
        /// <summary>
        /// Gets or sets the export identity of the translation vendor.
        /// </summary>
        public long TranslationVendorId { get; set; }

        /// <summary>
        /// Gets or sets the name of the translation vendor.
        /// </summary>
        public string TranslationVendorName { get; set; }

        /// <summary>
        /// Gets or sets a list of translation jobs within the database that are being exported.
        /// </summary>
        public List<TranslationExportJobModel> TranslationJobs { get; set; } = new List<TranslationExportJobModel>();
    }
}