//--------------------------------------------------------------------------
// <copyright file="MinimalTranslationConfigurationModel.cs" company="GlobalLink Vasont">
// Copyright (c) GlobalLink Vasont. All rights reserved.
// </copyright>
//--------------------------------------------------------------------------
namespace Vasont.Inspire.Models.Translations
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Vasont.Inspire.Models.Common;
    using Vasont.Inspire.Models.Security;

    /// <summary>
    /// This class is a model representation of a minimal translation configuration within the application.
    /// </summary>
    public class MinimalTranslationConfigurationModel
    {
        /// <summary>
        /// Gets or sets the identity of the translation configuration.
        /// </summary>
        public long TranslationConfigurationId { get; set; }

        /// <summary>
        /// Gets or sets the name of the translation configuration.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the description of the translation configuration.
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets the translation vendor associated with the translation configuration.
        /// </summary>
        public TranslationVendorModel TranslationVendor { get; set; } = new TranslationVendorModel();

        /// <summary>
        /// Gets or sets the date and time when the translation configuration was created.
        /// </summary>
        public DateTime CreatedDate { get; set; }

        /// <summary>
        /// Gets or sets the identifier for the user who created the translation configuration.
        /// </summary>
        public MinimalUserModel CreatedBy { get; set; } = new MinimalUserModel();

        /// <summary>
        /// Gets or sets the date and time when the translation configuration was updated.
        /// </summary>
        public DateTime UpdatedDate { get; set; }

        /// <summary>
        /// Gets or sets the identifier for the user who updated the translation configuration.
        /// </summary>
        public MinimalUserModel UpdatedBy { get; set; } = new MinimalUserModel();

        /// <summary>
        /// Gets or sets a value indicating whether the translation configuration is active.
        /// </summary>
        public bool Active { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the translation configuration is a default translation configuration.
        /// </summary>
        public bool Default { get; set; }

        public List<MinimalLanguageModel> Languages { get; set; } = new List<MinimalLanguageModel>();

        /// <summary>
        /// Gets a comma delimited list of language names.
        /// </summary>
        public string LanguageNames => string.Join(", ", this.Languages.OrderBy(l => l.Name).Select(l => l.Name).ToList());

        /// <summary>
        /// Gets or sets the translation integration id.
        /// </summary>
        public long? TranslationIntegrationId { get; set; }

        /// <summary>
        /// Gets or sets the translation properties id.
        /// </summary>
        public long? TranslationPropertiesId { get; set; }

        /// <summary>
        /// Gets or sets the translation configuration properties.
        /// </summary>
        public TranslationJobPropertiesModel TranslationJobProperties { get; set; } = new TranslationJobPropertiesModel();

        /// <summary>
        /// Gets or sets the identifier from the integration provider.
        /// </summary>
        public string IntegrationProjectId { get; set; }
    }
}