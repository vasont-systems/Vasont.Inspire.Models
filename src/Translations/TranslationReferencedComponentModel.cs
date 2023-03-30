//-------------------------------------------------------------------
// <copyright file="TranslationReferencedComponentModel.cs" company="GlobalLink Vasont">
// Copyright (c) GlobalLink Vasont. All rights reserved.
// </copyright>
//-------------------------------------------------------------------
namespace Vasont.Inspire.Models.Translations
{
    using System.Collections.Generic;

    /// <summary>
    /// This class is a model representation of the translation job referenced components.
    /// </summary>
    public class TranslationReferencedComponentModel
    {
        /// <summary>
        /// Gets or sets the identity of the translation referenced component.
        /// </summary>
        public long TranslationReferencedComponentsId { get; set; }

        /// <summary>
        /// Gets or sets the identity of the translation job.
        /// </summary>
        public long TranslationJobId { get; set; }

        /// <summary>
        /// Gets or sets a value indicating with the component id.
        /// </summary>
        public long ComponentId { get; set; }
   }
}