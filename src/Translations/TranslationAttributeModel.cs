//----------------------------------------------------------------------
// <copyright file="TranslationAttributeModel.cs" company="GlobalLink Vasont">
// Copyright (c) GlobalLink Vasont. All rights reserved.
// </copyright>
//----------------------------------------------------------------------
namespace Vasont.Inspire.Models.Translations
{
    using System.Collections.Generic;

    /// <summary>
    /// This class is a model representation of a translation attribute within the application.
    /// </summary>
    public class TranslationAttributeModel
    {
        /// <summary>
        /// Gets or sets the identity of the translation attribute.
        /// </summary>
        public long TranslationAttributeId { get; set; }

        /// <summary>
        /// Gets or sets the identity of the XML attribute.
        /// </summary>
        public long AttributeId { get; set; }

        /// <summary>
        /// Gets or sets the name of the XML attribute.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the attribute is ignored by translation.
        /// </summary>
        public bool IgnoreTranslation { get; set; } = false;
    }
}