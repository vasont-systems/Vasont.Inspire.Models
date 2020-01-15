//------------------------------------------------------------------
// <copyright file="WorkflowStatusModel.cs" company="GlobalLink Vasont">
// Copyright (c) GlobalLink Vasont. All rights reserved.
// </copyright>
//------------------------------------------------------------------

namespace Vasont.Inspire.Models.Workflow
{
    using System;
    using System.Xml.Serialization;
    using Common;

    /// <summary>
    /// This class represents a workflow state within a workflow.
    /// </summary>
    [XmlType("Status")]
    public class WorkflowStatusModel
    {
        /// <summary>
        /// Gets or sets the unique identity of the workflow status.
        /// </summary>
        [XmlAttribute(AttributeName = "id")]
        public string WorkflowStatusId { get; set; } = "_" + Guid.NewGuid();

        /// <summary>
        /// Gets or sets the unique identity of the workflow.
        /// </summary>
        public string WorkflowId { get; set; }

        /// <summary>
        /// Gets or sets the name of the workflow state.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the description of the workflow state.
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets the coordinates.
        /// </summary>
        public CoordinatesModel Coordinates { get; set; } = new CoordinatesModel();
    }
}