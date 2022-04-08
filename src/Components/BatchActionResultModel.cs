//-----------------------------------------------------------------------
// <copyright file="BatchActionResultModel.cs" company="GlobalLink Vasont">
// Copyright (c) GlobalLink Vasont. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------
namespace Vasont.Inspire.Models.Components
{
    using System.Collections.Generic;
    using Vasont.Inspire.Models.Common;

    /// <summary>
    /// This class contains properties and information related to a component API call that has failed.
    /// </summary>
    public class BatchActionResultModel : BatchActionResultModelBase
    {
        /// <summary>
        /// Gets a list of <see cref="ComponentModel"/> objects that reference the component requested for action.
        /// </summary>
        public List<ComponentModel> SourceReferenceComponents { get; } = new List<ComponentModel>();

        /// <summary>
        /// Gets a list of successful matches for the action.
        /// </summary>
        public int Matches { get; set; }
    }
}
