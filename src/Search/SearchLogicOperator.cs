//-------------------------------------------------------------
// <copyright file="SearchLogicOperator.cs" company="Vasont Systems">
// Copyright (c) Vasont Systems. All rights reserved.
// </copyright>
//-------------------------------------------------------------
namespace Vasont.Inspire.Models.Search
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using Vasont.Inspire.Core.Extensions;
    using Vasont.Inspire.Core.Properties;

    /// <summary>
    /// Gets or sets an enumerated list of available operators
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum SearchLogicOperator
    {
        /// <summary>
        /// Join filters via AND operator
        /// </summary>
        [LocalizedDescription(ResourceKeys.LabelAndText)]
        And,

        /// <summary>
        /// Join filters via OR operator
        /// </summary>
        [LocalizedDescription(ResourceKeys.LabelOrText)]
        Or
    }
}