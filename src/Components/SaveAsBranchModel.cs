﻿//-------------------------------------------------------------
// <copyright file="SaveAsBranchModel.cs" company="GlobalLink Vasont">
// Copyright (c) GlobalLink Vasont. All rights reserved.
// </copyright>
//-------------------------------------------------------------
namespace Vasont.Inspire.Models.Components
{
    using System.Collections.Generic;

    /// <summary>
    /// This class contains properties and information to request the system to create a component branch.
    /// </summary>
    public class SaveAsBranchModel
    {
        /// <summary>
        /// Gets or sets the new branch name to be used.
        /// </summary>
        public string BranchName { get; set; }

        /// <summary>
        /// Gets or sets the identity of the root component of the branch.
        /// </summary>
        public long SourceComponentId { get; set; }

        /// <summary>
        /// Gets or sets the identity of the folder of the new branch.
        /// </summary>
        public long TargetFolderId { get; set; }

        /// <summary>
        /// Gets or sets the identities of the components related to the source component of the new branch.
        /// </summary>
        public List<long> ChildComponentIds { get; set; } = new List<long>();

        /// <summary>
        /// Gets or sets the identity of the project to be added to.
        /// </summary>
        public long ProjectId { get; set; }

        /// <summary>
        /// Gets or sets the identity of the project folder to be added to.
        /// </summary>
        public long ProjectFolderId { get; set; }
    }
}