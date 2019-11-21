//-------------------------------------------------------------
// <copyright file="MinimalComponentAutoRepairStateModel.cs" company="GlobalLink Vasont">
// Copyright (c) GlobalLink Vasont. All rights reserved.
// </copyright>
//-------------------------------------------------------------
namespace Vasont.Inspire.Models.Components
{
    using System.Collections.Generic;

    /// <summary>
    /// This class contains the absolute maximum information we can send the client at this time.
    /// </summary>
    public class MinimalComponentAutoRepairStateModel
    {
        /// <summary>
        /// Gets or sets a list of components to be imported within the import process. 
        /// </summary>
        public List<long> ComponentIds { get; set; } = new List<long>();

        /// <summary>
        /// Gets or sets a value indicating whether the batch repair was successful.
        /// </summary>
        public bool IsRepairSuccessful { get; set; }
    }
}
