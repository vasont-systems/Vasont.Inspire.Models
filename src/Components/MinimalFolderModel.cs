﻿//-----------------------------------------------------------------------
// <copyright file="MinimalFolderModel.cs" company="Vasont Systems">
// Copyright (c) Vasont Systems. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace Vasont.Inspire.Models.Components
{
    /// <summary>
    /// This class represents a minimal component folder for use within the application.
    /// </summary>
    public class MinimalFolderModel
    {
        /// <summary>
        /// Gets or sets the unique identity of the folder.
        /// </summary>
        public long FolderId { get; set; }

        /// <summary>
        /// Gets or sets the name of the folder.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the path of the folder.
        /// </summary>
        public string Path { get; set; }
    }
}