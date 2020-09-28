//----------------------------------------------------------------------
// <copyright file="TranslationIntegrationBrowseResultModel.cs" company="GlobalLink Vasont">
// Copyright (c) GlobalLink Vasont. All rights reserved.
// </copyright>
//----------------------------------------------------------------------
namespace Vasont.Inspire.Models.Translations
{
    using System.Collections.Generic;

    /// <summary>
    /// This class represents the result model for a Translation Integration search.
    /// </summary>
    public class TranslationIntegrationBrowseResultModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TranslationIntegrationBrowseResultModel"/> class.
        /// </summary>
        public TranslationIntegrationBrowseResultModel()
        {
            this.TranslationIntegrations = new List<TranslationIntegrationModel>();
        }

        /// <summary>
        /// Gets or sets the total count.
        /// </summary>
        /// <value>
        /// The total count.
        /// </value>
        public long TotalCount { get; set; }

        /// <summary>
        /// Gets or sets the translation integrations.
        /// </summary>
        /// <value>
        /// The translation integrations.
        /// </value>
        public List<TranslationIntegrationModel> TranslationIntegrations { get; set; }
    }
}
