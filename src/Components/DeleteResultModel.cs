//-----------------------------------------------------------------------
// <copyright file="DeleteResultModel.cs" company="GlobalLink Vasont">
// Copyright (c) GlobalLink Vasont. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------
namespace Vasont.Inspire.Models.Components
{
    using System.Collections.Generic;
    using Vasont.Inspire.Models.Common;

    /// <summary>
    /// This class contains properties and information related to a component delete API call that has failed
    /// due to content within the system referencing the component to be deleted.
    /// </summary>
    public class DeleteResultModel : DeleteResultModelBase
    {
        /// <summary>
        /// Gets a list of <see cref="ComponentModel"/> objects that reference the component requested for deletion.
        /// </summary>
        public List<ComponentModel> SourceReferenceComponents { get; } = new List<ComponentModel>();
    }
}
