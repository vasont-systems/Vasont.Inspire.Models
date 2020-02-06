//-------------------------------------------------------------
// <copyright file="EditorValidateResultModel.cs" company="GlobalLink Vasont">
// Copyright (c) GlobalLink Vasont. All rights reserved.
// </copyright>
//-------------------------------------------------------------
namespace Vasont.Inspire.Models.Components
{
    using Newtonsoft.Json;
    using System.Net;

    /// <summary>
    /// This class represents a collection of properties used for xml validation.
    /// </summary>
    public class EditorValidateResultModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EditorValidateResultModel"/> class.
        /// </summary>
        public EditorValidateResultModel()
        {
            this.Error = new EditorXmlErrorModel();
            this.Status = HttpStatusCode.OK;
            this.Text = "VALID XML";
            this.Valid = true;
        }

        /// <summary>
        /// Gets or sets the validation error message.
        /// </summary>
        [JsonProperty(PropertyName = "error")]
        public EditorXmlErrorModel Error { get; set; }

        /// <summary>
        /// Gets or sets the status of the validation request.
        /// </summary>
        [JsonProperty(PropertyName = "status")]
        public HttpStatusCode Status { get; set; }

        /// <summary>
        /// Gets or sets the error type text.
        /// </summary>
        [JsonProperty(PropertyName = "text")]
        public string Text { get; set; }

        /// <summary>
        /// Gets or sets xml returned to editor.
        /// </summary>
        [JsonProperty(PropertyName = "xml")]
        public string Xml { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether xml is valid.
        /// </summary>
        [JsonProperty(PropertyName = "valid")]
        public bool Valid { get; set; }
    }
}