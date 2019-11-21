//----------------------------------------------------------------
// <copyright file="SystemEventModel.cs" company="GlobalLink Vasont">
// Copyright (c) GlobalLink Vasont. All rights reserved.
// </copyright>
//----------------------------------------------------------------
namespace Vasont.Inspire.Models.Plugins
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    /// <summary>
    /// Contains an enumerated list of system event names.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum SystemEventName
    {
        /// <summary>
        /// The system event used after files are exported.
        /// </summary>
        PostExport,

        /// <summary>
        /// The system event used before files are exported.
        /// </summary>
        PriorExport,

        /// <summary>
        /// The system event used after files are imported.
        /// </summary>
        PostImport,

        /// <summary>
        /// The system event used before files are imported.
        /// </summary>
        PriorImport,
    }

    /// <summary>
    /// This class represents a system event within the application.
    /// </summary>
    public class SystemEventModel
    {
        /// <summary>
        /// Gets or sets the identity of the system event.
        /// </summary>
        public long SystemEventId { get; set; }

        /// <summary>
        /// Gets or sets the name of the system event.
        /// </summary>
        public SystemEventName Name { get; set; }
    }
}