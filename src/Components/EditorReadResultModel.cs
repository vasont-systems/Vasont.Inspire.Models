//-----------------------------------------------------------------------
// <copyright file="EditorReadResultModel.cs" company="GlobalLink Vasont">
// Copyright (c) GlobalLink Vasont. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------
namespace Vasont.Inspire.Models.Components
{
    /// <summary>
    /// This class contains values used within the Editor Component Service.
    /// </summary>
    public class EditorReadResultModel
    { 
        /// <summary>
        /// Gets or sets the component type.
        /// </summary>
        public string ContentType { get; set; }

        /// <summary>
        /// Gets or sets the component file name.
        /// </summary>
        public string FileName { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the result is binary.
        /// </summary>
        public bool IsBinary { get; set; }

        /// <summary>
        /// Gets or sets a component lock model for the content to be read.
        /// </summary>
        public ComponentLockModel Lock { get; set; } = new ComponentLockModel();
    }
}
