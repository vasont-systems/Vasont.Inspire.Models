//-------------------------------------------------------------
// <copyright file="MissingReferenceModel.cs" company="Vasont Systems">
// Copyright (c) Vasont Systems. All rights reserved.
// </copyright>
//-------------------------------------------------------------
namespace Vasont.Inspire.Models.Transfers
{
    using System;

    /// <summary>
    /// This class represents a missing reference target within an import.
    /// </summary>
    public class MissingReferenceModel
    {
        /// <summary>
        /// Gets or sets an optional changeset identity used for historic component references.
        /// </summary>
        public Guid ChangesetId { get; set; }

        /// <summary>
        /// Gets or sets the component identity of the source component. 
        /// </summary>
        public long SourceComponentId { get; set; }

        /// <summary>
        /// Gets or sets the source file name.
        /// </summary>
        public string SourceFileName { get; set; }

        /// <summary>
        /// Gets or sets the missing target file name.
        /// </summary>
        public string TargetFileName { get; set; }
    }
}