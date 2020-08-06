//----------------------------------------------------------------------
// <copyright file="TranslationVendorFieldModel.cs" company="GlobalLink Vasont">
// Copyright (c) GlobalLink Vasont. All rights reserved.
// </copyright>
//----------------------------------------------------------------------
namespace Vasont.Inspire.Models.Translations
{
    /// <summary>
    /// This class represents a Translation Vendor Field.
    /// </summary>
    public class TranslationVendorFieldModel
    {
        /// <summary>
        /// Gets or sets the Translation Vendor Field identity.
        /// </summary>
        public long TranslationVendorFieldId { get; set; }

        /// <summary>
        /// Gets or sets the Translation Vendor identity.
        /// </summary>
        public long TranslationVendorId { get; set; }

        /// <summary>
        /// Gets or sets the Translation Vendor name.
        /// </summary>
        public string TranslationVendorName { get; set; }

        /// <summary>
        /// Gets or sets the Translation Vendor Field display name.
        /// </summary>
        public string DisplayName { get; set; }

        /// <summary>
        /// Gets or sets the Translation Vendor Field name.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the Translation Vendor Field value.
        /// </summary>
        public string Type { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the field is required.
        /// </summary>
        public bool Required { get; set; }

        /// <summary>
        /// Gets or sets the client identity.
        /// </summary>
        public long ClientId { get; set; }

        /// <summary>
        /// Gets or sets the parent identity.
        /// </summary>
        public long? ParentId { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the field is included or not.
        /// </summary>
        public bool IsIncluded { get; set; }

        /// <summary>
        /// Gets or sets the Description Field value.
        /// </summary>
        public string Description { get; set; }
    }
}