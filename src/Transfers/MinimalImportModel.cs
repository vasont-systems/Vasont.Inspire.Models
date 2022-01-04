//-------------------------------------------------------------
// <copyright file="MinimalImportModel.cs" company="GlobalLink Vasont">
// Copyright (c) GlobalLink Vasont. All rights reserved.
// </copyright>
//-------------------------------------------------------------
namespace Vasont.Inspire.Models.Transfers
{
    /// <summary>
    /// This class represents a minimal export model for use within the application.
    /// </summary>
    public class MinimalImportModel
    {
        /// <summary>
        /// Gets or sets the unique identity of the import.
        /// </summary>
        public long ImportId { get; set; }

        /// <summary>
        /// Gets or sets the name of the import.
        /// </summary>
        public string Name { get; set; }
    }
}