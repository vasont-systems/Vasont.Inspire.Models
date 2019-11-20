//---------------------------------------------------------------------
// <copyright file="WorkflowTemplateModel.cs" company="Vasont Systems">
// Copyright (c) Vasont Systems. All rights reserved.
// </copyright>
//---------------------------------------------------------------------
namespace Vasont.Inspire.Models.Workflow
{
    /// <summary>
    /// This class represents a component model with minimal information that will used for interaction with application user interfaces.
    /// </summary>
    public class WorkflowTemplateModel
    {
        /// <summary>
        /// Gets or sets the unique identity of the component.
        /// </summary>
        public long ComponentId { get; set; }

        /// <summary>
        /// Gets or sets the component name.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the workflow description.
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets a comma delimited list of workflow types that the template component supports.
        /// </summary>
        public string Type { get; set; }
    }
}
