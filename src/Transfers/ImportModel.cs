//-------------------------------------------------------------
// <copyright file="ImportModel.cs" company="GlobalLink Vasont">
// Copyright (c) GlobalLink Vasont. All rights reserved.
// </copyright>
//-------------------------------------------------------------
namespace Vasont.Inspire.Models.Transfers
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using Vasont.Inspire.Models.Plugins;

    /// <summary>
    /// Contains an enumerated list of import types.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum ImportType
    {
        /// <summary>
        /// The import is standard.
        /// </summary>
        Standard,

        /// <summary>
        /// The import is used to edit.
        /// </summary>
        Edit,

        /// <summary>
        /// The import is used to translate.
        /// </summary>
        Translate
    }

    /// <summary>
    /// This class represents an import model for use within the application.
    /// </summary>
    public class ImportModel
    {
        /// <summary>
        /// Gets or sets the unique identity of the import.
        /// </summary>
        public long ImportId { get; set; }

        /// <summary>
        /// Gets or sets the name of the import.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets a description of the import.
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the import is currently active.
        /// </summary>
        public bool Active { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this is a default import.
        /// </summary>
        public bool Default { get; set; }

        /// <summary>
        /// Gets or sets the import type.
        /// </summary>
        public ImportType Type { get; set; } = ImportType.Standard;

        /// <summary>
        /// Gets or sets a list of <see cref="ImportPluginModel"/> objects that are to be used with the import.
        /// </summary>
        public List<ImportPluginModel> Plugins { get; set; } = new List<ImportPluginModel>();
    }
}
