//-----------------------------------------------------------
// <copyright file="DiagnosticModel.cs" company="Vasont Systems">
// Copyright (c) Vasont Systems. All rights reserved.
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
        /// Gets ot sets total memory
        /// </summary>
        public long GCTotalMemory { get; set; }

        /// <summary>
        /// Gets ot sets current process memory
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
        /// Gets or sets connection strings
        /// </summary>
        public IDictionary<string, string> ConnectionStrings { get; set; }

        /// <summary>
        /// Gets or sets the value indicating is any users found in database
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
