﻿//---------------------------------------------------------------------------
// <copyright file="WorkflowNextTransitionModel.cs" company="GlobalLink Vasont">
// Copyright (c) GlobalLink Vasont. All rights reserved.
// </copyright>
//---------------------------------------------------------------------------
namespace Vasont.Inspire.Models.Workflow
{
    using System;
    using System.Collections.Generic;
    using Common;

    /// <summary>
    /// This class is a model of a workflow transition that can be chosen from the completion of another activity.
    /// </summary>
    public class WorkflowNextTransitionModel
    {
        /// <summary>
        /// Gets or sets the identity of the workflow transition.
        /// </summary>
        public string WorkflowTransitionId { get; set; }

        /// <summary>
        /// Gets or sets the unique identity of the related workflow.
        /// </summary>
        public string WorkflowId { get; set; }

        /// <summary>
        /// Gets or sets the transition name.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the transition description.
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets the identity of the next activity associated with this transition.
        /// </summary>
        public string NextActivityId { get; set; }

        /// <summary>
        /// Gets or sets the name of the next activity associated with this transition.
        /// </summary>
        public string NextActivityName { get; set; }

        /// <summary>
        /// Gets or sets the due date of the next activity associated with this transition.
        /// </summary>
        public DateTime? NextActivityDueDate { get; set; }

        /// <summary>
        /// Gets or sets a list of users who are allowed to be assigned to this activity.
        /// </summary>
        public List<WorkflowMemberModel> Members { get; set; } = new List<WorkflowMemberModel>();

        /// <summary>
        /// Gets or sets the coordinates.
        /// </summary>
        public CoordinatesModel Coordinates { get; set; } = new CoordinatesModel();
    }
}