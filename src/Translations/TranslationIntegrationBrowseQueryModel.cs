//----------------------------------------------------------------------
// <copyright file="TranslationIntegrationBrowseQueryModel.cs" company="GlobalLink Vasont">
// Copyright (c) GlobalLink Vasont. All rights reserved.
// </copyright>
//----------------------------------------------------------------------
namespace Vasont.Inspire.Models.Translations
{
    /// <summary>
    /// This class represents a Browse Query Model used for searching Translation Integrations.
    /// </summary>
    public class TranslationIntegrationBrowseQueryModel
    {
        /// <summary>
        /// Gets or sets a value indicating whether [active only].
        /// </summary>
        /// <value>
        ///   <c>true</c> if [active only]; otherwise, <c>false</c>.
        /// </value>
        public bool ActiveOnly { get; set; }

        /// <summary>
        /// Gets or sets the search text.
        /// </summary>
        /// <value>
        /// The search text.
        /// </value>
        public string SearchText { get; set; }
    }
}
