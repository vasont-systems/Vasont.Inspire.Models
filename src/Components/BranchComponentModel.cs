﻿//-----------------------------------------------------------------------
// <copyright file="BranchComponentModel.cs" company="GlobalLink Vasont">
// Copyright (c) GlobalLink Vasont. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------
namespace Vasont.Inspire.Models.Components
{
    /// <summary>
    /// This class represents a component that can be branched.
    /// </summary>
    public class BranchComponentModel : MinimalComponentModel
    {
        /// <summary>
        /// Gets or sets the sequence id for the component.
        /// </summary>
        public int SequenceId { get; set; }

        /// <summary>
        /// Gets or sets the level of the component in the source component hierarchy.
        /// </summary>
        public int Level { get; set; }

        /// <summary>
        /// Gets or sets the parent component id in the source component hierarchy.
        /// </summary>
        public long? ParentId { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this branch component has a least one reference.
        /// </summary>
        public bool HasChildren { get; set; }
    }
}