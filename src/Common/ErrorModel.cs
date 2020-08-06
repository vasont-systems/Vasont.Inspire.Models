//-----------------------------------------------------------------------
// <copyright file="ErrorModel.cs" company="GlobalLink Vasont">
// Copyright (c) GlobalLink Vasont. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------
namespace Vasont.Inspire.Models.Common
{
    using System;
    using Core.Errors;

    /// <summary>
    /// This class represents an error message within the <see cref="ErrorResponseModel" /> class.
    /// </summary>
    public class ErrorModel
    {
        #region Public Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="ErrorModel" /> class.
        /// </summary>
        public ErrorModel()
            : this(string.Empty, ErrorType.Warning, DateTime.UtcNow, string.Empty)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ErrorModel" /> class.
        /// </summary>
        /// <param name="message">Contains the error message text.</param>
        /// <param name="type">Contains the error message type.</param>
        /// <param name="eventDate">Contains the date time when the error was created.</param>
        /// <param name="stackTrace">Contains an error stack trace message.</param>
        /// <param name="propertyName">Contains the property name for validation errors.</param>
        public ErrorModel(string message, ErrorType type, DateTime eventDate, string stackTrace, string propertyName = "")
        {
            this.Message = message;
            this.ErrorType = type;
            this.PropertyName = propertyName;
            this.StackTrace = stackTrace;
            this.EventDate = eventDate;
        }

        #endregion

        #region Public Properties

        /// <summary>
        /// Gets or sets the error message type.
        /// </summary>
        public ErrorType ErrorType { get; set; }

        /// <summary>
        /// Gets or sets the error message text.
        /// </summary>
        public string Message { get; set; }

        /// <summary>
        /// Gets or sets a related property name.
        /// </summary>
        public string PropertyName { get; set; }

        /// <summary>
        /// Gets or sets the date time when the error was generated.
        /// </summary>
        public DateTime EventDate { get; set; }

        /// <summary>
        /// Gets or sets the error stack trace generated if any.
        /// </summary>
        public string StackTrace { get; set; }

        #endregion
    }
}