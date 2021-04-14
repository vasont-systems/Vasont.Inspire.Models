//-------------------------------------------------------------------
// <copyright file="TranslationJobPropertiesModel.cs" company="GlobalLink Vasont">
// Copyright (c) GlobalLink Vasont. All rights reserved.
// </copyright>
//-------------------------------------------------------------------
namespace Vasont.Inspire.Models.Translations
{
    using System.Collections.Generic;

    /// <summary>
    /// This class is a model representation of the translation job properties within the application.
    /// </summary>
    public class TranslationJobPropertiesModel
    {
        /// <summary>
        /// Gets or sets the identity of the translation job properties.
        /// </summary>
        public long TranslationJobPropertiesId { get; set; }

        /// <summary>
        /// Gets or sets the identity of the translation job.
        /// </summary>
        public long TranslationJobId { get; set; }

        /// <summary>
        /// Gets or sets a value indicating with the export config id.
        /// </summary>
        public long ExportId { get; set; }

        /// Gets or sets a value indicating whether related components should be included when initiating a new translation job.
        /// </summary>
        public bool IncludeRelationships { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether to include binary components in translation.
        /// </summary>
        public bool IncludeBinary { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether a complete translation should be forced.
        /// </summary>
        public bool ForceTranslation { get; set; }

        /// <summary>
        /// Gets or sets the display text used for the component filtering based on audience.
        /// </summary>
        public string FilterDisplayString { get; set; }

        /// <summary>
        /// Gets or sets the custom attributes.
        /// </summary>
        public string SubmissionAttributes { get; set; }
    }
}