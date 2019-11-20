//-----------------------------------------------------------------------
// <copyright file="BatchComponentsResultModel.cs" company="Vasont Systems">
// Copyright (c) Vasont Systems. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------
namespace Vasont.Inspire.Models.Components
{
    using System.Collections.Generic;

    /// <summary>
    /// This class represents the components returned from the batch component API.
    /// </summary>
    public class BatchComponentsResultModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BatchComponentsResultModel"/> class.
        /// </summary>
        public BatchComponentsResultModel()
            : this(new List<MinimalComponentModel>())
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BatchComponentsResultModel"/> class.
        /// </summary>
        /// <param name="components">Contains a list of <see cref="MinimalComponentModel"/> objects.</param>
        public BatchComponentsResultModel(List<MinimalComponentModel> components)
        {
            this.Components = components;
        }

        /// <summary>
        /// Gets the list of component identifiers.
        /// </summary>
        public List<MinimalComponentModel> Components { get; }
    }
}
