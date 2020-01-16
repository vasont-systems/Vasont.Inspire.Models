//-------------------------------------------------------------
// <copyright file="BranchReferenceModel.cs" company="GlobalLink Vasont">
// Copyright (c) GlobalLink Vasont. All rights reserved.
// </copyright>
//-------------------------------------------------------------
namespace Vasont.Inspire.Models.Components
{
    /// <summary>
    /// This class model represents a component reference found within the data repository to be used for branching.
    /// </summary>
    public class BranchReferenceModel
    {
        /// <summary>
        /// Gets or sets the target component identity.
        /// </summary>
        public long? TargetComponentId { get; set; }

        /// <summary>
        /// Gets or sets the target component name.
        /// </summary>
        public string TargetName { get; set; }

        /// <summary>
        /// Gets or sets the target component file name.
        /// </summary>
        public string TargetFileName { get; set; }

        /// <summary>
        /// Gets or sets the target component type.
        /// </summary>
        public string TargetType { get; set; }

        /// <summary>
        /// Gets or sets the target component text snippet.
        /// </summary>
        public string TargetSnippet { get; set; }
    }
}
