//------------------------------------------------------------------
// <copyright file="WorkflowStatusModel.cs" company="Vasont Systems">
// Copyright (c) Vasont Systems. All rights reserved.
// </copyright>
//------------------------------------------------------------------

namespace Vasont.Inspire.Models.Workflow
{
    using System;
    using System.Xml.Serialization;

    /// <summary>
    /// This class represents a workflow state within a workflow.
    /// </summary>
    [XmlType("Status")]
    public class WorkflowStatusModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WorkflowStatusModel"/> class.
        /// </summary>
        public WorkflowStatusModel()
        {
            this.WorkflowStatusId = "_" + Guid.NewGuid().ToString();
        }
        
        /// <summary>
        /// Gets or sets the unique identity of the workflow status.
        /// </summary>
        [XmlAttribute(AttributeName = "id")]
        public string WorkflowStatusId { get; set; }

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
    }
}