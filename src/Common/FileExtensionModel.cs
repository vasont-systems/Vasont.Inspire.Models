//-------------------------------------------------------------
// <copyright file="FileExtensionModel.cs" company="GlobalLink Vasont">
// Copyright (c) GlobalLink Vasont. All rights reserved.
// </copyright>
//-------------------------------------------------------------
namespace Vasont.Inspire.Models.Common
{
    using System;

    /// <summary>
    /// This class is a model representation of a file extension definition within the application.
    /// </summary>
    [Obsolete("Use local DTOs", false)]
    public class FileExtensionModel
    {
        /// <summary>
        /// Gets or sets the file extension unique identity value.
        /// </summary>
        public long FileExtensionId { get; set; }

        /// <summary>
        /// Gets or sets the file extension value.
        /// </summary>
        public string FileExtensionValue { get; set; }

        /// <summary>
        /// Gets or sets the component type description.
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets the XML DTD document type used to identify the XML-based component type.
        /// </summary>
        public string MimeType { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the component type is a default.
        /// </summary>
        public bool Blacklisted { get; set; }
    }
}