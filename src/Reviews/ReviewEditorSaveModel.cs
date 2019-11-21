//---------------------------------------------------------------------
// <copyright file="ReviewEditorSaveModel.cs" company="GlobalLink Vasont">
// Copyright (c) GlobalLink Vasont. All rights reserved.
// </copyright>
//---------------------------------------------------------------------
namespace Vasont.Inspire.Models.Reviews
{
    /// <summary>
    /// This class represents a collection of values submitted to the application during the save command for storing review editor content.
    /// </summary>
    public class ReviewEditorSaveModel
    {
        /// <summary>
        /// Gets or sets the review component identity to save.
        /// </summary>
        public long ComponentId { get; set; }

        /// <summary>
        /// Gets or sets the editor HTML content sent from the editor to be converted back to XML and saved.
        /// </summary>
        public string Html { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the editor was dirty when the submittal was made. This value prevents unnecessary saves made through save and submit action
        /// if no content had actually changed.
        /// </summary>
        public bool EditorIsDirty { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the converted XML shall be streamed back to the calling editor.
        /// </summary>
        public bool DownloadResult { get; set; }
    }
}