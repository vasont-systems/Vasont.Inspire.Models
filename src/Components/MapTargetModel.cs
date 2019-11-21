//---------------------------------------------------------------------
// <copyright file="MapTargetModel.cs" company="GlobalLink Vasont">
// Copyright (c) GlobalLink Vasont. All rights reserved.
// </copyright>
//---------------------------------------------------------------------
namespace Vasont.Inspire.Models.Components
{
    /// <summary>
    /// This class represents a map target within a map model.
    /// </summary>
    public class MapTargetModel
    {
        /// <summary>
        /// Gets or sets the component identity of the target component.
        /// </summary>
        public long ComponentId { get; set; }

        /// <summary>
        /// Gets or sets the name of the target component.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the file name of the target component.
        /// </summary>
        public string FileName { get; set; }

        /// <summary>
        /// Gets or sets the component type info for the target component.
        /// </summary>
        public MapTargetComponentTypeModel ComponentType { get; set; }

        /// <summary>
        /// Gets or sets the component lock model
        /// </summary>
        public ComponentLockModel Lock { get; set; }
    }
}
