//-----------------------------------------------------------------------
// <copyright file="BatchActionResultModelBase.cs" company="GlobalLink Vasont">
// Copyright (c) GlobalLink Vasont. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------
namespace Vasont.Inspire.Models.Common
{
    /// <summary>
    /// This abstract class defines common model properties to return during a batch action within the application.
    /// </summary>
    public abstract class BatchActionResultModelBase
    {
        /// <summary>
        /// Gets or sets the identity of the record that action was performed on.
        /// </summary>
        public long Id { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the value was successful.
        /// </summary>
        public bool Successful { get; set; }
    }
}