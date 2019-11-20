//---------------------------------------------------------------------------
// <copyright file="FolderComponentsResultModel.cs" company="Vasont Systems">
// Copyright (c) Vasont Systems. All rights reserved.
// </copyright>
//---------------------------------------------------------------------------
namespace Vasont.Inspire.Models.Components
{
    using System.Collections.Generic;

    /// <summary>
    /// This class represents the results of a folder component query request.
    /// </summary>
    public class FolderComponentsResultModel
    {
        /// <summary>
        /// Gets or sets the total number of components in the folder.
        /// </summary>
        public long TotalCount { get; set; }

        /// <summary>
        /// Gets or sets the resulting components from the query request.
        /// </summary>
        public List<MinimalComponentModel> Components { get; set; }
    }
}
