//-----------------------------------------------------------------------------
// <copyright file="TranslationExportRequestModel.cs" company="GlobalLink Vasont">
// Copyright (c) GlobalLink Vasont. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------------
namespace Vasont.Inspire.Models.Translations
{
    /// <summary>
    /// This class contains properties and information to request the system to start a translation export process.
    /// </summary>
    public class TranslationExportRequestModel
    {
        /// <summary>
        /// Gets or sets the identity for the translation vendor for which content will be exported.
        /// </summary>
        public long TranslationVendorId { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the process will send a notification.
        /// </summary>
        public bool SendNotification { get; set; }
    }
}