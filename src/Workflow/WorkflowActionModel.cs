//-------------------------------------------------------------------
// <copyright file="WorkflowActionModel.cs" company="Vasont Systems">
// Copyright (c) Vasont Systems. All rights reserved.
// </copyright>
//-------------------------------------------------------------------
namespace Vasont.Inspire.Models.Workflow
{
    using System;
    using System.Xml.Serialization;

    /// <summary>
    /// This class is a model of a workflow action.
    /// </summary>
    [XmlType("Action")]
    public class WorkflowActionModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WorkflowActionModel"/> class.
        /// </summary>
        public WorkflowActionModel()
        {
            this.WorkflowActionId = "_" + Guid.NewGuid().ToString();
        }
     
        /// <summary>
        /// Gets or sets the unique workflow action identity.
        /// </summary>
        [XmlAttribute(AttributeName = "id")]
        public string WorkflowActionId { get; set; }

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
    }
}