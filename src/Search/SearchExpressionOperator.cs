//-------------------------------------------------------------
// <copyright file="SearchExpressionOperator.cs" company="Vasont Systems">
// Copyright (c) Vasont Systems. All rights reserved.
// </copyright>
//-------------------------------------------------------------

namespace Vasont.Inspire.Models.Search
{
    using System.ComponentModel;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using Vasont.Inspire.Core.Extensions;
    using Vasont.Inspire.Core.Properties;

    /// <summary>
    /// Gets or sets an enumerated list of available operators
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum SearchExpressionOperator
    {
        /// <summary>
        /// Does equal
        /// </summary>
        [Description("=")]
        Equals,

        /// <summary>
        /// Does not equal
        /// </summary>
        [Description("<>")]
        NotEquals,

        /// <summary>
        /// Greater than
        /// </summary>
        [Description(">")]
        GreaterThan,

        /// <summary>
        /// Less than
        /// </summary>
        [Description("<")]
        LessThan,

        /// <summary>
        /// Greater than or does equal
        /// </summary>
        [Description(">=")]
        GreaterThanOrEqual,

        /// <summary>
        /// Less than or does equal
        /// </summary>
        [Description("<=")]
        LessThanOrEqual,

        /// <summary>
        /// Contains a value
        /// </summary>
        [LocalizedDescription(ResourceKeys.LabelContainsText)]
        Contains,

        /// <summary>
        /// Does not contain a value
        /// </summary>
        [LocalizedDescription(ResourceKeys.LabelDoesNotContainText)]
        DoesNotContain,

        /// <summary>
        /// Starts with a value
        /// </summary>
        [LocalizedDescription(ResourceKeys.LabelStartsWithText)]
        StartsWith,

        /// <summary>
        /// Does not start with a value
        /// </summary>
        [LocalizedDescription(ResourceKeys.LabelDoesNotStartWithText)]
        DoesNotStartWith,

        /// <summary>
        /// Ends with a value
        /// </summary>
        [LocalizedDescription(ResourceKeys.LabelEndsWithText)]
        EndsWith,

        /// <summary>
        /// Does not end with a value
        /// </summary>
        [LocalizedDescription(ResourceKeys.LabelDoesNotEndWithText)]
        DoesNotEndWith
    }
}
