//------------------------------------------------------------------------
// <copyright file="NewComponentRequestModel.cs" company="GlobalLink Vasont">
// Copyright (c) GlobalLink Vasont. All rights reserved.
// </copyright>
//------------------------------------------------------------------------
namespace Vasont.Inspire.Models.Webhooks
{
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
    }
}
