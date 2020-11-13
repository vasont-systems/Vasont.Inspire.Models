//-----------------------------------------------------------------------
// <copyright file="RestoreComponentResultModel.cs" company="GlobalLink Vasont">
// Copyright (c) GlobalLink Vasont. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------
namespace Vasont.Inspire.Core.Versioning.Models
{
    using System.Collections.Generic;

    /// <summary>
    /// This class represents a component or history changeset restore result.
    /// </summary>
    public class RestoreComponentResultModel
    {
        /// <summary>
        /// Gets or sets a value indicating whether the request was successful.
        /// </summary>
        public bool Success { get; set; }

        /// <summary>
        /// Gets or sets a list of folder ids that could not be restored.
        /// </summary>
        public List<long> InvalidFolderIds { get; set; }
    }
}
