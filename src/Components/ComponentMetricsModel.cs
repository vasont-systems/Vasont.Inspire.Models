using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Vasont.Inspire.Core.Extensions;
using Vasont.Inspire.Core.Properties;
using Vasont.Inspire.Models.Security;

namespace Vasont.Inspire.Models.Components
{
    public class ComponentMetricsModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ComponentMetricsModel"/> class.
        /// </summary>
        public ComponentMetricsModel()
        {
            this.WordCount = 0;
            this.CharCount = 0;
            this.CharCountNoSpace = 0;
            this.FileSize = 0;
        }

        /// <summary>
        /// Gets or sets the XML Component Word Count
        /// </summary>
        public long WordCount { get; set; }

        /// <summary>
        /// Gets or sets the XML Component Character Count
        /// </summary>
        public long CharCount { get; set; }

        /// <summary>
        /// Gets or sets the XML Component Character Count Without Spaces
        /// </summary>
        public long CharCountNoSpace { get; set; }

        /// <summary>
        /// Gets or sets the Component Size
        /// </summary>
        public long FileSize { get; set; }
    }
}
