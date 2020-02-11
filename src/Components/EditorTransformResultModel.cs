//-------------------------------------------------------------
// <copyright file="EditorTransformResultModel.cs" company="GlobalLink Vasont">
// Copyright (c) GlobalLink Vasont. All rights reserved.
// </copyright>
//-------------------------------------------------------------
namespace Vasont.Inspire.Models.Components
{
    using Newtonsoft.Json;

    /// <summary>
    /// This class contains properties related to transforming content between html and xml.
    /// </summary>
    public class EditorTransformResultModel
    {
        /// <summary>
        /// Gets or sets a value indicating whether the content was successfully transformed.
        /// </summary>
        [JsonProperty(PropertyName = "success")]
        public bool Success { get; set; }

        /// <summary>
        /// Gets or sets the content string to be transformed.
        /// </summary>
        [JsonProperty(PropertyName = "content")]
        public string Content { get; set; }
    }
}