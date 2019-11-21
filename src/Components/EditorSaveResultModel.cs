//-----------------------------------------------------------------
// <copyright file="EditorSaveResultModel.cs" company="GlobalLink Vasont">
// Copyright (c) GlobalLink Vasont. All rights reserved.
// </copyright>
//-----------------------------------------------------------------
namespace Vasont.Inspire.Models.Components
{
    /// <summary>
    /// This class contains properties related to the saving of content from an editor save request.
    /// </summary>
    public class EditorSaveResultModel
    {
        /// <summary>
        /// Gets or sets a value indicating whether the content was successfully saved.
        /// </summary>
        public bool Success { get; set; }

        /// <summary>
        /// Gets or sets the content type used for streaming back content.
        /// </summary>
        public string ContentType { get; set; }

        /// <summary>
        /// Gets or sets the file name to use for streaming back content.
        /// </summary>
        public string FileName { get; set; }

        /// <summary>
        /// Gets or sets the component identity to use for streaming back content.
        /// </summary>
        public long ComponentId { get; set; }
    }
}
