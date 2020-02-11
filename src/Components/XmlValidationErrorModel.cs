//-----------------------------------------------------------------------
// <copyright file="XmlValidationErrorModel.cs" company="GlobalLink Vasont">
// Copyright (c) GlobalLink Vasont. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------
namespace Vasont.Inspire.Models.Components
{
    /// <summary>
    /// This class is used as the Error Response Model
    /// </summary>
    public class XmlValidationErrorModel
    {
        /// <summary>
        /// Gets or sets a value indicating the Component Identity.
        /// </summary>
        public long ComponentId { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the component is a map.
        /// </summary>
        public bool IsMap { get; set; }

        /// <summary>
        /// Gets or sets a value indicating the Component Filename.
        /// </summary>
        public string FileName { get; set; }

        /// <summary>
        /// Gets or sets a value indicating the error line number.
        /// </summary>
        public int LineNumber { get; set; }

        /// <summary>
        /// Gets or sets a value indicating the error line position.
        /// </summary>
        public int LinePosition { get; set; }

        /// <summary>
        /// Gets or sets a value indicating the validation message.
        /// </summary>
        public string Message { get; set; }
    }
}