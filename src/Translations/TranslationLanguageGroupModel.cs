//--------------------------------------------------------------------------
// <copyright file="TranslationLanguageGroupModel.cs" company="GlobalLink Vasont">
// Copyright (c) GlobalLink Vasont. All rights reserved.
// </copyright>
//--------------------------------------------------------------------------
namespace Vasont.Inspire.Models.Translations
{
    using System.Collections.Generic;
    using Common;

    /// <summary>
    /// This class is a model representation of a translation language group within the application.
    /// </summary>
    public class TranslationLanguageGroupModel
    {
        /// <summary>
        /// Gets or sets the identity of the translation language group.
        /// </summary>
        public long LanguageGroupId { get; set; }

        /// <summary>
        /// Gets or sets the name of the translation language group.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the description of the translation language group.
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets the translation language group languages.
        /// </summary>
        public List<MinimalLanguageModel> Languages { get; set; } = new List<MinimalLanguageModel>();
    }
}