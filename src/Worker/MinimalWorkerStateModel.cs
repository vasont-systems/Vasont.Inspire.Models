//-------------------------------------------------------------
// <copyright file="MinimalWorkerStateModel.cs" company="GlobalLink Vasont">
// Copyright (c) GlobalLink Vasont. All rights reserved.
// </copyright>
//-------------------------------------------------------------
namespace Vasont.Inspire.Models.Worker
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics.CodeAnalysis;
    using System.Globalization;
    using Vasont.Inspire.Core.Errors;
    using Vasont.Inspire.Core.Properties;

    /// <summary>
    /// This class represents a minimal representation of a background worker state.
    /// </summary>
    public class MinimalWorkerStateModel
    {
        /// <summary>
        /// Gets or sets the worker cache life in minutes.
        /// </summary>
        public int CacheLifeInMinutes { get; set; }

        /// <summary>
        /// Gets or sets the tenant domain key of the owning tenant.
        /// </summary>
        public string TenantDomainKey { get; set; }

        /// <summary>
        /// Gets or sets a unique key for the worker process.
        /// </summary>
        public string Key { get; set; }

        /// <summary>
        /// Gets or sets the unique identity of the worker process.
        /// </summary>
        public Guid ProcessId { get; set; }

        /// <summary>
        /// Gets or sets the default language for the worker process.
        /// </summary>
        public string DefaultLanguage { get; set; }

        /// <summary>
        /// Gets or sets the worker state status.
        /// </summary>
        public WorkerStatus Status { get; set; }

        /// <summary>
        /// Gets or sets the date when the process was executed.
        /// </summary>
        public DateTime SubmittedUtcDate { get; set; }

        /// <summary>
        /// Gets a string of the length of time the process has been running.
        /// </summary>
        public string Runtime
        {
            get
            {
                TimeSpan span = DateTime.UtcNow - this.SubmittedUtcDate;
                return string.Format(CultureInfo.InvariantCulture, Resources.RuntimeMessageText, span.Days, span.Hours, span.Minutes, span.Seconds);
            }
        }

        /// <summary>
        /// Gets or sets a message value used for multi-purpose messaging for the process.
        /// </summary>
        public string Message { get; set; }

        /// <summary>
        /// Gets or sets a list of issues from the import process.
        /// </summary>
        public List<ErrorMessage> Issues { get; set; } = new List<ErrorMessage>();
    }

    /// <summary>
    /// This class represents worker state within the application that contains an additional. model object.
    /// </summary>
    /// <typeparam name="T">Contains the object type of the additional worker model.</typeparam>
    [SuppressMessage("StyleCop.CSharp.MaintainabilityRules", "SA1402:FileMayOnlyContainASingleClass", Justification = "Class files would be named the same.")]
    public sealed class MinimalWorkerStateModel<T> : MinimalWorkerStateModel
    {
        #region Public Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="MinimalWorkerStateModel{T}" /> class.
        /// </summary>
        public MinimalWorkerStateModel()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MinimalWorkerStateModel{T}" /> class.
        /// </summary>
        /// <param name="model">Contains any additional model used with the worker.</param>
        public MinimalWorkerStateModel(T model)
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