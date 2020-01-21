//-------------------------------------------------------------------------------
// <copyright file="MinimalTranslationJobComponentModel.cs" company="GlobalLink Vasont">
// Copyright (c) GlobalLink Vasont. All rights reserved.
// </copyright>
//-------------------------------------------------------------------------------
namespace Vasont.Inspire.Models.Translations
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using Vasont.Inspire.Core.Extensions;

    /// <summary>
    /// Contains an enumerated list of translation job component states.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum TranslationJobComponentState
    {
        /// <summary>
        /// The translation job component is queued for translation.
        /// </summary>
        Queued,

        /// <summary>
        /// The translation job component has been submitted for translation.
        /// </summary>
        Submitted,

        /// <summary>
        /// The translation job component has been completed.
        /// </summary>
        Completed,

        /// <summary>
        /// The translation job component has been cancelled.
        /// </summary>
        Cancelled
    }

    /// <summary>
    /// This class represents a minimal translation job component within the application.
    /// </summary>
    public class MinimalTranslationJobComponentModel
    {
        /// <summary>
        /// Gets or sets the identity of the translation job component.
        /// </summary>
        public long TranslationJobComponentId { get; set; }

        /// <summary>
        /// Gets or sets the identity of the translation job.
        /// </summary>
        public long TranslationJobId { get; set; }

        /// <summary>
        /// Gets or sets the state of the translation job component.
        /// </summary>
        public TranslationJobComponentState State { get; set; }

        /// <summary>
        /// Gets or sets the target file name.
        /// </summary>
        public string FileName { get; set; }

        /// <summary>
        /// Gets or sets the source language code.
        /// </summary>
        public string SourceLanguageCode { get; set; }

        /// <summary>
        /// Gets or sets the target language code.
        /// </summary>
        public string TargetLanguageCode { get; set; }

        /// <summary>
        /// Gets or sets the translation job source component identifier.
        /// </summary>
        public long TranslationJobSourceComponentId { get; set; }

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the type of the component.
        /// </summary>
        public string ComponentTypeName { get; set; }
    }
}
