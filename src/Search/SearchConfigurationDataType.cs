//---------------------------------------------------------------------
// <copyright file="SearchConfigurationDataType.cs" company="GlobalLink Vasont">
// Copyright (c) GlobalLink Vasont. All rights reserved.
// </copyright>
//---------------------------------------------------------------------

namespace Vasont.Inspire.Models.Search
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    /// <summary>
    /// Contains an enumerated selection list of data types.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum SearchConfigurationDataType
    {
        /// <summary>
        /// The data type is a string.
        /// </summary>
        String,

        /// <summary>
        /// The data type is a long.
        /// </summary>
        Long,

        /// <summary>
        /// The data type is a long.
        /// </summary>
        SimplifiedLong,

        /// <summary>
        /// The data type is an integer.
        /// </summary>
        Int,

        /// <summary>
        /// The data type is an integer.
        /// </summary>
        SimplifiedInt,

        /// <summary>
        /// The data type is a boolean.
        /// </summary>
        Boolean,

        /// <summary>
        /// The data type is a date time.
        /// </summary>
        DateTime,

        /// <summary>
        /// The data type is XML
        /// </summary>
        Xml
    }
}
