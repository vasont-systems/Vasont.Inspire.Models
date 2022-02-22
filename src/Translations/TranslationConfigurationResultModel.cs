//----------------------------------------------------------------------------
// <copyright file="TranslationConfigurationResultModel.cs" company="GlobalLink Vasont">
// Copyright (c) GlobalLink Vasont. All rights reserved.
// </copyright>
//----------------------------------------------------------------------------
namespace Vasont.Inspire.Models.Translations
{
    using System.Collections.Generic;

    /// <summary>
    /// This class represents the results of a translation configuration query request.
    /// </summary>
    public class TranslationConfigurationResultModel
    {
        /// <summary>
        /// Gets or sets the total number of translation configurations.
        /// </summary>
        public long TotalCount { get; set; }

        /// <summary>
        /// Gets or sets the resulting translation configurations from the query request.
        /// </summary>
        public List<TranslationConfigurationModel> TranslationConfigurations { get; set; } = new List<TranslationConfigurationModel>();
    }
}