//-----------------------------------------------------------------------
// <copyright file="EditorLoadModel.cs" company="GlobalLink Vasont">
// Copyright (c) GlobalLink Vasont. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------
namespace Vasont.Inspire.Models.Components
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    /// <summary>
    /// Contains an enumerated list of external editor types.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum EditorType
    {
        /// <summary>
        /// Content is returned as plain XML.
        /// </summary>
        Generic,

        /// <summary>
        /// Content is transformed using XEditor-transforms to XEditor HTML editor standard.
        /// </summary>
        XEditor,

        /// <summary>
        /// Content is transformed using Oxygen WebApp-specific HTML editor standard.
        /// </summary>
        OxygenWeb,

        /// <summary>
        /// Content is transformed using AuthorBridge-specific HTML editor standard.
        /// </summary>
        AuthorBridge
    }

    /// <summary>
    /// Contains an enumerated list of editor modes.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum EditorMode
    {
        /// <summary>
        /// The editor is in editing mode.
        /// </summary>
        Edit,

        /// <summary>
        /// The editor is in viewing mode.
        /// </summary>
        View,

        /// <summary>
        /// The editor is in reviewing mode.
        /// </summary>
        Review
    }

    /// <summary>
    /// Contains an enumerated list of review editor modes.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum ReviewEditorMode
    {
        /// <summary>
        /// Mode not used.
        /// </summary>
        NotReview,

        /// <summary>
        /// Mode for an active reviewer with comment only rights.
        /// </summary>
        Annotate,

        /// <summary>
        /// Mode for an active reviewer with full review rights.
        /// </summary>
        Review,

        /// <summary>
        /// Mode for a coordinator when remove is in Resolving state.
        /// </summary>
        Resolve,

        /// <summary>
        /// Read only mode.
        /// </summary>
        View
    }

    /// <summary>
    /// This class represents the editor load parameters for an external editor query to load content from Inspire for editing/viewing.
    /// </summary>
    public class EditorLoadModel : BaseLoadModel
    {
        /// <summary>
        /// Gets or sets the editor type to use.
        /// </summary>
        public EditorType EditorType { get; set; } = EditorType.XEditor;

        /// <summary>
        /// Gets or sets the editor mode.
        /// </summary>
        public EditorMode EditorMode { get; set; } = EditorMode.Edit;

        /// <summary>
        /// Gets or sets the review editor mode.
        /// </summary>
        public ReviewEditorMode ReviewMode { get; set; } = ReviewEditorMode.NotReview;

        /// <summary>
        /// Gets or sets the schema type to use for transform.
        /// </summary>
        public string SchemaType { get; set; } = "dita";

        /// <summary>
        /// Gets or sets the schema version to use for transform.
        /// </summary>
        public string Version { get; set; } = "1_3";

        /// <summary>
        /// Gets or sets a value indicating whether references are resolved server-side.
        /// </summary>
        public bool ResolveReferences { get; set; }

        /// <summary>
        /// Gets or sets the map identity where the component was opened from.
        /// </summary>
        public long MapReferenceId { get; set; }
    }
}