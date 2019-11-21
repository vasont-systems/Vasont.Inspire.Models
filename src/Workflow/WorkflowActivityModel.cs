//---------------------------------------------------------------------
// <copyright file="WorkflowActivityModel.cs" company="GlobalLink Vasont">
// Copyright (c) GlobalLink Vasont. All rights reserved.
// </copyright>
//---------------------------------------------------------------------
namespace Vasont.Inspire.Models.Workflow
{
    using System;
    using System.Collections.Generic;
    using System.Xml.Serialization;

    /// <summary>
    /// This class is a model of a workflow activity.
    /// </summary>
    [XmlType("Activity")]
    public class WorkflowActivityModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WorkflowActivityModel"/> class.
        /// </summary>
        public WorkflowActivityModel()
        {
            this.WorkflowActivityId = "_" + Guid.NewGuid().ToString();
            this.Events = new List<WorkflowActivityEventModel>();
            this.ActorIds = new List<string>();
            this.State = WorkflowState.Executing;
        }
        
        /// <summary>
        /// Gets or sets the unique workflow activity identity.
        /// </summary>
        [XmlAttribute(AttributeName = "id")]
        public string WorkflowActivityId { get; set; }

        /// <summary>
        /// Gets or sets the unique identity of the related workflow.
        /// </summary>
        public string WorkflowId { get; set; }

        /// <summary>
        /// Gets or sets the activity name.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the activity description.
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the activity is the initial first step in a workflow.
        /// </summary>
        public bool IsInitial { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the activity is the final first step in a workflow.
        /// </summary>
        public bool IsFinal { get; set; }

        /// <summary>
        /// Gets or sets the workflow state to set once the activity has been initiated.
        /// </summary>
        public WorkflowState State { get; set; }

        /// <summary>
        /// Gets or sets the workflow status identity to set once the activity has been initiated.
        /// </summary>
        public string StatusId { get; set; }

        /// <summary>
        /// Gets or sets a list of activity events.
        /// </summary>
        public List<WorkflowActivityEventModel> Events { get; set; }

        /// <summary>
        /// Gets or sets a list of workflow actor identities associated with this activity.
        /// </summary>
        [XmlArrayItem("ActorId")]
        public List<string> ActorIds { get; set; }

        /// <summary>
        /// Gets or sets a comma delimited list of workflow actor names associated with this activity.
        /// </summary>
        [XmlIgnore]
        public string ActorNames { get; set; }

        /// <summary>
        /// Gets or sets the identity of a project activity.
        /// This is specific to workflow activities related to project assignments.
        /// </summary>
        public long ProjectActivityId { get; set; }

        /// <summary>
        /// Gets or sets the number of minutes past the start date that the workflow activity will be due.
        /// </summary>
        public int DefaultDurationMinutes { get; set; }
    }
}