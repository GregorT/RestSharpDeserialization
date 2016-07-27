using RestSharp.Deserializers;
using System;
using System.Collections.Generic;

namespace DeSerializationOfJson.Models
{
    /// <summary>
    /// File Collection model
    /// </summary>
    public class FileCollectionModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FileCollectionModel"/> class.
        /// </summary>
        public FileCollectionModel()
        {
            FileList = new List<Tuple<string, FileItemModel>>();
        }

        /// <summary>
        /// Gets or sets the title.
        /// </summary>
        /// <value>
        /// The title.
        /// </value>
        [DeserializeAs(Name ="title")]
        public string Title { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this instance has title.
        /// </summary>
        /// <value>
        ///   <c>true</c> if this instance has title; otherwise, <c>false</c>.
        /// </value>
        [DeserializeAs(Name = "has_title")]
        public bool HasTitle { get; set; }

        /// <summary>
        /// Gets or sets the file list.
        /// </summary>
        /// <value>
        /// The file list.
        /// </value>
        public List<Tuple<string, FileItemModel>> FileList { get; set; }
    }
}
