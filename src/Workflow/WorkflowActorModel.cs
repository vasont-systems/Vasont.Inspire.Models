//------------------------------------------------------------------
// <copyright file="WorkflowActorModel.cs" company="GlobalLink Vasont">
// Copyright (c) GlobalLink Vasont. All rights reserved.
// </copyright>
//------------------------------------------------------------------
namespace Vasont.Inspire.Models.Workflow
{
    using System;
    using System.Collections.Generic;
    using System.Xml.Serialization;
    using Common;

    /// <summary>
    /// This class represents an actor within a workflow
    /// </summary>
    [XmlType("Actor")]
    public class WorkflowActorModel
    {
        /// <summary>
        /// Gets or sets the actor unique identity value.
        /// </summary>
        [XmlAttribute(AttributeName = "id")]
        public string WorkflowActorId { get; set; } = "_" + Guid.NewGuid();

        /// <summary>
        /// Gets or sets the associated workflow identity.
        /// </summary>
        public string WorkflowId { get; set; }

        /// <summary>
        /// Gets or sets the actor name.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this actor contains a member that will be the coordinator.
        /// </summary>
        public bool IsCoordinator { get; set; }

        /// <summary>
        /// Gets or sets the actor description.
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets a list of <see cref="WorkflowMemberModel"/> models.
        /// These members will be set by the process that implements workflow, such as project assignments.
        /// </summary>
        public List<WorkflowMemberModel> Members { get; set; } = new List<WorkflowMemberModel>();

        /// <summary>
        /// Gets or sets the coordinates.
        /// </summary>
        public CoordinatesModel Coordinates { get; set; } = new CoordinatesModel();
    }
}