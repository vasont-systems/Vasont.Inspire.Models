//----------------------------------------------------------------------
// <copyright file="TranslationVendorFieldValueModel.cs" company="GlobalLink Vasont">
// Copyright (c) GlobalLink Vasont. All rights reserved.
// </copyright>
//----------------------------------------------------------------------
namespace Vasont.Inspire.Models.Translations
{
    /// <summary>
    /// This class represents a Translation Vendor Field.
    /// </summary>
    public class TranslationVendorFieldValueModel
    {
        /// <summary>
        /// Gets or sets the Translation Vendor Field Value identity.
        /// </summary>
        public long TranslationVendorFieldValueId { get; set; }

        /// <summary>
        /// Gets or sets the Translation Vendor Field identity.
        /// </summary>
        public long TranslationVendorFieldId { get; set; }

        /// <summary>
        /// Gets or sets the Translation Vendor Field valid value.
        /// </summary>
        public string ValidValue { get; set; }
   }
}