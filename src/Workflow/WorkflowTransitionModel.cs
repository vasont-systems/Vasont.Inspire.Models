//-----------------------------------------------------------------------
// <copyright file="WorkflowTransitionModel.cs" company="Vasont Systems">
// Copyright (c) Vasont Systems. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace Vasont.Inspire.Models.Workflow
{
    using System;
    using System.Xml.Serialization;

    /// <summary>
    /// This class represents a workflow transition within the application.
    /// </summary>
    [XmlType("Transition")]
    public class WorkflowTransitionModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WorkflowTransitionModel"/> class.
        /// </summary>
        public WorkflowTransitionModel()
        {
            this.WorkflowTransitionId = "_" + Guid.NewGuid().ToString();
        }
        
        /// <summary>
        /// Gets or sets the unique identity of the workflow transition.
        /// </summary>
        [XmlAttribute(AttributeName = "id")]
        public string WorkflowTransitionId { get; set; }

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
    }
}