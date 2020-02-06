//-----------------------------------------------------------------------
// <copyright file="EditorXmlErrorModel.cs" company="GlobalLink Vasont">
//     Copyright (c) GlobalLink Vasont. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------
namespace Vasont.Inspire.Models.Components
{
    using Newtonsoft.Json;

    /// <summary>
    /// This class contains values used for an xml validation error.
    /// </summary>
    public class EditorXmlErrorModel
    {
        /// <summary>
        /// Gets or sets the validation error message.
        /// </summary>
        [JsonProperty(PropertyName = "text")]
        public string Text { get; set; }

        /// <summary>
        /// Gets or sets the validation type.
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public string Type { get; set; }

        /// <summary>
        /// Gets or sets a value indicating the error row number.
        /// </summary>
        [JsonProperty(PropertyName = "row")]
        public long Row { get; set; }

        /// <summary>
        /// Gets or sets a value indicating the error column number.
        /// </summary>
        [JsonProperty(PropertyName = "column")]
        public long Column { get; set; }
    }
}