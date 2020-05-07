//---------------------------------------------------------------------------
// <copyright file="TranslationBrowseQueryModel.cs" company="GlobalLink Vasont">
// Copyright (c) GlobalLink Vasont. All rights reserved.
// </copyright>
//---------------------------------------------------------------------------

namespace Vasont.Inspire.Models.Translations
{
    using Common;
    using System.Collections.Generic;

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

        /// <summary>
        /// Gets or sets a list of job states to filter results by.
        /// </summary>
        public List<string> JobStates { get; set; } = new List<string>();
    }
}