//-----------------------------------------------------------------------
// <copyright file="ComponentStandards.cs" company="GlobalLink Vasont">
// Copyright (c) GlobalLink Vasont. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------
namespace Vasont.Inspire.Models.Common
{
    using System;

    /// <summary>
    /// This class contains constants containing component standards.
    /// </summary>
    public static class ComponentStandards
    {
        /// <summary>
        /// Contains the default DITA multi-value attribute value delimiter.
        /// </summary>
        public const char DitaDefaultDelimiter = ' ';

        /// <summary>
        /// Contains the default DocBook multi-value attribute value delimiter.
        /// </summary>
        public const char DocBookDefaultDelimiter = ' ';

        /// <summary>
        /// Contains the key name for the DITA 1.0 standard.
        /// </summary>
        public const string Dita10Standard = "DITA_1.0";

        /// <summary>
        /// Contains the key name for the DITA 1.1 standard.
        /// </summary>
        public const string Dita11Standard = "DITA_1.1";

        /// <summary>
        /// Contains the key name for the DITA 1.2 standard.
        /// </summary>
        public const string Dita12Standard = "DITA_1.2";

        /// <summary>
        /// Contains the key name for the DITA 1.3 standard.
        /// </summary>
        public const string Dita13Standard = "DITA_1.3";

        /// <summary>
        /// Contains the key name for the DocBook 5.0 standard.
        /// </summary>
        public const string DocBook5Standard = "DOCBOOK_5.0";

        /// <summary>
        /// Contains the key name for the Inspire Workflow 1.0 standard.
        /// </summary>
        public const string InspireWorkflow10Standard = "INSPIRE_WORKFLOW_1.0";

        /// <summary>
        /// Contains the key name for the Taxonomy SKOS standard.
        /// </summary>
        public const string SKOS = "SKOS";

        /// <summary>
        /// Contains the Id attribute name for the schema standard.
        /// </summary>
        public const string IdAttributeName = "id";

        /// <summary>
        /// Gets the map document type names.
        /// </summary>
        public static string[] MapDocumentTypeNames { get; } = { "map", "bookmap", "subjectScheme" };

        /// <summary>
        /// This method is used to return the delimiter of choice for the specified schema standard.
        /// </summary>
        /// <param name="schemaStandardName">Contains the schema standard.</param>
        /// <returns>Returns the delimiter string.</returns>
        public static char MultiValueDelimiter(this string schemaStandardName)
        {
            char delimiter;

            switch (schemaStandardName)
            {
                case Dita10Standard:
                case Dita11Standard:
                case Dita12Standard:
                case Dita13Standard:
                    delimiter = DitaDefaultDelimiter;
                    break;

                case DocBook5Standard:
                    delimiter = DocBookDefaultDelimiter;
                    break;

                default:
                    throw new NotImplementedException(schemaStandardName);
            }

            return delimiter;
        }
    }
}