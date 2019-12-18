//-----------------------------------------------------------------------
// <copyright file="ErrorResponseModel.cs" company="GlobalLink Vasont">
// Copyright (c) GlobalLink Vasont. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------
namespace Vasont.Inspire.Models.Common
{
    using System.Collections.Generic;

    /// <summary>
    /// This class is used as the Error Response Model 
    /// </summary>
    public class ErrorResponseModel
    {
        /// <summary>
        /// Gets the error messages.
        /// </summary>
        public List<ErrorModel> Messages { get; } = new List<ErrorModel>();

        /// <summary>
        /// Gets or sets a value indicating whether this instance has unhandled exception.
        /// </summary>
        /// <value>
        /// <c>true</c> if this instance has unhandled exception; otherwise, <c>false</c>.
        /// </value>
        public bool HasUnhandledException { get; set; }
    }
}
