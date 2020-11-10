//-----------------------------------------------------------------------
// <copyright file="ComponentPreviewTransformModel.cs" company="GlobalLink Vasont">
// Copyright (c) GlobalLink Vasont. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------
namespace Vasont.Inspire.Models.Components
{
    using System;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    /// <summary>
    /// Contains an enumerated list of process types.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum ComponentProcessType
    {
        /// <summary>
        /// Contains a value that indicates the processtype is view.
        /// </summary>
        View,

        /// <summary>
        /// Contains a value that indicates the processtype is translation.
        /// </summary>
        Translation
    }

    /// <summary>
    /// This class represents a component preview transform within the system and is to be used for interaction with application user interfaces.
    /// </summary>
    public class ComponentPreviewTransformModel
    {
        /// <summary>
        /// Gets or sets the identity of the component preview transform.
        /// </summary>
        public long ComponentPreviewTransformId { get; set; }

        /// <summary>
        /// Gets or sets the name of the component preview transform.
        /// </summary>
        public string ComponentPreviewTransformName { get; set; }

        /// <summary>
        /// Gets or sets the create date of the component preview transform.
        /// </summary>
        public DateTime CreateDate { get; set; }

        /// <summary>
        /// Gets or sets the identity of the component type of the component preview transform.
        /// </summary>
        public long ComponentTypeId { get; set; }

        /// <summary>
        /// Gets or sets the process type of the component preview transform.
        /// </summary>
        public string ProcessType { get; set; }

        /// <summary>
        /// Gets or sets the XSLT of the component preview transform.
        /// </summary>
        public string XSLT { get; set; }

        /// <summary>
        /// Gets or sets the CSS of the component preview transform.
        /// </summary>
        public string CSS { get; set; }
    }
}
