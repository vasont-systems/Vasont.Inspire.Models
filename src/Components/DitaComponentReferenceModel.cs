//-----------------------------------------------------------------------
// <copyright file="DitaComponentReferenceModel.cs" company="Vasont Systems">
// Copyright (c) Vasont Systems. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace Vasont.Inspire.Models.Components
{
    using System;

    /// <summary>
    /// This class represents a content reference within a document.
    /// </summary>
    public class DitaComponentReferenceModel : IComponentReference
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DitaComponentReferenceModel"/> class.
        /// </summary>
        /// <param name="conrefInput">Contains the initial conref input string.</param>
        /// <param name="defaultTargetName">Contains an optional default target file name for empty file positions.</param>
        public DitaComponentReferenceModel(string conrefInput = "", string defaultTargetName = "")
        {
            this.Initialize(conrefInput, defaultTargetName);
        }

        #region Public Properties

        /// <summary>
        /// Gets or sets the file name
        /// </summary>
        public string TargetName { get; set; }

        /// <summary>
        /// Gets or sets the root identity
        /// </summary>
        public string TargetRootId { get; set; }

        /// <summary>
        /// Gets or sets the element identity
        /// </summary>
        public string TargetElementId { get; set; }

        /// <summary>
        /// Gets or sets a Uri object for the reference.
        /// </summary>
        public Uri Address { get; set; }

        #endregion

        #region Public Override Methods

        /// <summary>
        /// This method is used to convert the object to a content reference pointer string.
        /// </summary>
        /// <returns>Returns the object formatted as {filename}#{rootId}/{targetId}</returns>
        public override string ToString()
        {
            string output = this.TargetName;

            if (!string.IsNullOrWhiteSpace(this.TargetRootId))
            {
                output += "#" + this.TargetRootId;

                // DITA considers a link with rootid equal to element id as invalid
                if (!string.IsNullOrWhiteSpace(this.TargetElementId) && this.TargetRootId != this.TargetElementId)
                {
                    output += "/" + this.TargetElementId;
                }
            }

            return output;
        }

        #endregion

        #region Private Methods

        /// <summary>
        /// Initializes the class properties by parsing the initial conref input value.
        /// </summary>
        /// <param name="input">Contains the input to parse.</param>
        /// <param name="defaultFileName">Contains the optional default file name.</param>
        private void Initialize(string input, string defaultFileName)
        {
            Uri outputUri;

            if (Uri.TryCreate(input, UriKind.RelativeOrAbsolute, out outputUri))
            {
                this.Address = outputUri;
            }

            if (!string.IsNullOrWhiteSpace(input))
            {
                // split to get parts
                string[] conrefParts = input.Split('#');

                if (conrefParts.Length > 0)
                {
                    this.TargetName = !string.IsNullOrWhiteSpace(conrefParts[0]) && conrefParts[0] != "." ? conrefParts[0] : defaultFileName;
                }
                else
                {
                    this.TargetName = defaultFileName;
                }

                // if we have a # marker...
                if (conrefParts.Length == 2)
                {
                    string targetPath = conrefParts[1];
                    string[] targetIds = !string.IsNullOrWhiteSpace(targetPath) ? targetPath.Split('/') : Array.Empty<string>();
                    this.TargetRootId = targetIds.Length > 0 ? targetIds[0] : string.Empty;
                    this.TargetElementId = targetIds.Length == 2 ? targetIds[1] : string.Empty;
                }
            }
        }
        #endregion
    }
}
