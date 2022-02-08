//---------------------------------------------------------------------------
// <copyright file="TranslationConfigurationQueryModel.cs" company="GlobalLink Vasont">
// Copyright (c) GlobalLink Vasont. All rights reserved.
// </copyright>
//---------------------------------------------------------------------------

namespace Vasont.Inspire.Models.Translations
{
    using Common;

    /// <summary>
    /// This class contains parameters passed to the query for retrieving translation configurations.
    /// </summary>
    public class TranslationConfigurationQueryModel : PaginatedQueryRequestModel
    {
        /// <summary>
        /// Gets or sets search text that will be used to filter results.
        /// </summary>
        public string SearchText { get; set; }
    }
}