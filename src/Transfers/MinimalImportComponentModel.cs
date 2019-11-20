//-------------------------------------------------------------
// <copyright file="MinimalImportComponentModel.cs" company="Vasont Systems">
// Copyright (c) Vasont Systems. All rights reserved.
// </copyright>
//-------------------------------------------------------------

namespace Vasont.Inspire.Models.Transfers
{
    using System;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    /// <summary>
    /// Contains an enumerated list of actions to perform for the component.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum ComponentImportAction
    {
        /// <summary>
        /// Create a new component record.
        /// </summary>
        Create,

        /// <summary>
        /// Update an existing component.
        /// </summary>
        Update,

        /// <summary>
        /// The component exists, but there's no need to update content, so just ensure references are up to date.
        /// </summary>
        UpdateReferencesOnly,

        /// <summary>
        /// Do nothing with this content as it exists but nothing has changed.
        /// </summary>
        Ignore
    }

    /// <summary>
    /// This class contains the bare minimum properties of a import component model.
    /// </summary>
    public class MinimalImportComponentModel
    {
        /// <summary>
        /// Gets or sets the component identity of the component object if it has been defined.
        /// </summary>
        public long ComponentId { get; set; }

        /// <summary>
        /// Gets or sets the translation job component identifier.
        /// </summary>
        public long TranslationJobComponentId { get; set; }

        /// <summary>
        /// Gets or sets the unique identity of the component within the import
        /// </summary>
        public Guid UniqueId { get; set; }

        /// <summary>
        /// Gets or sets the action to perform for the component.
        /// </summary>
        public ComponentImportAction Action { get; set; }
        
        /// <summary>
        /// Gets or sets the original file name from import.
        /// </summary>
        public string OriginalFileName { get; set; }

        /// <summary>
        /// Gets or sets the new file name for Inspire storage and reference.
        /// </summary>
        public string FileName { get; set; }

        /// <summary>
        /// Gets or sets the last update date.
        /// </summary>
        public DateTime LastUpdateDate { get; set; }
    }
}
