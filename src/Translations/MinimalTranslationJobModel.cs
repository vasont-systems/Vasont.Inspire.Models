//--------------------------------------------------------------------------
// <copyright file="MinimalTranslationJobModel.cs" company="Vasont Systems">
// Copyright (c) Vasont Systems. All rights reserved.
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
        Translating,

        /// <summary>
        /// The translation job has been completed.
        /// </summary>
        Completed,

        /// <summary>
        /// The translation job has been cancelled.
        /// </summary>
        Cancelled,

        /// <summary>The translation job is exporting</summary>
        Exporting,

        /// <summary>The translation job at vendor</summary>
        AtVendor,

        /// <summary>The translation job failed sending</summary>
        FailedSending,

        /// <summary>The translation job failed retrieving</summary>
        FailedRetrieving
    }

    /// <summary>
    /// This class is a model representation of a minimal translation job within the application.
    /// </summary>
    public class MinimalTranslationJobModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MinimalTranslationJobModel"/> class.
        /// </summary>
        public MinimalTranslationJobModel()
        {
            this.Coordinator = new MicroUserModel();
            this.TranslationVendor = new TranslationVendorModel();
            this.Languages = new List<MinimalLanguageModel>();
        }

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
        public TranslationVendorModel TranslationVendor { get; set; }

        /// <summary>
        /// Gets or sets the user model of the translation job coordinator.
        /// </summary>
        public MicroUserModel Coordinator { get; set; }

        /// <summary>
        /// Gets or sets the date and time when the translation job was created.
        /// </summary>
        public DateTime CreatedDate { get; set; }

        /// <summary>
        /// Gets or sets the date and time when the translation job is due.
        /// </summary>
        public DateTime? DueDate { get; set; }

        /// <summary>
        /// Gets or sets the date and time when the translation job was completed.
        /// </summary>
        public DateTime? CompletedDate { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the translation job is archived.
        /// </summary>
        public bool Archived { get; set; }

        /// <summary>
        /// Gets or sets the translation job languages.
        /// </summary>
        public List<MinimalLanguageModel> Languages { get; set; }

        /// <summary>
        /// Gets a comma delimited list of language names.
        /// </summary>
        public string LanguageNames => string.Join(", ", this.Languages.OrderBy(l => l.Name).Select(l => l.Name).ToList());

        /// <summary>
        /// Gets or sets the vendor specific custom attributes JSON string.
        /// </summary>
        public string SubmissionAttributes { get; set; }

        /// <summary>Gets or sets the project code.</summary>
        public string ProjectCode { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether [cancel at vendor].
        /// </summary>
        public bool CancelAtVendor { get; set; }

    }
}