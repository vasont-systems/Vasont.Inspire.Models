//-----------------------------------------------------------
// <copyright file="DiagnosticThreading.cs" company="Vasont Systems">
// Copyright (c) Vasont Systems. All rights reserved.
// </copyright>
//-----------------------------------------------------------
namespace Vasont.Inspire.Models.Diagnostics
{
    /// <summary>
    /// This class is represents a diagnostic threading information
    /// </summary>
    public class DiagnosticThreading
    {
        /// <summary>
        /// Gets or sets minimum threads count
        /// </summary>
        public int MinimumThreads { get; set; }

        /// <summary>
        /// Gets or sets maximum threads count
        /// </summary>
        public int MaximumThreads { get; set; }

        /// <summary>
        /// Gets or sets minimum completion ports
        /// </summary>
        public int MinimumCompletionPorts { get; set; }

        /// <summary>
        /// Gets or sets maximum completion ports
        /// </summary>
        public int MaximumCompletionPorts {get; set; }

        /// <summary>
        /// Gets or sets settings max ports
        /// </summary>
        public int SettingsMaxPorts { get; set; }

        /// <summary>
        /// Gets or sets settings max parallel
        /// </summary>
        public int SettingsMaxParallel { get; set; }
    }
}