//-----------------------------------------------------------------
// <copyright file="TranslationDetailModel.cs" company="GlobalLink Vasont">
// Copyright (c) GlobalLink Vasont. All rights reserved.
// </copyright>
//-----------------------------------------------------------------
namespace Vasont.Inspire.Models.Translations
{
    using System;
    using System.Collections.Generic;
    using Vasont.Inspire.Models.Common;
    using Vasont.Inspire.Models.Security;
    using Vasont.Inspire.Models.Transfers;

    /// <summary>
    /// This class represents a translation within the application.
    /// </summary>
    public class TranslationDetailModel
    {
        /// <summary>
        /// Gets or sets the identity of the translation.
        /// </summary>
        public long TranslationId { get; set; }

        /// <summary>
        /// Gets or sets the translation name.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the translation description.
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets the translation coordinator user information.
        /// </summary>
        public MinimalUserModel Coordinator { get; set; } = new MinimalUserModel();

        /// <summary>
        /// Gets or sets the translation state information.
        /// </summary>
        public TranslationJobState State { get; set; } = TranslationJobState.Translating;

        /// <summary>
        /// Gets or sets the date time when the translation was started.
        /// </summary>
        public DateTime? StartDate { get; set; }

        /// <summary>
        /// Gets or sets the data and time the translation is due.
        /// </summary>
        public DateTime? DueDate { get; set; }

        /// <summary>
        /// Gets or sets the date and time that the translation was completed or cancelled.
        /// </summary>
        public DateTime? CompletedDate { get; set; }

        /// <summary>
        /// Gets or sets the user information about the user who last completed the translation.
        /// </summary>
        public MinimalUserModel CompletedBy { get; set; } = new MinimalUserModel();

        /// <summary>
        /// Gets or sets the date and time that the translation was completed.
        /// </summary>
        public DateTime? CancelledDate { get; set; }

        /// <summary>
        /// Gets or sets the user information about the user who last cancelled the translation.
        /// </summary>
        public MinimalUserModel CancelledBy { get; set; } = new MinimalUserModel();

        /// <summary>
        /// Gets or sets the date and time when the translation was created.
        /// </summary>
        public DateTime CreatedDate { get; set; } = DateTime.UtcNow;

        /// <summary>
        /// Gets or sets the user information about the user who created the translation.
        /// </summary>
        public MinimalUserModel CreatedBy { get; set; } = new MinimalUserModel();

        /// <summary>
        /// Gets or sets a value indicating whether the translation is archived.
        /// </summary>
        public bool Archived { get; set; }

        /// <summary>
        /// Gets or sets a list of translation languaged in the job.
        /// </summary>
        public List<MinimalLanguageModel> TranslationLanguages { get; set;  }

        /// <summary>
        /// Gets or sets the translation vendor.
        /// </summary>
        public TranslationVendorModel Vendor { get; set; }

        /// <summary>
        /// Gets or sets the translation filter.
        /// </summary>
        public string Filter { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the translation included referenced content.
        /// </summary>
        public bool IncludeReferencedContent { get; set; }

        /// <summary>
        /// Gets or sets the translation export configuration.
        /// </summary>
        public MinimalExportModel Export { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the translation included binary components.
        /// </summary>
        public bool IncludeBinary { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the translation was forced to include all components.
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
        /// Gets or sets the translation attributes.
        /// </summary>
        public string Attributes { get; set; }

        /// <summary>
        /// Gets or sets the translation components detail associated with the translation.
        /// </summary>
        public List<TranslationJobComponentModel> Components { get; set; } = new List<TranslationJobComponentModel>();

        /// <summary>
        /// Gets or sets a value indicating whether the translation is related to workflow.
        /// </summary>
        public bool HasWorkflow { get; set; }
    }
}
