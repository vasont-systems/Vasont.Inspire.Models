//-------------------------------------------------------------
// <copyright file="WorkerStateModel.cs" company="GlobalLink Vasont">
// Copyright (c) GlobalLink Vasont. All rights reserved.
// </copyright>
//-------------------------------------------------------------
namespace Vasont.Inspire.Models.Worker
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics.CodeAnalysis;
    using System.Globalization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using Vasont.Inspire.Core.Errors;
    using Vasont.Inspire.Core.Properties;

    /// <summary>
    /// Contains an enumerated list of worker process statuses.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    [Obsolete("Use local enums", false)]
    public enum WorkerStatus
    {
        /// <summary>
        /// The default status
        /// </summary>
        Idle,

        /// <summary>
        /// The worker is working.
        /// </summary>
        Working,

        /// <summary>
        /// The worker is complete.
        /// </summary>
        Complete,

        /// <summary>
        /// The worker has failed.
        /// </summary>
        Failed
    }

    /// <summary>
    /// This class represents a baseline worker state model.
    /// </summary>
    [Obsolete("Use local DTOs", false)]
    public class WorkerStateModel : MinimalWorkerStateModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WorkerStateModel" /> class.
        /// </summary>
        public WorkerStateModel()
        {
            this.Status = WorkerStatus.Idle;
            this.ProcessId = Guid.NewGuid();
            this.Issues = new List<ErrorMessage>();
            this.SubmittedUtcDate = DateTime.UtcNow;
        }

        /// <summary>
        /// Gets or sets a value indicating whether an e-mail notification shall be sent to the submitting user once the import process is completed.
        /// </summary>
        public bool SendResultNotification { get; set; }

        /// <summary>
        /// Gets or sets the submitter user name.
        /// </summary>
        public string SubmittedByUserName { get; set; }

        /// <summary>
        /// Gets or sets the worker path for this process.
        /// </summary>
        public string WorkerPath { get; set; }

        #region Public Methods

        /// <summary>
        /// This method is used to add an error message to the worker state model.
        /// </summary>
        /// <param name="errorMessage">Contains an instance of <see cref="ErrorMessage" /> class to add to the issues list.</param>
        public void AddIssue(ErrorMessage errorMessage)
        {
            this.Issues.Add(errorMessage);
        }

        /// <summary>
        /// This method is used to add an error message to the worker state model.
        /// </summary>
        /// <param name="messageKey">Contains the resource message key used for resource message lookup.</param>
        /// <param name="type">Contains the optional error message type.</param>
        /// <param name="parameters">Contains an optional array of parameters to add to the issue.</param>
        public void AddIssue(string messageKey, ErrorType type = ErrorType.Fatal, params object[] parameters)
        {
            if (string.IsNullOrWhiteSpace(messageKey))
            {
                throw new ArgumentNullException(nameof(messageKey));
            }

            string message = Resources.ResourceManager.GetString(messageKey, Resources.Culture);

            if (!string.IsNullOrWhiteSpace(message))
            {
                if (parameters != null)
                {
                    message = string.Format(CultureInfo.InvariantCulture, message, parameters);
                }

                this.AddIssue(new ErrorMessage(message, type));
            }
        }

        #endregion
    }

    /// <summary>
    /// This class represents worker state within the application that contains an additional model object.
    /// </summary>
    /// <typeparam name="T">Contains the object type of the additional worker model.</typeparam>
    [SuppressMessage("StyleCop.CSharp.MaintainabilityRules", "SA1402:FileMayOnlyContainASingleClass", Justification = "Class files would be named the same.")]
    [Obsolete("Use local DTO", false)]
    public sealed class WorkerStateModel<T> : WorkerStateModel
    {
        #region Public Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="WorkerStateModel{T}" /> class.
        /// </summary>
        public WorkerStateModel()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WorkerStateModel{T}" /> class.
        /// </summary>
        /// <param name="model">Contains any additional model used with the worker.</param>
        public WorkerStateModel(T model)
        {
            this.Model = model;
        }

        #endregion

        /// <summary>
        /// Gets or sets the optional model for the worker.
        /// </summary>
        public T Model { get; set; }
    }
}