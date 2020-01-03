//-------------------------------------------------------------
// <copyright file="TranslationRelationModel.cs" company="GlobalLink Vasont">
// Copyright (c) GlobalLink Vasont. All rights reserved.
// </copyright>
//-------------------------------------------------------------
namespace Vasont.Inspire.Models.Components
{
    using System;

    /// <summary>
    /// This class model represents a component reference found within the data repository to be used for translations.
    /// </summary>
    public class TranslationRelationModel : ComponentRelationModel
    {
        /// <summary>
        /// Gets or sets the translation language code.
        /// </summary>
        public string LanguageCode { get; set; }

        /// <summary>
        /// Gets or sets the translation language name.
        /// </summary>
        public string LanguageName { get; set; }

        /// <summary>
        /// Gets or sets the translation date.
        /// </summary>
        public DateTime Date { get; set; }
    }
}