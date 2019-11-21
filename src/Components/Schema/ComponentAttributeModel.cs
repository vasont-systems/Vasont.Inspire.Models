//-------------------------------------------------------------
// <copyright file="ComponentAttributeModel.cs" company="GlobalLink Vasont">
// Copyright (c) GlobalLink Vasont. All rights reserved.
// </copyright>
//-------------------------------------------------------------
namespace Vasont.Inspire.Models.Components.Schema
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    /// <summary>
    /// Contains an enumerated list of map configuration attribute types used for determining how the attribute value field shall 
    /// be rendered in the application.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum ComponentConfigurationAttributeType
    {
        /// <summary>
        /// The attribute is an identity type containing a unique identity for the element.
        /// </summary>
        Identity,

        /// <summary>
        /// The attribute contains a general string value.
        /// </summary>
        String,

        /// <summary>
        /// The attribute contains a boolean value.
        /// </summary>
        Boolean,

        /// <summary>
        /// The attribute contains a date value.
        /// </summary>
        Date,

        /// <summary>
        /// The attribute contains a date time value.
        /// </summary>
        DateTime,

        /// <summary>
        /// The attribute contains a number.
        /// </summary>
        Number,

        /// <summary>
        /// The attribute shall point to a component.
        /// </summary>
        Component,

        /// <summary>
        /// The attribute allows for multiple value selections.
        /// </summary>
        Multiselect
    }
    
    /// <summary>
    /// This class defines the properties of a map attribute configuration model.
    /// </summary>
    public class ComponentAttributeModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ComponentAttributeModel"/> class.
        /// </summary>
        public ComponentAttributeModel()
        {
            this.ValidValues = new List<KeyValuePair<string, string>>();
            this.ValidTypes = new List<string>();
            this.Type = ComponentConfigurationAttributeType.String;
        }

        /// <summary>
        /// Gets or sets the unique identity of the attribute.
        /// </summary>
        [JsonIgnore]
        public long InternalId { get; set; }

        /// <summary>
        /// Gets or sets the attribute identity name for use within the configuration output.
        /// </summary>
        public string AttributeId { get; set; }

        /// <summary>
        /// Gets or sets the simple display name of the attribute.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the XML rendering text for the attribute.
        /// </summary>
        public string XmlName { get; set; }

        /// <summary>
        /// Gets or sets the map attribute value type.
        /// </summary>
        public ComponentConfigurationAttributeType Type { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the attribute is required.
        /// </summary>
        public bool Required { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the attribute is read only.
        /// </summary>
        public bool ReadOnly { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the attribute is visible in the user interface.
        /// </summary>
        public bool Visible { get; set; }

        /// <summary>
        /// Gets or sets a sort order value for displaying the attribute.
        /// </summary>
        public int SortOrder { get; set; }

        /// <summary>
        /// Gets or sets an optional regular expression string for attribute value input validation.
        /// </summary>
        public string RegEx { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the attribute is globally applied to all elements in a configuration.
        /// </summary>
        [JsonIgnore]
        public bool Global { get; set; }

        /// <summary>
        /// Gets or sets the minimum allowed value for a numeric type attribute
        /// </summary>
        public int MinValue { get; set; }
        
        /// <summary>
        /// Gets or sets the maximum allowed value for a numeric type attribute.
        /// </summary>
        public int MaxValue { get; set; }

        /// <summary>
        /// Gets or sets a default value for the attribute.
        /// </summary>
        public string DefaultValue { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the attribute is configured for profiling.
        /// </summary>
        public bool Profiled { get; set; }

        /// <summary>
        /// Gets or sets a list of key value pair objects containing valid values and display text for the attribute.
        /// </summary>
        public List<KeyValuePair<string, string>> ValidValues { get; set; }

        /// <summary>
        /// Gets or sets a list of valid component types that the component type attributes can target.
        /// </summary>
        public List<string> ValidTypes { get; set; }

        /// <summary>
        /// This method is used by the serializer to determine if it is to be rendered.
        /// </summary>
        /// <returns>Returns a value indicating that the property should be rendered.</returns>
        public bool ShouldMinValue()
        {
            return this.Type == ComponentConfigurationAttributeType.Number;
        }

        /// <summary>
        /// This method is used by the serializer to determine if it is to be rendered.
        /// </summary>
        /// <returns>Returns a value indicating that the property should be rendered.</returns>
        public bool ShouldMaxValue()
        {
            return this.Type == ComponentConfigurationAttributeType.Number;
        }
    }
}