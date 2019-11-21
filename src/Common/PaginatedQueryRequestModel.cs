//-------------------------------------------------------------
// <copyright file="PaginatedQueryRequestModel.cs" company="GlobalLink Vasont">
// Copyright (c) GlobalLink Vasont. All rights reserved.
// </copyright>
//-------------------------------------------------------------
namespace Vasont.Inspire.Models.Common
{
    using System;
    using Vasont.Inspire.Core.Extensions;

    /// <summary>
    ///  This class contains parameters passed to the query for filtering.
    /// </summary>
    public class PaginatedQueryRequestModel
    {
        /// <summary>
        ///  Initializes a new instance of the <see cref="PaginatedQueryRequestModel" /> class.
        /// </summary>
        public PaginatedQueryRequestModel()
            : this(25)
        {
        }

        /// <summary>
        ///  Initializes a new instance of the <see cref="PaginatedQueryRequestModel" /> class.
        /// </summary>
        /// <param name="maxPageSize">Contains the maximum page size.</param>
        /// <param name="currentPage">Contains an optional current page number.</param>
        public PaginatedQueryRequestModel(int maxPageSize, int currentPage = 1)
        {
            this.Page = currentPage;
            this.Limit = maxPageSize;
            this.Sort = Array.Empty<string>();
            this.Dir = Array.Empty<SortDirection>();
        }

        /// <summary>
        ///  Gets or sets current page number.
        /// </summary>
        public int Page { get; set; }

        /// <summary>
        ///  Gets or sets the result limit.
        /// </summary>
        public int Limit { get; set; }

        /// <summary>
        ///  Gets or sets the name of the column to sort by.
        /// </summary>
        public string[] Sort { get; set; }

        /// <summary>
        ///  Gets or sets the sort direction.
        /// </summary>
        public SortDirection[] Dir { get; set; }
    }
}