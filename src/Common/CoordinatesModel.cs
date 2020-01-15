//-------------------------------------------------------------
// <copyright file="CoordinatesModel.cs" company="GlobalLink Vasont">
// Copyright (c) GlobalLink Vasont. All rights reserved.
// </copyright>
//-------------------------------------------------------------
namespace Vasont.Inspire.Models.Common
{
    /// <summary>
    /// This class contains coordinate information and settings to be used by models requiring a graphical interface.
    /// </summary>
    public class CoordinatesModel
    {
        /// <summary>
        /// Gets or sets the x coordinate.
        /// </summary>
        public decimal XCoordinate { get; set; } = 0;

        /// <summary>
        /// Gets or sets the y coordinate.
        /// </summary>
        public decimal YCoordinate { get; set; } = 0;

        /// <summary>
        /// Gets or sets the width.
        /// </summary>
        public decimal Width { get; set; } = 100;

        /// <summary>
        /// Gets or sets the height.
        /// </summary>
        public decimal Height { get; set; } = 30;
    }
}