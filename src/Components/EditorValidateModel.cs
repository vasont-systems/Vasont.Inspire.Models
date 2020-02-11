//-------------------------------------------------------------
// <copyright file="EditorValidateModel.cs" company="GlobalLink Vasont">
// Copyright (c) GlobalLink Vasont. All rights reserved.
// </copyright>
//-------------------------------------------------------------
namespace Vasont.Inspire.Models.Components
{
    using Newtonsoft.Json;

    /// <summary>
    /// This class represents a collection of properties used for xml validation.
    /// </summary>
    public class EditorValidateModel
    {
        /// <summary>
        /// Gets or sets a value indicating validation schema.
        /// </summary>
        [JsonProperty(PropertyName = "schema")]
        public string Schema { get; set; }

        /// <summary>
        /// Gets or sets a value containing xml content.
        /// </summary>
        [JsonProperty(PropertyName = "xml")]
        public string Xml { get; set; }
    }
}