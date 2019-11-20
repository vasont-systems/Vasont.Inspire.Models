//---------------------------------------------------------------------------
// <copyright file="TranslationBrowseQueryModel.cs" company="Vasont Systems">
// Copyright (c) Vasont Systems. All rights reserved.
// </copyright>
//---------------------------------------------------------------------------

namespace Vasont.Inspire.Models.Translations
{
    using Common;

    /// <summary>
    /// This class contains parameters passed to the query for retrieving translations.
    /// </summary>
    public class TranslationBrowseQueryModel : PaginatedQueryRequestModel
    {
        /// <summary>
        /// Gets or sets a value indicating whether or not to include archived translations.
        /// </summary>
        public bool IncludeArchived { get; set; }

        /// <summary>
        /// Gets or sets search text that will be used to filter results.
        /// </summary>
        public string SearchText { get; set; }
    }
}