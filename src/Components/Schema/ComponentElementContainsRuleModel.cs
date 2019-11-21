//-------------------------------------------------------------
// <copyright file="ComponentElementContainsRuleModel.cs" company="GlobalLink Vasont">
// Copyright (c) GlobalLink Vasont. All rights reserved.
// </copyright>
//-------------------------------------------------------------
namespace Vasont.Inspire.Models.Components.Schema
{ 
    /// <summary>
    /// This class represents a component element rule model for a component configuration.
    /// </summary>
    public class ComponentElementContainsRuleModel
    {
        /// <summary>
        /// Gets or sets the unique identity of the element the rule applies to.
        /// </summary>
        public long ElementRuleId { get; set; }
        
        /// <summary>
        /// Gets or sets the element identity that the rule applies to.
        /// </summary>
        public string ElementId { get; set; }

        /// <summary>
        /// Gets or sets the minimum number of instances the element must be used. Minimum > 0 = Required.
        /// </summary>
        public int Minimum { get; set; }

        /// <summary>
        /// Gets or sets the maximum number of instances of the element allowed.
        /// </summary>
        public int Maximum { get; set; }

        /// <summary>
        /// Gets a value indicating whether the element is required.
        /// </summary>
        public bool Required => this.Minimum > 0;
        
        /// <summary>
        /// Gets or sets the rendering sequence order. O means no order necessary.
        /// </summary>
        public int SequenceOrder { get; set; }
        
        /// <summary>
        /// This method is called by the serializer to determine if the property Permissions should be rendered.
        /// </summary>
        /// <returns>Returns a value indicating whether to render the related property.</returns>
        public bool ShouldRequired()
        {
            return this.Required;
        }
    }
}