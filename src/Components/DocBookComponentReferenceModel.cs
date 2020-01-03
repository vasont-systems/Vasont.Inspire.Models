//-----------------------------------------------------------------------
// <copyright file="DocBookComponentReferenceModel.cs" company="GlobalLink Vasont">
// Copyright (c) GlobalLink Vasont. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------
namespace Vasont.Inspire.Models.Components
{
    using System;
    using System.Collections.Generic;
    using System.Xml.Linq;

    /// <summary>
    /// This class represents a content reference within a document.
    /// </summary>
    public class DocBookComponentReferenceModel : IComponentReference
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DocBookComponentReferenceModel"/> class.
        /// </summary>
        /// <param name="refInput">Contains the initial conref input string.</param>
        /// <param name="fileName">Contains the filename of the current component.</param>
        /// <param name="linkMethod">Contains a value indicating the Link Method name of reference.</param>
        /// <param name="attributes">Contains an optional list of pointer type attributes on the element.</param> 
        public DocBookComponentReferenceModel(string refInput = "", string fileName = "", string linkMethod = "DocbookUri", List<XAttribute> attributes = null)
        {
            if (!string.IsNullOrEmpty(refInput))
            {
                this.LinkMethod = linkMethod;
                this.Initialize(refInput, fileName, linkMethod, attributes);
            }
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
        /// Gets or sets the element identity
        /// </summary>
        public string LinkMethod { get; set; }

        /// <summary>
        /// Gets or sets a Uri object for the reference.
        /// </summary>
        public Uri Address { get; set; }

        #endregion

        #region Public Override Methods

        /// <summary>
        /// This method is used to convert the object to a content reference pointer string.
        /// </summary>
        /// <returns>Returns the object formatted as {filename}#{targetId}</returns>
        public override string ToString()
        {
            string output = this.TargetName;

            if (!string.IsNullOrWhiteSpace(this.TargetElementId))
            {
                if (this.LinkMethod == "InternalElement" || this.LinkMethod == "ExternalElement")
                {
                    output = this.TargetElementId;
                }
                else if (!string.IsNullOrWhiteSpace(this.TargetElementId))
                {
                    output += "#" + this.TargetElementId;
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
        /// <param name="fileName">Contains the filename of the current component.</param>
        /// <param name="linkMethod">Contains a value indicating the Link Method name of reference.</param>
        /// <param name="attributes">Contains a list of pointer type</param>
        private void Initialize(string input, string fileName, string linkMethod, List<XAttribute> attributes = null)
        {
            if (string.IsNullOrEmpty(linkMethod))
            {
                linkMethod = "DocbookUri";
            }

            attributes = attributes ?? new List<XAttribute>();

            if (!string.IsNullOrWhiteSpace(input))
            {
                this.TargetRootId = null;

                // link methods have no UI to update in Inspire, fixed names
                Uri outputUri;
                switch (linkMethod)
                {
                    case "InternalElement":
                        // <xref linkend="v123"/>

                        // TargetName is always filename of the current component
                        this.TargetName = fileName;

                        // TargetElementId is always the value
                        this.TargetElementId = input;

                        if (Uri.TryCreate(fileName, UriKind.RelativeOrAbsolute, out outputUri))
                        {
                            this.Address = outputUri;
                        }

                        break;
                    case "ExternalElement":
                        // <xi:include href="filename.xml" xpointer="v123"/>
                        // TargetName is value of the Uri attribute on same element
                        // eventually attribute config should have property attribute linking type
                        var uriAttribute = attributes?.Find(x => x.Name.LocalName.Equals("href", StringComparison.OrdinalIgnoreCase));
                        this.TargetName = uriAttribute != null ? uriAttribute.Value : string.Empty;

                        // TargetElementId is always the value
                        this.TargetElementId = input;

                        if (Uri.TryCreate(fileName, UriKind.RelativeOrAbsolute, out outputUri))
                        {
                            this.Address = outputUri;
                        }

                        break;
                    case "Filename":
                        // <imagedata fileref="filename.png"/>
                        if (Uri.TryCreate(input, UriKind.RelativeOrAbsolute, out outputUri))
                        {
                            this.Address = outputUri;
                        }

                        this.TargetName = input;
                        this.TargetElementId = string.Empty;

                        break;
                    case "DocbookUri":
                        // Default Case
                        // <xref xml:href="filename.xml"/>
                        // <xref xml:href="#v123"/>
                        // <xref xml:href="filename.xml#v123"/>
                        if (Uri.TryCreate(input, UriKind.RelativeOrAbsolute, out outputUri))
                        {
                            this.Address = outputUri;
                        }

                        // split to get parts
                        string[] refParts = input.Split('#');

                        // filename
                        if (refParts.Length > 1)
                        {
                            this.TargetName = !string.IsNullOrWhiteSpace(refParts[0]) ? refParts[0] : fileName;
                            this.TargetElementId = !string.IsNullOrWhiteSpace(refParts[1]) ? refParts[1] : string.Empty;
                        }
                        else
                        {
                            // TargetName is the value
                            this.TargetName = input;
                            this.TargetElementId = string.Empty;
                        }

                        break;
                }
            }
        }
        #endregion
    }
}
