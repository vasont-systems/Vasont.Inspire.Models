﻿//----------------------------------------------------------------------
// <copyright file="TranslationVendorModel.cs" company="GlobalLink Vasont">
// Copyright (c) GlobalLink Vasont. All rights reserved.
// </copyright>
//----------------------------------------------------------------------
namespace Vasont.Inspire.Models.Translations
{
    using System.Collections.Generic;

    /// <summary>
    /// This class is a model representation of a translation vendor within the application.
    /// </summary>
    public class TranslationVendorModel
    {
        /// <summary>
        /// Gets or sets the identity of the translation vendor.
        /// </summary>
        public long TranslationVendorId { get; set; }

        /// <summary>
        /// Gets or sets the name of the translation vendor.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the description of the translation vendor.
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the vendor is currently active.
        /// </summary>
        public bool Active { get; set; } = true;

        /// <summary>
        /// Gets or sets a value indicating whether an API integration is used to perform translations for this vendor.
        /// </summary>
        public bool ApiIntegration { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this vendor api integration supports cancellation.
        /// </summary>
        public bool SupportCancellation { get; set; }

        /// <summary>
        /// Gets or sets a list of TranslationAttributes.
        /// </summary>
        public List<TranslationVendorFieldModel> VendorAttributes { get; set; } = new List<TranslationVendorFieldModel>();

        /// <summary>Gets or sets the project code.</summary>
        public string ProjectCode { get; set; }

        /// <summary>
        /// Gets or sets the optional translation integration identifier.
        /// </summary>
        public long? TranslationIntegrationId { get; set; }

        /// <summary>
        /// Gets or sets the translation integration name, if available.
        /// </summary>
        public string TranslationIntegrationName { get; set; }

        /// <summary>
        /// Gets or sets the optional translation integration.
        /// </summary>
        public TranslationIntegrationModel TranslationIntegration { get; set; }
    }
}