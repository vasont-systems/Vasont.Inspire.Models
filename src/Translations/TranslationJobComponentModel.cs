//----------------------------------------------------------------------------
// <copyright file="TranslationJobComponentModel.cs" company="GlobalLink Vasont">
// Copyright (c) GlobalLink Vasont. All rights reserved.
// </copyright>
//----------------------------------------------------------------------------
namespace Vasont.Inspire.Models.Translations
{
    using System;
    using Vasont.Inspire.Models.Components;

    /// <summary>
    /// This class represents a translation job component within the application.
    /// </summary>
    public class TranslationJobComponentModel : MinimalTranslationJobComponentModel
    {
        /// <summary>
        /// Gets or sets the source component.
        /// </summary>
        public MinimalComponentModel SourceComponent { get; set; }

        /// <summary>
        /// Gets or sets the changeset of the source component history record.
        /// </summary>
        public Guid SourceChangesetId { get; set; }

        /// <summary>
        /// Gets or sets the target component.
        /// </summary>
        public MinimalComponentModel TargetComponent { get; set; }

        /// <summary>
        /// Gets or sets the changeset of the target component history record.
        /// </summary>
        public Guid TargetChangesetId { get; set; }

        /// <summary>
        /// Gets or sets the date and time when the translation job component was created.
        /// </summary>
        public DateTime CreatedDate { get; set; }

        /// <summary>
        /// Gets or sets the date and time when the translation job component was submitted.
        /// </summary>
        public DateTime? SubmittedDate { get; set; }

        /// <summary>
        /// Gets or sets the date and time when the translation job component was completed.
        /// </summary>
        public DateTime? CompletedDate { get; set; }
    }
}
