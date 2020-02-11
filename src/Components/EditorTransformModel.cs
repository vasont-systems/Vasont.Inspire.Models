//-------------------------------------------------------------
// <copyright file="EditorTransformModel.cs" company="GlobalLink Vasont">
// Copyright (c) GlobalLink Vasont. All rights reserved.
// </copyright>
//-------------------------------------------------------------
namespace Vasont.Inspire.Models.Components
{
    using Newtonsoft.Json;

    /// <summary>
    /// This class represents a collection of properties used to transform content between xml and html.
    /// </summary>
    public class EditorTransformModel
    {
        /// <summary>
        /// Gets or sets the content which may be xml or html.
        /// </summary>
        [JsonProperty(PropertyName = "content")]
        public string Content { get; set; }

        /// <summary>
        /// Gets or sets a value indicating transform from direction.
        /// </summary>
        [JsonProperty(PropertyName = "from")]
        public string From { get; set; }

        /// <summary>
        /// Gets or sets a value indicating transform to direction.
        /// </summary>
        [JsonProperty(PropertyName = "to")]
        public string To { get; set; }

        /// <summary>
        ///  Gets or sets a value indicating the component identifier.
        /// </summary>
        public long ComponentId { get; set; }

        /// <summary>
        ///  Gets or sets a value indicating the component filename.
        /// </summary>
        public string FileName { get; set; }

        /// <summary>
        ///  Gets or sets a value indicating whether to pretty print output.
        /// </summary>
        public bool PrettyPrint { get; set; }

        /// <summary>
        ///  Gets or sets a value indicating the component schema standard.
        /// </summary>
        public string SchemaStandard { get; set; }

        /// <summary>
        ///  Gets or sets a value indicating whether the transform is for submitted content.
        /// </summary>
        public bool Submit { get; set; }
    }
}