//-------------------------------------------------------------
// <copyright file="ComponentExternalAssetsResultModel.cs" company="GlobalLink Vasont">
// Copyright (c) GlobalLink Vasont. All rights reserved.
// </copyright>
//-------------------------------------------------------------
namespace Vasont.Inspire.Models.Components
{
    using System.Collections.Generic;

    /// <summary>
    /// This class represents the results of a component external assets query request.
    /// </summary>
    public class ComponentExternalAssetsResultModel
    {
        /// <summary>
        /// Gets or sets the total number of component external assets.
        /// </summary>
        public long TotalCount { get; set; }

        /// <summary>
        /// Gets or sets the resulting component translations from the query request.
        /// </summary>
        public List<ExternalAssetModel> ComponentExternalAssets { get; set; } = new List<ExternalAssetModel>();
    }
}