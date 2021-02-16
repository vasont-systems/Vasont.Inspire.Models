//-------------------------------------------------------------------------
// <copyright file="TranslationExportJobModel.cs" company="GlobalLink Vasont">
// Copyright (c) GlobalLink Vasont. All rights reserved.
// </copyright>
//-------------------------------------------------------------------------
namespace Vasont.Inspire.Models.Translations
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// This class contains the translation export job model used within within the application.
    /// </summary>
    public class TranslationExportJobModel
    {
        /// <summary>
        /// Gets or sets the export identity of the translation job.
        /// </summary>
        public long TranslationJobId { get; set; }

        /// <summary>
        /// Gets or sets the current status of the translation job.
        /// </summary>
        public TranslationJobState State { get; set; }

        /// <summary>
        /// Gets or sets the download URL to retrieve the translation export.
        /// </summary>
        public string DownloadUrl { get; set; }

        /// <summary>
        /// Gets or sets the archive file name.
        /// </summary>
        public string ArchiveFileName { get; set; }

        /// <summary>
        /// Gets or sets a list of components within the database that are to be exported.
        /// </summary>
        public List<MinimalTranslationJobComponentModel> Components { get; set; } = new List<MinimalTranslationJobComponentModel>();

        /// <summary>
        /// Gets or sets the custom attributes.
        /// </summary>
        public string SubmissionAttributes { get; set; }

        /// <summary>
        /// Gets or sets the name of the submission.
        /// </summary>
        public string SubmissionName { get; set; }

        /// <summary>
        /// Gets or sets the description.
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets the due date.
        /// </summary>
        public DateTime? DueDate { get; set; }

        /// <summary>Gets or sets the project code.</summary>
        public string ProjectCode { get; set; }

        /// <summary>Gets or sets the integration id.</summary>
        public long? TranslationIntegrationId { get; set; }

        /// <summary>Gets or sets the properties id.</summary>
        public long? TranslationPropertiesId { get; set; }
    }
}