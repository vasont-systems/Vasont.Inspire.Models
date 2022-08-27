//-----------------------------------------------------------------------
// <copyright file="MultimediaLoadModel.cs" company="GlobalLink Vasont">
// Copyright (c) GlobalLink Vasont. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------
namespace Vasont.Inspire.Models.Components
{
    /// <summary>
    /// This class represents the editor load parameters for a call to retrieve a multimedia file from an external editor.
    /// </summary>
    public class MultimediaLoadModel : BaseLoadModel
    {
        /// <summary>
        /// Gets or sets a value indicating whether the image or video is returned as a thumbnail.
        /// </summary>
        public bool Thumbnail { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the preview should ignore the threshold.
        /// </summary>
        public bool IgnoreThreshold { get; set; }
    }
}
