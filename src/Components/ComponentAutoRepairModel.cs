//-------------------------------------------------------------
// <copyright file="ComponentAutoRepairModel.cs" company="Vasont Systems">
// Copyright (c) Vasont Systems. All rights reserved.
// </copyright>
//-------------------------------------------------------------
namespace Vasont.Inspire.Models.Components
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    /// <summary>
    /// Contains an enumerated set of auto repair results.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum ComponentAutoRepairResult
    {
        /// <summary>
        /// The component relation was successfully repaired.
        /// </summary>
        Success,

        /// <summary>
        /// The component relation repair failed.
        /// </summary>
        Failed,

        /// <summary>
        /// The component relation repair ignored
        /// the component should be repaired manually.
        /// </summary>
        Ignored
    }

    /// <summary>
    /// This class represents a component that has been repaired by an extract service.
    /// </summary>
    public class ComponentAutoRepairModel
    {
        /// <summary>
        /// Gets or sets the unique identity of the component.
        /// </summary>
        public long ComponentId { get; set; }

        /// <summary>
        /// Gets or sets the name of the component.
        /// </summary>
        public string ComponentName { get; set; }

        /// <summary>
        /// Gets or sets the state of the component.
        /// </summary>
        public ComponentStateType State { get; set; }
    }
}
