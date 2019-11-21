//------------------------------------------------------------------------
// <copyright file="ProfileAttributeItemModel.cs" company="GlobalLink Vasont">
// Copyright (c) GlobalLink Vasont. All rights reserved.
// </copyright>
//-------------------------------------------------------------------------
namespace Vasont.Inspire.Models.Components.Schema
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    /// <summary>
    /// Contains an enumerated list of profile attribute item types.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum ProfileAttributeItemType
    {
        /// <summary>
        /// The selector item is an attribute.
        /// </summary>
        Attribute,

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
    /// This class represents a profile attribute item model within the application.
    /// </summary>
    public class ProfileAttributeItemModel
    {
        #region Public Properties
        /// <summary>
        /// Gets or sets the unique identifier of the profile attribute item.
        /// </summary>
        [JsonProperty(Order = 1)]
        public string Id { get; set; }

        /// <summary>
        /// Gets or sets the profile attribute item type
        /// </summary>
        [JsonProperty(Order = 2)]
        [JsonConverter(typeof(StringEnumConverter))]
        public ProfileAttributeItemType Type { get; set; }

        /// <summary>
        /// Gets or sets the parent profile attribute item identity value.
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
        #endregion
    }
}