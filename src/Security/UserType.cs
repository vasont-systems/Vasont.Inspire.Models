//-------------------------------------------------------------
// <copyright file="UserType.cs" company="GlobalLink Vasont">
// Copyright (c) GlobalLink Vasont. All rights reserved.
// </copyright>
//-------------------------------------------------------------
namespace Vasont.Inspire.Models.Security
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    /// <summary>
    /// Contains an enumerated list of inspire users types.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum UserType
    {
        /// <summary>
        /// User is a basic user.
        /// </summary>
        Standard = 1,

        /// <summary>
        /// User is a basic Inspire seat license
        /// </summary>
        ReviewOnly = 2,

        /// <summary>
        /// User is a Vasont support user.
        /// </summary>
        Support = 3
    }
}