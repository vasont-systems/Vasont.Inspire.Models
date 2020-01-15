//-------------------------------------------------------------------
// <copyright file="WorkflowActionModel.cs" company="GlobalLink Vasont">
// Copyright (c) GlobalLink Vasont. All rights reserved.
// </copyright>
//-------------------------------------------------------------------
namespace Vasont.Inspire.Models.Workflow
{
    using System;
    using System.Xml.Serialization;
    using Common;

    /// <summary>
    /// This class is a model of a workflow action.
    /// </summary>
    [XmlType("Action")]
    public class WorkflowActionModel
    {
        /// <summary>
        /// Gets or sets the unique workflow action identity.
        /// </summary>
        [XmlAttribute(AttributeName = "id")]
        public string WorkflowActionId { get; set; } = "_" + Guid.NewGuid();

        /// <summary>
        /// Gets or sets the unique identity of the related workflow.
        /// </summary>
        public string WorkflowId { get; set; }

        /// <summary>
        /// Gets or sets the action name.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the action description.
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets the coordinates.
        /// </summary>
        public CoordinatesModel Coordinates { get; set; } = new CoordinatesModel();
    }
}