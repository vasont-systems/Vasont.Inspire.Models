//-----------------------------------------------------------------------
// <copyright file="EventLogModel.cs" company="GlobalLink Vasont">
// Copyright (c) GlobalLink Vasont. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------
namespace Vasont.Inspire.Models.Logging
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using Vasont.Inspire.Core.Errors;
    using Vasont.Inspire.Core.Extensions;
    using Vasont.Inspire.Core.Properties;

    /// <summary>
    /// Contains an enumerated list of event logging levels.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum EventLogLevel
    {
        /// <summary>
        /// Display all warning levels.
        /// </summary>
        All = 0,

        /// <summary>
        /// Designates fine-grained informational events that are useful during application debugging.
        /// </summary>
        [LocalizedDescription(ResourceKeys.LabelDebugText)]
        Debug,

        /// <summary>
        /// Designates informational events not related to a specific issue.
        /// </summary>
        [LocalizedDescription(ResourceKeys.LabelInformationText)]
        Info,

        /// <summary>
        /// Designates potentially harmful situations.
        /// </summary>
        [LocalizedDescription(ResourceKeys.LabelWarningText)]
        Warn,

        /// <summary>
        /// Designates error events that might still allow the application to continue running.
        /// </summary>
        [LocalizedDescription(ResourceKeys.LabelErrorText)]
        Error,

        /// <summary>
        /// Designates very severe error events that will presumably lead the application to abort.
        /// </summary>
        [LocalizedDescription(ResourceKeys.LabelFatalText)]
        Fatal,
    }

    /// <summary>
    /// This class represents an event log entry within the application.
    /// </summary>
    public class EventLogModel
    {
        /// <summary>
        /// Gets or sets the event identifier.
        /// </summary>
        /// <value>The event identifier.</value>
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public long EventId { get; set; }

        /// <summary>
        /// Gets or sets the event date.
        /// </summary>
        /// <value>The event date.</value>
        public DateTime EventDate { get; set; }

        /// <summary>
        /// Gets or sets the category.
        /// </summary>
        /// <value>The category.</value>
        [Column(TypeName = "varchar(20)")]
        public ErrorCategory Category { get; set; }

        /// <summary>
        /// Gets or sets the log level.
        /// </summary>
        /// <value>The log level.</value>
        [Column(TypeName = "varchar(30)")]
        public EventLogLevel LogLevel { get; set; }

        /// <summary>
        /// Gets or sets the thread name of the logger.
        /// </summary>
        /// <value>The thread name of the logger.</value>
        [StringLength(150)]
        public string ThreadName { get; set; }

        /// <summary>
        /// Gets or sets the name of the logger.
        /// </summary>
        /// <value>The name of the logger.</value>
        [StringLength(150)]
        public string LoggerName { get; set; }

        /// <summary>
        /// Gets or sets the message.
        /// </summary>
        /// <value>The message.</value>
        [StringLength(1000)]
        public string Message { get; set; }

        /// <summary>
        /// Gets or sets the remote address.
        /// </summary>
        /// <value>The remote address.</value>
        [StringLength(15)]
        public string RemoteAddress { get; set; }

        /// <summary>
        /// Gets or sets the type of the URL request.
        /// </summary>
        /// <value>The type of the URL request.</value>
        [StringLength(10)]
        public string UrlRequestType { get; set; }

        /// <summary>
        /// Gets or sets the request URL.
        /// </summary>
        /// <value>The request URL.</value>
        [StringLength(500)]
        public string RequestUrl { get; set; }

        /// <summary>
        /// Gets or sets the stack trace.
        /// </summary>
        /// <value>The stack trace.</value>
        [StringLength(4000)]
        public string StackTrace { get; set; }
    }
}