//-------------------------------------------------------------
// <copyright file="AdHocQueryFilterModel.cs" company="GlobalLink Vasont">
// Copyright (c) GlobalLink Vasont. All rights reserved.
// </copyright>
//-------------------------------------------------------------
namespace Vasont.Inspire.Models.Search
{
    using System.Collections.Generic;

    /// <summary>
    /// This class is represents an ad-hoc filter query row sent from a query interface within the application.
    /// </summary>
    public class AdHocQueryFilterModel
    {
        #region Public Constructors
        /// <summary>
        /// Initializes a new instance of the <see cref="AdHocQueryFilterModel"/> class.
        /// </summary>
        public AdHocQueryFilterModel()
        {
            this.Logic = SearchLogicOperator.And;
            this.Operator = SearchExpressionOperator.Equals;
            this.GroupedFilters = new List<AdHocQueryFilterModel>();
        }
        #endregion

        #region Public Properties
        /// <summary>
        /// Gets or sets the filter row logic operator
        /// </summary>
        public SearchLogicOperator Logic { get; set; }

        /// <summary>
        /// Gets or sets the filter name to add to the query expression.
        /// </summary>
        public string FilterId { get; set; }

        /// <summary>
        /// Gets or sets the filter operator
        /// </summary>
        public SearchExpressionOperator Operator { get; set; }

        /// <summary>
        /// Gets or sets the query filter value used to compare.
        /// </summary>
        public string Value { get; set; }

        /// <summary>
        /// Gets or sets a list of grouped filters for the given filter model.
        /// </summary>
        public List<AdHocQueryFilterModel> GroupedFilters { get; set; }
        #endregion
    }
}