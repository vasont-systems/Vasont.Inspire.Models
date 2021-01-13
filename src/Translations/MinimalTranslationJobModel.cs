//--------------------------------------------------------------------------
// <copyright file="MinimalTranslationJobModel.cs" company="GlobalLink Vasont">
// Copyright (c) GlobalLink Vasont. All rights reserved.
// </copyright>
//--------------------------------------------------------------------------
namespace Vasont.Inspire.Models.Translations
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using Vasont.Inspire.Core.Extensions;
    using Vasont.Inspire.Core.Properties;
    using Vasont.Inspire.Models.Common;
    using Vasont.Inspire.Models.Security;

    /// <summary>
    /// Contains an enumerated list of translation job states.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum TranslationJobState
    {
        /// <summary>
        /// The translation job is translating.
        /// </summary>
        [LocalizedDescription(ResourceKeys.LabelTranslatingText)]
        Translating,

        /// <summary>
        /// The translation job has been completed.
        /// </summary>
        [LocalizedDescription(ResourceKeys.LabelCompletedText)]
        Completed,

        /// <summary>
        /// The translation job has been cancelled.
        /// </summary>
        [LocalizedDescription(ResourceKeys.LabelCancelledText)]
        Cancelled,

        /// <summary>
        /// The translation job is exporting
        /// </summary>
        [LocalizedDescription(ResourceKeys.LabelExportingText)]
        Exporting,

        /// <summary>
        /// The translation job at vendor
        /// </summary>
        [LocalizedDescription(ResourceKeys.LabelAtVendorText)]
        AtVendor,

        /// <summary>
        /// The translation job failed sending
        /// </summary>
        [LocalizedDescription(ResourceKeys.LabelFailedSendingText)]
        FailedSending,

        /// <summary>
        /// The translation job failed retrieving
        /// </summary>
        [LocalizedDescription(ResourceKeys.LabelFailedRetrievingText)]
        FailedRetrieving
    }

    /// <summary>
    /// This class is a model representation of a minimal translation job within the application.
    /// </summary>
    public class MinimalTranslationJobModel
    {
        /// <summary>
        /// Gets or sets the identity of the translation job.
        /// </summary>
        public long TranslationJobId { get; set; }

        /// <summary>
        /// Gets or sets the name of the translation job.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the description of the translation job.
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets the current status of the translation job.
        /// </summary>
        public TranslationJobState State { get; set; }

        /// <summary>
        /// Gets or sets the state on the model via string name.
        /// </summary>
        [JsonIgnore]
        public string StateName
        {
            get => this.State.ToString();
            set => this.State = value.ToEnum<TranslationJobState>();
        }

        /// <summary>
        /// Gets or sets the translation vendor associated with the translation job.
        /// </summary>
        public TranslationVendorModel TranslationVendor { get; set; } = new TranslationVendorModel();

        /// <summary>
        /// Gets or sets the user model of the translation job coordinator.
        /// </summary>
        public MicroUserModel Coordinator { get; set; } = new MicroUserModel();

        /// <summary>
        /// Gets or sets the date and time when the translation job was created.
        /// </summary>
        public DateTime CreatedDate { get; set; }

        /// <summary>
        /// Gets or sets the identifier for the user who created the translation job.
        /// </summary>
        public MinimalUserModel CreatedBy { get; set; } = new MinimalUserModel();

        /// <summary>
        /// Gets or sets the date and time when the translation job is due.
        /// </summary>
        public DateTime? DueDate { get; set; }

        /// <summary>
        /// Gets or sets the date and time when the translation job was completed.
        /// </summary>
        public DateTime? CompletedDate { get; set; }

        /// <summary>
        /// Gets or sets the identifier for the user who completed the translation job.
        /// </summary>
        public MinimalUserModel CompletedBy { get; set; } = new MinimalUserModel();

        /// <summary>
        /// Gets or sets a value indicating whether the translation job is archived.
        /// </summary>
        public bool Archived { get; set; }

        /// <summary>
        /// Gets or sets the translation job languages.
        /// </summary>
        public List<MinimalLanguageModel> Languages { get; set; } = new List<MinimalLanguageModel>();

        /// <summary>
        /// Gets a comma delimited list of language names.
        /// </summary>
        public string LanguageNames => string.Join(", ", this.Languages.OrderBy(l => l.Name).Select(l => l.Name).ToList());

        /// <summary>
        /// Gets or sets the vendor specific custom attributes JSON string.
        /// </summary>
        public string SubmissionAttributes { get; set; }

        /// <summary>
        /// Gets or sets the project code.
        /// </summary>
        public string ProjectCode { get; set; }

        /// <summary>
        /// Gets or sets the translation integration id.
        /// </summary>
        public long? TranslationIntegrationId { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether [cancel at vendor].
        /// </summary>
        public bool CancelAtVendor { get; set; }

        /// <summary>
        /// Gets or sets the date and time when the translation job was cancelled.
        /// </summary>
        public DateTime? CancelledDate { get; set; }

        /// <summary>
        /// Gets or sets the identifier for the user who cancelled the translation job.
        /// </summary>
        public MinimalUserModel CancelledBy { get; set; } = new MinimalUserModel();

        /// <summary>
        /// Gets or sets the date and time when the translation job was cancelled.
        /// </summary>
        public DateTime? ArchivedDate { get; set; }

        /// <summary>
        /// Gets or sets the identifier for the user who archived the translation job.
        /// </summary>
        public MinimalUserModel ArchivedBy { get; set; } = new MinimalUserModel();

        /// <summary>
        /// Gets or sets the submission request info sent over to the integration.
        /// </summary>
        public string SubmissionRequest { get; set; }

        /// <summary>
        /// Gets or sets the submission response info received from the integration.
        /// </summary>
        public string SubmissionResponse { get; set; }

        /// <summary>
        /// Gets or sets the retrieval request info sent over to the integration.
        /// </summary>
        public string RetrievalRequest { get; set; }

        /// <summary>
        /// Gets or sets the retrieval response info received from the integration.
        /// </summary>
        public string RetrievalResponse { get; set; }

        /// <summary>
        /// Gets or sets the Url from where the resulting files can be downloaded.
        /// </summary>
        public string FileDownloadUrl { get; set; }
    }
}