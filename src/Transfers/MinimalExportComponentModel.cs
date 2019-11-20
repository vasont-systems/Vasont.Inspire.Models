//-------------------------------------------------------------
// <copyright file="MinimalExportComponentModel.cs" company="Vasont Systems">
// Copyright (c) Vasont Systems. All rights reserved.
// </copyright>
//-------------------------------------------------------------
namespace Vasont.Inspire.Models.Transfers
{
    using System;
    using System.Collections.Generic;
    using System.Xml.Linq;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using Vasont.Inspire.Models.Components;

    /// <summary>
    /// Contains an enumerated set of export content results.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum ExportContentResult
    {
        /// <summary>
        /// The component content was successfully exported to the working folder.
        /// </summary>
        Success,

        /// <summary>
        /// The component content failed to be exported to the working folder.
        /// </summary>
        Failed,

        /// <summary>
        /// The component content was successfully exported but was modified due to filtering and therefore
        /// the component should be flagged as needing relationship evaluation before export can complete.
        /// </summary>
        Modified,

        /// <summary>
        /// The component content was successfully exported but the content was filtered and therefore 
        /// the component should be removed from the export.
        /// </summary>
        Removed
    }

    /// <summary>
    /// This contains the minimal export component model needed.
    /// </summary>
    public class MinimalExportComponentModel
    {
        /// <summary>
        /// Gets or sets the changeset identity.
        /// </summary>
        public Guid ChangesetId { get; set; }

        /// <summary>
        /// Gets or sets the unique identity of the component.
        /// </summary>
        public long ComponentId { get; set; }

        /// <summary>
        /// Gets or sets the file name of the component.
        /// </summary>
        public string FileName { get; set; }

        /// <summary>
        /// Gets or sets the language code.
        /// </summary>
        public string LanguageCode { get; set; }

        /// <summary>
        /// Gets or sets the component type.
        /// </summary>
        public ComponentTypeModel ComponentType { get; set; }

        /// <summary>
        /// Gets or sets a list of filtered elements.
        /// </summary>
        public List<XElement> FilteredElements { get; set; } = new List<XElement>();

        /// <summary>
        /// Gets or sets a value indicating whether the module had recent changes that require reprocessing.
        /// </summary>
        public bool RequiresProcessing { get; set; }

        /// <summary>
        /// Gets or sets the export content result state.
        /// </summary>
        public ExportContentResult ExportResult { get; set; }

        /// <summary>
        /// Gets or sets the file and path of the component.
        /// </summary>
        [JsonIgnore]
        public string ExtractedFilePath { get; set; }

        /// <summary>
        /// Gets or sets the created date.
        /// </summary>
        public DateTime CreatedDate { get; set; }

        /// <summary>
        /// Gets or sets the updated date.
        /// </summary>
        public DateTime UpdatedDate { get; set; }

        /// <summary>
        /// Gets or sets a list of filtered references.
        /// </summary>
        public List<long> FilteredTargetIds { get; set; } = new List<long>();
    }
}
