//----------------------------------------------------------------------
// <copyright file="ReviewChangedComponentQueryModel.cs" company="Vasont Systems">
// Copyright (c) Vasont Systems. All rights reserved.
// </copyright>
//----------------------------------------=-----------------------------
namespace Vasont.Inspire.Models.Reviews
{
    using System;

    /// <summary>
    /// This class contains parameters passed to the query for retrieving review components
    /// that got updated after a particular timestamp.
    /// </summary>
    public class ReviewChangedComponentQueryModel
    {
        /// <summary>
        /// Gets or sets the identity of the Review to search components on.
        /// </summary>
        public long ReviewId { get; set; }

        /// <summary>
        /// Gets or sets the threshold date time from which to check for changed component content.
        /// </summary>
        public DateTime CompareDate { get; set; }
    }
}