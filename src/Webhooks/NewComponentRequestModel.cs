//------------------------------------------------------------------------
// <copyright file="NewComponentRequestModel.cs" company="GlobalLink Vasont">
// Copyright (c) GlobalLink Vasont. All rights reserved.
// </copyright>
//------------------------------------------------------------------------
namespace Vasont.Inspire.Models.Webhooks
{
    using System.Collections.Generic;
    using Microsoft.AspNetCore.Http;

    /// <summary>
    /// This class contains the model used for a new component request.
    /// </summary>
    public class NewComponentRequestModel : ComponentRequestModel
    {
        /// <summary>
        /// Gets or sets the name of the template that was used for the request.
        /// </summary>
        public string TemplateName { get; set; }

        /// <summary>
        /// Gets or sets a list of file names that are being submitted for new content.
        /// </summary>
        public string FileName { get; set; }

        /// <summary>
        /// Gets or sets the title of the new content that will be used to name the new component.
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Gets or sets a file object for new content.
        /// </summary>
        public IFormFile File { get; set; }

        /// <summary>
        /// Gets or sets a list of form file objects.
        /// </summary>
        public List<IFormFile> Attachments { get; set; } = new List<IFormFile>();

        /// <summary>
        /// Gets or sets a list of file paths.
        /// </summary>
        public List<string> FilePaths { get; set; } = new List<string>();
    }
}
