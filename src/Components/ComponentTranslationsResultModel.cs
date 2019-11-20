//-------------------------------------------------------------
// <copyright file="ComponentTranslationsResultModel.cs" company="Vasont Systems">
// Copyright (c) Vasont Systems. All rights reserved.
// </copyright>
//-------------------------------------------------------------
namespace Vasont.Inspire.Models.Components
{
    using System.Collections.Generic;

    /// <summary>
    /// This class represents the results of a component translations query request.
    /// </summary>
    public class ComponentTranslationsResultModel
    {
        /// <summary>
        /// Gets or sets the total number of component translations.
        /// </summary>
        public long TotalCount { get; set; }

        /// <summary>
        /// Gets or sets the resulting component translations from the query request.
        /// </summary>
        public List<TranslationReferenceModel> ComponentTranslations { get; set; }
    }
}