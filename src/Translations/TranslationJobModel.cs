//-------------------------------------------------------------------
// <copyright file="TranslationJobModel.cs" company="GlobalLink Vasont">
// Copyright (c) GlobalLink Vasont. All rights reserved.
// </copyright>
//-------------------------------------------------------------------
namespace Vasont.Inspire.Models.Translations
{
    using System.Collections.Generic;

    /// <summary>
    /// This class is a model representation of a translation job within the application.
    /// </summary>
    public class TranslationJobModel : MinimalTranslationJobModel
    {
        /// <summary>
        /// Gets or sets a list of component identities that will be used to initiate a new translation job.
        /// </summary>
        public List<long> SourceComponentIds { get; set; } = new List<long>();

        /// <summary>
        /// Gets or sets a value indicating whether related components should be included when initiating a new translation job.
        /// </summary>
        public bool IncludeRelationships { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether translation components will be created within sub-folders with a folder name matching the language code.
        /// </summary>
        public bool CreateSubFolders { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether a complete translation should be forced.
        /// </summary>
        public bool ForceTranslation { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether attributes are to be ignored when finding modified content.
        /// </summary>
        public bool IgnoreAttributes { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether XSDs zip file should be included with translation job.
        /// </summary>
        public bool IncludeXSDs { get; set; }

        /// <summary>
        /// Gets or sets the translation job components that are applied to the translation job.
        /// </summary>
        public List<TranslationJobComponentModel> Components { get; set; } = new List<TranslationJobComponentModel>();

        /// <summary>
        /// Gets or sets a list of values to be used for component filtering based on audience.
        /// </summary>
        public List<string> FilterValues { get; set; } = new List<string>();

        /// <summary>
        /// Gets or sets the display text used for the component filtering based on audience.
        /// </summary>
        public string FilterDisplayString { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether to include binary components in translation.
        /// </summary>
        public bool IncludeBinary { get; set; }

        /// <summary>
        /// Gets or sets a value indicating with the export config id.
        /// </summary>
        public long ExportId { get; set; }

        /// <summary>
        /// Gets or sets a value indicating with project directory workflow id.
        /// </summary>
        public long WorkflowId { get; set; }
    }
}