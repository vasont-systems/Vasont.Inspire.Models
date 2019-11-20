//-------------------------------------------------------------------------
// <copyright file="WorkflowActivityEventModel.cs" company="Vasont Systems">
// Copyright (c) Vasont Systems. All rights reserved.
// </copyright>
//--------------------------------------------------------------------------
namespace Vasont.Inspire.Models.Workflow
{
    using System.Xml.Serialization;

    /// <summary>
    /// Contains an enumerated list of workflow activity events.
    /// </summary>
    public enum WorkflowActivityEventType
    {
        /// <summary>
        /// The Pre-activity execution event.
        /// </summary>
        EnterActivity,

        /// <summary>
        /// The post-activity execution event.
        /// </summary>
        ExitActivity,

        /// <summary>
        /// The event is related to a command.
        /// </summary>
        Command,

        /// <summary>
        /// The event is related to an activity timer event firing.
        /// </summary>
        Timer
    }

    /// <summary>
    /// Contains an enumerated list of workflow activity event actions
    /// </summary>
    public enum WorkflowActivityEventAction
    {
        /// <summary>
        /// The Activity action will e-mail assignees notifying them the activity requires their attention.
        /// </summary>
        EmailAssignees,

        /// <summary>
        /// The Activity action will e-mail the workflow owner.
        /// </summary>
        EmailOwner,

        /// <summary>
        /// The Activity action will execute a plugin specified within the parameters section of the event.
        /// </summary>
        ExecutePlugin
    }

    /// <summary>
    /// This class represents a workflow activity event model within the application.
    /// </summary>
    [XmlType("Event")]
    public class WorkflowActivityEventModel
    {
        /// <summary>
        /// Gets or sets the parent workflow activity this event is to execute on.
        /// </summary>
        public string WorkflowActivityId { get; set; }

        /// <summary>
        /// Gets or sets the event that is to be watched for the related activity.
        /// </summary>
        public WorkflowActivityEventType Event { get; set; }

        /// <summary>
        /// Gets or sets the action to execute when the activity event occurs.
        /// </summary>
        public WorkflowActivityEventAction Action { get; set; }

        /// <summary>
        /// Gets or sets optional parameter values for the activity event action.
        /// </summary>
        public string Parameters { get; set; }

        /// <summary>
        /// Gets or sets the event order in which this action is executed.
        /// </summary>
        public int EventOrder { get; set; }
    }
}