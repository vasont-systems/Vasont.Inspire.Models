//-------------------------------------------------------------
// <copyright file="ReviewComponentLockModel.cs" company="GlobalLink Vasont">
// Copyright (c) GlobalLink Vasont. All rights reserved.
// </copyright>
//-------------------------------------------------------------
namespace Vasont.Inspire.Models.ReviewComponents
{
    using System;
    using Vasont.Inspire.Models.Security;

    /// <summary>
    /// This class represents a review component lock for a component within the application.
    /// </summary>
    public class ReviewComponentLockModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ReviewComponentLockModel"/> class.
        /// </summary>
        public ReviewComponentLockModel()
        {
            this.LockedBy = new MicroUserModel();
        }

        /// <summary>
        /// Gets or sets the review component identifier.
        /// </summary>
        public long ReviewComponentId { get; set; }

        /// <summary>
        /// Gets or sets the locked date information.
        /// </summary>
        public DateTime LockedDate { get; set; }

        /// <summary>
        /// Gets or sets the locked by user model information.
        /// </summary>
        public MicroUserModel LockedBy { get; set; }
    }
}