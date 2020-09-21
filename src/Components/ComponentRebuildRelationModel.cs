//-------------------------------------------------------------
// <copyright file="ComponentRebuildRelationModel.cs" company="GlobalLink Vasont">
// Copyright (c) GlobalLink Vasont. All rights reserved.
// </copyright>
//-------------------------------------------------------------
namespace Vasont.Inspire.Models.Components
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    /// <summary>
    /// Contains an enumerated set of rebuild relation results.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum ComponentRebuildRelationResult
    {
        /// <summary>
        /// The component relation was successfully rebuilt.
        /// </summary>
        Success,

        /// <summary>
        /// The component relation rebuild failed.
        /// </summary>
        Failed,

        /// <summary>
        /// The component relation rebuild ignored
        /// the component should be rebuilt manually.
        /// </summary>
        Ignored
    }

    /// <summary>
    /// This class represents a component that has been rebuilt by an extract service.
    /// </summary>
    public class ComponentRebuildRelationModel
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