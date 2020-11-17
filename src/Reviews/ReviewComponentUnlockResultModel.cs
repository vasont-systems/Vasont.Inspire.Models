//-----------------------------------------------------------------------
// <copyright file="ReviewComponentUnlockResultModel.cs" company="GlobalLink Vasont">
// Copyright (c) GlobalLink Vasont. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace Vasont.Inspire.Models.ReviewComponents
{
    /// <summary>
    /// This class contains values used within the Unlocking of a review component.
    /// </summary>
    public class ReviewComponentUnlockResultModel
    {
        /// <summary>
        /// Gets or sets the unique identity of the unlocking review component.
        /// </summary>
        public long ReviewComponentId { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the unlock was complete.
        /// </summary>
        public bool Success { get; set; }
    }
}
