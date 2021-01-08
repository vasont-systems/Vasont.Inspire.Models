//--------------------------------------------------------------------------
// <copyright file="TranslationLanguageGroupModel.cs" company="GlobalLink Vasont">
// Copyright (c) GlobalLink Vasont. All rights reserved.
// </copyright>
//--------------------------------------------------------------------------
namespace Vasont.Inspire.Models.Translations
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    /// <summary>
    /// Contains an enumerated list of translation language group item types.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum TranslationLanguageGroupItemType
    {
        /// <summary>
        /// The selector item is a group.
        /// </summary>
        Group,

        /// <summary>
        /// The selector item is a value.
        /// </summary>
        Value
    }

    /// <summary>
    /// This class represents a translation language group item model within
    /// the application.
    /// </summary>
    public class TranslationLanguageGroupItemModel
    {
        /// <summary>
        /// Gets or sets the unique identifier of the translation language group item.
        /// </summary>
        [JsonProperty(Order = 1)]
        public string Id { get; set; }

        /// <summary>
        /// Gets or sets the translation language group item type
        /// </summary>
        [JsonProperty(Order = 2)]
        [JsonConverter(typeof(StringEnumConverter))]
        public TranslationLanguageGroupItemType Type { get; set; }

        /// <summary>
        /// Gets or sets the parent translation language group item identity value.
        /// </summary>
        [JsonProperty(Order = 3)]
        public string ParentId { get; set; }

        /// <summary>
        /// Gets or sets the display value for the item.
        /// </summary>
        [JsonProperty(Order = 4)]
        public string Display { get; set; }

        /// <summary>
        /// Gets or sets the value for the item.
        /// </summary>
        [JsonProperty(Order = 5)]
        public string Value { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the item is selected.
        /// </summary>
        [JsonProperty(Order = 6)]
        public bool Selected { get; set; }

        /// <summary>
        /// Gets or sets the item id.
        /// </summary>
        [JsonProperty(Order = 7)]
        public long ItemId { get; set; }
    }
}