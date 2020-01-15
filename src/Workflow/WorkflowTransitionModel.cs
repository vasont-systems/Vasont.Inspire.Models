//-----------------------------------------------------------------------
// <copyright file="WorkflowTransitionModel.cs" company="GlobalLink Vasont">
// Copyright (c) GlobalLink Vasont. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace Vasont.Inspire.Models.Workflow
{
    using System;
    using System.Xml.Serialization;
    using Common;

    /// <summary>
    /// This class represents a workflow transition within the application.
    /// </summary>
    [XmlType("Transition")]
    public class WorkflowTransitionModel
    {
        /// <summary>
        /// Gets or sets the unique identity of the workflow transition.
        /// </summary>
        [XmlAttribute(AttributeName = "id")]
        public string WorkflowTransitionId { get; set; } = "_" + Guid.NewGuid();

        /// <summary>
        /// Gets or sets the unique identity of the associated workflow.
        /// </summary>
        public string WorkflowId { get; set; }

        /// <summary>
        /// Gets or sets the name of the transition.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the description of the transition.
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets the activity identity that the transition is coming from.
        /// </summary>
        public string FromActivityId { get; set; }

        /// <summary>
        /// Gets or sets the activity identity that the transition is going to.
        /// </summary>
        public string ToActivityId { get; set; }

        /// <summary>
        /// Gets or sets the identity of an optional action that is associated with this transition.
        /// </summary>
        public string ActionId { get; set; }

        /// <summary>
        /// Gets or sets the coordinates.
        /// </summary>
        public CoordinatesModel Coordinates { get; set; } = new CoordinatesModel();
    }
}