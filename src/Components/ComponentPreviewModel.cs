//-----------------------------------------------------------------------
// <copyright file="ComponentPreviewModel.cs" company="GlobalLink Vasont">
// Copyright (c) GlobalLink Vasont. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------
namespace Vasont.Inspire.Models.Components
{
    using System;

    /// <summary>
    /// This class represents a component preview.
    /// </summary>
    public class ComponentPreviewModel
    {
        /// <summary>
        /// Gets or sets the identity of the component preview.
        /// </summary>
        public long ComponentPreviewId { get; set; }

        /// <summary>
        /// Gets or sets the identity of the component for which the preview is for.
        /// </summary>
        public long ComponentId { get; set; }

        /// <summary>
        /// Gets or sets the content of the component preview that the transform could use.
        /// </summary>
        public string Content { get; set; }

        /// <summary>
        /// Gets or sets the created date of the component preview.
        /// </summary>
        public DateTime CreatedDate { get; set; }

        /// <summary>
        /// Gets or sets the last updated date of the component preview.
        /// </summary>
        public DateTime LastUpdatedDate { get; set; }
    }
}
