using System.Collections.Generic;

namespace DeSerializationOfJson.Models
{
    /// <summary>
    /// Temporary object for geting json arrays
    /// </summary>
    public class TempObject
    {
        /// <summary>
        /// Gets or sets the entries.
        /// </summary>
        /// <value>
        /// The entries.
        /// </value>
        public List<List<string>> entries { get; set; }
    }
}