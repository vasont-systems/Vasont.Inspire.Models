//-----------------------------------------------------------------------
// <copyright file="LanguageModel.cs" company="GlobalLink Vasont">
// Copyright (c) GlobalLink Vasont. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------
using System;

namespace Vasont.Inspire.Models.Common
{
    /// <summary>
    /// This class represents a supported language definition for the application.
    /// </summary>
    [Obsolete("Use local DTOs", true)]
    public class LanguageModel : MicroCreatedUpdaterModelBase
    {
        /// <summary>
        /// Gets or sets the unique language code.
        /// </summary>
        public string LanguageCode { get; set; }

        /// <summary>
        /// Gets or sets the language display name.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the language is available as an application locale.
        /// </summary>
        public bool IsLocale { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the language has a related spelling dictionary.
        /// </summary>
        public bool HasDictionary { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the language is a default language for all locales.
        /// </summary>
        public bool Default { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the language code is active.
        /// </summary>
        public bool Active { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the language is a valid translation target.
        /// </summary>
        public bool TranslationTarget { get; set; }

        /// <summary>
        /// Gets or sets the image override language code.
        /// </summary>
        public string TranslationImageLanguageCode { get; set; }

        /// <summary>
        /// Gets or sets the image override language name.
        /// </summary>
        public string TranslationImageLanguageName { get; set; }

        /// <summary>
        /// Gets or sets the reading code ('ltr', 'lro', 'rtl', 'rlo').
        /// </summary>
        public string Reading { get; set; }
    }
}
