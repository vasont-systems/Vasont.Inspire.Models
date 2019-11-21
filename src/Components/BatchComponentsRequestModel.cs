//-----------------------------------------------------------------------
// <copyright file="BatchComponentsRequestModel.cs" company="GlobalLink Vasont">
// Copyright (c) GlobalLink Vasont. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------
namespace Vasont.Inspire.Models.Components
{
    using System.Collections.Generic;
   
    /// <summary>
    /// This class contains properties required for the batch component API.
    /// </summary>
    public class BatchComponentsRequestModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BatchComponentsRequestModel"/> class.
        /// </summary>
        public BatchComponentsRequestModel()
            : this(new List<long>())
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BatchComponentsRequestModel"/> class.
        /// </summary>
        /// <param name="componentIds">The list of component identifiers.</param>
        public BatchComponentsRequestModel(List<long> componentIds)
        {
            this.ComponentIds = componentIds;
        }

        /// <summary>
        /// Gets or sets the list of component identifiers.
        /// </summary>
        public List<long> ComponentIds { get; set; }
    }
}
