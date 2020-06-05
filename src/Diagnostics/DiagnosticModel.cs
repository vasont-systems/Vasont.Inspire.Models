//-----------------------------------------------------------
// <copyright file="DiagnosticModel.cs" company="GlobalLink Vasont">
// Copyright (c) GlobalLink Vasont. All rights reserved.
// </copyright>
//-----------------------------------------------------------
namespace Vasont.Inspire.Models.Diagnostics
{
    using System.Collections.Generic;

    /// <summary>
    /// This class represents a diagnostic information within the application.
    /// </summary>
    public class DiagnosticModel
    {
        /// <summary>
        /// Gets or sets total memory
        /// </summary>
        public long GCTotalMemory { get; set; }

        /// <summary>
        /// Gets or sets current process memory
        /// </summary>
        public long ProcessMemory { get; set; }

        /// <summary>
        /// Gets or sets memory cache keys
        /// </summary>
        public Dictionary<string, object>.KeyCollection CacheKeys { get; set; }

        /// <summary>
        /// Gets or sets database connection status message
        /// </summary>
        public string DatabaseConnectionTestResult { get; set; }

        /// <summary>
        /// Gets or sets the message queue count.
        /// </summary>
        public int MessageQueueCount { get; set; }

        /// <summary>
        /// Gets or sets connection strings
        /// </summary>
        public IDictionary<string, string> ConnectionStrings { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the user data was found in database.
        /// </summary>
        public bool UsersDataFound { get; set; }

        /// <summary>
        /// Gets or sets threading information
        /// </summary>
        public DiagnosticThreading Threading { get; set; }

        /// <summary>
        /// Gets or sets diagnostic settings
        /// </summary>
        public DiagnosticSettings Settings { get; set; }
    }
}