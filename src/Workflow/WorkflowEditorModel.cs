//-----------------------------------------------------------------------
// <copyright file="WorkflowEditorModel.cs" company="GlobalLink Vasont">
// Copyright (c) GlobalLink Vasont. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------
namespace Vasont.Inspire.Models.Workflow
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using Vasont.Inspire.Models.Components;

    /// <summary>
    /// Contains an enumerated list of workflow editor actions to execute.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum WorkflowEditorActionType
    {
        /// <summary>
        /// No action. Commonly set by default.
        /// </summary>
        None,

        /// <summary>
        /// Save the contents to a temporary storage area.
        /// </summary>
        Save,

        /// <summary>
        /// Save the contents and submit back into the repository overwriting the previous contents.
        /// </summary>
        SaveAndSubmit,

        /// <summary>
        /// Save the contents and submit back into the repository as a new component.
        /// </summary>
        SaveAs,

        /// <summary>
        /// Save the contents to a temporary storage area and download the contents to a local disk file.
        /// </summary>
        Download
    }

    /// <summary>
    /// This class represents the workflow editor model for interacting with a workflow component within the application.
    /// </summary>
    public class WorkflowEditorModel : MinimalComponentModel
    {
        /// <summary>
        /// Gets or sets a value indicating whether the editor should be in read-only mode.
        /// </summary>
        public bool ReadOnly { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the model contents have changed.
        /// </summary>
        public bool Dirty { get; set; }

        /// <summary>
        /// Gets or sets the original file name of the component for a save as allowing for the repair of any future workflow linking references.
        /// </summary>
        public string OriginalFileName { get; set; }

        /// <summary>
        /// Gets or sets the workflow type.
        /// </summary>
        public WorkflowType WorkflowType { get; set; } = WorkflowType.Project;

        /// <summary>
        /// Gets or sets the workflow editor action type.
        /// </summary>
        public WorkflowEditorActionType Action { get; set; } = WorkflowEditorActionType.None;

        /// <summary>
        /// Gets or sets the workflow model to be loaded into the editor interface.
        /// </summary>
        public WorkflowModel Model { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether or not the workflow should be a template.
        /// </summary>
        public bool CreateAsTemplate { get; set; }
    }
}