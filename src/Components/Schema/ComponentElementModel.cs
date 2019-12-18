//-------------------------------------------------------------
// <copyright file="ComponentElementModel.cs" company="GlobalLink Vasont">
// Copyright (c) GlobalLink Vasont. All rights reserved.
// </copyright>
//-------------------------------------------------------------
namespace Vasont.Inspire.Models.Components.Schema
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    /// <summary>
    /// Contains an enumerated list of element mode roles.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum ComponentConfigurationElementModeRole
    {
        /// <summary>
        /// Element cannot contain any sub-elements or text.
        /// </summary>
        Empty,

        /// <summary>
        /// Element can only contain block elements.
        /// </summary>
        Container,

        /// <summary>
        /// Element can contain text with inline elements
        /// </summary>
        Mixed,

        /// <summary>
        /// Element can contain block elements, and text with in-line elements for styling.
        /// </summary>
        MixedWithStyling,

        /// <summary>
        /// Element can contain block elements and text with inline elements
        /// </summary>
        MixedContainer
    }

    /// <summary>
    /// Contains an enumerated list of map configuration element types used for determining how the element shall be rendered.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum ComponentConfigurationElementType
    {
        /// <summary>
        /// The root element in a map configuration. Typically always Map.
        /// </summary>
        Root,

        /// <summary>
        /// A basic element within the map.
        /// </summary>
        Element,

        /// <summary>
        /// An element that references another target component
        /// </summary>
        Target,

        /// <summary>
        /// An element that contains other target elements
        /// </summary>
        TargetGroup,

        /// <summary>
        /// An element that contains metadata information
        /// </summary>
        Meta,

        /// <summary>
        /// An element that contains other metadata elements.
        /// </summary>
        MetaGroup,

        /// <summary>
        /// An element that references another target component key definition
        /// </summary>
        KeyTarget
    }

    /// <summary>
    /// This class defines the properties of a map element configuration model.
    /// </summary>
    public class ComponentElementModel
    {
        /// <summary>
        /// Gets or sets the unique identity of the element definition.
        /// </summary>
        [JsonIgnore]
        public long InternalId { get; set; }

        /// <summary>
        /// Gets or sets the element identity value for the configuration output.
        /// </summary>
        public string ElementId { get; set; }

        /// <summary>
        /// Gets or sets the display name of the element definition.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the XML rendering name of the element definition.
        /// </summary>
        public string XmlName { get; set; }

        /// <summary>
        /// Gets or sets the element definition type.
        /// </summary>
        public ComponentConfigurationElementType Type { get; set; } = ComponentConfigurationElementType.Element;

        /// <summary>
        /// Gets or sets the element definition role.
        /// </summary>
        public ComponentConfigurationElementModeRole Role { get; set; } = ComponentConfigurationElementModeRole.Empty;

        /// <summary>
        /// Gets or sets a list of available element attributes
        /// </summary>
        public List<ComponentAttributeModel> Attributes { get; set; } = new List<ComponentAttributeModel>();

        /// <summary>
        /// Gets or sets the root contains rule model
        /// </summary>
        public List<ComponentElementContainsRuleModel> Contains { get; set; } = new List<ComponentElementContainsRuleModel>();
    }
}