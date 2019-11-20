//----------------------------------------------------------------
// <copyright file="MapNodeModel.cs" company="Vasont Systems">
// Copyright (c) Vasont Systems. All rights reserved.
// </copyright>
//----------------------------------------------------------------
namespace Vasont.Inspire.Models.Components
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    /// <summary>
    /// Contains an enumerated list of map node types.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum MapNodeType
    {
        /// <summary>
        /// This refers to an XML element.
        /// </summary>
        Element,

        /// <summary>
        /// This refers to an XML comment.
        /// </summary>
        Comment,

        /// <summary>
        /// This refers to an XML processing instruction.
        /// </summary>
        ProcessingInstruction
    }

    /// <summary>
    /// This class represents a map element within the application.
    /// </summary>
    public class MapNodeModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MapNodeModel"/> class.
        /// </summary>
        public MapNodeModel()
        {
            this.ChildNodes = new List<MapNodeModel>();
            this.Attributes = new List<MapAttributeModel>();
            this.Type = MapNodeType.Element;
            this.Metadata = new MapNodeUiMetadataModel();
        }

        /// <summary>
        /// Gets or sets the unique identifier of the model node.
        /// </summary>
        [JsonProperty(Order = 1)]
        public string NodeId { get; set; }

        /// <summary>
        /// Gets or sets the parent model node identity value.
        /// </summary>
        [JsonProperty(Order = 2)]
        public string ParentNodeId { get; set; }

        /// <summary>
        /// Gets or sets the node name.
        /// </summary>
        [JsonProperty(Order = 3)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the text of the node.
        /// </summary>
        public string InnerText { get; set; }

        /// <summary>
        /// Gets or sets the type of the node.
        /// </summary>
        public MapNodeType Type { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this is a tracked element within the Inspire map configuration.
        /// </summary>
        public bool IsTracked { get; set; }

        /// <summary>
        /// Gets or sets the element metadata related to the component configuration data.
        /// </summary>
        public MapNodeUiMetadataModel Metadata { get; set; }

        /// <summary>
        /// Gets or sets a Target component model
        /// </summary>
        public MapTargetModel Target { get; set; }

        /// <summary>
        /// Gets or sets a list of <see cref="MapAttributeModel"/> objects representing populated attributes for this element.
        /// </summary>
        public List<MapAttributeModel> Attributes { get; set; }

        /// <summary>
        /// Gets or sets a list of <see cref="MapNodeModel"/> objects representing children elements.
        /// </summary>
        public List<MapNodeModel> ChildNodes { get; set; }
    }
}