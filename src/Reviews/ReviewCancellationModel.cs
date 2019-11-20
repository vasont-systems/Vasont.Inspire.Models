//-------------------------------------------------------------
// <copyright file="ReviewCancellationModel.cs" company="Vasont Systems">
// Copyright (c) Vasont Systems. All rights reserved.
// </copyright>
//-------------------------------------------------------------
namespace Vasont.Inspire.Models.Reviews
{
    /// <summary>
    /// This class represents a review cancellation request within the application.
    /// </summary>
    public class ReviewCancellationModel
    {
        /// <summary>
        /// Gets or sets the review cancellation comment.
        /// </summary>
        public string Comment { get; set; }
    }
}