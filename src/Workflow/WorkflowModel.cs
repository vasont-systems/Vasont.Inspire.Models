//-------------------------------------------------------------
// <copyright file="WorkflowModel.cs" company="GlobalLink Vasont">
// Copyright (c) GlobalLink Vasont. All rights reserved.
// </copyright>
//-------------------------------------------------------------
namespace Vasont.Inspire.Models.Workflow
{
    using System;
    using System.Collections.Generic;
    using System.Xml.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    /// <summary>
    /// Contains an enumerated list of workflow states.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum WorkflowState
    {
        /// <summary>
        /// The project workflow is executing.
        /// </summary>
        Executing,

        /// <summary>
        /// The project workflow has been completed.
        /// </summary>
        Completed,

        /// <summary>
        /// The project workflow has been cancelled.
        /// </summary>
        Cancelled
    }

    /// <summary>
    /// Contains an enumerated list of workflow types.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum WorkflowType
    {
        /// <summary>
        /// The workflow is related to project assignments.
        /// </summary>
        Project,

        /// <summary>
        /// The workflow is related to a review.
        /// </summary>
        Review
    }

    /// <summary>
    /// This class is a model representation of a workflow within the application.
    /// </summary>
    [XmlType("Workflow")]
    public class WorkflowModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WorkflowModel"/> class.
        /// </summary>
        public WorkflowModel()
        {
            this.WorkflowId = "_" + Guid.NewGuid().ToString();
            this.Actors = new List<WorkflowActorModel>();
            this.Statuses = new List<WorkflowStatusModel>();
            this.Activities = new List<WorkflowActivityModel>();
            this.Transitions = new List<WorkflowTransitionModel>();
            this.Actions = new List<WorkflowActionModel>();
        }
        
        /// <summary>
        /// Gets or sets the unique identity of the workflow.
        /// </summary>
        [XmlAttribute(AttributeName = "id")]
        public string WorkflowId { get; set; }

        /// <summary>
        /// Gets or sets the name of the workflow.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the description.
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets the workflow type.
        /// </summary>
        public WorkflowType WorkflowType { get; set; }

        /// <summary>
        /// Gets or sets a list of workflow actors.
        /// </summary>
        public List<WorkflowActorModel> Actors { get; set; }

        /// <summary>
        /// Gets or sets a list of workflow statuses.
        /// </summary>
        public List<WorkflowStatusModel> Statuses { get; set; }

        /// <summary>
        /// Gets or sets a list of workflow activities.
        /// </summary>
        public List<WorkflowActivityModel> Activities { get; set; }

        /// <summary>
        /// Gets or sets a list of workflow transitions.
        /// </summary>
        public List<WorkflowTransitionModel> Transitions { get; set; }

        /// <summary>
        /// Gets or sets a list of workflow actions.
        /// </summary>
        public List<WorkflowActionModel> Actions { get; set; }
    }
}