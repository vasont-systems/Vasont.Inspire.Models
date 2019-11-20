//-------------------------------------------------------------
// <copyright file="ProcessHistoricRelationsResultModel.cs" company="Vasont Systems">
// Copyright (c) Vasont Systems. All rights reserved.
// </copyright>
//-------------------------------------------------------------
namespace Vasont.Inspire.Models.Transfers
{
    using System.Collections.Generic;

    /// <summary>
    /// This class represents the results of relationship analysis on historic component content.
    /// </summary>
    public class ProcessHistoricRelationsResultModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ProcessHistoricRelationsResultModel"/> class.
        /// </summary>
        /// <param name="references">Contains an optional list of references to initialize the model.</param>
        /// <param name="missingReferences">Contains an optional list of missing references to initialize the model.</param>
        public ProcessHistoricRelationsResultModel(List<ExportHistoryComponentModel> references = null, List<MissingReferenceModel> missingReferences = null)
        {
            this.References = references ?? new List<ExportHistoryComponentModel>();
            this.MissingReferences = missingReferences ?? new List<MissingReferenceModel>();
        }

        /// <summary>
        /// Gets or sets a value indicating whether the process relations request was successful.
        /// </summary>
        public bool Success { get; set; }
        
        /// <summary>
        /// Gets a dictionary containing references processed within a process relations request.
        /// </summary>
        public List<ExportHistoryComponentModel> References { get; }

        /// <summary>
        /// Gets a dictionary containing missing references that could not be resolved within the process relationships request.
        /// </summary>
        public List<MissingReferenceModel> MissingReferences { get; }
    }
}
