//---------------------------------------------------------------------------
// <copyright file="ChangeComponentRequestModel.cs" company="GlobalLink Vasont">
// Copyright (c) GlobalLink Vasont. All rights reserved.
// </copyright>
//---------------------------------------------------------------------------
namespace Vasont.Inspire.Models.Webhooks
{
    using System;
    using System.Collections.Generic;
    using Microsoft.AspNetCore.Http;

    /// <summary>
    /// This class contains the model used for a component change request.
    /// </summary>
    [Obsolete("Vasont.Inspire.Models.Webhooks.ChangeComponentRequestModel is deprecated. Please use Vasont.Inspire.Shared.Models/Webhook.ChangeComponentRequestDto instead.")]

    public class ChangeComponentRequestModel : ComponentRequestModel
    {
        /// <summary>
        /// Gets or sets the value that will be used to identify the component.
        /// </summary>
        public string ComponentIdentifier { get; set; }

        /// <summary>
        /// Gets or sets the comment related to the change request.
        /// </summary>
        public string Comment { get; set; }

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