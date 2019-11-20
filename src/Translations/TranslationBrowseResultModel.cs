//----------------------------------------------------------------------------
// <copyright file="TranslationBrowseResultModel.cs" company="Vasont Systems">
// Copyright (c) Vasont Systems. All rights reserved.
// </copyright>
//----------------------------------------------------------------------------
namespace Vasont.Inspire.Models.Translations
{
    using System.Collections.Generic;

    /// <summary>
    /// This class represents the results of a translation browse query request.
    /// </summary>
    public class TranslationBrowseResultModel
    {
        /// <summary>
        /// Gets or sets the total number of translations.
        /// </summary>
        public long TotalCount { get; set; }

        /// <summary>
        /// Gets or sets the resulting translations from the query request.
        /// </summary>
        public List<MinimalTranslationJobModel> Translations { get; set; }
    }
}