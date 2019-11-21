//--------------------------------------------------------------------------
// <copyright file="ComponentHistoryQueryModel.cs" company="GlobalLink Vasont">
// Copyright (c) GlobalLink Vasont. All rights reserved.
// </copyright>
//--------------------------------------------------------------------------
namespace Vasont.Inspire.Models.Versioning
{
    using Common;

    /// <summary>
    /// This model class represents parameters passed in from a paging grid listing a component's history.
    /// </summary>
    public sealed class ComponentHistoryQueryModel : PaginatedQueryRequestModel
    {
        /// <summary>
        /// Gets or sets the component to retrieve history on.
        /// </summary>
        public long ComponentId { get; set; }
    }
}
