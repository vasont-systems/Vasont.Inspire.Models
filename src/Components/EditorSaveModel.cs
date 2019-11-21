//-------------------------------------------------------------
// <copyright file="EditorSaveModel.cs" company="GlobalLink Vasont">
// Copyright (c) GlobalLink Vasont. All rights reserved.
// </copyright>
//-------------------------------------------------------------
namespace Vasont.Inspire.Models.Components
{
    /// <summary>
    /// This class represents a collection of values submitted to the application during the save command for storing editor content.
    /// </summary>
    public class EditorSaveModel
    {
        /// <summary>
        /// Gets or sets the component identity to save.
        /// </summary>
        public long ComponentId { get; set; }

        /// <summary>
        /// Gets or sets the file name of the component to save.
        /// </summary>
        public string FileName { get; set; }

        /// <summary>
        /// Gets or sets the original file name of the component for a save as.
        /// </summary>
        public string OriginalFileName { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the save shall submit the contents back into the available storage area.
        /// </summary>
        public bool Submit { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the save is a save as.
        /// </summary>
        public bool SaveAs { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the save shall submit the contents back into the available storage and complete any associated project tasks.
        /// </summary>
        public bool Complete { get; set; }

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

        /// <summary>
        /// Gets or sets a value indicating whether the save will generate identity attributes based on schema specific requirements.
        /// </summary>
        public bool GenerateIdAttributes { get; set; }
    }
}
